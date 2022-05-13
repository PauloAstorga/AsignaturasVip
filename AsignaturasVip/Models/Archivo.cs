using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AsignaturasVip.Models
{
    public class Archivo
    {
        private int id;
        private string nombre;
        private string tipo;
        private double peso;
        private bool visibilidad;
        private byte[] datos;

        public Archivo(int id, string nombre, string tipo, double peso, bool visibilidad, byte[] datos)
        {
            this.id = id;
            this.nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            this.tipo = tipo ?? throw new ArgumentNullException(nameof(tipo));
            this.peso = peso;
            this.visibilidad = visibilidad;
            this.datos = datos ?? throw new ArgumentNullException(nameof(datos));
        }

        public byte[] Datos
        {
            get { return datos; }
            set { datos = value; }
        }


        public bool Visibilidad
        {
            get { return visibilidad; }
            set { visibilidad = value; }
        }

        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }


        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
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