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
    /// Summary description for WebServiceFarmaceutico
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceFarmaceutico : System.Web.Services.WebService
    {


        [WebMethod]

        public void insertaFarmaceuticoService(Farmaceutico auxFarmaceutico)
        {
            NegocioFarmaceutico auxnegocioFarmaceutico = new NegocioFarmaceutico();
            auxnegocioFarmaceutico.insertarFarmaceuta(auxFarmaceutico);

        }


        [WebMethod]
        public DataSet retornarFarmaceuticoService(string id_ciudad)
        {
            NegocioFarmaceutico auxNegocioFarmaceutico = new NegocioFarmaceutico();
            return auxNegocioFarmaceutico.retornarFarmaceuta(id_ciudad);
        }

        [WebMethod]
        public Farmaceutico retornaPosicionFarmaceuticoService(int pos, string id_ciudad)
        {
            NegocioFarmaceutico auxNegocioFarmaceutico = new NegocioFarmaceutico();
            return auxNegocioFarmaceutico.retornaPosicionFarmaceuta(pos, id_ciudad);
        }

        [WebMethod]

        public Farmaceutico buscarFarmaceuticoService(String id_ciudad)
        {
            NegocioFarmaceutico auxNegocioFarmaceutico = new NegocioFarmaceutico();
            return auxNegocioFarmaceutico.buscarFarmaceuta(id_ciudad);
        }

        [WebMethod]
        public Farmaceutico buscarIdFarmaceuticoService(String id_ciudad)
        {
            NegocioFarmaceutico auxNegocioFarmaceutico = new NegocioFarmaceutico();
            return auxNegocioFarmaceutico.buscarIdFarmaceutico(id_ciudad);
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

        [WebMethod]
        public DataSet retornarTotalFarmaceutasService()
        {
            NegocioFarmaceutico auxNegocioFarmaceutico = new NegocioFarmaceutico();
            return auxNegocioFarmaceutico.retornarTotalFarmaceutas();
        }
    }
}
