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
    public partial class WebForm3 : System.Web.UI.Page
    {
        NegocioProvincia negProv = new NegocioProvincia();
        NegocioLocalidad negLoc = new NegocioLocalidad();
        NegocioMedico negMed = new NegocioMedico();
        NegocioEspecialidad negEsp = new NegocioEspecialidad();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
            {
            CargarDDLProv();
            CargarDDLEspecialidades();
            lblNombre.Text = (string)Session["Usuario"];
            }
        }

        //boton para agregar un Medico.
        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            Boolean estado = false;
            int legajo = Convert.ToInt32(txtLegajo.Text);
            int provincia = (ddlProvincia.SelectedIndex) + 1;
            int localidad = Convert.ToInt32(ddlLocalidad.SelectedValue);
            string especialidad = ddlEspecialidades.SelectedValue;
            string sexo = cblSexo.SelectedValue;
            bool Lunes;
            bool Martes;
            bool Miercoles;
            bool Jueves;
            bool Viernes;
            bool Sabado;
            bool Domingo;

            if (cbLunes.Checked == true) { Lunes = true; }
            else { Lunes = false; }

            if (cbMartes.Checked == true) { Martes = true; }
            else { Martes = false; }

            if (cbMiercoles.Checked == true) { Miercoles = true; }
            else { Miercoles = false; }

            if (cbJueves.Checked == true) { Jueves = true; }
            else { Jueves = false; }

            if (cbViernes.Checked == true) { Viernes = true; }
            else { Viernes = false; }

            if (cbSabado.Checked == true) { Sabado = true; }
            else { Sabado = false; }

            if (cbDomingo.Checked == true) { Domingo = true; }
            else { Domingo = false; }


            estado = negMed.AgregarMedico(legajo, txtNombre.Text, txtDNI.Text, txtApellido.Text, sexo, txtNacionalidad.Text, txtFechaNac.Text, txtDireccion.Text, especialidad, Lunes, Martes, Miercoles, Jueves, Viernes, Sabado, Domingo, txtHorarioEntrada.Text, txtHorarioSalida.Text, provincia, localidad, txtCorreo.Text, txtTelefono.Text);

            if (estado)
            {
                lblMensaje.Text = "El Medico fue agregado con exito";
                LimpiarCampos();
            }
            else
            {
                lblMensaje.Text = "Error al agregar el Medico";
            }
        }

        private void LimpiarCampos()
        {
            txtLegajo.Text = "";
            txtDNI.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            cblSexo.SelectedIndex = 0;
            txtNacionalidad.Text = "";
            txtFechaNac.Text = "";
            ddlProvincia.SelectedIndex = 0;
            ddlLocalidad.SelectedIndex = 0;
            txtDireccion.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            ddlEspecialidades.SelectedIndex = 0;
            txtHorarioEntrada.Text = "";
            txtHorarioSalida.Text = "";
            cbLunes.Checked = false;
            cbMartes.Checked = false;
            cbMiercoles.Checked = false;
            cbJueves.Checked = false;
            cbViernes.Checked = false;
            cbSabado.Checked = false;
            cbDomingo.Checked = false;
        }

        protected void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void ddlProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = ddlProvincia.SelectedValue;
            ddlLocalidad.DataSource = negLoc.getLocalidadParaDDL(id);
            ddlLocalidad.DataTextField = "Nombre_LOC";
            ddlLocalidad.DataValueField = "IDLocalidad_LOC";
            ddlLocalidad.DataBind();
        }

        private void CargarDDLProv()
        {
            ddlProvincia.DataSource = negProv.CargarDdlProvincias();
            ddlProvincia.DataTextField = "Nombre_PRO";
            ddlProvincia.DataValueField = "IDProvincia_PRO";
            ddlProvincia.DataBind();
        }

        private void CargarDDLEspecialidades()
        {
            ddlEspecialidades.DataSource = negEsp.CargarDdlEspecialidad();
            ddlEspecialidades.DataTextField = "Nombre_ES";
            ddlEspecialidades.DataValueField = "IDEspecialidad_ES";
            ddlEspecialidades.DataBind();
        }

        protected void ddlLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}