<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnCar.aspx.cs" Inherits="STFrontEnd.AnCar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblCarID" runat="server" style="z-index: 1; left: 11px; top: 59px; position: absolute; width: 65px" Text="Car ID:"></asp:Label>
            <asp:Label ID="lblCarColour" runat="server" style="z-index: 1; left: 12px; top: 99px; position: absolute; right: 654px" Text="Car Colour:"></asp:Label>
            <asp:Label ID="lblCarMake" runat="server" style="z-index: 1; left: 11px; top: 145px; position: absolute; height: 19px" Text="Car Make:"></asp:Label>
            <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 13px; top: 192px; position: absolute" Text="Car Model:"></asp:Label>
            <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 7px; top: 240px; position: absolute; height: 25px" Text="Registration No:"></asp:Label>
            <asp:TextBox ID="txtCarID" runat="server" style="z-index: 1; left: 113px; top: 52px; position: absolute; height: 28px; width: 88px"></asp:TextBox>
            <asp:TextBox ID="txtCarColour" runat="server" style="z-index: 1; left: 110px; top: 88px; position: absolute; height: 26px; width: 118px; right: 553px; margin-top: 5px"></asp:TextBox>
            <asp:TextBox ID="txtCarMake" runat="server" style="z-index: 1; left: 110px; top: 141px; position: absolute; height: 27px; width: 120px; margin-top: 0px"></asp:TextBox>
            <asp:TextBox ID="txtCarModel" runat="server" style="z-index: 1; left: 109px; top: 190px; position: absolute; height: 24px"></asp:TextBox>
            <asp:TextBox ID="txtRegistrationNo" runat="server" style="z-index: 1; left: 117px; top: 237px; position: absolute; height: 25px"></asp:TextBox>
            <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 12px; top: 286px; position: absolute" Text="Active" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 20px; top: 324px; position: absolute" Text="[lblError]"></asp:Label>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 93px; top: 378px; position: absolute; width: 51px" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 154px; top: 374px; position: absolute" Text="Cancel" />
        </div>
    </form>
</body>
</html>
