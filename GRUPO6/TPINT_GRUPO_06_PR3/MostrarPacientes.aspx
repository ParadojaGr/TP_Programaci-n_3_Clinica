<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MostrarPacientes.aspx.cs" Inherits="TPINT_GRUPO_06_PR3.MostrarPacientes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">

        .auto-style4 {
            width: 184px;
            height: 45px;
        }
        .auto-style5 {
            width: 330px;
            height: 45px;
        }
        .auto-style10 {
            height: 45px;
            width: 50px;
        }
        .auto-style6 {
            height: 45px;
        }
        .auto-style7 {
            width: 184px;
            height: 23px;
        }
        .auto-style8 {
            width: 330px;
            height: 23px;
        }
        .auto-style11 {
            height: 23px;
            width: 50px;
        }
        .auto-style9 {
            height: 23px;
        }
        .auto-style1 {
            width: 100%;
        }
        .auto-style12 {
            height: 23px;
            color: #FF0000;
        }
        .auto-style14 {
            width: 333px;
        }
        .auto-style16 {
            height: 61px;
        }
        .auto-style17 {
            height: 30px;
        }
        .auto-style18 {
            color: #FF0000;
            font-size: large;
        }
        .auto-style19 {
            font-weight: bold;
        }
        .auto-style20 {
            height: 45px;
            width: 391px;
        }
        .auto-style21 {
            height: 23px;
            width: 391px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
            <table class="auto-style1">
                <tr>
                    <td class="auto-style4">Usuario:
                        <asp:Label ID="lblNombre" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style5" style="font-size: x-large; text-decoration: underline">MENU MOSTRAR PACIENTES</td>
                    <td class="auto-style10"></td>
                    <td class="auto-style6"></td>
                    <td class="auto-style6"></td>
                    <td class="auto-style20">&nbsp;</td>
                    <td class="auto-style6">
                        <asp:HyperLink ID="hlVolver" runat="server" NavigateUrl="~/Administradores.aspx">Volver</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">Ingrese el Dni del Paciente:</td>
                    <td class="auto-style8">
                        <asp:TextBox ID="txtBusqueda" runat="server" Width="320px"></asp:TextBox>
                        <br />
                        <strong>
                        <asp:Label ID="lblNoEncontro" runat="server" CssClass="auto-style12"></asp:Label>
                        </strong>
                    </td>
                    <td class="auto-style11">
                        <asp:RequiredFieldValidator ID="rfvBusqueda" runat="server" ControlToValidate="txtBusqueda" ErrorMessage="Complete el campo Busqueda">*</asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style9">
                        <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
                    </td>
                    <td class="auto-style9">
                        <asp:Button ID="btnMostrarTodo" runat="server" Text="Mostrar Todo" OnClick="btnMostrarTodo_Click" ValidationGroup="Grupo_1" />
                    </td>
                    <td class="auto-style21">
                        Filtrar por:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:DropDownList ID="ddlFiltros" runat="server" Height="19px" Width="182px">
                            <asp:ListItem Value="0">--Filtros--</asp:ListItem>
                            <asp:ListItem Value="1">Nombre</asp:ListItem>
                            <asp:ListItem Value="2">Apellido</asp:ListItem>
                            <asp:ListItem Value="3">Sexo</asp:ListItem>
                            <asp:ListItem Value="4">Sexo Descendiente</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style9">
                        <asp:Button ID="btnFiltro" runat="server" Text="Filtrar" ValidationGroup="Grupo_1" OnClick="btnFiltro_Click" />
                    </td>
                </tr>
                </table>
        <div>
        </div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style14" rowspan="3">
                        <asp:GridView ID="GridViewPacientes" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="320px">
                        </asp:GridView>
                    </td>
                    <td class="auto-style16">&nbsp;&nbsp;&nbsp;
                        <strong><em>
                        <asp:Button ID="btnEliminar" runat="server" Height="32px" Text="Eliminar" Width="81px" CssClass="auto-style19" OnClick="btnEliminar_Click" />
                        </em></strong>&nbsp; <strong>
                        <asp:Label ID="lblEliminar" runat="server" CssClass="auto-style18"></asp:Label>
                        </strong>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style17"></td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <table class="auto-style1">
                <tr>
                    <td>
                        <asp:ValidationSummary ID="ValidationSummary2" runat="server" Width="199px" />
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
    </form>
</body>
</html>
