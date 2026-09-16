using CapaConexion;
using CapaDTOCesfam;
using System;
using System.Data;

namespace CapaNegocioCesfam
{
    public class NegocioFarmacia : NegocioBase
    {
        private const string Tabla = "Farmacia";
        private ConexionCesfam conec1;

        public ConexionCesfam Conec1 { get { return conec1; } set { conec1 = value; } }

        public void configurarConexion()
        {
            conec1 = CrearConexion(Tabla);
        }

        public void insertarFarmacia(Farmacia farmacia)
        {
            Validar(farmacia);
            configurarConexion();
            conec1.EjecutarComando(
                "INSERT INTO Farmacia (id_farmacia, nombre_farmacia) VALUES (@id, @nombre)",
                Texto("@id", farmacia.Id_farmacia, 20),
                Texto("@nombre", farmacia.Nombre_farmacia, 120));
        }

        public DataSet retornarFarmacia(string id_farmacia)
        {
            Requerido(id_farmacia, "id_farmacia");
            configurarConexion();
            return conec1.EjecutarConsulta(
                Tabla,
                "SELECT id_farmacia, nombre_farmacia FROM Farmacia WHERE id_farmacia = @id",
                Texto("@id", id_farmacia, 20));
        }

        public Farmacia retornaPosicionFarmacia(int pos, string id_farmacia)
        {
            return Mapear(ObtenerTabla(retornarFarmacia(id_farmacia), Tabla), pos);
        }

        public Farmacia buscarFarmacia(string id_farmacia)
        {
            return Mapear(ObtenerTabla(retornarFarmacia(id_farmacia), Tabla), 0);
        }

        public void eliminarFarmacia(string id_farmacia)
        {
            Requerido(id_farmacia, "id_farmacia");
            configurarConexion();
            conec1.EjecutarComando(
                "DELETE FROM Farmacia WHERE id_farmacia = @id",
                Texto("@id", id_farmacia, 20));
        }

        public void actualizarFarmacia(Farmacia farmacia)
        {
            Validar(farmacia);
            configurarConexion();
            conec1.EjecutarComando(
                "UPDATE Farmacia SET nombre_farmacia = @nombre WHERE id_farmacia = @id",
                Texto("@nombre", farmacia.Nombre_farmacia, 120),
                Texto("@id", farmacia.Id_farmacia, 20));
        }

        public Farmacia buscarIdFarmacia(string id_farmacia)
        {
            return buscarFarmacia(id_farmacia);
        }

        public Farmacia buscar_Farmacia(string id_farmacia)
        {
            return buscarFarmacia(id_farmacia);
        }

        public DataSet retornarTotalFarmacias()
        {
            configurarConexion();
            return conec1.EjecutarConsulta(
                Tabla,
                "SELECT id_farmacia, nombre_farmacia FROM Farmacia ORDER BY nombre_farmacia");
        }

        private static void Validar(Farmacia farmacia)
        {
            if (farmacia == null) throw new ArgumentNullException("farmacia");
            Requerido(farmacia.Id_farmacia, "id_farmacia");
            Requerido(farmacia.Nombre_farmacia, "nombre_farmacia");
        }

        private static Farmacia Mapear(DataTable tabla, int posicion)
        {
            if (!PosicionValida(tabla, posicion)) return new Farmacia();
            DataRow fila = tabla.Rows[posicion];
            return new Farmacia
            {
                Id_farmacia = Convert.ToString(fila["id_farmacia"]),
                Nombre_farmacia = Convert.ToString(fila["nombre_farmacia"])
            };
        }
    }
}
