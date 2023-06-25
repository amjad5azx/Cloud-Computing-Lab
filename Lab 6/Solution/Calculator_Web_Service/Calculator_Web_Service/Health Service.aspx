<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Health Service.aspx.cs" Inherits="Calculator_Web_Service.Health_Service" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Health Services</h1>
            <h2>BMI Checker</h2>
            <asp:Label ID="Label1" runat="server" Text="Enter Weight: "></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" TextMode="Number"></asp:TextBox><br />
            <asp:Label ID="Label2" runat="server" Text="Enter Height: "></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Number"></asp:TextBox><br />
            <asp:Button ID="Button1" runat="server" Text="Calculate" /><br />
            <h2>Calories Burner Calculator</h2>
            <asp:Label ID="Label3" runat="server" Text="Enter Weight: "></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" TextMode="Number"></asp:TextBox><br />
            <asp:Label ID="Label4" runat="server" Text="Enter Height: "></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server" TextMode="Number"></asp:TextBox><br />
            <asp:Label ID="Label5" runat="server" Text="Select Gender: "></asp:Label>
            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                <asp:ListItem Text="Male"></asp:ListItem>
                <asp:ListItem Text="Female"></asp:ListItem>
            </asp:RadioButtonList>
            <asp:Label ID="Label6" runat="server" Text="Enter Age: "></asp:Label>
            &nbsp;<asp:TextBox ID="TextBox5" runat="server" TextMode="Number"></asp:TextBox>
            <br />
            <asp:Button ID="Button2" runat="server" Text="Calculate" /><br />
        </div>
    </form>
</body>
</html>
