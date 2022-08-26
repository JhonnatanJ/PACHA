using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaComun.Cache;
using System.Data;

namespace CapaDatos.Fase2
{
    public class DatosUnidadTerritorial
    {
        
        
        public void InsertarDatos(String pais, String region, String provincia, String canton, String parroquia)
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand();


            comando.Connection = conexionBD;
            comando.CommandText = "insert into datoscomunidad(IDCOMUNIDAD, PAIS, REGION, PROVINCIA, CANTON, PARROQUIA, COMUNIDAD)" +
                "VALUES (@id, @pais, @region, @provincia, @canton, @parroquia, @comunidad)";

            comando.Parameters.AddWithValue("@id", CacheLoginComunidad.idcomunidad);
            comando.Parameters.AddWithValue("@pais", pais);
            comando.Parameters.AddWithValue("@region", region);
            comando.Parameters.AddWithValue("@provincia", provincia);
            comando.Parameters.AddWithValue("@canton", canton);
            comando.Parameters.AddWithValue("@parroquia", parroquia);
            comando.Parameters.AddWithValue("@comunidad", CacheLoginComunidad.nombre);

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

            comando.CommandText = "select PAIS as Pais, REGION as Region, PROVINCIA as Provincia," +
                "CANTON as Canton, PARROQUIA as Parroquia, COMUNIDAD as Comunidad" +
                " from datoscomunidad where IDCOMUNIDAD=@idcomunidad";

            comando.Parameters.AddWithValue("@idcomunidad", CacheLoginComunidad.idcomunidad);
            comando.CommandType = System.Data.CommandType.Text;
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            da.Fill(dt);
            conexionBD.Close();
            return dt;
        }


    }
}
