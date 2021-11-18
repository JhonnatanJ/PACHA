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
            
            string cadenaConexionJhonn = "Server=localhost;Port=3366;Database=pacha;Uid=root;Pwd=root;";
            string cadenaConexionPancho = "Server=localhost;Port=3306;Database=pacha;Uid=root;Pwd=root;";

            try
            {
                try
                {
                    MySqlConnection conexionBD = new MySqlConnection(cadenaConexionPancho);
                    return conexionBD;
                }
                catch
                {
                    MySqlConnection conexionBD = new MySqlConnection(cadenaConexionJhonn);
                    return conexionBD;
                }
            }
            catch(MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }
    }
}
