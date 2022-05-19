using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AsignaturasVip.Models
{
    public class Usuario
    {
            private int codigo;
            private string correo;
            private string password;
            private Rol rol;

            public Usuario()
            {
            }
            public Rol Rol
            {
                get { return rol; }
                set { rol = value; }
            }


            public string Password
            {
                get { return password; }
                set { password = value; }
            }


            public string Correo
            {
                get { return correo; }
                set { correo = value; }
            }


            public int Codigo
            {
                get { return codigo; }
                set { codigo = value; }
            }

        }
    }