using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AsignaturasVip.Models
{
    public class Nota
    {
        private int id;
        private string contenido;

        public string Contenido
        {
            get { return contenido; }
            set { contenido = value; }
        }


        public int Id
        {
            get { return id; }
            set { id = value; }
        }

    }
}