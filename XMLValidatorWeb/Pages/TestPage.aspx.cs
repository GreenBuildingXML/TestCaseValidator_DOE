using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using DOEgbXML;
using System.Xml;
using System.IO;
using System.Web.Services;
using Newtonsoft.Json.Linq;
using XMLValidatorWeb.SupportFiles;
using System.Web;
using System.Reflection;

namespace XMLValidatorWeb.Pages
{
    public partial class TestPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //create testlist for creating dropdown list iteams dynamically
            DOEgbXMLTestDetail testList = new DOEgbXMLTestDetail();
            testList.InitializeTestResultStrings();

            //create dropdownlist items base on the tests
            if (DropDownList1 != null)
            {
                string selectedValue = DropDownList1.SelectedValue;

                //clear all iteam
                DropDownList1.Items.Clear();

                foreach (DOEgbXMLTestDetail detail in testList.TestDetailList)
                    //if test is the one selected before select it
                    if (detail.testName == selectedValue)
                    {
                        DropDownList1.Items.Add(new ListItem(detail.testName, detail.testName, true));
                        DropDownList1.SelectedValue = selectedValue;
                    }
                    else
                        DropDownList1.Items.Add(new ListItem(detail.testName, detail.testName));
            }

            if (DropDownList2 != null)
            {
                string selectedValue = DropDownList2.SelectedValue;

                //clear all iteam
                DropDownList2.Items.Clear();
                //get all of the available XSDs
                var root = AppDomain.CurrentDomain.BaseDirectory;
                var path = root + "SupportFiles//XSD";
                string[] files = Directory.GetFiles(path, "*.xsd");
                for(int i = 0; i < files.Length; i++)
                    files[i] = Path.GetFileName(files[i]);


                foreach (string file in files)
                    //if test is the one selected before select it
                    if (file == selectedValue)
                    {
                        DropDownList2.Items.Add(new ListItem(file, file, true));
                        DropDownList2.SelectedValue = selectedValue;
                    }
                    else
                        DropDownList2.Items.Add(new ListItem(file, file));
            }

