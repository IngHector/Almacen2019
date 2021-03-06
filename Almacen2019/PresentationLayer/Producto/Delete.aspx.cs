﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
namespace PresentationLayer.Producto
{
    public partial class Delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"].ToString());
            idDelete.Value = id.ToString();

            ProductoModel pm = new ProductoModel();
            productos p = pm.getById(new productos() { id = id });

            lblProducto.Text = "Eliminar el producto " + p.nombre+"?";
        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            ProductoModel productoModel = new ProductoModel();
            productos p = new productos();
            p.id = int.Parse(idDelete.Value.ToString());
            productoModel.delete(p);
            Response.Redirect("Default.aspx");
            
        }
    }
}