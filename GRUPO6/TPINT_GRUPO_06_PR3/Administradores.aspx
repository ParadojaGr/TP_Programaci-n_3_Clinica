<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Administradores.aspx.cs" Inherits="TPINT_GRUPO_06_PR3.WebForm2" %>

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
            width: 230px;
        }
        .auto-style3 {
            width: 283px;
        }
        .auto-style5 {
            width: 230px;
            height: 23px;
        }
        .auto-style6 {
            width: 283px;
            height: 23px;
        }
        .auto-style7 {
            height: 23px;
        }
        .auto-style9 {
            width: 207px;
        }
        .auto-style10 {
            width: 208px;
        }
        .auto-style11 {
            margin-left: 0px;
        }
        .auto-style12 {
            margin-left: 2px;
        }
        .auto-style13 {
            width: 251px;
        }
        .auto-style14 {
            font-size: medium;
        }
        .auto-style15 {
            text-decoration: underline;
            font-size: x-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <strong><span class="auto-style14">Usuario:</span></strong> <strong>
                    <asp:Label ID="lblNombre" runat="server" CssClass="auto-style14"></asp:Label>
                    </strong>
                </td>
                <td class="auto-style3">&nbsp;</td>
                <td colspan="3" class="auto-style15">
                    <strong>MENU ADMINISTRADORES</strong></td>
                <td>
                    <asp:HyperLink ID="hlVolver" runat="server" NavigateUrl="~/Loggin.aspx">Volver</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td class="auto-style5"></td>
                <td class="auto-style6"></td>
                <td class="auto-style7" colspan="3"></td>
                <td class="auto-style7"></td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <strong>
                    <asp:Button ID="btnAgregarMedico" runat="server" Text="Agregar Medico" Width="266px" OnClick="btnAgregarMedico_Click" />
                    </strong>
                </td>
                <td class="auto-style3">&nbsp;
                    <asp:Button ID="btnMostrarMedicos" runat="server" Text="Mostrar Medicos" Width="267px" OnClick="btnMostrarMedicos_Click1" />
&nbsp; 
                    </td>
                <td class="auto-style10">
                    <asp:Button ID="btnEditarBorrarMedicos" runat="server" OnClick="btnEditarBorrarMedicos_Click" Text="Modificar Medicos" Width="201px" />
                </td>
                <td class="auto-style13">
                    <asp:Button ID="btnCrearUsuario" runat="server" Text="Crear Usuario Medico" Width="242px" OnClick="btnCrearUsuario_Click" />
                </td>
                <td class="auto-style9">
                    <asp:Button ID="btnTurnos" runat="server" Text="Agregar Turnos" Width="196px" CssClass="auto-style11" OnClick="btnTurnos_Click" />
                </td>
                <td>
                    <asp:Button ID="btnInformes" runat="server" Text="Informes" Width="206px" OnClick="btnInformes_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="btnAgregarPaciente" runat="server" Text="Agregar Paciente" Width="265px" OnClick="btnAgregarPaciente_Click" />
                </td>
                <td class="auto-style3">&nbsp;
                    <asp:Button ID="btnMostrarPacientes" runat="server" Text="Mostrar Pacientes" Width="266px" OnClick="btnMostrarPacientes_Click" />
&nbsp; 
                    </td>
                <td class="auto-style10">
                    <asp:Button ID="btnEditarBorrarPacientes" runat="server" OnClick="btnEditarBorrarPacientes_Click" Text="Modificar Pacientes" Height="26px" Width="202px" />
                </td>
                <td class="auto-style13">
                    <asp:Button ID="btnEditarUsuario" runat="server" OnClick="btnEditarUsuario_Click" Text="Modificar Usuario" Width="243px" />
                </td>
                <td class="auto-style9">
                    <asp:Button ID="btnVerTurnos" runat="server" Text="Ver Turnos" Width="194px" CssClass="auto-style12" OnClick="btnVerTurnos_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td colspan="3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td colspan="3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
