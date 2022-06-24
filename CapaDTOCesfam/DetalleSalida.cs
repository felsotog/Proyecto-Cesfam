using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTOCesfam
{
   public class DetalleSalida
    {
        String id_detalleSalida;
        int cantidad;
        String medicamento_codigo;
        String salida_medicamento_id_salida;

        public string Id_detalleSalida { get => id_detalleSalida; set => id_detalleSalida = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public string Medicamento_codigo { get => medicamento_codigo; set => medicamento_codigo = value; }
        public string Salida_medicamento_id_salida { get => salida_medicamento_id_salida; set => salida_medicamento_id_salida = value; }
    }
}
