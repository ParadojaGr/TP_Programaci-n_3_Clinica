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
    public partial class AgregarPaciente : System.Web.UI.Page
    {
        private NegocioProvincia negProv = new NegocioProvincia();
        private NegocioLocalidad negLoc = new NegocioLocalidad();
        private NegocioPaciente negPac = new NegocioPaciente();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                CargarDDLProv();
                CargarDDLLoca();
                lblNombre.Text = (string)Session["Usuario"];
            }
        }

        private void CargarDDLProv()
        {
            DataTable provincias = negProv.CargarDdlProvincias();
            ddlProvincia.DataSource = provincias;
            ddlProvincia.DataTextField = "Nombre_PRO";
            ddlProvincia.DataValueField = "IDProvincia_PRO";
            ddlProvincia.DataBind();
        }

        private void CargarDDLLoca()
        {
            DataTable localidad = negLoc.CargarDdlLocalidad();
            ddlLocalidad.DataSource = localidad;
            ddlLocalidad.DataTextField = "Nombre_LOC";
            ddlLocalidad.DataValueField = "IDLocalidad_LOC";
            ddlLocalidad.DataBind();
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            Boolean estado = false;
            int provincia = (ddlProvincia.SelectedIndex) + 1;
            int localidad = (ddlLocalidad.SelectedIndex) + 1;
            string sexo = cblSexo.SelectedValue;

            estado = negPac.AgregarPaciente(txtNombre.Text, txtDNI.Text, txtApellido.Text, sexo, txtNacionalidad.Text, txtFechaNacimiento.Text, txtDireccion.Text, provincia, localidad, txtCorreoElectronico.Text, txtTelefono.Text);

            if (estado)
            {
                lblMensaje.Text = "El Paciente fue agregado con exito";
                LimpiarCampos();
            }
            else
            {
                lblMensaje.Text = "Error al agregar al Paciente";
            }
        }

        private void LimpiarCampos()
        {
            txtDNI.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            cblSexo.SelectedIndex = 0;
            txtNacionalidad.Text = "";
            txtFechaNacimiento.Text = "";
            ddlProvincia.SelectedIndex = 0;
            ddlLocalidad.SelectedIndex = 0;
            txtDireccion.Text = "";
            txtCorreoElectronico.Text = "";
            txtTelefono.Text = "";

        }

        protected void ddlLocalidad_SelectedIndexChanged(object sender, EventArgs e)
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
    }
}