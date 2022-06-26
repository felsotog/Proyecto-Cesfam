using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDTOCesfam;
using CapaConexion;
using System.Data;

namespace CapaNegocioCesfam
{
   public class NegocioDetalleCaducidad
    {
        private ConexionCesfam conec1;

        public ConexionCesfam Conec1 { get => conec1; set => conec1 = value; }

        public void configurarConexion()
        {
            this.conec1 = new ConexionCesfam();
            this.conec1.NombreBaseDeDatos = "CESFAM";
            this.conec1.NombreTabla = "detalle_caducidad";
            this.conec1.CadenaConexion = "Data Source=localhost;Initial Catalog=CESFAM;Integrated Security=True";
        }

        public void insertarDetalleCaducidad(DetalleCaducidad detallecaducidad)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = "INSERT INTO " + this.conec1.NombreTabla + " ( id_detalle,cantidad_caducada,motivo,medicamento_codigo,caducar_medicamento_id_caducidad) VALUES ('"
                + detallecaducidad.Id_detalle + "'," + detallecaducidad.Cantidad_caducada + ", '" + detallecaducidad.Motivo + "', '" + detallecaducidad.Medicamento_codigo + "', '"  + detallecaducidad.Caducar_medicamento_id_caducidad + "';";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }


        public DataSet retornarDetalleCaducidad(string id_detalle)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " SELECT * FROM " + this.conec1.NombreTabla + " WHERE id_detalle = '" + id_detalle + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            return this.conec1.DbDataSet;
        }

        public DetalleCaducidad retornaPosicionDetalleCaducidad(int pos, string id_detalle)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM " + this.conec1.NombreTabla + " WHERE id_detalle = '" + id_detalle + "';";

            this.conec1.EsSelect = true;
            this.Conec1.conectar();
            DetalleCaducidad auxDetalleCaducidad = new DetalleCaducidad();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxDetalleCaducidad.Id_detalle = (String)dt.Rows[pos]["id_detalle"];
                auxDetalleCaducidad.Cantidad_caducada = (int)dt.Rows[pos]["cantidad_caducada"];
                auxDetalleCaducidad.Motivo = (String)dt.Rows[pos]["motivo"];
                auxDetalleCaducidad.Medicamento_codigo = (String)dt.Rows[pos]["medicamento_codigo"];
                auxDetalleCaducidad.Caducar_medicamento_id_caducidad = (String)dt.Rows[pos]["caducar_medicamento_id_caducidad"];



            }
            catch (Exception ex)
            {
                auxDetalleCaducidad.Id_detalle = "";
                auxDetalleCaducidad.Cantidad_caducada =0;
                auxDetalleCaducidad.Motivo = "";
                auxDetalleCaducidad.Medicamento_codigo = "";
                auxDetalleCaducidad.Caducar_medicamento_id_caducidad = "";



            }

            return auxDetalleCaducidad;
        }



        public DetalleCaducidad buscarDetalleCaducidad(String id_detalle)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = " SELECT * FROM " + this.Conec1.NombreTabla +
                " WHERE id_detalle = '" + id_detalle + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            DetalleCaducidad auxDetalleCaducidad = new DetalleCaducidad();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxDetalleCaducidad.Id_detalle = (String)dt.Rows[0]["id_detalle"];
                auxDetalleCaducidad.Cantidad_caducada = (int)dt.Rows[0]["cantidad_caducada"];
                auxDetalleCaducidad.Motivo = (String)dt.Rows[ 0]["motivo"];
                auxDetalleCaducidad.Medicamento_codigo = (String)dt.Rows[0]["medicamento_codigo"];
                auxDetalleCaducidad.Caducar_medicamento_id_caducidad = (String)dt.Rows[0]["caducar_medicamento_id_caducidad"];

                


            }
            catch (Exception ex)
            {
                auxDetalleCaducidad.Id_detalle = "";
                auxDetalleCaducidad.Cantidad_caducada =0;
                auxDetalleCaducidad.Motivo = "";
                auxDetalleCaducidad.Medicamento_codigo = "";
                auxDetalleCaducidad.Caducar_medicamento_id_caducidad = "";


            }
            return auxDetalleCaducidad;
        }

        public void eliminarDetalleCaducidad(String id_detalle)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " DELETE FROM " + this.conec1.NombreTabla +
                " WHERE id_detalle = '" + id_detalle + "';";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }

        public void actualizarDetalleCaducidad(DetalleCaducidad detallecaducidad)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = "UPDATE " + this.conec1.NombreTabla + " SET "
                + " cantidad_caducada = '" + detallecaducidad.Cantidad_caducada + "',motivo = " + detallecaducidad.Motivo + "',medicamento_codigo = " + detallecaducidad.Medicamento_codigo + "',caducar_medicamento_id_caducidad = " + detallecaducidad.Caducar_medicamento_id_caducidad
                + "' WHERE id_caducidad = '" + detallecaducidad.Id_detalle + "';";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }


        public DetalleCaducidad buscarIdDetalleCaducidad(String id_caducidad)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = " SELECT * FROM " + this.Conec1.NombreTabla +
                " WHERE id_caducidad = '" + id_caducidad + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            DetalleCaducidad auxDetalleCaducidad = new DetalleCaducidad();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxDetalleCaducidad.Id_detalle = (String)dt.Rows[0]["id_detalle"];
                auxDetalleCaducidad.Cantidad_caducada = (int)dt.Rows[0]["cantidad_caducada"];
                auxDetalleCaducidad.Motivo = (String)dt.Rows[0]["motivo"];
                auxDetalleCaducidad.Medicamento_codigo = (String)dt.Rows[0]["medicamento_codigo"];
                auxDetalleCaducidad.Caducar_medicamento_id_caducidad = (String)dt.Rows[0]["caducar_medicamento_id_caducidad"];



            }
            catch (Exception ex)
            {
                auxDetalleCaducidad.Id_detalle = "";
                auxDetalleCaducidad.Cantidad_caducada = 0;
                auxDetalleCaducidad.Motivo = "";
                auxDetalleCaducidad.Medicamento_codigo = "";
                auxDetalleCaducidad.Caducar_medicamento_id_caducidad = "";





            }
            return auxDetalleCaducidad;

        }

        public DetalleCaducidad buscar_DetalleCaducidad(String id_detalle)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = " SELECT * FROM " + this.Conec1.NombreTabla +
                " WHERE id_detalle = '" + id_detalle + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            DetalleCaducidad auxDetalleCaducidad = new DetalleCaducidad();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxDetalleCaducidad.Id_detalle = (String)dt.Rows[0]["id_detalle"];
                auxDetalleCaducidad.Cantidad_caducada = (int)dt.Rows[0]["cantidad_caducada"];
                auxDetalleCaducidad.Motivo = (String)dt.Rows[0]["motivo"];
                auxDetalleCaducidad.Medicamento_codigo = (String)dt.Rows[0]["medicamento_id_medicamento"];
                auxDetalleCaducidad.Caducar_medicamento_id_caducidad = (String)dt.Rows[0]["caducar_medicamento_id_caducidad"];



            }
            catch (Exception ex)
            {
                auxDetalleCaducidad.Id_detalle = "";
                auxDetalleCaducidad.Cantidad_caducada = 0;
                auxDetalleCaducidad.Motivo = "";
                auxDetalleCaducidad.Medicamento_codigo = "";
                auxDetalleCaducidad.Caducar_medicamento_id_caducidad = "";



            }
            return auxDetalleCaducidad;


        }

        public DataSet retornarTotalDetalleCaducidad()
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " SELECT * FROM " + this.conec1.NombreTabla;
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            return this.conec1.DbDataSet;
        }

        //public DataSet retornarStockMedicamento(string id_medicamento)
        //{
        //  this.configurarConexion();
        //  this.conec1.CadenaSQL = " select ma.nombre,pro.codigo,pro.descripcion,pro.precio_unitario,pro.cantidad_total from marca ma join producto pro on(ma.id_marca=pro.marca_id_marca) where  pro.codigo = '" + codigo + "';";
        //  this.conec1.EsSelect = true;
        //  this.conec1.conectar();
        //  return this.conec1.DbDataSet;
        // }
    }
}

