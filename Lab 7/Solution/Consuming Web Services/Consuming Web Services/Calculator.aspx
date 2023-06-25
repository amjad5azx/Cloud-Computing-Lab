<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="Consuming_Web_Services.Calculator" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="align-items:center;text-align:center">
        <h1>Calculator</h1>
        <asp:Label ID="Label1" runat="server" Text="First Number: "></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="num1" runat="server"></asp:TextBox><br />
        <asp:Label ID="Label2" runat="server" Text="Second Number: "></asp:Label>
        <asp:TextBox ID="num2" runat="server"></asp:TextBox><br />
        <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="Subtract" OnClick="Button2_Click" />
        <asp:Button ID="Button3" runat="server" Text="Product" OnClick="Button3_Click" />
        <asp:Button ID="Button4" runat="server" Text="Division" OnClick="Button4_Click" />
        <br />
        <asp:Label ID="res" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
