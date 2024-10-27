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
    public partial class CrearUsuario : System.Web.UI.Page
    {
        NegocioUsuario negUs = new NegocioUsuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblNombre.Text = (string)Session["Usuario"];
            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            Boolean estado = false;

            /// El estado se fija que esten todos los datos en el tipode variable que 
            /// corresponda y que se puedan cargar correctamente.

            int legajo = Convert.ToInt32(txtLegajo.Text);

            if(txtContraseña.Text.Trim() == txtConfirmarContraseña.Text.Trim())
            {
                estado = negUs.AgregarUsuario(legajo, txtUsuario.Text, txtContraseña.Text);
                
                if (estado)
                {
                    lblMensaje.Text = "El Usuario fue agregado con exito";
                    LimpiarCampos();
                }
                else
                {
                    lblMensaje.Text = "Error al agregar el Usuario";
                }
            }
            else
            {
                lblMensaje.Text = "Las contraseñas no coinciden";
            }
        }

        private void LimpiarCampos()
        {
            txtLegajo.Text = "";
            txtUsuario.Text = "";
            txtContraseña.Text = "";
            txtConfirmarContraseña.Text = "";
        }
    }
}