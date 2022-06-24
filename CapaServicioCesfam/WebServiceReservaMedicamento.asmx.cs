using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using CapaNegocioCesfam;
using CapaDTOCesfam;
using System.Data;

namespace CapaServicioCesfam
{
    /// <summary>
    /// Descripción breve de WebServiceReservaMedicamento
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceReservaMedicamento : System.Web.Services.WebService
    {


        [WebMethod]

        public void insertaReservaMedicamentoService(ReservaMedicamento auxReservaMedicamento)
        {
            NegocioReservaMedicamento auxnegocioReservaMedicamento = new NegocioReservaMedicamento();
            auxnegocioReservaMedicamento.insertarReservaMedicamento(auxReservaMedicamento);

        }


        [WebMethod]
        public DataSet retornarReservaMedicamentoService(string id_reserva)
        {
            NegocioReservaMedicamento auxNegocioReservaMedicamento = new NegocioReservaMedicamento();
            return auxNegocioReservaMedicamento.retornarReservaMedicamento(id_reserva);
        }

        [WebMethod]
        public ReservaMedicamento retornaPosicionReservaMedicamentoService(int pos, string id_reserva)
        {
            NegocioReservaMedicamento auxNegocioReservaMedicamento = new NegocioReservaMedicamento();
            return auxNegocioReservaMedicamento.retornaPosicionReservaMedicamento(pos, id_reserva);
        }

        [WebMethod]

        public ReservaMedicamento buscarReservaMedicamentoService(String id_reserva)
        {
            NegocioReservaMedicamento auxNegocioReservaMedicamento = new NegocioReservaMedicamento();
            return auxNegocioReservaMedicamento.buscarReservaMedicamento(id_reserva);
        }

        [WebMethod]
        public ReservaMedicamento buscarIdReservaMedicamentoService(String id_reserva)
        {
            NegocioReservaMedicamento auxNegocioReservaMedicamento = new NegocioReservaMedicamento();
            return auxNegocioReservaMedicamento.buscarIdReservaMedicamento(id_reserva);
        }

        [WebMethod]

        public void eliminarReservaMedicamentoService(String id_reserva)
        {
            NegocioReservaMedicamento auxNegocioReservaMedicamento = new NegocioReservaMedicamento();
            auxNegocioReservaMedicamento.eliminarReservaMedicamento(id_reserva);
        }

        [WebMethod]

        public void actualizarReservaMedicamentoService(ReservaMedicamento reserva_medicamento)
        {
            NegocioReservaMedicamento auxNegocioReservaMedicamento = new NegocioReservaMedicamento();
            auxNegocioReservaMedicamento.actualizarReservaMedicamento(reserva_medicamento);
        }
    }
}
