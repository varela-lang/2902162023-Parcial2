<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AdventureWorksWeb.Producto" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Detalle de Producto</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FormView ID="FormView1" runat="server">
                <ItemTemplate>
                    <h2>Detalle del Producto</h2>
                    <p><b>Nombre:</b> <%# Eval("EnglishProductName") %></p>
                    <p><b>Subcategoría:</b> <%# Eval("ProductSubcategoryName") %></p>
                    <p><b>Categoría:</b> <%# Eval("ProductCategoryName") %></p>
                </ItemTemplate>
            </asp:FormView>
        </div>
    </form>
</body>
</html>
