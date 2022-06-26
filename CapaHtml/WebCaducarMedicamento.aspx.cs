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
                            //this.LabelMensaje1.Text = "complete todos los campos";
                        }
                        else
                        {
                            auxNegocioCaducarMedicamento.insertaCaducarMedicamentoService(auxCaducarMedicamento);
                            this.LimpiarIngreso();

                            //this.LabelMensaje1.Text = "datos guardados correctamente";
                            this.GridView1.DataBind();



                        }
                    }
                    else
                    {
                        //this.LabelMensaje1.Text = "ingreso Merma ya existe";
                    }
                }
                catch (Exception ex)
                {
                    //this.LabelMensaje1.Text = "error al guardar";
                }

            }
        }
    }
}