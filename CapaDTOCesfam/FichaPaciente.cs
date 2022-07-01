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
        DateTime fecha_ficha;
        String medico_rut_medico;
        String paciente_rut;

        public string Id_ficha { get => id_ficha; set => id_ficha = value; }
        public DateTime Fecha_ficha { get => fecha_ficha; set => fecha_ficha = value; }
        public string Medico_rut_medico { get => medico_rut_medico; set => medico_rut_medico = value; }
        public string Paciente_rut { get => paciente_rut; set => paciente_rut = value; }
    }
}
