<%@ Page Title="" Language="C#" MasterPageFile="~/StrideTaxis.Master" AutoEventWireup="true" CodeBehind="PaymentAddPage.aspx.cs" Inherits="STFrontEnd.PaymentAddPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="height: 550px;">

        <asp:Label ID="LabelCardNumber" runat="server" style="z-index: 1; left: 195px; top: 105px; position: absolute" Text="Card Number"></asp:Label>
        <asp:Label ID="LabelAccountNumber" runat="server" style="z-index: 1; left: 194px; top: 139px; position: absolute" Text="Account Number"></asp:Label>
        <asp:Label ID="LabelSortCode" runat="server" style="z-index: 1; left: 192px; top: 174px; position: absolute" Text="Sort Code"></asp:Label>
        <asp:Label ID="LabelExpiryDate" runat="server" style="z-index: 1; left: 192px; top: 208px; position: absolute" Text="Expiry Date"></asp:Label>
        <asp:Label ID="LabelValidFrom" runat="server" style="z-index: 1; left: 191px; top: 243px; position: absolute; margin-top: 0px;" Text="Valid From"></asp:Label>
        <asp:Label ID="LabelCardHolderName" runat="server" style="z-index: 1; left: 191px; top: 272px; position: absolute" Text="Card Holder's Name"></asp:Label>
        <asp:Label ID="LabelCVC" runat="server" style="z-index: 1; left: 194px; top: 298px; position: absolute" Text="CVC"></asp:Label>
        <asp:TextBox ID="TextBoxCardNumber" runat="server" style="z-index: 1; left: 123px; top: 32px; position: absolute; width: 301px;"></asp:TextBox>
        <asp:TextBox ID="TextBoxAccountNumber" runat="server" style="z-index: 1; left: 138px; top: 67px; position: absolute; width: 205px"></asp:TextBox>

        <asp:TextBox ID="TextBoxSortCode" runat="server" style="z-index: 1; left: 102px; top: 103px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBoxExpiryDate" runat="server" style="z-index: 1; left: 102px; top: 139px; position: absolute"></asp:TextBox>

        <asp:TextBox ID="TextBoxValidFrom" runat="server" style="z-index: 1; left: 104px; top: 171px; position: absolute"></asp:TextBox>

        <asp:TextBox ID="TextBoxCardHolderName" runat="server" style="z-index: 1; left: 162px; top: 200px; position: absolute; width: 372px"></asp:TextBox>
        <asp:TextBox ID="TextBoxCVC" runat="server" style="z-index: 1; left: 68px; top: 228px; position: absolute"></asp:TextBox>
    
        <asp:Label ID="LableError" runat="server" style="z-index: 1; left: 203px; top: 373px; position: absolute" Text="Error"></asp:Label>
    
        <asp:Button ID="ButtonOK" runat="server" style="z-index: 1; left: 31px; top: 345px; position: absolute; width: 70px;" Text="OK" OnClick="ButtonOK_Click" />
    
        <asp:Button ID="ButtonCancel" runat="server" style="z-index: 1; left: 129px; top: 346px; position: absolute; width: 70px;" Text="Cancel" />
    
    </div>
</asp:Content>
