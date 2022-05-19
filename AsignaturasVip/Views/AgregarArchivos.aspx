<%--<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarArchivos.aspx.cs" Inherits="AsignaturasVip.Views.AgregarArchivos" %>--%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" class="btn btn-primary" runat="server">
        <div>
            <asp:TextBox ID="TxtCodigo" placeholder="Código" runat="server"></asp:TextBox>

            <asp:TextBox ID="TxtNombre" placeholder="Nombre" runat="server"></asp:TextBox>

            <asp:CheckBox ID="CkVisibilidad" runat="server" />

            <asp:Label ID="LbVisibilidad" for="CkVisibilidad" runat="server" Text="¿Visible?"></asp:Label>

            <asp:FileUpload ID="ArchivoUpload" runat="server" />

        </div>
    </form>
</body>
</html>
