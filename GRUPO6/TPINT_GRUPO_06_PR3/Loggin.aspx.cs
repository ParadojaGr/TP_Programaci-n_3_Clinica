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
    public partial class Loggin : System.Web.UI.Page
    {
        NegocioUsuario negUs = new NegocioUsuario();
        Usuario us = new Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] == null)
            {
                Session["Usuario"] = txtUsuario.Text;
            }
            else
            {
                Session["Usuario"] = "";
                Session["Usuario"] = txtUsuario.Text;
            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            if(negUs.BuscarExisteUsuario(txtUsuario.Text, txtContraseña.Text))
            {
                if (negUs.Es_Admin(txtUsuario.Text, txtContraseña.Text))
                {
                    Response.Redirect("Administradores.aspx");
                }
                else
                {
                    Response.Redirect("Medicos.aspx");
                }
            }
            else
            {
                lblError.Text = "Nombre de usuario o Contraseña Incorrectos";
            }
        }
    }
}