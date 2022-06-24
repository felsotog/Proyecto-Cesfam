using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTOCesfam
{
    public class FichaPaciente
    {
        String id_ficha;
        String descripcion;
        DateTime fecha_ficha;
        String medico_rut_medico;

        public string Id_ficha { get => id_ficha; set => id_ficha = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public DateTime Fecha_ficha { get => fecha_ficha; set => fecha_ficha = value; }
        public string Medico_rut_medico { get => medico_rut_medico; set => medico_rut_medico = value; }
    }
}
