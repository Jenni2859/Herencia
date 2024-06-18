using Herencia.Clases;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.Gestion_BD
{
    public class GestionCategoria: Conexion //Heredamos la clase conexion
    {

        /// <summary>
        /// Constructor por defecto de la clase
        /// </summary>
        public GestionCategoria() { }


        public void RegistrarCategoria(String NameCategory)
        {
            using (MySqlConnection connection = EstableceConexion())
            try
            {
                    AbrirConexion(connection);
                    MySqlCommand cmd = new MySqlCommand("SP_REGISTER_CATEGORY", connection);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("CATEGORY_P", NameCategory);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Se registró los datos exítosamente");

                }
            catch (MySqlException err)
                {
                    Console.WriteLine($"Ocurrio un error: {err.Message}");
                }
        }


        /// <summary>
        /// Recoge toddo a la lista de categorias y las almacena en una
        /// </summary>
        /// <returns></returns>
        public DataTable ListaTodasCategorias()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection con = EstableceConexion())
                try
                {
                    AbrirConexion(con);
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM V_SHOW_CATEGORIES", con);
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