            if (TestSummuryLabel != null)
            {
                //show the test summary of the selected test
                foreach (DOEgbXMLTestDetail detail in testList.TestDetailList)
                    if (detail.testName == DropDownList1.SelectedValue)
                    {
                        TestSummuryLabel.Text = detail.testSummary;
                        break;
                    }
            }
        }

        [WebMethod]
        public static CampusReport UploadTest(HttpContext context)
        {
            var r = context;
            CampusReport c = new CampusReport();
            //if there is a file
            //valadate it by pass in input stream as xmlreader

            return c;
        }

        [WebMethod]
        public static string GetResults()
        {
            //open log file and save as a string
            try
            {
                var root = AppDomain.CurrentDomain.BaseDirectory;
                string path =  root+"log-file.txt";
                string logblog = File.ReadAllText(path);
                int len = logblog.Length;
                return logblog;
            }
            catch(Exception e)
            {
                return "Error:  We're sorry, we could not read this test's log file.  Please contact gbxml.org to report this problem.";
            }
        }

        [WebMethod]
        public static string GetErrorSummary()
        {
            try
            {
                var root = AppDomain.CurrentDomain.BaseDirectory;
                string readpath = root + "log-file.txt";
                string writepath = root + "log-file-summary.txt";

                List<string> tempStrings = new List<string>();
                bool write = false;
                bool errors = false;
                int startIndex = 0;
                int linecount = 0;
                foreach (string line in File.ReadLines(readpath))
                {
                    Match m = Regex.Match(line, "START:");
                    if (m.Success)
                    {
                        startIndex = tempStrings.Count == 0 ? 0 : tempStrings.Count; //designed to keep the list short
                        write = true;
                        linecount = 0;
                    }
                    if (write)
                    {
                        tempStrings.Add(line);
                        linecount++;
                    }
                    Match errormatch = Regex.Match(line, "TEST FILE FAILURE|FATAL"); //removed MATCH FAILED as this is only a failure of SurfaceMatch subtests, not the whole test
                    if (errormatch.Success)
                    {
                        errors = true;
                    }
                    Match mend = Regex.Match(line, "END:");
                    if (mend.Success)
                    {
                        if(!errors)
                        {
                            tempStrings.RemoveRange(startIndex, linecount);
                        }
                        write = false;
                        errors = false;
                    }
                    
                }

                if(tempStrings.Count > 0)
                {
                    using (StreamWriter writetext = new StreamWriter(writepath))
                    {
                        foreach (string line in tempStrings)
                        {
                            writetext.WriteLine(line);
                        }
                    }

                    readpath = writepath;
                    string logsummary = File.ReadAllText(readpath);
                    return logsummary;
                }
                else
                {
                    return "Note for user.  There are no errors to report!";
                }
                
                
            }
            catch(Exception e)
            {
                return "Error:  We're sorry, we could not read this test's log file.  Please contact gbxml.org to report this problem.";
            }
        }

        //protected void upLoadButton_Click1(object sender, EventArgs e)
        //{
        //    if (FileUpload1.HasFile)
        //    {
        //        if (FileUpload1.PostedFile.ContentType == "text/xml")
        //        {
        //            //if there is a file
        //            //valadate it by pass in input stream as xmlreader
        //            Stream responseStream = FileUpload1.PostedFile.InputStream;
        //            XmlReader xmlreader = XmlReader.Create(responseStream);


        //            //initialize instances for testing
        //            DOEgbXMLValidator val = new DOEgbXMLValidator();
        //            XMLParser parser = new XMLParser();
        //            //if it is not valid
        //            if (!val.IsValidXmlEx(xmlreader) || val.nErrors > 0 || val.nWarnings > 0)
        //            {
        //                if (PrintFriendlyButton != null)
        //                    PrintFriendlyButton.Visible = false;

        //                if (DownloadLogButton != null)
        //                    DownloadLogButton.Visible = false;


        //                //setup errorlog
        //                string errorLog = "";
        //                string errorDes = "";
        //                if (val.nErrors > 0 || val.nWarnings > 0)
        //                {
        //                    errorLog += "<p class='text-error'><div class='alert alert-error'>" + "Find " + val.nErrors + " Errors and " + val.nWarnings + " Warnings <br/> <br/>" + val.Errors + "</div></p>";
        //                    errorDes = "Find ";
        //                    if (val.nErrors > 0)
        //                    {
        //                        errorDes += val.nErrors;
        //                        if (val.nWarnings > 0)
        //                            errorDes += " Errors and";
        //                        else
        //                            errorDes += " Errors";

        //                    }
        //                    if (val.nWarnings > 0)
        //                        errorDes += val.nWarnings + " Warnings";
        //                }
        //                else
        //                {
        //                    errorLog += "<p class='text-error'><div class='alert alert-error'>" + "Your XML File is severely deficient structurally.  It may be missing element tags or is not valid XML.  The test has failed. <br /><br/>" + val.BigError + "<br />" + "</div></p>";
        //                    errorDes = "Your XML File is severely deficient structurally.";
        //                }
        //                // Session.Add("table", errorLog);
        //                Session["table"] = errorLog;

        //                TestResultLabel.Text = "";

        //                ResultSummaryLabel.Text = "<h3>Result Summary</h3>";
        //                ResultSummaryLabel.Text += "<div class='container'><table class='table table-bordered'>";
        //                ResultSummaryLabel.Text += "<tr class='error'>" +
        //                                "<td>" + "gbXML schema Test" + "</td>" +
        //                                "<td>" + errorDes + "</td>" +
        //                                "<td>" + "Fail" + "</td>" +
        //                                "<td>" + "<a href='TestDetailPage.aspx?type=Error' target='_blank'>" + "More Detail" + "</a>" + "</td>" +
        //                                "</tr>";
        //                ResultSummaryLabel.Text += "</table></div><br/>";
        //            }
        //            //if it is valid
        //            else if (val.nErrors == 0 && val.nWarnings == 0)
        //            {
        //                //run test
                        
        //                responseStream.Position = 0;
        //                XmlReader xmlreader2 = XmlReader.Create(responseStream);
        //                //start test
        //                parser.StartTest(xmlreader2, DropDownList1.SelectedValue, Page.User.Identity.Name);

        //                string results = parser.browserjson;
        //                results = results.Replace(@"\", @"\\");
        //                ClientScriptManager cs = Page.ClientScript;
        //                cs.RegisterStartupScript(GetType(), "Startup", "init('" + results + "');", true);
        //                //show summary table
        //                ResultSummaryLabel.Text = parser.summaryTable;

        //                //show test section table
        //                TestResultLabel.Text = parser.table;

        //                //store reportlist in session
        //                Session["reportList"] = parser.ReportList;


        //                LogLabel.Text = parser.log;
        //                TableLabel.Text = parser.table;
        //                //remove extra tag
        //                //TableLabel.Text = TableLabel.Text.Replace("<a href='PrintFriendlyTablePage.aspx' target='_blank'>", "");
        //                //TableLabel.Text = TableLabel.Text.Replace("</a>", "");
        //                //TableLabel.Text = TableLabel.Text.Replace("<table class='table table-bordered'>", "<table border='1'>");
        //                //DownloadLogButton.Visible = true;
        //                //PrintFriendlyButton.Visible = true;
        //            }
        //            //this should never happens
        //            else
        //            {
        //                ResultSummaryLabel.Text = "?????????something is very wrong";
        //                TestResultLabel.Text = "";
        //            }

        //        }
        //        //if the file type is not xml
        //        else
        //        {
        //            if (PrintFriendlyButton != null)
        //                PrintFriendlyButton.Visible = false;

        //            if (DownloadLogButton != null)
        //                DownloadLogButton.Visible = false;

        //            ResultSummaryLabel.Text = "";
        //            TestResultLabel.Text = "";

        //            ResultSummaryLabel.Text = "<h3>Result Summary</h3>";
        //            ResultSummaryLabel.Text += "<table class='table table-bordered'>";
        //            ResultSummaryLabel.Text += "<tr class='error'>" +
        //                            "<td>" + "gbXML schema Test" + "</td>" +
        //                            "<td>" + "You have not specified a right type of file." + "</td>" +
        //                            "<td>" + "Fail" + "</td>" +

        //                            "</tr>";
        //            ResultSummaryLabel.Text += "</table><br/>";
        //        }
        //    }
        //    //if there is no file
        //    else
        //    {
        //        if (PrintFriendlyButton != null)
        //            PrintFriendlyButton.Visible = false;

        //        if (DownloadLogButton != null)
        //            DownloadLogButton.Visible = false;


        //        ResultSummaryLabel.Text = "";
        //        TestResultLabel.Text = "";

        //        ResultSummaryLabel.Text = "<h3>Result Summary</h3>";
        //        ResultSummaryLabel.Text += "<table class='table table-bordered'>";
        //        ResultSummaryLabel.Text += "<tr class='error'>" +
        //                        "<td>" + "gbXML schema Test" + "</td>" +
        //                        "<td>" + "You have not specified a file." + "</td>" +
        //                        "<td>" + "Fail" + "</td>" +
        //                        "</tr>";
        //        ResultSummaryLabel.Text += "</table><br/>";

        //    }
        //}


        protected void DownloadLogButton_Click(object sender, EventArgs e)
        {
            Response.Clear();
            Response.ClearContent();
            Response.ClearHeaders();
            Response.AddHeader("content-disposition", "attachment;filename=Log.txt");
            Response.ContentType = "text/plain";
            Response.Write(LogLabel.Text);
            Response.End();
        }

        protected void PrintFriendlyButton_Click(object sender, EventArgs e)
        {
            Session.Add("table", TableLabel.Text);

            string url = "PrintFriendlyTablePage.aspx";

            ClientScript.RegisterStartupScript(this.GetType(), "OpenWindow", "<script>openNewWindow('" + url + "')</script>");
        }

        //TODO: REMOVE?
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if change the selected index clear all labels
            //ResultSummaryLabel.Text = "";
            //TestResultLabel.Text = "";
            //LogLabel.Text = "";
            //TableLabel.Text = "";
            //DownloadLogButton.Visible = false;
            //PrintFriendlyButton.Visible = false;
        }

        //TODO: REMOVE?
        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if change the selected index clear all labels
            //ResultSummaryLabel.Text = "";
            //TestResultLabel.Text = "";
            //LogLabel.Text = "";
            //TableLabel.Text = "";
            //DownloadLogButton.Visible = false;
            //PrintFriendlyButton.Visible = false;
        }

    }
}