using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTOCesfam
{
    public class ReservaMedicamento
    {
        String id_reserva;
        DateTime fecha_reserva;
        int cantidad_reserva;
        String farmaceutico_id_farmaceuta;
        String medicamento_codigo;

        public string Id_reserva { get => id_reserva; set => id_reserva = value; }
        public DateTime Fecha_reserva { get => fecha_reserva; set => fecha_reserva = value; }
        public int Cantidad_reserva { get => cantidad_reserva; set => cantidad_reserva = value; }
        public string Farmaceutico_id_farmaceuta { get => farmaceutico_id_farmaceuta; set => farmaceutico_id_farmaceuta = value; }
        public string Medicamento_codigo { get => medicamento_codigo; set => medicamento_codigo = value; }
    }
}
