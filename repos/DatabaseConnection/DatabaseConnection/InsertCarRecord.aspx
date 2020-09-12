<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertCarRecord.aspx.cs" Inherits="DatabaseConnection.InsertCarRecord" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="VIN:"></asp:Label>
            <asp:TextBox ID="txtVin" runat="server"></asp:TextBox>

            <br />

             <asp:Label ID="Label2" runat="server" Text="Make:"></asp:Label>
            <asp:TextBox ID="txtMake" runat="server"></asp:TextBox>

            <br />

             <asp:Label ID="Label3" runat="server" Text="Model:"></asp:Label>
            <asp:TextBox ID="txtModel" runat="server"></asp:TextBox>

            <br />

             <asp:Label ID="Label4" runat="server" Text="Year:"></asp:Label>
            <asp:TextBox ID="txtYear" runat="server"></asp:TextBox>

            <br />

             <asp:Label ID="Label5" runat="server" Text="Inspected:"></asp:Label>
            <asp:CheckBox ID="chkInspected" runat="server" />
            
            <br />
            <asp:Button ID="btnSubmit" runat="server" Text="Create New Record" />
        </div>
    </form>
</body>
</html>
