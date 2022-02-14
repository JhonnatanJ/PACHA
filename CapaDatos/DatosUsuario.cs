using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using CapaComun.Cache;
using System.Data;

namespace CapaDatos
{
    public class DatosUsuario
    {
        public bool Login(string user, string pass)
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand();
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

        public void Agregar(string ci, string pass, string nombres, string apellidos, string rol, string email, string celular)
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand();


            comando.Connection = conexionBD;
            comando.CommandText = "insert into usuario(CI, CONTRASENA, NOMBRES, APELLIDOS, ROL, EMAIL, CELULAR) " +
                "VALUES (@ci, @pass, @nombres, @apellidos, @rol, @email, @celular)";
            comando.Parameters.AddWithValue("@ci", ci);
            comando.Parameters.AddWithValue("@pass", pass);
            comando.Parameters.AddWithValue("@nombres", nombres);
            comando.Parameters.AddWithValue("@apellidos", apellidos);
            comando.Parameters.AddWithValue("@rol", rol);
            comando.Parameters.AddWithValue("@email", email);
            comando.Parameters.AddWithValue("@celular", celular);
            comando.CommandType = System.Data.CommandType.Text;
            comando.ExecuteNonQuery();
            conexionBD.Close();
        }

        public void Modificar(string pass, string nombres, string apellidos, string email, string celular)
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand();


            comando.Connection = conexionBD;
            comando.CommandText = "update usuario set CONTRASENA=@pass, NOMBRES=@nombres, " +
                "APELLIDOS=@apellidos, ROL=@rol, EMAIL=@email, CELULAR=@celular WHERE CI=@ci";

            comando.Parameters.AddWithValue("@ci", CacheLoginUsuario.ci);
            comando.Parameters.AddWithValue("@pass", pass);
            comando.Parameters.AddWithValue("@nombres", nombres);
            comando.Parameters.AddWithValue("@apellidos", apellidos);
            comando.Parameters.AddWithValue("@rol", CacheLoginUsuario.rol);
            comando.Parameters.AddWithValue("@email", email);
            comando.Parameters.AddWithValue("@celular", celular);
            comando.CommandType = System.Data.CommandType.Text;
            comando.ExecuteNonQuery();
            conexionBD.Close();
        }

        public DataTable CargarDGVUsuarios()
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand();
            DataTable dt = new DataTable();

            comando.Connection = conexionBD;
            comando.CommandText = "SELECT CI, NOMBRES, APELLIDOS, ROL, EMAIL, CELULAR FROM usuario";
            comando.CommandType = System.Data.CommandType.Text;
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            da.Fill(dt);
            conexionBD.Close();
            return dt;
        }

        public void ReestablecerContrasena( string ci, string pass)
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand();


            comando.Connection = conexionBD;
            comando.CommandText = "update usuario set CONTRASENA=@pass WHERE CI=@ci";

            comando.Parameters.AddWithValue("@ci", ci);
            comando.Parameters.AddWithValue("@pass", pass);
            comando.CommandType = System.Data.CommandType.Text;
            comando.ExecuteNonQuery();
            conexionBD.Close();
        }
    }
}
