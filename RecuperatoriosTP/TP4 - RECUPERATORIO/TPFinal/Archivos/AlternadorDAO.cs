using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces.Interfaces;
using Excepciones;
using ClasesInstanciables.Clases;
using ClasesInstanciables.Enumerados;

namespace Archivos
{
    public class AlternadorDAO<U> : IBaseDeDatos<Fabricacion, U> where U : Alternador
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        public AlternadorDAO()
        {
            this.conexion = new SqlConnection(Properties.Settings.Default.StringConection);
            this.comando = new SqlCommand();
            this.comando.Connection = this.conexion;
        }

        /// <summary>
        /// Guarda un alternador fabricado a la base de datos
        /// </summary>
        /// <param name="fabricacion"></param>
        /// <param name="objeto"></param>
        /// <returns></returns>
        public bool Guardar(Fabricacion fabricacion, U objeto)
        {
            bool aux = false;
            try
            {
                foreach (Alternador item in fabricacion.Alternadores)
                {
                    if (objeto.Marca.ToString() == item.Marca.ToString())
                    {
                        comando.Parameters.Clear();
                        comando.CommandText = "INSERT INTO dbo.Alternadores(Marca, Cantidad) VALUES(@marca, @cantidad)";
                        comando.Parameters.AddWithValue("@marca", item.Marca.ToString());
                        comando.Parameters.AddWithValue("@cantidad", item.Cantidad);
                        this.Ejecutar();
                        aux = true;
                        return aux;
                    }
                }
                return aux;
            }
            catch (Exception ex)
            {
                throw new GuardarBdException("Error al guardar base de datos(Alternadores)", ex);
            }
        }

        /// <summary>
        /// Lee la tabla Alternadores de la base de datos
        /// </summary>
        /// <param name="fabricacion"></param>
        /// <returns></returns>
        public Fabricacion Leer(Fabricacion fabricacion)
        {
            try
            {
                comando.CommandText = "SELECT marca, cantidad FROM dbo.Alternadores";
                if (this.conexion.State != System.Data.ConnectionState.Open && this.conexion.State != System.Data.ConnectionState.Connecting)
                {
                    conexion.Open();
                }

                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    int cantidad;
                    EMarca marca;
                    Enum.TryParse(oDr["marca"].ToString(), false, out marca);
                    int.TryParse(oDr["cantidad"].ToString(), out cantidad);

                    Alternador alternador = new Alternador(marca, cantidad);
                    fabricacion.Alternadores.Add(alternador);
                }

                this.conexion.Close();

                return fabricacion;
            }
            catch (Exception ex)
            {
                throw new LeerBdException("Error al leer base de datos(Alternadores)", ex);
            }
            finally
            {
                this.conexion.Close();
            }
        }

        /// <summary>
        /// Actualiza la cantidad de fabricaciones de una marca
        /// </summary>
        /// <param name="fabricacion"></param>
        /// <param name="objeto"></param>
        public void ActualizarDatos(Fabricacion fabricacion, U objeto)
        {
            try
            {
                foreach (Alternador item in fabricacion.Alternadores)
                {
                    if (objeto.Marca.ToString() == item.Marca.ToString())
                    {
                        comando.Parameters.Clear();
                        comando.CommandText = "Update Alternadores set Cantidad = @cantidad where Marca = @marca";
                        comando.Parameters.AddWithValue("@marca", item.Marca.ToString());
                        comando.Parameters.AddWithValue("@cantidad", item.Cantidad);
                        this.Ejecutar();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ActualizarBdException("Error al actualizar base de datos(Alternadores)", ex);
            }
        }


        /// <summary>
        /// Verifica si el alternador ya se encuentra en la base de datos
        /// </summary>
        /// <param name="alternador"></param>
        /// <returns></returns>
        public bool Verificar(U alternador)
        {
            bool validacion = false;
            comando.CommandText = "SELECT Marca FROM dbo.Alternadores";
            try
            {
                if (this.conexion.State != System.Data.ConnectionState.Open && this.conexion.State != System.Data.ConnectionState.Connecting)
                {
                    conexion.Open();
                }

                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    string marcaAux = oDr["marca"].ToString();
                    if (marcaAux == alternador.Marca.ToString())
                    {
                        validacion = true;
                        return validacion;
                    }
                }
                return validacion;
            }
            catch (Exception ex)
            {
                throw new VerificarBdException("Error al verificar base de datos(Alternadores)", ex);
            }
            finally
            {
                this.conexion.Close();
            }
        }

        /// <summary>
        /// Ejecuta las querys
        /// </summary>
        private void Ejecutar()
        {
            try
            {
                if (this.conexion.State != System.Data.ConnectionState.Open && this.conexion.State != System.Data.ConnectionState.Connecting)
                {
                    conexion.Open();
                }

                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception();
            }
            finally
            {
                this.conexion.Close();
            }
        }
    }
}
