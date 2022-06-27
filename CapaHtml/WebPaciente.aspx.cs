using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaHtml
{
    public partial class WebPaciente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void LimpiarIngreso()
        {
            this.txtRut.Text = "";
            this.txtNombre.Text = "";
            this.txtSector.Text = "";
            this.txtDireccion.Text = "";
            this.txtTelefono.Text = "";
        }

       

        

        protected void btnAgendar1_Click(object sender, EventArgs e)
        {
            ServiceMantenedorPaciente.WebServicePacienteSoapClient auxNegocioPaciente = new ServiceMantenedorPaciente.WebServicePacienteSoapClient();
            ServiceMantenedorPaciente.Paciente auxPaciente = new ServiceMantenedorPaciente.Paciente();

            auxPaciente.Rut = this.txtRut.Text;
            auxPaciente.Nombre_paciente = this.txtNombre.Text;
            auxPaciente.Sector = this.txtSector.Text;
            auxPaciente.Telefono = int.Parse(this.txtTelefono.Text);
            auxPaciente.Direccion = this.txtDireccion.Text;



            if (String.IsNullOrEmpty(auxNegocioPaciente.buscarPacienteService(auxPaciente.Rut).Rut))
            {
                try
                {                  

                    if (String.IsNullOrEmpty(auxNegocioPaciente.buscarPacienteService(auxPaciente.Rut).Rut))
                    {

                        if (string.IsNullOrEmpty(this.txtRut.Text) || string.IsNullOrEmpty(this.txtNombre.Text) 
                         || string.IsNullOrEmpty(this.txtSector.Text) || string.IsNullOrEmpty(this.txtTelefono.Text)
                         || string.IsNullOrEmpty(this.txtDireccion.Text))

                        {
                            //this.LabelMensaje1.Text = "complete todos los campos";
                        }
                        else
                        {
                            auxNegocioPaciente.insertPacienteService(auxPaciente);
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