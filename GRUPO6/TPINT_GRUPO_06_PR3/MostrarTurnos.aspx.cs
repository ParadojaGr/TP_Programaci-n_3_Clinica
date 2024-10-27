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
    public partial class WebForm5 : System.Web.UI.Page
    {
        NegocioTurno negTur = new NegocioTurno();
        Turnos tur = new Turnos();
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
            DataTable tabla = negTur.getTablaTurno();
            gvTurnos.DataSource = tabla;
            gvTurnos.DataBind();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtBusqueda.Text);

            if (negTur.BuscarExiste(id))
            {
                DataTable tabla = negTur.getRegistro(id);
                gvTurnos.DataSource = tabla;
                gvTurnos.DataBind();

                lblNoEncontro.Text = "";
            }
            else
            {
                lblNoEncontro.Text = "EL ID DE TURNO NO FUE ENCONTRADO EN LA BASE DE DATOS";
                CargarGridView();
            }
        }

        protected void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            CargarGridView();
            txtBusqueda.Text = "";
            lblNoEncontro.Text = "";
        }
    }
}