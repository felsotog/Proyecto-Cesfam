using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTOCesfam
{
    public class DetalleIngreso
    {
        String id_detalleingr;
        int cantidad;
        DateTime fecha_elaboracion;
        DateTime fecha_vencimiento;
        String medicamento_codico;
        String ingreso_medicamento_id_ingreso;

        public string Id_detalleIngr { get => id_detalleingr; set => id_detalleingr = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public DateTime Fecha_elaboracion { get => fecha_elaboracion; set => fecha_elaboracion = value; }
        public DateTime Fecha_vencimiento { get => fecha_vencimiento; set => fecha_vencimiento = value; }
        public string Medicamento_codico { get => medicamento_codico; set => medicamento_codico = value; }
        public string Ingreso_medicamento_id_ingreso { get => ingreso_medicamento_id_ingreso; set => ingreso_medicamento_id_ingreso = value; }
    }
}
