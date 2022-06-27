using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaHtml
{
    public partial class WebMedicamento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        public void LimpiarIngreso()
        {
            this.txtcodigo.Text = "";
            this.txtNombre.Text = "";
            this.txtTipo.Text = "";
            this.txtFechafabricacion.Text = "";
            this.txtFechavencimiento.Text = "";
            this.TextAreaDescripcion.InnerText = "";
            this.txtCantidad.Text = "";
            this.DropDownListidfarmacia.Text = "";
        }

        protected void btnGuardar_Click1(object sender, EventArgs e)
        {
            ServiceMantenedorMedicamento.WebServiceMedicamentoSoapClient auxNegocioMedicamento = new ServiceMantenedorMedicamento.WebServiceMedicamentoSoapClient();
            ServiceMantenedorMedicamento.Medicamento auxMedicamento = new ServiceMantenedorMedicamento.Medicamento();
            auxMedicamento.Codigo = this.txtcodigo.Text;
            auxMedicamento.Nombre_medicamento = this.txtNombre.Text;
            auxMedicamento.Tipo_medicamento = this.txtTipo.Text;
            auxMedicamento.Fecha_fabricacion = DateTime.Parse(this.txtFechafabricacion.Text);
            auxMedicamento.Fecha_vencimiento = DateTime.Parse(this.txtFechavencimiento.Text);
            auxMedicamento.Descripcion = this.TextAreaDescripcion.InnerText;
            auxMedicamento.Cantidad = int.Parse(this.txtCantidad.Text);
            auxMedicamento.Farmacia_id_farmacia = this.DropDownListidfarmacia.SelectedValue;


            if (String.IsNullOrEmpty(auxNegocioMedicamento.buscarIdMedicamentoService(auxMedicamento.Codigo).Codigo))
            {
                try
                {
                    if (String.IsNullOrEmpty(auxNegocioMedicamento.buscarIdMedicamentoService(auxMedicamento.Codigo).Codigo))
                    {

                        if (string.IsNullOrEmpty(this.txtcodigo.Text) || string.IsNullOrEmpty(this.txtNombre.Text) 
                         || string.IsNullOrEmpty(this.txtTipo.Text) || string.IsNullOrEmpty(this.txtFechafabricacion.Text)
                         || string.IsNullOrEmpty(this.txtFechavencimiento.Text) || string.IsNullOrEmpty(this.TextAreaDescripcion.InnerText)
                         || string.IsNullOrEmpty(this.txtCantidad.Text) || string.IsNullOrEmpty(this.DropDownListidfarmacia.SelectedValue)) 

                        {
                            this.lblError.Text = "complete todos los campos";
                        }
                        else
                        {
                            auxNegocioMedicamento.insertaMedicamentoService(auxMedicamento);
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