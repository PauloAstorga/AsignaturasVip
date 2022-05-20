using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AsignaturasVip.Models;

namespace AsignaturasVip.Controllers
{
    public class SeccionController
    {
        public static List<Seccion> listaSecciones = new List<Seccion>();

        public static string AddSeccion(string id, string nombre, string asignatura)
        {
            try
            {
                int idSeccion = int.Parse(id);
                Asignatura asig = AsignaturaController.Find(id);
                if (asig != null)
                {
                    Seccion seccion = new Seccion(idSeccion, nombre, asig);
                    listaSecciones.Add(seccion);
                    return "La Seccion se guardó exitosamente";
                }
                else
                {
                    return "Error";
                }
            }
            catch (Exception ex)
            {
                
                return "Error";
                throw;
            }
        }

        public static Seccion Find(string id)
        {
            foreach (Seccion seccion in listaSecciones)
            {
                try
                {
                    if (seccion.Id == int.Parse(id))
                    {
                        return seccion;
                    }
                }
                catch (Exception)
                {
                    return null;
                    throw;
                }

            }
            return null;
        }

        public static string EditSeccion(string id, string nombre, Asignatura asignatura)
        {
            try
            {
                Seccion seccion = Find(id);

                seccion.Nombre = nombre;
                seccion.Asig = asignatura;
                return "Sección modificada exitosamente";
            }
            catch (Exception ex)
            {
                if (ex is InvalidCastException)
                {
                    return "Valor no válido para editar";
                }

                return "Error al editar";
                throw;
            }
        }

        public static string DeleteSeccion(string id)
        {

            try
            {
                Seccion seccion = Find(id);
                listaSecciones.Remove(seccion);
                return "Sección eliminada exitosamente";
            }
            catch (Exception)
            {
                return "Error al eliminar la sección";
                throw;
            }
        }
    }
}