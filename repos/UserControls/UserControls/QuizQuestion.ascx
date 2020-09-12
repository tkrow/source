<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="QuizQuestion.ascx.cs" Inherits="UserControls.QuizQuestion" %>
<asp:Panel ID="Panel1" runat="server">

    <asp:Label runat="server" Text="Question X" ID="lblQuestion" ></asp:Label>
    <asp:RadioButtonList ID="RadioButtonList1" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">      
        <asp:ListItem Value="A" Text="Answer 1"></asp:ListItem>
        <asp:ListItem Value="B" Text="Answer 2"></asp:ListItem>
        <asp:ListItem Value="C" Text="Answer 3"></asp:ListItem>
        <asp:ListItem Value="D" Text="Answer 4"></asp:ListItem>
    </asp:RadioButtonList>
    <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>

</asp:Panel>