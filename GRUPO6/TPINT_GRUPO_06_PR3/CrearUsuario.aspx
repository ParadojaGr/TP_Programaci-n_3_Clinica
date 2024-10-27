<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CrearUsuario.aspx.cs" Inherits="TPINT_GRUPO_06_PR3.CrearUsuario" %>

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
            width: 247px;
            height: 43px;
        }
        .auto-style3 {
            width: 174px;
        }
        .auto-style5 {
            width: 542px;
            height: 43px;
        }
        .auto-style6 {
            width: 296px;
        }
        .auto-style8 {
            width: 208px;
        }
        .auto-style9 {
            width: 312px;
            height: 35px;
        }
        .auto-style10 {
            height: 35px;
        }
        .auto-style11 {
            width: 174px;
            height: 61px;
        }
        .auto-style12 {
            width: 312px;
            height: 61px;
        }
        .auto-style13 {
            height: 61px;
        }
        .auto-style14 {
            width: 312px;
            height: 28px;
        }
        .auto-style15 {
            height: 28px;
        }
        .auto-style16 {
            height: 28px;
            width: 208px;
        }
        .auto-style17 {
            color: #FF0000;
        }
        .auto-style18 {
            color: #00CC66;
            font-size: medium;
        }
        .auto-style19 {
            width: 312px;
        }
        .auto-style20 {
            height: 43px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2" colspan="2">Usuario:
                        <asp:Label ID="lblNombre" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style5" colspan="3" style="font-size: x-large; text-decoration: underline"><strong>MENU CREAR USUARIO</strong></td>
                    <td style="font-size: x-large; text-decoration: underline" class="auto-style20">
                        <asp:HyperLink ID="hlVolver" runat="server" Font-Bold="False" Font-Size="Large" NavigateUrl="~/Administradores.aspx">Volver</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style19">&nbsp;</td>
                    <td colspan="4">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3" rowspan="2">&nbsp;</td>
                    <td class="auto-style19" rowspan="2">Ingrese Legajo del usuario:</td>
                    <td class="auto-style8" rowspan="2">
                        <asp:TextBox ID="txtLegajo" runat="server" Width="229px"></asp:TextBox>
                    </td>
                    <td class="auto-style6" colspan="2">
                        <strong>
                        <asp:Label ID="lblErrorDNI" runat="server" CssClass="auto-style17"></asp:Label>
                        </strong>
                    </td>
                    <td rowspan="2">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6" colspan="2">
                        <asp:RequiredFieldValidator ID="rfvDNI" runat="server" ControlToValidate="txtLegajo" ErrorMessage="Complete el campo DNI">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style19">Ingrese un nombre para el&nbsp; usuario:</td>
                    <td colspan="4">
                        <asp:TextBox ID="txtUsuario" runat="server" Width="229px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvUsuario" runat="server" ControlToValidate="txtUsuario" ErrorMessage="Complete el campo Usuario">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3" rowspan="3">&nbsp;</td>
                    <td class="auto-style9">Ingrese una contraseña para el usuario:</td>
                    <td class="auto-style10" colspan="4">
                        <asp:TextBox ID="txtContraseña" runat="server" Width="229px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvContraseña" runat="server" ControlToValidate="txtContraseña" ErrorMessage="Complete el campo Contraseña">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style14" rowspan="2">Confirme la contraseña:</td>
                    <td class="auto-style16" rowspan="2">
                        <asp:TextBox ID="txtConfirmarContraseña" runat="server" Width="229px"></asp:TextBox>
                    </td>
                    <td class="auto-style15">
                        &nbsp;</td>
                    <td class="auto-style15" colspan="2" rowspan="2">&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:CompareValidator ID="cpvConfirmarContraseña" runat="server" ControlToCompare="txtContraseña" ControlToValidate="txtConfirmarContraseña" ErrorMessage="las contraseñas no coinciden ">*</asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style11">
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
                    </td>
                    <td class="auto-style12"></td>
                    <td class="auto-style13" colspan="4">
                        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" />
                    &nbsp; <strong>
                        <asp:Label ID="lblMensaje" runat="server" CssClass="auto-style18"></asp:Label>
                        </strong>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
