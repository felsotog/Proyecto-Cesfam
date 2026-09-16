using CapaConexion;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaNegocioCesfam
{
    /// <summary>
    /// Reúne validaciones y utilidades de acceso a datos comunes a las entidades mantenidas.
    /// </summary>
    public abstract class NegocioBase
    {
        protected static ConexionCesfam CrearConexion(string tabla)
        {
            return new ConexionCesfam
            {
                NombreTabla = tabla
            };
        }

        protected static SqlParameter Texto(string nombre, string valor, int longitud)
        {
            return new SqlParameter(nombre, SqlDbType.NVarChar, longitud)
            {
                Value = (object)valor ?? DBNull.Value
            };
        }

        protected static void Requerido(string valor, string campo)
        {
            if (string.IsNullOrWhiteSpace(valor))
            {
                throw new ArgumentException("El campo " + campo + " es obligatorio.", campo);
            }
        }

        protected static DataTable ObtenerTabla(DataSet dataSet, string tabla)
        {
            // Un resultado sin tabla se trata como vacío para que las búsquedas no fallen por índice.
            if (dataSet == null || !dataSet.Tables.Contains(tabla))
            {
                return null;
            }

            return dataSet.Tables[tabla];
        }

        protected static bool PosicionValida(DataTable tabla, int posicion)
        {
            return tabla != null && posicion >= 0 && posicion < tabla.Rows.Count;
        }
    }
}
