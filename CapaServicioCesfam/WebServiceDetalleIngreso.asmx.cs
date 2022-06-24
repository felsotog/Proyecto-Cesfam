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
    /// Descripción breve de WebService1DetalleIngreso
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1DetalleIngreso : System.Web.Services.WebService
    {
        [WebMethod]

        public void insertaDetalleIngresoService(DetalleIngreso detalleingreso,String id_detalle_ingreso,String codigo)
        {
            int stock_medicamento;
            int cantidad_ingreso;
            
            NegocioMedicamento auxNegocioMedicamento = new NegocioMedicamento();
            Medicamento auxMedicamento = auxNegocioMedicamento.buscarIdMedicamento(codigo);
            stock_medicamento = auxMedicamento.Cantidad;
            NegocioDetalleIngreso auxNegocioDetalleIngreso = new NegocioDetalleIngreso();
            auxNegocioDetalleIngreso.insertarDetalleIngreso(detalleingreso);
            DetalleIngreso auxDetalleIngreso = auxNegocioDetalleIngreso.buscarIdDetalleIngreso(id_detalle_ingreso);
            cantidad_ingreso = auxDetalleIngreso.Cantidad;
            auxMedicamento.Codigo = codigo;
            auxMedicamento.Cantidad = stock_medicamento + cantidad_ingreso;
            auxNegocioMedicamento.actualizarMedicamento(auxMedicamento);

        }


        [WebMethod]
        public DataSet retornarDetalleIngresoService(string id_detalleingr)
        {
            NegocioDetalleIngreso auxNegocioDetalleIngreso = new NegocioDetalleIngreso();
            return auxNegocioDetalleIngreso.retornarDetalleIngreso(id_detalleingr);
        }

        [WebMethod]
        public DetalleIngreso retornaPosicionDetalleIngresoService(int pos, string id_detalleingr)
        {
            NegocioDetalleIngreso auxNegocioDetalleIngreso = new NegocioDetalleIngreso();
            return auxNegocioDetalleIngreso.retornaPosicionDetalleIngreso(pos, id_detalleingr);
        }

        [WebMethod]

        public DetalleIngreso buscarDetalleIngresoService(String id_detalleingr)
        {
            NegocioDetalleIngreso auxNegocioDetalleIngreso = new NegocioDetalleIngreso();
            return auxNegocioDetalleIngreso.buscarDetalleIngreso(id_detalleingr);
        }

        [WebMethod]
        public DetalleIngreso buscarIdDetalleIngresoService(String id_detalleingr)
        {
            NegocioDetalleIngreso auxNegocioDetalleIngreso = new NegocioDetalleIngreso();
            return auxNegocioDetalleIngreso.buscarIdDetalleIngreso(id_detalleingr);
        }

        [WebMethod]

        public void eliminarDetalleIngresoService(String id_detalleingr)
        {
            NegocioDetalleIngreso auxNegocioDetalleIngreso = new NegocioDetalleIngreso();
            auxNegocioDetalleIngreso.eliminarDetalleIngreso(id_detalleingr);
        }

        [WebMethod]

        public void actualizarDetalleIngresoService(DetalleIngreso detalleingreso)
        {
            NegocioDetalleIngreso auxNegocioDetalleIngreso = new NegocioDetalleIngreso();
            auxNegocioDetalleIngreso.actualizarDetalleIngreso(detalleingreso);
        }
    }
}
