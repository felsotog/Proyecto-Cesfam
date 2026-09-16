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
    /// Descripción breve de WebServicePersonalCesfam
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServicePersonalCesfam : System.Web.Services.WebService
    {

        [WebMethod]


        public void insertarPersonalService(PersonalCesfam personal)
        {
            NegocioPersonalCesfam auxnegocioPersonal = new NegocioPersonalCesfam();
            auxnegocioPersonal.insertarPersonal(personal);

        }


        [WebMethod]
        public DataSet retornarPersonalService(string id_personal)
        {
            NegocioPersonalCesfam auxNegocioPersonal = new NegocioPersonalCesfam();
            return auxNegocioPersonal.retornarPersonal(id_personal);
        }

        [WebMethod]
        public PersonalCesfam retornaPosicionPersonalService(int pos, string id_personal)
        {
            NegocioPersonalCesfam auxNegocioPersonal = new NegocioPersonalCesfam();
            return auxNegocioPersonal.retornaPosicionPersonal(pos, id_personal);
        }

        [WebMethod]

        public PersonalCesfam buscarPersonalService(String id_personal)
        {
            NegocioPersonalCesfam auxNegocioPersonal = new NegocioPersonalCesfam();
            return auxNegocioPersonal.buscarPersonal(id_personal);
        }

        [WebMethod]
        public PersonalCesfam buscarIdPersonalService(String id_personal)
        {
            NegocioPersonalCesfam auxNegocioPersonal = new NegocioPersonalCesfam();
            return auxNegocioPersonal.buscarIdPersonal(id_personal);
        }

        [WebMethod]

        public void eliminarPersonalService(String id_personal)
        {
            NegocioPersonalCesfam auxNegocioPersonal = new NegocioPersonalCesfam();
            auxNegocioPersonal.eliminarPersonal(id_personal);
        }

        [WebMethod]

        public void actualizarPersonalService(PersonalCesfam personal)
        {
            NegocioPersonalCesfam auxNegocioPersonal = new NegocioPersonalCesfam();
            auxNegocioPersonal.actualizarPersonal(personal);
        }

        [WebMethod]
        public DataSet retornarTotalPersonalService()
        {
            return new NegocioPersonalCesfam().retornarTotalPersonal();
        }
    }
}
