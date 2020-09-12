<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SqlDataSourceExampleAgain.aspx.cs" Inherits="DatabaseConnection.SqlDataSourceExampleAgain" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Cars]" DeleteCommand="DELETE FROM [Cars] WHERE [vin] = @vin" InsertCommand="INSERT INTO [Cars] ([vin], [make], [model], [year], [isUnderInspection]) VALUES (@vin, @make, @model, @year, @isUnderInspection)" UpdateCommand="UPDATE [Cars] SET [make] = @make, [model] = @model, [year] = @year, [isUnderInspection] = @isUnderInspection WHERE [vin] = @vin">
                <DeleteParameters>
                    <asp:Parameter Name="vin" Type="String" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="vin" Type="String" />
                    <asp:Parameter Name="make" Type="String" />
                    <asp:Parameter Name="model" Type="String" />
                    <asp:Parameter Name="year" Type="String" />
                    <asp:Parameter Name="isUnderInspection" Type="Boolean" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="make" Type="String" />
                    <asp:Parameter Name="model" Type="String" />
                    <asp:Parameter Name="year" Type="String" />
                    <asp:Parameter Name="isUnderInspection" Type="Boolean" />
                    <asp:Parameter Name="vin" Type="String" />
                </UpdateParameters>
            </asp:SqlDataSource>
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataKeyNames="vin" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:CommandField ShowEditButton="True" ShowSelectButton="True" />
                <asp:BoundField DataField="vin" HeaderText="vin" ReadOnly="True" SortExpression="vin" />
                <asp:BoundField DataField="make" HeaderText="make" SortExpression="make" />
                <asp:BoundField DataField="model" HeaderText="model" SortExpression="model" />
                <asp:BoundField DataField="year" HeaderText="year" SortExpression="year" />
                <asp:CheckBoxField DataField="isUnderInspection" HeaderText="inspected" SortExpression="isUnderInspection" />
            </Columns>
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FFF1D4" />
            <SortedAscendingHeaderStyle BackColor="#B95C30" />
            <SortedDescendingCellStyle BackColor="#F1E5CE" />
            <SortedDescendingHeaderStyle BackColor="#93451F" />
        </asp:GridView>
    </form>
</body>
</html>
