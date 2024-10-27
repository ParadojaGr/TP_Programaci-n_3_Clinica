using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPINT_GRUPO_06_PR3
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblNombre.Text = (string)Session["Usuario"];
            }
        }

        protected void btnMostrarMedicos_Click(object sender, EventArgs e)
        {
            Response.Redirect("MostrarMedicos.aspx");
        }

        protected void btnAgregarMedico_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarMedico.aspx");
                
        }

        protected void btnMostrarMedicos_Click1(object sender, EventArgs e)
        {
            Response.Redirect("MostrarMedicos.aspx");
        }

        protected void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            Response.Redirect("CrearUsuario.aspx");
        }

        protected void btnAgregarPaciente_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarPaciente.aspx");
        }

        protected void btnEditarBorrarMedicos_Click(object sender, EventArgs e)
        {
            Response.Redirect("ModificarMedicos.aspx");
        }

        protected void btnEditarBorrarPacientes_Click(object sender, EventArgs e)
        {
            Response.Redirect("ModificarPacientes.aspx");
        }

        protected void btnInformes_Click(object sender, EventArgs e)
        {
            Response.Redirect("Informes.aspx");
        }

        protected void btnTurnos_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarTurnos.aspx");
        }

        protected void btnVerTurnos_Click(object sender, EventArgs e)
        {
            Response.Redirect("MostrarTurnos.aspx");
        }

        protected void btnMostrarPacientes_Click(object sender, EventArgs e)
        {
            Response.Redirect("MostrarPacientes.aspx");
        }

        protected void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            Response.Redirect("ModificarUsuarios.aspx");
        }
    }
}