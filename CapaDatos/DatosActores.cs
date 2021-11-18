using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaComun.Cache;

namespace CapaDatos
{
    public class DatosActores
    {
        
        public void InsertarDatosActores(string nombreActor, string siglas, string tipo, string unidadAnalisis, string competenciasRel)
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand();
           

            comando.Connection = conexionBD;
            comando.CommandText = "insert into actor(NOMBRE, IDCOMUNIDAD, SIGLAS, TIPO, RELACIONES, COMPETENCIASRELACIONADAS) " +
                "VALUES (@nombreActor, @idcomunidad, @siglas, @tipo, @unidadAnalisis, @competenciasRel)";
            comando.Parameters.AddWithValue("@nombreActor", nombreActor);
            comando.Parameters.AddWithValue("@idcomunidad", CacheLoginComunidad.idcomunidad);
            comando.Parameters.AddWithValue("@siglas", siglas);
            comando.Parameters.AddWithValue("@tipo", tipo);
            comando.Parameters.AddWithValue("@unidadAnalisis", unidadAnalisis);
            comando.Parameters.AddWithValue("@competenciasRel", competenciasRel);
            comando.CommandType = System.Data.CommandType.Text;
            comando.ExecuteNonQuery();
        }

        public void CargarDatosActores(string nombreActor)
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand();

            comando.Connection = conexionBD;
            comando.CommandText = "select * from actor where NOMBRE=@nombre";
            comando.Parameters.AddWithValue("@nombre", nombreActor);
            comando.CommandType = System.Data.CommandType.Text;
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    CacheActores.numactor = reader.GetInt32(0);
                    CacheActores.idcomunidad = reader.GetString(1);
                    CacheActores.nombre = reader.GetString(2);
                    CacheActores.siglas = reader.GetString(3);
                    CacheActores.tipo = reader.GetString(4);
                    CacheActores.relaciones = reader.GetString(5);
                    CacheActores.competenciasrelacionadas = reader.GetString(6);
                }
            }
            conexionBD.Close();
        }

    }
}
