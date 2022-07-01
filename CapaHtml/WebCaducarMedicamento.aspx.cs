using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaHtml
{
    public partial class WebCaducarMedicamento : System.Web.UI.Page
    {
        public void LimpiarIngreso()
        {
            this.txtIdmerma.Text = "";
            this.txtFechacaducidad.Text = "";
            
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgendar1_Click(object sender, EventArgs e)
        {
            ServiceMantenedorCaducarMedicamento.WebService1CaducarMedicamentoSoapClient auxNegocioCaducarMedicamento = new ServiceMantenedorCaducarMedicamento.WebService1CaducarMedicamentoSoapClient();
            ServiceMantenedorCaducarMedicamento.CaducarMedicamento auxCaducarMedicamento = new ServiceMantenedorCaducarMedicamento.CaducarMedicamento();

            auxCaducarMedicamento.Id_caducidad = this.txtIdmerma.Text;
            auxCaducarMedicamento.Fecha_caducidad = DateTime.Parse(this.txtFechacaducidad.Text);



            if (String.IsNullOrEmpty(auxNegocioCaducarMedicamento.buscarCaducarMedicamentoService(auxCaducarMedicamento.Id_caducidad).Id_caducidad))
            {
                try
                {


                    auxCaducarMedicamento.Id_caducidad = this.txtIdmerma.Text;
                    auxCaducarMedicamento.Fecha_caducidad = DateTime.Parse(this.txtFechacaducidad.Text);


                    if (String.IsNullOrEmpty(auxNegocioCaducarMedicamento.buscarCaducarMedicamentoService(auxCaducarMedicamento.Id_caducidad).Id_caducidad))
                    {

                        if (string.IsNullOrEmpty(this.txtIdmerma.Text) || string.IsNullOrEmpty(this.txtFechacaducidad.Text))

                        {
                            this.lblError.Text = "complete todos los campos";
                        }
                        else
                        {
                            auxNegocioCaducarMedicamento.insertaCaducarMedicamentoService(auxCaducarMedicamento);
                            this.LimpiarIngreso();

                            this.lblSucces.Text = "datos guardados correctamente";
                            this.GridView1.DataBind();



                        }
                    }
                    else
                    {
                        this.lblError.Text = "ingreso Merma ya existe";
                    }
                }
                catch (Exception ex)
                {
                    this.lblError.Text = "error al guardar";
                }

            }

            
        }

        protected void btnGuardarDetalle_Click(object sender, EventArgs e)
        {

           
        }

        protected void btonGuardarDetalle_Click(object sender, EventArgs e)
        {
            ServiceMantenedorDetalleCaducidad.WebService1DetalleCaducidadSoapClient auxNegocioDetalleCaducidad = new ServiceMantenedorDetalleCaducidad.WebService1DetalleCaducidadSoapClient();
            ServiceMantenedorDetalleCaducidad.DetalleCaducidad auxDetalleCaducidad = new ServiceMantenedorDetalleCaducidad.DetalleCaducidad();

            auxDetalleCaducidad.Id_detalle = this.TxtIdDetalle.Text;
            auxDetalleCaducidad.Cantidad_caducada = int.Parse(this.txtCantidad.Text);
            auxDetalleCaducidad.Motivo = this.TextAreaMotivo.InnerText;
            auxDetalleCaducidad.Medicamento_codigo = this.DropDownListCodigoM.SelectedValue;
            auxDetalleCaducidad.Caducar_medicamento_id_caducidad = this.DropDownListMermaId.SelectedValue;



            if (String.IsNullOrEmpty(auxNegocioDetalleCaducidad.buscarDetalleCaducidadService(auxDetalleCaducidad.Id_detalle).Id_detalle))
            {
                try
                {


                    if (String.IsNullOrEmpty(auxNegocioDetalleCaducidad.buscarDetalleCaducidadService(auxDetalleCaducidad.Id_detalle).Id_detalle))
                    {

                        if (string.IsNullOrEmpty(this.TxtIdDetalle.Text) || string.IsNullOrEmpty(this.txtCantidad.Text) || string.IsNullOrEmpty(this.TextAreaMotivo.InnerText) || string.IsNullOrEmpty(this.DropDownListCodigoM.SelectedValue) || string.IsNullOrEmpty(this.DropDownListMermaId.SelectedValue))

                        {
                            this.Label11.Text = "complete todos los campos";
                        }
                        else
                        {
                            auxNegocioDetalleCaducidad.insertaDetalleCaducidadService(auxDetalleCaducidad);
                            this.LimpiarIngreso();

                            this.Label12.Text = "datos guardados correctamente";
                            this.GridView1.DataBind();



                        }
                    }
                    else
                    {
                        this.Label11.Text = "ingreso Merma ya existe";
                    }
                }
                catch (Exception ex)
                {
                    this.Label1.Text = "error al guardar";
                }

            }
        }
    }
}