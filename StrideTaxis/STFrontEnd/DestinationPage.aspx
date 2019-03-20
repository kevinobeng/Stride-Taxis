<%@ Page Title="" Language="C#" MasterPageFile="~/StrideTaxis.Master" AutoEventWireup="true" CodeBehind="DestinationPage.aspx.cs" Inherits="STFrontEnd.DestinationPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="btnDisplayDestination" runat="server" style="z-index: 1; left: 746px; top: 317px; position: absolute; width: 209px" Text="Display Popular Destination" OnClick="btnDisplayDestination_Click"/>
    <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 632px; top: 370px; position: absolute; width: 72px" Text="Label"></asp:Label>
    <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 604px; top: 316px; position: absolute" Text="Add" />
    <asp:ListBox ID="lstDestinations" runat="server" style="z-index: 1; left: 449px; top: 58px; position: absolute; height: 256px; width: 511px; margin-right: 2px"></asp:ListBox>
</asp:Content>
