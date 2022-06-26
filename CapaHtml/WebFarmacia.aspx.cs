using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaHtml
{
    public partial class WebFarmacia : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            this.lblError.Text = "";
            this.lblSucces.Text = "";
        }

        public void LimpiarIngreso()
        {
            this.txtIdFarmacia.Text = "";
            this.txtNombreFarmacia.Text = "";
        }

        protected void btnFarmacia_Click(object sender, EventArgs e)
        {
            ServiceMantenedorFarmacia.WebServiceFarmaciaSoapClient auxNegocioFarmacia = new ServiceMantenedorFarmacia.WebServiceFarmaciaSoapClient();
            ServiceMantenedorFarmacia.Farmacia auxFarmacia = new ServiceMantenedorFarmacia.Farmacia();

            auxFarmacia.Id_farmacia = this.txtIdFarmacia.Text;
            auxFarmacia.Nombre_farmacia = this.txtNombreFarmacia.Text;

            if (String.IsNullOrEmpty(auxNegocioFarmacia.buscarFarmaciaService(auxFarmacia.Id_farmacia).Id_farmacia))
            {
                try
                {
                    if (String.IsNullOrEmpty(auxNegocioFarmacia.buscarFarmaciaService(auxFarmacia.Id_farmacia).Id_farmacia))
                    {

                        if (string.IsNullOrEmpty(this.txtIdFarmacia.Text) || string.IsNullOrEmpty(this.txtNombreFarmacia.Text))

                        {
                            this.lblError.Text = "complete todos los campos";
                        }
                        else
                        {
                            auxNegocioFarmacia.insertaFarmaciaService(auxFarmacia);
                            this.LimpiarIngreso();

                            this.lblSucces.Text = "datos guardados correctamente";
                            this.GridView1.DataBind();
                        }
                    }
                    else
                    {
                        this.lblSucces.Text = "ingreso Farmaceuta ya existe";
                    }
                }
                catch (Exception ex)
                {
                    this.lblSucces.Text = "error al guardar";
                }

                

            }
        }

        protected void Volver_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebPaginaPrincipal.aspx");
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged1(object sender, EventArgs e)
        {

        }
    }
}