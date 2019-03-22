<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteCar.aspx.cs" Inherits="STFrontEnd.DeleteCar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 97px">
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute; width: 272px" Text="Are you sure you want to delete this car?"></asp:Label>
        </div>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 9px; top: 58px; position: absolute; width: 76px" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 97px; top: 56px; position: absolute; width: 82px; height: 26px;" Text="No" />
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
