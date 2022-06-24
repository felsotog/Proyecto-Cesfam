using CapaConexion;
using System;
using CapaDTOCesfam;
using CapaNegocioCesfam;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace CapaNegocioCesfam
{
    public class NegocioMedicamento
    {
        private ConexionCesfam conec1;

        public ConexionCesfam Conec1 { get => conec1; set => conec1 = value; }

        public void configurarConexion()
        {
            this.conec1 = new ConexionCesfam();
            this.conec1.NombreBaseDeDatos = "CESFAM";
            this.conec1.NombreTabla = "medicamento";
            this.conec1.CadenaConexion = @"Data Source=DESKTOP-UKNM7EP\SQLEXPRESS;Initial Catalog=CESFAM;Integrated Security=True";
        }

        public void insertarMedicamento(Medicamento medicamento)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = "INSERT INTO " + this.conec1.NombreTabla + " (codigo,nombre_medicamento,tipo_medicamento,fecha_fabricacion,fecha_vencimiento,descripcion,cantidad,farmacia_id_farmacia) VALUES ('"
                + medicamento.Codigo + "','" + medicamento.Nombre_medicamento + "'," + medicamento.Tipo_medicamento + "," + medicamento.Fecha_fabricacion + ",'" + medicamento.Fecha_vencimiento + "', '" + medicamento.Descripcion + "', " + medicamento.Cantidad + ", '" + medicamento.Farmacia_id_farmacia + "');";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }


        public DataSet retornarMedicamento(string codigo)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " SELECT * FROM " + this.conec1.NombreTabla + " WHERE codigo = '" + codigo + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            return this.conec1.DbDataSet;
        }

        public Medicamento retornaPosicionMedicamento(int pos, string codigo)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM " + this.conec1.NombreTabla + " WHERE codigo = '" + codigo + "';";

            this.conec1.EsSelect = true;
            this.Conec1.conectar();
            Medicamento auxMedicamento = new Medicamento();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxMedicamento.Codigo = (String)dt.Rows[pos]["codigo"];
                auxMedicamento.Nombre_medicamento = (String)dt.Rows[pos]["nombre_medicamento"];
                auxMedicamento.Tipo_medicamento = (String)dt.Rows[pos]["tipo_medicamento"];
                auxMedicamento.Fecha_fabricacion = (DateTime)dt.Rows[pos]["fecha_fabricacion"];
                auxMedicamento.Fecha_vencimiento = (DateTime)dt.Rows[pos]["fecha_vencimiento"];
                auxMedicamento.Descripcion = (String)dt.Rows[pos]["descripcion"];
                auxMedicamento.Cantidad = (int)dt.Rows[pos]["cantidad"];
                auxMedicamento.Farmacia_id_farmacia = (String)dt.Rows[pos]["farmacia_id_farmacia"];


            }
            catch (Exception ex)
            {
                auxMedicamento.Codigo = "";
                auxMedicamento.Nombre_medicamento = "";
                auxMedicamento.Tipo_medicamento = "";
                auxMedicamento.Fecha_fabricacion = DateTime.Today;
                auxMedicamento.Fecha_vencimiento = DateTime.Today;
                auxMedicamento.Descripcion = "";
                auxMedicamento.Cantidad = 0;
                auxMedicamento.Farmacia_id_farmacia = "";


            }

            return auxMedicamento;
        }



        public Medicamento buscarMedicamento(String codigo)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = " SELECT * FROM " + this.Conec1.NombreTabla +
                " WHERE codigo = '" + codigo + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            Medicamento auxMedicamento = new Medicamento();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxMedicamento.Codigo = (String)dt.Rows[0]["codigo"];
                auxMedicamento.Nombre_medicamento = (String)dt.Rows[0]["nombre_medicamento"];
                auxMedicamento.Tipo_medicamento = (String)dt.Rows[0]["tipo_medicamento"];
                auxMedicamento.Fecha_fabricacion = (DateTime)dt.Rows[0]["fecha_fabricacion"];
                auxMedicamento.Fecha_vencimiento = (DateTime)dt.Rows[0]["fecha_vencimiento"];
                auxMedicamento.Descripcion = (String)dt.Rows[0]["descripcion"];
                auxMedicamento.Cantidad = (int)dt.Rows[0]["cantidad"];
                auxMedicamento.Farmacia_id_farmacia = (String)dt.Rows[0]["farmacia_id_farmacia"];



            }
            catch (Exception ex)
            {
                auxMedicamento.Codigo = "";
                auxMedicamento.Nombre_medicamento = "";
                auxMedicamento.Tipo_medicamento = "";
                auxMedicamento.Fecha_fabricacion = DateTime.Today;
                auxMedicamento.Fecha_vencimiento = DateTime.Today;
                auxMedicamento.Descripcion = "";
                auxMedicamento.Cantidad = 0;
                auxMedicamento.Farmacia_id_farmacia = "";




            }
            return auxMedicamento;
        }

        public void eliminarMedicamento(String codigo)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " DELETE FROM " + this.conec1.NombreTabla +
                " WHERE codigo = '" + codigo + "';";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }

        public void actualizarMedicamento(Medicamento medicamento)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = "UPDATE " + this.conec1.NombreTabla + " SET "
                + "nombre_medicamento = '" + medicamento.Nombre_medicamento + "',tipo_medicamento = " + medicamento.Tipo_medicamento + ",fecha_fabricacion = " + medicamento.Fecha_fabricacion + ",fecha_vencimiento = '" + medicamento.Fecha_vencimiento + ",descripcion = '" + medicamento.Descripcion + ",cantidad = '" + medicamento.Cantidad + ",farmacia_id_farmacia = '" + medicamento.Farmacia_id_farmacia
                + "' WHERE codigo = '" + medicamento.Codigo + "';";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }


        public Medicamento buscarIdMedicamento(String codigo)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = " SELECT * FROM " + this.Conec1.NombreTabla +
                " WHERE codigo = '" + codigo + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            Medicamento auxMedicamento = new Medicamento();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxMedicamento.Codigo = (String)dt.Rows[0]["codigo"];
                auxMedicamento.Nombre_medicamento = (String)dt.Rows[0]["nombre_medicamento"];
                auxMedicamento.Tipo_medicamento = (String)dt.Rows[0]["tipo_medicamento"];
                auxMedicamento.Fecha_fabricacion = (DateTime)dt.Rows[0]["fecha_fabricacion"];
                auxMedicamento.Fecha_vencimiento = (DateTime)dt.Rows[0]["fecha_vencimiento"];
                auxMedicamento.Descripcion = (String)dt.Rows[0]["descripcion"];
                auxMedicamento.Cantidad = (int)dt.Rows[0]["cantidad"];
                auxMedicamento.Farmacia_id_farmacia = (String)dt.Rows[0]["farmacia_id_farmacia"];





            }
            catch (Exception ex)
            {
                auxMedicamento.Codigo = "";
                auxMedicamento.Nombre_medicamento = "";
                auxMedicamento.Tipo_medicamento = "";
                auxMedicamento.Fecha_fabricacion = DateTime.Today;
                auxMedicamento.Fecha_vencimiento = DateTime.Today;
                auxMedicamento.Descripcion = "";
                auxMedicamento.Cantidad = 0;
                auxMedicamento.Farmacia_id_farmacia = "";





            }
            return auxMedicamento;

        }


        public Medicamento buscarId_Medicamento(String codigo)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = " SELECT * FROM " + this.Conec1.NombreTabla +
                " WHERE codigo = '" + codigo + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            Medicamento auxMedicamento = new Medicamento();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxMedicamento.Codigo = (String)dt.Rows[0]["codigo"];
                auxMedicamento.Nombre_medicamento = (String)dt.Rows[0]["nombre_medicamento"];
                auxMedicamento.Tipo_medicamento = (String)dt.Rows[0]["tipo_medicamento"];
                auxMedicamento.Fecha_fabricacion = (DateTime)dt.Rows[0]["fecha_fabricacion"];
                auxMedicamento.Fecha_vencimiento = (DateTime)dt.Rows[0]["fecha_vencimiento"];
                auxMedicamento.Descripcion = (String)dt.Rows[0]["descripcion"];
                auxMedicamento.Cantidad = (int)dt.Rows[0]["cantidad"];
                auxMedicamento.Farmacia_id_farmacia = (String)dt.Rows[0]["farmacia_id_farmacia"];



            }
            catch (Exception ex)
            {
                auxMedicamento.Codigo = "";
                auxMedicamento.Nombre_medicamento = "";
                auxMedicamento.Tipo_medicamento = "";
                auxMedicamento.Fecha_fabricacion = DateTime.Today;
                auxMedicamento.Fecha_vencimiento = DateTime.Today;
                auxMedicamento.Descripcion = "";
                auxMedicamento.Cantidad = 0;
                auxMedicamento.Farmacia_id_farmacia = "";




            }
            return auxMedicamento;


        }

        public DataSet retornarTotalMedicamentos()
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