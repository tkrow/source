<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ValidationBasics.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="validateFirstName" runat="server" ControlToValidate="txtFirstName" ErrorMessage="Please enter a value." Display="Dynamic"></asp:RequiredFieldValidator>
            <br />
            <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="validateLastName" runat="server" ControlToValidate="txtFirstName" ErrorMessage="Please enter a value." Display="Dynamic"></asp:RequiredFieldValidator>

            <br />
            <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator1" runat="server" Operator="GreaterThanEqual" ValueToCompare="18" Type="Integer" ErrorMessage="You must be 18 or older."></asp:CompareValidator>
            <asp:CompareValidator ID="CompareValidator2" runat="server" Operator="GreaterThanEqual" ValueToCompare="18" Type="Integer" ErrorMessage="Please enter a whole number."></asp:CompareValidator>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Button" />
            <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="CustomValidator" OnServerValidate="validateLastName"></asp:CustomValidator>
        </div>
    </form>
</body>
</html>
