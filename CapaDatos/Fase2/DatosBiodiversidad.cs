using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaComun.Cache;
using MySqlConnector;
using System.Data;

namespace CapaDatos.Fase2
{
    public class DatosBiodiversidad
    {
        public void InsertarDatos(String sector, String especie, String bioDec1, String bioDec2, String bioDec3, String bioDec4, String bioDec5, String bioDec6, String bioDec7, String bioDec8)
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand();


            comando.Connection = conexionBD;
            comando.CommandText = "insert into biodiversidad(IDCOMUNIDAD,SECTOR, INFORMACION, DECADA1, DECADA2, DECADA3, DECADA4, DECADA5, DECADA6, DECADA7, DECADA8)" +
                "VALUES (@id, @sector, @informacion, @bioDec1, @infDec2, @infDec3, @infDec4, @infDec5, @infDec6, @infDec7, @infDec8)";

            comando.Parameters.AddWithValue("@id", CacheLoginComunidad.idcomunidad);
            comando.Parameters.AddWithValue("@sector", sector);
            comando.Parameters.AddWithValue("@informacion", especie);
            comando.Parameters.AddWithValue("@bioDec1", bioDec1);
            comando.Parameters.AddWithValue("@infDec2", bioDec2);
            comando.Parameters.AddWithValue("@infDec3", bioDec3);
            comando.Parameters.AddWithValue("@infDec4", bioDec4);
            comando.Parameters.AddWithValue("@infDec5", bioDec5);
            comando.Parameters.AddWithValue("@infDec6", bioDec6);
            comando.Parameters.AddWithValue("@infDec7", bioDec7);
            comando.Parameters.AddWithValue("@infDec8", bioDec8);

            comando.CommandType = System.Data.CommandType.Text;
            comando.ExecuteNonQuery();
        }

        public DataTable CargarDGVbiodiversidad()
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand();
            DataTable dt = new DataTable();

            comando.Connection = conexionBD;
            comando.CommandText = "select SECTOR as Sector, INFORMACION as Información,DECADA1 as '1950', DECADA2 as '1960'," +
                "DECADA3 as '1970',DECADA4 as '1980',DECADA5 as '1990'," +
                "DECADA6 as '2000',DECADA7 as '2010', DECADA8 as '2020' from biodiversidad " +
                "where IDCOMUNIDAD=@idcomunidad";

            comando.Parameters.AddWithValue("@idcomunidad", CacheLoginComunidad.idcomunidad);
            comando.CommandType = System.Data.CommandType.Text;
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            da.Fill(dt);
            conexionBD.Close();
            return dt;
        }

        public void EliminarBiodiversidad(string item)
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand();

            comando.Connection = conexionBD;
            comando.CommandText = "delete from biodiversidad where INFORMACION=@informacion";
            comando.Parameters.AddWithValue("@informacion", item);
            comando.CommandType = System.Data.CommandType.Text;
            comando.ExecuteNonQuery();
            conexionBD.Close();
        }
    }
}
