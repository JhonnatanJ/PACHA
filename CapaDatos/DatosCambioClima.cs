using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using CapaComun.Cache;
using System.Data;

namespace CapaDatos
{
    public class DatosCambioClima
    {
        public void InsertarDatosClimatico(string lugar, string cambioPotencial, string amenaza, string impactoPrevisto, string riesgoClimatico, string estratSugerida, string politAplicada)
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand();


            comando.Connection = conexionBD;
            comando.CommandText = "insert into cambioclimatico(LUGAR, CAMBIOPOTENCIAL, AMENAZA, IMPACTOPREVISTO, RIESGOCLIMATICO, ESTRATEGIASUGERIDA, POLITICAAPLICADA, IDCOMUNIDAD)" +
                "VALUES (@lugar, @cambioPotencial, @amenaza, @impactoPrevisto, @riesgoClimatico, @estratSugerida, @politAplicada, @idcomunidad)";
            comando.Parameters.AddWithValue("@lugar", lugar);
            comando.Parameters.AddWithValue("@cambioPotencial", cambioPotencial);
            comando.Parameters.AddWithValue("@amenaza", amenaza);
            comando.Parameters.AddWithValue("@impactoPrevisto", impactoPrevisto);
            comando.Parameters.AddWithValue("@riesgoClimatico", riesgoClimatico);
            comando.Parameters.AddWithValue("@estratSugerida", estratSugerida);
            comando.Parameters.AddWithValue("@politAplicada", politAplicada);
            comando.Parameters.AddWithValue("@idcomunidad", CacheLoginComunidad.idcomunidad);
            comando.CommandType = System.Data.CommandType.Text;
            comando.ExecuteNonQuery();
        }

        public DataTable CargarDGVclima()
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand();
            DataTable dt = new DataTable();

            comando.Connection = conexionBD;
            comando.CommandText = "select IDCAMBIOCLIMATICO as Item,LUGAR as Lugar,CAMBIOPOTENCIAL as 'Cambios Potenciales',AMENAZA as Amenazas,IMPACTOPREVISTO as 'Impactos Previstos',RIESGOCLIMATICO as 'Riesgo Climatico',ESTRATEGIASUGERIDA as 'Estrategias Sugeridas',POLITICAAPLICADA as 'Politicas en marcha' from cambioclimatico where IDCOMUNIDAD=@idcomunidad";
            comando.Parameters.AddWithValue("@idcomunidad", CacheLoginComunidad.idcomunidad);
            comando.CommandType = System.Data.CommandType.Text;
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            da.Fill(dt);
            conexionBD.Close();
            return dt;
        }

        public void EliminarClima(string item)
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand();

            comando.Connection = conexionBD;
            comando.CommandText = "delete from cambioclimatico where IDCAMBIOCLIMATICO=@idcambioclimatico";
            comando.Parameters.AddWithValue("@idcambioclimatico", item);
            comando.CommandType = System.Data.CommandType.Text;
            comando.ExecuteNonQuery();
            conexionBD.Close();
        }

    }
}
