using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Interfaces.Interfaces;
using Excepciones;

namespace Archivos
{
    public class Xml<T>:IArchivos<T>
    {
        /// <summary>
        /// Guarda un archivo de tipo XML
        /// </summary>
        /// <param name="rutaArchivo"></param>
        /// <param name="objeto"></param>
        /// <returns></returns>
        public bool Guardar(string rutaArchivo, T objeto)
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), rutaArchivo + ".xml");
            XmlTextWriter writer = new XmlTextWriter(path, Encoding.UTF8);
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            try
            {
                serializer.Serialize(writer, objeto);
                return true;
            }
            catch (Exception ex)
            {
                throw new ArchivoException("Error al guardar XML", ex);
            }
            finally
            {
                writer.Close();
            }
        }

        /// <summary>
        /// Lee un archivo de tipo XML
        /// </summary>
        /// <param name="rutaArchivo"></param>
        /// <returns></returns>
        public T Leer(string rutaArchivo)
        {
            T datos;
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), rutaArchivo + ".xml");
            try
            {
                using (XmlTextReader reader = new XmlTextReader(path))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    datos = (T)serializer.Deserialize(reader);
                    return datos;
                }
            }
            catch (Exception ex)
            {
                throw new ArchivoException("Error al leer XML", ex);
            }
        }
    }
}
