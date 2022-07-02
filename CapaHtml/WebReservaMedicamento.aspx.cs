using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaHtml
{
    public partial class WebReservaMedicamento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void LimpiarIngreso()
        {
            this.txtIdreserva.Text = "";
            this.txtFechareserva.Text = "";
            this.TextCantidad.Text = "";
            this.DropDownListRutFar.Text = "";
            this.DropDownListCodig.Text = "";
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            ServiceMantenedorReservaMedicamento.WebServiceReservaMedicamentoSoapClient auxNegocioReservaMedicamento = new ServiceMantenedorReservaMedicamento.WebServiceReservaMedicamentoSoapClient();
            ServiceMantenedorReservaMedicamento.ReservaMedicamento auxReservaMedicamento = new ServiceMantenedorReservaMedicamento.ReservaMedicamento();
            auxReservaMedicamento.Id_reserva = this.txtIdreserva.Text;
            auxReservaMedicamento.Fecha_reserva = DateTime.Parse(this.txtFechareserva.Text);
            auxReservaMedicamento.Cantidad_reserva = int.Parse(this.TextCantidad.Text);
            auxReservaMedicamento.Farmaceutico_id_farmaceuta = this.DropDownListRutFar.Text;
            auxReservaMedicamento.Medicamento_codigo = this.DropDownListCodig.Text;
            



            if (String.IsNullOrEmpty(auxNegocioReservaMedicamento.buscarIdReservaMedicamentoService(auxReservaMedicamento.Id_reserva).Id_reserva))
            {
                try
                {
                    if (String.IsNullOrEmpty(auxNegocioReservaMedicamento.buscarIdReservaMedicamentoService(auxReservaMedicamento.Id_reserva).Id_reserva))
                    {

                        if (string.IsNullOrEmpty(this.txtIdreserva.Text) || string.IsNullOrEmpty(this.txtFechareserva.Text)
                         || string.IsNullOrEmpty(this.TextCantidad.Text) || string.IsNullOrEmpty(this.DropDownListRutFar.Text)
                         || string.IsNullOrEmpty(this.DropDownListCodig.Text) )

                        {
                            this.lblError.Text = "complete todos los campos";
                        }
                        else
                        {
                            auxNegocioReservaMedicamento.insertaReservaMedicamentoService(auxReservaMedicamento);
                            this.LimpiarIngreso();

                            this.lblSucces.Text = "Todos los datos Guardados Correctamente";
                            this.GridView3.DataBind();
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
    }
}