<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TotalOrdenes.aspx.cs" Inherits="AdventureWorksWeb.TotalOrdenes" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Total de Órdenes por Mes y Año</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Total de Órdenes por Mes y Año</h2>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="Year" HeaderText="Year" />
                    <asp:BoundField DataField="Month" HeaderText="Month" />
                    <asp:BoundField DataField="OrderCount" HeaderText="OrderCount" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
