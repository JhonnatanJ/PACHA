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
    public class DatosCurvaDemo
    {
        public void InsertarDatos(String informacion, float infDec1, float infDec2, float infDec3, float infDec4, float infDec5, float infDec6, float infDec7, float infDec8)
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand();


            comando.Connection = conexionBD;
            comando.CommandText = "insert into curvademografica(IDCOMUNIDAD, INFORMACION, DECADA1, DECADA2, DECADA3, DECADA4, DECADA5, DECADA6, DECADA7, DECADA8)" +
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

        public void ModificarDatos(String informacion, float infDec1, float infDec2, float infDec3, float infDec4, float infDec5, float infDec6, float infDec7, float infDec8)
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand();


            comando.Connection = conexionBD;
            comando.CommandText = "update curvademografica set IDCOMUNIDAD=@id, DECADA1=@infDec1, DECADA2=@infDec2, DECADA3=@infDec3, DECADA4=@infDec4, " +
                "DECADA5=@infDec5, DECADA6=@infDec6, DECADA7=@infDec7, DECADA8=@infDec8 WHERE INFORMACION=@informacion AND IDCOMUNIDAD=@id";

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


        public DataTable CargarDGVcurva()
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand();
            DataTable dt = new DataTable();

            comando.Connection = conexionBD;
            comando.CommandText = "select INFORMACION as Información,DECADA1 as '1950', DECADA2 as '1960'," +
                "DECADA3 as '1970',DECADA4 as '1980',DECADA5 as '1990'," +
                "DECADA6 as '2000',DECADA7 as '2010', DECADA8 as '2020' from curvademografica " +
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
