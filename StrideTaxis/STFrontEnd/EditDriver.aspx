<%@ Page Title="" Language="C#" MasterPageFile="~/StrideTaxis.Master" AutoEventWireup="true" CodeBehind="EditDriver.aspx.cs" Inherits="STFrontEnd.EditDriver" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p style="height: 330px; margin-left: 29px; margin-bottom: 171px; margin-top: 0px;">
     <asp:TextBox ID="txtDriverID" runat="server" style="z-index: 1; left: 284px; top: 57px; position: absolute"></asp:TextBox>
     <asp:TextBox ID="txtTelephoneNo" runat="server" style="z-index: 1; left: 512px; top: 58px; position: absolute"></asp:TextBox>
     <asp:Label ID="lblTelephoneNo" runat="server" ForeColor="#003399" style="z-index: 1; left: 426px; top: 58px; position: absolute; width: 78px; height: 21px" Text="Telephone No"></asp:Label>
     <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 282px; top: 179px; position: absolute"></asp:TextBox>
     <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 283px; top: 138px; position: absolute"></asp:TextBox>
     <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 513px; top: 100px; position: absolute"></asp:TextBox>
     <asp:Label ID="lblDriverID" runat="server" ForeColor="#003399" style="z-index: 1; left: 473px; top: 125px; position: absolute" Text="DriverID"></asp:Label>
     <asp:Label ID="lblLicenseNo" runat="server" ForeColor="#003399" style="z-index: 1; left: 466px; top: 170px; position: absolute" Text="License No"></asp:Label>
     <asp:Label ID="lblFirstName" runat="server" ForeColor="#003399" style="z-index: 1; left: 465px; top: 210px; position: absolute" Text="First Name"></asp:Label>
     <asp:TextBox ID="txtLicenseNo" runat="server" style="z-index: 1; left: 284px; top: 98px; position: absolute"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
     <asp:Label ID="lblLastName" runat="server" ForeColor="#003399" style="z-index: 1; left: 469px; top: 249px; position: absolute" Text="Last Name"></asp:Label>
     <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 591px; top: 147px; position: absolute" Text="Cancel" />
     <asp:Button ID="btnSaveChanges" runat="server" style="z-index: 1; left: 485px; top: 148px; position: absolute; width: 93px; height: 26px" Text="Save Changes" />
    <asp:Label ID="lblEmail" runat="server" ForeColor="#003399" style="z-index: 1; left: 726px; top: 171px; position: absolute; width: 33px" Text="Email"></asp:Label>
    <asp:Label ID="lblEditDriverDetails" runat="server" BackColor="#FFCC00" BorderColor="Black" Font-Bold="True" Font-Size="XX-Large" ForeColor="#33CC33" style="z-index: 1; left: 973px; top: 40px; position: absolute; height: 152px; width: 153px" Text="Edit Driver Details"></asp:Label>


 </p>   
</asp:Content>