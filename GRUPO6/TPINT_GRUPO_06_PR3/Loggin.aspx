<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Loggin.aspx.cs" Inherits="TPINT_GRUPO_06_PR3.Loggin" %>

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
            width: 150px;
        }
        .auto-style3 {
            height: 23px;
        }
        .auto-style4 {
            width: 150px;
            height: 92px;
        }
        .auto-style5 {
            height: 92px;
        }
        .auto-style6 {
            color: #FF0000;
        }
        .auto-style7 {
            text-decoration: underline;
            font-size: x-large;
        }
        .auto-style8 {
            font-weight: bold;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style4"></td>
                <td class="auto-style5"><span class="auto-style7"><strong>INICIO DE SESIÓN</strong></span> </td>
            </tr>
            <tr>
                <td class="auto-style2">USUARIO:</td>
                <td>
                    <asp:TextBox ID="txtUsuario" runat="server" Width="241px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvUsuario" runat="server" ControlToValidate="txtUsuario" ErrorMessage="Complete el campo usuario">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3" colspan="2"></td>
            </tr>
            <tr>
                <td>CONTRASEÑA:</td>
                <td>
                    <asp:TextBox ID="txtContraseña" runat="server" Width="240px" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvContraseña" runat="server" ControlToValidate="txtContraseña" ErrorMessage="Complete el campo contraseña">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <strong>
                    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" CssClass="auto-style8" OnClick="btnAceptar_Click" style="height: 26px" />
                    </strong>
                    <asp:ValidationSummary ID="Vs1" runat="server" />
                </td>
            </tr>
        </table>
        <strong>
        <asp:Label ID="lblError" runat="server" CssClass="auto-style6"></asp:Label>
        </strong>
    </form>
</body>
</html>
