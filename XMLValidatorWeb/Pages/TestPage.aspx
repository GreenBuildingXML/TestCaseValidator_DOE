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

    <div class="container">
        <h1>
            gbXML Validator
        </h1>
        <br />
        <br />
        Select Which Test You Want To Run:
        <asp:DropDownList ID="DropDownList1" AutoPostBack="true" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="TestSummuryLabel" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <div>
            Select Your XML File Here:
            <asp:FileUpload ID="FileUpload1" runat="server" CssClass="Fileupload" class="btn" />
            <asp:Button class="btn" ID="DownloadLogButton" runat="server" Text="Download Log File"
                OnClick="DownloadLogButton_Click" Visible="False" />
            <asp:Button class="btn" ID="PrintFriendlyButton" runat="server" Text="Print Friendly"
                OnClick="PrintFriendlyButton_Click" Visible="False" />
        </div>
        <br />
        <br />
        <asp:Button class="btn-large btn-success" ID="upLoadButton" runat="server" Text="Upload File"
            OnClick="upLoadButton_Click1" />
        <br />
        <br />
    

        <asp:Label ID="ResultSummaryLabel" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="TestResultLabel" runat="server" Text=""></asp:Label>
    </div>

       <asp:Label ID="LogLabel" runat="server" Visible="False"></asp:Label>
       <asp:Label ID="TableLabel" runat="server" Visible="False"></asp:Label>
</asp:Content>
