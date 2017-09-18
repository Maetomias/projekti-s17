<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="T6_laskin.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="True" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <asp:Button ID="plusBtn" runat="server" OnClick="plusBtn_Click" Text="+" />
            <asp:Button ID="minusBtn" runat="server" OnClick="minusBtn_Click" Text="-" />
        </div>
        <p>
            <asp:TextBox ID="TextBox2" runat="server" AutoPostBack="True" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
            <asp:Button ID="kertoBtn" runat="server" OnClick="kertoBtn_Click" Text="*" />
            <asp:Button ID="jakoBtn" runat="server" OnClick="jakoBtn_Click" Text="/" />
        </p>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    </form>
</body>
</html>
