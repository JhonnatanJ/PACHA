using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using CapaComun.Cache;
using System.Data;

namespace CapaDatos.Fase2
{
    public class DatosOcuTerritorio
    {
        public void InsertarDatos(String informacion, String infDec1, String infDec2, String infDec3, String infDec4, String infDec5, String infDec6, String infDec7, String infDec8)
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand();


            comando.Connection = conexionBD;
            comando.CommandText = "insert into ocupacionterritorio(IDCOMUNIDAD, INFORMACION, DECADA1, DECADA2, DECADA3, DECADA4, DECADA5, DECADA6, DECADA7, DECADA8)" +
                "VALUES (@id, @informacion, @infDec1, @infDec2, @infDec3, @infDec4, @infDec5, @infDec6, @infDec7, @infDec8)";

            comando.Parameters.AddWithValue("@id", CacheLoginComunidad.idcomunidad);
            comando.Parameters.AddWithValue("@informacion", informacion);
            comando.Parameters.AddWithValue("@infDec1", infDec1);
            comando.Parameters.AddWithValue("@infDec2", infDec2);
            comando.Parameters.AddWithValue("@infDec3", infDec3);
            comando.Parameters.AddWithValue("@infDec4", infDec4);
            comando.Parameters.AddWithValue("@infDec5", infDec5);
            comando.Parameters.AddWithValue("@infDec6", infDec6);
            comando.Parameters.AddWithValue("@infDec7", infDec7);
            comando.Parameters.AddWithValue("@infDec8", infDec8);

            comando.CommandType = System.Data.CommandType.Text;
            comando.ExecuteNonQuery();
        }

        public DataTable CargarDGVocupacion()
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand();
            DataTable dt = new DataTable();

            comando.Connection = conexionBD;
            comando.CommandText = "select INFORMACION as Información,DECADA1 as '1950', DECADA2 as '1960'," +
                "DECADA3 as '1970',DECADA4 as '1980',DECADA5 as '1990'," +
                "DECADA6 as '2000',DECADA7 as '2010', DECADA8 as '2020' from ocupacionterritorio " +
                "where IDCOMUNIDAD=@idcomunidad";

            comando.Parameters.AddWithValue("@idcomunidad", CacheLoginComunidad.idcomunidad);
            comando.CommandType = System.Data.CommandType.Text;
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            da.Fill(dt);
            conexionBD.Close();
            return dt;
        }
    }
}
