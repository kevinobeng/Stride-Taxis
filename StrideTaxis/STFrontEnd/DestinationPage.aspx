﻿<%@ Page Title="" Language="C#" MasterPageFile="~/StrideTaxis.Master" AutoEventWireup="true" CodeBehind="DestinationPage.aspx.cs" Inherits="STFrontEnd.DestinationPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="btnDisplayDestination" runat="server" style="z-index: 1; left: 746px; top: 317px; position: absolute; width: 209px" Text="Display Popular Destinations" OnClick="btnDisplayDestination_Click"/>
    <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 662px; top: 407px; position: absolute; " Text="Label"></asp:Label>
    <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 580px; top: 318px; position: absolute; width: 75px;" Text="Delete" OnClick="btnDelete_Click"/>
    <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 495px; top: 319px; position: absolute; width: 75px;" Text="Add" OnClick="btnAdd_Click" />
    <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 665px; top: 318px; position: absolute; width: 75px;" Text="Edit" />
    <asp:ListBox ID="lstDestinations" runat="server" style="z-index: 1; left: 449px; top: 58px; position: absolute; height: 256px; width: 511px; margin-right: 2px"></asp:ListBox>
</asp:Content>