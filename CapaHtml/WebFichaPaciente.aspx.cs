using System;
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
            this.GridView1.DataBind();
        }

        protected void Volver_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebPaginaPrincipal.aspx");
        }

        public void LimpiarIngreso()
        {
            this.txtIdficha.Text = "";
            this.txtCalendario.Text = "";
            this.DropDownListrutmedico.Text = "";
            this.DropDownListRutPac.Text = "";
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            ServiceMantenedorFichaPaciente.WebServiceFichaPacienteSoapClient auxNegocioFichaPaciente = new ServiceMantenedorFichaPaciente.WebServiceFichaPacienteSoapClient();
            ServiceMantenedorFichaPaciente.FichaPaciente auxFichaPaciente = new ServiceMantenedorFichaPaciente.FichaPaciente();

            auxFichaPaciente.Id_ficha = this.txtIdficha.Text;
            auxFichaPaciente.Fecha_ficha = DateTime.Parse(this.txtCalendario.Text);
            auxFichaPaciente.Medico_rut_medico = this.DropDownListrutmedico.SelectedValue;
            auxFichaPaciente.Paciente_rut = this.DropDownListRutPac.SelectedValue;
            



            if (String.IsNullOrEmpty(auxNegocioFichaPaciente.buscarFichaPacienteService(auxFichaPaciente.Id_ficha).Id_ficha))
            {
                try
                {


                    if (String.IsNullOrEmpty(auxNegocioFichaPaciente.buscarFichaPacienteService(auxFichaPaciente.Id_ficha).Id_ficha))
                    {

                        if (string.IsNullOrEmpty(this.txtIdficha.Text) || string.IsNullOrEmpty(this.txtCalendario.Text) || string.IsNullOrEmpty(this.DropDownListrutmedico.Text) || string.IsNullOrEmpty(this.DropDownListRutPac.Text) )

                        {
                            this.Label11.Text = "complete todos los campos";
                        }
                        else
                        {
                            auxNegocioFichaPaciente.insertaFichaPacienteService(auxFichaPaciente);
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

        protected void btnGuardarDetalle_Click(object sender, EventArgs e)
        {
            ServiceMantenedorDetalleFicha.WebService1DetalleFichaSoapClient auxNegocioDetalleFicha = new ServiceMantenedorDetalleFicha.WebService1DetalleFichaSoapClient();
            ServiceMantenedorDetalleFicha.DetalleFicha auxDetalleFicha = new ServiceMantenedorDetalleFicha.DetalleFicha();

            auxDetalleFicha.Id_detalle_ficha = this.txtIdDetalle.Text;
            auxDetalleFicha.Ficha_paciente_id_ficha = this.DropDownListIdFicha.SelectedValue;
            auxDetalleFicha.Formulario_medicamento_id_formulario = this.DropDownListIdForm.SelectedValue;
            auxDetalleFicha.Comentarios = this.TextAreaComentarios.InnerText;




            if (String.IsNullOrEmpty(auxNegocioDetalleFicha.buscarDetalleFichaService(auxDetalleFicha.Id_detalle_ficha).Id_detalle_ficha))
            {
                try
                {


                    if (String.IsNullOrEmpty(auxNegocioDetalleFicha.buscarDetalleFichaService(auxDetalleFicha.Id_detalle_ficha).Id_detalle_ficha))
                    {

                        if (string.IsNullOrEmpty(this.txtIdDetalle.Text) || string.IsNullOrEmpty(this.DropDownListIdFicha.Text) || string.IsNullOrEmpty(this.DropDownListIdForm.Text) || string.IsNullOrEmpty(this.TextAreaComentarios.InnerText))

                        {
                            this.Label11.Text = "complete todos los campos";
                        }
                        else
                        {
                            auxNegocioDetalleFicha.insertaDetalleFichadService(auxDetalleFicha);
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