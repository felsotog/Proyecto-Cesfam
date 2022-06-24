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
    public class NegocioDetalleFicha
    {
        private ConexionCesfam conec1;

        public ConexionCesfam Conec1 { get => conec1; set => conec1 = value; }

        public void configurarConexion()
        {
            this.conec1 = new ConexionCesfam();
            this.conec1.NombreBaseDeDatos = "CESFAM";
            this.conec1.NombreTabla = "detalle_ficha";
            this.conec1.CadenaConexion = @"Data Source=DESKTOP-UKNM7EP\SQLEXPRESS;Initial Catalog=CESFAM;Integrated Security=True";
        }

        public void insertarDetalleFicha(DetalleFicha detalleficha)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = "INSERT INTO " + this.conec1.NombreTabla + " (id_detalle_ficha,ficha_paciente_id_ficha,formulario_medicamento_id_formulario) VALUES ('"
                + detalleficha.Id_detalle_ficha + "','" + detalleficha.Ficha_paciente_id_ficha + "', '" + detalleficha.Formulario_medicamento_id_formulario + "');";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }


        public DataSet retornarDetalleFicha(string id_detalle_ficha)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " SELECT * FROM " + this.conec1.NombreTabla + " WHERE id_detalle_ficha = '" + id_detalle_ficha + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            return this.conec1.DbDataSet;
        }

        public DetalleFicha retornaPosicionDetalleFicha(int pos, string id_detalle_ficha)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM " + this.conec1.NombreTabla + " WHERE id_detalle_ficha = '" + id_detalle_ficha + "';";

            this.conec1.EsSelect = true;
            this.Conec1.conectar();
            DetalleFicha auxDetalleFicha = new DetalleFicha();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxDetalleFicha.Id_detalle_ficha = (String)dt.Rows[pos]["id_detalle_ficha"];
                auxDetalleFicha.Ficha_paciente_id_ficha = (String)dt.Rows[pos]["ficha_paciente_id_ficha"];
                auxDetalleFicha.Formulario_medicamento_id_formulario = (String)dt.Rows[pos]["formulario_medicamento_id_formulario"];



            }
            catch (Exception ex)
            {
                auxDetalleFicha.Id_detalle_ficha = "";
                auxDetalleFicha.Ficha_paciente_id_ficha = "";
                auxDetalleFicha.Formulario_medicamento_id_formulario = "";



            }

            return auxDetalleFicha;
        }



        public DetalleFicha buscarDetalleFicha(String id_detalle_ficha)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = " SELECT * FROM " + this.Conec1.NombreTabla +
                " WHERE id_detalle_ficha = '" + id_detalle_ficha + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            DetalleFicha auxDetalleFicha = new DetalleFicha();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxDetalleFicha.Id_detalle_ficha = (String)dt.Rows[0]["id_detalle_ficha"];
                auxDetalleFicha.Ficha_paciente_id_ficha = (String)dt.Rows[0]["ficha_paciente_id_ficha"];
                auxDetalleFicha.Formulario_medicamento_id_formulario = (String)dt.Rows[0]["formulario_medicamento_id_formulario"];



            }
            catch (Exception ex)
            {
                auxDetalleFicha.Id_detalle_ficha = "";
                auxDetalleFicha.Ficha_paciente_id_ficha = "";
                auxDetalleFicha.Formulario_medicamento_id_formulario = "";


            }
            return auxDetalleFicha;
        }

        public void eliminarDetalleFicha(String id_detalle_ficha)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " DELETE FROM " + this.conec1.NombreTabla +
                " WHERE id_detalle_ficha = '" + id_detalle_ficha + "';";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }

        public void actualizarDetalleFicha(DetalleFicha detalleficha)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = "UPDATE " + this.conec1.NombreTabla + " SET "
                + " ficha_paciente_id_ficha = '" + detalleficha.Ficha_paciente_id_ficha + "',formulario_medicamento_id_formulario = " + detalleficha.Formulario_medicamento_id_formulario
                + "' WHERE id_detalle_ficha = '" + detalleficha.Id_detalle_ficha + "';";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }


        public DetalleFicha buscarIdDetalleFicha(String id_detalle_ficha)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = " SELECT * FROM " + this.Conec1.NombreTabla +
                " WHERE id_detalle_ficha = '" + id_detalle_ficha + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            DetalleFicha auxDetalleFicha = new DetalleFicha();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxDetalleFicha.Id_detalle_ficha = (String)dt.Rows[0]["id_detalle_ficha"];
                auxDetalleFicha.Ficha_paciente_id_ficha = (String)dt.Rows[0]["ficha_paciente_id_ficha"];
                auxDetalleFicha.Formulario_medicamento_id_formulario = (String)dt.Rows[0]["formulario_medicamento_id_formulario"];



            }
            catch (Exception ex)
            {
                auxDetalleFicha.Id_detalle_ficha = "";
                auxDetalleFicha.Ficha_paciente_id_ficha = "";
                auxDetalleFicha.Formulario_medicamento_id_formulario = "";





            }
            return auxDetalleFicha;

        }

        public DetalleFicha buscar_DetalleFicha(String id_detalle_ficha)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = " SELECT * FROM " + this.Conec1.NombreTabla +
                " WHERE id_detalle_ficha = '" + id_detalle_ficha + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            DetalleFicha auxDetalleFicha = new DetalleFicha();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxDetalleFicha.Id_detalle_ficha = (String)dt.Rows[0]["id_detalle_ficha"];
                auxDetalleFicha.Ficha_paciente_id_ficha = (String)dt.Rows[0]["ficha_paciente_id_ficha"];
                auxDetalleFicha.Formulario_medicamento_id_formulario = (String)dt.Rows[0]["formulario_medicamento_id_formulario"];



            }
            catch (Exception ex)
            {
                auxDetalleFicha.Id_detalle_ficha = "";
                auxDetalleFicha.Ficha_paciente_id_ficha = "";
                auxDetalleFicha.Formulario_medicamento_id_formulario = "";


            }
            return auxDetalleFicha;


        }

        public DataSet retornarTotalDetalleFicha()
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