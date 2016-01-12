<%@ Page Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="TestDetailPage.aspx.cs" Inherits="XMLValidatorWeb.TestDetail" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div class='container'>
        <div class="span12">
            <asp:Label ID="TestDetailLabelName" runat="server" Text=""></asp:Label>
        </div>
        <div class="span9">
            <asp:Label ID="TestDetailLabelOverView" runat="server" Text=""></asp:Label>
        </div>
        <div class="span2">
            <asp:Image  ID="TestDetailImage" runat="server" ImageUrl="~/Images/TmpImage.gif" AlternateText="test detail image" />
        </div>
        <div class = "span12">
        <asp:Label ID="TestDetailLabelResults" runat="server" Text=""></asp:Label>
        </div>
    </div>
</asp:Content>
