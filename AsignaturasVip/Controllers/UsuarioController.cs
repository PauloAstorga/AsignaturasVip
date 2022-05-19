using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AsignaturasVip.Models;

namespace AsignaturasVip.Controllers
{
    public class UsuarioController : Controller
    {
        private static List<Usuario> listaUsuario = new List<Usuario>();

        public static string AddUsuario(int cod, string correo, string pass, Rol rol)
        {

            Usuario u = new Usuario()
            {
                Correo = correo,
                Codigo = cod,
                Password = pass,
                Rol = rol
            };

            listaUsuario.Add(u);
            return "Usuario Agregado con exito";
        }

        public static Usuario FindUsuario(string username)
        {

            foreach (Usuario item in listaUsuario)
            {
                if (item.Correo.Equals(username))
                {
                    return item;
                }
            }
            return null;
        }

        public static Usuario FindUsuario(int cod)
        {
            return null;
        }

        public static void FillUsuarios()
        {

            if (listaUsuario.Count < 1)
            {
                AddUsuario(10001, "Administrador@email.com", "12345", new Rol() { Codigo = 1, Nombre = "Administrador" });
                AddUsuario(20001, "Estudiante@email.com", "12345", new Rol() { Codigo = 2, Nombre = "Normal" });
            }

        }
    }
}