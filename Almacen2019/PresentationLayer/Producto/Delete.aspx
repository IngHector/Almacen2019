<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Delete.aspx.cs" Inherits="PresentationLayer.Producto.Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblProducto" runat="server" Text="Label"></asp:Label>
            <input type="hidden" id="idDelete" name="id" runat="server"/>
&nbsp;<asp:Button ID="btnConfirmar" runat="server" Text="Confirmar" OnClick="btnConfirmar_Click" />
        </div>
    </form>
</body>
</html>
