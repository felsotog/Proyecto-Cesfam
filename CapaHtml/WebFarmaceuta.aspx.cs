using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaHtml
{

    public partial class WebFarmaceuta : System.Web.UI.Page
    {
        public void LimpiarIngreso()
        {
            this.txtIdfarmaceuta.Text = "";
            this.txtNombreFarmaceuta.Text = "";
            this.DropDownListidfarmacia.Text = "";

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            this.GridView1.DataBind();
        }

        protected void btnFarmacia_Click(object sender, EventArgs e)
        {
            ServiceMantenedorFarmaceutico.WebServiceFarmaceuticoSoapClient auxNegocioFarmaceutico = new ServiceMantenedorFarmaceutico.WebServiceFarmaceuticoSoapClient();
            ServiceMantenedorFarmaceutico.Farmaceutico auxFarmaceutico = new ServiceMantenedorFarmaceutico.Farmaceutico();




            if (String.IsNullOrEmpty(auxNegocioFarmaceutico.buscarFarmaceuticoService(auxFarmaceutico.Id_farmaceuta).Id_farmaceuta))
            {
                try
                {


                    auxFarmaceutico.Id_farmaceuta = this.txtIdfarmaceuta.Text;
                    auxFarmaceutico.Nombre_farmaceuta = this.txtNombreFarmaceuta.Text;
                    auxFarmaceutico.Farmacia_id_farmacia = this.DropDownListidfarmacia.SelectedValue;



                    if (String.IsNullOrEmpty(auxNegocioFarmaceutico.buscarFarmaceuticoService(auxFarmaceutico.Id_farmaceuta).Id_farmaceuta))
                    {

                        if (string.IsNullOrEmpty(this.txtIdfarmaceuta.Text) || string.IsNullOrEmpty(this.txtNombreFarmaceuta.Text) || string.IsNullOrEmpty(this.DropDownListidfarmacia.Text))

                        {
                            //this.LabelMensaje1.Text = "complete todos los campos";
                        }
                        else
                        {
                            auxNegocioFarmaceutico.insertaFarmaceuticoService(auxFarmaceutico);
                            this.LimpiarIngreso();

                            //this.LabelMensaje1.Text = "datos guardados correctamente";
                            this.GridView1.DataBind();



                        }
                    }
                    else
                    {
                        //this.LabelMensaje1.Text = "ingreso Farmaceuta ya existe";
                    }
                }
                catch (Exception ex)
                {
                    //this.LabelMensaje1.Text = "error al guardar";
                }

            }
        }
    }
}