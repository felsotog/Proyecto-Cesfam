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
    /// Descripción breve de WebServiceMedico
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceMedico : System.Web.Services.WebService
    {


        [WebMethod]

        public void insertaMedicoService(Medico auxMedico)
        {
            NegocioMedico auxNegocioMedico = new NegocioMedico();
            auxNegocioMedico.insertarMedico(auxMedico);

        }


        [WebMethod]
        public DataSet retornarMedicamentoService(string rut_medico)
        {
            NegocioMedico auxNegocioMedico = new NegocioMedico();
            return auxNegocioMedico.retornarMedico(rut_medico);
        }

        [WebMethod]
        public Medico retornaPosicionMedicoService(int pos, string rut_medico)
        {
            NegocioMedico auxNegocioMedico = new NegocioMedico();
            return auxNegocioMedico.retornaPosicionMedico(pos, rut_medico);
        }

        [WebMethod]

        public Medico buscarMedicoService(String rut_medico)
        {
            NegocioMedico auxNegocioMedico = new NegocioMedico();
            return auxNegocioMedico.buscarMedico(rut_medico);
        }

        [WebMethod]
        public Medico buscarIdMedicoService(String rut_medico)
        {
            NegocioMedico auxNegocioMedico = new NegocioMedico();
            return auxNegocioMedico.buscarIdMedico(rut_medico);
        }

        [WebMethod]

        public void eliminarMedicoService(String rut_medico)
        {
            NegocioMedico auxNegocioMedico = new NegocioMedico();
            auxNegocioMedico.eliminarMedico(rut_medico);
        }

        [WebMethod]

        public void actualizarMedicoService(Medico medico)
        {
            NegocioMedico auxNegocioMedico = new NegocioMedico();
            auxNegocioMedico.actualizarMedico(medico);
        }
    }
}
