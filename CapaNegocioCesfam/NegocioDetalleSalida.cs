using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaConexion;
using CapaDTOCesfam;

namespace CapaNegocioCesfam
{
   public class NegocioDetalleSalida
    {
        private ConexionCesfam conec1;

        public ConexionCesfam Conec1 { get => conec1; set => conec1 = value; }

        public void configurarConexion()
        {
            this.conec1 = new ConexionCesfam();
            this.conec1.NombreBaseDeDatos = "CESFAM";
            this.conec1.NombreTabla = "detalle_salida";
            this.conec1.CadenaConexion = "Data Source=localhost;Initial Catalog=CESFAM;Integrated Security=True";
        }

        public void insertarDetalleSalida(DetalleSalida detallesalida)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = "INSERT INTO " + this.conec1.NombreTabla + " ( id_detallesalida,cantidad,medicamento_codigo,salida_medicamento_id_salida) VALUES ('"
                + detallesalida.Id_detalleSalida + "'," + detallesalida.Cantidad + ", '" + detallesalida.Medicamento_codigo + "', '" + detallesalida.Salida_medicamento_id_salida + "');";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }


        public DataSet retornarDetalleSalida(string id_DetalleSalida)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " SELECT * FROM " + this.conec1.NombreTabla + " WHERE id_detallesalida = '" + id_DetalleSalida + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            return this.conec1.DbDataSet;
        }

        public DetalleSalida retornaPosicionDetalleSalida(int pos, string id_DetalleSalida)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM " + this.conec1.NombreTabla + " WHERE id_detallesalida = '" + id_DetalleSalida + "';";

            this.conec1.EsSelect = true;
            this.Conec1.conectar();
            DetalleSalida auxDetalleSalida = new DetalleSalida();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxDetalleSalida.Id_detalleSalida = (String)dt.Rows[pos]["id_detallesalida"];
                auxDetalleSalida.Cantidad = (int)dt.Rows[pos]["cantidad_caducada"];
                auxDetalleSalida.Medicamento_codigo = (String)dt.Rows[pos]["medicamento_codigo"];
                auxDetalleSalida.Salida_medicamento_id_salida = (String)dt.Rows[pos]["salida_medicamento_id_salida"];




            }
            catch (Exception ex)
            {
                auxDetalleSalida.Id_detalleSalida = "";
                auxDetalleSalida.Cantidad = 0;
                auxDetalleSalida.Medicamento_codigo= "";
                auxDetalleSalida.Salida_medicamento_id_salida = "";
             



            }

            return auxDetalleSalida;
        }



        public DetalleSalida buscarDetalleSalida(String id_detalleSalida)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = " SELECT * FROM " + this.Conec1.NombreTabla +
                " WHERE id_detallesalida = '" + id_detalleSalida + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            DetalleSalida auxDetalleSalida = new DetalleSalida();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxDetalleSalida.Id_detalleSalida = (String)dt.Rows[0]["id_detallesalida"];
                auxDetalleSalida.Cantidad = (int)dt.Rows[0]["cantidad_caducada"];
                auxDetalleSalida.Medicamento_codigo = (String)dt.Rows[0]["medicamento_codigo"];
                auxDetalleSalida.Salida_medicamento_id_salida = (String)dt.Rows[0]["salida_medicamento_id_salida"];





            }
            catch (Exception ex)
            {
                auxDetalleSalida.Id_detalleSalida = "";
                auxDetalleSalida.Cantidad = 0;
                auxDetalleSalida.Medicamento_codigo = "";
                auxDetalleSalida.Salida_medicamento_id_salida = "";


            }
            return auxDetalleSalida;
        }

        public void eliminarDetalleSalida(String id_detalleSalida)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " DELETE FROM " + this.conec1.NombreTabla +
                " WHERE id_detallesalida = '" + id_detalleSalida + "';";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }

        public void actualizarDetalleSalida(DetalleSalida detallesalida)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = "UPDATE " + this.conec1.NombreTabla + " SET "
                + " cantidad = " + detallesalida.Cantidad  + " ,medicamento_codigo = '" + detallesalida.Medicamento_codigo + "',salida_medicamento_id_salida = '" + detallesalida.Salida_medicamento_id_salida 
                + "' WHERE id_detallesalida = '" + detallesalida.Id_detalleSalida + "';";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }


        public DetalleSalida buscarIdDetalleSalida(String id_detalleSalida)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = " SELECT * FROM " + this.Conec1.NombreTabla +
                " WHERE id_detallesalida = '" + id_detalleSalida + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            DetalleSalida auxDetalleSalida = new DetalleSalida();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxDetalleSalida.Id_detalleSalida = (String)dt.Rows[0]["id_detallesalida"];
                auxDetalleSalida.Cantidad = (int)dt.Rows[0]["cantidad_caducada"];
                auxDetalleSalida.Medicamento_codigo = (String)dt.Rows[0]["medicamento_codigo"];
                auxDetalleSalida.Salida_medicamento_id_salida = (String)dt.Rows[0]["salida_medicamento_id_salida"];



            }
            catch (Exception ex)
            {
                auxDetalleSalida.Id_detalleSalida = "";
                auxDetalleSalida.Cantidad = 0;
                auxDetalleSalida.Medicamento_codigo = "";
                auxDetalleSalida.Salida_medicamento_id_salida = "";





            }
            return auxDetalleSalida;

        }

        public DetalleSalida buscar_DetalleSalida(String id_detalleSalida)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = " SELECT * FROM " + this.Conec1.NombreTabla +
                " WHERE id_detallesalida = '" + id_detalleSalida + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            DetalleSalida auxDetalleSalida = new DetalleSalida();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxDetalleSalida.Id_detalleSalida = (String)dt.Rows[0]["id_detallesalida"];
                auxDetalleSalida.Cantidad = (int)dt.Rows[0]["cantidad_caducada"];
                auxDetalleSalida.Medicamento_codigo = (String)dt.Rows[0]["medicamento_codigo"];
                auxDetalleSalida.Salida_medicamento_id_salida = (String)dt.Rows[0]["salida_medicamento_id_salida"];



            }
            catch (Exception ex)
            {
                auxDetalleSalida.Id_detalleSalida = "";
                auxDetalleSalida.Cantidad = 0;
                auxDetalleSalida.Medicamento_codigo = "";
                auxDetalleSalida.Salida_medicamento_id_salida = "";



            }
            return auxDetalleSalida;


        }

        public DataSet retornarTotalDetalleSalida()
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
        //}
    }
}

