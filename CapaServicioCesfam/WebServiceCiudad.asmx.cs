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
    /// Descripción breve de WebServiceCiudad
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceCiudad : System.Web.Services.WebService
    {

        [WebMethod]

        public void insertarCiudadService(Ciudad auxCiudad)
        {
            NegocioCiudad auxnegociociudad = new NegocioCiudad();
            auxnegociociudad.insertarCiudad(auxCiudad);

        }


        [WebMethod]
        public DataSet retornarCiudadService(string id_ciudad)
        {
            NegocioCiudad auxNegociociudad = new NegocioCiudad();
            return auxNegociociudad.retornarciudad(id_ciudad);
        }

        [WebMethod]
        public Ciudad retornaPosicionCiudadService(int pos, string id_ciudad)
        {
            NegocioCiudad auxNegocioCiudad = new NegocioCiudad();
            return auxNegocioCiudad.retornaPosicionCiudad(pos, id_ciudad);
        }

        [WebMethod]

        public Ciudad buscarCiudadService(String id_ciudad)
        {
            NegocioCiudad auxNegocioCiudad = new NegocioCiudad();
            return auxNegocioCiudad.buscarCiudad(id_ciudad);
        }

        [WebMethod]
        public Ciudad buscarIdCiudadService(String id_ciudad)
        {
            NegocioCiudad auxNegocioCiudad = new NegocioCiudad();
            return auxNegocioCiudad.buscarIdCiudad(id_ciudad);
        }

        [WebMethod]

        public void eliminarCiudadService(String id_ciudad)
        {
            NegocioCiudad auxNegocioCiudad = new NegocioCiudad();
            auxNegocioCiudad.eliminarCiudad(id_ciudad);
        }

        [WebMethod]

        public void actualizarCiudadService(Ciudad ciudad)
        {
            NegocioCiudad auxNegocioCiudad = new NegocioCiudad();
            auxNegocioCiudad.actualizarCiudad(ciudad);
        }

        [WebMethod]
        public DataSet retornarTotalCiudadesService()
        {
            return new NegocioCiudad().retornarTotalCiudades();
        }
    }
}
