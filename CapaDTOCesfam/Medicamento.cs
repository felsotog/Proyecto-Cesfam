using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaDTOCesfam
{
    public class Medicamento
    {
         String codigo;
         String nombre_medicamento;
         String tipo_medicamento;
         DateTime fecha_fabricacion;
         DateTime fecha_vencimiento;
         String descripcion;
         int cantidad;
         string farmacia_id_farmacia;

        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre_medicamento { get => nombre_medicamento; set => nombre_medicamento = value; }
        public string Tipo_medicamento { get => tipo_medicamento; set => tipo_medicamento = value; }
        public DateTime Fecha_fabricacion { get => fecha_fabricacion; set => fecha_fabricacion = value; }
        public DateTime Fecha_vencimiento { get => fecha_vencimiento; set => fecha_vencimiento = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public string Farmacia_id_farmacia { get => farmacia_id_farmacia; set => farmacia_id_farmacia = value; }
    }
}