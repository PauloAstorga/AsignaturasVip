using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AsignaturasVip.Models;

namespace AsignaturasVip.Controllers
{
    public class AsignaturaController
    {
        public static List<Asignatura> listAsignaturas = new List<Asignatura>();

        public static string AddAsignatura(string id, string nombre, string unidad)
        {
            try
            {
                Unidad unity = UnidadController.Find(int.Parse(id));
                if (unity != null)
                {
                    int idAsignatura = int.Parse(id);
                    Asignatura asignatura = new Asignatura(idAsignatura, nombre, unity);
                    listAsignaturas.Add(asignatura);
                    return "La asignatura se guardó exitosamente";
                }
                else
                {
                    return "error";
                }
            }
            catch (Exception ex)
            {
                return "Error";
                throw;
            }
        }


        public static Asignatura Find(string id)
        {
            foreach (Asignatura asignatura in listAsignaturas)
            {
                try
                {
                    if (asignatura.Id == int.Parse(id))
                    {
                        return asignatura;
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

        public static string EditAsignatura(string id, string nombre, Unidad unidad)
        {
            try
            {
                Asignatura asignatura = Find(id);

                asignatura.Nombre = nombre;
                asignatura.Unity = unidad;
                
                return "Asignatura modificada exitosamente";
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
        public static List<Asignatura> FindAll()
        {
            return listAsignaturas;
        }


        public static string DeleteAsignatura(string id)
        {

            try
            {
                Asignatura asignatura = Find(id);
                listAsignaturas.Remove(asignatura);
                return "Asignatura eliminada exitosamente";
            }
            catch (Exception)
            {
                return "Error al eliminar la asignatura";
                throw;
            }
        }
        public static void PrecargaAsignaturas()
        {

            if (listAsignaturas.Count < 1)
            {
                AddAsignatura("1", "Programación Web", "1");
               

            }
        }
    }
}