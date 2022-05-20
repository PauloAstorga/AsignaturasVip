<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarAsignaturas.aspx.cs" Inherits="AsignaturasVip.Views.AgregarAsignaturas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 133px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td colspan="2">Agregar Asignatura</td>
                </tr>
                <tr>
                    <td class="auto-style2">Codigo:</td>
                    <td>
                        <asp:TextBox ID="TxtCodigo" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Nombre:</td>
                    <td>
                        <asp:TextBox ID="TxtNombre" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Unidad:</td>
                    <td>
                        <asp:DropDownList ID="DropUnidad" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="Button1" runat="server" Text="Agregar" OnClick="Button1_Click" />
                    </td>
                </tr>
            </table>
        </div>
        <asp:Label ID="LbMensaje" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
