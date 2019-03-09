using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;

namespace PresentationLayer.Producto
{
    public partial class Update : System.Web.UI.Page
    {

        protected void Page_Init(object sender, EventArgs e)
        {
            LineaModel lineaModel = new LineaModel();
            comboLinea.DataSource = lineaModel.getAll();
            comboLinea.DataTextField = "nombre";
            comboLinea.DataValueField = "id";
            comboLinea.DataBind();

            int id = int.Parse(Request.QueryString["id"].ToString());
            idUpdate.Value = id.ToString();
            //lblex.Text = id.ToString();


            ProductoModel pm = new ProductoModel();
            productos p = pm.getById(new productos() { id = id });

            txtClave.Text = p.clave;
            txtNombre.Text = p.nombre;
            comboLinea.SelectedValue = p.id_lineas.ToString();
            idUpdate.Value = p.id.ToString();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        

        private void clearForm()
        {
            txtClave.Text = "";
            txtNombre.Text = "";
            loadCombo();
        }

        private void loadCombo()
        {

            LineaModel lineaModel = new LineaModel();
            comboLinea.DataSource = lineaModel.getAll();
            comboLinea.DataTextField = "nombre";
            comboLinea.DataValueField = "id";
            comboLinea.DataBind();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            ProductoModel productoModel = new ProductoModel();
            productos p = new productos()
            {   
                clave = txtClave.Text,
                nombre = txtNombre.Text,
                id_lineas = int.Parse(comboLinea.SelectedValue)
            };
            
             p.id = int.Parse(idUpdate.Value.ToString());
            //lblex.Text = p.id + "" + p.clave + p.nombre + p.id_lineas;
            productoModel.update(p);
            Response.Redirect("Default.aspx");
        }
    }
}