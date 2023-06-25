<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="Consuming_Web_Services.Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="align-items:center;text-align:center">
        <h1>Add to Cart</h1>
        <asp:TextBox ID="txtItemName" runat="server"></asp:TextBox><br />
        <asp:Button ID="btnAddItem" runat="server" Text="Add" OnClick="btnAddItem_Click" />
        <br />
        <h2>Items List</h2>
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </div>
</asp:Content>
