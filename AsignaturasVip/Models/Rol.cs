using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AsignaturasVip.Models
{
    public class Rol
    {
        private int codigo;
        private string nombre;
        public Rol()
        {
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
    }
}