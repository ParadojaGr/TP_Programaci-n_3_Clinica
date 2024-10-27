using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Entidades;

namespace TPINT_GRUPO_06_PR3
{
    public partial class AgregarTurnos : System.Web.UI.Page
    {
        NegocioTurno negTur = new NegocioTurno();
        NegocioPaciente negPac = new NegocioPaciente();
        NegocioMedico negMed = new NegocioMedico();
        NegocioEspecialidad negEsp = new NegocioEspecialidad();
        Medico med = new Medico();
        Turnos tur = new Turnos();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarDDLEspecialidades();
                lblNombre.Text = (string)Session["Usuario"];
            }
        }

        protected void ddlDia_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlHora.Items.Clear();
            List<string> horasDisponibles = negTur.getTurnosDisponibles(Convert.ToInt32(ddlMed.SelectedValue), ddlDia.SelectedValue);

            foreach (var turno in horasDisponibles)
            {
                ddlHora.Items.Add(turno);
            }
            ddlHora.DataBind();
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            if (negPac.buscarExiste(txbDNIPaciente.Text))
            {
                tur.set_DniPaciente_TUR(txbDNIPaciente.Text);
                tur.set_Dia_TUR(ddlDia.SelectedValue);
                tur.set_LegajoMedico_TUR(Convert.ToInt32(ddlMed.SelectedValue));
                tur.set_Hora_TUR(ddlHora.SelectedValue);
                negTur.CargarTurno(tur);
                LimpiarCampos();
                lblError.Text = "El Turno se agrego correctamente :)";
            }
            else
            {
                lblError.Text = "No se encontro ningun Paciente con ese DNI en la base de Datos :(";
                LimpiarCampos();
            }

        }

        protected void txbDNIPaciente_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ddlEspecialidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string especialidad = ddlEspecialidades.SelectedValue;
            ddlMed.DataSource = negMed.getMedicosParaDDL(especialidad);
            ddlMed.DataTextField = "Nombre_Completo";
            ddlMed.DataValueField = "Legajo_MED";
            ddlMed.DataBind();
        }

        private void CargarDDLEspecialidades()
        {
            ddlEspecialidades.DataSource = negEsp.CargarDdlEspecialidad();
            ddlEspecialidades.DataTextField = "Nombre_ES";
            ddlEspecialidades.DataValueField = "IDEspecialidad_ES";
            ddlEspecialidades.DataBind();
        }

     
        protected void ddlMed_SelectedIndexChanged1(object sender, EventArgs e)
        {
            ddlDia.Items.Clear();
            ddlHora.Items.Clear();
            Semana sem = new Semana();
            string legajo = ddlMed.SelectedValue;
            sem = negMed.getDiasParaDDL(legajo);
            foreach (var dia in sem.Get_ListadoStringDias())
            {
                ddlDia.Items.Add(new ListItem(dia));
            }
            ddlDia.DataBind();
        }

        private void LimpiarCampos()
        {
            txbDNIPaciente.Text = "";
            ddlMed.Items.Clear();
            ddlDia.Items.Clear();
            ddlHora.Items.Clear();
        }
    }
}

