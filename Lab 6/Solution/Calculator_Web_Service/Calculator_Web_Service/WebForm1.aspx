<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Calculator_Web_Service.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <h1>Calculator</h1>
        <asp:Label ID="Label1" runat="server" Text="First Number: "></asp:Label>
        <asp:TextBox ID="num1" runat="server"></asp:TextBox><br />
        <asp:Label ID="Label2" runat="server" Text="Second Number: "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
        <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="Subtract" />
        <asp:Button ID="Button3" runat="server" Text="Product" />
        <asp:Button ID="Button4" runat="server" Text="Division" />
        <br />
        <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
    </form>
</body>
    
</html>
