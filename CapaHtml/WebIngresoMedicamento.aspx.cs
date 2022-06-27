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

        public void LimpiarIngreso()
        {
            this.txtIdIngreso.Text = "";
            this.FechaIngreso.Text = "";
            this.DropDownListidfarmaceuta.Text = "";
        }

        protected void Volver_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebPaginaPrincipal.aspx");
        }

        protected void MostrarIdFarmaceuta_Click(object sender, EventArgs e)
        {
            ServiceMantenedorFarmaceutico.WebServiceFarmaceuticoSoapClient auxNegocioFarmaceutico = new ServiceMantenedorFarmaceutico.WebServiceFarmaceuticoSoapClient();

            
        }

        protected void btnGuardarMedicamento_Click(object sender, EventArgs e)
        {
           
        }

        protected void btnGuardarDetalle_Click(object sender, EventArgs e)
        {

            ServiceMantenedorDetalleIngreso.WebService1DetalleIngresoSoapClient auxNegocioDetalleIngreso = new ServiceMantenedorDetalleIngreso.WebService1DetalleIngresoSoapClient();
            ServiceMantenedorDetalleIngreso.DetalleIngreso auxDetalleIngreso = new ServiceMantenedorDetalleIngreso.DetalleIngreso();
            auxDetalleIngreso.Id_detalleIngr = this.txtIddetalle.Text;
            auxDetalleIngreso.Cantidad = int.Parse(this.txtCantidad.Text);
            auxDetalleIngreso.Fecha_elaboracion = DateTime.Parse(this.txtFechaelaboracion.Text);
            auxDetalleIngreso.Fecha_vencimiento = DateTime.Parse(this.txtFechavencimiento.Text);
            auxDetalleIngreso.Medicamento_codico = this.DropDownListCodigomedicamento.SelectedValue;
            auxDetalleIngreso.Ingreso_medicamento_id_ingreso = this.DropDownListIngresoid.SelectedValue;


            if (String.IsNullOrEmpty(auxNegocioDetalleIngreso.buscarDetalleIngresoService(auxDetalleIngreso.Id_detalleIngr).Id_detalleIngr))
            {
                try
                {
                    if (String.IsNullOrEmpty(auxNegocioDetalleIngreso.buscarDetalleIngresoService(auxDetalleIngreso.Id_detalleIngr).Id_detalleIngr))
                    {

                        if (string.IsNullOrEmpty(this.txtIddetalle.Text) || string.IsNullOrEmpty(this.txtCantidad.Text)
                         || string.IsNullOrEmpty(this.txtFechaelaboracion.Text) || string.IsNullOrEmpty(this.txtFechavencimiento.Text)
                         || string.IsNullOrEmpty(this.DropDownListCodigomedicamento.Text) || string.IsNullOrEmpty(this.DropDownListIngresoid.Text))

                        {
                            this.lblError.Text = "complete todos los campos";
                        }
                        else
                        {
                            auxNegocioDetalleIngreso.insertaDetalleIngresoService(auxDetalleIngreso,this.txtIddetalle.Text,this.DropDownListCodigomedicamento.SelectedValue);
                            this.LimpiarIngreso();

                            this.lblSucces.Text = "Todos los datos Guardados Correctamente";
                            this.GridView1.DataBind();
                        }
                    }
                    else
                    {
                        this.lblError.Text = "Detalle ingreso Medicamento ya existe";
                    }
                }
                catch (Exception ex)
                {
                    this.lblError.Text = "error al guardar";
                }

            }
        }



        //-----------------------------------------------------------------------------------------------------------------------

        protected void btnGuardarIngreso_Click(object sender, EventArgs e)
        {
            ServiceMantenedorIngresoMedicamento.WebService1IngresoMedicamentoSoapClient auxNegocioIngresoMedicamento = new ServiceMantenedorIngresoMedicamento.WebService1IngresoMedicamentoSoapClient();
            ServiceMantenedorIngresoMedicamento.IngresoMedicamento auxIngresoMedicamento = new ServiceMantenedorIngresoMedicamento.IngresoMedicamento();
            auxIngresoMedicamento.Id_ingreso = this.txtIdIngreso.Text;
            auxIngresoMedicamento.Fecha_ingreso = DateTime.Parse(this.FechaIngreso.Text);
            auxIngresoMedicamento.Farmaceutico_id_farmaceuta = this.DropDownListidfarmaceuta.Text;


            if (String.IsNullOrEmpty(auxNegocioIngresoMedicamento.buscarIdIngresoMedicamentoService(auxIngresoMedicamento.Id_ingreso).Id_ingreso))
            {
                try
                {
                    if (String.IsNullOrEmpty(auxNegocioIngresoMedicamento.buscarIdIngresoMedicamentoService(auxIngresoMedicamento.Id_ingreso).Id_ingreso))
                    {

                        if (string.IsNullOrEmpty(this.txtIdIngreso.Text) || string.IsNullOrEmpty(this.FechaIngreso.Text) || string.IsNullOrEmpty(this.DropDownListidfarmaceuta.Text))

                        {
                            this.lblError.Text = "complete todos los campos";
                        }
                        else
                        {
                            auxNegocioIngresoMedicamento.insertaIngresoMedicamentoService(auxIngresoMedicamento);
                            this.LimpiarIngreso();

                            this.lblSucces.Text = "Todos los datos Guardados Correctamente";
                            this.GridView1.DataBind();
                        }
                    }
                    else
                    {
                        this.lblError.Text = "ingreso Medicamento ya existe";
                    }
                }
                catch (Exception ex)
                {
                    this.lblError.Text = "error al guardar";
                }

            }
        }
    }
}