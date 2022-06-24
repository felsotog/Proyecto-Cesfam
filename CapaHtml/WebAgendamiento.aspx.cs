using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaHtml
{
    public partial class WebAgendamiento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.lblError.Text = "";
            this.lblSucces.Text = "";
        }

        protected void btnAgendar_Click(object sender, EventArgs e)
        {
            if (this.txtIdAgendamiento.Text == "" || this.Calendario.Text == ""
                || this.txtRutMedico.Text == "" || this.txtRutPaciente.Text == "")
            {
                this.lblError.Text = "Todos los campos olbligatorios!";
            }
            else
            {
                ServiceMantenedorAgendamiento.WebServiceAgendamientoSoapClient auxNegocioAgendamiento = new ServiceMantenedorAgendamiento.WebServiceAgendamientoSoapClient();
                ServiceMantenedorAgendamiento.Agendamiento auxAgendamiento = new ServiceMantenedorAgendamiento.Agendamiento();
                auxAgendamiento.Id_agendamiento = this.txtIdAgendamiento.Text;
                auxAgendamiento.Horario = DateTime.Parse(this.Calendario.Text);
                auxAgendamiento.Medico_rut_medico = this.txtRutMedico.Text;
                auxAgendamiento.Paciente_rut = this.txtRutPaciente.Text;
                auxNegocioAgendamiento.insertaAgendamientoService(auxAgendamiento);
                this.lblSucces.Text = "Todos los datos Guardados Correctamente";
                Limpiar();
            }

            void Limpiar()
            {
                this.txtIdAgendamiento.Text = "";
                this.Calendario.Text = "";
                this.txtRutMedico.Text = "";
                this.txtRutPaciente.Text = "";
            }
        }

        protected void Volver_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebPaginaPrincipal.aspx");
        }
    }
}