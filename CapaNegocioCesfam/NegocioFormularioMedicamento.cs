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
   public class NegocioFormularioMedicamento
    {
        private ConexionCesfam conec1;

        public ConexionCesfam Conec1 { get => conec1; set => conec1 = value; }

        public void configurarConexion()
        {
            this.conec1 = new ConexionCesfam();
            this.conec1.NombreBaseDeDatos = "CESFAM";
            this.conec1.NombreTabla = "formulario_medicamento";
            this.conec1.CadenaConexion = "Data Source=localhost;Initial Catalog=CESFAM;Integrated Security=True";
        }

        public void insertarFormularioMedicamento(FormularioMedicamento formulariomedicamento)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = "INSERT INTO " + this.conec1.NombreTabla + " (id_formulario,fecha_receta,medico_rut_medico) VALUES ('"
                + formulariomedicamento.Id_formulario + "','" + formulariomedicamento.Fecha_receta + "', '" + formulariomedicamento.Medico_rut_medico +  "');";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }


        public System.Data.DataSet retornarFormularioMedicamento(string id_formulario)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " SELECT * FROM " + this.conec1.NombreTabla + " WHERE id_formulario = '" + id_formulario + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            return this.conec1.DbDataSet;
        }

        public FormularioMedicamento retornaPosicionFormularioMedicamento(int pos, string id_formulario)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM " + this.conec1.NombreTabla + " WHERE id_formulario = '" + id_formulario + "';";

            this.conec1.EsSelect = true;
            this.Conec1.conectar();
            FormularioMedicamento auxFormularioMedicamento = new FormularioMedicamento();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxFormularioMedicamento.Id_formulario = (String)dt.Rows[pos]["id_formulario"];
                auxFormularioMedicamento.Fecha_receta = (DateTime)dt.Rows[pos]["fecha_receta"];
                auxFormularioMedicamento.Medico_rut_medico = (String)dt.Rows[pos]["medico_rut_medico"];
                




            }
            catch (Exception ex)
            {
                auxFormularioMedicamento.Id_formulario = "";
                auxFormularioMedicamento.Fecha_receta = DateTime.Today;
                auxFormularioMedicamento.Medico_rut_medico = "";
                




            }

            return auxFormularioMedicamento;
        }



        public FormularioMedicamento buscarFormularioMedicamento(String id_formulario)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = " SELECT * FROM " + this.Conec1.NombreTabla +
                " WHERE id_formulario = '" + id_formulario + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            FormularioMedicamento auxFormularioMedicamento = new FormularioMedicamento();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxFormularioMedicamento.Id_formulario = (String)dt.Rows[0]["id_formulario"];
                auxFormularioMedicamento.Fecha_receta = (DateTime)dt.Rows[0]["fecha_receta"];
                auxFormularioMedicamento.Medico_rut_medico = (String)dt.Rows[0]["medico_rut_medico"];





            }
            catch (Exception ex)
            {
                auxFormularioMedicamento.Id_formulario = "";
                auxFormularioMedicamento.Fecha_receta = DateTime.Today;
                auxFormularioMedicamento.Medico_rut_medico = "";


            }
            return auxFormularioMedicamento;
        }

        public void eliminarFormularioMedicamento(String id_formulario)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " DELETE FROM " + this.conec1.NombreTabla +
                " WHERE id_formulario = '" + id_formulario + "';";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }

        public void actualizarFormularioMedicamento(FormularioMedicamento formulariomedicamento)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = "UPDATE " + this.conec1.NombreTabla + " SET "
                + " fecha_receta = '" + formulariomedicamento.Fecha_receta + "',medico_rut_medico = " + formulariomedicamento.Medico_rut_medico 
                + "' WHERE id_formulario= '" + formulariomedicamento.Id_formulario + "';";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }


        public FormularioMedicamento buscarIdFormularioMedicamento(String id_formulario)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = " SELECT * FROM " + this.Conec1.NombreTabla +
                " WHERE id_formulario = '" + id_formulario + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            FormularioMedicamento auxFormularioMedicamento = new FormularioMedicamento();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxFormularioMedicamento.Id_formulario = (String)dt.Rows[0]["id_formulario"];
                auxFormularioMedicamento.Fecha_receta = (DateTime)dt.Rows[0]["fecha_receta"];
                auxFormularioMedicamento.Medico_rut_medico = (String)dt.Rows[0]["medico_rut_medico"];


            }
            catch (Exception ex)
            {
                auxFormularioMedicamento.Id_formulario = "";
                auxFormularioMedicamento.Fecha_receta = DateTime.Today;
                auxFormularioMedicamento.Medico_rut_medico = "";






            }
            return auxFormularioMedicamento;

        }

        public FormularioMedicamento buscar_FormularioMedicamento(String id_formulario)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = " SELECT * FROM " + this.Conec1.NombreTabla +
                " WHERE id_formulario = '" + id_formulario + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            FormularioMedicamento auxFormularioMedicamento = new FormularioMedicamento();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxFormularioMedicamento.Id_formulario = (String)dt.Rows[0]["id_formulario"];
                auxFormularioMedicamento.Fecha_receta = (DateTime)dt.Rows[0]["fecha_receta"];
                auxFormularioMedicamento.Medico_rut_medico = (String)dt.Rows[0]["medico_rut_medico"];

            }
            catch (Exception ex)
            {
                auxFormularioMedicamento.Id_formulario = "";
                auxFormularioMedicamento.Fecha_receta = DateTime.Today;
                auxFormularioMedicamento.Medico_rut_medico = "";




            }
            return auxFormularioMedicamento;


        }

        public DataSet retornarTotalFormularioMedicamento()
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

