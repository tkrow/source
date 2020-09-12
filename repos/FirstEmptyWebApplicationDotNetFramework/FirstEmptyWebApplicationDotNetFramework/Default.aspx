<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FirstEmptyWebApplicationDotNetFramework.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Hello from Default.aspx!</h1>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label">This is a Label!</asp:Label>
            <asp:Label ID="Label2" runat="server" Text="This is also a Label, but uses the 'Text' property"></asp:Label>

            <br />

            <asp:Label ID="Label3" runat="server" Text="First Name: " AssociatedControlID="TextBox1"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Label ID="lblFirstNameError" runat="server" Text="Label" Visible="false" ForeColor="Red"></asp:Label>

            <br />

            <asp:Label ID="Label4" runat="server" Text="Last Name: " AssociatedControlID="TextBox2"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:Label ID="lblLastNameError" runat="server" Text="Label" Visible="false" ForeColor="Red"></asp:Label>


            <br />

            <!--
            <asp:RadioButton ID="RadioButton1" runat="server" GroupName="mediaChoice" Text="website" />
            <asp:RadioButton ID="RadioButton2" runat="server" GroupName="mediaChoice" Text="radio"/>
            <asp:RadioButton ID="RadioButton3" runat="server" GroupName="mediaChoice" Text="word of mouth"/>
            -->

            <br />
            <asp:Label ID="lblRadioButtonListError" runat="server" Text="Label" Visible="false" ForeColor="Red"></asp:Label>
            <br />
            <asp:RadioButtonList ID ="RadioButtonList1" runat="server">
                <asp:ListItem Text="Website" />
                <asp:ListItem Text="Radio" />
                <asp:ListItem Text="Word Of Mouth" />
        

            </asp:RadioButtonList>
            <br />

            <asp:Button ID="Button1" runat="server" Text="Submit Form"/>

        </div>
    </form>

    <asp:Panel ID="pnlThankYou" runat="server" Visible="false">
        <div>Thank you for submitting the form</div>
        <asp:Label ID="lblDisplayFirstName" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Label ID="lblDisplayLastName" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Label ID="lblDisplayRadioButtonOption" runat="server" Text="Label"></asp:Label>
    </asp:Panel>

</body>
</html>