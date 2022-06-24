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
    /// Descripción breve de WebServiceDetalleSalida
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceDetalleSalida : System.Web.Services.WebService
    {

        [WebMethod]

        public void insertaDetalleSalidaService(DetalleSalida detalle_salida)
        {
            NegocioDetalleSalida auxnegocioDetalleSalida = new NegocioDetalleSalida();
            auxnegocioDetalleSalida.insertarDetalleSalida(detalle_salida);

        }


        [WebMethod]
        public DataSet retornarDetalleSalidaService(string id_detalle_salida)
        {
            NegocioDetalleSalida auxNegocioDetalleSalida = new NegocioDetalleSalida();
            return auxNegocioDetalleSalida.retornarDetalleSalida(id_detalle_salida);
        }

        [WebMethod]
        public DetalleSalida retornaPosicionDetalleSalidaService(int pos, string id_detalle_salida)
        {
            NegocioDetalleSalida auxNegocioDetalleSalida = new NegocioDetalleSalida();
            return auxNegocioDetalleSalida.retornaPosicionDetalleSalida(pos, id_detalle_salida);
        }

        [WebMethod]

        public DetalleSalida buscarDetalleSalidaService(String id_detalle_salida)
        {
            NegocioDetalleSalida auxNegocioDetalleSalida = new NegocioDetalleSalida();
            return auxNegocioDetalleSalida.buscarDetalleSalida(id_detalle_salida);
        }

        [WebMethod]
        public DetalleSalida buscarIdDetalleSalidaService(String id_detalle_salida)
        {
            NegocioDetalleSalida auxNegocioDetalleSalida = new NegocioDetalleSalida();
            return auxNegocioDetalleSalida.buscarIdDetalleSalida(id_detalle_salida);
        }

        [WebMethod]

        public void eliminarDetalleSalidaService(String id_detalle_salida)
        {
            NegocioDetalleSalida auxNegocioDetalleSalida = new NegocioDetalleSalida();
            auxNegocioDetalleSalida.eliminarDetalleSalida(id_detalle_salida);
        }

        [WebMethod]

        public void actualizarDetalleSalidaService(DetalleSalida detalle_salida)
        {
            NegocioDetalleSalida auxNegocioDetalleSalida = new NegocioDetalleSalida();
            auxNegocioDetalleSalida.actualizarDetalleSalida(detalle_salida);
        }
    }
}
