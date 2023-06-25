<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AgeCalculation.aspx.cs" Inherits="Consuming_Web_Services.AgeCalculation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="align-items:center;text-align:center">
        <h1>Age Calculation</h1>
            <asp:Label ID="Label1" runat="server" Text="Enter Year: "></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" TextMode="Number"></asp:TextBox><br />
            <asp:Label ID="Label2" runat="server" Text="Enter Month: "></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Number"></asp:TextBox><br />
            <asp:Label ID="Label3" runat="server" Text="Enter Day: "></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" TextMode="Number"></asp:TextBox><br />
            <asp:Button ID="Button1" runat="server" Text="Calculate" OnClick="Button1_Click" /><br />
            <asp:Label ID="res" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
