using ClasesInstanciables.Clases;
using ClasesInstanciables.Enumerados;
using Excepciones;
using Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public class ArranqueDAO<U>: IBaseDeDatos<Fabricacion, U> where U : Arranque
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        public ArranqueDAO()
        {
            this.conexion = new SqlConnection(Properties.Settings.Default.StringConection);
            this.comando = new SqlCommand();
            this.comando.Connection = this.conexion;
        }

        /// <summary>
        /// Guarda un arranque fabricado a la base de datos
        /// </summary>
        /// <param name="fabricacion"></param>
        /// <param name="objeto"></param>
        /// <returns></returns>
        public bool Guardar(Fabricacion fabricacion, U objeto)
        {
            bool aux = false;
            try
            {
                foreach (Arranque item in fabricacion.Arranques)
                {
                    if (objeto.Marca.ToString() == item.Marca.ToString())
                    {
                        comando.Parameters.Clear();
                        comando.CommandText = "INSERT INTO dbo.Arranques(Marca, Cantidad) VALUES(@marca, @cantidad)";
                        comando.Parameters.AddWithValue("@marca", item.Marca.ToString());
                        comando.Parameters.AddWithValue("@cantidad", item.Cantidad);
                        this.Ejecutar();
                        aux = true;
                        return aux;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new GuardarBdException("Error al guardar base de datos(Arranques)", ex);
            }
            return aux;
        }

        /// <summary>
        /// Lee la tabla Arranques de la base de datos
        /// </summary>
        /// <param name="fabricacion"></param>
        /// <returns></returns>
        public Fabricacion Leer(Fabricacion fabricacion)
        {
            try
            {
                comando.CommandText = "SELECT marca, cantidad FROM dbo.Arranques";

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

                    Arranque arranque = new Arranque(marca, cantidad);
                    fabricacion.Arranques.Add(arranque);
                }

                this.conexion.Close();

                return fabricacion;
            }
            catch (Exception ex)
            {
                throw new LeerBdException("Error al leer base de datos(Arranques)", ex);
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
                foreach (Arranque item in fabricacion.Arranques)
                {
                    if (objeto.Marca.ToString() == item.Marca.ToString())
                    {
                        comando.Parameters.Clear();
                        comando.CommandText = "Update Arranques set Cantidad = @cantidad where Marca = @marca";
                        comando.Parameters.AddWithValue("@marca", item.Marca.ToString());
                        comando.Parameters.AddWithValue("@cantidad", item.Cantidad);
                        this.Ejecutar();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ActualizarBdException("Error al actualizar base de datos(Arranques)", ex);
            }
        }

        /// <summary>
        /// Verifica si el arranque ya se encuentra en la base de datos
        /// </summary>
        /// <param name="alternador"></param>
        /// <returns></returns>
        public bool Verificar(U arranque)
        {
            bool validacion = false;
            comando.CommandText = "SELECT Marca FROM dbo.Arranques";
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
                    if (marcaAux == arranque.Marca.ToString())
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
