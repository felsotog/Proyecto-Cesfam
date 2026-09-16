using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CapaConexion
{
    /// <summary>
    /// Centraliza el acceso a SQL Server para todas las capas del sistema.
    /// </summary>
    public class ConexionCesfam
    {
        public string NombreBaseDeDatos { get; set; }
        public string NombreTabla { get; set; }
        public string CadenaConexion { get; set; }
        public string CadenaSQL { get; set; }
        public bool EsSelect { get; set; }
        public SqlConnection DbConnection { get; private set; }
        public DataSet DbDataSet { get; private set; }
        public SqlDataAdapter DbDataAdapter { get; private set; }
        public SqlParameter[] Parametros { get; set; }

        public ConexionCesfam()
        {
            NombreBaseDeDatos = "CESFAM";
            CadenaConexion = ObtenerCadenaConexion();
            Parametros = new SqlParameter[0];
        }

        public static string ObtenerCadenaConexion()
        {
            // La variable de entorno tiene prioridad para evitar publicar credenciales en GitHub.
            string desdeEntorno = Environment.GetEnvironmentVariable("CESFAM_CONNECTION_STRING");
            if (!string.IsNullOrWhiteSpace(desdeEntorno))
            {
                return desdeEntorno;
            }

            ConnectionStringSettings configurada =
                ConfigurationManager.ConnectionStrings["CesfamDatabase"];

            if (configurada == null || string.IsNullOrWhiteSpace(configurada.ConnectionString))
            {
                throw new ConfigurationErrorsException(
                    "No se encontró la cadena 'CesfamDatabase'. Configúrela en Web.config/App.config " +
                    "o defina la variable CESFAM_CONNECTION_STRING.");
            }

            return configurada.ConnectionString;
        }

        public DataSet EjecutarConsulta(
            string nombreTabla,
            string sql,
            params SqlParameter[] parametros)
        {
            ValidarArgumentos(nombreTabla, sql);

            // Cada operación administra su propia conexión para liberarla incluso si SQL Server falla.
            var resultado = new DataSet();
            using (var conexion = new SqlConnection(CadenaConexion))
            using (var comando = CrearComando(conexion, sql, parametros))
            using (var adaptador = new SqlDataAdapter(comando))
            {
                conexion.Open();
                adaptador.Fill(resultado, nombreTabla);
            }

            return resultado;
        }

        public int EjecutarComando(string sql, params SqlParameter[] parametros)
        {
            if (string.IsNullOrWhiteSpace(sql))
            {
                throw new ArgumentException("La sentencia SQL es obligatoria.", "sql");
            }

            using (var conexion = new SqlConnection(CadenaConexion))
            using (var comando = CrearComando(conexion, sql, parametros))
            {
                conexion.Open();
                return comando.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Mantiene compatibilidad con el código original.
        /// </summary>
        public void conectar()
        {
            if (EsSelect)
            {
                DbDataSet = EjecutarConsulta(NombreTabla, CadenaSQL, Parametros);
                return;
            }

            EjecutarComando(CadenaSQL, Parametros);
        }

        public void abrir()
        {
            if (DbConnection == null)
            {
                DbConnection = new SqlConnection(CadenaConexion);
            }

            if (DbConnection.State != ConnectionState.Open)
            {
                DbConnection.Open();
            }
        }

        public void cerrar()
        {
            if (DbConnection != null && DbConnection.State != ConnectionState.Closed)
            {
                DbConnection.Close();
            }
        }

        private static SqlCommand CrearComando(
            SqlConnection conexion,
            string sql,
            SqlParameter[] parametros)
        {
            var comando = new SqlCommand(sql, conexion);
            // Los parámetros mantienen los valores separados de la sentencia SQL y evitan inyección.
            if (parametros != null && parametros.Length > 0)
            {
                comando.Parameters.AddRange(parametros);
            }

            return comando;
        }

        private static void ValidarArgumentos(string nombreTabla, string sql)
        {
            if (string.IsNullOrWhiteSpace(nombreTabla))
            {
                throw new ArgumentException("El nombre de la tabla de resultado es obligatorio.", "nombreTabla");
            }

            if (string.IsNullOrWhiteSpace(sql))
            {
                throw new ArgumentException("La sentencia SQL es obligatoria.", "sql");
            }
        }
    }
}
