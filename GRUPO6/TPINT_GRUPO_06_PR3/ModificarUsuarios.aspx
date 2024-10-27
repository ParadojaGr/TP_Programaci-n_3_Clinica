<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModificarUsuarios.aspx.cs" Inherits="TPINT_GRUPO_06_PR3.ModificarUsuarios" %>

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
            width: 344px;
        }
        .auto-style3 {
            text-decoration: underline;
            font-size: x-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2"><strong>Usuario:
                        <asp:Label ID="lblNombre" runat="server"></asp:Label>
                        </strong></td>
                    <td class="auto-style3"><strong>MENU MODIFICAR USUARIOS</strong></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:GridView ID="gvUsuarios" runat="server" AutoGenerateColumns="False" AutoGenerateEditButton="True" Width="460px" OnRowCancelingEdit="gvUsuarios_RowCancelingEdit" OnRowEditing="gvUsuarios_RowEditing" OnRowUpdating="gvUsuarios_RowUpdating">
                            <Columns>
                                <asp:TemplateField HeaderText="Legajo">
                                    <EditItemTemplate>
                                        <asp:Label ID="lbl_eit_Legajo" runat="server" Text='<%# Bind("Legajo_USU") %>'></asp:Label>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_it_Legajo" runat="server" Text='<%# Bind("Legajo_USU") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Nombre de Usuario">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="txt_eit_Nombre" runat="server" Text='<%# Bind("Nombre_USU") %>' Width="220px"></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_it_Nombre" runat="server" Text='<%# Bind("Nombre_USU") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Contraseña">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="txt_eit_Contraseña" runat="server" Text='<%# Bind("Contraseña_USU") %>' Width="300px"></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_it_Contraseña" runat="server" Text='<%# Bind("Contraseña_USU") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
