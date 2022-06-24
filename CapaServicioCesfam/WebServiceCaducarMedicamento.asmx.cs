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
    /// Descripción breve de WebService1CaducarMedicamento
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1CaducarMedicamento : System.Web.Services.WebService
    {

        [WebMethod]

        public void insertaCaducarMedicamentoService(CaducarMedicamento caducarmedicamento)
        {
            NegocioCaducarMedicamento auxnegocioCaducarMedicamento = new NegocioCaducarMedicamento();
            auxnegocioCaducarMedicamento.insertarCaducarMedicamento(caducarmedicamento);

        }


        [WebMethod]
        public DataSet retornarCaducarMedicamentoService(string id_caducidad)
        {
            NegocioCaducarMedicamento auxNegocioCaducarMedicamento = new NegocioCaducarMedicamento();
            return auxNegocioCaducarMedicamento.retornarCaducarMedicamento(id_caducidad);
        }

        [WebMethod]
        public CaducarMedicamento retornaPosicionCaducarMedicamentoService(int pos, string id_caducidad)
        {
            NegocioCaducarMedicamento auxNegocioCaducarMedicamento = new NegocioCaducarMedicamento();
            return auxNegocioCaducarMedicamento.retornaPosicionCaducarMedicamento(pos, id_caducidad);
        }

        [WebMethod]

        public CaducarMedicamento buscarCaducarMedicamentoService(String id_caducidad)
        {
            NegocioCaducarMedicamento auxNegocioCaducarMedicamento = new NegocioCaducarMedicamento();
            return auxNegocioCaducarMedicamento.buscarCaducarMedicamento(id_caducidad);
        }

        [WebMethod]
        public CaducarMedicamento buscarIdCaducarMedicamentoService(String id_caducidad)
        {
            NegocioCaducarMedicamento auxNegocioCaducarMedicamento = new NegocioCaducarMedicamento();
            return auxNegocioCaducarMedicamento.buscarIdCaducarMedicamento(id_caducidad);
        }

        [WebMethod]

        public void eliminarCaducarMedicamentoService(String id_caducidad)
        {
            NegocioCaducarMedicamento auxNegocioCaducarMedicamento = new NegocioCaducarMedicamento();
            auxNegocioCaducarMedicamento.eliminarCaducarMedicamento(id_caducidad);
        }

        [WebMethod]

        public void actualizarCaducarMedicamentoService(CaducarMedicamento caducarmedicamento)
        {
            NegocioCaducarMedicamento auxNegocioCaducarMedicamento = new NegocioCaducarMedicamento();
            auxNegocioCaducarMedicamento.actualizarCaducarMedicamento(caducarmedicamento);
        }
    }
}
    
