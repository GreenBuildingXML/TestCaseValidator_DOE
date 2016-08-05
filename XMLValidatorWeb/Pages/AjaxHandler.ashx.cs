using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XMLValidatorWeb.SupportFiles;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.IO;
using System.Xml;
using DOEgbXML;
using log4net;

namespace XMLValidatorWeb
{
    /// <summary>
    /// Summary description for AjaxHandler
    /// </summary>
    public class AjaxHandler : IHttpHandler
    {
        private static readonly ILog logger =
           LogManager.GetLogger(typeof(XMLParser));

        public void ProcessRequest(HttpContext context)
        {
            var formdata = context.Request.Form;
            string testcaseName = formdata["testcase"].Replace('+',' ');
            string schemaversion = formdata["schema"];
            gbXMLReport gbr = new gbXMLReport();
            gbr.gbxml_testcase = testcaseName;
            gbr.gbxml_version = schemaversion;
            
            logger.Info("Received XML file from user at UTC time " + DateTime.UtcNow);
            var file = context.Request.Files[0];
            if (file.ContentType == "text/xml")
            {
                logger.Info("File has extension XML.");
                DOEgbXMLValidator val = new DOEgbXMLValidator(schemaversion);
                XMLParser parser = new XMLParser();
                //if there is a file
                //valadate it by pass in input stream as xmlreader
                Stream responseStream = file.InputStream;
                XmlReader xmlreader = XmlReader.Create(responseStream);

                //if it is not valid
                if (!val.IsValidXmlEx(xmlreader) || val.nErrors > 0 || val.nWarnings > 0)
                {
                    //if (PrintFriendlyButton != null)
                    //    PrintFriendlyButton.Visible = false;

                    //if (DownloadLogButton != null)
                    //    DownloadLogButton.Visible = false;


                    //setup errorlog
                    if (val.nErrors > 0 || val.nWarnings > 0)
                    {
                        gbr.XMLSchemaErrors = val.nErrors.ToString();
                        gbr.XMLSchemaWarnings = val.nWarnings.ToString();
                        logger.Info("Found " + val.nErrors + " Errors and " + val.nWarnings + " Warnings " + val.Errors);
                        gbr.message = val.Errors;
                        gbr.schema_compliance_results = "FAIL";
                        gbr.detailed_compliance_results = "DID NOT ATTEMPT DUE TO SCHEMA FAILURE";
                        
                    }
                    else
                    {
                        gbr.XMLSchemaWarnings = "Infinity";
                        gbr.XMLSchemaErrors = "Infinity";

                        logger.Info("Your XML File is severely deficient structurally.  It may be missing element tags or is not valid XML.  The test has failed. " + val.BigError);
                        gbr.message = "Your XML File is severely deficient structurally.";
                        gbr.schema_compliance_results = "FAIL";
                        gbr.detailed_compliance_results = "DID NOT ATTEMPT DUE TO SCHEMA FAILURE";
                    }
                }
                else{
                    //the xml itself is totally valid
                    gbr.schema_compliance_results = "PASS";
                    gbr.message = "The XML uploaded is validated against schema " + gbr.gbxml_version;
                    gbr.XMLSchemaErrors = val.nErrors.ToString();
                    gbr.XMLSchemaWarnings = val.nWarnings.ToString();

                    //run test

                    responseStream.Position = 0;
                    XmlReader xmlreader2 = XmlReader.Create(responseStream);
                    //start test
                    parser.StartTest(xmlreader2, testcaseName, ref gbr);

                    //see if any of the PassOverall are failed
                    var campusProps = gbr.CampusReport;
                    var surffailures = campusProps.SurfacesReport.FindAll(x => x.FoundMatch == false);
                    if (surffailures.Count > 0) gbr.detailed_compliance_results = "FAIL";
                    var spacefailures = campusProps.SpacesReport.FindAll(x => x.FoundMatch == false);
                    if (spacefailures.Count > 0) gbr.detailed_compliance_results = "FAIL";
                    var surfsummaryfail = campusProps.SurfacesSummary.FindAll(x => x.PassedAllTests == false);
                    if (surfsummaryfail.Count > 0) gbr.detailed_compliance_results = "FAIL";
                    var spacesummaryfail = campusProps.SpacesSummary.FindAll(x => x.PassedAllTests == false);
                    if (spacesummaryfail.Count > 0) gbr.detailed_compliance_results = "FAIL";
                    //TODO: building summary, stories summary
                }
            }
            else{
                //the stuff is not even xml
                logger.Info("Your file does not end in .xml");
                gbr.message = "The file does not end in .xml";
                gbr.schema_compliance_results = "FAIL";
            }

            context.Response.ContentType = "application/json";
            context.Response.Write(JsonConvert.SerializeObject(gbr));
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}