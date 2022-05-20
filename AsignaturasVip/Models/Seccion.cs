using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AsignaturasVip.Models
{
    public class Seccion
    {
        private int id;
        private string nombre;
        private Asignatura asignatura;

        public Seccion(int id, string nombre, Asignatura asignatura)
        {
            this.id = id;
            this.nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            this.asignatura = asignatura ?? throw new ArgumentNullException(nameof(asignatura));
        }


        public Asignatura Asig
        {
            get { return asignatura; }
            set { asignatura = value; }
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