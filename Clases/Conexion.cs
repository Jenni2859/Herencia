using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Icao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.Clases
{
    public class Conexion
    {
        private string cadenaConexion;

        string server = "jyjtechsolutions.com";
        string nombre_base = "u481278819_tiendapaula";
        string usuario = "u481278819_paula";
        string pass = "tPaula*2024";

        public Conexion() 
        {
            cadenaConexion = $"Server={server};Database={nombre_base};User id={usuario}; Password={pass};";

            
        }


        /// <summary>
        /// Establece la conexion con la base de datos
        /// </summary>
        /// <returns></returns>
        public MySqlConnection EstableceConexion()
        {
            return new MySqlConnection(cadenaConexion) ;


        }


        public void AbrirConexion(MySqlConnection conexion)
        {
            try
            {
                conexion.Open();
                Console.WriteLine("Conexion establecida!!");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Errar: {ex.Message}");
            }
        }

        public void CerrarConexion(MySqlConnection conexion)
        {
            try
            {
                conexion.Close();
                
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Ocurrio un error: {ex.Message}");
            }
        }

        public void EjecutarConsulta(string consulta)
        {
            using (MySqlConnection con = EstableceConexion())
             try
            {
                    AbrirConexion(con);
                    MySqlCommand cmd = new MySqlCommand(consulta, con);
                    int cantidadFilasAfectadas = cmd.ExecuteNonQuery();
                    Console.WriteLine($"Filas afectadas {cantidadFilasAfectadas}");

                }
            catch (MySqlException ex)
                {
                    Console.WriteLine($"Ocurrio un error: {ex.Message}");
                }
        }


        public DataTable ImprimirConsulta(string consulta)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection con = EstableceConexion())
            try
            {
                    AbrirConexion(con);
                    MySqlCommand cmd = new MySqlCommand( consulta, con);
                    MySqlDataAdapter adacter = new MySqlDataAdapter(cmd);
                    adacter.Fill(dt);

            }
            catch (MySqlException ex)
                {
                    Console.WriteLine($"Error: {ex}");
                }

            return dt;
        }


        /// <summary>
        /// Ejecuta un procedimiento almacenado que retorna datos (select)
        /// </summary>
        /// <param name="nombreCategoria">Nombre de la categoria a buscar</param>
        /// <returns></returns>
        public DataTable ObtenerListaCategorias(string idCategoria)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection connection = EstableceConexion())
                try
                {
                    AbrirConexion(connection);
                    MySqlCommand cmd = new MySqlCommand("SP_SEARCH_CATEGORY", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("ID_C", idCategoria);
                    MySqlDataAdapter adacter = new MySqlDataAdapter(cmd);
                    adacter.Fill(dt);

                }
                catch (MySqlException ex)
                {
                    Console.WriteLine($"Error: {ex}");
                }
            return dt;
        }
    }
}
