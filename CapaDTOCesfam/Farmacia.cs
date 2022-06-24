using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaDTOCesfam
{
    public class Farmacia
    {
        private String id_farmacia;
        private String nombre_farmacia;

        public string Id_farmacia { get => id_farmacia; set => id_farmacia = value; }
        public string Nombre_farmacia { get => nombre_farmacia; set => nombre_farmacia = value; }
    }
}