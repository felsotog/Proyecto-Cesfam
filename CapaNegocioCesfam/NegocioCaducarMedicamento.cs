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
   public class NegocioCaducarMedicamento
    {
        private ConexionCesfam conec1;

        public ConexionCesfam Conec1 { get => conec1; set => conec1 = value; }

        public void configurarConexion()
        {
            this.conec1 = new ConexionCesfam();
            this.conec1.NombreBaseDeDatos = "CESFAM";
            this.conec1.NombreTabla = "caducar_medicamento";
            this.conec1.CadenaConexion = "Data Source=localhost;Initial Catalog=CESFAM;Integrated Security=True";
        }

        public void insertarCaducarMedicamento(CaducarMedicamento caducarmedicamento)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = "INSERT INTO " + this.conec1.NombreTabla + " (id_caducidad,fecha_caducidad) VALUES ('"
                + caducarmedicamento.Id_caducidad + "','" + caducarmedicamento.Fecha_caducidad + "');";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }


        public DataSet retornarCaducarMedicamento(string id_caducidad)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " SELECT * FROM " + this.conec1.NombreTabla + " WHERE id_caducidad = '" + id_caducidad + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            return this.conec1.DbDataSet;
        }

        public CaducarMedicamento retornaPosicionCaducarMedicamento(int pos, string id_caducidad)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM " + this.conec1.NombreTabla + " WHERE id_caducidad = '" + id_caducidad + "';";

            this.conec1.EsSelect = true;
            this.Conec1.conectar();
            CaducarMedicamento auxCaducarMedicamento = new CaducarMedicamento();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxCaducarMedicamento.Id_caducidad = (String)dt.Rows[pos]["id_caducidad"];
                auxCaducarMedicamento.Fecha_caducidad = (DateTime)dt.Rows[pos]["fecha_caducidad"];
                


            }
            catch (Exception ex)
            {
                auxCaducarMedicamento.Id_caducidad = "";
                auxCaducarMedicamento.Fecha_caducidad = DateTime.Today;
                


            }

            return auxCaducarMedicamento;
        }



        public CaducarMedicamento buscarCaducarMedicamento(String id_caducidad)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = " SELECT * FROM " + this.Conec1.NombreTabla +
                " WHERE id_caducidad = '" + id_caducidad + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            CaducarMedicamento auxCaducarMedicamento = new CaducarMedicamento();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxCaducarMedicamento.Id_caducidad = (String)dt.Rows[0]["id_caducidad"];
                auxCaducarMedicamento.Fecha_caducidad = (DateTime)dt.Rows[0]["fecha_caducidad"];



            }
            catch (Exception ex)
            {
                auxCaducarMedicamento.Id_caducidad = "";
                auxCaducarMedicamento.Fecha_caducidad = DateTime.Today;




            }
            return auxCaducarMedicamento;
        }

        public void eliminarCaducarMedicamento(String id_caducidad)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " DELETE FROM " + this.conec1.NombreTabla +
                " WHERE id_caducidad = '" + id_caducidad + "';";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }

        public void actualizarCaducarMedicamento(CaducarMedicamento caducarmedicamento)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = "UPDATE " + this.conec1.NombreTabla + " SET "
                + "fecha_caducidad = '" + caducarmedicamento.Fecha_caducidad 
                + "' WHERE id_caducidad = '" + caducarmedicamento.Id_caducidad + "';";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }


        public CaducarMedicamento buscarIdCaducarMedicamento(String id_caducidad)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = " SELECT * FROM " + this.Conec1.NombreTabla +
                " WHERE id_caducidad = '" + id_caducidad + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            CaducarMedicamento auxCaducarMedicamento = new CaducarMedicamento();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxCaducarMedicamento.Id_caducidad = (String)dt.Rows[0]["id_caducidad"];
                auxCaducarMedicamento.Fecha_caducidad = (DateTime)dt.Rows[0]["fecha_caducidad"];





            }
            catch (Exception ex)
            {
                auxCaducarMedicamento.Id_caducidad = "";
                auxCaducarMedicamento.Fecha_caducidad = DateTime.Today;





            }
            return auxCaducarMedicamento;

        }


        public CaducarMedicamento buscarIdCaducarmedicamento(String id_caducidad)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = " SELECT * FROM " + this.Conec1.NombreTabla +
                " WHERE id_caducidad = '" + id_caducidad + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            CaducarMedicamento auxCaducarMedicamento = new CaducarMedicamento();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxCaducarMedicamento.Id_caducidad = (String)dt.Rows[0]["id_caducidad"];
                auxCaducarMedicamento.Fecha_caducidad = (DateTime)dt.Rows[0]["fecha_caducidad"];


            }
            catch (Exception ex)
            {
                auxCaducarMedicamento.Id_caducidad = "";
                auxCaducarMedicamento.Fecha_caducidad = DateTime.Today;




            }
            return auxCaducarMedicamento;


        }

        public DataSet retornarCaducarMedicamento()
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
