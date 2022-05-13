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
        private Nota nota;

        public Seccion(int id, string nombre, Asignatura asignatura, Nota nota)
        {
            this.id = id;
            this.nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            this.asignatura = asignatura ?? throw new ArgumentNullException(nameof(asignatura));
            this.nota = nota ?? throw new ArgumentNullException(nameof(nota));
        }

        public Nota Note
        {
            get { return nota; }
            set { nota = value; }
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