using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTOCesfam
{
   public class DetalleReceta
    {
        String id_detalle_receta;
        int cantidad;
        String paciente_rut;
        String formulario_medicamento_id_formulario;
        String medicamento_codigo;

        public string Id_detalle_receta { get => id_detalle_receta; set => id_detalle_receta = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public string Paciente_rut { get => paciente_rut; set => paciente_rut = value; }
        public string Formulario_medicamento_id_formulario { get => formulario_medicamento_id_formulario; set => formulario_medicamento_id_formulario = value; }
        public string Medicamento_codigo { get => medicamento_codigo; set => medicamento_codigo = value; }
    }
}
