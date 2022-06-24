using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaServicioCesfam;
using CapaNegocioCesfam;

namespace CapaHtml
{
    public partial class WebAgendar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void btnAgendar_Click(object sender, EventArgs e)
        {
            
            ServiceMantenedorAgendamiento.WebServiceAgendamientoSoapClient auxNegocioAgendamiento = new ServiceMantenedorAgendamiento.WebServiceAgendamientoSoapClient();
            ServiceMantenedorAgendamiento.Agendamiento auxAgendamiento = new ServiceMantenedorAgendamiento.Agendamiento();
            auxAgendamiento.Id_agendamiento = this.txtIdAgendamiento.Text;
            auxAgendamiento.Horario = DateTime.Parse("2022-07-03");
            auxAgendamiento.Medico_rut_medico = this.txtRutMedico.Text;
            auxAgendamiento.Paciente_rut = this.txtRutPaciente.Text;
            auxNegocioAgendamiento.insertaAgendamientoService(auxAgendamiento);
        }
    }
}