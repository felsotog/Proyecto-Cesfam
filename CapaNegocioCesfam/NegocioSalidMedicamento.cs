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
    public class NegocioSalidaMedicamento
    {
        private ConexionCesfam conec1;

        public ConexionCesfam Conec1 { get => conec1; set => conec1 = value; }

        public void configurarConexion()
        {
            this.conec1 = new ConexionCesfam();
            this.conec1.NombreBaseDeDatos = "CESFAM";
            this.conec1.NombreTabla = "salida_medicamento";
            this.conec1.CadenaConexion = "Data Source=DESKTOP-DQKDMBV;Initial Catalog=CESFAM;Integrated Security=True";
        }

        public void insertarSalidaMedicamento(SalidaMedicamento salida_medicamento)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = "INSERT INTO " + this.conec1.NombreTabla + " (id_salida,fecha_salida,farmaceutico_id_farmaceuta,paciente_rut) VALUES ('"
                + salida_medicamento.Id_salida + "','" + salida_medicamento.Fecha_salida + "', '" + salida_medicamento.Farmaceutico_id_farmaceuta + "', '" + salida_medicamento.Paciente_rut + "');";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }


        public DataSet retornarSalidaMedicamento(string id_salida)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " SELECT * FROM " + this.conec1.NombreTabla + " WHERE id_salida = '" + id_salida + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            return this.conec1.DbDataSet;
        }

        public SalidaMedicamento retornaPosicionSalidaMedicamento(int pos, string id_salida)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM " + this.conec1.NombreTabla + " WHERE id_salida = '" + id_salida + "';";

            this.conec1.EsSelect = true;
            this.Conec1.conectar();
            SalidaMedicamento auxSalidaMedicamento = new SalidaMedicamento();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxSalidaMedicamento.Id_salida = (String)dt.Rows[pos]["id_salida"];
                auxSalidaMedicamento.Fecha_salida = (DateTime)dt.Rows[pos]["fecha_salida"];
                auxSalidaMedicamento.Farmaceutico_id_farmaceuta = (String)dt.Rows[pos]["farmaceutico_id_farmaceuta"];
                auxSalidaMedicamento.Paciente_rut = (String)dt.Rows[pos]["paciente_rut"];



            }
            catch (Exception ex)
            {
                auxSalidaMedicamento.Id_salida = "";
                auxSalidaMedicamento.Fecha_salida = DateTime.Today;
                auxSalidaMedicamento.Farmaceutico_id_farmaceuta = "";
                auxSalidaMedicamento.Paciente_rut = "";



            }

            return auxSalidaMedicamento;
        }



        public SalidaMedicamento buscarSalidaMedicamento(String id_salida)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = " SELECT * FROM " + this.Conec1.NombreTabla +
                " WHERE id_salida = '" + id_salida + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            SalidaMedicamento auxSalidaMedicamento = new SalidaMedicamento();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxSalidaMedicamento.Id_salida = (String)dt.Rows[0]["id_salida"];
                auxSalidaMedicamento.Fecha_salida = (DateTime)dt.Rows[0]["fecha_salida"];
                auxSalidaMedicamento.Farmaceutico_id_farmaceuta = (String)dt.Rows[0]["farmaceutico_id_farmaceuta"];
                auxSalidaMedicamento.Paciente_rut = (String)dt.Rows[0]["paciente_rut"];


            }
            catch (Exception ex)
            {
                auxSalidaMedicamento.Id_salida = "";
                auxSalidaMedicamento.Fecha_salida = DateTime.Today;
                auxSalidaMedicamento.Farmaceutico_id_farmaceuta = "";
                auxSalidaMedicamento.Paciente_rut = "";

            }
            return auxSalidaMedicamento;
        }

        public void eliminarSalidaMedicamento(String id_salida)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " DELETE FROM " + this.conec1.NombreTabla +
                " WHERE id_salida = '" + id_salida + "';";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }

        public void actualizarSalidaMedicamento(SalidaMedicamento salida_medicamento)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = "UPDATE " + this.conec1.NombreTabla + " SET "
                + " fecha_salida = '" + salida_medicamento.Fecha_salida + "',farmaceutico_id_farmaceuta = " + salida_medicamento.Farmaceutico_id_farmaceuta
                + "' WHERE id_salida = '" + salida_medicamento.Id_salida + "';";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }


        public SalidaMedicamento buscarIdSalidaMedicamento(String id_salida)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = " SELECT * FROM " + this.Conec1.NombreTabla +
                " WHERE id_salida = '" + id_salida + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            SalidaMedicamento auxSalidaMedicamento = new SalidaMedicamento();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxSalidaMedicamento.Id_salida = (String)dt.Rows[0]["id_salida"];
                auxSalidaMedicamento.Fecha_salida = (DateTime)dt.Rows[0]["fecha_salida"];
                auxSalidaMedicamento.Farmaceutico_id_farmaceuta = (String)dt.Rows[0]["farmaceutico_id_farmaceuta"];
                auxSalidaMedicamento.Paciente_rut = (String)dt.Rows[0]["paciente_rut"];

            }
            catch (Exception ex)
            {
                auxSalidaMedicamento.Id_salida = "";
                auxSalidaMedicamento.Fecha_salida = DateTime.Today;
                auxSalidaMedicamento.Farmaceutico_id_farmaceuta = "";
                auxSalidaMedicamento.Paciente_rut = "";

            }
            return auxSalidaMedicamento;

        }

        


        

        public DataSet retornarTotalSalidaMedicamento()
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

