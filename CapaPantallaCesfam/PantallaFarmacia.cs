using CapaDTOCesfam;
using CapaNegocioCesfam;
using System;
using System.Windows.Forms;

namespace CapaPantallaCesfam
{
    public partial class PantallaFarmacia : Form
    {
        public PantallaFarmacia()
        {
            InitializeComponent();
        }

        private void LimpiarIngreso()
        {
            txtIdFarmacia.Clear();
            txtNombre.Clear();
            txtIdFarmacia.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarFormulario()) return;

            btnGuardar.Enabled = false;
            try
            {
                var farmacia = new Farmacia
                {
                    Id_farmacia = txtIdFarmacia.Text.Trim(),
                    Nombre_farmacia = txtNombre.Text.Trim()
                };

                new NegocioFarmacia().insertarFarmacia(farmacia);
                MessageBox.Show(
                    "La farmacia se guardó correctamente.",
                    "Registro completado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                LimpiarIngreso();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No fue posible guardar la farmacia.\n\n" + ex.Message,
                    "Error al guardar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                btnGuardar.Enabled = true;
            }
        }

        private bool ValidarFormulario()
        {
            if (string.IsNullOrWhiteSpace(txtIdFarmacia.Text))
                return MostrarCampoRequerido(txtIdFarmacia, "Ingresa el código de la farmacia.");

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
                return MostrarCampoRequerido(txtNombre, "Ingresa el nombre de la farmacia.");

            return true;
        }

        private static bool MostrarCampoRequerido(Control control, string mensaje)
        {
            MessageBox.Show(mensaje, "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            control.Focus();
            return false;
        }
    }
}
