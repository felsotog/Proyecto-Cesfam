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
    /// Summary description for WebServiceMedicamento
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceMedicamento : System.Web.Services.WebService
    {


        [WebMethod]

        public void insertaMedicamentoService(Medicamento auxMedicamento)
        {
            NegocioMedicamento auxnegocioMedicamento = new NegocioMedicamento();
            auxnegocioMedicamento.insertarMedicamento(auxMedicamento);

        }


        [WebMethod]
        public DataSet retornarMedicamentoService(string id_medicamento)
        {
            NegocioMedicamento auxNegocioMedicamento = new NegocioMedicamento();
            return auxNegocioMedicamento.retornarMedicamento(id_medicamento);
        }

        [WebMethod]
        public Medicamento retornaPosicionMedicamentoService(int pos, string id_medicamento)
        {
            NegocioMedicamento auxNegocioMedicamento = new NegocioMedicamento();
            return auxNegocioMedicamento.retornaPosicionMedicamento(pos, id_medicamento);
        }

        [WebMethod]

        public Medicamento buscarMedicamentoService(String id_medicamento)
        {
            NegocioMedicamento auxNegocioMedicamento = new NegocioMedicamento();
            return auxNegocioMedicamento.buscarMedicamento(id_medicamento);
        }

        [WebMethod]
        public Medicamento buscarIdMedicamentoService(String id_medicamento)
        {
            NegocioMedicamento auxNegocioMedicamento = new NegocioMedicamento();
            return auxNegocioMedicamento.buscarIdMedicamento(id_medicamento);
        }

        [WebMethod]

        public void eliminarMedicamentoService(String id_medicamento)
        {
            NegocioMedicamento auxNegocioMedicamento = new NegocioMedicamento();
            auxNegocioMedicamento.eliminarMedicamento(id_medicamento);
        }

        [WebMethod]

        public void actualizarMedicamentoService(Medicamento medicamento)
        {
            NegocioMedicamento auxNegocioMedicamento = new NegocioMedicamento();
            auxNegocioMedicamento.actualizarMedicamento(medicamento);
        }
    }
}
