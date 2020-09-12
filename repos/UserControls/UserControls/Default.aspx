<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UserControls.Default" %>

<%@ Register Src="~/QuizQuestion.ascx" TagPrefix="uc1" TagName="QuizQuestion" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="something" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:PlaceHolder ID="PlaceHolder1" runat="server">
                
                <uc1:QuizQuestion runat="server" ID="QuizQuestion1" />
                <uc1:QuizQuestion runat="server" ID="QuizQuestion2" />

            </asp:PlaceHolder>

            <asp:Label ID="lblDebug" runat="server" Text="Label"></asp:Label>

            <asp:HiddenField ID="HiddenField1" runat="server" />
            
            <asp:Button ID="btnSubmit" runat="server" Text="Submit Answer" OnClick="btnSubmit_Click"/>
        </div>
    </form>
</body>
</html>
