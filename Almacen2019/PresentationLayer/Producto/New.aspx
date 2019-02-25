<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="New.aspx.cs" Inherits="PresentationLayer.Producto.New" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label3" runat="server" Text="New Producto" Font-Size="X-Large"></asp:Label>
            <br />
            <asp:Label ID="lblClave" runat="server" Text="Clave"></asp:Label>
            <asp:TextBox ID="txtClave" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblnombre" runat="server" Text="Nombre"></asp:Label>
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblLinea" runat="server" Text="Linea"></asp:Label>
            <asp:DropDownList ID="comboLinea" runat="server">
            </asp:DropDownList>
            <br />
            <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" />
        </div>
    </form>
</body>
</html>
