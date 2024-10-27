using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Negocio;
using Entidades;

namespace TPINT_GRUPO_06_PR3
{
    public partial class ModificarUsuarios : System.Web.UI.Page
    {
        NegocioUsuario negUs = new NegocioUsuario();
        Usuario us = new Usuario();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarGridview();
                lblNombre.Text = (string)Session["Usuario"];
            }
        }

        //cargar el gv
        public void CargarGridview()
        {
            DataTable tabla = negUs.getTablaUsuario();
            gvUsuarios.DataSource = tabla;
            gvUsuarios.DataBind();
        }

        protected void gvUsuarios_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvUsuarios.EditIndex = e.NewEditIndex;
            CargarGridview();
        }

        protected void gvUsuarios_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvUsuarios.EditIndex = -1;
            CargarGridview();
        }

        protected void gvUsuarios_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            String s_Legajo = ((Label)gvUsuarios.Rows[e.RowIndex].FindControl("lbl_eit_Legajo")).Text;
            String s_Usuario = ((TextBox)gvUsuarios.Rows[e.RowIndex].FindControl("txt_eit_Nombre")).Text;
            String s_Contraseña = ((TextBox)gvUsuarios.Rows[e.RowIndex].FindControl("txt_eit_Contraseña")).Text;

            us.set_Legajo_USU(Convert.ToInt32(s_Legajo));
            us.set_Usuario_USU(s_Usuario);
            us.set_Contraseña_USU(s_Contraseña);
            negUs.ActualizarUsuario(us);

            gvUsuarios.EditIndex = -1;
            CargarGridview();
        }
    }
}