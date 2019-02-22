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
        protected void Page_Load(object sender, EventArgs e)
        {
            LineaModel lineaModel = new LineaModel();
            comboLinea.DataSource = lineaModel.getAll();
            comboLinea.DataTextField="nombre";
            comboLinea.DataValueField = "id";
            comboLinea.DataBind();
            //comboLinea.Data
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            productos p = new productos()
            {
                clave = txtClave.Text,
                nombre = txtNombre.Text,
                id_lineas=int.Parse( comboLinea.Text)
            };
            ProductoModel productoModel = new ProductoModel();
            productoModel.add(p);

            clearForm();
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
    }
}