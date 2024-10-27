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
    public partial class MostrarMedicos : System.Web.UI.Page
    {
        NegocioMedico neg = new NegocioMedico();
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
            DataTable tabla = neg.getTablaMedico();
            gvMedicos.DataSource = tabla;
            gvMedicos.DataBind();
        }

        protected void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            CargarGridView();
            txtBusqueda.Text = "";
            ddlFiltros.SelectedIndex = 0;
            lblNoEncontro.Text = "";
            lblEliminado.Text = "";
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {

            int legajo = Convert.ToInt32(txtBusqueda.Text);
            int respuesta = neg.EliminarMedico(legajo);
            if (respuesta == 1)
            {
                lblEliminado.Text = "El Medico fue eliminado con exito";
            }
            else if (respuesta == 0)
            {
                lblEliminado.Text = "Error al eliminar el Medico";
            }
            else if (respuesta == 2)
            {
                lblEliminado.Text = "No se encontro el Medico";
            }

            CargarGridView();
            txtBusqueda.Text = "";
        }

        protected void BtnBuscar_Click(object sender, EventArgs e)
        {
            int legajo = Convert.ToInt32(txtBusqueda.Text);

            if (neg.buscarExiste(legajo))
            {
                DataTable tabla = neg.getRegistroMedico(legajo);
                gvMedicos.DataSource = tabla;
                gvMedicos.DataBind();

                lblNoEncontro.Text = "";
            }
            else
            {
                lblNoEncontro.Text = "EL MEDICO NO FUE ENCONTRADO EN LA BASE DE DATOS";
                CargarGridView();
            }
        }

        protected void gvMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            int valor = Convert.ToInt32(ddlFiltros.SelectedValue);
            if (valor == 1)
            {
                DataTable tabla = neg.Filtro_Nombre();
                gvMedicos.DataSource = tabla;
                gvMedicos.DataBind();
            }
            else if (valor == 2)
            {
                DataTable tabla = neg.Filtro_Apellido();
                gvMedicos.DataSource = tabla;
                gvMedicos.DataBind();
            }
            else if (valor == 3)
            {
                DataTable tabla = neg.Filtro_Sexo();
                gvMedicos.DataSource = tabla;
                gvMedicos.DataBind();
            }
            else if (valor == 4)
            {
                DataTable tabla = neg.Filtro_Sexo_Descendiente();
                gvMedicos.DataSource = tabla;
                gvMedicos.DataBind();
            }
            else if (valor == 5)
            {
                DataTable tabla = neg.Filtro_Especialidad();
                gvMedicos.DataSource = tabla;
                gvMedicos.DataBind();
            }
        }
    }
}