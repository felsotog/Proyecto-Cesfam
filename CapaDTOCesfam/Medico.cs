using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTOCesfam
{
    public class Medico
    {
        String rut_medico;
        String nombre_completo;
        String especialidad;
        String direccion;
        String telefono;
        String email;

        public string Rut_medico { get => rut_medico; set => rut_medico = value; }
        public string Nombre_completo { get => nombre_completo; set => nombre_completo = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
    }
}
