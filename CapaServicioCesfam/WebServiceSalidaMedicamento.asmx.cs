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
    /// Descripción breve de WebServiceSalidaMedicamento
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceSalidaMedicamento : System.Web.Services.WebService
    {


        [WebMethod]

        public void insertaSalidaMedicamentoService(SalidaMedicamento auxSalidaMedicamento)
        {
            NegocioSalidaMedicamento auxnegocioSalidaMedicamento = new NegocioSalidaMedicamento();
            auxnegocioSalidaMedicamento.insertarSalidaMedicamento(auxSalidaMedicamento);

        }


        [WebMethod]
        public DataSet retornarSalidaMedicamentoService(string id_salida)
        {
            NegocioSalidaMedicamento auxNegocioSalidaMedicamento = new NegocioSalidaMedicamento();
            return auxNegocioSalidaMedicamento.retornarSalidaMedicamento(id_salida);
        }

        [WebMethod]
        public SalidaMedicamento retornaPosicionSalidaMedicamentoService(int pos, string id_salida)
        {
            NegocioSalidaMedicamento auxNegocioSalidaMedicamento = new NegocioSalidaMedicamento();
            return auxNegocioSalidaMedicamento.retornaPosicionSalidaMedicamento(pos, id_salida);
        }

        [WebMethod]

        public SalidaMedicamento buscarSalidaMedicamentoService(String id_salida)
        {
            NegocioSalidaMedicamento auxNegocioSalidaMedicamento = new NegocioSalidaMedicamento();
            return auxNegocioSalidaMedicamento.buscarSalidaMedicamento(id_salida);
        }

        [WebMethod]
        public SalidaMedicamento buscarIdSalidaMedicamentoService(String id_salida)
        {
            NegocioSalidaMedicamento auxNegocioSalidaMedicamento = new NegocioSalidaMedicamento();
            return auxNegocioSalidaMedicamento.buscarIdSalidaMedicamento(id_salida);
        }

        [WebMethod]

        public void eliminarSalidaMedicamentoService(String id_salida)
        {
            NegocioSalidaMedicamento auxNegocioSalidaMedicamento = new NegocioSalidaMedicamento();
            auxNegocioSalidaMedicamento.eliminarSalidaMedicamento(id_salida);
        }

        [WebMethod]

        public void actualizarSalidaMedicamentoService(SalidaMedicamento salida_medicamento)
        {
            NegocioSalidaMedicamento auxNegocioSalidaMedicamento = new NegocioSalidaMedicamento();
            auxNegocioSalidaMedicamento.actualizarSalidaMedicamento(salida_medicamento);
        }
    }
}
