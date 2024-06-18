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
    public class GestionUsuario: Conexion
    {
        public string usuarioVerificar { get; set; }

        public string PasswordVerificar { get; set; }


        public GestionUsuario() { }


        public bool Verificar_Usuario_Contra(int usuario, string contrasennia)
        {
            bool existe = false; 

            DataTable dt = new DataTable();

            using (MySqlConnection connection = EstableceConexion())
                try
                {
                    AbrirConexion(connection);

                    MySqlCommand cmd = new MySqlCommand($"SELECT * FROM USERS WHERE IdUser = {usuario} and Password_user = {contrasennia}",connection);
                    cmd.Parameters.AddWithValue("IdUser", usuario);
                    cmd.Parameters.AddWithValue("Password_user", contrasennia);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);

                    existe = dt.Rows.Count > 0;


                    //Muestra datos que solo el desarrollador ve
                    int cantidFilasAfectadas = cmd.ExecuteNonQuery();
                    Console.WriteLine($"Filas afectadas: {cantidFilasAfectadas}");

                }
            catch (MySqlException err)
                {
                    Console.WriteLine($"Ocurrio un error: {err.Message}");
                }
            finally
                {
                    CerrarConexion(connection);
                }

            return existe;
        }

    }
}
