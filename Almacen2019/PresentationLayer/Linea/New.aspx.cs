﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;

namespace PresentationLayer.Linea
{
    public partial class New : System.Web.UI.Page
    {
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
                lineas linea = new lineas()
                    {
                        clave = txtClave.Text,
                        nombre =txtNombre.Text
                    };

            LineaModel lineamodel = new LineaModel();
            lineamodel.add(linea);
            clearForm();
            }

           

            //lineas li = new lineas();
            //li.clave = txtClave.Text;
            //li.nombre = txtNombre.Text;
        }
        private void clearForm() {
            txtClave.Text = "";
            txtNombre.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}