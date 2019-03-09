<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="New.aspx.cs" Inherits="PresentationLayer.Linea.New" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="New Linea " Font-Bold="True" Font-Size="Larger"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblClave" runat="server" Text="Clave "></asp:Label>
            <asp:TextBox ID="txtClave" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblNombre" runat="server" Text="Nombre "></asp:Label>
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblinfo" runat="server" Text="Label" Visible="False"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" />
        &nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Inventario" />
        </div>
    </form>
</body>
</html>
