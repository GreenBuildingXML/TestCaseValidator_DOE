using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DOEgbXML;

namespace XMLValidatorWeb
{
    public partial class TestDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (TestDetailLabelOverView != null)
            {
                if (Request.QueryString["type"] != "Error")
                {
                    List<DOEgbXMLReportingObj> reportlist = new List<DOEgbXMLReportingObj>();
                    if (Session["reportList"] == null || Request.QueryString["type"] == null)
                        Response.Redirect(@"~/");

                    reportlist = (List<DOEgbXMLReportingObj>)Session["reportList"];

                    //looking for the right report from the list
                    int testType = 0;
                    int subType = -1;

                    if (Request.QueryString["type"] != null)
                    {
                        try
                        {
                            testType = (int)Convert.ToInt32(Request.QueryString["type"]);
                        }
                        catch
                        {
                            return;
                        }
                    }

                    if (Request.QueryString["subtype"] != null)
                    {
                        try
                        {
                            subType = (int)Convert.ToInt32(Request.QueryString["subtype"]);
                        }
                        catch
                        {
                            return;
                        }
                    }

                    DOEgbXMLReportingObj rightReport = new DOEgbXMLReportingObj();
                    foreach (DOEgbXMLReportingObj report in reportlist)
                        if (report.testType == (TestType)testType)
                            if (report.subTestIndex == -1 || report.subTestIndex == subType)
                                rightReport = report;


                    //title
                    string title = rightReport.testType.ToString();
                    title = title.Replace("_", " ");
                    if (subType != -1)
                        title += " " + subType;
                    TestDetailLabelName.Text += "<h2>" + title + "</h2>";

                    //description 
                    //  TestDetailLabelOverView.Text += "<p>" + "Description.................................................................." + "</p>";
                    TestDetailLabelOverView.Text += "<h4>" + "Test Summary:" + "</h4>" +
                                                    "<p>" + rightReport.testSummary + "</p>";
                    var passTest = rightReport.TestPassedDict.Values;
                    bool individualTestBool = true;
                    foreach (bool testResult in passTest)
                    {
                        if (testResult == false)
                        {
                            individualTestBool = false;
                            break;
                        }
                    }

                    string output = "<h4>" + "Test Result:" + "</h4>";
                    if (rightReport.passOrFail && individualTestBool)
                        output += "<div class='text-success'>" + rightReport.longMsg + "</div>";
                    else
                        output += "<div class='text-error'>" + rightReport.longMsg + "</div>";
                    if (rightReport.MessageList.Count > 0)
                        for (int i = 0; i < rightReport.MessageList.Count; i++)
                        {
                            output += "<div  class='text-info'>" + rightReport.MessageList[i] + "</div>";
                        }

                    TestDetailLabelResults.Text = output;
                }
                else
                {
                    TestDetailImage.Visible = false;
                    TestDetailLabelResults.Text = Session["table"].ToString();
                }
            }
        }
    }
}