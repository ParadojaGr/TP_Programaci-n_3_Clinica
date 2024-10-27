<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarTurnos.aspx.cs" Inherits="TPINT_GRUPO_06_PR3.AgregarTurnos" %>

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
            width: 159px;
        }
        .auto-style3 {
            width: 348px;
        }
        .auto-style4 {
            width: 159px;
            height: 23px;
        }
        .auto-style5 {
            width: 348px;
            height: 23px;
        }
        .auto-style6 {
            height: 23px;
        }
        .auto-style9 {
            color: #FF0000;
        }
        .auto-style10 {
            width: 159px;
            height: 29px;
        }
        .auto-style11 {
            width: 300px;
            height: 29px;
        }
        .auto-style13 {
            height: 29px;
        }
        .auto-style14 {
            width: 159px;
            height: 72px;
        }
        .auto-style15 {
            width: 348px;
            height: 72px;
        }
        .auto-style16 {
            height: 72px;
        }
        .auto-style17 {
            width: 159px;
            height: 30px;
        }
        .auto-style18 {
            width: 348px;
            height: 30px;
        }
        .auto-style19 {
            height: 30px;
        }
        .auto-style22 {
            width: 605px;
            height: 30px;
        }
        .auto-style23 {
            width: 605px;
            height: 72px;
        }
        .auto-style24 {
            width: 605px;
            height: 29px;
        }
        .auto-style25 {
            width: 605px;
        }
        .auto-style26 {
            width: 605px;
            height: 23px;
        }
        .auto-style27 {
            width: 348px;
            height: 29px;
        }
        .auto-style28 {
            text-decoration: underline;
            color: #0000FF;
            background-color: #FFFFFF;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style14">Usuario:
                        <asp:Label ID="lblNombre" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style15" style="font-size: x-large; text-decoration: underline">MENU AGREGAR TURNOS</td>
                    <td class="auto-style23">&nbsp;</td>
                    <td class="auto-style16"><strong>
                        <asp:HyperLink ID="hlVolver" runat="server" CssClass="auto-style28" NavigateUrl="~/Administradores.aspx">Volver</asp:HyperLink>
                        </strong></td>
                </tr>
                <tr>
                    <td class="auto-style11">&nbsp;</td>
                    <td class="auto-style27">
                        &nbsp;</td>
                    <td class="auto-style24">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style17"></td>
                    <td class="auto-style18">
                        Ingrese DNI del Paciente:</td>
                    <td class="auto-style22">
                        <asp:TextBox ID="txbDNIPaciente" runat="server" Width="218px"></asp:TextBox>
                    </td>
                    <td class="auto-style19">
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4"></td>
                    <td class="auto-style3">Seleccione la Especialidad</td>
                    <td class="auto-style25">
                        <asp:DropDownList ID="ddlEspecialidades" runat="server" Width="229px" AutoPostBack="True" OnSelectedIndexChanged="ddlEspecialidades_SelectedIndexChanged">
                            <asp:ListItem>---------------------------------------------</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style10"></td>
                    <td class="auto-style5">Seleccione EL Medico:</td>
                    <td class="auto-style26">
                        <asp:DropDownList ID="ddlMed" runat="server" AutoPostBack="True" Height="16px" OnSelectedIndexChanged="ddlMed_SelectedIndexChanged1" Width="230px">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style6">
                    </td>
                </tr>
                <tr>
                    <td class="auto-style10"></td>
                    <td class="auto-style27">SeleccioneDía:</td>
                    <td class="auto-style24">
                        <asp:DropDownList ID="ddlDia" runat="server" Width="229px" OnSelectedIndexChanged="ddlDia_SelectedIndexChanged" AutoPostBack="True">
                            <asp:ListItem>---------------------------------------------</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style13">
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4"></td>
                    <td class="auto-style5">Seleccione Hora:</td>
                    <td class="auto-style26">
                        <asp:DropDownList ID="ddlHora" runat="server" Width="229px" AutoPostBack="True">
                            <asp:ListItem>---------------------------------------------</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style6">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td colspan="2">
                        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" />
                        <strong>&nbsp;
                        <asp:Label ID="lblError" runat="server" CssClass="auto-style9"></asp:Label>
                        </strong>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
