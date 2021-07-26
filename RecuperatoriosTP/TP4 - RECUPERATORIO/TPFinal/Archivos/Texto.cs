using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces.Interfaces;
using Excepciones;

namespace Archivos
{
    public class Texto : IArchivos<string>
    {
        /// <summary>
        /// Guarda un archivo de texto
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public bool Guardar(string archivo, string datos)
        {
            string rutaFile;
            if (!string.IsNullOrEmpty(archivo) && !string.IsNullOrEmpty(datos))
            {
                try
                {
                    rutaFile = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    using (StreamWriter auxSw = new StreamWriter(Path.Combine(rutaFile, archivo), true))
                    {
                        auxSw.WriteLine(datos);
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    throw new ArchivoException("Error al guardar TXT", ex);
                }
            }
            return false;
        }

        /// <summary>
        /// Lee un archivo de texto
        /// </summary>
        /// <param name="archivo"></param>
        /// <returns></returns>
        public string Leer(string archivo)
        {
            string rutaFile;
            string datos = "";
            if (!string.IsNullOrEmpty(archivo))
            {
                try
                {
                    rutaFile = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    using (StreamReader auxSw = new StreamReader(Path.Combine(rutaFile, archivo)))
                    {
                        datos = auxSw.ReadToEnd();
                        return datos;
                    }
                }
                catch (Exception ex)
                {
                    throw new ArchivoException("Error al leer TXT", ex);
                }
            }
            return datos;
        }
    }
}
