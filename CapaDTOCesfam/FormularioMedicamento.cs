using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTOCesfam
{
    public class FormularioMedicamento
    {
        String id_formulario;
        DateTime fecha_receta;
        String medico_rut_medico;

        public string Id_formulario { get => id_formulario; set => id_formulario = value; }
        public DateTime Fecha_receta { get => fecha_receta; set => fecha_receta = value; }
        public string Medico_rut_medico { get => medico_rut_medico; set => medico_rut_medico = value; }
    }
}
