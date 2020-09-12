<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Exam_1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">

    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>Choose your favorite Gaming Platform:</asp:ListItem>
            <asp:ListItem>PC</asp:ListItem>
            <asp:ListItem>Playstation 4</asp:ListItem>
            <asp:ListItem>Switch</asp:ListItem>
            <asp:ListItem>XBOX One</asp:ListItem>
            </asp:DropDownList>

            <asp:Label ID="lblErrorMessage" runat="server" ForeColor="Red" Text="Please select a platform." Visible="False"></asp:Label>

        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit Form" OnButtonClick="submitForm" UseSubmitBehavior="False"/>
        <p>
            <asp:Label ID="lblOutput" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>