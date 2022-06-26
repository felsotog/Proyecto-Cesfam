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
    public class NegocioAgendamiento
    {
        private ConexionCesfam conec1;

        public ConexionCesfam Conec1 { get => conec1; set => conec1 = value; }

        public void configurarConexion()
        {
            this.conec1 = new ConexionCesfam();
            this.conec1.NombreBaseDeDatos = "CESFAM";
            this.conec1.NombreTabla = "agendamiento";
            this.conec1.CadenaConexion = "Data Source=localhost;Initial Catalog=CESFAM;Integrated Security=True";
        }

        public void insertarAgendamiento(Agendamiento agendamiento)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = "INSERT INTO " + this.conec1.NombreTabla + " ( id_agendamiento,horario,paciente_rut,medico_rut_medico) VALUES ('"
                + agendamiento.Id_agendamiento + "','" + agendamiento.Horario + "', '" + agendamiento.Paciente_rut + "', '" + agendamiento.Medico_rut_medico + "');";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }


        public DataSet retornarAgendamiento(string id_agendamiento)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " SELECT * FROM " + this.conec1.NombreTabla + " WHERE id_agendamiento = '" + id_agendamiento + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            return this.conec1.DbDataSet;
        }

        public Agendamiento retornaPosicionAgendamiento(int pos, string id_agendamiento)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM " + this.conec1.NombreTabla + " WHERE id_agendamiento = '" + id_agendamiento + "';";

            this.conec1.EsSelect = true;
            this.Conec1.conectar();
            Agendamiento auxAgendamiento = new Agendamiento();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxAgendamiento.Id_agendamiento = (String)dt.Rows[pos]["id_agendamiento"];
                auxAgendamiento.Horario = (DateTime)dt.Rows[pos]["horario"];
                auxAgendamiento.Paciente_rut = (String)dt.Rows[pos]["paciente_rut"];
                auxAgendamiento.Medico_rut_medico = (String)dt.Rows[pos]["medico_rut_medico"];



            }
            catch (Exception ex)
            {
                auxAgendamiento.Id_agendamiento = "";
                auxAgendamiento.Horario = DateTime.Today;
                auxAgendamiento.Paciente_rut = "";
                auxAgendamiento.Medico_rut_medico = "";



            }

            return auxAgendamiento;
        }



        public Agendamiento buscarAgendamiento(String id_agendamiento)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = " SELECT * FROM " + this.Conec1.NombreTabla +
                " WHERE id_agendamiento = '" + id_agendamiento + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            Agendamiento auxAgendamiento = new Agendamiento();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxAgendamiento.Id_agendamiento = (String)dt.Rows[0]["id_agendamiento"];
                auxAgendamiento.Horario = (DateTime)dt.Rows[0]["horario"];
                auxAgendamiento.Paciente_rut = (String)dt.Rows[0]["paciente_rut"];
                auxAgendamiento.Medico_rut_medico = (String)dt.Rows[0]["medico_rut_medico"];



            }
            catch (Exception ex)
            {
                auxAgendamiento.Id_agendamiento = "";
                auxAgendamiento.Horario = DateTime.Today;
                auxAgendamiento.Paciente_rut = "";
                auxAgendamiento.Medico_rut_medico = "";


            }
            return auxAgendamiento;
        }

        public void eliminarAgendamiento(String id_agendamiento)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " DELETE FROM " + this.conec1.NombreTabla +
                " WHERE id_agendamiento = '" + id_agendamiento + "';";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }

        public void actualizarAgendamiento(Agendamiento agendamiento)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = "UPDATE " + this.conec1.NombreTabla + " SET "
                + " horario = '" + agendamiento.Horario + "',paciente_rut = " + agendamiento.Paciente_rut + "',medico_rut_medico = " + agendamiento.Medico_rut_medico
                + "' WHERE id_agendamiento = '" + agendamiento.Id_agendamiento + "';";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }


        public Agendamiento buscarIdAgendamiento(String id_agendamiento)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = " SELECT * FROM " + this.Conec1.NombreTabla +
                " WHERE id_agendamiento = '" + id_agendamiento + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            Agendamiento auxAgendamiento = new Agendamiento();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxAgendamiento.Id_agendamiento = (String)dt.Rows[0]["id_agendamiento"];
                auxAgendamiento.Horario = (DateTime)dt.Rows[0]["horario"];
                auxAgendamiento.Paciente_rut = (String)dt.Rows[0]["nombre"];
                auxAgendamiento.Medico_rut_medico = (String)dt.Rows[0]["medico_rut_medico"];



            }
            catch (Exception ex)
            {
                auxAgendamiento.Id_agendamiento = "";
                auxAgendamiento.Horario = DateTime.Today;
                auxAgendamiento.Paciente_rut = "";
                auxAgendamiento.Medico_rut_medico = "";





            }
            return auxAgendamiento;

        }

        public Agendamiento buscar_Agendamiento(String id_agendamiento)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = " SELECT * FROM " + this.Conec1.NombreTabla +
                " WHERE id_agendamiento = '" + id_agendamiento + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            Agendamiento auxAgendamiento = new Agendamiento();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxAgendamiento.Id_agendamiento = (String)dt.Rows[0]["id_agendamiento"];
                auxAgendamiento.Horario = (DateTime)dt.Rows[0]["horario"];
                auxAgendamiento.Paciente_rut = (String)dt.Rows[0]["paciente_rut"];
                auxAgendamiento.Medico_rut_medico = (String)dt.Rows[0]["medico_rut_medico"];



            }
            catch (Exception ex)
            {
                auxAgendamiento.Id_agendamiento = "";
                auxAgendamiento.Horario = DateTime.Today;
                auxAgendamiento.Paciente_rut = "";
                auxAgendamiento.Medico_rut_medico = "";


            }
            return auxAgendamiento;


        }

        public DataSet retornarTotalAgendamiento()
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





