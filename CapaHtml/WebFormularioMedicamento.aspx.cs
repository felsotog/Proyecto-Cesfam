using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaHtml
{
    public partial class WebFormularioMedicamento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        public void LimpiarIngreso()
        {
            this.txtIdformulario.Text = "";
            this.txtFechareceta.Text = "";
            this.DropDownListRutM.Text = "";
        }

        protected void btnGuardarDetalle_Click(object sender, EventArgs e)
        {
            ServiceMantenedorFormularioMedicamento.WebServiceFormularioMedicamentoSoapClient auxNegocioFormularioMedicamento = new ServiceMantenedorFormularioMedicamento.WebServiceFormularioMedicamentoSoapClient();
            ServiceMantenedorFormularioMedicamento.FormularioMedicamento auxFormulario = new ServiceMantenedorFormularioMedicamento.FormularioMedicamento();

            auxFormulario.Id_formulario = this.txtIdformulario.Text;
            auxFormulario.Fecha_receta = DateTime.Parse(this.txtFechareceta.Text);
            auxFormulario.Medico_rut_medico = this.DropDownListRutM.SelectedValue;
            




            if (String.IsNullOrEmpty(auxNegocioFormularioMedicamento.buscarFormularioMedicamentoService(auxFormulario.Id_formulario).Id_formulario))
            {
                try
                {


                    if (String.IsNullOrEmpty(auxNegocioFormularioMedicamento.buscarFormularioMedicamentoService(auxFormulario.Id_formulario).Id_formulario))
                    {

                        if (string.IsNullOrEmpty(this.txtIdformulario.Text) || string.IsNullOrEmpty(this.txtFechareceta.Text) || string.IsNullOrEmpty(this.DropDownListRutM.Text) )

                        {
                            this.lblError.Text = "complete todos los campos";
                        }
                        else
                        {
                            auxNegocioFormularioMedicamento.insertaFormularioMedicamentoService(auxFormulario);
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
                    ///this.lblError.Text = "error al guardar";
                }

            }
        }
    }
}