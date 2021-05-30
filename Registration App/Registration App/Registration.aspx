<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Registration_App.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration Form</title>
    <link rel="stylesheet" runat="server" type="text/css" href="RegistrationForm.css" />
</head>
<body>
    <form id="regsiter" runat="server" >
        <div id="div1">
            <asp:Label ID="Heading" runat="server" Text="Register Here!"></asp:Label><br />
            <br />
            <asp:TextBox ID="fname" runat="server" placeholder="First Name"></asp:TextBox><br />
            <asp:Label ID="message" runat="server"></asp:Label><br /><br />
            <asp:TextBox ID="lname" runat="server" placeholder="Last Name"></asp:TextBox><br />
            <asp:Label ID="message2" runat="server"></asp:Label><br /><br />
            <asp:TextBox ID="emailid" runat="server" placeholder="Email ID"></asp:TextBox><br />
            <asp:Label ID="message3" runat="server"></asp:Label><br /><br />
            <asp:TextBox ID="phone" runat="server" placeholder="Phone Number" type="Number"></asp:TextBox><br />
            <asp:Label ID="message4" runat="server"></asp:Label><br />
            <asp:RadioButtonList ID="gender" runat="server">
                <asp:ListItem Value="Male"></asp:ListItem>
                <asp:ListItem Value="Female"></asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <asp:Label ID="date" runat="server" Text="DOB"></asp:Label><br />
            <asp:TextBox ID="dob" runat="server" TextMode="Date" ></asp:TextBox><br />
            <asp:Label ID="messagedob" runat="server"></asp:Label>
            <br />
            <asp:TextBox ID="address" runat="server" placeholder="Address" /><br />
            <br />
            <asp:DropDownList ID="country" runat="server">
              <asp:ListItem Value="">Select Country</asp:ListItem>  
              <asp:ListItem Value="Canada"></asp:ListItem>  
              <asp:ListItem Value="Germany"></asp:ListItem>  
              <asp:ListItem Value="India"></asp:ListItem>  
              <asp:ListItem Value="USA"></asp:ListItem>  
            </asp:DropDownList><br />
            <br />
            <asp:TextBox ID="password" runat="server" type="password" placeholder="Password"></asp:TextBox><br />
            <asp:Label ID="message6" runat="server"></asp:Label><br /><br />
            <asp:Button ID="registerbtn" Type="submit" runat="server" Text="Register" onClick="RegisterClick" />
            <asp:Button ID="resetbtn" runat="server" Type="reset" Text="Reset" /><br />
            <br />
            <asp:CheckBox ID="checkbox1" runat="server"/>
            <asp:Label ID="terms" runat="server" Text="I agree to the terms and conditions"></asp:Label><br />
            <br />
            
        </div> 
    </form>
</body>
</html>
