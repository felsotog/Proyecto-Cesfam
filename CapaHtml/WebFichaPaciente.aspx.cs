﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaHtml
{
    public partial class WebFichaPaciente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Volver_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebPaginaPrincipal.aspx");
        }
    }
}