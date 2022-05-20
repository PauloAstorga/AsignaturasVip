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
    public partial class AgregarSecciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CargarDrop()
        {
            DropAsignatura.DataSource = from a in AsignaturaController.FindAll()
                                        select new
                                        {
                                           Id = a.Id,
                                           Nombre = a.Nombre
                                          
                                        };
            DropAsignatura.DataValueField = "Id";
            DropAsignatura.DataTextField = "Nombre";
            DropAsignatura.DataBind();
        }

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
                LbMensaje.Text = SeccionController.AddSeccion(TxtCodigo.Text, TxtNombre.Text, DropAsignatura.SelectedValue);
            
        }
    }
}