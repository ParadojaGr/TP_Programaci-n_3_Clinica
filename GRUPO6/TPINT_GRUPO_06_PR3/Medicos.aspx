<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Medicos.aspx.cs" Inherits="TPINT_GRUPO_06_PR3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 569px;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style7 {
            width: 238px;
        }
        .auto-style9 {
            width: 238px;
            height: 30px;
        }
        .auto-style10 {
            height: 30px;
        }
        .auto-style11 {
            margin-left: 0px;
        }
        .auto-style13 {
            width: 116px;
            height: 30px;
        }
        .auto-style14 {
            width: 190px;
        }
        .auto-style16 {
            width: 201px;
            height: 30px;
        }
        .auto-style18 {
            width: 134px;
            height: 30px;
        }
        .auto-style20 {
            color: #FF0000;
        }
        .auto-style25 {
            width: 201px;
        }
        .auto-style26 {
            width: 116px;
        }
        .auto-style27 {
            height: 166px;
        }
        .auto-style28 {
            text-decoration: underline;
            font-size: x-large;
        }
        .auto-style30 {
            height: 41px;
        }
        .auto-style31 {
            width: 201px;
            height: 41px;
        }
        .auto-style32 {
            font-weight: bold;
        }
        .auto-style33 {
            font-size: x-large;
        }
        .auto-style34 {
            width: 218px;
            height: 41px;
        }
        .auto-style35 {
            width: 218px;
            height: 30px;
        }
        .auto-style36 {
            width: 218px;
        }
    </style>
</head>
<body style="height: 144px">
    <form id="form1" runat="server">
        <div class="auto-style1">
            <table class="auto-style2">
                <tr>
                    <td class="auto-style34">
                        <strong>
                        Usuario:
                        <asp:Label ID="lblNombre" runat="server"></asp:Label>
                        </strong>
                    </td>
                    <td class="auto-style30" colspan="4">
                        &nbsp;<strong><span class="auto-style33">&nbsp;&nbsp; </span><span class="auto-style28">MENU MEDICOS</span></strong>&nbsp;</td>
                    <td class="auto-style31"></td>
                    <td class="auto-style30">
                        <strong>
                        <asp:HyperLink ID="hylVolver" runat="server" NavigateUrl="~/Loggin.aspx">Volver</asp:HyperLink>
                        </strong>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style35" rowspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label1" runat="server" Text="Busqueda :"></asp:Label>
                    </td>
                    <td class="auto-style9" rowspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="txtBusqueda" runat="server" CssClass="auto-style11" Width="234px"></asp:TextBox>
                        <strong>
                        <asp:Label ID="lblNoEncontro" runat="server" CssClass="auto-style20"></asp:Label>
                        </strong> </td>
                    <td class="auto-style13">&nbsp;<asp:RequiredFieldValidator ID="rfvCompletarBusqueda" runat="server" ControlToValidate="txtBusqueda" ErrorMessage="Complete el campo de busqueda">*</asp:RequiredFieldValidator>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;</td>
                    <td class="auto-style13" rowspan="2">
                        <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
                    </td>
                    <td class="auto-style18" rowspan="2">
                        <asp:Button ID="btnMostrar" runat="server" Text="Mostrar todo" OnClick="btnMostrar_Click" />
                    </td>
                    <td class="auto-style16" rowspan="2">
                        <asp:DropDownList ID="ddlFiltros" runat="server" Height="19px" Width="182px">
                            <asp:ListItem>--Filtros--</asp:ListItem>
                            <asp:ListItem Value="1">Lunes</asp:ListItem>
                            <asp:ListItem Value="2">Martes</asp:ListItem>
                            <asp:ListItem Value="3">Miercoles</asp:ListItem>
                            <asp:ListItem Value="4">Jueves</asp:ListItem>
                            <asp:ListItem Value="5">Viernes</asp:ListItem>
                            <asp:ListItem Value="6">Sabado</asp:ListItem>
                            <asp:ListItem Value="7">Domingo</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style10" rowspan="2">
                        <asp:Button ID="btnFiltrar" runat="server" Text="Filtrar" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style26"></td>
                </tr>
                <tr>
                    <td class="auto-style27" colspan="7">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:GridView ID="gvTurnos" runat="server" Width="258px">
                        </asp:GridView>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style36">
                        <strong>&nbsp;
                        <br />
                        <asp:Button ID="btnIrAObservaciones" runat="server" CssClass="auto-style32" Text="Observaciones" OnClick="btnIrAObservaciones_Click" ValidationGroup="Grupo_1" />
                        </strong>
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
                    </td>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style14" colspan="3">&nbsp;</td>
                    <td class="auto-style25">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
