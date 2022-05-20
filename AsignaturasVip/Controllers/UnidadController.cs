using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AsignaturasVip.Models;

namespace AsignaturasVip.Controllers
{
    public class UnidadController
    {
        public static List<Unidad> listUnidad = new List<Unidad>();

        public static string AddUnidad(string id, string nombre, string objetivos)
        {

            try
            {
                Unidad u = new Unidad()
                {

                    Nombre = nombre,
                    Objetivos = objetivos,
                    Id = int.Parse(id)
                };

                listUnidad.Add(u);
                return "Unidad Agregada correctamente.";

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public static Unidad Find(int id)
        {
            foreach (Unidad item in listUnidad)
            {
                if (id == item.Id)
                {
                    return item;
                }
            }
            return null;

        }
        public static List<Unidad> FindAll()
        {
            return listUnidad;
        }


        public static void PrecargaUnidad()
        {
            if (listUnidad.Count < 1)
            {
                AddUnidad("1", "Unidad 1 Diseño con CSS", "Diseñar Páginas web y darles estilo");
                AddUnidad("2", "Unidad 2 Base de datos", "Diseñar Diseñar bases de datos");
                AddUnidad("3", "Unidad 1 Introduccion a Base de datos", "Introducir conceptos de bases de datos");
            }


        }
    }
}
