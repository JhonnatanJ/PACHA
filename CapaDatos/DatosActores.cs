using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaComun.Cache;
using System.Data;

namespace CapaDatos
{
    public class DatosActores
    {
        
        public void InsertarDatosActores(string nombreActor, string siglas, string tipo, string unidadAnalisis, string incidencias, string competenciasRel)
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand();
           

            comando.Connection = conexionBD;
            comando.CommandText = "insert into actor(NOMBRE, IDCOMUNIDAD, SIGLAS, TIPO, RELACIONES, INCIDENCIAS, COMPETENCIASRELACIONADAS) " +
                "VALUES (@nombreActor, @idcomunidad, @siglas, @tipo, @unidadAnalisis, @incidencias, @competenciasRel)";
            comando.Parameters.AddWithValue("@nombreActor", nombreActor);
            comando.Parameters.AddWithValue("@idcomunidad", CacheLoginComunidad.idcomunidad);
            comando.Parameters.AddWithValue("@siglas", siglas);
            comando.Parameters.AddWithValue("@tipo", tipo);
            comando.Parameters.AddWithValue("@unidadAnalisis", unidadAnalisis);
            comando.Parameters.AddWithValue("@incidencias", incidencias);
            comando.Parameters.AddWithValue("@competenciasRel", competenciasRel);
            comando.CommandType = System.Data.CommandType.Text;
            comando.ExecuteNonQuery();
            conexionBD.Close();
        }

        public void ModificarActor(string nombre, string nombreActor, string siglas, string tipo, string unidadAnalisis, string incidencias, string competenciasRel)
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand();

            comando.Connection = conexionBD;
            comando.CommandText = "update actor set NOMBRE=@nombreActor, SIGLAS=@siglas, TIPO=@tipo, INCIDENCIAS=@incidencias, RELACIONES=@relaciones," +
                "COMPETENCIASRELACIONADAS=@competenciasRel WHERE NOMBRE=@nombre AND IDCOMUNIDAD=@idcomunidad";
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@nombreActor", nombreActor);
            comando.Parameters.AddWithValue("@idcomunidad", CacheLoginComunidad.idcomunidad);
            comando.Parameters.AddWithValue("@siglas", siglas);
            comando.Parameters.AddWithValue("@tipo", tipo);
            comando.Parameters.AddWithValue("@relaciones", unidadAnalisis);
            comando.Parameters.AddWithValue("@incidencias", incidencias);
            comando.Parameters.AddWithValue("@competenciasRel", competenciasRel);
            comando.CommandType = System.Data.CommandType.Text;
            comando.ExecuteNonQuery();
            conexionBD.Close();
        }

        public void EliminarActor(string nombre)
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand();

            comando.Connection = conexionBD;
            comando.CommandText = "delete from actor where IDCOMUNIDAD=@idcomunidad AND NOMBRE = @nombre";
            comando.Parameters.AddWithValue("@idcomunidad", CacheLoginComunidad.idcomunidad);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.CommandType = System.Data.CommandType.Text;
            comando.ExecuteNonQuery();
            conexionBD.Close();

        }

        public DataTable CargarDGV(string nombre)
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand();
            DataTable dt = new DataTable();

            comando.Connection = conexionBD;
            comando.CommandText = "select NOMBRE,SIGLAS,TIPO,RELACIONES,INCIDENCIAS,COMPETENCIASRELACIONADAS AS \"COMPETENCIAS RELACIONADAS\" from actor where IDCOMUNIDAD=@idcomunidad AND NOMBRE=@nombre";
            comando.Parameters.AddWithValue("@idcomunidad", CacheLoginComunidad.idcomunidad);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.CommandType = System.Data.CommandType.Text;
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            da.Fill(dt);
            CargarDatosActores(nombre);
            conexionBD.Close();
            return dt;
        }

        public DataTable CargarCombo()
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand();
            DataTable dt = new DataTable();

            comando.Connection = conexionBD;
            comando.CommandText = "select NOMBRE from actor where IDCOMUNIDAD=@idcomunidad";
            comando.Parameters.AddWithValue("@idcomunidad", CacheLoginComunidad.idcomunidad);
            comando.CommandType = System.Data.CommandType.Text;
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            da.Fill(dt);
           
            conexionBD.Close();
            return dt;
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
                    CacheActores.incidencias = reader.GetString(6);
                    CacheActores.competenciasrelacionadas = reader.GetString(7);
                }
            }
            conexionBD.Close();
        }

    }
}
