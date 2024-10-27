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
    public partial class ModificarEliminarMedicos : System.Web.UI.Page
    {
        NegocioMedico negMed = new NegocioMedico();
        Medico med = new Medico();
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
            DataTable tabla = negMed.getTablaSinJoins();
            gvMedicos.DataSource = tabla;
            gvMedicos.DataBind();
        }

        protected void gvMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void gvMedicos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvMedicos.EditIndex = e.NewEditIndex;
            CargarGridView();
        }

        protected void gvMedicos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvMedicos.EditIndex = -1;
            CargarGridView();
        }

        protected void gvMedicos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            //buscar los datos del itemtemplate.
            String s_Legajo = ((Label)gvMedicos.Rows[e.RowIndex].FindControl("lbl_eit_Legajo")).Text;
            String s_DNI = ((TextBox)gvMedicos.Rows[e.RowIndex].FindControl("txt_DNI_MED")).Text;
            String s_Nombre = ((TextBox)gvMedicos.Rows[e.RowIndex].FindControl("txt_Nombre_MED")).Text;
            String s_Apellido = ((TextBox)gvMedicos.Rows[e.RowIndex].FindControl("txt_Apellido_MED")).Text;
            String s_Sexo = ((TextBox)gvMedicos.Rows[e.RowIndex].FindControl("txt_Sexo_MED")).Text;
            String s_Nacionalidad = ((TextBox)gvMedicos.Rows[e.RowIndex].FindControl("txt_Nacionalidad_MED")).Text;
            String s_Nacimiento = ((TextBox)gvMedicos.Rows[e.RowIndex].FindControl("txt_Nacimiento_MED")).Text;
            String s_Direccion = ((TextBox)gvMedicos.Rows[e.RowIndex].FindControl("txt_Direccion_MED")).Text;
            String s_Especialidad = ((TextBox)gvMedicos.Rows[e.RowIndex].FindControl("txt_Especialidad_MED")).Text;
            String s_Provincia = ((TextBox)gvMedicos.Rows[e.RowIndex].FindControl("txt_Provincia_MED")).Text;
            String s_Localidad = ((TextBox)gvMedicos.Rows[e.RowIndex].FindControl("txt_Localidad_MED")).Text;
            Boolean s_Lunes = ((CheckBox)gvMedicos.Rows[e.RowIndex].FindControl("cb_Lunes")).Checked;
            Boolean s_Martes = ((CheckBox)gvMedicos.Rows[e.RowIndex].FindControl("cb_Martes")).Checked;
            Boolean s_Miercoles = ((CheckBox)gvMedicos.Rows[e.RowIndex].FindControl("cb_Miercoles")).Checked;
            Boolean s_Jueves = ((CheckBox)gvMedicos.Rows[e.RowIndex].FindControl("cb_Jueves")).Checked;
            Boolean s_Viernes = ((CheckBox)gvMedicos.Rows[e.RowIndex].FindControl("cb_Viernes")).Checked;
            Boolean s_Sabado = ((CheckBox)gvMedicos.Rows[e.RowIndex].FindControl("cb_Sabado")).Checked;
            Boolean s_Domingo = ((CheckBox)gvMedicos.Rows[e.RowIndex].FindControl("cb_Domingo")).Checked;
            String s_HorarioEntrada = ((TextBox)gvMedicos.Rows[e.RowIndex].FindControl("txt_Entrada_MED")).Text;
            String s_HorarioSalida = ((TextBox)gvMedicos.Rows[e.RowIndex].FindControl("txt_Salida_MED")).Text;
            String s_Email = ((TextBox)gvMedicos.Rows[e.RowIndex].FindControl("txt_Email_MED")).Text;
            String s_Telefono = ((TextBox)gvMedicos.Rows[e.RowIndex].FindControl("txt_Telefono_MED")).Text;

            med.set_Legajo(Convert.ToInt32(s_Legajo));
            med.set_DNI(s_DNI);
            med.set_Nombre(s_Nombre);
            med.set_Apellido(s_Apellido);
            med.set_Sexo(s_Sexo);
            med.set_Nacionalidad(s_Nacionalidad);
            med.set_FechaNacimiento(s_Nacimiento);
            med.set_Direccion(s_Direccion);
            med.set_Especialidad(s_Especialidad);
            med.set_Provincia(Convert.ToInt32(s_Provincia));
            med.set_Localidad(Convert.ToInt32(s_Localidad));
            med.set_Lunes(s_Lunes);
            med.set_Martes(s_Martes);
            med.set_Miercoles(s_Miercoles);
            med.set_Jueves(s_Jueves);
            med.set_Viernes(s_Viernes);
            med.set_Sabado(s_Sabado);
            med.set_Domingo(s_Domingo);
            med.set_HorarioEntrada(s_HorarioEntrada);
            med.set_HorarioSalida(s_HorarioSalida);
            med.set_Email(s_Email);
            med.set_Telefono(s_Telefono);

            negMed.ActualizarMedico(med);

            gvMedicos.EditIndex = -1;
            CargarGridView();
        }
    }
}