<%@ Page Title="" Language="C#" MasterPageFile="~/StrideTaxis.Master" AutoEventWireup="true" CodeBehind="Payment.aspx.cs" Inherits="STFrontEnd.Payment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="height: 550px;">

        <asp:Label ID="LabelMyPayment" runat="server" style="z-index: 1; left: 230px; top: 85px; position: absolute" Text="My Payments" Font-Bold="True" Font-Size="X-Large"></asp:Label>

        <asp:ListBox ID="ListBoxStoredPayments" runat="server" style="z-index: 1; left: 12px; top: 72px; position: absolute; height: 313px; width: 452px"></asp:ListBox>

        <asp:Button ID="ButtonAdd" runat="server" style="z-index: 1; left: 479px; top: 90px; position: absolute; width: 102px" Text="Add" OnClick="ButtonAdd_Click" />

        <asp:Button ID="ButtonEdit" runat="server" style="z-index: 1; left: 482px; top: 132px; position: absolute; width: 102px" Text="Edit" OnClick="ButtonEdit_Click" />

        <asp:Button ID="ButtonDelete" runat="server" style="z-index: 1; left: 480px; top: 175px; position: absolute; width: 103px" Text="Delete" OnClick="ButtonDelete_Click" />

        <asp:Button ID="ButtonDisplayAllStoredPayments" runat="server" style="z-index: 1; left: 120px; top: 401px; position: absolute; width: 282px" Text="Display All Stored Payments" />
        <asp:Button ID="ButtonApply" runat="server" style="z-index: 1; left: 482px; top: 352px; position: absolute; width: 102px" Text="Apply" />

        <asp:TextBox ID="TextBoxSearchStoredPayments" runat="server" style="z-index: 1; left: 730px; top: 320px; position: absolute; width: 287px"></asp:TextBox>
        <asp:Label ID="LabelSearchStoredPayments" runat="server" style="z-index: 1; left: 641px; top: 381px; position: absolute; width: 264px" Text="Search Stored Payments Here"></asp:Label>
        <asp:Label ID="LabelError" runat="server" style="z-index: 1; left: 635px; top: 314px; position: absolute; width: 49px" Text="Error"></asp:Label>
    </div>

</asp:Content>
