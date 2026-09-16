using CapaConexion;
using CapaDTOCesfam;
using System;
using System.Data;

namespace CapaNegocioCesfam
{
    public class NegocioFarmaceutico : NegocioBase
    {
        private const string Tabla = "farmaceutico";
        private ConexionCesfam conec1;

        public ConexionCesfam Conec1 { get { return conec1; } set { conec1 = value; } }

        public void configurarConexion()
        {
            conec1 = CrearConexion(Tabla);
        }

        public void insertarFarmaceuta(Farmaceutico farmaceutico)
        {
            Validar(farmaceutico);
            configurarConexion();
            conec1.EjecutarComando(
                "INSERT INTO farmaceutico (id_farmaceuta, nombre_farmaceuta, farmacia_id_farmacia) VALUES (@id, @nombre, @farmacia)",
                Texto("@id", farmaceutico.Id_farmaceuta, 20),
                Texto("@nombre", farmaceutico.Nombre_farmaceuta, 120),
                Texto("@farmacia", farmaceutico.Farmacia_id_farmacia, 20));
        }

        public DataSet retornarFarmaceuta(string id_farmaceuta)
        {
            Requerido(id_farmaceuta, "id_farmaceuta");
            configurarConexion();
            return conec1.EjecutarConsulta(
                Tabla,
                "SELECT id_farmaceuta, nombre_farmaceuta, farmacia_id_farmacia FROM farmaceutico WHERE id_farmaceuta = @id",
                Texto("@id", id_farmaceuta, 20));
        }

        public Farmaceutico retornaPosicionFarmaceuta(int pos, string id_farmaceuta)
        {
            return Mapear(ObtenerTabla(retornarFarmaceuta(id_farmaceuta), Tabla), pos);
        }

        public Farmaceutico buscarFarmaceuta(string id_farmaceuta)
        {
            return Mapear(ObtenerTabla(retornarFarmaceuta(id_farmaceuta), Tabla), 0);
        }

        public void eliminarFarmaceuta(string id_farmaceuta)
        {
            Requerido(id_farmaceuta, "id_farmaceuta");
            configurarConexion();
            conec1.EjecutarComando(
                "DELETE FROM farmaceutico WHERE id_farmaceuta = @id",
                Texto("@id", id_farmaceuta, 20));
        }

        public void actualizarFarmaceuta(Farmaceutico farmaceuta)
        {
            Validar(farmaceuta);
            configurarConexion();
            conec1.EjecutarComando(
                "UPDATE farmaceutico SET nombre_farmaceuta = @nombre, farmacia_id_farmacia = @farmacia WHERE id_farmaceuta = @id",
                Texto("@nombre", farmaceuta.Nombre_farmaceuta, 120),
                Texto("@farmacia", farmaceuta.Farmacia_id_farmacia, 20),
                Texto("@id", farmaceuta.Id_farmaceuta, 20));
        }

        public Farmaceutico buscarIdFarmaceutico(string id_farmaceuta)
        {
            return buscarFarmaceuta(id_farmaceuta);
        }

        public Farmaceutico buscar_Farmaceuta(string id_farmaceuta)
        {
            return buscarFarmaceuta(id_farmaceuta);
        }

        public DataSet retornarTotalFarmaceutas()
        {
            configurarConexion();
            return conec1.EjecutarConsulta(
                Tabla,
                "SELECT id_farmaceuta, nombre_farmaceuta, farmacia_id_farmacia FROM farmaceutico ORDER BY nombre_farmaceuta");
        }

        private static void Validar(Farmaceutico farmaceutico)
        {
            if (farmaceutico == null) throw new ArgumentNullException("farmaceutico");
            Requerido(farmaceutico.Id_farmaceuta, "id_farmaceuta");
            Requerido(farmaceutico.Nombre_farmaceuta, "nombre_farmaceuta");
            Requerido(farmaceutico.Farmacia_id_farmacia, "farmacia_id_farmacia");
        }

        private static Farmaceutico Mapear(DataTable tabla, int posicion)
        {
            if (!PosicionValida(tabla, posicion)) return new Farmaceutico();
            DataRow fila = tabla.Rows[posicion];
            return new Farmaceutico
            {
                Id_farmaceuta = Convert.ToString(fila["id_farmaceuta"]),
                Nombre_farmaceuta = Convert.ToString(fila["nombre_farmaceuta"]),
                Farmacia_id_farmacia = Convert.ToString(fila["farmacia_id_farmacia"])
            };
        }
    }
}
