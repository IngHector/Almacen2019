using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
namespace PresentationLayer.Producto
{
    public partial class New : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            LineaModel lineaModel = new LineaModel();
            comboLinea.DataSource = lineaModel.getAll();
            comboLinea.DataTextField = "nombre";
            comboLinea.DataValueField = "id";
            comboLinea.DataBind();
        }
            protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtClave.Text == "" || txtNombre.Text == "")
            {
                lblinfo.Visible = true;
                lblinfo.Text = "Ingresa Todos Los Campos";
            }

            else {
                lblinfo.Visible = false;
                
                productos p = new productos()
                {
                    clave = txtClave.Text,
                    nombre = txtNombre.Text,
                    id_lineas = int.Parse(comboLinea.Text)
                };
                ProductoModel productoModel = new ProductoModel();
                productoModel.add(p);

                clearForm();
            }
        }

        private void clearForm()
        {
            txtClave.Text = "";
            txtNombre.Text = "";
            loadCombo();
        }

        private void loadCombo() {

            LineaModel lineaModel = new LineaModel();
            comboLinea.DataSource = lineaModel.getAll();
            comboLinea.DataTextField = "nombre";
            comboLinea.DataValueField = "id";
            comboLinea.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}