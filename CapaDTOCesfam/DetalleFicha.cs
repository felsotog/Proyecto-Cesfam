using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTOCesfam
{
    public class DetalleFicha
    {
        String id_detalle_ficha;
        String ficha_paciente_id_ficha;
        String formulario_medicamento_id_formulario;
        String comentarios;

        public string Id_detalle_ficha { get => id_detalle_ficha; set => id_detalle_ficha = value; }
        public string Ficha_paciente_id_ficha { get => ficha_paciente_id_ficha; set => ficha_paciente_id_ficha = value; }
        public string Formulario_medicamento_id_formulario { get => formulario_medicamento_id_formulario; set => formulario_medicamento_id_formulario = value; }
        public string Comentarios { get => comentarios; set => comentarios = value; }
    }
}