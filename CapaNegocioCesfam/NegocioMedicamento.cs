using CapaConexion;
using CapaDTOCesfam;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaNegocioCesfam
{
    public class NegocioMedicamento : NegocioBase
    {
        private const string Tabla = "medicamento";
        private ConexionCesfam conec1;

        public ConexionCesfam Conec1 { get { return conec1; } set { conec1 = value; } }

        public void configurarConexion()
        {
            conec1 = CrearConexion(Tabla);
        }

        public void insertarMedicamento(Medicamento medicamento)
        {
            Validar(medicamento);
            configurarConexion();
            conec1.EjecutarComando(
                "INSERT INTO medicamento " +
                "(codigo, nombre_medicamento, tipo_medicamento, fecha_fabricacion, fecha_vencimiento, descripcion, cantidad, farmacia_id_farmacia) " +
                "VALUES (@id, @nombre, @tipo, @fabricacion, @vencimiento, @descripcion, @cantidad, @farmacia)",
                CrearParametros(medicamento));
        }

        public DataSet retornarMedicamento(string codigo)
        {
            Requerido(codigo, "codigo");
            configurarConexion();
            return conec1.EjecutarConsulta(
                Tabla,
                "SELECT codigo, nombre_medicamento, tipo_medicamento, fecha_fabricacion, " +
                "fecha_vencimiento, descripcion, cantidad, farmacia_id_farmacia FROM medicamento WHERE codigo = @id",
                Texto("@id", codigo, 20));
        }

        public Medicamento retornaPosicionMedicamento(int pos, string codigo)
        {
            return Mapear(ObtenerTabla(retornarMedicamento(codigo), Tabla), pos);
        }

        public Medicamento buscarMedicamento(string codigo)
        {
            return Mapear(ObtenerTabla(retornarMedicamento(codigo), Tabla), 0);
        }

        public void eliminarMedicamento(string codigo)
        {
            Requerido(codigo, "codigo");
            configurarConexion();
            conec1.EjecutarComando(
                "DELETE FROM medicamento WHERE codigo = @id",
                Texto("@id", codigo, 20));
        }

        public void actualizarMedicamento(Medicamento medicamento)
        {
            Validar(medicamento);
            configurarConexion();
            conec1.EjecutarComando(
                "UPDATE medicamento SET nombre_medicamento = @nombre, tipo_medicamento = @tipo, " +
                "fecha_fabricacion = @fabricacion, fecha_vencimiento = @vencimiento, " +
                "descripcion = @descripcion, cantidad = @cantidad, farmacia_id_farmacia = @farmacia WHERE codigo = @id",
                CrearParametros(medicamento));
        }

        public Medicamento buscarIdMedicamento(string codigo)
        {
            return buscarMedicamento(codigo);
        }

        public Medicamento buscarId_Medicamento(string codigo)
        {
            return buscarMedicamento(codigo);
        }

        public DataSet retornarTotalMedicamentos()
        {
            configurarConexion();
            return conec1.EjecutarConsulta(
                Tabla,
                "SELECT codigo, nombre_medicamento, tipo_medicamento, fecha_fabricacion, " +
                "fecha_vencimiento, descripcion, cantidad, farmacia_id_farmacia FROM medicamento ORDER BY nombre_medicamento");
        }

        private static SqlParameter[] CrearParametros(Medicamento medicamento)
        {
            return new[]
            {
                Texto("@id", medicamento.Codigo, 20),
                Texto("@nombre", medicamento.Nombre_medicamento, 150),
                Texto("@tipo", medicamento.Tipo_medicamento, 80),
                new SqlParameter("@fabricacion", SqlDbType.DateTime) { Value = medicamento.Fecha_fabricacion },
                new SqlParameter("@vencimiento", SqlDbType.DateTime) { Value = medicamento.Fecha_vencimiento },
                Texto("@descripcion", medicamento.Descripcion, 500),
                new SqlParameter("@cantidad", SqlDbType.Int) { Value = medicamento.Cantidad },
                Texto("@farmacia", medicamento.Farmacia_id_farmacia, 20)
            };
        }

        private static void Validar(Medicamento medicamento)
        {
            if (medicamento == null) throw new ArgumentNullException("medicamento");
            Requerido(medicamento.Codigo, "codigo");
            Requerido(medicamento.Nombre_medicamento, "nombre_medicamento");
            Requerido(medicamento.Tipo_medicamento, "tipo_medicamento");
            Requerido(medicamento.Farmacia_id_farmacia, "farmacia_id_farmacia");
            if (medicamento.Cantidad < 0) throw new ArgumentOutOfRangeException("cantidad", "La cantidad no puede ser negativa.");
            if (medicamento.Fecha_vencimiento < medicamento.Fecha_fabricacion)
            {
                throw new ArgumentException("La fecha de vencimiento no puede ser anterior a la fecha de fabricación.");
            }
        }

        private static Medicamento Mapear(DataTable tabla, int posicion)
        {
            if (!PosicionValida(tabla, posicion)) return new Medicamento();
            DataRow fila = tabla.Rows[posicion];
            return new Medicamento
            {
                Codigo = Convert.ToString(fila["codigo"]),
                Nombre_medicamento = Convert.ToString(fila["nombre_medicamento"]),
                Tipo_medicamento = Convert.ToString(fila["tipo_medicamento"]),
                Fecha_fabricacion = Convert.ToDateTime(fila["fecha_fabricacion"]),
                Fecha_vencimiento = Convert.ToDateTime(fila["fecha_vencimiento"]),
                Descripcion = Convert.ToString(fila["descripcion"]),
                Cantidad = Convert.ToInt32(fila["cantidad"]),
                Farmacia_id_farmacia = Convert.ToString(fila["farmacia_id_farmacia"])
            };
        }
    }
}
