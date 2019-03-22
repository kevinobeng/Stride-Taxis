<%@ Page Title="" Language="C#" MasterPageFile="~/StrideTaxis.Master" AutoEventWireup="true" CodeBehind="DeleteDriver.aspx.cs" Inherits="STFrontEnd.DeleteDriver" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <p style="height: 449px">
        <asp:Label ID="lblLicenseType" runat="server" style="z-index: 1; left: 133px; top: 118px; position: absolute" Text="License Type"></asp:Label>
        <asp:Label ID="lblDeleteDriver" runat="server" style="z-index: 1; left: 688px; top: 120px; position: absolute; height: 112px; width: 188px;" Text="Delete Driver" Font-Bold="True" Font-Names="Arial" Font-Size="XX-Large" ForeColor="Yellow"></asp:Label>
        <asp:DropDownList ID="DropDownListDeletePayment" runat="server" style="z-index: 1; left: 122px; top: 61px; position: absolute; height: 23px; width: 199px"></asp:DropDownList>

        <asp:Button ID="btnDeleteThisLicenseNo" runat="server" style="z-index: 1; left: 340px; top: 54px; position: absolute" Text="Delete This License No" />
        <asp:Button ID="ButtonCancel" runat="server" style="z-index: 1; left: 335px; top: 92px; position: absolute; width: 213px;" Text="Cancel" />

</asp:Content>
