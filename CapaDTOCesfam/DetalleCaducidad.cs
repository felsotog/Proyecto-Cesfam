using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTOCesfam
{
    public class DetalleCaducidad
    {
        String id_detalle;
        int cantidad_caducada;
        String motivo;
        String medicamento_codigo;
        String caducar_medicamento_id_caducidad;

        public string Id_detalle { get => id_detalle; set => id_detalle = value; }
        public int Cantidad_caducada { get => cantidad_caducada; set => cantidad_caducada = value; }
        public string Motivo { get => motivo; set => motivo = value; }
        public string Medicamento_codigo { get => medicamento_codigo; set => medicamento_codigo = value; }
        public string Caducar_medicamento_id_caducidad { get => caducar_medicamento_id_caducidad; set => caducar_medicamento_id_caducidad = value; }
    }
}
