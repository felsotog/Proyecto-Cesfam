using CapaConexion;
using CapaDTOCesfam;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaNegocioCesfam
{
    public class NegocioCiudad : NegocioBase
    {
        private const string Tabla = "ciudad";
        private ConexionCesfam conec1;

        public ConexionCesfam Conec1 { get { return conec1; } set { conec1 = value; } }

        public void configurarConexion()
        {
            conec1 = CrearConexion(Tabla);
        }

        public void insertarCiudad(Ciudad ciudad)
        {
            if (ciudad == null) throw new ArgumentNullException("ciudad");
            Requerido(ciudad.Id_ciudad, "id_ciudad");
            Requerido(ciudad.Nombre_ciudad, "nombre_ciudad");
            configurarConexion();
            conec1.EjecutarComando(
                "INSERT INTO ciudad (id_ciudad, nombre_ciudad) VALUES (@id, @nombre)",
                Texto("@id", ciudad.Id_ciudad, 20),
                Texto("@nombre", ciudad.Nombre_ciudad, 100));
        }

        public DataSet retornarciudad(string id_ciudad)
        {
            Requerido(id_ciudad, "id_ciudad");
            configurarConexion();
            return conec1.EjecutarConsulta(
                Tabla,
                "SELECT id_ciudad, nombre_ciudad FROM ciudad WHERE id_ciudad = @id",
                Texto("@id", id_ciudad, 20));
        }

        public Ciudad retornaPosicionCiudad(int pos, string id_ciudad)
        {
            return Mapear(ObtenerTabla(retornarciudad(id_ciudad), Tabla), pos);
        }

        public Ciudad buscarCiudad(string id_ciudad)
        {
            return Mapear(ObtenerTabla(retornarciudad(id_ciudad), Tabla), 0);
        }

        public void eliminarCiudad(string id_ciudad)
        {
            Requerido(id_ciudad, "id_ciudad");
            configurarConexion();
            conec1.EjecutarComando(
                "DELETE FROM ciudad WHERE id_ciudad = @id",
                Texto("@id", id_ciudad, 20));
        }

        public void actualizarCiudad(Ciudad ciudad)
        {
            if (ciudad == null) throw new ArgumentNullException("ciudad");
            Requerido(ciudad.Id_ciudad, "id_ciudad");
            Requerido(ciudad.Nombre_ciudad, "nombre_ciudad");
            configurarConexion();
            conec1.EjecutarComando(
                "UPDATE ciudad SET nombre_ciudad = @nombre WHERE id_ciudad = @id",
                Texto("@nombre", ciudad.Nombre_ciudad, 100),
                Texto("@id", ciudad.Id_ciudad, 20));
        }

        public DataSet buscarIdciudad(string id_ciudad)
        {
            return retornarciudad(id_ciudad);
        }

        public Ciudad buscarIdCiudad(string id_ciudad)
        {
            return buscarCiudad(id_ciudad);
        }

        public DataSet retornarTotalCiudades()
        {
            configurarConexion();
            return conec1.EjecutarConsulta(
                Tabla,
                "SELECT id_ciudad, nombre_ciudad FROM ciudad ORDER BY nombre_ciudad");
        }

        private static Ciudad Mapear(DataTable tabla, int posicion)
        {
            if (!PosicionValida(tabla, posicion)) return new Ciudad();
            DataRow fila = tabla.Rows[posicion];
            return new Ciudad
            {
                Id_ciudad = Convert.ToString(fila["id_ciudad"]),
                Nombre_ciudad = Convert.ToString(fila["nombre_ciudad"])
            };
        }
    }
}
