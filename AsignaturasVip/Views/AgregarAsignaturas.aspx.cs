using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AsignaturasVip.Controllers;
using AsignaturasVip.Models;

namespace AsignaturasVip.Views
{
    public partial class AgregarAsignaturas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void CargarDrop()
        {
            DropUnidad.DataSource = from u in UnidadController.FindAll()
                                        select new
                                        {
                                            Id = u.Id,
                                            Nombre = u.Nombre

                                        };
            DropUnidad.DataValueField = "Id";
            DropUnidad.DataTextField = "Nombre";
            DropUnidad.DataBind();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            LbMensaje.Text = AsignaturaController.AddAsignatura(TxtCodigo.Text, TxtNombre.Text, DropUnidad.SelectedValue);
        }
    }
}