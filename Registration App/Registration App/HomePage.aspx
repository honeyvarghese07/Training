<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Registration_App.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home Page</title>
    <link rel="stylesheet" type="text/css" href="HomePage.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="row">
        <div class="column" runat="server">
            <asp:Button ID="activeusers" runat="server" Text="Show Active Users" onclick="ActiveUsers"/>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        </div>
        <div class="column" runat="server">
            <asp:Button ID="deletedusers" runat="server" Text="Show Deleted Users" onclick="DeletedUsers"></asp:Button>
            <asp:GridView ID="gridview2" runat="server"></asp:GridView>
        </div>
        <div class="column" runat="server">
            <asp:Button ID="inactiveusers" runat="server" Text="Show Inactive users" onclick="InactiveUsers"></asp:Button>
            <asp:GridView ID="gridview3" runat="server"></asp:GridView>
        </div>
       </div>
    </form>
</body>
</html>
