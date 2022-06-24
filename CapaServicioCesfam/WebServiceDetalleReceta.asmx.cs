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
    /// Descripción breve de WebServiceDetalleReceta
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceDetalleReceta : System.Web.Services.WebService
    {


        [WebMethod]

        public void insertaDetalleRecetaService(DetalleReceta detalle_receta)
        {
            NegocioDetalleReceta auxNegocioDetalleReceta = new NegocioDetalleReceta();
            auxNegocioDetalleReceta.insertarDetalleReceta(detalle_receta);

        }


        [WebMethod]
        public DataSet retornarDetalleRecetaService(string id_detalle_receta)
        {
            NegocioDetalleReceta auxNegocioDetalleReceta = new NegocioDetalleReceta();
            return auxNegocioDetalleReceta.retornarDetalleReceta(id_detalle_receta);
        }

        [WebMethod]
        public DetalleReceta retornaPosicionDetalleRecetaService(int pos, string id_detalle_receta)
        {
            NegocioDetalleReceta auxNegocioDetalleReceta = new NegocioDetalleReceta();
            return auxNegocioDetalleReceta.retornaPosicionDetalleReceta(pos, id_detalle_receta);
        }

        [WebMethod]

        public DetalleReceta buscarDetalleRecetaService(String id_detalle_receta)
        {
            NegocioDetalleReceta auxNegocioDetalleReceta = new NegocioDetalleReceta();
            return auxNegocioDetalleReceta.buscarDetalleReceta(id_detalle_receta);
        }

        [WebMethod]
        public DetalleReceta buscarIdDetalleRecetaService(String id_detalle_receta)
        {
            NegocioDetalleReceta auxNegocioDetalleReceta = new NegocioDetalleReceta();
            return auxNegocioDetalleReceta.buscarIdDetalleReceta(id_detalle_receta);
        }

        [WebMethod]

        public void eliminarDetalleRecetaService(String id_detalle_receta)
        {
            NegocioDetalleReceta auxNegocioDetalleReceta = new NegocioDetalleReceta();
            auxNegocioDetalleReceta.eliminarDetalleReceta(id_detalle_receta);
        }

        [WebMethod]

        public void actualizarDetalleRecetaService(DetalleReceta detalle_receta)
        {
            NegocioDetalleReceta auxNegocioDetalleReceta = new NegocioDetalleReceta();
            auxNegocioDetalleReceta.actualizarDetalleReceta(detalle_receta);
        }
    }
}
