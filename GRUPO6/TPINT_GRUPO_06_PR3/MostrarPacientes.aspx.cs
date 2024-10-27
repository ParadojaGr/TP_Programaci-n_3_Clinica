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
    public partial class MostrarPacientes : System.Web.UI.Page
    {
        NegocioPaciente neg = new NegocioPaciente();
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
            DataTable tabla = neg.getTablaPaciente();
            GridViewPacientes.DataSource = tabla;
            GridViewPacientes.DataBind();
        }

        protected void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            CargarGridView();
            txtBusqueda.Text = "";
            ddlFiltros.SelectedIndex = 0;
            lblNoEncontro.Text = "";
            lblEliminar.Text = "";
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string dni = txtBusqueda.Text;

            if (neg.buscarExiste(dni))
            {
                DataTable tabla = neg.getRegistroPaciente(dni);
                GridViewPacientes.DataSource = tabla;
                GridViewPacientes.DataBind();

                lblNoEncontro.Text = "";
                lblEliminar.Text = "";
            }
            else
            {
                lblNoEncontro.Text = "EL PACIENTE NO FUE ENCONTRADO EN LA BASE DE DATOS";
                CargarGridView();
                lblEliminar.Text = "";
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            string dni = txtBusqueda.Text;
            int respuesta = neg.EliminarPaciente(dni);
            if(respuesta == 1)
            {
                lblEliminar.Text = "El Paciente fue eliminado con exito";
            }
            else if(respuesta == 0)
            {
                lblEliminar.Text = "Error al eliminar el paciente";
            }
            else if(respuesta == 2)
            {
                lblEliminar.Text = "No se encontro el paciente";
            }

            CargarGridView();
        }


        //FILTROS:
        protected void btnFiltro_Click(object sender, EventArgs e)
        {
            int valor = Convert.ToInt32(ddlFiltros.SelectedValue);
            if(valor == 1)
            {
                DataTable tabla = neg.Filtro_Nombre();
                GridViewPacientes.DataSource = tabla;
                GridViewPacientes.DataBind();
            }
            else if (valor == 2)
            {
                DataTable tabla = neg.Filtro_Apellido();
                GridViewPacientes.DataSource = tabla;
                GridViewPacientes.DataBind();
            }
            else if (valor == 3)
            {
                DataTable tabla = neg.Filtro_Sexo();
                GridViewPacientes.DataSource = tabla;
                GridViewPacientes.DataBind();
            }
            else if (valor == 4)
            {
                DataTable tabla = neg.Filtro_Sexo_Descendiente();
                GridViewPacientes.DataSource = tabla;
                GridViewPacientes.DataBind();
            }
        }

        //protected void gvPacientes(object sender, GridViewPageEventArgs e)
        //{

        //}

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}