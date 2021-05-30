<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="Registration_App.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
    <link rel="stylesheet" type="text/css" href="Login.css" />
</head>
<body>
    <form id="login" runat="server">
        <div>
            <asp:Label ID="heading" runat="server" Text="Login to your account"></asp:Label><br />
            <br />
            <asp:TextBox ID="email" runat="server" placeholder="Email ID" AutoPostBack="true"></asp:TextBox>
            <br /><br />
            <asp:TextBox ID="password" runat="server" Type="password" placeholder="Password"></asp:TextBox><br />
            <br />
            <asp:Button ID="loginbtn" runat="server" Type="submit" Text="Login" onclick="ButtonClick"/><br />
            <asp:Label ID="message1" runat="server"></asp:Label><br /> 
            <asp:Label ID="loginmsg" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
