<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TreeView.aspx.cs" Inherits="Registration_App.TreeView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>TreeView</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>  
                <h3>Product Details</h3>  
                <hr />  
                <asp:TreeView ID="treeview1" runat="server" ShowCheckBoxes="All" style="display:contents"></asp:TreeView>  
       </div>  
    </form>
</body>
</html>
