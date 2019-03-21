<%@ Page Title="" Language="C#" MasterPageFile="~/StrideTaxis.Master" AutoEventWireup="true" CodeBehind="AddDestination.aspx.cs" Inherits="STFrontEnd.AddDestination" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:TextBox ID="txtHouseNo" runat="server" style="z-index: 1; left: 831px; top: 91px; position: absolute; width: 210px"></asp:TextBox>
    <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 977px; top: 337px; position: absolute" Text="Label"></asp:Label>
    <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 709px; top: 269px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
    <asp:TextBox ID="txtPostCode" runat="server" style="z-index: 1; left: 831px; top: 208px; position: absolute; width: 210px"></asp:TextBox>
    <asp:Label ID="lblPickUp" runat="server" style="z-index: 1; left: 674px; top: 236px; position: absolute" Text="Pick Up"></asp:Label>
    <asp:TextBox ID="txtPickUp" runat="server" style="z-index: 1; left: 831px; top: 247px; position: absolute; width: 210px">DD/MM/YYYY HH:MM</asp:TextBox>
    <asp:TextBox ID="txtStreet" runat="server" style="z-index: 1; left: 831px; top: 130px; position: absolute; width: 210px"></asp:TextBox>
    <asp:Button ID="btnSave" runat="server" style="z-index: 1; left: 1005px; top: 269px; position: absolute; height: 23px;" Text="Save" OnClick="btnSave_Click" />
    <asp:TextBox ID="txtTown" runat="server" style="z-index: 1; left: 831px; top: 169px; position: absolute; width: 210px"></asp:TextBox>
    <asp:Label ID="lblEndPointTown" runat="server" style="z-index: 1; left: 672px; top: 162px; position: absolute" Text="Town:"></asp:Label>
    <asp:Label ID="lblEndPointStreet" runat="server" style="z-index: 1; left: 672px; top: 130px; position: absolute" Text="Street:"></asp:Label>
    <asp:Label ID="lblEndPointPostCode" runat="server" style="z-index: 1; left: 672px; top: 198px; position: absolute" Text="Post Code:"></asp:Label>
    <asp:Label ID="lblEndPointHouseNo" runat="server" style="z-index: 1; left: 671px; top: 100px; position: absolute" Text="House No. :"></asp:Label>
</asp:Content>