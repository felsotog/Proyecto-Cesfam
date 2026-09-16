using CapaConexion;
using CapaDTOCesfam;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaNegocioCesfam
{
    public class NegocioPersonalCesfam : NegocioBase
    {
        private const string Tabla = "personal_cesfam";
        private ConexionCesfam conec1;

        public ConexionCesfam Conec1 { get { return conec1; } set { conec1 = value; } }

        public void configurarConexion()
        {
            conec1 = CrearConexion(Tabla);
        }

        public void insertarPersonal(PersonalCesfam personal)
        {
            Validar(personal);
            configurarConexion();
            conec1.EjecutarComando(
                "INSERT INTO personal_cesfam (id_personal, nombre_completo, rut, cargo, telefono, correo) " +
                "VALUES (@id, @nombre, @rut, @cargo, @telefono, @correo)",
                CrearParametros(personal));
        }

        public DataSet retornarPersonal(string id_personal)
        {
            Requerido(id_personal, "id_personal");
            configurarConexion();
            return conec1.EjecutarConsulta(
                Tabla,
                "SELECT id_personal, nombre_completo, rut, cargo, telefono, correo " +
                "FROM personal_cesfam WHERE id_personal = @id",
                Texto("@id", id_personal, 20));
        }

        public PersonalCesfam retornaPosicionPersonal(int pos, string id_personal)
        {
            return Mapear(ObtenerTabla(retornarPersonal(id_personal), Tabla), pos);
        }

        public PersonalCesfam buscarPersonal(string id_personal)
        {
            return Mapear(ObtenerTabla(retornarPersonal(id_personal), Tabla), 0);
        }

        public void eliminarPersonal(string id_personal)
        {
            Requerido(id_personal, "id_personal");
            configurarConexion();
            conec1.EjecutarComando(
                "DELETE FROM personal_cesfam WHERE id_personal = @id",
                Texto("@id", id_personal, 20));
        }

        public void actualizarPersonal(PersonalCesfam personal)
        {
            Validar(personal);
            configurarConexion();
            conec1.EjecutarComando(
                "UPDATE personal_cesfam SET nombre_completo = @nombre, rut = @rut, cargo = @cargo, " +
                "telefono = @telefono, correo = @correo WHERE id_personal = @id",
                CrearParametros(personal));
        }

        public DataSet buscarIdciudad(string id_ciudad)
        {
            Requerido(id_ciudad, "id_ciudad");
            configurarConexion();
            return conec1.EjecutarConsulta(
                Tabla,
                "SELECT id_personal, nombre_completo, rut, cargo, telefono, correo " +
                "FROM personal_cesfam WHERE id_ciudad = @ciudad",
                Texto("@ciudad", id_ciudad, 20));
        }

        public PersonalCesfam buscarIdPersonal(string id_personal)
        {
            return buscarPersonal(id_personal);
        }

        public DataSet retornarTotalPersonal()
        {
            configurarConexion();
            return conec1.EjecutarConsulta(
                Tabla,
                "SELECT id_personal, nombre_completo, rut, cargo, telefono, correo " +
                "FROM personal_cesfam ORDER BY nombre_completo");
        }

        private static SqlParameter[] CrearParametros(PersonalCesfam personal)
        {
            return new[]
            {
                Texto("@id", personal.Id_personal, 20),
                Texto("@nombre", personal.Nombre_completo, 150),
                Texto("@rut", personal.Rut, 20),
                Texto("@cargo", personal.Cargo1, 80),
                new SqlParameter("@telefono", SqlDbType.Int) { Value = personal.Telefono },
                Texto("@correo", personal.Correo, 150)
            };
        }

        private static void Validar(PersonalCesfam personal)
        {
            if (personal == null) throw new ArgumentNullException("personal");
            Requerido(personal.Id_personal, "id_personal");
            Requerido(personal.Nombre_completo, "nombre_completo");
            Requerido(personal.Rut, "rut");
            Requerido(personal.Cargo1, "cargo");
            Requerido(personal.Correo, "correo");
            if (personal.Telefono < 0) throw new ArgumentOutOfRangeException("telefono", "El teléfono no puede ser negativo.");
        }

        private static PersonalCesfam Mapear(DataTable tabla, int posicion)
        {
            if (!PosicionValida(tabla, posicion)) return new PersonalCesfam();
            DataRow fila = tabla.Rows[posicion];
            return new PersonalCesfam
            {
                Id_personal = Convert.ToString(fila["id_personal"]),
                Nombre_completo = Convert.ToString(fila["nombre_completo"]),
                Rut = Convert.ToString(fila["rut"]),
                Cargo1 = Convert.ToString(fila["cargo"]),
                Telefono = Convert.ToInt32(fila["telefono"]),
                Correo = Convert.ToString(fila["correo"])
            };
        }
    }
}
