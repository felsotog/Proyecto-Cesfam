using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTOCesfam
{
   public class CaducarMedicamento
    {

        String id_caducidad;
        DateTime fecha_caducidad;

        public string Id_caducidad { get => id_caducidad; set => id_caducidad = value; }
        public DateTime Fecha_caducidad { get => fecha_caducidad; set => fecha_caducidad = value; }
    }
}
