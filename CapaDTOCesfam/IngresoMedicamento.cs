using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTOCesfam
{
    public class IngresoMedicamento
    {
        string id_ingreso;
        DateTime fecha_ingreso;
        String farmaceutico_id_farmaceuta;

        public string Id_ingreso { get => id_ingreso; set => id_ingreso = value; }
        public DateTime Fecha_ingreso { get => fecha_ingreso; set => fecha_ingreso = value; }
        public string Farmaceutico_id_farmaceuta { get => farmaceutico_id_farmaceuta; set => farmaceutico_id_farmaceuta = value; }
    }
}
