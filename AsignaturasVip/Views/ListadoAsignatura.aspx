<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListadoAsignatura.aspx.cs" Inherits="AsignaturasVip.Views.ListadoAsignatura" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GrdLista" runat="server" OnSelectedIndexChanged="GrdLista_SelectedIndexChanged"></asp:GridView>
        </div>
    </form>
    <asp:LinkButton ID="LnkAsignaturas" runat="server" OnClick="LnkAsignaturas_Click">Agregar Asignaturas</asp:LinkButton><br />
    <asp:LinkButton ID="LnkSecciones" runat="server" OnClick="LnkSecciones_Click">Lista de secciones</asp:LinkButton>
</body>
</html>
