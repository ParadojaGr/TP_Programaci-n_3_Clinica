<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Informes.aspx.cs" Inherits="TPINT_GRUPO_06_PR3.Informes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 152px;
        }
        .auto-style2 {
            width: 136px;
        }
        .auto-style3 {
            width: 612px;
            text-align: left;
            font-size: x-large;
            text-decoration: underline;
        }
        .auto-style4 {
            width: 136px;
            height: 33px;
        }
        .auto-style6 {
            height: 33px;
        }
        .auto-style7 {
            width: 136px;
            height: 156px;
        }
        .auto-style9 {
            height: 156px;
        }
        .auto-style10 {
            width: 522px;
        }
        .auto-style11 {
            width: 522px;
            height: 33px;
        }
        .auto-style12 {
            width: 522px;
            height: 156px;
        }
        .auto-style13 {
            width: 612px;
            height: 33px;
        }
        .auto-style14 {
            width: 612px;
            height: 156px;
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
                    <td class="auto-style3"><strong>MENU INFORMES</strong></td>
                    <td style="font-size: x-large; text-decoration: underline" class="auto-style10">&nbsp;</td>
                    <td>
                        <asp:HyperLink ID="hlVolver" runat="server" NavigateUrl="~/Administradores.aspx">Volver</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td colspan="2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4"></td>
                    <td class="auto-style13">
                        <asp:Button ID="btnInformeMEDxTUR" runat="server" Text="Medicos más turnos" OnClick="btnInformeMEDxTUR_Click" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnInformeESPxTUR" runat="server" Text="Especialidades con más turnos" OnClick="btnInformeESPxTUR_Click" Width="240px" />
                    </td>
                    <td class="auto-style11">
                        &nbsp;</td>
                    <td class="auto-style6"></td>
                </tr>
                <tr>
                    <td class="auto-style7"></td>
                    <td class="auto-style14">
                        <asp:GridView ID="gvInformes" runat="server" Width="475px">
                        </asp:GridView>
                    </td>
                    <td class="auto-style12">
                        </td>
                    <td class="auto-style9"></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
