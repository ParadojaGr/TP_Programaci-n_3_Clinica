<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModificarPacientes.aspx.cs" Inherits="TPINT_GRUPO_06_PR3.ModificarEliminarPacientes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">

        .auto-style1 {
            width: 100%;
            height: 81px;
        }
        .auto-style15 {
            width: 249px;
        }
        .auto-style3 {
            text-decoration: underline;
            font-size: x-large;
            width: 1148px;
        }
        .auto-style16 {
            width: 12px;
        }
        .auto-style10 {
            width: 249px;
            height: 25px;
        }
        .auto-style14 {
            width: 1148px;
            height: 25px;
        }
        .auto-style11 {
            width: 12px;
            height: 25px;
        }
        .auto-style12 {
            height: 25px;
        }
        .auto-style17 {
            width: 100%;
        }
        .auto-style18 {
            margin-right: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style15"><strong>Usuario:
                        <asp:Label ID="lblNombre" runat="server"></asp:Label>
                        </strong>
                    </td>
                    <td class="auto-style3"><strong>MENU EDITAR PACIENTES</strong></td>
                    <td class="auto-style16"></td>
                    <td>
                        <asp:HyperLink ID="hlVolver" runat="server" NavigateUrl="~/Administradores.aspx">Volver</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style10"></td>
                    <td class="auto-style14"></td>
                    <td class="auto-style11"></td>
                    <td class="auto-style12"></td>
                </tr>
            </table>
        </div>
        <table class="auto-style17">
            <tr>
                <td>
                    <asp:GridView ID="gvPacientes" runat="server" AutoGenerateEditButton="True" AutoGenerateColumns="False" CssClass="auto-style18" OnRowCancelingEdit="gvPacientes_RowCancelingEdit" OnRowEditing="gvPacientes_RowEditing" OnRowUpdating="gvPacientes_RowUpdating">
                        <Columns>
                            <asp:TemplateField HeaderText="DNI">
                                    <EditItemTemplate>
                                        <asp:Label ID="lbl_eit_DNI" runat="server" Text='<%# Bind("DNI_PAC") %>'></asp:Label>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_it_DNI" runat="server" Text='<%# Bind("DNI_PAC") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                 <asp:TemplateField HeaderText="Nombre">
                                     <EditItemTemplate>
                                         <asp:TextBox ID="txt_Nombre_PAC" runat="server" Height="17px" Text='<%# Bind("Nombre_PAC") %>' Width="220px"></asp:TextBox>
                                     </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_it_Nombre" runat="server" Text='<%# Bind("Nombre_PAC") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Apellido">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="txt_Apellido_PAC" runat="server" Height="17px" Text='<%# Bind("Apellido_PAC") %>' Width="220px"></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_it_Apellido" runat="server" Text='<%# Bind("Apellido_PAC") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Sexo">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="txt_Sexo_PAC" runat="server" Height="17px" Text='<%# Bind("Sexo_PAC") %>' Width="220px"></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_it_Sexo" runat="server" Text='<%# Bind("Sexo_PAC") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Nacionalidad">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="txt_Nacionalidad_PAC" runat="server" Height="17px" Text='<%# Bind("Nacionalidad_PAC") %>' Width="220px"></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_it_Nacionalidad" runat="server" Text='<%# Bind("Nacionalidad_PAC") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Fecha de Nacimiento">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="txt_Nacimiento_PAC" runat="server" Height="17px" Text='<%# Bind("FechaNacimiento_PAC") %>' Width="220px"></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_it_FechaNacimiento" runat="server" Text='<%# Bind("FechaNacimiento_PAC") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Dirección">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="txt_Direccion_PAC" runat="server" Height="17px" Text='<%# Bind("Direccion_PAC") %>' Width="220px"></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_it_Direccion" runat="server" Text='<%# Bind("Direccion_PAC") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Provincia">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="txt_Provincia_PAC" runat="server" Height="17px" Text='<%# Bind("Provincia_PAC") %>' Width="220px"></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_it_Provincia" runat="server" Text='<%# Bind("Provincia_PAC") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Localidad">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="txt_Localidades" runat="server" Height="16px" Text='<%# Bind("Localidad_PAC") %>' Width="213px"></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_it_Localidad" runat="server" Text='<%# Bind("Localidad_PAC") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Email">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="txt_Email_PAC" runat="server" Height="17px" Text='<%# Bind("Email_PAC") %>' Width="220px"></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_it_Email" runat="server" Text='<%# Bind("Email_PAC") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Teléfono">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="txt_Telefono_PAC" runat="server" Height="17px" Text='<%# Bind("Telefono_PAC") %>' Width="220px"></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_it_Telefono" runat="server" Text='<%# Bind("Telefono_PAC") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </td>
            </tr>
        </table>
        </div>
    </form>
</body>
</html>
