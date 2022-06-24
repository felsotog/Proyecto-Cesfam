using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaDTOCesfam
{
    public class Farmaceutico
    {
        private String id_farmaceuta;
        private String nombre_farmaceuta;
        private String farmacia_id_farmacia;

        public string Id_farmaceuta { get => id_farmaceuta; set => id_farmaceuta = value; }
        public string Nombre_farmaceuta { get => nombre_farmaceuta; set => nombre_farmaceuta = value; }
        public string Farmacia_id_farmacia { get => farmacia_id_farmacia; set => farmacia_id_farmacia = value; }
    }
}