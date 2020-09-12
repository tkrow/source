<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DefaultWithDynamicDropDown.aspx.cs" Inherits="DropDownListBasics.DefaultWithDynamicDropDown" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
        </div>
        <asp:Label ID="lblOutput" runat="server" Text="Label"></asp:Label>
        <asp:Button ID="Button1" runat="server" Text="Button" />
    </form>
</body>
</html>
