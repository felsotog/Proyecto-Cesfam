using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaHtml
{
    public partial class WebSalidaMedicamento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        public void LimpiarIngreso()
        {
            this.txtIdsalida.Text = "";
            this.txtFechasalida.Text = "";
            this.DropDownListRutFarm.Text = "";
            this.DropDownListRutP.Text = "";
        }

        protected void btnGuardar_Click1(object sender, EventArgs e)
        {
            ServiceMantenedorSalidaMedicamento.WebServiceSalidaMedicamentoSoapClient auxNegocioSalidaMedicamento = new ServiceMantenedorSalidaMedicamento.WebServiceSalidaMedicamentoSoapClient();
            ServiceMantenedorSalidaMedicamento.SalidaMedicamento auxSalidaMedicamento = new ServiceMantenedorSalidaMedicamento.SalidaMedicamento();
            auxSalidaMedicamento.Id_salida = this.txtIdsalida.Text;
            auxSalidaMedicamento.Fecha_salida = DateTime.Parse(this.txtFechasalida.Text);
            auxSalidaMedicamento.Farmaceutico_id_farmaceuta = this.DropDownListRutFarm.Text;
            auxSalidaMedicamento.Paciente_rut = this.DropDownListRutP.Text;
            

            if (String.IsNullOrEmpty(auxNegocioSalidaMedicamento.buscarIdSalidaMedicamentoService(auxSalidaMedicamento.Id_salida).Id_salida))
            {
                try
                {
                    if (String.IsNullOrEmpty(auxNegocioSalidaMedicamento.buscarIdSalidaMedicamentoService(auxSalidaMedicamento.Id_salida).Id_salida))
                    {

                        if (string.IsNullOrEmpty(this.txtIdsalida.Text) || string.IsNullOrEmpty(this.txtFechasalida.Text)
                         || string.IsNullOrEmpty(this.DropDownListRutFarm.Text) || string.IsNullOrEmpty(this.DropDownListRutP.Text)
                         )

                        {
                            this.lblError.Text = "complete todos los campos";
                        }
                        else
                        {
                            auxNegocioSalidaMedicamento.insertaSalidaMedicamentoService(auxSalidaMedicamento);
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

                }

            }
        }

        protected void btnGuardarDetalle_Click(object sender, EventArgs e)
        {
            ServiceMantenedorDetalleSalida.WebServiceDetalleSalidaSoapClient auxNegocioDetalleSalida = new ServiceMantenedorDetalleSalida.WebServiceDetalleSalidaSoapClient();
            ServiceMantenedorDetalleSalida.DetalleSalida auxDetalleSalida = new ServiceMantenedorDetalleSalida.DetalleSalida();
            auxDetalleSalida.Id_detalleSalida = this.txtIdDetalle.Text;
            auxDetalleSalida.Cantidad = int.Parse(this.txtCantidad.Text);
            auxDetalleSalida.Medicamento_codigo = this.DropDownListCodigoM.Text;
            auxDetalleSalida.Salida_medicamento_id_salida = this.DropDownListIdSalida.Text;


            if (String.IsNullOrEmpty(auxNegocioDetalleSalida.buscarDetalleSalidaService(auxDetalleSalida.Id_detalleSalida).Id_detalleSalida))
            {
                try
                {
                    if (String.IsNullOrEmpty(auxNegocioDetalleSalida.buscarDetalleSalidaService(auxDetalleSalida.Id_detalleSalida).Id_detalleSalida))
                    {

                        if (string.IsNullOrEmpty(this.txtIdDetalle.Text) || string.IsNullOrEmpty(this.txtCantidad.Text)
                         || string.IsNullOrEmpty(this.DropDownListCodigoM.Text) || string.IsNullOrEmpty(this.DropDownListIdSalida.Text)
                         )

                        {
                            this.Label14.Text = "complete todos los campos";
                        }
                        else
                        {
                            auxNegocioDetalleSalida.insertaDetalleSalidaService(auxDetalleSalida,this.txtIdDetalle.Text,this.DropDownListCodigoM.SelectedValue);
                            this.LimpiarIngreso();

                            this.Label15.Text = "Todos los datos Guardados Correctamente";
                            this.GridView1.DataBind();
                        }
                    }
                    else
                    {
                        this.Label14.Text = "entrega Medicamento ya existe";
                    }
                }
                catch (Exception ex)
                {

                }

            }
        }
    }
}