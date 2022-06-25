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
    public class NegocioMedico
    {
        private ConexionCesfam conec1;

        public ConexionCesfam Conec1 { get => conec1; set => conec1 = value; }

        public void configurarConexion()
        {
            this.conec1 = new ConexionCesfam();
            this.conec1.NombreBaseDeDatos = "CESFAM";
            this.conec1.NombreTabla = "medico";
            this.conec1.CadenaConexion = "Data Source=DESKTOP-DQKDMBV;Initial Catalog=CESFAM;Integrated Security=True";
        }

        public void insertarMedico(Medico medico)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = "INSERT INTO " + this.conec1.NombreTabla + " (rut_medico,nombre_completo,especialidad,direccion,telefono,email) VALUES ('"
                + medico.Rut_medico + "','" + medico.Nombre_completo + "', '" + medico.Especialidad + "', '" + medico.Direccion + "', '" + medico.Telefono + "', '" + medico.Email + "');";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }


        public DataSet retornarMedico(string rut_medico)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " SELECT * FROM " + this.conec1.NombreTabla + " WHERE rut_medico = '" + rut_medico + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            return this.conec1.DbDataSet;
        }

        public Medico retornaPosicionMedico(int pos, string rut_medico)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM " + this.conec1.NombreTabla + " WHERE rut_medico = '" + rut_medico + "';";

            this.conec1.EsSelect = true;
            this.Conec1.conectar();
            Medico auxMedico = new Medico();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxMedico.Rut_medico = (String)dt.Rows[pos]["rut_medico"];
                auxMedico.Nombre_completo = (String)dt.Rows[pos]["nombre_completo"];
                auxMedico.Especialidad = (String)dt.Rows[pos]["especialidad"];
                auxMedico.Direccion = (String)dt.Rows[pos]["direccion"];
                auxMedico.Telefono = (String)dt.Rows[pos]["telefono"];
                auxMedico.Email = (String)dt.Rows[pos]["email"];

            }
            catch (Exception ex)
            {
                auxMedico.Rut_medico = "";
                auxMedico.Nombre_completo = "";
                auxMedico.Especialidad = "";
                auxMedico.Direccion = "";
                auxMedico.Telefono = "";
                auxMedico.Email = "";



            }

            return auxMedico;
        }



        public Medico buscarMedico(String rut_medico)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = " SELECT * FROM " + this.Conec1.NombreTabla +
                " WHERE rut_medico = '" + rut_medico + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            Medico auxMedico = new Medico();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxMedico.Rut_medico = (String)dt.Rows[0]["rut_medico"];
                auxMedico.Nombre_completo = (String)dt.Rows[0]["nombre_completo"];
                auxMedico.Especialidad = (String)dt.Rows[0]["especialidad"];
                auxMedico.Direccion = (String)dt.Rows[0]["direccion"];
                auxMedico.Telefono = (String)dt.Rows[0]["telefono"];
                auxMedico.Email = (String)dt.Rows[0]["email"];


            }
            catch (Exception ex)
            {
                auxMedico.Rut_medico = "";
                auxMedico.Nombre_completo = "";
                auxMedico.Especialidad = "";
                auxMedico.Direccion = "";
                auxMedico.Telefono = "";
                auxMedico.Email = "";

            }
            return auxMedico;
        }

        public void eliminarMedico(String rut_medico)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " DELETE FROM " + this.conec1.NombreTabla +
                " WHERE rut_medico = '" + rut_medico + "';";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }

        public void actualizarMedico(Medico medico)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = "UPDATE " + this.conec1.NombreTabla + " SET "
                + " nombre_completo = '" + medico.Nombre_completo + "',especialidad = " + medico.Especialidad + "',direccion = " + medico.Direccion + "',telefono = " + medico.Telefono + "',email = " + medico.Email
                + "' WHERE rut_medico = '" + medico.Rut_medico + "';";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }


        public Medico buscarIdMedico(String rut_medico)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = " SELECT * FROM " + this.Conec1.NombreTabla +
                " WHERE rut_medico = '" + rut_medico + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            Medico auxMedico = new Medico();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxMedico.Rut_medico = (String)dt.Rows[0]["rut_medico"];
                auxMedico.Nombre_completo = (String)dt.Rows[0]["nombre_completo"];
                auxMedico.Especialidad = (String)dt.Rows[0]["especialidad"];
                auxMedico.Direccion = (String)dt.Rows[0]["direccion"];
                auxMedico.Telefono = (String)dt.Rows[0]["telefono"];
                auxMedico.Email = (String)dt.Rows[0]["email"];

            }
            catch (Exception ex)
            {
                auxMedico.Rut_medico = "";
                auxMedico.Nombre_completo = "";
                auxMedico.Especialidad = "";
                auxMedico.Direccion = "";
                auxMedico.Telefono = "";
                auxMedico.Email = "";

            }
            return auxMedico;

        }



        public DataSet retornarTotalMedico()
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

