using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace CapaDatos
{
    public class DatosUsuario
    {
        public bool Login(string user, string pass)
        {

            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            MySqlCommand comando = new MySqlCommand();            
           
            try
            {
                comando.Connection = conexionBD;
                comando.CommandText = "select * from usuario where CI=@user and CONTRASENA=@pass";
                comando.Parameters.AddWithValue("@user", user);
                comando.Parameters.AddWithValue("@pass", pass);
                comando.CommandType = System.Data.CommandType.Text;
                MySqlDataReader reader = comando.ExecuteReader();
                
                if (reader.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                conexionBD.Close();
            }
            
        }

    }
}
