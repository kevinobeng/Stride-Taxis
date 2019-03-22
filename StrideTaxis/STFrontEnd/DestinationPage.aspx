<%@ Page Title="" Language="C#" MasterPageFile="~/StrideTaxis.Master" AutoEventWireup="true" CodeBehind="DestinationPage.aspx.cs" Inherits="STFrontEnd.DestinationPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="btnDisplayDestination" runat="server" style="z-index: 1; left: 733px; top: 317px; position: absolute; width: 225px" Text="Display Popular Destinations" OnClick="btnDisplayDestination_Click"/>
    <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 452px; top: 316px; position: absolute; " Text="Label"></asp:Label>
    <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 975px; top: 159px; position: absolute; width: 95px;" Text="Delete" OnClick="btnDelete_Click"/>
    <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 975px; top: 60px; position: absolute; width: 95px;" Text="Add" OnClick="btnAdd_Click" />
    <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 976px; top: 109px; position: absolute; width: 95px;" Text="Edit" />
    <asp:ListBox ID="lstDestinations" runat="server" style="z-index: 1; left: 449px; top: 58px; position: absolute; height: 256px; width: 511px; margin-right: 2px" OnSelectedIndexChanged="lstDestinations_SelectedIndexChanged"></asp:ListBox>
</asp:Content>
