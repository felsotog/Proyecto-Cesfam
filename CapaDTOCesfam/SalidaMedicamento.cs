using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTOCesfam
{
    public class SalidaMedicamento
    {
        String id_salida;
        DateTime fecha_salida;
        String farmaceutico_id_farmaceuta;
        String paciente_rut;

        public string Id_salida { get => id_salida; set => id_salida = value; }
        public DateTime Fecha_salida { get => fecha_salida; set => fecha_salida = value; }
        public string Farmaceutico_id_farmaceuta { get => farmaceutico_id_farmaceuta; set => farmaceutico_id_farmaceuta = value; }
        public string Paciente_rut { get => paciente_rut; set => paciente_rut = value; }
    }
}
