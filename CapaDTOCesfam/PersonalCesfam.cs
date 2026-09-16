using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaDTOCesfam
{
    public class PersonalCesfam
    {
        private String id_personal;
        private String nombre_completo;
        private String rut;
        private String Cargo;
        private int telefono;
        private String correo;

        public string Id_personal { get => id_personal; set => id_personal = value; }
        public string Nombre_completo { get => nombre_completo; set => nombre_completo = value; }
        public string Rut { get => rut; set => rut = value; }
        public string Cargo1 { get => Cargo; set => Cargo = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
    }
}