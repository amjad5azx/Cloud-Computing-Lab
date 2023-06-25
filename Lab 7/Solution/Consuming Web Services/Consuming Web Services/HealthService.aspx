<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="HealthService.aspx.cs" Inherits="Consuming_Web_Services.HealthService" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="align-items:center;text-align:center">
       <h1>Health Services</h1>
            <h2>BMI Checker</h2>
            <asp:Label ID="Label1" runat="server" Text="Enter Weight: "></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" TextMode="Number"></asp:TextBox><br />
            <asp:Label ID="Label2" runat="server" Text="Enter Height: "></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Number"></asp:TextBox><br />
            <asp:Button ID="Button1" runat="server" Text="Calculate" Height="33px" OnClick="Button1_Click" /><br />
       <asp:Label ID="res1" runat="server" Text=""></asp:Label><br />
            <h2>Calories Burner Calculator</h2>
            <asp:Label ID="Label3" runat="server" Text="Enter Weight: "></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server" TextMode="Number"></asp:TextBox><br />
            <asp:Label ID="Label4" runat="server" Text="Enter Height: "></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox4" runat="server" TextMode="Number"></asp:TextBox><br />
            <asp:Label ID="Label5" runat="server" Text="Select Gender: "></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server" Width="190px">
                 <asp:ListItem Text="Male"></asp:ListItem>
                <asp:ListItem Text="Female"></asp:ListItem>
            </asp:DropDownList><br />
            <asp:Label ID="Label6" runat="server" Text="Enter Age: "></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;<asp:TextBox ID="TextBox5" runat="server" TextMode="Number"></asp:TextBox>
            <br />
            <asp:Button ID="Button2" runat="server" Text="Calculate" OnClick="Button2_Click" /><br />
       <asp:Label ID="res2" runat="server" Text=""></asp:Label><br />
    </div>
</asp:Content>
