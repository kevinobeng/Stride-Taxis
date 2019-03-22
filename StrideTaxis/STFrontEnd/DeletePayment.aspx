<%@ Page Title="" Language="C#" MasterPageFile="~/StrideTaxis.Master" AutoEventWireup="true" CodeBehind="DeletePayment.aspx.cs" Inherits="STFrontEnd.DeletePayment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div style="height: 550px;">    

            <asp:Button ID="ButtonYes" runat="server" style="z-index: 1; left: 433px; top: 160px; position: absolute; width: 102px" Text="Yes" OnClick="ButtonYes_Click"/>
            <asp:Button ID="ButtonNo" runat="server" style="z-index: 1; left: 617px; top: 162px; position: absolute; width: 102px" Text="No" OnClick="ButtonNo_Click" />
            <asp:Label ID="LabelDeletePayment" runat="server" style="z-index: 1; left: 452px; top: 123px; position: absolute; width: 627px" Text="Click Yes To Delete The Selected Payment, or No To Return To Payment.aspx"></asp:Label>


        </div>
</asp:Content>
