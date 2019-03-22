<%@ Page Title="" Language="C#" MasterPageFile="~/StrideTaxis.Master" AutoEventWireup="true" CodeBehind="AddDestination.aspx.cs" Inherits="STFrontEnd.AddDestination" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:TextBox ID="txtHouseNo" runat="server" style="z-index: 1; left: 831px; top: 91px; position: absolute; width: 210px"></asp:TextBox>
    <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 669px; top: 366px; position: absolute" Text="Label"></asp:Label>
    <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 818px; top: 313px; position: absolute; width: 80px;" Text="Cancel" OnClick="btnCancel_Click" />
    <asp:TextBox ID="txtPostCode" runat="server" style="z-index: 1; left: 831px; top: 208px; position: absolute; width: 210px"></asp:TextBox>
    <asp:Label ID="lblPickUp" runat="server" style="z-index: 1; left: 674px; top: 250px; position: absolute" Text="Pick Up:"></asp:Label>
    <asp:TextBox ID="txtPickUp" runat="server" style="z-index: 1; left: 831px; top: 247px; position: absolute; width: 210px">DD/MM/YYYY HH:MM</asp:TextBox>
    <asp:TextBox ID="txtStreet" runat="server" style="z-index: 1; left: 831px; top: 130px; position: absolute; width: 210px"></asp:TextBox>
    <asp:Button ID="btnSave" runat="server" style="z-index: 1; left: 974px; top: 314px; position: absolute; width: 80px;" Text="Save" OnClick="btnSave_Click" />
    <asp:TextBox ID="txtTown" runat="server" style="z-index: 1; left: 831px; top: 169px; position: absolute; width: 210px"></asp:TextBox>
    <asp:Label ID="lblEndPointTown" runat="server" style="z-index: 1; left: 672px; top: 172px; position: absolute" Text="Town:"></asp:Label>
    <asp:Label ID="lblEndPointStreet" runat="server" style="z-index: 1; left: 672px; top: 132px; position: absolute" Text="Street:"></asp:Label>
    <asp:Label ID="lblEndPointPostCode" runat="server" style="z-index: 1; left: 672px; top: 210px; position: absolute" Text="Post Code:"></asp:Label>
    <asp:Label ID="lblEndPointHouseNo" runat="server" style="z-index: 1; left: 672px; top: 95px; position: absolute" Text="House No. :"></asp:Label>
</asp:Content>