using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocioCesfam;
using CapaDTOCesfam;
using CapaServicioCesfam;


namespace CapaPantallaCesfam
{
    public partial class PantallaFarmacia : Form
    {
        public PantallaFarmacia()
        {
            InitializeComponent();
        }

        public void limpiarIngreso()
        {
            this.txtIdCiudad.Text = "";
            this.txtIdFarmacia.Text = "";
            this.txtNombre.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

           

            
            Farmacia auxFarmacia = new Farmacia();
            auxFarmacia.Id_farmacia = this.txtIdFarmacia.Text;
            auxFarmacia.Nombre_farmacia = this.txtIdCiudad.Text;
            

            NegocioFarmacia auxNegocioFarmacia = new NegocioFarmacia();
            auxNegocioFarmacia.insertarFarmacia(auxFarmacia);
          

        }
    }
}
        
           
              