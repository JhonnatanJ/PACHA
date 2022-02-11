using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using CapaComun.Cache;

namespace CapaDatos
{
    public class DatosComunidadLog
    {
        public DataTable CargarCombo()
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
                MySqlCommand comando = new MySqlCommand();
                DataTable dt = new DataTable();

                comando.Connection = conexionBD;
                comando.CommandText = "select NOMBRE from comunidadlog where CI=@user";
                comando.Parameters.AddWithValue("@user", CacheLoginUsuario.ci);
                comando.CommandType = System.Data.CommandType.Text;
                MySqlDataAdapter da = new MySqlDataAdapter(comando);
                da.Fill(dt);
            conexionBD.Close();
            return dt;
        }

        public DataTable CargarComboAdmin()
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand();
            DataTable dt = new DataTable();

            comando.Connection = conexionBD;
            comando.CommandText = "select NOMBRE from comunidadlog";
            comando.CommandType = System.Data.CommandType.Text;
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            da.Fill(dt);
            conexionBD.Close();
            return dt;
        }


        public void CargarDatosComunidadLog(string nombreComunidad)
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand();

            comando.Connection = conexionBD;
            comando.CommandText = "select * from comunidadlog where NOMBRE=@nombre";
            comando.Parameters.AddWithValue("@nombre", nombreComunidad);
            comando.CommandType = System.Data.CommandType.Text;
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    CacheLoginComunidad.idcomunidad = reader.GetString(0);
                    CacheLoginComunidad.ci = reader.GetString(1);
                    CacheLoginComunidad.nombre = reader.GetString(2);
                }
            }
            conexionBD.Close();
        }
        public void InsertarDatosComunidadLog(string id, string nombre)
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexionBD;
            comando.CommandText = "insert into comunidadlog(IDCOMUNIDAD, CI, NOMBRE) VALUES (@id, @ci, @nombre)";
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@ci", CacheLoginUsuario.ci);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.CommandType = System.Data.CommandType.Text;
            comando.ExecuteNonQuery();
            conexionBD.Close();
        }
    }
}
