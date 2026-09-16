using CapaServicioCesfam;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;

namespace CapaHtml
{
    public partial class WebAjax : Page
    {
        /// <summary>
        /// Entrega los indicadores generales consumidos por las tarjetas del panel AJAX.
        /// </summary>
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static ResumenSistema CargarResumen()
        {
            return new ResumenSistema
            {
                Ciudades = Contar(new WebServiceCiudad().retornarTotalCiudadesService()),
                Farmacias = Contar(new WebServiceFarmacia().retornarTotalFarmaciasService()),
                Medicamentos = Contar(new WebServiceMedicamento().retornarTotalMedicamentosService()),
                Farmaceuticos = Contar(new WebServiceFarmaceutico().retornarTotalFarmaceuticosService()),
                Personal = Contar(new WebServicePersonalCesfam().retornarTotalPersonalService())
            };
        }

        /// <summary>
        /// Proyecta únicamente los datos necesarios para la tabla y evita exponer el DataSet al navegador.
        /// </summary>
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static List<MedicamentoResumen> ListarMedicamentos()
        {
            DataSet resultado = new WebServiceMedicamento().retornarTotalMedicamentosService();
            var medicamentos = new List<MedicamentoResumen>();
            if (resultado == null || resultado.Tables.Count == 0) return medicamentos;

            foreach (DataRow fila in resultado.Tables[0].Rows)
            {
                DateTime vencimiento = Convert.ToDateTime(fila["fecha_vencimiento"], CultureInfo.InvariantCulture);
                medicamentos.Add(new MedicamentoResumen
                {
                    Id = Convert.ToString(fila["codigo"]),
                    Nombre = Convert.ToString(fila["nombre_medicamento"]),
                    Tipo = Convert.ToString(fila["tipo_medicamento"]),
                    Vencimiento = vencimiento.ToString("dd-MM-yyyy", CultureInfo.InvariantCulture),
                    Cantidad = Convert.ToInt32(fila["cantidad"], CultureInfo.InvariantCulture),
                    Estado = ObtenerEstado(vencimiento)
                });
            }

            return medicamentos;
        }

        private static int Contar(DataSet dataSet)
        {
            return dataSet == null || dataSet.Tables.Count == 0
                ? 0
                : dataSet.Tables[0].Rows.Count;
        }

        private static string ObtenerEstado(DateTime vencimiento)
        {
            // El umbral de 30 días permite detectar inventario que requiere revisión próxima.
            DateTime hoy = DateTime.Today;
            if (vencimiento < hoy) return "Vencido";
            if (vencimiento <= hoy.AddDays(30)) return "Por vencer";
            return "Vigente";
        }

        public class ResumenSistema
        {
            public int Ciudades { get; set; }
            public int Farmacias { get; set; }
            public int Medicamentos { get; set; }
            public int Farmaceuticos { get; set; }
            public int Personal { get; set; }
        }

        public class MedicamentoResumen
        {
            public string Id { get; set; }
            public string Nombre { get; set; }
            public string Tipo { get; set; }
            public string Vencimiento { get; set; }
            public int Cantidad { get; set; }
            public string Estado { get; set; }
        }
    }
}
