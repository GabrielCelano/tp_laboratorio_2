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
    public class OperarioDAO<U> : IBaseDeDatos<Fabrica, U> where U : Operario
    {
        private SqlConnection conexion;
        private SqlCommand comando;

        public OperarioDAO()
        {
            this.conexion = new SqlConnection(Properties.Settings.Default.StringConection);
            this.comando = new SqlCommand();
            this.comando.Connection = this.conexion;
        }

        /// <summary>
        /// Guarda un nuevo operario en la base de datos
        /// </summary>
        /// <param name="fabrica"></param>
        /// <param name="objeto"></param>
        /// <returns></returns>
        public bool Guardar(Fabrica fabrica, U objeto)
        {
            bool aux = false;
            try
            {
                foreach (Operario item in fabrica.Operarios)
                {
                    if (item.DNI == objeto.DNI)
                    {
                        comando.Parameters.Clear();
                        comando.CommandText = "INSERT INTO dbo.Operarios(Nombre,Apellido,Dni,Puesto,Fabricaciones) VALUES(@nombre, @apellido, @dni, @puesto, @fabricaciones)";
                        comando.Parameters.AddWithValue("@nombre", item.Nombre);
                        comando.Parameters.AddWithValue("@apellido", item.Apellido);
                        comando.Parameters.AddWithValue("@dni", item.DNI);
                        comando.Parameters.AddWithValue("@puesto", item.Puesto.ToString());
                        comando.Parameters.AddWithValue("@fabricaciones", item.Fabricaciones);

                        this.Ejecutar();
                        aux = true;

                        return aux;
                    }
                }
                return aux;
            }
            catch (Exception ex)
            {
                throw new GuardarBdException("Error al guardar base de datos(Operarios)", ex);
            }
        }

        /// <summary>
        /// Lee la tabla Operarios de la base de datos
        /// </summary>
        /// <param name="lista"></param>
        /// <returns></returns>
        public Fabrica Leer(Fabrica lista)
        {
            comando.CommandText = "SELECT nombre, apellido, dni, puesto, fabricaciones FROM dbo.Operarios";

            try
            {
                if (this.conexion.State != System.Data.ConnectionState.Open && this.conexion.State != System.Data.ConnectionState.Connecting)
                {
                    conexion.Open();
                }

                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    int dni;
                    int fabricaciones;
                    EPuestoDeTrabajo puesto;
                    string nombre = oDr["nombre"].ToString();
                    string apellido = oDr["apellido"].ToString();
                    int.TryParse(oDr["dni"].ToString(), out dni);
                    Enum.TryParse(oDr["puesto"].ToString(), false, out puesto);
                    int.TryParse(oDr["fabricaciones"].ToString(), out fabricaciones);

                    Operario operario = new Operario(nombre, apellido, dni, puesto, fabricaciones);
                    lista.Operarios.Add(operario);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw new LeerBdException("Error al leer base de datos(Operarios)", ex);
            }
            finally
            {
                this.conexion.Close();
            }
        }

        /// <summary>
        /// Actualiza la cantidad de fabricaciones de un operario
        /// </summary>
        /// <param name="fabrica"></param>
        /// <param name="operario"></param>
        public void ActualizarDatos(Fabrica fabrica, U operario)
        {
            try
            {
                foreach (Operario item in fabrica.Operarios)
                {
                    if (operario.DNI == item.DNI)
                    {
                        comando.Parameters.Clear();
                        comando.CommandText = "Update Operarios set Fabricaciones = @fabricaciones where Dni = @dni";
                        comando.Parameters.AddWithValue("@dni", item.DNI);
                        comando.Parameters.AddWithValue("@fabricaciones", item.Fabricaciones);
                        this.Ejecutar();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ActualizarBdException("Error al actualizar base de datos(Operarios)", ex);
            }
        }

        /// <summary>
        /// Verifica si un operario ya se encuentra en la base de datos
        /// </summary>
        /// <param name="operario"></param>
        /// <returns></returns>
        public bool Verificar(U operario)
        {
            bool validacion = false;
            comando.CommandText = "SELECT Dni FROM dbo.Operarios";

            try
            {
                if (this.conexion.State != System.Data.ConnectionState.Open && this.conexion.State != System.Data.ConnectionState.Connecting)
                {
                    conexion.Open();
                }

                SqlDataReader oDr = comando.ExecuteReader();

                while (oDr.Read())
                {
                    int dniAux;
                    int.TryParse(oDr["dni"].ToString(), out dniAux);
                    if (dniAux == operario.DNI)
                    {
                        validacion = true;
                    }
                }

                return validacion;
            }
            catch (Exception ex)
            {
                throw new VerificarBdException("Error al verificar base de datos(Operarios)", ex);
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
