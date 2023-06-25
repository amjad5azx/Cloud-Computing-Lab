<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="ID: "></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Width="171px"></asp:TextBox><br />
            <asp:Label ID="Label2" runat="server" Text="Name: "></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" Width="169px"></asp:TextBox><br />
            <asp:Label ID="Label3" runat="server" Text="Department: "></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server" Width="168px"></asp:TextBox><br />
            <asp:Label ID="Label4" runat="server" Text="Batch: "></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox4" runat="server" Width="167px"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Create" OnClick="Button1_Click1" />
            <asp:Button ID="Button2" runat="server" Text="Update" OnClick="Button2_Click" />
            <asp:Button ID="Button3" runat="server" Text="Delete" OnClick="Button3_Click" />
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="stId" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="stId" HeaderText="stId" InsertVisible="False" ReadOnly="True" SortExpression="stId" />
                    <asp:BoundField DataField="stName" HeaderText="stName" SortExpression="stName" />
                    <asp:BoundField DataField="department" HeaderText="department" SortExpression="department" />
                    <asp:BoundField DataField="batch" HeaderText="batch" SortExpression="batch" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:StudentConnectionString2 %>" SelectCommand="SELECT * FROM [Detail]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
