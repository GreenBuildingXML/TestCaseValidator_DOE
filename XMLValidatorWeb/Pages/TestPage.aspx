<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true"
    CodeBehind="TestPage.aspx.cs" Inherits="XMLValidatorWeb.Pages.TestPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script language="javascript" type="text/javascript">
        function openNewWindow(url) {
            var w = window.open(url);
            w.focus();
        } 
    </script>
     <script src="<%=ResolveClientUrl("~/Scripts/jquery-ui.js")%>"></script>
    <script src="<%=ResolveClientUrl("~/Scripts/jquery.multilevelpushmenu.js")%>"></script>
    <script src="<%=ResolveClientUrl("~/Scripts/jquery.fileupload.js")%>"></script>
    <script src="<%=ResolveClientUrl("~/Scripts/jquery.iframe-transport.js")%>"></script>
    <script src="<%=ResolveClientUrl("~/Scripts/FileSaver.js")%>"></script>
    <link href="<%=ResolveClientUrl("~/css/jquery.multilevelpushmenu.css?12212009035543")%>" rel="stylesheet" />
    <link rel="stylesheet" href="//netdna.bootstrapcdn.com/font-awesome/4.0.1/css/font-awesome.min.css">


    <div class="container-fluid" style="margin-top:150px">
        <div class="row">
            <div class="col-lg-3">
                <div id="menu">

                </div>
            </div>
            <div class="col-lg-9" ID="tableInjection">
                <div id="uploadSection">
                    <h1>
                    gbXML Vendor Certification Validator
                    </h1>
                    <br />
                    <br />
                    <table>
                        <tr>
                            <td><h4>Select Which gbXML Schema You Wish to Test Against:</h4></td>
                            <td>
                                <asp:DropDownList ID="DropDownList2" AutoPostBack="true" runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                 <h4>Select Which Test You Want To Run:</h4>
                            </td>
                            <td>
                                <asp:DropDownList ID="DropDownList1" AutoPostBack="true" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <h4>Select Your File for Validation:</h4>
                            </td>
                            <td>
                                <input id="fileUpload" type="file" name="file" />
                            </td>
                        </tr>
                    </table>
                    
                    <br />
                    <h2>Test Description</h2>
                    <div style="width:750px">
                        <asp:Label ID="TestSummuryLabel" runat="server" Text=""></asp:Label>
                    </div>
                    
                    <br />

                    
                    
                    <%--<div>
                        Select Your XML File Here:
                        <asp:FileUpload ID="FileUpload1" runat="server" CssClass="Fileupload" class="btn" />
                        <asp:Button class="btn" ID="DownloadLogButton" runat="server" Text="Download Log File"
                            OnClick="DownloadLogButton_Click" Visible="False" />
                        <asp:Button class="btn" ID="PrintFriendlyButton" runat="server" Text="Print Friendly"
                            OnClick="PrintFriendlyButton_Click" Visible="False" />
                    </div>--%>
                    <%--<asp:Button class="btn-large btn-success" ID="upLoadButton" runat="server" Text="Upload File"
                        OnClick="upLoadButton_Click1" />--%>
                    <%--<asp:Button class="btn-large btn-success" ID="upLoadButton" runat="server" Text="Upload File" />
                    <button id="testButton">Click it.</button>--%>
                    <br />
                    <br />
                    
                       
                   
                </div>
                <div id="TableSection">

                </div>
                <div id="downloadButtons">

                </div>
                <%--<asp:Label ID="ResultSummaryLabel" runat="server" Text=""></asp:Label>
                <br />
                <asp:Label ID="TestResultLabel" runat="server" Text=""></asp:Label>--%>
            </div>
        </div>
    </div>

       <asp:Label ID="LogLabel" runat="server" Visible="False"></asp:Label>
       <asp:Label ID="TableLabel" runat="server" Visible="False"></asp:Label>

    <script>

        var reports = null;

        function DrawBuildingSummaryTable()
        {
            var result = reports.CampusReport.BuildingSummary;
            var standardResults = $.grep(result, function (n, i) {
                return n.FileType == "Standard";
            })
            standardResults = standardResults[0];
            var testResults = $.grep(result, function (n, i) {
                return n.FileType == "Test";
            })
            testResults = testResults[0];

            var html = "";
            html += '<h2>Building Summary Report Results: ' + (standardResults.PassedAllTests ? 'Passed' : 'Failed') + '</h2>';
            html += "<br/>"
            html += '<table class="resultsTable">';
            html += "<tr><th></th><th>Standard</th>"
            html += "<th>Test</th></tr>"
            //careful these fields must match the Reporting Object BuildingSummary properties.  If not, it will be undefined.
            html += "<tr><td>BuildingArea</td><td>" + standardResults.BuildingArea.measure + "</td><td>" + testResults.BuildingArea.measure + "</td></tr>";
            html += "<tr><td>Number of Stories</td><td>" + standardResults.NumberOfStories + "</td><td>" + testResults.NumberOfStories + "</td></tr>";
            html += "<tr><td>Number of Spaces</td><td>" + standardResults.NumberOfSpaces + "</td><td>" + testResults.NumberOfSpaces + "</td></tr>";
            html += "</table>";
            $("#TableSection").html(html);
        }

        function DrawDownloadButtons()
        {
            var html = '<button id="downloadLog">Download Complete Log</button>';
            html += '<button id="downloadErrors">Download Error</button>'; 
            $("#downloadButtons").html(html);

            $("#downloadLog").on("click", function () {
                $.ajax({
                    type: "POST",
                    data: {},
                    url: "TestPage.aspx/GetResults",
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    success: function (msg) {
                        console.log("success",msg);
                        var text = msg.d;
                        var filename = "gbxmlValidatorFullLog";
                        var blob = new Blob([text], { type: "text/plain;charset=utf-8" });
                        saveAs(blob, filename + ".txt");
                    },
                    error: function (msg) {
                        console.log(msg);
                    }
                });
                return false;
            })

            $("#downloadErrors").on("click", function () {
                $.ajax({
                    type: "POST",
                    data: {},
                    url: "TestPage.aspx/GetErrorSummary",
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    success: function (msg) {
                        console.log("success", msg);
                        var text = msg.d;
                        var filename = "gbxmlValidatorLogErrorSummary";
                        var blob = new Blob([text], { type: "text/plain;charset=utf-8" });
                        saveAs(blob, filename + ".txt");
                    },
                    error: function (msg) {
                        console.log(msg);
                    }
                });
                return false;
            })
        }

        function MakeOverallSummaryTable()
        {
            var html = "";
            html += '<h2>Results Summary:</h2>';
            html += "<br/>"
            html += '<table class="resultsTable">';
            //careful these fields must match the Reporting Object BuildingSummary properties.  If not, it will be undefined.
            html += "<tr><td>Test Case Name</td><td>" + reports.gbxml_testcase + "</td></tr>";
            html += "<tr><td>gbXML Schema Tested</td><td>" + reports.gbxml_version + "</td></tr>";
            html += "<tr><td>Schema Testing Results</td><td>" + reports.schema_compliance_results + "</td></tr>";
            html += "<tr><td>Schema Testing Warnings</td><td>" + reports.XMLSchemaWarnings + "</td></tr>";
            html += "<tr><td>Schema Testing Errors</td><td>" + reports.XMLSchemaErrors + "</td></tr>";
            html += "<tr><td>Geometry Testing Results</td><td>" + reports.detailed_compliance_results + "</td></tr>";
            if (reports.detailed_compliance_results == "FAIL" || reports.schema_compliance_results == "FAIL" || reports.detailed_compliance_results == "ERROR")
            {
                html += "<tr><td>Overall Validation Score</td><td>" + "FAIL" + "</td></tr>";
            }
            else
            {
                html += "<tr><td>Overall Validation Score</td><td>" + "PASS" + "</td></tr>";
            }
            html += "</table>";
            html += reports.message;
            $("#TableSection").html(html);
            DrawDownloadButtons();
        }

        function DrawSurfacesSummaryTable()
        {
            var result = reports.CampusReport.SurfacesSummary;
            var standardResults = $.grep(result, function (n, i) {
                return n.FileType == "Standard";
            })
            standardResults = standardResults[0];
            var testResults = $.grep(result, function (n, i) {
                return n.FileType == "Test";
            })
            testResults = testResults[0];
            var failedSurfaces = $.grep(reports.CampusReport.SurfacesReport, function (n, i) {
                return n.FoundMatch == false;
            })
            var html = "";
            html += '<h2>Surfaces Summary Report Results: ' + (standardResults.PassedAllTests ? 'Passed' : 'Failed') + '</h2>';
            html += "<br/>"
            html += "<h3>Surfaces which failed: <br/>"
            for (var i = 0; i < failedSurfaces.length; i++)
            {
                html += failedSurfaces[i].ID + "<br/>";
            }
            html+="</h3>";
            html += "<br/>";
            html += "Surface count summary (has no bearing on pass or fail, just informative.)"
            html += '<table class="resultsTable">';
            html += "<tr><th></th><th>Standard</th>"
            html += "<th>Test</th></tr>"
            //careful these fields must match the Reporting Object SurfaceSummary properties.  If not, it will be undefined.
            html += "<tr><td>Passed Surface Planarity Tests</td><td>" + standardResults.SurfacesArePlanar + "</td><td>" + testResults.SurfacesArePlanar + "</td></tr>";
            html += "<tr><td>Number of Exterior Walls</td><td>" + standardResults.NumberOfExternalWalls + "</td><td>" + testResults.NumberOfExternalWalls + "</td></tr>";
            html += "<tr><td>Number of Interior Walls</td><td>" + standardResults.NumberOfInternalWalls + "</td><td>" + testResults.NumberOfInternalWalls + "</td></tr>";
            html += "<tr><td>Number of Interior Floors/Ceilings</td><td>" + standardResults.NumberOfInternalFloors_Ceilings + "</td><td>" + testResults.NumberOfInternalFloors_Ceilings + "</td></tr>";
            html += "<tr><td>Number of Slabs On Grade</td><td>" + standardResults.NumberOfSlabsOnGrade + "</td><td>" + testResults.NumberOfSlabsOnGrade + "</td></tr>";
            html += "<tr><td>Number of Roofs</td><td>" + standardResults.NumberOfRoofs + "</td><td>" + testResults.NumberOfRoofs + "</td></tr>";
            html += "<tr><td>Number of Underground Walls</td><td>" + standardResults.NumberOfUndergroundWalls + "</td><td>" + testResults.NumberOfUndergroundWalls + "</td></tr>";
            html += "<tr><td>Number of Shading Devices</td><td>" + standardResults.NumberOfShades + "</td><td>" + testResults.NumberOfShades + "</td></tr>";
            html += "</table>";
            $("#TableSection").html(html);
        }
        function DrawSpacesSummaryTable()
        {
            var result = reports.CampusReport.SpacesSummary;
            var standardResults = $.grep(result, function (n, i) {
                return n.FileType == "Standard";
            })
            standardResults = standardResults[0];
            var testResults = $.grep(result, function (n, i) {
                return n.FileType == "Test";
            })
            testResults = testResults[0];

            var html = "";
            html += '<h2>Spaces Summary Report Results: ' + (standardResults.PassedAllTests ? 'Passed' : 'Failed') + '</h2>';
            html += "<br/>"
            html += '<table class="resultsTable">';
            html += "<tr><th></th><th>Standard</th>"
            html += "<th>Test</th></tr>"
            //careful these fields must match the Reporting Object SurfaceSummary properties.  If not, it will be undefined.
            html += "<tr><td>Number of Spaces</td><td>" + standardResults.Count + "</td><td>" + testResults.Count + "</td></tr>";
            html += "<tr><td>Are All Space IDs Unique</td><td>" + standardResults.spaceIDs_unique + "</td><td>" + testResults.spaceIDs_unique + "</td></tr>";
            html += "</table>";
            $("#TableSection").html(html);
        }

        function DrawSpacesDetailedTable(id)
        {
            //a tetailed report, need to use grep to grab by unique id.
            var result = $.grep(reports.CampusReport.SpacesReport, function (n, i) {
                return n.ID == id;
            })
            result = result[0];
            console.log("Spaces report result: ", result);
            var html = "";
            html += '<h2>Space ' + result.ID + ' Results: ' + (result.FoundMatch ? 'Found Match' : 'Failed to Find Match') + '</h2>';
            html += '<table class="resultsTable">';
            html += "<tr><th></th><th>Standard</th>"
            html += "<th>Test</th></tr>"
            html += "<tr><td>Surface Area</td><td>" + result.TotalSurfaceArea + "</td><td>" + result.TotalTestSurfaceArea + "</td></tr>";
            html += "<tr><td>Surface Volume</td><td>" + result.TotalVolume + "</td><td>" + result.TotalTestVolume + "</td></tr>";
            html += "</table>";
            $("#TableSection").html(html);
        }
        function DrawSurfacesDetailedTable(id)
        {
            //a tetailed report, need to use grep to grab by unique id.
            var result = $.grep(reports.CampusReport.SurfacesReport, function (n, i) {
                return n.ID == id;
            })
            result = result[0];
            console.log("Surfaces report result: ", result);
            var html = "";
            html += '<h2>Surface ' + result.ID + ' Results: ' + (result.FoundMatch ? 'Found Match' : 'Failed to Find Match') + '</h2>';
            html += '<table class="resultsTable">';
            html += "<tr><th></th><th>Standard</th>"
            html += "<th>Test</th></tr>"
            html += "<tr><td>Surface Area</td><td>" + result.TotalSurfaceArea + "</td><td>" + result.TotalTestSurfaceArea + "</td></tr>";
            html += "</table>";
            $("#TableSection").html(html);
        }

        $('#fileUpload').fileupload({
            formData: { 'testcase': $('#<%=DropDownList1.ClientID %> option:selected').text(), 'schema': $('#<%=DropDownList2.ClientID %> option:selected').text() },
            replaceFileInput: false,
            dataType: 'json',
            url: '<%= ResolveUrl("AjaxHandler.ashx") %>',
            done: function (e, data) {
                console.log(data.result);
                console.log("Done.");
                reports = data.result;
                init([JSON.parse(data.result.menu)]);
                reports.menu = null; //save some space
            }
        });

        function init(menuarr)
        {
            $('#uploadSection').hide();
           
            //create the initial summary menu
            MakeOverallSummaryTable();
            $('#menu').multilevelpushmenu({
                onItemClick: function () {
                    $("#TableSection").empty();
                    $('#downloadButtons').empty();
                    // First argument is original event object
                    var event = arguments[0],
                        // Second argument is menu level object containing clicked item (<div> element)
                        $menuLevelHolder = arguments[1],
                        // Third argument is clicked item (<li> element)
                        $item = arguments[2],
                        // Fourth argument is instance settings/options object
                        options = arguments[3];
                    var parentContainer = ($menuLevelHolder.find('h2:first').text());
                    console.log("Clicked", $item);
                    var id = $item.attr("id")
                    if (parentContainer == "Surfaces") //must match id in menu hierarchy.  See MakeViewJson in DOEgbXMLParser if this is breaking
                    {
                        DrawSurfacesDetailedTable(id);
                    }
                    else if (parentContainer == "Spaces")
                    {
                        DrawSpacesDetailedTable(id);
                    }
                    else if (parentContainer == "Building Stories")
                    {
                        console.log("Show building stories detailed table.")
                    }
                    //multiple buildings in the future.
                    
                },
                onGroupItemClick: function () {
                    $("#TableSection").empty();
                    $('#downloadButtons').empty();
                    var event = arguments[0],
                        $menuLevelHolder = arguments[1],
                        $item = arguments[2],
                        options = arguments[3];
                    var element = $item.attr("id");
                    console.log('Clicked,', $item);
                    
                    if(element == "surfaces")
                    {
                        //draw surface summary table
                        DrawSurfacesSummaryTable();
                    }
                    else if (element == 'spaces')
                    {
                        DrawSpacesSummaryTable();
                    }
                    else if (element == 'building')
                    {
                        DrawBuildingSummaryTable();
                    }
                },
                onBackItemClick: function () {
                    $("#TableSection").empty();
                    $("#downloadButtons").empty();
                    // First argument is original event object
                    var event = arguments[0],
                        $menuLevelHolder = arguments[1],
                        options = arguments[2],
                        title = $menuLevelHolder.find('h2:first').text();
                    console.log("Clicked", title);
                    if (title == "Campus") {
                        //show report summary
                        MakeOverallSummaryTable();
                    }
                    else if (title == "Building")
                    {
                        //show building summary
                        console.log("Showing building summary")
                        DrawBuildingSummaryTable();
                    }
                    else if (title == "Surfaces")
                    {
                        //show surfaces summary
                        console.log("Showing surfaces summary.")
                        DrawSurfacesSummaryTable();
                    }
                    else if (title == "Spaces")
                    {
                        //show spaces summary
                        console.log("Showing spaces summary.")
                        DrawSpacesSummaryTable();
                    }
                    else if (title = "Building Stories")
                    {
                        console.log("Showing building stories summary.")
                    }
                    else
                    {
                        //for now, nothing, there should be no other categories other than these.
                    }
                },

                menu: menuarr,
                collapsed: false,
                menuHeight: 1600
            });
            $(window).resize(function () {
                $('#menu').multilevelpushmenu('redraw');
            });
        }

        
        <%--$('#<%= upLoadButton.ClientID %>').on('click', function (evt) {
            var fileupload = $('#<%= FileUpload1.ClientID %>');
            var files = fileupload.prop('files');
            //TODO: check to make sure something is there, and that the file is an xml file.

            var data = new FormData();
            for (var i = 0; i < files.length; i++) {
                data.append(files[i].name, files[i]);
            }

            $.ajax({
                url: "TestPage.aspx/UploadTest",
                type: "POST",
                data: data,
                processData: false,
                contentType: false,
                success: function (result) { console.log("Test upload successful.", result); },
                error: function (err) {
                    alert(err.statusText)
                }
            });
            evt.preventDefault();
            return false;
        });--%>

        //function setUpTable(callback)
        //{
        //    $.jsontotable(tableTestArray, { id: '#jsontotable', header: true, footer: true, className: 'table table-condensed table-striped table-hover' });
        //    console.log($("#jsontotable").children().first());
        //    callback($("#jsontotable").children().first());
        //}

        //function tableSetCB(tableref)
        //{
        //    tableref.dataTable();
        //}
    </script>
</asp:Content>
