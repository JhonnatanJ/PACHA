using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    class Conexion
    {
        public static MySqlConnection conexion()
        {
            //string servidor = "localhost";
            //string bd = "pacha";
            //string usuario = "root2";
            //string password = "root";
            //string port = "3307";

            string cadenaConexion = "Server=localhost;Port=3306;Database=pacha;Uid=root;Pwd=root;";

            try
            {
                MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
                return conexionBD;
            }
            catch(MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }
    }
}
