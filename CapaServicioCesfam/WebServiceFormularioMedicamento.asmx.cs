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
    /// Descripción breve de WebServiceFormularioMedicamento
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceFormularioMedicamento : System.Web.Services.WebService
    {

        [WebMethod]

        public void insertaFormularioMedicamentoService(FormularioMedicamento formulariomedicamento)
        {
            NegocioFormularioMedicamento auxNegocioFormularioMedicamento = new NegocioFormularioMedicamento();
            auxNegocioFormularioMedicamento.insertarFormularioMedicamento(formulariomedicamento);

        }


        [WebMethod]
        public DataSet retornarFormularioMedicamentoService(string id_formulario)
        {
            NegocioFormularioMedicamento auxNegocioFormularioMedicamento = new NegocioFormularioMedicamento();
            return auxNegocioFormularioMedicamento.retornarFormularioMedicamento(id_formulario);
        }

        [WebMethod]
        public FormularioMedicamento retornaPosicionFormularioMedicamentoService(int pos, string id_formulario)
        {
            NegocioFormularioMedicamento auxNegocioFormularioMedicamento = new NegocioFormularioMedicamento();
            return auxNegocioFormularioMedicamento.retornaPosicionFormularioMedicamento(pos, id_formulario);
        }

        [WebMethod]

        public FormularioMedicamento buscarFormularioMedicamentoService(String id_formulario)
        {
            NegocioFormularioMedicamento auxNegocioFormularioMedicamento = new NegocioFormularioMedicamento();
            return auxNegocioFormularioMedicamento.buscarFormularioMedicamento(id_formulario);
        }

        [WebMethod]
        public FormularioMedicamento buscarIdFormularioMedicamentoService(String id_formulario)
        {
            NegocioFormularioMedicamento auxNegocioFormularioMedicamento = new NegocioFormularioMedicamento();
            return auxNegocioFormularioMedicamento.buscarIdFormularioMedicamento(id_formulario);
        }

        [WebMethod]

        public void eliminarFormularioMedicamentoService(String id_formulario)
        {
            NegocioFormularioMedicamento auxNegocioFormularioMedicamento = new NegocioFormularioMedicamento();
            auxNegocioFormularioMedicamento.eliminarFormularioMedicamento(id_formulario);
        }

        [WebMethod]

        public void actualizarFormularioMedicamentoService(FormularioMedicamento formulariomedicamento)
        {
            NegocioFormularioMedicamento auxNegocioFormularioMedicamento = new NegocioFormularioMedicamento();
            auxNegocioFormularioMedicamento.actualizarFormularioMedicamento(formulariomedicamento);
        }
    }
}
