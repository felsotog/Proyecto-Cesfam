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
    /// Descripción breve de WebService1DetalleCaducidad
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1DetalleCaducidad : System.Web.Services.WebService
    {

        [WebMethod]

        public void insertaDetalleCaducidadService(DetalleCaducidad detallecaducidad)
        {
            NegocioDetalleCaducidad auxnegocioDetalleCaducidad = new NegocioDetalleCaducidad();
            auxnegocioDetalleCaducidad.insertarDetalleCaducidad(detallecaducidad);

        }


        [WebMethod]
        public DataSet retornarDetalleCaducidadService(string id_detalle)
        {
            NegocioDetalleCaducidad auxNegocioDetalleCaducidad = new NegocioDetalleCaducidad();
            return auxNegocioDetalleCaducidad.retornarDetalleCaducidad(id_detalle);
        }

        [WebMethod]
        public DetalleCaducidad retornaPosicionDetalleCaducidadService(int pos, string id_detalle)
        {
            NegocioDetalleCaducidad auxNegocioDetalleCaducidad = new NegocioDetalleCaducidad();
            return auxNegocioDetalleCaducidad.retornaPosicionDetalleCaducidad(pos, id_detalle);
        }

        [WebMethod]

        public DetalleCaducidad buscarDetalleCaducidadService(String id_detalle)
        {
            NegocioDetalleCaducidad auxNegocioDetalleCaducidad = new NegocioDetalleCaducidad();
            return auxNegocioDetalleCaducidad.buscarDetalleCaducidad(id_detalle);
        }

        [WebMethod]
        public DetalleCaducidad buscarIdDetalleCaducidadService(String id_detalle)
        {
            NegocioDetalleCaducidad auxNegocioDetalleCaducidad = new NegocioDetalleCaducidad();
            return auxNegocioDetalleCaducidad.buscarIdDetalleCaducidad(id_detalle);
        }

        [WebMethod]

        public void eliminarDetalleCaducidadService(String id_detalle)
        {
            NegocioDetalleCaducidad auxNegocioDetalleCaducidad = new NegocioDetalleCaducidad();
            auxNegocioDetalleCaducidad.eliminarDetalleCaducidad(id_detalle);
        }

        [WebMethod]

        public void actualizarDetalleCaducidadService(DetalleCaducidad detallecaducidad)
        {
            NegocioDetalleCaducidad auxNegocioDetalleCaducidad = new NegocioDetalleCaducidad();
            auxNegocioDetalleCaducidad.actualizarDetalleCaducidad(detallecaducidad);
        }
    }
}
