<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GridViewPage.aspx.cs" Inherits="DatabaseConnection.GridViewPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="vin" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" style="margin-right: 0px">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="vin" HeaderText="vin" ReadOnly="True" SortExpression="vin" />
                    <asp:BoundField DataField="make" HeaderText="make" SortExpression="make" />
                    <asp:BoundField DataField="model" HeaderText="model" SortExpression="model" />
                    <asp:BoundField DataField="year" HeaderText="year" SortExpression="year" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\myDatabase.mdf;Integrated Security=True" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [Cars]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
