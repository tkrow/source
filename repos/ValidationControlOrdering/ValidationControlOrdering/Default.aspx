<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ValidationControlOrdering.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Weird Items Store</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <h1><asp:Label ID="Label1" runat="server" Text="Weird Items Store"></asp:Label></h1>
            <h2><asp:Label ID="Label2" runat="server" Text="Walking Bonsai Tree"></asp:Label></h2>
            <h4><asp:Label ID="Label3" runat="server" Text="$59.99"></asp:Label></h4>

            <asp:TextBox ID="amountOrderedBox" runat="server" style="margin-top: 0px"></asp:TextBox>

            <br />
                       
            <br />
            <br />
            <br />
            <br />

            <asp:RadioButtonList ID="subscriptionList" runat="server">
                <asp:ListItem>Subscribe and Save</asp:ListItem>
                <asp:listitem>One-time Purchase</asp:listitem>
            </asp:RadioButtonList>

            <br />
            
            <asp:Button ID="submitOrder" runat="server" Text="Submit Order" OnClick="submitOrder_Click" />

            <br />

            <asp:Label ID="orderConfirmation" runat="server" Text=""></asp:Label>
            
            <br />

            I am aware that this is not up to specifications. I had to cut some features due to time
            and not being able to get some things to work without jumping hoops like a lion at a circus.
        </div>
    </form>
</body>
</html>
