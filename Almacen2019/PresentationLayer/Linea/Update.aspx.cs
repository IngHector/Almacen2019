using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;

namespace PresentationLayer.Linea
{
    public partial class Update : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"].ToString());
            idUpdate.Value = id.ToString();

            LineaModel lm = new LineaModel();
            lineas l = lm.getById(new lineas() { id = id });

            txtClave.Text = l.clave;
            txtNombre.Text = l.nombre.Trim();

            idUpdate.Value = l.id.ToString();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            LineaModel lineaModel = new LineaModel();
            lineas l = new lineas()
            {
                clave = txtClave.Text,
                nombre = txtNombre.Text,
            };
            l.id = int.Parse(idUpdate.Value.ToString());
            lineaModel.update(l);
            Response.Redirect("Default.aspx");
        }
    }
}