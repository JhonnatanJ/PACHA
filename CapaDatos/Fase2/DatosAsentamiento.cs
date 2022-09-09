using CapaComun.Cache;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Fase2
{
    public class DatosAsentamiento
    {
        public void InsertarDatos(String nombre, String sector, String latitud, String longitud, int poblacion)
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand();

            comando.Connection = conexionBD;
            comando.CommandText = "insert into asentamiento(IDCOMUNIDAD, NOMBRE, SECTOR, LATITUD, LONGITUD, POBLACION) " +
                "VALUES (@id, @nombre, @sector, @latitud, @longitud, @poblacion)";

            comando.Parameters.AddWithValue("@id", CacheLoginComunidad.idcomunidad);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@sector", sector);
            comando.Parameters.AddWithValue("@latitud", latitud);
            comando.Parameters.AddWithValue("@longitud", longitud);
            comando.Parameters.AddWithValue("@poblacion", poblacion);

            comando.CommandType = System.Data.CommandType.Text;
            comando.ExecuteNonQuery();
        }

        public DataTable CargarDGV()
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand();
            DataTable dt = new DataTable();

            comando.Connection = conexionBD;
            comando.CommandText = "select NOMBRE as Nombre, SECTOR as Sector, LATITUD as X, LONGITUD as Y," +
                "POBLACION as Poblacion from asentamiento where IDCOMUNIDAD=@idcomunidad";

            comando.Parameters.AddWithValue("@idcomunidad", CacheLoginComunidad.idcomunidad);
            comando.CommandType = System.Data.CommandType.Text;
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            da.Fill(dt);
            conexionBD.Close();
            return dt;
        }

        public void EliminarAsentamiento(string item)
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand();

            comando.Connection = conexionBD;
            comando.CommandText = "delete from asentamiento where NOMBRE=@nombre";
            comando.Parameters.AddWithValue("@nombre", item);
            comando.CommandType = System.Data.CommandType.Text;
            comando.ExecuteNonQuery();
            conexionBD.Close();
        }
    }

}
