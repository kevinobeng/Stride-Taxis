<%@ Page Title="" Language="C#" MasterPageFile="~/StrideTaxis.Master" AutoEventWireup="true" CodeBehind="DeleteDestination.aspx.cs" Inherits="STFrontEnd.DeleteDestination" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="btnYes" runat="server" style="z-index: 1; left: 706px; top: 156px; position: absolute; width: 63px" Text="Yes" />
    <asp:Label ID="lblDelete" runat="server" style="z-index: 1; top: 97px; position: absolute; left: 664px" Text="Are You Sure You Want To Delete This Destination?"></asp:Label>
    <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 920px; top: 155px; position: absolute; width: 66px" Text="No" />
</asp:Content>
