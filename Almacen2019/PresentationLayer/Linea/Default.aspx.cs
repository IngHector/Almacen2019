using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;

namespace PresentationLayer
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LineaModel lm = new LineaModel();
            tableLineas.DataSource=  lm.getAll();
            tableLineas.DataBind();
        }

    }
}