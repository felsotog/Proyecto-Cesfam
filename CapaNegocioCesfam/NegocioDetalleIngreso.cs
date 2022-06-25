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
    public class NegocioDetalleIngreso
    {
        private ConexionCesfam conec1;

        public ConexionCesfam Conec1 { get => conec1; set => conec1 = value; }

        public void configurarConexion()
        {
            this.conec1 = new ConexionCesfam();
            this.conec1.NombreBaseDeDatos = "CESFAM";
            this.conec1.NombreTabla = "detalle_ingreso";
            this.conec1.CadenaConexion = "Data Source=DESKTOP-DQKDMBV;Initial Catalog=CESFAM;Integrated Security=True";
        }

        public void insertarDetalleIngreso(DetalleIngreso detalle_ingreso)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = "INSERT INTO " + this.conec1.NombreTabla + " (id_detalleingr,cantidad,fecha_elaboracion,fecha_vencimiento,medicamento_codigo,ingreso_medicamento_id_ingreso) VALUES ('"
                + detalle_ingreso.Id_detalleIngr + "'," + detalle_ingreso.Cantidad + ",'" + detalle_ingreso.Fecha_elaboracion + "','" + detalle_ingreso.Fecha_vencimiento + "','" + detalle_ingreso.Medicamento_codico + "', '" + detalle_ingreso.Ingreso_medicamento_id_ingreso + "');";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }


        public DataSet retornarDetalleIngreso(string id_detalleIngr)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " SELECT * FROM " + this.conec1.NombreTabla + " WHERE id_detalleingr = '" + id_detalleIngr + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            return this.conec1.DbDataSet;
        }

        public DetalleIngreso retornaPosicionDetalleIngreso(int pos, string id_detalle_Ingreso)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM " + this.conec1.NombreTabla + " WHERE id_detalleingr = '" + id_detalle_Ingreso + "';";

            this.conec1.EsSelect = true;
            this.Conec1.conectar();
            DetalleIngreso auxDetalleIngreso = new DetalleIngreso();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxDetalleIngreso.Id_detalleIngr = (String)dt.Rows[pos]["id_detalleingr"];
                auxDetalleIngreso.Cantidad = (int)dt.Rows[pos]["cantidad"];
                auxDetalleIngreso.Fecha_elaboracion = (DateTime)dt.Rows[pos]["fecha_elaboracion"];
                auxDetalleIngreso.Fecha_vencimiento = (DateTime)dt.Rows[pos]["fecha_vencimiento"];
                auxDetalleIngreso.Medicamento_codico = (String)dt.Rows[pos]["medicamento_codigo"];
                auxDetalleIngreso.Ingreso_medicamento_id_ingreso = (String)dt.Rows[pos]["ingreso_medicamento_id_ingreso"];



            }
            catch (Exception ex)
            {
                auxDetalleIngreso.Id_detalleIngr = "";
                auxDetalleIngreso.Cantidad = 0;
                auxDetalleIngreso.Fecha_elaboracion = DateTime.Today;
                auxDetalleIngreso.Fecha_vencimiento = DateTime.Today;
                auxDetalleIngreso.Medicamento_codico = "";
                auxDetalleIngreso.Ingreso_medicamento_id_ingreso = "";


            }

            return auxDetalleIngreso;
        }



        public DetalleIngreso buscarDetalleIngreso(String id_detalle_ingreso)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = " SELECT * FROM " + this.Conec1.NombreTabla +
                " WHERE id_detalleingr = '" + id_detalle_ingreso + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            DetalleIngreso auxDetalleIngreso = new DetalleIngreso();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxDetalleIngreso.Id_detalleIngr = (String)dt.Rows[0]["id_detalleingr"];
                auxDetalleIngreso.Cantidad = (int)dt.Rows[0]["cantidad"];
                auxDetalleIngreso.Fecha_elaboracion = (DateTime)dt.Rows[0]["fecha_elaboracion"];
                auxDetalleIngreso.Fecha_vencimiento = (DateTime)dt.Rows[0]["fecha_vencimiento"];
                auxDetalleIngreso.Medicamento_codico = (String)dt.Rows[0]["medicamento_codigo"];
                auxDetalleIngreso.Ingreso_medicamento_id_ingreso = (String)dt.Rows[0]["ingreso_medicamento_id_ingreso"];



            }
            catch (Exception ex)
            {
                auxDetalleIngreso.Id_detalleIngr = "";
                auxDetalleIngreso.Cantidad = 0;
                auxDetalleIngreso.Fecha_elaboracion = DateTime.Today;
                auxDetalleIngreso.Fecha_vencimiento = DateTime.Today;
                auxDetalleIngreso.Medicamento_codico = "";
                auxDetalleIngreso.Ingreso_medicamento_id_ingreso = "";




            }
            return auxDetalleIngreso;
        }

        public void eliminarDetalleIngreso(String id_detalle_ingreso)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " DELETE FROM " + this.conec1.NombreTabla +
                " WHERE id_detalleingr = '" + id_detalle_ingreso + "';";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }

        public void actualizarDetalleIngreso(DetalleIngreso detalleIngreso)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = "UPDATE " + this.conec1.NombreTabla + " SET "
                + "cantidad = '" + detalleIngreso.Cantidad + "',fecha_elaboracion = " + detalleIngreso.Fecha_elaboracion + ",fecha_vencimiento = " + detalleIngreso.Fecha_vencimiento + ",medicamento_codigo = '" + detalleIngreso.Medicamento_codico + ",ingreso_medicamento_id_ingreso = '" + detalleIngreso.Ingreso_medicamento_id_ingreso
                + "' WHERE id_detallaingr = '" + detalleIngreso.Id_detalleIngr + "';";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }


        public DetalleIngreso buscarIdDetalleIngreso(String id_detalle_ingreso)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = " SELECT * FROM " + this.Conec1.NombreTabla +
                " WHERE id_detalleingr = '" + id_detalle_ingreso + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            DetalleIngreso auxDetalleIngreso = new DetalleIngreso();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxDetalleIngreso.Id_detalleIngr = (String)dt.Rows[0]["id_detalleingr"];
                auxDetalleIngreso.Cantidad = (int)dt.Rows[0]["cantidad"];
                auxDetalleIngreso.Fecha_elaboracion = (DateTime)dt.Rows[0]["fecha_elaboracion"];
                auxDetalleIngreso.Fecha_vencimiento = (DateTime)dt.Rows[0]["fecha_vencimiento"];
                auxDetalleIngreso.Medicamento_codico = (String)dt.Rows[0]["medicamento_codigo"];
                auxDetalleIngreso.Ingreso_medicamento_id_ingreso = (String)dt.Rows[0]["ingreso_medicamento_id_ingreso"];

            }
            catch (Exception ex)
            {
                auxDetalleIngreso.Id_detalleIngr = "";
                auxDetalleIngreso.Cantidad = 0;
                auxDetalleIngreso.Fecha_elaboracion = DateTime.Today;
                auxDetalleIngreso.Fecha_vencimiento = DateTime.Today;
                auxDetalleIngreso.Medicamento_codico = "";
                auxDetalleIngreso.Ingreso_medicamento_id_ingreso = "";


            }
            return auxDetalleIngreso;

        }


        public DetalleIngreso buscarId_DetalleIngreso(String id_detalle_ingreso)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = " SELECT * FROM " + this.Conec1.NombreTabla +
                " WHERE id_detalleingr = '" + id_detalle_ingreso + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            DetalleIngreso auxDetalleIngreso = new DetalleIngreso();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxDetalleIngreso.Id_detalleIngr = (String)dt.Rows[0]["id_detalleingr"];
                auxDetalleIngreso.Cantidad = (int)dt.Rows[0]["cantidad"];
                auxDetalleIngreso.Fecha_elaboracion = (DateTime)dt.Rows[0]["fecha_elaboracion"];
                auxDetalleIngreso.Fecha_vencimiento = (DateTime)dt.Rows[0]["fecha_vencimiento"];
                auxDetalleIngreso.Medicamento_codico = (String)dt.Rows[0]["medicamento_codigo"];
                auxDetalleIngreso.Ingreso_medicamento_id_ingreso = (String)dt.Rows[0]["ingreso_medicamento_id_ingreso"];



            }
            catch (Exception ex)
            {
                auxDetalleIngreso.Id_detalleIngr = "";
                auxDetalleIngreso.Cantidad = 0;
                auxDetalleIngreso.Fecha_elaboracion = DateTime.Today;
                auxDetalleIngreso.Fecha_vencimiento = DateTime.Today;
                auxDetalleIngreso.Medicamento_codico = "";
                auxDetalleIngreso.Ingreso_medicamento_id_ingreso = "";





            }
            return auxDetalleIngreso;


        }

        public DataSet retornarTotalDetalleIngreso()
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

