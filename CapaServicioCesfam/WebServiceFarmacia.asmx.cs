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
    /// Summary description for WebServiceFarmacia
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceFarmacia : System.Web.Services.WebService
    {

        [WebMethod]

        public void insertaFarmaciaService(Farmacia auxFarmacia)
        {
            NegocioFarmacia auxnegocioFarmacia = new NegocioFarmacia();
            auxnegocioFarmacia.insertarFarmacia(auxFarmacia);

        }


        [WebMethod]
        public DataSet retornarFarmaciaService(string id_farmacia)
        {
            NegocioFarmacia auxNegocioFarmacia = new NegocioFarmacia();
            return auxNegocioFarmacia.retornarFarmacia(id_farmacia);
        }

        [WebMethod]
        public Farmacia retornaPosicionFarmaciaService(int pos, string id_farmacia)
        {
            NegocioFarmacia auxNegocioFarmacia = new NegocioFarmacia();
            return auxNegocioFarmacia.retornaPosicionFarmacia(pos, id_farmacia);
        }

        [WebMethod]

        public Farmacia buscarFarmaciaService(String id_farmacia)
        {
            NegocioFarmacia auxNegocioFarmacia = new NegocioFarmacia();
            return auxNegocioFarmacia.buscarFarmacia(id_farmacia);
        }

        [WebMethod]
        public Farmacia buscarIdFarmaciaService(String id_farmacia)
        {
            NegocioFarmacia auxNegocioFarmacia = new NegocioFarmacia();
            return auxNegocioFarmacia.buscarIdFarmacia(id_farmacia);
        }

        [WebMethod]

        public void eliminarFarmaciaService(String id_farmacia)
        {
            NegocioFarmacia auxNegocioFarmacia = new NegocioFarmacia();
            auxNegocioFarmacia.eliminarFarmacia(id_farmacia);
        }

        [WebMethod]

        public void actualizarCiudadService(Farmacia farmacia)
        {
            NegocioFarmacia auxNegocioFarmacia = new NegocioFarmacia();
            auxNegocioFarmacia.actualizarFarmacia(farmacia);
        }
    }
}
