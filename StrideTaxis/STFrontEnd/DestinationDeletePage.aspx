<%@ Page Title="" Language="C#" MasterPageFile="~/StrideTaxis.Master" AutoEventWireup="true" CodeBehind="DestinationDeletePage.aspx.cs" Inherits="STFrontEnd.DestinationDeletePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="btnYes" runat="server" style="z-index: 1; left: 600px; top: 117px; position: absolute; width: 63px" Text="Yes" OnClick="btnYes_Click" />
    <asp:Label ID="lblDelete" runat="server" style="z-index: 1; top: 97px; position: absolute; left: 664px" Text="Are You Sure You Want To Delete This Destination?"></asp:Label>
    <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 731px; top: 117px; position: absolute; width: 66px" Text="No" OnClick="btnNo_Click" />
</asp:Content>
