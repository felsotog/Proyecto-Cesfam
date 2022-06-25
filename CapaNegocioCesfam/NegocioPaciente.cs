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
    public class NegocioPaciente
    {
        private ConexionCesfam conec1;

        public ConexionCesfam Conec1 { get => conec1; set => conec1 = value; }

        public void configurarConexion()
        {
            this.conec1 = new ConexionCesfam();
            this.conec1.NombreBaseDeDatos = "CESFAM";
            this.conec1.NombreTabla = "paciente";
            this.conec1.CadenaConexion = "Data Source=DESKTOP-DQKDMBV;Initial Catalog=CESFAM;Integrated Security=True";
        }

        public void insertarPaciente(Paciente paciente)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = "INSERT INTO " + this.conec1.NombreTabla + " ( rut, nombre_paciente, sector,telefono,direccion) VALUES ('"
                + paciente.Rut + "','" + paciente.Nombre_paciente + "', '" + paciente.Sector + "', " + paciente.Telefono + ", '" + paciente.Direccion +"');";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }


        public System.Data.DataSet retornarPaciente(string Rut)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " SELECT * FROM " + this.conec1.NombreTabla + " WHERE rut = '" + Rut + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            return this.conec1.DbDataSet;
        }

        public Paciente retornaPosicionPaciente(int pos, string Rut)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM " + this.conec1.NombreTabla + " WHERE rut = '" + Rut + "';";

            this.conec1.EsSelect = true;
            this.Conec1.conectar();
            Paciente auxPaciente = new Paciente();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxPaciente.Rut = (String)dt.Rows[pos]["rut"];
                auxPaciente.Nombre_paciente = (String)dt.Rows[pos]["nombre_paciente"];
                auxPaciente.Sector = (String)dt.Rows[pos]["sector"];
                auxPaciente.Telefono = (int)dt.Rows[pos]["telefono"];
                auxPaciente.Direccion = (String)dt.Rows[pos]["direccion"];




            }
            catch (Exception ex)
            {
                auxPaciente.Rut = "";
                auxPaciente.Nombre_paciente= "";
                auxPaciente.Sector= "";
                auxPaciente.Telefono = 0;
                auxPaciente.Direccion = "";





            }

            return auxPaciente;
        }



        public Paciente buscarPaciente(String Rut)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = " SELECT * FROM " + this.Conec1.NombreTabla +
                " WHERE rut = '" + Rut + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            Paciente auxPaciente = new Paciente();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxPaciente.Rut = (String)dt.Rows[0]["rut"];
                auxPaciente.Nombre_paciente = (String)dt.Rows[0]["nombre_paciente"];
                auxPaciente.Sector = (String)dt.Rows[0]["sector"];
                auxPaciente.Telefono = (int)dt.Rows[0]["telefono"];
                auxPaciente.Direccion = (String)dt.Rows[0]["direccion"];





            }
            catch (Exception ex)
            {
                auxPaciente.Rut = "";
                auxPaciente.Nombre_paciente = "";
                auxPaciente.Sector = "";
                auxPaciente.Telefono = 0;
                auxPaciente.Direccion = "";


            }
            return auxPaciente;
        }

        public void eliminarPaciente(String Rut)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " DELETE FROM " + this.conec1.NombreTabla +
                " WHERE rut = '" + Rut + "';";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }

        public void actualizarPaciente(Paciente paciente)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = "UPDATE " + this.conec1.NombreTabla + " SET "
                + " nombre_paciente = '" + paciente.Nombre_paciente + "',sector = " + paciente.Sector + "',telefono = " + paciente.Telefono + "',direccion = " + paciente.Direccion
                + "' WHERE rut = '" + paciente.Rut + "';";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }


        public Paciente buscarIdPaciente(String Rut)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = " SELECT * FROM " + this.Conec1.NombreTabla +
                " WHERE rut = '" + Rut + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            Paciente auxPaciente = new Paciente();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxPaciente.Rut = (String)dt.Rows[0]["rut"];
                auxPaciente.Nombre_paciente = (String)dt.Rows[0]["nombre_paciente"];
                auxPaciente.Sector = (String)dt.Rows[0]["sector"];
                auxPaciente.Telefono = (int)dt.Rows[0]["telefono"];
                auxPaciente.Direccion = (String)dt.Rows[0]["direccion"];


            }
            catch (Exception ex)
            {
                auxPaciente.Rut = "";
                auxPaciente.Nombre_paciente = "";
                auxPaciente.Sector = "";
                auxPaciente.Telefono = 0;
                auxPaciente.Direccion = "";






            }
            return auxPaciente;

        }

        public Paciente buscar_Paciente(String Rut)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = " SELECT * FROM " + this.Conec1.NombreTabla +
                " WHERE rut = '" + Rut + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            Paciente auxPaciente = new Paciente();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxPaciente.Rut = (String)dt.Rows[0]["rut"];
                auxPaciente.Nombre_paciente = (String)dt.Rows[0]["nombre_paciente"];
                auxPaciente.Sector = (String)dt.Rows[0]["sector"];
                auxPaciente.Telefono = (int)dt.Rows[0]["telefono"];
                auxPaciente.Direccion = (String)dt.Rows[0]["direccion"];

            }
            catch (Exception ex)
            {
                auxPaciente.Rut = "";
                auxPaciente.Nombre_paciente = "";
                auxPaciente.Sector = "";
                auxPaciente.Telefono = 0;
                auxPaciente.Direccion = "";




            }
            return auxPaciente;


        }

        public DataSet retornarTotalPaciente()
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
    
