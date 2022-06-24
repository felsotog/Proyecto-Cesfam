using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTOCesfam
{
   public class Paciente
    {
        String rut;
        String nombre_paciente;
        String sector;
        int telefono;
        String direccion;

        public string Rut { get => rut; set => rut = value; }
        public string Nombre_paciente { get => nombre_paciente; set => nombre_paciente = value; }
        public string Sector { get => sector; set => sector = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
    }
}
