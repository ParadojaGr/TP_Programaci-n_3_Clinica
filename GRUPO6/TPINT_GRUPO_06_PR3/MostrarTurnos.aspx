<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MostrarTurnos.aspx.cs" Inherits="TPINT_GRUPO_06_PR3.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">

        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            height: 23px;
            width: 152px;
        }
        .auto-style5 {
            height: 23px;
            width: 315px;
        }
        .auto-style2 {
            height: 23px;
        }
        .auto-style7 {
            height: 23px;
            width: 142px;
        }
        .auto-style4 {
            width: 152px;
        }
        .auto-style6 {
            width: 315px;
        }
        .auto-style8 {
            width: 142px;
        }
        .auto-style9 {
            color: #FF0000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">Usuario:
                        <asp:Label ID="lblNombre" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style5" style="font-size: x-large; text-decoration: underline">MENU MOSTRAR TURNOS</td>
                    <td class="auto-style2"></td>
                    <td class="auto-style7"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2">
                        <asp:HyperLink ID="hlVolver" runat="server" Font-Bold="False" Font-Size="Large" NavigateUrl="~/Administradores.aspx">Volver</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Busqueda:</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="txtBusqueda" runat="server" Width="304px"></asp:TextBox>
                        <br />
                        <strong>
                        <asp:Label ID="lblNoEncontro" runat="server" CssClass="auto-style9"></asp:Label>
                        </strong>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="rfvBusqueda" runat="server" ErrorMessage="complete el campo Busqueda" ControlToValidate="txtBusqueda">*</asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style8">
                        <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
                    </td>
                    <td>
                        <asp:Button ID="btnMostrarTodo" runat="server" Text="Mostar todo" OnClick="btnMostrarTodo_Click" />
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlFiltros" runat="server" Height="19px" Width="182px">
                            <asp:ListItem>--Filtros--</asp:ListItem>
                            <asp:ListItem></asp:ListItem>
                            <asp:ListItem></asp:ListItem>
                            <asp:ListItem></asp:ListItem>
                            <asp:ListItem></asp:ListItem>
                            <asp:ListItem></asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:Button ID="btnFiltro" runat="server" Text="Filtrar" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style6">
                        <asp:GridView ID="gvTurnos" runat="server" Width="307px">
                        </asp:GridView>
                    </td>
                    <td>&nbsp;</td>
                    <td class="auto-style8">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" Width="175px" />
                    </td>
                    <td class="auto-style6">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style8">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
