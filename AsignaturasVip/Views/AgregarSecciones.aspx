<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarSecciones.aspx.cs" Inherits="AsignaturasVip.Views.AgregarSecciones" %>

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
            width: 76px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td colspan="2">Agregar Secciones</td>
                </tr>
                <tr>
                    <td class="auto-style2">Codigo:</td>
                    <td>
            <asp:TextBox ID="TxtCodigo" placeholder="Código" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style2">Nombre:</td>
                    <td>

            <asp:TextBox ID="TxtNombre" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style2">Asignatura:</td>
                    <td>
            
                        <asp:DropDownList ID="DropAsignatura" runat="server" ></asp:DropDownList></td>
                </tr>
                <tr>
                    <td colspan="2">

            <asp:Button ID="BtnAgregar" runat="server" Text="Agregar" Width="56px" OnClick="BtnAgregar_Click" />
                    </td>
                </tr>
            </table>
            <br />

            <asp:Label ID="LbMensaje" runat="server" Text=""></asp:Label>

            <br />
            
            <br />

        </div>
    </form>
</body>
</html>
