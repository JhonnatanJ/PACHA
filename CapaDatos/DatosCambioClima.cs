using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using CapaComun.Cache;

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
    }
}
