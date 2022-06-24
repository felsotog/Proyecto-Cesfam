using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTOCesfam
{
    public class Agendamiento
    {
        String id_agendamiento;
        DateTime horario;
        String paciente_rut;
        String medico_rut_medico;

        public string Id_agendamiento { get => id_agendamiento; set => id_agendamiento = value; }
        public DateTime Horario { get => horario; set => horario = value; }
        public string Paciente_rut { get => paciente_rut; set => paciente_rut = value; }
        public string Medico_rut_medico { get => medico_rut_medico; set => medico_rut_medico = value; }
    }
}
