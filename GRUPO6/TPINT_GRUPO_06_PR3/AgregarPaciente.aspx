<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarPaciente.aspx.cs" Inherits="TPINT_GRUPO_06_PR3.AgregarPaciente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 514px;
        }
        .auto-style2 {
            width: 182px;
        }
        .auto-style3 {
            width: 182px;
            height: 25px;
        }
        .auto-style4 {
            height: 25px;
        }
        .auto-style5 {
            text-decoration: underline;
            color: #0000FF;
        }
        .auto-style10 {
            height: 25px;
            width: 352px;
        }
        .auto-style11 {
            width: 352px;
        }
        .auto-style12 {
            height: 25px;
            width: 401px;
        }
        .auto-style13 {
            width: 401px;
        }
        .auto-style14 {
            width: 182px;
            height: 24px;
        }
        .auto-style15 {
            width: 352px;
            height: 24px;
        }
        .auto-style16 {
            width: 401px;
            height: 24px;
        }
        .auto-style17 {
            height: 24px;
        }
        .auto-style18 {
            height: 25px;
            width: 76px;
        }
        .auto-style19 {
            width: 76px;
        }
        .auto-style20 {
            height: 24px;
            width: 76px;
        }
        .auto-style9 {
            color: #FF0000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style3"><strong>
                    Usuario:
                    <asp:Label ID="lblNombre" runat="server"></asp:Label>
                    </strong></td>
                <td class="auto-style10"></td>
                <td class="auto-style12"></td>
                <td class="auto-style18"></td>
                <td class="auto-style4"></td>
                <td class="auto-style4"><strong>
                    <asp:HyperLink ID="HyperLink1" runat="server" CssClass="auto-style5" NavigateUrl="~/Administradores.aspx">Volver</asp:HyperLink>
                    </strong></td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style11">Ingrese DNI:</td>
                <td class="auto-style13">
                    <asp:TextBox ID="txtDNI" runat="server" Width="369px"></asp:TextBox>
                </td>
                <td class="auto-style19">
                    <asp:RequiredFieldValidator ID="rfvDNI" runat="server" ControlToValidate="txtDNI" ErrorMessage="Complete el campo DNI">*</asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style11">Ingrese Nombre:</td>
                <td class="auto-style13">
                    <asp:TextBox ID="txtNombre" runat="server" Width="369px"></asp:TextBox>
                </td>
                <td class="auto-style19">
                    <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ControlToValidate="txtNombre" ErrorMessage="Complete el campo Nombre">*</asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style11">Ingrese Apellido:</td>
                <td class="auto-style13">
                    <asp:TextBox ID="txtApellido" runat="server" Width="366px"></asp:TextBox>
                </td>
                <td class="auto-style19">
                    <asp:RequiredFieldValidator ID="rfvApellido" runat="server" ControlToValidate="txtApellido" ErrorMessage="Complete el campo Apellido">*</asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style14"></td>
                <td class="auto-style15">Ingrese Sexo: &nbsp;</td>
                <td class="auto-style16">
                    <asp:CheckBoxList ID="cblSexo" runat="server" Width="228px" RepeatDirection="Horizontal">
                        <asp:ListItem>F</asp:ListItem>
                        <asp:ListItem>M</asp:ListItem>
                        <asp:ListItem>Otro</asp:ListItem>
                    </asp:CheckBoxList>
                </td>
                <td class="auto-style20"></td>
                <td class="auto-style17"></td>
                <td class="auto-style17"></td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style11">Ingrese Nacionalidad:</td>
                <td class="auto-style13">
                    <asp:TextBox ID="txtNacionalidad" runat="server" Width="366px"></asp:TextBox>
                </td>
                <td class="auto-style19">
                    <asp:RequiredFieldValidator ID="rfvNacionalidad" runat="server" ControlToValidate="txtNacionalidad" ErrorMessage="Complete el Campo Nacionalidad">*</asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style11">Ingrese Fecha de Nacimiento:</td>
                <td class="auto-style13">
                    <asp:TextBox ID="txtFechaNacimiento" runat="server" Width="366px"></asp:TextBox>
                </td>
                <td class="auto-style19">
                    <asp:RequiredFieldValidator ID="rfvFechaNacimiento" runat="server" ControlToValidate="txtFechaNacimiento" ErrorMessage="Complete el campo Fecha Nacimiento">*</asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style11">Ingrese Provincia:</td>
                <td class="auto-style13">
                    <asp:DropDownList ID="ddlProvincia" runat="server" Height="72px" Width="379px" AutoPostBack="True" OnSelectedIndexChanged="ddlProvincia_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td class="auto-style19">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style11">Ingrese localidad:</td>
                <td class="auto-style13">
                    <asp:DropDownList ID="ddlLocalidad" runat="server" Height="72px" Width="379px" OnSelectedIndexChanged="ddlLocalidad_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td class="auto-style19">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style10">Ingrese Dirección:</td>
                <td class="auto-style12">
                    <asp:TextBox ID="txtDireccion" runat="server" Width="366px"></asp:TextBox>
                </td>
                <td class="auto-style18">
                    <asp:RequiredFieldValidator ID="rfvDireccion" runat="server" ControlToValidate="txtDireccion" ErrorMessage="Complete el campo Direccion">*</asp:RequiredFieldValidator>
                </td>
                <td class="auto-style4"></td>
                <td class="auto-style4"></td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style11">Ingrese Correo Electronico:</td>
                <td class="auto-style13">
                    <asp:TextBox ID="txtCorreoElectronico" runat="server" Width="366px"></asp:TextBox>
                </td>
                <td class="auto-style19">
                    <asp:RequiredFieldValidator ID="rfvCorreoElectronico" runat="server" ControlToValidate="txtCorreoElectronico" ErrorMessage="Complete el campo Correo Electronico">*</asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style11">Ingrese Teléfono:</td>
                <td class="auto-style13">
                    <asp:TextBox ID="txtTelefono" runat="server" Width="366px"></asp:TextBox>
                </td>
                <td class="auto-style19">
                    <asp:RequiredFieldValidator ID="rfvTelefono" runat="server" ControlToValidate="txtTelefono" ErrorMessage="Complete el campo Telefono">*</asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style19">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style11">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
                </td>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style19">
                    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" />
                </td>
                <td><strong>
                    <asp:Label ID="lblMensaje" runat="server" CssClass="auto-style9"></asp:Label>
                    </strong></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style19">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style19">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style19">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style19">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style19">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style19">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
