using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AsignaturasVip.Models;

namespace AsignaturasVip.Controllers
{
    public class ArchivoController
    {
        public static List<Archivo> listaArchivos = new List<Archivo>();

        public static string AddArchivo(string id, string nombre, string tipo, string peso, string visibilidad, byte[] datos)
        {
            try
            {
                int idArchivo = int.Parse(id);
                double pesoArchivo = double.Parse(peso);
                bool visibilidadArchivo = bool.Parse(visibilidad);

                Archivo archivo = new Archivo(idArchivo, nombre, tipo, pesoArchivo, visibilidadArchivo, datos);
                listaArchivos.Add(archivo);
                return "El archivo se guardó exitosamente";
            }
            catch (Exception ex)
            {
                if (ex is FormatException)
                {
                    return "Error con el formato del archivo";
                }
                if (ex is InvalidCastException)
                {
                    return "Error con el formato de los datos ingresados";
                }

                return "Error";
                throw;
            }
        }

        public static Archivo Find(string id)
        {
            foreach (Archivo archivo in listaArchivos)
            {
                try
                {
                    if (archivo.Id == int.Parse(id))
                    {
                        return archivo;
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

        public static string EditArchivo(string id, string nombre, string visibilidad)
        {
            try
            {
                bool visibilidadArchivo = bool.Parse(visibilidad);
                Archivo archivo = Find(id);

                archivo.Visibilidad = visibilidadArchivo;
                archivo.Nombre = nombre;
                return "Archivo modificado exitosamente";
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

        public static string DeleteArchivo(string id)
        {

            try
            {
                Archivo archivo = Find(id);
                listaArchivos.Remove(archivo);
                return "Archivo eliminado exitosamente";
            }
            catch (Exception)
            {
                return "Error al eliminar el archivo";
                throw;
            }
        }
    }
}