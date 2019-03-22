<%@ Page Title="" Language="C#" MasterPageFile="~/StrideTaxis.Master" AutoEventWireup="true" CodeBehind="AddDriver.aspx.cs" Inherits="STFrontEnd.AddDriver" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p style="height: 330px; margin-left: 29px; margin-bottom: 171px">
     <asp:TextBox ID="txtDriverID" runat="server" style="z-index: 1; left: 284px; top: 57px; position: absolute"></asp:TextBox>
     <asp:TextBox ID="txtTelephoneNo" runat="server" style="z-index: 1; left: 512px; top: 58px; position: absolute"></asp:TextBox>
     <asp:Label ID="lblTelephoneNo" runat="server" ForeColor="#003399" style="z-index: 1; left: 696px; top: 53px; position: absolute; width: 78px; height: 21px" Text="Telephone No"></asp:Label>
     <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 282px; top: 179px; position: absolute"></asp:TextBox>
     <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 283px; top: 138px; position: absolute"></asp:TextBox>
     <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 513px; top: 100px; position: absolute"></asp:TextBox>
     <asp:Label ID="lblDriverID" runat="server" ForeColor="#003399" style="z-index: 1; left: 206px; top: 58px; position: absolute; height: 5px; width: 96px;" Text="DriverID"></asp:Label>
     <asp:Label ID="lblLicenseNo" runat="server" ForeColor="#003399" style="z-index: 1; left: 354px; top: 157px; position: absolute" Text="License No"></asp:Label>
     <asp:Label ID="lblFirstName" runat="server" ForeColor="#003399" style="z-index: 1; left: 360px; top: 194px; position: absolute" Text="First Name"></asp:Label>
     <asp:TextBox ID="txtLicenseNo" runat="server" style="z-index: 1; left: 284px; top: 98px; position: absolute"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
     <asp:Label ID="lblLastName" runat="server" ForeColor="#003399" style="z-index: 1; left: 372px; top: 236px; position: absolute" Text="Last Name"></asp:Label>
     <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 591px; top: 147px; position: absolute" Text="Cancel" />
     <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 516px; top: 149px; position: absolute; width: 60px; height: 20px" Text="Add" OnClick="btnAdd_Click" />
     <asp:Label ID="lblAddDriverDetails" runat="server" BackColor="#CCCCCC" BorderColor="Black" Font-Bold="True" Font-Size="XX-Large" ForeColor="#0000CC" style="z-index: 1; left: 1009px; top: 53px; position: absolute; height: 152px; width: 153px" Text="Add Driver Details"></asp:Label>
         <asp:Label ID="lblEmail" runat="server" ForeColor="#003399" style="z-index: 1; left: 879px; top: 160px; position: absolute; width: 33px" Text="Email"></asp:Label>

















 </p>
</asp:Content>