<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModificarMedicos.aspx.cs" Inherits="TPINT_GRUPO_06_PR3.ModificarEliminarMedicos" %>

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
        .auto-style3 {
            text-decoration: underline;
            font-size: x-large;
            width: 1185px;
        }
        .auto-style10 {
            width: 149px;
            height: 25px;
        }
        .auto-style11 {
            width: 44px;
            height: 25px;
        }
        .auto-style12 {
            height: 25px;
        }
        .auto-style14 {
            width: 1185px;
            height: 25px;
        }
        .auto-style15 {
            width: 149px;
        }
        .auto-style16 {
            width: 44px;
        }
        .auto-style17 {
            width: 100%;
        }
        .auto-style18 {
            margin-right: 0px;
        }
    </style>
</head>
<body style="height: 71px">
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style15">Usuario:
                        <asp:Label ID="lblNombre" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style3"><strong>MENU EDITAR MEDICOS</strong></td>
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
                    <asp:GridView ID="gvMedicos" runat="server" AutoGenerateEditButton="True" AutoGenerateColumns="False" CssClass="auto-style18" OnRowCancelingEdit="gvMedicos_RowCancelingEdit" OnRowEditing="gvMedicos_RowEditing" OnRowUpdating="gvMedicos_RowUpdating" OnSelectedIndexChanged="gvMedicos_SelectedIndexChanged" Width="1618px">
                        <Columns>
                                <asp:TemplateField HeaderText="Legajo">
                                    <EditItemTemplate>
                                        <asp:Label ID="lbl_eit_Legajo" runat="server" Text='<%# Bind("Legajo_MED") %>'></asp:Label>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_Legajo" runat="server" Text='<%# Bind("Legajo_MED") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            <asp:TemplateField HeaderText="DNI">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="txt_DNI_MED" runat="server" Height="17px" Text='<%# Bind("DNI_MED") %>' Width="220px"></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_it_DNI" runat="server" Text='<%# Bind("DNI_MED") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                 <asp:TemplateField HeaderText="Nombre">
                                     <EditItemTemplate>
                                         <asp:TextBox ID="txt_Nombre_MED" runat="server" Height="17px" Text='<%# Bind("Nombre_MED") %>' Width="220px"></asp:TextBox>
                                     </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_it_Nombre" runat="server" Text='<%# Bind("Nombre_MED") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Apellido">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="txt_Apellido_MED" runat="server" Height="17px" Text='<%# Bind("Apellido_MED") %>' Width="220px"></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_it_Apellido" runat="server" Text='<%# Bind("Apellido_MED") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Sexo">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="txt_Sexo_MED" runat="server" Height="17px" Text='<%# Bind("Sexo_MED") %>' Width="220px"></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_it_Sexo" runat="server" Text='<%# Bind("Sexo_MED") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Nacionalidad">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="txt_Nacionalidad_MED" runat="server" Height="17px" Text='<%# Bind("Nacionalidad_MED") %>' Width="220px"></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_it_Nacionalidad" runat="server" Text='<%# Bind("Nacionalidad_MED") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Fecha de Nacimiento">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="txt_Nacimiento_MED" runat="server" Height="17px" Text='<%# Bind("FechaNacimiento_MED") %>' Width="220px"></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_it_FechaNacimiento" runat="server" Text='<%# Bind("FechaNacimiento_MED") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Dirección">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="txt_Direccion_MED" runat="server" Height="17px" Text='<%# Bind("Direccion_MED") %>' Width="220px"></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_it_Direccion" runat="server" Text='<%# Bind("Direccion_MED") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Especialidad">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="txt_Especialidad_MED" runat="server" Height="17px" Text='<%# Bind("Especialidad_MED") %>' Width="220px"></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_it_Especialidad" runat="server" Text='<%# Bind("Especialidad_MED") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Provincia">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="txt_Provincia_MED" runat="server" Height="17px" Text='<%# Bind("Provincia_MED") %>' Width="220px"></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_it_Provincia" runat="server" Text='<%# Bind("Provincia_MED") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Localidad">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="txt_Localidad_MED" runat="server" Height="17px" Text='<%# Bind("Localidad_MED") %>' Width="220px"></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_it_Localidad" runat="server" Text='<%# Bind("Localidad_MED") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Lunes">
                                    <EditItemTemplate>
                                        <asp:CheckBox ID="cb_Lunes" runat="server" Checked='<%# Bind("Dia_MED_1") %>' />
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_it_Lunes" runat="server" Text='<%# Bind("Dia_MED_1") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                 <asp:TemplateField HeaderText="Martes">
                                     <EditItemTemplate>
                                         <asp:CheckBox ID="cb_Martes" runat="server" Checked='<%# Bind("Dia_MED_2") %>' />
                                     </EditItemTemplate>
                                     <ItemTemplate>
                                         <asp:Label ID="lbl_it_Martes" runat="server" Text='<%# Bind("Dia_MED_2") %>'></asp:Label>
                                     </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Miercoles">
                                    <EditItemTemplate>
                                        <asp:CheckBox ID="cb_Miercoles" runat="server" Checked='<%# Bind("Dia_MED_3") %>' />
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_it_Miercoles" runat="server" Text='<%# Bind("Dia_MED_3") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Jueves">
                                    <EditItemTemplate>
                                        <asp:CheckBox ID="cb_Jueves" runat="server" Checked='<%# Bind("Dia_MED_4") %>' />
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_it_Jueves" runat="server" Text='<%# Bind("Dia_MED_4") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Viernes">
                                    <EditItemTemplate>
                                        <asp:CheckBox ID="cb_Viernes" runat="server" Checked='<%# Bind("Dia_MED_5") %>' />
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_it_Viernes" runat="server" Text='<%# Bind("Dia_MED_5") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Sabado">
                                    <EditItemTemplate>
                                        <asp:CheckBox ID="cb_Sabado" runat="server" Checked='<%# Bind("Dia_MED_6") %>' />
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_it_Sabado" runat="server" Text='<%# Bind("Dia_MED_6") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Domingo">
                                    <EditItemTemplate>
                                        <asp:CheckBox ID="cb_Domingo" runat="server" Checked='<%# Bind("Dia_MED_7") %>' />
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_it_Domingo" runat="server" Text='<%# Bind("Dia_MED_7") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                 <asp:TemplateField HeaderText="Horario Entrada">
                                     <EditItemTemplate>
                                         <asp:TextBox ID="txt_Entrada_MED" runat="server" Height="17px" Text='<%# Bind("HorarioEntrada_MED") %>' Width="220px"></asp:TextBox>
                                     </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_it_HorarioEntrada" runat="server" Text='<%# Bind("HorarioEntrada_MED") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Horario Salida">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="txt_Salida_MED" runat="server" Height="17px" Text='<%# Bind("HorarioSalida_MED") %>' Width="220px"></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_it_HorarioSalida" runat="server" Text='<%# Bind("HorarioSalida_MED") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Email">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="txt_Email_MED" runat="server" Height="17px" Text='<%# Bind("Email_MED") %>' Width="220px"></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_it_Email" runat="server" Text='<%# Bind("Email_MED") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Teléfono">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="txt_Telefono_MED" runat="server" Height="17px" Text='<%# Bind("Telefono_MED") %>' Width="220px"></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_it_Telefono" runat="server" Text='<%# Bind("Telefono_MED") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </td>
            </tr>
        </table>
    </form>

</body>
</html>
