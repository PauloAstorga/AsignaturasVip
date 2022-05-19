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
    public partial class IniciarSesion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void Btn1_Click(object sender, EventArgs e)
        {
            Usuario lgu = LoginController.Login(TxtCorreo.Text, TxtPass.Text);
            if (lgu != null)
            {
                Session["ActiveUser"] = lgu;
                LbInicio.Text = "Bienvenido " + lgu.Correo;
            }
            else
            {
                Session["ActiveUser"] = null;
                LbInicio.Text = "Credenciales Invalidas";
            }
        }
    }
}