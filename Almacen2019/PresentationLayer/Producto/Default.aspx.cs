using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;

namespace PresentationLayer.Producto
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ProductoModel productomodel = new ProductoModel();
            tableProductos.DataSource = productomodel.getAllProductos();
            tableProductos.DataBind();
        }

        protected void new_Click(object sender, EventArgs e)
        {
            
        }

        protected void new_Click1(object sender, EventArgs e)
        {
            Response.Redirect("New.aspx");
        }
    }
  
}