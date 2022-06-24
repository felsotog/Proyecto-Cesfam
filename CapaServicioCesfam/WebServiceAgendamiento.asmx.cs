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
    /// Descripción breve de WebServiceAgendamiento
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceAgendamiento : System.Web.Services.WebService
    {

        [WebMethod]

        public void insertaAgendamientoService(Agendamiento agendamiento)
        {
            NegocioAgendamiento auxnegocioAgendamiento = new NegocioAgendamiento();
            auxnegocioAgendamiento.insertarAgendamiento(agendamiento);

        }


        [WebMethod]
        public DataSet retornarAgendamientoService(string id_agendamiento)
        {
            NegocioAgendamiento auxNegocioAgendamiento = new NegocioAgendamiento();
            return auxNegocioAgendamiento.retornarAgendamiento(id_agendamiento);
        }

        [WebMethod]
        public Agendamiento retornaPosicionAgendamientoService(int pos, string id_agendamiento)
        {
            NegocioAgendamiento auxNegocioAgendamiento = new NegocioAgendamiento();
            return auxNegocioAgendamiento.retornaPosicionAgendamiento(pos, id_agendamiento);
        }

        [WebMethod]

        public Agendamiento buscarAgendamientoService(String id_agendamiento)
        {
            NegocioAgendamiento auxNegocioAgendamiento = new NegocioAgendamiento();
            return auxNegocioAgendamiento.buscarAgendamiento(id_agendamiento);
        }

        [WebMethod]
        public Agendamiento buscarIdAgendamientoService(String id_agendamiento)
        {
            NegocioAgendamiento auxNegocioAgendamiento = new NegocioAgendamiento();
            return auxNegocioAgendamiento.buscarIdAgendamiento(id_agendamiento);
        }

        [WebMethod]

        public void eliminarAgendamientoService(String id_agendamiento)
        {
            NegocioAgendamiento auxNegocioAgendamiento = new NegocioAgendamiento();
            auxNegocioAgendamiento.eliminarAgendamiento(id_agendamiento);
        }

        [WebMethod]

        public void actualizarAgendamientoService(Agendamiento agendamiento)
        {
            NegocioAgendamiento auxNegocioAgendamiento = new NegocioAgendamiento();
            auxNegocioAgendamiento.actualizarAgendamiento(agendamiento);
        }
    }
}
