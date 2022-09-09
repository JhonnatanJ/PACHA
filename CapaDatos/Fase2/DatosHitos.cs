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
    public class DatosHitos
    {
        public void InsertarDatos(String tipo, String nombre, String latitud, String longitud)
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand();

            comando.Connection = conexionBD;
            comando.CommandText = "insert into hitosgeograficos(IDCOMUNIDAD, TIPO, NOMBRE, LATITUD, LONGITUD) " +
                "VALUES (@id, @tipo, @nombre, @latitud, @longitud)";

            comando.Parameters.AddWithValue("@id", CacheLoginComunidad.idcomunidad);
            comando.Parameters.AddWithValue("@tipo", tipo);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@latitud", latitud);
            comando.Parameters.AddWithValue("@longitud", longitud);

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
            comando.CommandText = "select TIPO as Tipo, NOMBRE as Nombre, LATITUD as X, LONGITUD as Y" +
                " from hitosgeograficos where IDCOMUNIDAD=@idcomunidad";

            comando.Parameters.AddWithValue("@idcomunidad", CacheLoginComunidad.idcomunidad);
            comando.CommandType = System.Data.CommandType.Text;
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            da.Fill(dt);
            conexionBD.Close();
            return dt;
        }

        public void EliminarHitos(string item)
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand();

            comando.Connection = conexionBD;
            comando.CommandText = "delete from hitosgeograficos where NOMBRE=@nombre";
            comando.Parameters.AddWithValue("@nombre", item);
            comando.CommandType = System.Data.CommandType.Text;
            comando.ExecuteNonQuery();
            conexionBD.Close();
        }
    }
}
