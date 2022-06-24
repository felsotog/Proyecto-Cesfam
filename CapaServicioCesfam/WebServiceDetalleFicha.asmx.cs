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
    /// Descripción breve de WebService1DetalleFicha
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1DetalleFicha : System.Web.Services.WebService
    {

        [WebMethod]

        public void insertaDetalleFichadService(DetalleFicha detalleficha)
        {
            NegocioDetalleFicha auxnegocioDetalleFicha = new NegocioDetalleFicha();
            auxnegocioDetalleFicha.insertarDetalleFicha(detalleficha);

        }


        [WebMethod]
        public DataSet retornarDetalleFichaService(string id_detalle_ficha)
        {
            NegocioDetalleFicha auxNegocioDetalleFicha = new NegocioDetalleFicha();
            return auxNegocioDetalleFicha.retornarDetalleFicha(id_detalle_ficha);
        }

        [WebMethod]
        public DetalleFicha retornaPosicionDetalleFichaService(int pos, string id_detalle_ficha)
        {
            NegocioDetalleFicha auxNegocioDetalleFicha = new NegocioDetalleFicha();
            return auxNegocioDetalleFicha.retornaPosicionDetalleFicha(pos, id_detalle_ficha);
        }

        [WebMethod]

        public DetalleFicha buscarDetalleFichaService(String id_detalle_ficha)
        {
            NegocioDetalleFicha auxNegocioDetalleFicha = new NegocioDetalleFicha();
            return auxNegocioDetalleFicha.buscarDetalleFicha(id_detalle_ficha);
        }

        [WebMethod]
        public DetalleFicha buscarIdDetalleFichaService(String id_detalle_ficha)
        {
            NegocioDetalleFicha auxNegocioDetalleFicha = new NegocioDetalleFicha();
            return auxNegocioDetalleFicha.buscarIdDetalleFicha(id_detalle_ficha);
        }

        [WebMethod]

        public void eliminarDetalleFichaService(String id_detalle_ficha)
        {
            NegocioDetalleFicha auxNegocioDetalleFicha = new NegocioDetalleFicha();
            auxNegocioDetalleFicha.eliminarDetalleFicha(id_detalle_ficha);
        }

        [WebMethod]

        public void actualizarDetalleFichaService(DetalleFicha detalleficha)
        {
            NegocioDetalleFicha auxNegocioDetalleFicha = new NegocioDetalleFicha();
            auxNegocioDetalleFicha.actualizarDetalleFicha(detalleficha);
        }
    }
}
