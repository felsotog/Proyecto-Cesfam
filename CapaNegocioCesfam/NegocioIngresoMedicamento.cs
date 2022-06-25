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
   public class NegocioIngresoMedicamento
    {
   

            private ConexionCesfam conec1;

            public ConexionCesfam Conec1 { get => conec1; set => conec1 = value; }

            public void configurarConexion()
            {
                this.conec1 = new ConexionCesfam();
                this.conec1.NombreBaseDeDatos = "CESFAM";
                this.conec1.NombreTabla = "ingreso_medicamento";
                this.conec1.CadenaConexion = "Data Source=DESKTOP-DQKDMBV;Initial Catalog=CESFAM;Integrated Security=True";
            }

            public void insertarIngresoMedicamento(IngresoMedicamento ingresomedicamento)
            {
                this.configurarConexion();
                this.conec1.CadenaSQL = "INSERT INTO " + this.conec1.NombreTabla + " (id_ingreso,fecha_ingreso,farmaceutico_id_farmaceuta) VALUES ('"
                    + ingresomedicamento.Id_ingreso + "','" + ingresomedicamento.Fecha_ingreso + "', '" + ingresomedicamento.Farmaceutico_id_farmaceuta + "' );";
                this.conec1.EsSelect = false;
                this.conec1.conectar();
            }


            public DataSet retornarIngresoMedicamento(string id_ingreso)
            {
                this.configurarConexion();
                this.conec1.CadenaSQL = " SELECT * FROM " + this.conec1.NombreTabla + " WHERE id_ingreso = '" + id_ingreso + "';";
                this.conec1.EsSelect = true;
                this.conec1.conectar();
                return this.conec1.DbDataSet;
            }

            public IngresoMedicamento retornaPosicionIngresoMedicamento(int pos, string id_ingreso)
            {
                this.configurarConexion();
                this.Conec1.CadenaSQL = "SELECT * FROM " + this.conec1.NombreTabla + " WHERE id_ingreso = '" + id_ingreso + "';";

                this.conec1.EsSelect = true;
                this.Conec1.conectar();
            IngresoMedicamento auxIngresoMedicamento = new IngresoMedicamento();
                DataTable dt = new DataTable();
                dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
                try
                {
                auxIngresoMedicamento.Id_ingreso = (String)dt.Rows[pos]["id_ingreso"];
                auxIngresoMedicamento.Fecha_ingreso = (DateTime)dt.Rows[pos]["fecha_ingreso"];
                auxIngresoMedicamento.Farmaceutico_id_farmaceuta = (String)dt.Rows[pos]["Farmaceutico_id_farmaceuta"];
               



                }
                catch (Exception ex)
                {
                auxIngresoMedicamento.Id_ingreso = "";
                auxIngresoMedicamento.Fecha_ingreso = DateTime.Today;
                auxIngresoMedicamento.Farmaceutico_id_farmaceuta = "";




            }

            return auxIngresoMedicamento;
            }



            public IngresoMedicamento buscarIngresoMedicamento(String id_ingreso)
            {
                this.configurarConexion();
                this.Conec1.CadenaSQL = " SELECT * FROM " + this.Conec1.NombreTabla +
                    " WHERE id_ingreso = '" + id_ingreso + "';";
                this.conec1.EsSelect = true;
                this.conec1.conectar();
            IngresoMedicamento auxIngresoMedicamento = new IngresoMedicamento();
                DataTable dt = new DataTable();
                dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
                try
                {
                auxIngresoMedicamento.Id_ingreso = (String)dt.Rows[0]["id_ingreso"];
                auxIngresoMedicamento.Fecha_ingreso = (DateTime)dt.Rows[0]["fecha_ingreso"];
                auxIngresoMedicamento.Farmaceutico_id_farmaceuta = (String)dt.Rows[0]["Farmaceutico_id_farmaceuta"];





            }
            catch (Exception ex)
                {
                auxIngresoMedicamento.Id_ingreso = "";
                auxIngresoMedicamento.Fecha_ingreso = DateTime.Today;
                auxIngresoMedicamento.Farmaceutico_id_farmaceuta = "";


            }
                return auxIngresoMedicamento;
            }

            public void eliminarIngresoMedicamento(String id_ingreso)
            {
                this.configurarConexion();
                this.conec1.CadenaSQL = " DELETE FROM " + this.conec1.NombreTabla +
                    " WHERE id_ingreso = '" + id_ingreso + "';";
                this.conec1.EsSelect = false;
                this.conec1.conectar();
            }

            public void actualizarIngresoMedicamento(IngresoMedicamento ingresomedicamento)
            {
                this.configurarConexion();
                this.conec1.CadenaSQL = "UPDATE " + this.conec1.NombreTabla + " SET "
                    + " fecha_ingreso = '" + ingresomedicamento.Fecha_ingreso + "',farmaceutico_id_farmaceuta = " + ingresomedicamento.Farmaceutico_id_farmaceuta 
                    + "' WHERE id_ingreso = '" + ingresomedicamento.Id_ingreso + "';";
                this.conec1.EsSelect = false;
                this.conec1.conectar();
            }


            public IngresoMedicamento buscarIdIngresoMedicamento(String id_ingreso)
            {
                this.configurarConexion();
                this.Conec1.CadenaSQL = " SELECT * FROM " + this.Conec1.NombreTabla +
                    " WHERE id_ingreso = '" + id_ingreso + "';";
                this.conec1.EsSelect = true;
                this.conec1.conectar();
                IngresoMedicamento auxIngresoMedicamento = new IngresoMedicamento();
                DataTable dt = new DataTable();
                dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
                try
                {

                auxIngresoMedicamento.Id_ingreso = (String)dt.Rows[0]["id_ingreso"];
                auxIngresoMedicamento.Fecha_ingreso = (DateTime)dt.Rows[0]["fecha_ingreso"];
                auxIngresoMedicamento.Farmaceutico_id_farmaceuta = (String)dt.Rows[0]["Farmaceutico_id_farmaceuta"];


            }
                catch (Exception ex)
                {
                auxIngresoMedicamento.Id_ingreso = "";
                auxIngresoMedicamento.Fecha_ingreso = DateTime.Today;
                auxIngresoMedicamento.Farmaceutico_id_farmaceuta = "";





            }
                return auxIngresoMedicamento;

            }

        public IngresoMedicamento buscar_IngresoMedicamento(String id_ingreso)
            {
                this.configurarConexion();
                this.Conec1.CadenaSQL = " SELECT * FROM " + this.Conec1.NombreTabla +
                    " WHERE id_ingreso = '" + id_ingreso + "';";
                this.conec1.EsSelect = true;
                this.conec1.conectar();
            IngresoMedicamento auxIngresoMedicamento = new IngresoMedicamento();
                DataTable dt = new DataTable();
                dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
                try
                {
                auxIngresoMedicamento.Id_ingreso = (String)dt.Rows[0]["id_ingreso"];
                auxIngresoMedicamento.Fecha_ingreso = (DateTime)dt.Rows[0]["fecha_ingreso"];
                auxIngresoMedicamento.Farmaceutico_id_farmaceuta = (String)dt.Rows[0]["Farmaceutico_id_farmaceuta"];



            }
                catch (Exception ex)
                {
                auxIngresoMedicamento.Id_ingreso = "";
                auxIngresoMedicamento.Fecha_ingreso = DateTime.Today;
                auxIngresoMedicamento.Farmaceutico_id_farmaceuta = "";

            }
                return auxIngresoMedicamento;


            }

            public DataSet retornarTotalIngresoMedicamento()
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

