<%@ Page Title="" Language="C#" MasterPageFile="~/StrideTaxis.Master" AutoEventWireup="true" CodeBehind="AddDestination.aspx.cs" Inherits="STFrontEnd.AddDestination" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:TextBox ID="txtHouseNo" runat="server" style="z-index: 1; left: 540px; top: 75px; position: absolute; width: 210px"></asp:TextBox>
    <asp:TextBox ID="txtPostCode" runat="server" style="z-index: 1; left: 540px; top: 116px; position: absolute; width: 210px"></asp:TextBox>
    <asp:TextBox ID="txtStreet" runat="server" style="z-index: 1; left: 540px; top: 154px; position: absolute; width: 210px"></asp:TextBox>
    <asp:TextBox ID="txtTown" runat="server" style="z-index: 1; left: 540px; top: 194px; position: absolute; width: 210px"></asp:TextBox>
    <asp:Label ID="lblEndPointTown" runat="server" style="z-index: 1; left: 565px; top: 236px; position: absolute" Text="Town:"></asp:Label>
    <asp:Label ID="lblEndPointStreet" runat="server" style="z-index: 1; left: 565px; top: 198px; position: absolute; height: 21px" Text="Street:"></asp:Label>
    <asp:Label ID="lblEndPointPostCode" runat="server" style="z-index: 1; left: 565px; top: 159px; position: absolute" Text="Post Code:"></asp:Label>
    <asp:Label ID="lblEndPointHouseNo" runat="server" style="z-index: 1; left: 565px; top: 115px; position: absolute" Text="House No. :"></asp:Label>
</asp:Content>
