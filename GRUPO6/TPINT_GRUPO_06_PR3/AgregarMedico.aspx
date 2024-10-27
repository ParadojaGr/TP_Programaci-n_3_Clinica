<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarMedico.aspx.cs" Inherits="TPINT_GRUPO_06_PR3.WebForm3" %>

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
        .auto-style3 {
            width: 184px;
        }
        .auto-style4 {
            height: 26px;
            width: 184px;
        }
        .auto-style5 {
            width: 362px;
        }
        .auto-style6 {
            height: 26px;
            width: 362px;
        }
        .auto-style9 {
            margin-left: 0px;
        }
        .auto-style10 {
            width: 181px;
        }
        .auto-style13 {
            width: 181px;
            height: 23px;
        }
        .auto-style14 {
            width: 365px;
            height: 23px;
        }
        .auto-style15 {
            width: 385px;
            height: 23px;
        }
        .auto-style16 {
            height: 23px;
        }
        .auto-style17 {
            width: 100%;
            height: 163px;
        }
        .auto-style19 {
            height: 26px;
            width: 386px;
        }
        .auto-style20 {
            width: 386px;
        }
        .auto-style22 {
            margin-left: 0px;
            color: #FF0000;
        }
        .auto-style23 {
            width: 365px;
        }
        .auto-style24 {
            width: 385px;
        }
        .auto-style25 {
            width: 181px;
            height: 25px;
        }
        .auto-style26 {
            width: 365px;
            height: 25px;
        }
        .auto-style27 {
            width: 385px;
            height: 25px;
        }
        .auto-style28 {
            height: 25px;
        }
        .auto-style29 {
            width: 181px;
            height: 66px;
        }
        .auto-style30 {
            width: 365px;
            height: 66px;
        }
        .auto-style31 {
            width: 385px;
            height: 66px;
        }
        .auto-style32 {
            height: 66px;
        }
        .auto-style33 {
            width: 365px;
            height: 23px;
            text-align: justify;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">
                    <strong>
                    Usuario:
                    <asp:Label ID="lblNombre" runat="server"></asp:Label>
                    </strong>
                </td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style20">&nbsp;</td>
                <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <strong>
                    <asp:HyperLink ID="hlVolver" runat="server" NavigateUrl="~/Administradores.aspx">Volver</asp:HyperLink>
                    </strong>
                </td>
            </tr>
            <tr>
                <td class="auto-style4"></td>
                <td class="auto-style6">Ingrese Legajo :</td>
                <td class="auto-style19"><asp:TextBox ID="txtLegajo" runat="server" Width="374px" CssClass="auto-style9"></asp:TextBox>
                </td>
                <td class="auto-style2">
                    <asp:RequiredFieldValidator ID="rfvLegajo" runat="server" ControlToValidate="txtLegajo" ErrorMessage="Complete el campo Legajo">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4"></td>
                <td class="auto-style6">Ingrese DNI :</td>
                <td class="auto-style19">
                    <asp:TextBox ID="txtDNI" runat="server" Width="369px"></asp:TextBox>
                </td>
                <td class="auto-style2">
                    <asp:RequiredFieldValidator ID="rfvDNI" runat="server" ControlToValidate="txtDNI" ErrorMessage="Complete el campo DNI">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4"></td>
                <td class="auto-style6">Ingrese Nombre :</td>
                <td class="auto-style19">
                    <asp:TextBox ID="txtNombre" runat="server" Width="373px"></asp:TextBox>
                </td>
                <td class="auto-style2">
                    <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ControlToValidate="txtNombre" ErrorMessage="Complete el campo Nombre">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style5">Ingrese Apellido:</td>
                <td class="auto-style20">
                    <asp:TextBox ID="txtApellido" runat="server" Width="374px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfvApellido" runat="server" ControlToValidate="txtApellido" ErrorMessage="Complete el campo Apellido">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style5">Ingrese Sexo:</td>
                <td class="auto-style20">
                    <strong>
                    <asp:CheckBoxList ID="cblSexo" runat="server" Width="259px" RepeatDirection="Horizontal" Height="27px">
                        <asp:ListItem>F</asp:ListItem>
                        <asp:ListItem>M</asp:ListItem>
                        <asp:ListItem>Otro</asp:ListItem>
                    </asp:CheckBoxList>
                    </strong>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style5">Ingrese Nacionalidad:</td>
                <td class="auto-style20">
                    <asp:TextBox ID="txtNacionalidad" runat="server" Width="374px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfvNacionalidad" runat="server" ControlToValidate="txtNacionalidad" ErrorMessage="Complete el campo Nacionalidad">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style5">Ingrese Fecha de Nacimiento:</td>
                <td class="auto-style20">
                    <asp:TextBox ID="txtFechaNac" runat="server" Width="374px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfvFechaNac" runat="server" ControlToValidate="txtFechaNac" ErrorMessage="Complete el campo Fecha">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style5">Ingrese la Provincia</td>
                <td class="auto-style20">
                    <asp:DropDownList ID="ddlProvincia" runat="server" Height="72px" Width="379px" AutoPostBack="True" OnSelectedIndexChanged="ddlProvincia_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style5">Ingrese la Localidad</td>
                <td class="auto-style20">
                    <asp:DropDownList ID="ddlLocalidad" runat="server" Height="31px" Width="380px" OnSelectedIndexChanged="ddlLocalidad_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style5">Ingrese Direccion:</td>
                <td class="auto-style20">
                    <asp:TextBox ID="txtDireccion" runat="server" Width="374px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfvDireccion" runat="server" ControlToValidate="txtDireccion" ErrorMessage="Complete el campo Direccion">*</asp:RequiredFieldValidator>
                </td>
            </tr>
        </table>
        <div>
            <table class="auto-style17">
                <tr>
                    <td class="auto-style10">&nbsp;</td>
                    <td class="auto-style23">Ingrese Correo Electronico:</td>
                    <td class="auto-style24">
                    <asp:TextBox ID="txtCorreo" runat="server" Width="374px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="rfvCorreo" runat="server" ControlToValidate="txtCorreo" ErrorMessage="Complete el campo Correo">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style10">&nbsp;</td>
                    <td class="auto-style23">Ingrese Teléfono:</td>
                    <td class="auto-style24">
                    <asp:TextBox ID="txtTelefono" runat="server" Width="374px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="rfvTelefono" runat="server" ControlToValidate="txtTelefono" ErrorMessage="Complete el campo Telefono">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style25"></td>
                    <td class="auto-style26">Ingrese especialidad:</td>
                    <td class="auto-style27">
                        <asp:DropDownList ID="ddlEspecialidades" runat="server" Height="17px" Width="381px">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style28">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style13"></td>
                    <td class="auto-style14">Ingrese Horario de Entrada:</td>
                    <td class="auto-style15">
                        <asp:TextBox ID="txtHorarioEntrada" runat="server" Width="374px"></asp:TextBox>
                    </td>
                    <td class="auto-style16">
                        <asp:RequiredFieldValidator ID="rfvHorarioEntrada" runat="server" ControlToValidate="txtHorarioEntrada" ErrorMessage="Complete el campo Horario de Entrada">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style13"></td>
                    <td class="auto-style14">Ingrese Horario de Salida:</td>
                    <td class="auto-style15">
                        <asp:TextBox ID="txtHorarioSalida" runat="server" Width="374px"></asp:TextBox>
                    </td>
                    <td class="auto-style16">
                        <asp:RequiredFieldValidator ID="rfvHorarioSalida" runat="server" ControlToValidate="txtHorarioSalida" ErrorMessage="Complete el campo Horario de Salida">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style13"></td>
                    <td class="auto-style33">Seleccione los dias de atencion:</td>
                    <td class="auto-style15">
                        <strong>
                        <asp:CheckBox ID="cbLunes" runat="server" Text="Lunes" />
                        <br />
                        </strong>
                        <br />
                        <strong>
                        <asp:CheckBox ID="cbMartes" runat="server" Text="Martes" />
                        <br />
                        </strong>
                        <br />
                        <strong>
                        <asp:CheckBox ID="cbMiercoles" runat="server" OnCheckedChanged="CheckBox3_CheckedChanged" Text="Miercoles" />
                        <br />
                        </strong>
                        <br />
                        <strong>
                        <asp:CheckBox ID="cbJueves" runat="server" Text="Jueves" />
                        <br />
                        </strong>
                        <br />
                        <strong>
                        <asp:CheckBox ID="cbViernes" runat="server" Text="Viernes" />
                        <br />
                        </strong>
                        <br />
                        <strong>
                        <asp:CheckBox ID="cbSabado" runat="server" Text="Sabado" />
                        <br />
                        </strong>
                        <br />
                        <strong>
                        <asp:CheckBox ID="cbDomingo" runat="server" Text="Domingo" />
                        </strong>
                    </td>
                    <td class="auto-style16">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style29"></td>
                    <td class="auto-style30">
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" Height="108px" />
                    </td>
                    <td class="auto-style31"></td>
                    <td class="auto-style32">
                        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" />
                    &nbsp; <strong>
                        <asp:Label ID="lblMensaje" runat="server" CssClass="auto-style22"></asp:Label>
                        </strong>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
