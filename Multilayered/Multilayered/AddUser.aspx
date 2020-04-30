<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddUser.aspx.cs" Inherits="Multilayered.AddUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add User</title>
</head>
<body>
    <h1>Add New User</h1>
    <form id="form1" runat="server">
        <div>
            <input type ="text" placeholder="Username" runat="server" id="txtUsername"/>
            <input type ="password" placeholder="Password" runat="server" id="txtPassword"/>
            <input type ="text" placeholder="FirstName" runat="server" id="txtFirstname"/>
            <input type ="text" placeholder="LastName" runat="server" id="txtLastName"/>
            <textarea type ="textarea" placeholder="Hobby" runat="server" id="txtHobby"></textarea>
            <asp:Button ID="AddNewUser" Text="Add User" runat="server" OnClick="AddUser_Click"/>
        </div>
    </form>
</body>
</html>
