﻿<%@ Page Title="" Language="C#" MasterPageFile="~/StrideTaxis.Master" AutoEventWireup="true" CodeBehind="Payment.aspx.cs" Inherits="STFrontEnd.Payment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="height: 550px;">

        <asp:ListBox ID="ListBoxStoredPayments" runat="server" style="z-index: 1; left: 21px; top: 42px; position: absolute; height: 314px; width: 356px"></asp:ListBox>













        <asp:Label ID="LabelCardNumber" runat="server" style="z-index: 1; left: 820px; top: 112px; position: absolute" Text="Card Number"></asp:Label>













        <asp:Label ID="LabelAccountNumber" runat="server" style="z-index: 1; left: 820px; top: 147px; position: absolute" Text="Account Number"></asp:Label>













        <asp:Label ID="LabelSortCode" runat="server" style="z-index: 1; left: 818px; top: 181px; position: absolute" Text="Sort Code"></asp:Label>













        <asp:Label ID="LabelExpiryDate" runat="server" style="z-index: 1; left: 820px; top: 216px; position: absolute" Text="Expiry Date"></asp:Label>













        <asp:Label ID="LabelValidFrom" runat="server" style="z-index: 1; left: 820px; top: 254px; position: absolute; margin-top: 0px;" Text="Valid From"></asp:Label>













        <asp:Label ID="LabelCardHolderName" runat="server" style="z-index: 1; left: 822px; top: 290px; position: absolute" Text="Card Holder's Name"></asp:Label>













        <asp:Label ID="LabelCVC" runat="server" style="z-index: 1; left: 825px; top: 327px; position: absolute" Text="CVC"></asp:Label>













        <asp:TextBox ID="TextBoxCardNumber" runat="server" style="z-index: 1; left: 765px; top: 41px; position: absolute; width: 301px;"></asp:TextBox>













        <asp:TextBox ID="TextBoxAccountNumber" runat="server" style="z-index: 1; left: 776px; top: 76px; position: absolute; width: 205px"></asp:TextBox>













        <asp:TextBox ID="TextBoxSortCode" runat="server" style="z-index: 1; left: 742px; top: 113px; position: absolute"></asp:TextBox>













        <asp:TextBox ID="TextBoxExpiryDate" runat="server" style="z-index: 1; left: 743px; top: 148px; position: absolute"></asp:TextBox>













        <asp:TextBox ID="TextBoxValidFrom" runat="server" style="z-index: 1; left: 742px; top: 187px; position: absolute"></asp:TextBox>













        <asp:TextBox ID="TextBoxCardHolderName" runat="server" style="z-index: 1; left: 799px; top: 219px; position: absolute; width: 372px"></asp:TextBox>













        <asp:TextBox ID="TextBoxCVC" runat="server" style="z-index: 1; left: 720px; top: 258px; position: absolute"></asp:TextBox>













    </div>
</asp:Content>