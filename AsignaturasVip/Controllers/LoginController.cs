using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AsignaturasVip.Models;

namespace AsignaturasVip.Controllers
{
    public class LoginController : Controller
    {
        public static Usuario Login(string correo, string password)
        {

            Usuario u = UsuarioController.FindUsuario(correo);
            if (u != null)
            {
                if (u.Password.Equals(password))
                {
                    return u;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }


        }
    }
}