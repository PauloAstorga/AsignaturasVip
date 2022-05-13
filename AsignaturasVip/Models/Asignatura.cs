using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AsignaturasVip.Models
{
    public class Asignatura
    {

        private int id;
        private string nombre;
        private Unidad unidad;

        public Asignatura(int id, string nombre, Unidad unidad)
        {
            this.id = id;
            this.nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            this.unidad = unidad ?? throw new ArgumentNullException(nameof(unidad));
        }

        public Unidad Unity
        {
            get { return unidad; }
            set { unidad = value; }
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