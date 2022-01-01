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
    public class DatosRiesgoClimatico
    {
        public void InsertarDatos(String sector, String amenaza, String impacto, String respuesta, String riesgo, int importancia, String observacion)
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand();


            comando.Connection = conexionBD;
            comando.CommandText = "insert into riesgoclimatico(IDCOMUNIDAD, SECTOR, AMENAZA, IMPACTO, RESPUESTA, RIESGO, IMPORTANCIA, OBSERVACIONES)" +
                "VALUES (@id, @sector, @amenaza, @impacto, @respuesta, @riesgo, @importancia, @observacion)";

            comando.Parameters.AddWithValue("@id", CacheLoginComunidad.idcomunidad);
            comando.Parameters.AddWithValue("@sector", sector);
            comando.Parameters.AddWithValue("@amenaza", amenaza);
            comando.Parameters.AddWithValue("@impacto", impacto);
            comando.Parameters.AddWithValue("@respuesta", respuesta);
            comando.Parameters.AddWithValue("@riesgo", riesgo);
            comando.Parameters.AddWithValue("@importancia", importancia);
            comando.Parameters.AddWithValue("@observacion", observacion);

            comando.CommandType = System.Data.CommandType.Text;
            comando.ExecuteNonQuery();
        }
    }
}
