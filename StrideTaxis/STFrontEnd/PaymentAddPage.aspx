<%@ Page Title="" Language="C#" MasterPageFile="~/StrideTaxis.Master" AutoEventWireup="true" CodeBehind="PaymentAddPage.aspx.cs" Inherits="STFrontEnd.PaymentAddPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="height: 550px;">

        <asp:Label ID="LabelCardNumber" runat="server" style="z-index: 1; left: 205px; top: 88px; position: absolute" Text="Card Number"></asp:Label>
        <asp:Label ID="LabelAccountNumber" runat="server" style="z-index: 1; left: 203px; top: 143px; position: absolute; right: 1019px;" Text="Account Number"></asp:Label>
        <asp:Label ID="LabelSortCode" runat="server" style="z-index: 1; left: 209px; top: 194px; position: absolute" Text="Sort Code"></asp:Label>
        <asp:Label ID="LabelExpiryDate" runat="server" style="z-index: 1; left: 202px; top: 248px; position: absolute" Text="Expiry Date"></asp:Label>
        <asp:Label ID="LabelValidFrom" runat="server" style="z-index: 1; left: 206px; top: 308px; position: absolute; margin-top: 0px;" Text="Valid From"></asp:Label>
        <asp:Label ID="LabelCardHolderName" runat="server" style="z-index: 1; left: 195px; top: 354px; position: absolute" Text="Card Holder's Name"></asp:Label>
        <asp:Label ID="LabelCVC" runat="server" style="z-index: 1; left: 202px; top: 404px; position: absolute" Text="CVC"></asp:Label>
        <asp:TextBox ID="TextBoxCardNumber" runat="server" style="z-index: 1; left: 513px; top: 89px; position: absolute; width: 301px;"></asp:TextBox>
        <asp:TextBox ID="TextBoxAccountNumber" runat="server" style="z-index: 1; left: 551px; top: 131px; position: absolute; width: 205px"></asp:TextBox>

        <asp:TextBox ID="TextBoxSortCode" runat="server" style="z-index: 1; left: 566px; top: 192px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBoxExpiryDate" runat="server" style="z-index: 1; left: 571px; top: 248px; position: absolute"></asp:TextBox>

        <asp:TextBox ID="TextBoxValidFrom" runat="server" style="z-index: 1; left: 572px; top: 306px; position: absolute"></asp:TextBox>

        <asp:TextBox ID="TextBoxCardHolderName" runat="server" style="z-index: 1; left: 467px; top: 347px; position: absolute; width: 372px; margin-top: 0px;"></asp:TextBox>
        <asp:TextBox ID="TextBoxCVC" runat="server" style="z-index: 1; left: 576px; top: 400px; position: absolute"></asp:TextBox>
    
        <asp:Label ID="LableError" runat="server" style="z-index: 1; left: 1012px; top: 284px; position: absolute" Text="Error"></asp:Label>
    
        <asp:Button ID="ButtonOK" runat="server" style="z-index: 1; left: 936px; top: 73px; position: absolute; width: 70px;" Text="OK" OnClick="ButtonOK_Click" />
    
        <asp:Button ID="ButtonCancel" runat="server" style="z-index: 1; left: 1032px; top: 75px; position: absolute; width: 70px;" Text="Cancel" />
    
    </div>
</asp:Content>
