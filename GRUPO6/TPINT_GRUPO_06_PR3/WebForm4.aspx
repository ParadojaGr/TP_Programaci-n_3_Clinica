<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="TPINT_GRUPO_06_PR3.WebForm4" %>

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
            height: 26px;
        }
        .auto-style5 {
            text-decoration: underline;
            color: #0000FF;
        }
        .auto-style6 {
            height: 32px;
        }
        .auto-style7 {
            height: 26px;
            width: 282px;
        }
        .auto-style8 {
            width: 282px;
        }
        .auto-style9 {
            height: 32px;
            width: 282px;
        }
        .auto-style10 {
            height: 26px;
            width: 173px;
        }
        .auto-style11 {
            width: 173px;
        }
        .auto-style12 {
            height: 32px;
            width: 173px;
        }
        .auto-style13 {
            height: 26px;
            width: 278px;
        }
        .auto-style14 {
            width: 278px;
        }
        .auto-style15 {
            height: 32px;
            width: 278px;
        }
        .auto-style16 {
            width: 173px;
            height: 29px;
        }
        .auto-style17 {
            width: 282px;
            height: 29px;
        }
        .auto-style18 {
            height: 29px;
        }
        .auto-style19 {
            width: 278px;
            height: 29px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style10">Usuario:
                    <asp:Label ID="lblNombre" runat="server"></asp:Label>
                </td>
                <td class="auto-style7"></td>
                <td class="auto-style2">
                    <asp:Label ID="lblMENúUsario" runat="server" Font-Size="XX-Large" Text="MENÚ CREAR USUARIO"></asp:Label>
                </td>
                <td class="auto-style13"></td>
                <td class="auto-style2"><strong>
                    <asp:HyperLink ID="HyperLink1" runat="server" CssClass="auto-style5">Volver</asp:HyperLink>
                    </strong></td>
            </tr>
            <tr>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style8">&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style14">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style16"></td>
                <td class="auto-style17">
                    <asp:Label ID="lblNombre_" runat="server" Text="Ingrese el DNI del Usuario: "></asp:Label>
                </td>
                <td class="auto-style18">
                    <asp:TextBox ID="txbDNI" runat="server" Width="281px"></asp:TextBox>
                </td>
                <td class="auto-style19">
                    <asp:RequiredFieldValidator ID="rfvDNI" runat="server" ControlToValidate="txbDNI">Complete el DNI</asp:RequiredFieldValidator>
                </td>
                <td class="auto-style18"></td>
            </tr>
            <tr>
                <td class="auto-style12"></td>
                <td class="auto-style9">
                    <asp:Label ID="lblUsuario" runat="server" Text="Ingrese el nombre del Usuario: "></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:TextBox ID="txbUSer" runat="server" Width="287px"></asp:TextBox>
                </td>
                <td class="auto-style15">
                    <asp:RequiredFieldValidator ID="rfvUser" runat="server" ControlToValidate="txbUSer">Complete el nombre de Usuario</asp:RequiredFieldValidator>
                </td>
                <td class="auto-style6"></td>
            </tr>
            <tr>
                <td class="auto-style16"></td>
                <td class="auto-style17">&nbsp;</td>
                <td class="auto-style18">&nbsp;</td>
                <td class="auto-style19">&nbsp;</td>
                <td class="auto-style18"></td>
            </tr>
            <tr>
                <td class="auto-style10"></td>
                <td class="auto-style7"></td>
                <td class="auto-style2"></td>
                <td class="auto-style13"></td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td class="auto-style11">
                    <asp:Label ID="lblErrorMensaje1" runat="server" Text="Error mensaje 1"></asp:Label>
                    <br />
                    <asp:Label ID="lblErrorMensaje2" runat="server" Text="Error mensaje 2"></asp:Label>
                </td>
                <td class="auto-style8">&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style14">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
