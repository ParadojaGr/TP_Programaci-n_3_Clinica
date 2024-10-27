using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Entidades;
using Negocio;

namespace TPINT_GRUPO_06_PR3
{
    public partial class ModificarEliminarPacientes : System.Web.UI.Page
    {
        NegocioLocalidad negLoc = new NegocioLocalidad();
        NegocioPaciente negPac = new NegocioPaciente();
        Paciente pac = new Paciente();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarGridView();
                lblNombre.Text = (string)Session["Usuario"];
            }
        }

        public void CargarGridView()
        {
            DataTable tabla = negPac.getTablaSinJoins();
            gvPacientes.DataSource = tabla;
            gvPacientes.DataBind();
        }

        protected void gvPacientes_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvPacientes.EditIndex = e.NewEditIndex;
            CargarGridView();
        }

        protected void gvPacientes_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvPacientes.EditIndex = -1;
            CargarGridView();
        }

        protected void gvPacientes_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            //buscar los datos del itemtemplate.
            String s_DNI = ((Label)gvPacientes.Rows[e.RowIndex].FindControl("lbl_eit_DNI")).Text;
            String s_Nombre = ((TextBox)gvPacientes.Rows[e.RowIndex].FindControl("txt_Nombre_PAC")).Text;
            String s_Apellido = ((TextBox)gvPacientes.Rows[e.RowIndex].FindControl("txt_Apellido_PAC")).Text;
            String s_Sexo = ((TextBox)gvPacientes.Rows[e.RowIndex].FindControl("txt_Sexo_PAC")).Text;
            String s_Nacionalidad = ((TextBox)gvPacientes.Rows[e.RowIndex].FindControl("txt_Nacionalidad_PAC")).Text;
            String s_Nacimiento = ((TextBox)gvPacientes.Rows[e.RowIndex].FindControl("txt_Nacimiento_PAC")).Text;
            String s_Direccion = ((TextBox)gvPacientes.Rows[e.RowIndex].FindControl("txt_Direccion_PAC")).Text;
            String s_Provincia = ((TextBox)gvPacientes.Rows[e.RowIndex].FindControl("txt_Provincia_PAC")).Text;
            String s_Localidad = ((TextBox)gvPacientes.Rows[e.RowIndex].FindControl("txt_Localidad_PAC")).Text;
            String s_Email = ((TextBox)gvPacientes.Rows[e.RowIndex].FindControl("txt_Email_PAC")).Text;
            String s_Telefono = ((TextBox)gvPacientes.Rows[e.RowIndex].FindControl("txt_Telefono_PAC")).Text;

            pac.set_DNI(s_DNI);
            pac.set_Nombre(s_Nombre);
            pac.set_Apellido(s_Apellido);
            pac.set_Sexo(s_Sexo);
            pac.set_Nacionalidad(s_Nacionalidad);
            pac.set_FechaNacimiento(s_Nacimiento);
            pac.set_Direccion(s_Direccion);
            pac.set_Provincia(Convert.ToInt32(s_Provincia));
            pac.set_Localidad(Convert.ToInt32(s_Localidad));
            pac.set_Email(s_Email);
            pac.set_Telefono(s_Telefono);

            negPac.ActualizarPaciente(pac);

            gvPacientes.EditIndex = -1;
            CargarGridView();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}