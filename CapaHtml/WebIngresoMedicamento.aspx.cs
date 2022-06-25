using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaHtml
{
    public partial class WebIngresoMedicamento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Volver_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebPaginaPrincipal.aspx");
        }

        protected void MostrarIdFarmaceuta_Click(object sender, EventArgs e)
        {
            ServiceMantenedorFarmaceutico.WebServiceFarmaceuticoSoapClient auxNegocioFarmaceutico = new ServiceMantenedorFarmaceutico.WebServiceFarmaceuticoSoapClient();

            this.GridViewFarmaceuta.DataSource = auxNegocioFarmaceutico.retornarTotalFarmaceutasService();
            this.GridViewFarmaceuta.DataMember = "farmaceutico";
            this.GridViewFarmaceuta.DataBind();
        }

        protected void btnGuardarMedicamento_Click(object sender, EventArgs e)
        {
            ServiceMantenedorIngresoMedicamento.WebService1IngresoMedicamentoSoapClient auxNegocioIngresoMedicamento = new ServiceMantenedorIngresoMedicamento.WebService1IngresoMedicamentoSoapClient();
            ServiceMantenedorIngresoMedicamento.IngresoMedicamento auxIngresoMedicamento = new ServiceMantenedorIngresoMedicamento.IngresoMedicamento();
            auxIngresoMedicamento.Id_ingreso = this.txtIdIngreso.Text;
            auxIngresoMedicamento.Fecha_ingreso = DateTime.Parse(this.FechaIngreso.Text);
            auxIngresoMedicamento.Farmaceutico_id_farmaceuta = this.DropDownListidfarmaceuta.Text;
            auxNegocioIngresoMedicamento.insertaIngresoMedicamentoService(auxIngresoMedicamento);
            this.lblSucces.Text = "Todos los datos Guardados Correctamente";
        }
    }
}