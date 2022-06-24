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
    /// Descripción breve de WebService1IngresoMedicamento
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1IngresoMedicamento : System.Web.Services.WebService
    {

        [WebMethod]

        public void insertaIngresoMedicamentoService(IngresoMedicamento ingresomedicamento)
        {
            NegocioIngresoMedicamento auxnegocioIngresoMedicamento = new NegocioIngresoMedicamento();
            auxnegocioIngresoMedicamento.insertarIngresoMedicamento(ingresomedicamento);

        }


        [WebMethod]
        public DataSet retornarIngresoMedicamentoervice(string id_ingreso)
        {
            NegocioIngresoMedicamento auxNegocioIngresoMedicamento = new NegocioIngresoMedicamento();
            return auxNegocioIngresoMedicamento.retornarIngresoMedicamento(id_ingreso);
        }

        [WebMethod]
        public IngresoMedicamento retornaPosicionIngresoMedicamentoService(int pos, string id_ingreso)
        {
            NegocioIngresoMedicamento auxNegocioIngresoMedicamento = new NegocioIngresoMedicamento();
            return auxNegocioIngresoMedicamento.retornaPosicionIngresoMedicamento(pos, id_ingreso);
        }

        [WebMethod]

        public IngresoMedicamento buscarIngresoMedicamentoService(String id_ingreso)
        {
            NegocioIngresoMedicamento auxNegocioIngresoMedicamento = new NegocioIngresoMedicamento();
            return auxNegocioIngresoMedicamento.buscarIngresoMedicamento(id_ingreso);
        }

        [WebMethod]
        public IngresoMedicamento buscarIdIngresoMedicamentoService(String id_ingreso)
        {
            NegocioIngresoMedicamento auxNegocioIngresoMedicamento = new NegocioIngresoMedicamento();
            return auxNegocioIngresoMedicamento.buscarIdIngresoMedicamento(id_ingreso);
        }

        [WebMethod]

        public void eliminarIngresoMedicamentoService(String id_ingreso)
        {
            NegocioIngresoMedicamento auxNegocioIngresoMedicamento = new NegocioIngresoMedicamento();
            auxNegocioIngresoMedicamento.eliminarIngresoMedicamento(id_ingreso);
        }

        [WebMethod]

        public void actualizarIngresoMedicamentoService(IngresoMedicamento ingresomedicamento)
        {
            NegocioIngresoMedicamento auxNegocioIngresoMedicamento = new NegocioIngresoMedicamento();
            auxNegocioIngresoMedicamento.actualizarIngresoMedicamento(ingresomedicamento);
        }
    }
}
