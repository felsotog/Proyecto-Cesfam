using CapaConexion;
using CapaDTOCesfam;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace CapaNegocioCesfam
{
    public class NegocioFarmacia
    {
        private ConexionCesfam conec1;

        public ConexionCesfam Conec1 { get => conec1; set => conec1 = value; }

        public void configurarConexion()
        {
            this.conec1 = new ConexionCesfam();
            this.conec1.NombreBaseDeDatos = "CESFAM";
            this.conec1.NombreTabla = "farmacia";
            this.conec1.CadenaConexion = "Data Source=DESKTOP-Q77LRSF\\SQLEXPRESS;Initial Catalog=cesfam;Integrated Security=True";
        }

        public void insertarFarmacia(Farmacia farmacia)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = "INSERT INTO " + this.conec1.NombreTabla + " (id_farmacia,nombre_farmacia) VALUES ('"
                + farmacia.Id_farmacia + "','" + farmacia.Nombre_farmacia + "');";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }


        public DataSet retornarFarmacia(string id_farmacia)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " SELECT * FROM " + this.conec1.NombreTabla + " WHERE id_farmacia = '" + id_farmacia + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            return this.conec1.DbDataSet;
        }

        public Farmacia retornaPosicionFarmacia(int pos, string id_farmacia)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM " + this.conec1.NombreTabla + " WHERE id_farmacia = '" + id_farmacia + "';";

            this.conec1.EsSelect = true;
            this.Conec1.conectar();
            Farmacia auxFarmacia = new Farmacia();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxFarmacia.Id_farmacia = (String)dt.Rows[pos]["id_farmacia"];
                auxFarmacia.Nombre_farmacia = (String)dt.Rows[pos]["nombre_farmacia"];



            }
            catch (Exception ex)
            {
                auxFarmacia.Id_farmacia = "";
                auxFarmacia.Nombre_farmacia = "";



            }

            return auxFarmacia;
        }



        public Farmacia buscarFarmacia(String id_farmacia)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = " SELECT * FROM " + this.Conec1.NombreTabla +
                " WHERE id_farmacia = '" + id_farmacia + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            Farmacia auxFarmacia = new Farmacia();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxFarmacia.Id_farmacia = (String)dt.Rows[0]["id_farmacia"];
                auxFarmacia.Nombre_farmacia = (String)dt.Rows[0]["nombre_farmacia"];



            }
            catch (Exception ex)
            {
                auxFarmacia.Id_farmacia = "";
                auxFarmacia.Nombre_farmacia = "";


            }
            return auxFarmacia;
        }

        public void eliminarFarmacia(String id_farmacia)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " DELETE FROM " + this.conec1.NombreTabla +
                " WHERE id_farmacia = '" + id_farmacia + "';";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }

        public void actualizarFarmacia(Farmacia farmacia)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = "UPDATE " + this.conec1.NombreTabla + " SET "
                + " nombre_farmacia = '" + farmacia.Nombre_farmacia 
                + "' WHERE id_farmacia = '" + farmacia.Id_farmacia + "';";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }


        public Farmacia buscarIdFarmacia(String id_farmacia)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = " SELECT * FROM " + this.Conec1.NombreTabla +
                " WHERE id_farmacia = '" + id_farmacia + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            Farmacia auxFarmacia = new Farmacia();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxFarmacia.Id_farmacia = (String)dt.Rows[0]["id_farmacia"];
                auxFarmacia.Nombre_farmacia = (String)dt.Rows[0]["nombre_farmacia"];



            }
            catch (Exception ex)
            {
                auxFarmacia.Id_farmacia = "";
                auxFarmacia.Nombre_farmacia = "";




            
            }
            return auxFarmacia;
        
        }

        public Farmacia buscar_Farmacia(String id_farmacia)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = " SELECT * FROM " + this.Conec1.NombreTabla +
                " WHERE id_farmacia = '" + id_farmacia + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            Farmacia auxFarmacia = new Farmacia();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxFarmacia.Id_farmacia = (String)dt.Rows[0]["id_farmacia"];
                auxFarmacia.Nombre_farmacia = (String)dt.Rows[0]["nombre_farmacia"];



            }
            catch (Exception ex)
            {
                auxFarmacia.Id_farmacia = "";
                auxFarmacia.Nombre_farmacia = "";


            }
            return auxFarmacia;


        }

        public DataSet retornarTotalFarmacias()
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