﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SqlDataSourceExample.aspx.cs" Inherits="DatabaseConnection.SqlDataSourceExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:myConnectionString%>" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [Cars]"></asp:SqlDataSource>

        </div>
        <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1">
        </asp:GridView>
    </form>
</body>
</html>
