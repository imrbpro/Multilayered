<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Multilayered.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
                <asp:Button Text="Add New User" ID="newuser" OnClick="newuser_Click" runat="server"/>
                <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            </center>
        </div>
    </form>
</body>
</html>
