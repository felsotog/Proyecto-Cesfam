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
     public class NegocioFichaPaciente
    {

        private ConexionCesfam conec1;

        public ConexionCesfam Conec1 { get => conec1; set => conec1 = value; }

        public void configurarConexion()
        {
            this.conec1 = new ConexionCesfam();
            this.conec1.NombreBaseDeDatos = "CESFAM";
            this.conec1.NombreTabla = "ficha_paciente";
            this.conec1.CadenaConexion = "Data Source=DESKTOP-DQKDMBV;Initial Catalog=CESFAM;Integrated Security=True";
        }

        public void insertarFichaPaciente(FichaPaciente fichapaciente)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = "INSERT INTO " + this.conec1.NombreTabla + " (id_ficha,descripcion,fecha_ficha,medico_rut_medico) VALUES ('"
                + fichapaciente.Id_ficha + "','" + fichapaciente.Descripcion + "', '" + fichapaciente.Fecha_ficha + "', '" + fichapaciente.Medico_rut_medico + "');";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }


        public DataSet retornarFichaPaciente(string id_ficha)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " SELECT * FROM " + this.conec1.NombreTabla + " WHERE id_ficha = '" + id_ficha + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            return this.conec1.DbDataSet;
        }

        public FichaPaciente retornaPosicionFichaPaciente(int pos, string id_ficha)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM " + this.conec1.NombreTabla + " WHERE id_ficha = '" + id_ficha + "';";

            this.conec1.EsSelect = true;
            this.Conec1.conectar();
            FichaPaciente auxFichaPaciente = new FichaPaciente();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxFichaPaciente.Id_ficha = (String)dt.Rows[pos]["id_ficha"];
                auxFichaPaciente.Descripcion = (String)dt.Rows[pos]["descripcion"];
                auxFichaPaciente.Fecha_ficha = (DateTime)dt.Rows[pos]["fecha_ficha"];
                auxFichaPaciente.Medico_rut_medico = (String)dt.Rows[pos]["medico_rut_medico"];



            }
            catch (Exception ex)
            {
                auxFichaPaciente.Id_ficha = "";
                auxFichaPaciente.Descripcion = "";
                auxFichaPaciente.Fecha_ficha = DateTime.Today;
                auxFichaPaciente.Medico_rut_medico = "";



            }

            return auxFichaPaciente;
        }



        public FichaPaciente buscarFichaPaciente(String id_ficha)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = " SELECT * FROM " + this.Conec1.NombreTabla +
                " WHERE id_ficha = '" + id_ficha + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            FichaPaciente auxFichaPaciente = new FichaPaciente();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxFichaPaciente.Id_ficha = (String)dt.Rows[0]["id_ficha"];
                auxFichaPaciente.Descripcion = (String)dt.Rows[0]["descripcion"];
                auxFichaPaciente.Fecha_ficha = (DateTime)dt.Rows[0]["fecha_ficha"];
                auxFichaPaciente.Medico_rut_medico = (String)dt.Rows[0]["medico_rut_medico"];




            }
            catch (Exception ex)
            {
                auxFichaPaciente.Id_ficha = "";
                auxFichaPaciente.Descripcion = "";
                auxFichaPaciente.Fecha_ficha = DateTime.Today;
                auxFichaPaciente.Medico_rut_medico = "";


            }
            return auxFichaPaciente;
        }

        public void eliminarFichaPaciente(String id_ficha)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " DELETE FROM " + this.conec1.NombreTabla +
                " WHERE id_ficha = '" + id_ficha + "';";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }

        public void actualizarFichaPaciente(FichaPaciente fichapaciente)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = "UPDATE " + this.conec1.NombreTabla + " SET "
                + " descripcion = '" + fichapaciente.Descripcion + "',fecha_ficha = " + fichapaciente.Fecha_ficha + "',medico_rut_medico = " + fichapaciente.Medico_rut_medico
                + "' WHERE id_ficha = '" + fichapaciente.Id_ficha + "';";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }


        public FichaPaciente buscarIdFichaPaciente(String id_ficha)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = " SELECT * FROM " + this.Conec1.NombreTabla +
                " WHERE id_ficha = '" + id_ficha + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            FichaPaciente auxFichaPaciente = new FichaPaciente();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {

                auxFichaPaciente.Id_ficha = (String)dt.Rows[0]["id_ficha"];
                auxFichaPaciente.Descripcion = (String)dt.Rows[0]["descripcion"];
                auxFichaPaciente.Fecha_ficha = (DateTime)dt.Rows[0]["fecha_ficha"];
                auxFichaPaciente.Medico_rut_medico = (String)dt.Rows[0]["medico_rut_medico"];


            }
            catch (Exception ex)
            {
                auxFichaPaciente.Id_ficha = "";
                auxFichaPaciente.Descripcion = "";
                auxFichaPaciente.Fecha_ficha = DateTime.Today;
                auxFichaPaciente.Medico_rut_medico = "";





            }
            return auxFichaPaciente;

        }

        public FichaPaciente buscar_FichaPaciente(String id_ficha)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = " SELECT * FROM " + this.Conec1.NombreTabla +
                " WHERE id_ficha = '" + id_ficha + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            FichaPaciente auxFichaPaciente = new FichaPaciente();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxFichaPaciente.Id_ficha = (String)dt.Rows[0]["id_ficha"];
                auxFichaPaciente.Descripcion = (String)dt.Rows[0]["descripcion"];
                auxFichaPaciente.Fecha_ficha = (DateTime)dt.Rows[0]["fecha_ficha"];
                auxFichaPaciente.Medico_rut_medico = (String)dt.Rows[0]["medico_rut_medico"];



            }
            catch (Exception ex)
            {
                auxFichaPaciente.Id_ficha = "";
                auxFichaPaciente.Descripcion = "";
                auxFichaPaciente.Fecha_ficha = DateTime.Today;
                auxFichaPaciente.Medico_rut_medico = "";


            }
            return auxFichaPaciente;


        }

        public DataSet retornarTotalFichaPaciente()
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

