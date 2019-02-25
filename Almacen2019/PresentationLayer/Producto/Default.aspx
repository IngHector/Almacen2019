<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PresentationLayer.Producto.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="tableProductos" runat="server">
                <Columns>
                    <asp:HyperLinkField DataNavigateUrlFields="id" DataNavigateUrlFormatString="Delete.aspx?id={0}" HeaderText="Options" Text="Delete" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
