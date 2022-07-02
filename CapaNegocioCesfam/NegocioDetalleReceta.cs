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
    public class NegocioDetalleReceta
    {
        private ConexionCesfam conec1;

        public ConexionCesfam Conec1 { get => conec1; set => conec1 = value; }

        public void configurarConexion()
        {
            this.conec1 = new ConexionCesfam();
            this.conec1.NombreBaseDeDatos = "CESFAM";
            this.conec1.NombreTabla = "detalle_receta";
            this.conec1.CadenaConexion = "Data Source=localhost;Initial Catalog=CESFAM;Integrated Security=True";
        }

        public void insertarDetalleReceta(DetalleReceta detallereceta)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = "INSERT INTO " + this.conec1.NombreTabla + " ( id_detalle_receta,cantidad,paciente_rut,formulario_medicamento_id_formulario,medicamento_codigo) VALUES ('"
                + detallereceta.Id_detalle_receta + "'," + detallereceta.Cantidad + ", '" + detallereceta.Paciente_rut + "', '" + detallereceta.Formulario_medicamento_id_formulario + "', '" + detallereceta.Medicamento_codigo + "'); ";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }


        public DataSet retornarDetalleReceta(string id_Detalle_Receta)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " SELECT * FROM " + this.conec1.NombreTabla + " WHERE id_detalle_receta = '" + id_Detalle_Receta + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            return this.conec1.DbDataSet;
        }

        public DetalleReceta retornaPosicionDetalleReceta(int pos, string id_Detalle_Receta)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM " + this.conec1.NombreTabla + " WHERE id_detalle_receta = '" + id_Detalle_Receta + "';";

            this.conec1.EsSelect = true;
            this.Conec1.conectar();
            DetalleReceta auxDetalleReceta = new DetalleReceta();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxDetalleReceta.Id_detalle_receta = (String)dt.Rows[pos]["id_detalle_receta"];
                auxDetalleReceta.Cantidad = (int)dt.Rows[pos]["cantidad"];
                auxDetalleReceta.Paciente_rut = (String)dt.Rows[pos]["paciente_rut"];
                auxDetalleReceta.Formulario_medicamento_id_formulario = (String)dt.Rows[pos]["formulario_medicamento_id_formulario"];
                auxDetalleReceta.Medicamento_codigo = (String)dt.Rows[pos]["medicamento_codigo"];




            }
            catch (Exception ex)
            {
                auxDetalleReceta.Id_detalle_receta = "";
                auxDetalleReceta.Cantidad = 0;
                auxDetalleReceta.Paciente_rut = "";
                auxDetalleReceta.Formulario_medicamento_id_formulario = "";
                auxDetalleReceta.Medicamento_codigo = "";




            }

            return auxDetalleReceta;
        }



        public DetalleReceta buscarDetalleReceta(String id_detalle_receta)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = " SELECT * FROM " + this.Conec1.NombreTabla +
                " WHERE id_detalle_receta = '" + id_detalle_receta + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            DetalleReceta auxDetalleReceta = new DetalleReceta();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxDetalleReceta.Id_detalle_receta = (String)dt.Rows[0]["id_detalle_receta"];
                auxDetalleReceta.Cantidad = (int)dt.Rows[0]["cantidad"];
                auxDetalleReceta.Paciente_rut = (String)dt.Rows[0]["paciente_rut"];
                auxDetalleReceta.Formulario_medicamento_id_formulario = (String)dt.Rows[0]["formulario_medicamento_id_formulario"];
                auxDetalleReceta.Medicamento_codigo = (String)dt.Rows[0]["medicamento_codigo"];





            }
            catch (Exception ex)
            {
                auxDetalleReceta.Id_detalle_receta = "";
                auxDetalleReceta.Cantidad = 0;
                auxDetalleReceta.Paciente_rut = "";
                auxDetalleReceta.Formulario_medicamento_id_formulario = "";
                auxDetalleReceta.Medicamento_codigo = "";


            }
            return auxDetalleReceta;
        }

        public void eliminarDetalleReceta(String id_detalle_receta)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " DELETE FROM " + this.conec1.NombreTabla +
                " WHERE id_detalle_receta = '" + id_detalle_receta + "';";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }

        public void actualizarDetalleReceta(DetalleReceta detallereceta)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = "UPDATE " + this.conec1.NombreTabla + " SET "
                + " cantidad = '" + detallereceta.Cantidad + "',paciente= " + detallereceta.Paciente_rut + "',formulario_medicamento_id_formulario = " + detallereceta.Formulario_medicamento_id_formulario + "',medicamento_codigo " + detallereceta.Medicamento_codigo 
                + "' WHERE id_detalle_receta = '" + detallereceta.Id_detalle_receta + "';";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }


        public DetalleReceta buscarIdDetalleReceta(String id_detalle_receta)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = " SELECT * FROM " + this.Conec1.NombreTabla +
                " WHERE id_detalles_receta = '" + id_detalle_receta + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            DetalleReceta auxDetalleReceta = new DetalleReceta();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxDetalleReceta.Id_detalle_receta = (String)dt.Rows[0]["id_detalle_receta"];
                auxDetalleReceta.Cantidad = (int)dt.Rows[0]["cantidad"];
                auxDetalleReceta.Paciente_rut = (String)dt.Rows[0]["paciente_rut"];
                auxDetalleReceta.Formulario_medicamento_id_formulario = (String)dt.Rows[0]["formulario_medicamento_id_formulario"];
                auxDetalleReceta.Medicamento_codigo = (String)dt.Rows[0]["medicamento_codigo"];



            }
            catch (Exception ex)
            {
                auxDetalleReceta.Id_detalle_receta = "";
                auxDetalleReceta.Cantidad = 0;
                auxDetalleReceta.Paciente_rut = "";
                auxDetalleReceta.Formulario_medicamento_id_formulario = "";
                auxDetalleReceta.Medicamento_codigo = "";





            }
            return auxDetalleReceta;

        }

        public DetalleReceta buscar_DetalleReceta(String id_detalle_receta)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = " SELECT * FROM " + this.Conec1.NombreTabla +
                " WHERE id_detalle_receta = '" + id_detalle_receta+ "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            DetalleReceta auxDetalleReceta = new DetalleReceta();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxDetalleReceta.Id_detalle_receta = (String)dt.Rows[0]["id_detalle_receta"];
                auxDetalleReceta.Cantidad = (int)dt.Rows[0]["cantidad"];
                auxDetalleReceta.Paciente_rut = (String)dt.Rows[0]["paciente_rut"];
                auxDetalleReceta.Formulario_medicamento_id_formulario = (String)dt.Rows[0]["formulario_medicamento_id_formulario"];
                auxDetalleReceta.Medicamento_codigo = (String)dt.Rows[0]["medicamento_codigo"];



            }
            catch (Exception ex)
            {
                auxDetalleReceta.Id_detalle_receta = "";
                auxDetalleReceta.Cantidad = 0;
                auxDetalleReceta.Paciente_rut = "";
                auxDetalleReceta.Formulario_medicamento_id_formulario = "";
                auxDetalleReceta.Medicamento_codigo = "";



            }
            return auxDetalleReceta;


        }

        public DataSet retornarTotalDetalleReceta()
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

