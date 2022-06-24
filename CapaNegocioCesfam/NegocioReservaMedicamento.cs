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
    public class NegocioReservaMedicamento
    {
        private ConexionCesfam conec1;

        public ConexionCesfam Conec1 { get => conec1; set => conec1 = value; }

        public void configurarConexion()
        {
            this.conec1 = new ConexionCesfam();
            this.conec1.NombreBaseDeDatos = "CESFAM";
            this.conec1.NombreTabla = "reserva_medicamento";
            this.conec1.CadenaConexion = @"Data Source=DESKTOP-UKNM7EP\SQLEXPRESS;Initial Catalog=CESFAM;Integrated Security=True";
        }

        public void insertarReservaMedicamento(ReservaMedicamento reservaMedicamento)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = "INSERT INTO " + this.conec1.NombreTabla + " (id_reserva,fecha_reserva,cantidad_reserva,farmaceutico_id_farmaceuta,medicamento_codigo) VALUES ('"
                + reservaMedicamento.Id_reserva + "','" + reservaMedicamento.Fecha_reserva + "'," + reservaMedicamento.Cantidad_reserva + ", '" + reservaMedicamento.Farmaceutico_id_farmaceuta + "', '" + reservaMedicamento.Medicamento_codigo + "' );";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }


        public DataSet retornarReservaMedicamento(string id_reserva)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " SELECT * FROM " + this.conec1.NombreTabla + " WHERE id_reserva = '" + id_reserva + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            return this.conec1.DbDataSet;
        }

        public ReservaMedicamento retornaPosicionReservaMedicamento(int pos, string id_reserva)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM " + this.conec1.NombreTabla + " WHERE id_reserva = '" + id_reserva + "';";
            this.conec1.EsSelect = true;
            this.Conec1.conectar();
            ReservaMedicamento auxReservaMedicamento = new ReservaMedicamento();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxReservaMedicamento.Id_reserva = (String)dt.Rows[pos]["id_reserva"];
                auxReservaMedicamento.Fecha_reserva = (DateTime)dt.Rows[pos]["fecha_reserva"];
                auxReservaMedicamento.Cantidad_reserva = (int)dt.Rows[pos]["cantidad_reserva"];
                auxReservaMedicamento.Farmaceutico_id_farmaceuta = (String)dt.Rows[pos]["farmaceutico_id_farmaceuta"];
                auxReservaMedicamento.Medicamento_codigo = (String)dt.Rows[pos]["medicamento_codigo"];


            }
            catch (Exception ex)
            {
                auxReservaMedicamento.Id_reserva = "";
                auxReservaMedicamento.Fecha_reserva = DateTime.Today;
                auxReservaMedicamento.Cantidad_reserva = 0;
                auxReservaMedicamento.Farmaceutico_id_farmaceuta ="";
                auxReservaMedicamento.Medicamento_codigo = "";

            }

            return auxReservaMedicamento;
        }



        public ReservaMedicamento buscarReservaMedicamento(String id_reserva)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = " SELECT * FROM " + this.Conec1.NombreTabla +
                " WHERE id_reserva = '" + id_reserva + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            ReservaMedicamento auxReservaMedicamento = new ReservaMedicamento();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
               
                auxReservaMedicamento.Id_reserva = (String)dt.Rows[0]["id_reserva"];
                auxReservaMedicamento.Fecha_reserva = (DateTime)dt.Rows[0]["fecha_reserva"];
                auxReservaMedicamento.Cantidad_reserva = (int)dt.Rows[0]["cantidad_reserva"];
                auxReservaMedicamento.Farmaceutico_id_farmaceuta = (String)dt.Rows[0]["farmaceutico_id_farmaceuta"];
                auxReservaMedicamento.Medicamento_codigo = (String)dt.Rows[0]["medicamento_codigo"];



            }
            catch (Exception ex)
            {
                 





            }
            return auxReservaMedicamento;
        }

        public void eliminarReservaMedicamento(String id_reserva)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " DELETE FROM " + this.conec1.NombreTabla +
                " WHERE id_reserva = '" + id_reserva + "';";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }

        public void actualizarReservaMedicamento(ReservaMedicamento reservamedicamento)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = "UPDATE " + this.conec1.NombreTabla + " SET "
                + " fecha_reserva = '" + reservamedicamento.Fecha_reserva + "',cantidad_reserva = " + reservamedicamento.Cantidad_reserva + "',farmaceutico_id_farmaceuta = " + reservamedicamento.Farmaceutico_id_farmaceuta + "', medicamento_codigo = " + reservamedicamento.Medicamento_codigo
                + "' WHERE id_reserva = '" + reservamedicamento.Id_reserva + "';";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }


        public ReservaMedicamento buscarIdReservaMedicamento(String id_reserva)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = " SELECT * FROM " + this.Conec1.NombreTabla +
                " WHERE id_reserva = '" + id_reserva + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            ReservaMedicamento auxReservaMedicamento = new ReservaMedicamento();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxReservaMedicamento.Id_reserva = (String)dt.Rows[0]["id_reserva"];
                auxReservaMedicamento.Fecha_reserva = (DateTime)dt.Rows[0]["fecha_reserva"];
                auxReservaMedicamento.Cantidad_reserva = (int)dt.Rows[0]["cantidad_reserva"];
                auxReservaMedicamento.Farmaceutico_id_farmaceuta = (String)dt.Rows[0]["farmaceutico_id_farmaceuta"];
                auxReservaMedicamento.Medicamento_codigo = (String)dt.Rows[0]["medicamento_codigo"];




            }
            catch (Exception ex)
            {
                auxReservaMedicamento.Id_reserva = "";
                auxReservaMedicamento.Fecha_reserva = DateTime.Today;
                auxReservaMedicamento.Cantidad_reserva = 0;
                auxReservaMedicamento.Farmaceutico_id_farmaceuta = "";
                auxReservaMedicamento.Medicamento_codigo = "";






            }
            return auxReservaMedicamento;

        }

        public ReservaMedicamento buscar_ReservaMedicamento(String id_reserva)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = " SELECT * FROM " + this.Conec1.NombreTabla +
                " WHERE id_reserva = '" + id_reserva + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            ReservaMedicamento auxReservaMedicamento = new ReservaMedicamento();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxReservaMedicamento.Id_reserva = (String)dt.Rows[0]["id_reserva"];
                auxReservaMedicamento.Fecha_reserva = (DateTime)dt.Rows[0]["fecha_reserva"];
                auxReservaMedicamento.Cantidad_reserva = (int)dt.Rows[0]["cantidad_reserva"];
                auxReservaMedicamento.Farmaceutico_id_farmaceuta = (String)dt.Rows[0]["farmaceutico_id_farmaceuta"];
                auxReservaMedicamento.Medicamento_codigo = (String)dt.Rows[0]["medicamento_codigo"];



            }
            catch (Exception ex)
            {
                auxReservaMedicamento.Id_reserva = "";
                auxReservaMedicamento.Fecha_reserva = DateTime.Today;
                auxReservaMedicamento.Cantidad_reserva = 0;
                auxReservaMedicamento.Farmaceutico_id_farmaceuta = "";
                auxReservaMedicamento.Medicamento_codigo = "";





            }
            return auxReservaMedicamento;


        }

        public DataSet retornarTotalReservaMedicamento()
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
