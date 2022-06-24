using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using CapaDTOCesfam;
using CapaNegocioCesfam;


namespace CapaServicioCesfam
{
    /// <summary>
    /// Descripción breve de WebServicePaciente
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServicePaciente : System.Web.Services.WebService
    {


        [WebMethod]

        public void insertPacienteService(Paciente auxPaciente)
        {
            NegocioPaciente auxnegocioPaciente = new NegocioPaciente();
            auxnegocioPaciente.insertarPaciente(auxPaciente);

        }


        [WebMethod]
        public DataSet retornarMedicamentoService(string rut)
        {
            NegocioPaciente auxNegocioPaciente = new NegocioPaciente();
            return auxNegocioPaciente.retornarPaciente(rut);
        }

        [WebMethod]
        public Paciente retornaPosicionPacienteService(int pos, string rut)
        {
            NegocioPaciente auxNegocioPaciente = new NegocioPaciente();
            return auxNegocioPaciente.retornaPosicionPaciente(pos, rut);
        }

        [WebMethod]

        public Paciente buscarPacienteService(String rut)
        {
            NegocioPaciente auxNegocioPaciente = new NegocioPaciente();
            return auxNegocioPaciente.buscarPaciente(rut);
        }

        [WebMethod]
        public Paciente buscarIdPacienteService(String rut)
        {
            NegocioPaciente auxNegocioPaciente = new NegocioPaciente();
            return auxNegocioPaciente.buscarIdPaciente(rut);
        }

        [WebMethod]

        public void eliminarPacienteService(String rut)
        {
            NegocioPaciente auxNegocioPaciente = new NegocioPaciente();
            auxNegocioPaciente.eliminarPaciente(rut);
        }

        [WebMethod]

        public void actualizarPacienteService(Paciente paciente)
        {
            NegocioPaciente auxNegocioPaciente = new NegocioPaciente();
            auxNegocioPaciente.actualizarPaciente(paciente);
        }
    }
}
