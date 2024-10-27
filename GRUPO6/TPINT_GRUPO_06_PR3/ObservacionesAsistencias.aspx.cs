using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Entidades;
using System.Data;

namespace TPINT_GRUPO_06_PR3
{
    public partial class ObservacionesAsistencias : System.Web.UI.Page
    {
        NegocioTurno negTur = new NegocioTurno();
        Turnos tur = new Turnos();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                CargarGridView();
                lbl_Nombre.Text = (string)Session["Usuario"];
            }
        }

        public void CargarGridView()
        {
            string nombreUs = (string)Session["Usuario"];
            DataTable tabla = negTur.getTablaTurnoIndividual(nombreUs);
            gvTurnos.DataSource = tabla;
            gvTurnos.DataBind();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvTurnos.EditIndex = e.NewEditIndex;
            CargarGridView();
        }

        protected void gvTurnos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvTurnos.EditIndex = -1;
            CargarGridView();
        }

        protected void gvTurnos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            String s_ID = ((Label)gvTurnos.Rows[e.RowIndex].FindControl("lbl_eit_ID")).Text;
            //String s_DNI = ((Label)gvTurnos.Rows[e.RowIndex].FindControl("lbl_eit_DNI")).Text;
            //String s_Legajo = ((Label)gvTurnos.Rows[e.RowIndex].FindControl("lbl_eit_Legajo")).Text;
            //String s_Dia = ((Label)gvTurnos.Rows[e.RowIndex].FindControl("lbl_eit_Dia")).Text;
            //String s_Hora = ((Label)gvTurnos.Rows[e.RowIndex].FindControl("lbl_eit_Hora")).Text;
            String s_Observacion = ((TextBox)gvTurnos.Rows[e.RowIndex].FindControl("txt_eit_Observaciones")).Text;
            String s_Asistencia = ((TextBox)gvTurnos.Rows[e.RowIndex].FindControl("txt_eit_Asistencia")).Text;

            tur.set_IdTurno_TUR(Convert.ToInt32(s_ID));
            //tur.set_DniPaciente_TUR(s_DNI);
            //tur.set_LegajoMedico_TUR(Convert.ToInt32(s_Legajo));
            //tur.set_Dia_TUR(s_Dia);
            //tur.set_Hora_TUR(s_Hora);
            tur.set_Observaciones_TUR(s_Observacion);
            tur.set_Asistencia_TUR(Convert.ToInt32(s_Asistencia));

            negTur.ActualizarTurno(tur);

            gvTurnos.EditIndex = -1;
            CargarGridView();
        }

        protected void cb_eit_Asistencia_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}