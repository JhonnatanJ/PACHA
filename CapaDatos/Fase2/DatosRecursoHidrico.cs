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
    public class DatosRecursoHidrico
    {
        public void InsertarDatos(String recHidrico, float recDec1, float recDec2, float recDec3, float recDec4, float recDec5, float recDec6, float recDec7, float recDec8)
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand();


            comando.Connection = conexionBD;
            comando.CommandText = "insert into recursohidrico(IDCOMUNIDAD, INFORMACION, DECADA1, DECADA2, DECADA3, DECADA4, DECADA5, DECADA6, DECADA7, DECADA8)" +
                "VALUES (@id, @informacion, @recDec1, @recDec2, @recDec3, @recDec4, @recDec5, @recDec6, @recDec7, @recDec8)";

            comando.Parameters.AddWithValue("@id", CacheLoginComunidad.idcomunidad);
            comando.Parameters.AddWithValue("@informacion", recHidrico);
            comando.Parameters.AddWithValue("@recDec1", recDec1);
            comando.Parameters.AddWithValue("@recDec2", recDec2);
            comando.Parameters.AddWithValue("@recDec3", recDec3);
            comando.Parameters.AddWithValue("@recDec4", recDec4);
            comando.Parameters.AddWithValue("@recDec5", recDec5);
            comando.Parameters.AddWithValue("@recDec6", recDec6);
            comando.Parameters.AddWithValue("@recDec7", recDec7);
            comando.Parameters.AddWithValue("@recDec8", recDec8);

            comando.CommandType = System.Data.CommandType.Text;
            comando.ExecuteNonQuery();
        }

        public DataTable CargarDGVrecurso()
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand();
            DataTable dt = new DataTable();

            comando.Connection = conexionBD;
            comando.CommandText = "select INFORMACION as Información,DECADA1 as '1950', DECADA2 as '1960'," +
                "DECADA3 as '1970',DECADA4 as '1980',DECADA5 as '1990'," +
                "DECADA6 as '2000',DECADA7 as '2010', DECADA8 as '2020' from recursohidrico " +
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
