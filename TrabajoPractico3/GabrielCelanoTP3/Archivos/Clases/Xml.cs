using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using Excepciones;

namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        public bool Guardar(string archivo, T datos)
        {
            string rutaFile;
            if (!string.IsNullOrEmpty(archivo) && datos != null)
            {
                try
                {
                    rutaFile = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    using (StreamWriter sW = new StreamWriter(Path.Combine(rutaFile, archivo)))
                    {
                        XmlSerializer auxSerializador = new XmlSerializer(typeof(T));
                        auxSerializador.Serialize(sW, datos);
                        return true;
                    }
                }
                catch (Exception e)
                {
                    throw new ArchivosException();
                }
            }
            return false;
        }

        public bool Leer(string archivo, out T datos)
        {
            string rutaFile;
            datos = default(T);
            if (!string.IsNullOrEmpty(archivo))
            {
                XmlSerializer auxSerializador = new XmlSerializer(typeof(T));
                try
                {
                    rutaFile = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    using (StreamReader sR = new StreamReader(Path.Combine(rutaFile, archivo)))
                    {
                        datos = (T)auxSerializador.Deserialize(sR);
                        return true;
                    }
                }
                catch (Exception e)
                {
                    throw new ArchivosException();
                }
            }
            return false;
        }
    }
}