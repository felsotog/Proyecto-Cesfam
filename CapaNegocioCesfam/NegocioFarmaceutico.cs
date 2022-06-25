using CapaConexion;
using System;
using CapaDTOCesfam;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace CapaNegocioCesfam
{
    public class NegocioFarmaceutico
    {
        private ConexionCesfam conec1;

        public ConexionCesfam Conec1 { get => conec1; set => conec1 = value; }

        public void configurarConexion()
        {
            this.conec1 = new ConexionCesfam();
            this.conec1.NombreBaseDeDatos = "CESFAM";
            this.conec1.NombreTabla = "farmaceutico";
            this.conec1.CadenaConexion = "Data Source=DESKTOP-DQKDMBV;Initial Catalog=CESFAM;Integrated Security=True";
        }

        public void insertarFarmaceuta(Farmaceutico farmaceutico)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = "INSERT INTO " + this.conec1.NombreTabla + " (id_farmaceuta,nombre_farmaceuta,farmacia_id_farmacia) VALUES ('"
                + farmaceutico.Id_farmaceuta + "','" + farmaceutico.Nombre_farmaceuta + "', '" + farmaceutico.Farmacia_id_farmacia + "');";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }


        public DataSet retornarFarmaceuta(string id_farmaceuta)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " SELECT * FROM " + this.conec1.NombreTabla + " WHERE id_farmaceuta = '" + id_farmaceuta + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            return this.conec1.DbDataSet;
        }

        public Farmaceutico retornaPosicionFarmaceuta(int pos, string id_farmaceuta)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM " + this.conec1.NombreTabla + " WHERE id_farmaceuta = '" + id_farmaceuta + "';";

            this.conec1.EsSelect = true;
            this.Conec1.conectar();
            Farmaceutico auxFarmaceuta = new Farmaceutico();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxFarmaceuta.Id_farmaceuta = (String)dt.Rows[pos]["id_farmaceuta"];
                auxFarmaceuta.Nombre_farmaceuta = (String)dt.Rows[pos]["nombre_farmaceuta"];
                auxFarmaceuta.Farmacia_id_farmacia = (String)dt.Rows[pos]["farmacia_id_farmacia"];



            }
            catch (Exception ex)
            {
                auxFarmaceuta.Id_farmaceuta = "";
                auxFarmaceuta.Nombre_farmaceuta = "";
                auxFarmaceuta.Farmacia_id_farmacia = "";



            }

            return auxFarmaceuta;
        }



        public Farmaceutico buscarFarmaceuta(String id_farmaceuta)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = " SELECT * FROM " + this.Conec1.NombreTabla +
                " WHERE id_farmaceuta = '" + id_farmaceuta + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            Farmaceutico auxFarmaceuta = new Farmaceutico();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxFarmaceuta.Id_farmaceuta = (String)dt.Rows[0]["id_farmaceuta"];
                auxFarmaceuta.Nombre_farmaceuta = (String)dt.Rows[0]["nombre_farmaceuta"];
                auxFarmaceuta.Farmacia_id_farmacia = (String)dt.Rows[0]["farmacia_id_farmacia"];




            }
            catch (Exception ex)
            {
                auxFarmaceuta.Id_farmaceuta = "";
                auxFarmaceuta.Nombre_farmaceuta = "";
                auxFarmaceuta.Farmacia_id_farmacia = "";





            }
            return auxFarmaceuta;
        }

        public void eliminarFarmaceuta(String id_farmaceuta)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " DELETE FROM " + this.conec1.NombreTabla +
                " WHERE id_farmaceuta = '" + id_farmaceuta + "';";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }

        public void actualizarFarmaceuta(Farmaceutico farmaceuta)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = "UPDATE " + this.conec1.NombreTabla + " SET "
                + " nombre_famaceuta = '" + farmaceuta.Nombre_farmaceuta + "',farmacia_id_farmacia = " + farmaceuta.Farmacia_id_farmacia
                + "' WHERE id_farmaceuta = '" + farmaceuta.Id_farmaceuta + "';";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }


        public Farmaceutico buscarIdFarmaceutico(String id_farmaceuta)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = " SELECT * FROM " + this.Conec1.NombreTabla +
                " WHERE id_farmaceuta = '" + id_farmaceuta + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            Farmaceutico auxFarmaceutico = new Farmaceutico();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxFarmaceutico.Id_farmaceuta = (String)dt.Rows[0]["id_farmaceuta"];
                auxFarmaceutico.Nombre_farmaceuta = (String)dt.Rows[0]["nombre_farmaceuta"];
                auxFarmaceutico.Farmacia_id_farmacia = (String)dt.Rows[0]["farmacia_id_farmacia"];




            }
            catch (Exception ex)
            {
                auxFarmaceutico.Id_farmaceuta = "";
                auxFarmaceutico.Nombre_farmaceuta = "";
                auxFarmaceutico.Farmacia_id_farmacia = "";
               





            }
            return auxFarmaceutico;

        }

        public Farmaceutico buscar_Farmaceuta(String id_farmaceuta)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = " SELECT * FROM " + this.Conec1.NombreTabla +
                " WHERE id_farmaceuta = '" + id_farmaceuta + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            Farmaceutico auxFarmaceuta = new Farmaceutico();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxFarmaceuta.Id_farmaceuta = (String)dt.Rows[0]["id_farmaceuta"];
                auxFarmaceuta.Nombre_farmaceuta = (String)dt.Rows[0]["nombre_farmaceuta"];
                auxFarmaceuta.Farmacia_id_farmacia = (String)dt.Rows[0]["farmacia_id_farmacia"];



            }
            catch (Exception ex)
            {
                auxFarmaceuta.Id_farmaceuta = "";
                auxFarmaceuta.Nombre_farmaceuta = "";
                auxFarmaceuta.Farmacia_id_farmacia = "";





            }
            return auxFarmaceuta;


        }

        public DataSet retornarTotalFarmaceutas()
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