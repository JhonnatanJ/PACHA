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
    public class DatosProyecto
    {
        public void InsertarDatosProyecto(string nombreProyecto, string objetivo, string responsable, string cargo, string telefono, string email)
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand();


            comando.Connection = conexionBD;
            comando.CommandText = "insert into proyecto(NUMACTOR, NOMBRE, OBJETIVO, RESPONSABLE, CARGO, TELEFONO, EMAIL) " +
                "VALUES (@id, @nombreProyecto, @objetivo, @responsable, @cargo, @telefono, @email)";


            comando.Parameters.AddWithValue("@id", CacheActores.numactor);
            comando.Parameters.AddWithValue("@nombreProyecto", nombreProyecto);
            comando.Parameters.AddWithValue("@objetivo", objetivo);
            comando.Parameters.AddWithValue("@responsable", responsable);
            comando.Parameters.AddWithValue("@cargo", cargo);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@email", email);

            comando.CommandType = System.Data.CommandType.Text;
            comando.ExecuteNonQuery();
            conexionBD.Close();
        }

        public void ModificarProyecto(string nombre, string nombreProyecto, string objetivo, string responsable, string cargo, 
            string telefono, string email)
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand();


            comando.Connection = conexionBD;
            comando.CommandText = "update proyecto set NOMBRE=@nombreProyecto, OBJETIVO=@objetivo, RESPONSABLE=@responsable, " +
                "CARGO=@cargo, TELEFONO=@telefono, EMAIL=@email WHERE NOMBRE=@nombre AND NUMACTOR=@id";

            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@id", CacheActores.numactor);
            comando.Parameters.AddWithValue("@nombreProyecto", nombreProyecto);
            comando.Parameters.AddWithValue("@objetivo", objetivo);
            comando.Parameters.AddWithValue("@responsable", responsable);
            comando.Parameters.AddWithValue("@cargo", cargo);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@email", email);
            comando.CommandType = System.Data.CommandType.Text;
            comando.ExecuteNonQuery();
            conexionBD.Close();
        }

        public void EliminarProyecto(string nombre)
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand();

            comando.Connection = conexionBD;
            comando.CommandText = "delete from proyecto where NUMACTOR=@id AND NOMBRE = @nombre";
            comando.Parameters.AddWithValue("@id", CacheActores.numactor);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.CommandType = System.Data.CommandType.Text;
            comando.ExecuteNonQuery();
            conexionBD.Close();
        }

        public void EliminarProyectosActor()
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand();

            comando.Connection = conexionBD;
            comando.CommandText = "delete from proyecto where NUMACTOR=@id";
            comando.Parameters.AddWithValue("@id", CacheActores.numactor);
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
            comando.CommandText = "select * from proyecto where NUMACTOR=@numactor AND NOMBRE=@nombre";
            comando.Parameters.AddWithValue("@numactor", CacheActores.numactor);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.CommandType = System.Data.CommandType.Text;
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            da.Fill(dt);
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
            comando.CommandText = "select NOMBRE from proyecto where NUMACTOR=@numactor";
            comando.Parameters.AddWithValue("@numactor", CacheActores.numactor);
            comando.CommandType = System.Data.CommandType.Text;
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            da.Fill(dt);
            conexionBD.Close();
            return dt;
        }
    }
}
