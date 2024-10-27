using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace TPINT_GRUPO_06_PR3
{
    public partial class Informes : System.Web.UI.Page
    {
        NegocioInformes neg = new NegocioInformes();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblNombre.Text = (string)Session["Usuario"];
            }
        }

        protected void btnInformeMEDxTUR_Click(object sender, EventArgs e)
        {
            gvInformes.DataSource = neg.getTablaMEDxTUR();
            gvInformes.DataBind();
        }

        protected void btnInformeESPxTUR_Click(object sender, EventArgs e)
        {
            gvInformes.DataSource = neg.getTablaESPxTUR();
            gvInformes.DataBind();
        }
    }
}