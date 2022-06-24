using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaHtml
{
    public partial class WebFarmacia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.lblError.Text = "";
            this.lblSucces.Text = "";
        }

        protected void btnFarmacia_Click(object sender, EventArgs e)
        {
            ServiceMantenedorFarmacia.WebServiceFarmaciaSoapClient auxNegocioFarmacia = new ServiceMantenedorFarmacia.WebServiceFarmaciaSoapClient();
            ServiceMantenedorFarmacia.Farmacia auxFarmacia = new ServiceMantenedorFarmacia.Farmacia();
            auxFarmacia.Id_farmacia = this.txtIdFarmacia.Text;
            auxFarmacia.Nombre_farmacia = this.txtNombreFarmacia.Text;
            auxNegocioFarmacia.insertaFarmaciaService(auxFarmacia);
            this.lblSucces.Text = "Todos los datos Guardados Correctamente";
        }

        protected void Volver_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebPaginaPrincipal.aspx");
        }
    }
}