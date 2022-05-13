using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AsignaturasVip.Models
{
    public class Unidad
    {
        private int id;
        private string nombre;
        private string objetivos;
        private Archivo archivo;

        public Archivo Archive
        {
            get { return archivo; }
            set { archivo = value; }
        }


        public string Objetivos
        {
            get { return objetivos; }
            set { objetivos = value; }
        }


        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public int Id
        {
            get { return id; }
            set { id = value; }
        }


    }
}