<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Car.aspx.cs" Inherits="STFrontEnd.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 553px; background-color: #0066FF">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstCar" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute; height: 242px; width: 375px" OnSelectedIndexChanged="lstCar_SelectedIndexChanged"></asp:ListBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 22px; top: 293px; position: absolute" Text="[lblError]"></asp:Label>
        <asp:Label ID="lblCar" runat="server" style="z-index: 1; left: 12px; top: 330px; position: absolute; width: 188px" Text="Please Enter a Car"></asp:Label>
        <asp:TextBox ID="txtCar" runat="server" style="z-index: 1; left: 15px; top: 358px; position: absolute; width: 205px"></asp:TextBox>
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 406px; top: 56px; position: absolute; width: 76px" Text="Add" OnClick="btnAdd_Click1" />
        <p>
            &nbsp;</p>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 406px; top: 201px; position: absolute; width: 77px; margin-top: 0px" Text="Delete" />
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 18px; top: 416px; position: absolute; width: 134px" Text="Apply" />
        <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1; left: 164px; top: 414px; position: absolute; width: 188px" Text="Display All" />
        <p>
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 409px; top: 129px; position: absolute; width: 65px" Text="Edit" OnClick="btnEdit_Click" />
        </p>
    </form>
</body>
</html>
