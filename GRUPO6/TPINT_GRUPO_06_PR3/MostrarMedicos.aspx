<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MostrarMedicos.aspx.cs" Inherits="TPINT_GRUPO_06_PR3.MostrarMedicos" %>

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
            width: 226px;
        }
        .auto-style3 {
            width: 332px;
        }
        .auto-style6 {
            width: 90px;
        }
        .auto-style9 {
            color: #FF0000;
        }
        .auto-style10 {
            margin-top: 0px;
        }
        .auto-style11 {
            width: 542px;
            height: 43px;
        }
        .auto-style12 {
            margin-top: 12px;
        }
        .auto-style13 {
            height: 43px;
        }
        .auto-style16 {
            font-size: small;
            font-weight: bold;
        }
        .auto-style18 {
            width: 377px;
        }
        .auto-style19 {
            width: 139px;
        }
        .auto-style20 {
            color: #FF0000;
            font-size: large;
        }
        .auto-style22 {
            width: 268px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">Usuario:
                        <asp:Label ID="lblNombre" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style3" style="font-size: x-large; text-decoration: underline"><strong>MENU MOSTRAR MEDICOS</strong><br />
                    </td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style19">&nbsp;</td>
                    <td class="auto-style22">&nbsp;</td>
                    <td class="auto-style18">&nbsp;</td>
                    <td>
                        <asp:HyperLink ID="hlVolver" runat="server" NavigateUrl="~/Administradores.aspx">Volver</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Ingrese el legajo del Medico:</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtBusqueda" runat="server" Width="311px"></asp:TextBox>
                        <br />
                        <strong>
                        <asp:Label ID="lblNoEncontro" runat="server" CssClass="auto-style9"></asp:Label>
                        </strong>
                    </td>
                    <td class="auto-style6">
                        <asp:RequiredFieldValidator ID="rfvBusqueda" runat="server" ControlToValidate="txtBusqueda" ErrorMessage="Complete el campo Busqueda">*</asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style19">
                        <asp:Button ID="BtnBuscar" runat="server" Text="Buscar" OnClick="BtnBuscar_Click" />
                    </td>
                    <td class="auto-style22">
                        <asp:Button ID="btnMostrarTodo" runat="server" Text="Mostrar Todo" OnClick="btnMostrarTodo_Click" ValidationGroup="Grupo_1" />
                    </td>
                    <td class="auto-style18">
                        Filtrar por:&nbsp;&nbsp;&nbsp;
                        <asp:DropDownList ID="ddlFiltros" runat="server" Height="19px" Width="182px">
                            <asp:ListItem Value="0">--Filtros--</asp:ListItem>
                            <asp:ListItem Value="1">Nombre</asp:ListItem>
                            <asp:ListItem Value="2">Apellido</asp:ListItem>
                            <asp:ListItem Value="3">Sexo</asp:ListItem>
                            <asp:ListItem Value="4">Sexo Descendiente</asp:ListItem>
                            <asp:ListItem Value="5">Especialidad</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:Button ID="btnFiltrar" runat="server" Text="Filtrar" ValidationGroup="Grupo_1" OnClick="btnFiltrar_Click" />
                    </td>
                </tr>
                </table>
        </div>
        <table class="auto-style1">
            <tr>
                <td>
                        <asp:GridView ID="gvMedicos" runat="server" Height="126px" Width="325px" CssClass="auto-style10" OnSelectedIndexChanged="gvMedicos_SelectedIndexChanged">
                        </asp:GridView>
                        <strong>&nbsp;&nbsp;&nbsp;
                        &nbsp;
                        </strong>
                    </td>
            </tr>
            </table>
        <table class="auto-style1">
            <tr>
                <td class="auto-style11">
                        <strong>
                        <asp:Button ID="btnEliminar" runat="server" CssClass="auto-style16" Height="31px" OnClick="btnEliminar_Click" Text="Eliminar" Width="84px" />
&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="lblEliminado" runat="server" CssClass="auto-style20"></asp:Label>
                        </strong>
                    </td>
                <td class="auto-style13"></td>
            </tr>
            <tr>
                <td class="auto-style11">
                        <asp:ValidationSummary ID="ValidationSummary2" runat="server" CssClass="auto-style12" Width="188px" />
                    </td>
                <td class="auto-style13"></td>
            </tr>
        </table>
    </form>
</body>
</html>
