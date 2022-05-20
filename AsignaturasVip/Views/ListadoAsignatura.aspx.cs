using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AsignaturasVip.Models;
using AsignaturasVip.Controllers;

namespace AsignaturasVip.Views
{
    public partial class ListadoAsignatura : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GrdLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            GrdLista.DataSource = from a in AsignaturaController.FindAll()
                                    select new
                                    {

                                        Codigo = a.Id.ToString(),
                                        Nombre = a.Nombre,
                                        Unidad = a.Unity.Nombre,
                                        Objetivos = a.Unity.Objetivos,
                                    };
            GrdLista.DataBind();
        }

        protected void LnkAsignaturas_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarAsignaturas.aspx");
        }

        protected void LnkSecciones_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListadoSecciones.aspx");
        }
    }

}
