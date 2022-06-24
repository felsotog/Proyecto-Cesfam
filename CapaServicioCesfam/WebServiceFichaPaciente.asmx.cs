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
    /// Descripción breve de WebServiceFichaPaciente
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceFichaPaciente : System.Web.Services.WebService
    {

        [WebMethod]

        public void insertaFichaPacienteService(FichaPaciente ficha_paciente)
        {
            NegocioFichaPaciente auxNegocioFichaPaciente = new NegocioFichaPaciente();
            auxNegocioFichaPaciente.insertarFichaPaciente(ficha_paciente);

        }


        [WebMethod]
        public DataSet retornarFichaPacienteService(string id_ficha)
        {
            NegocioFichaPaciente auxNegocioFichaPaciente = new NegocioFichaPaciente();
            return auxNegocioFichaPaciente.retornarFichaPaciente(id_ficha);
        }

        [WebMethod]
        public FichaPaciente retornaPosicionFichaPacienteService(int pos, string id_ficha)
        {
            NegocioFichaPaciente auxNegocioFichaPaciente = new NegocioFichaPaciente();
            return auxNegocioFichaPaciente.retornaPosicionFichaPaciente(pos, id_ficha);
        }

        [WebMethod]

        public FichaPaciente buscarFichaPacienteService(String id_ficha)
        {
            NegocioFichaPaciente auxNegocioFichaPaciente = new NegocioFichaPaciente();
            return auxNegocioFichaPaciente.buscarFichaPaciente(id_ficha);
        }

        [WebMethod]
        public FichaPaciente buscarIdFichaPacienteService(String id_ficha)
        {
            NegocioFichaPaciente auxNegocioFichaPaciente = new NegocioFichaPaciente();
            return auxNegocioFichaPaciente.buscarIdFichaPaciente(id_ficha);
        }

        [WebMethod]

        public void eliminarFichaPacienteService(String id_ficha)
        {
            NegocioFichaPaciente auxNegocioFichaPaciente = new NegocioFichaPaciente();
            auxNegocioFichaPaciente.eliminarFichaPaciente(id_ficha);
        }

        [WebMethod]

        public void actualizarFichaPacienteService(FichaPaciente ficha_paciente)
        {
           NegocioFichaPaciente auxNegocioFichaPaciente = new NegocioFichaPaciente();
            auxNegocioFichaPaciente.actualizarFichaPaciente(ficha_paciente);
        }
    }
}
