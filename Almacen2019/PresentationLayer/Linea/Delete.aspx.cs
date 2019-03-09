using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;

namespace PresentationLayer.Linea
{
    public partial class Delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"].ToString());
            idDelete.Value = id.ToString();

            LineaModel pm = new LineaModel();
            lineas p = pm.getById(new lineas() { id = id });

            lblLinea.Text = "Eliminar la Linea " + p.nombre + "?";
        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            LineaModel lineasModel= new LineaModel();
            lineas l = new lineas();
            l.id = int.Parse(idDelete.Value.ToString());
            lineasModel.delete(l);
            Response.Redirect("Default.aspx");
        }
    }
}