<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgeCalculation.aspx.cs" Inherits="Calculator_Web_Service.AgeCalculation1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Age Calculation</h1>
            <asp:Label ID="Label1" runat="server" Text="Enter Year: "></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" TextMode="Number"></asp:TextBox><br />
            <asp:Label ID="Label2" runat="server" Text="Enter Month: "></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Number"></asp:TextBox><br />
            <asp:Label ID="Label3" runat="server" Text="Enter Month: "></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" TextMode="Number"></asp:TextBox><br />
            <asp:Button ID="Button1" runat="server" Text="Calculate" /><br />
            <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
