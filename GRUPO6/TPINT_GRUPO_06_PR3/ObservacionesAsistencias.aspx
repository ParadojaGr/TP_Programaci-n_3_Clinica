<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ObservacionesAsistencias.aspx.cs" Inherits="TPINT_GRUPO_06_PR3.ObservacionesAsistencias" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 185px;
        }
        .auto-style2 {
            height: 30px;
        }
        .auto-style3 {
            height: 30px;
            width: 168px;
        }
        .auto-style4 {
            width: 168px;
        }
        .auto-style5 {
            width: 168px;
            height: 18px;
        }
        .auto-style6 {
            height: 18px;
        }
        .auto-style7 {
            height: 30px;
            width: 983px;
        }
        .auto-style8 {
            width: 983px;
            height: 18px;
        }
        .auto-style9 {
            width: 983px;
        }
        .auto-style10 {
            text-decoration: underline;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style3"><strong>Usuario:
                    <asp:Label ID="lbl_Nombre" runat="server"></asp:Label>
                    </strong></td>
                <td class="auto-style7"></td>
                <td class="auto-style2">
                    <asp:HyperLink ID="hlVolver" runat="server" CssClass="auto-style10" NavigateUrl="~/Medicos.aspx">Volver</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td class="auto-style5"></td>
                <td class="auto-style8"></td>
                <td class="auto-style6"></td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:GridView ID="gvTurnos" runat="server" AutoGenerateColumns="False" AutoGenerateEditButton="True" OnRowCancelingEdit="gvTurnos_RowCancelingEdit" OnRowEditing="GridView1_RowEditing" OnRowUpdating="gvTurnos_RowUpdating" Width="695px">
                        <Columns>
                            <asp:TemplateField HeaderText="ID TURNO">
                                <EditItemTemplate>
                                    <asp:Label ID="lbl_eit_ID" runat="server" Text='<%# Bind("IDTurno_TUR") %>'></asp:Label>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="lbl_it_ID" runat="server" Text='<%# Bind("IDTurno_TUR") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="DNI PACIENTE">
                                <EditItemTemplate>
                                    <asp:Label ID="lbl_eit_DNI" runat="server" Text='<%# Bind("DNIPaciente_TUR") %>'></asp:Label>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="lbl_it_DNI" runat="server" Text='<%# Bind("DNIPaciente_TUR") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="LEGAJO MEDICO">
                                <EditItemTemplate>
                                    <asp:Label ID="lbl_eit_Legajo" runat="server" Text='<%# Bind("LegajoMedico_TUR") %>'></asp:Label>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="lbl_it_Legajo" runat="server" Text='<%# Bind("LegajoMedico_TUR") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="DIA">
                                <EditItemTemplate>
                                    <asp:Label ID="lbl_eit_Dia" runat="server" Text='<%# Bind("Dia_TUR") %>'></asp:Label>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="lbl_it_Dia" runat="server" Text='<%# Bind("Dia_TUR") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="HORA">
                                <EditItemTemplate>
                                    <asp:Label ID="lbl_eit_Hora" runat="server" Text='<%# Bind("Hora_TUR") %>'></asp:Label>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="lbl_it_Hora" runat="server" Text='<%# Bind("Hora_TUR") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="OBSERVACIONES">
                                <EditItemTemplate>
                                    <asp:TextBox ID="txt_eit_Observaciones" runat="server" Height="20px" Text='<%# Bind("Observaciones_TUR") %>' Width="218px"></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="lbl_it_Observaciones" runat="server" Text='<%# Bind("Observaciones_TUR") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="ASISTENCIA">
                                <EditItemTemplate>
                                    <asp:TextBox ID="txt_eit_Asistencia" runat="server" Text='<%# Bind("Asistencia_TUR") %>' Width="211px"></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="lbl_it_Asistencia" runat="server" Text='<%# Bind("Asistencia_TUR") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style9">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style9">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style9">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
