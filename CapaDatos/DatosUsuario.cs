using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using CapaComun.Cache;

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
                    while (reader.Read())
                    {
                        CacheLoginUsuario.ci = reader.GetString(0);
                        CacheLoginUsuario.contrasena = reader.GetString(1);
                        CacheLoginUsuario.nombres = reader.GetString(2);
                        CacheLoginUsuario.apellidos = reader.GetString(3);
                        CacheLoginUsuario.rol = reader.GetString(4);
                        CacheLoginUsuario.email = reader.GetString(5);
                        CacheLoginUsuario.celular = reader.GetString(6);
                    }

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
