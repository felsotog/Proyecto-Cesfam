using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaHtml
{
    public partial class WebMedico : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void LimpiarIngreso()
        {
            this.txtRut.Text = "";
            this.txtNombre.Text = "";
            this.txtEspecialidad.Text = "";
            this.txtDireccion.Text = "";
            this.txtTelefono.Text = "";
            this.txtEmail.Text = "";
        }

        protected void btnAgendar1_Click(object sender, EventArgs e)
        {
            ServiceMantenedorMedico.WebServiceMedicoSoapClient auxNegocioMedico = new ServiceMantenedorMedico.WebServiceMedicoSoapClient();
            ServiceMantenedorMedico.Medico auxMedico = new ServiceMantenedorMedico.Medico();
            auxMedico.Rut_medico = this.txtRut.Text;
            auxMedico.Nombre_completo = this.txtNombre.Text;
            auxMedico.Especialidad = this.txtEspecialidad.Text;
            auxMedico.Direccion = this.txtDireccion.Text;
            auxMedico.Telefono = this.txtTelefono.Text;
            auxMedico.Email = this.txtEmail.Text;
            


            if (String.IsNullOrEmpty(auxNegocioMedico.buscarIdMedicoService(auxMedico.Rut_medico).Rut_medico))
            {
                try
                {
                    if (String.IsNullOrEmpty(auxNegocioMedico.buscarIdMedicoService(auxMedico.Rut_medico).Rut_medico))
                    {

                        if (string.IsNullOrEmpty(this.txtRut.Text) || string.IsNullOrEmpty(this.txtNombre.Text)
                         || string.IsNullOrEmpty(this.txtEspecialidad.Text) || string.IsNullOrEmpty(this.txtDireccion.Text)
                         || string.IsNullOrEmpty(this.txtTelefono.Text) || string.IsNullOrEmpty(this.txtEmail.Text))

                        {
                            this.lblError.Text = "complete todos los campos";
                        }
                        else
                        {
                            auxNegocioMedico.insertaMedicoService(auxMedico);
                            this.LimpiarIngreso();

                            this.lblSucces.Text = "Todos los datos Guardados Correctamente";
                            this.GridView2.DataBind();
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