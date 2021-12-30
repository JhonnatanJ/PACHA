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
    public class DatosSector
    {
        public void InsertarDatos(String nombreSector)
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand();


            comando.Connection = conexionBD;
            comando.CommandText = "insert into sector(IDCOMUNIDAD, SECTOR)" +
                "VALUES (@id, @nombreSector)";

            comando.Parameters.AddWithValue("@id", CacheLoginComunidad.idcomunidad);
            comando.Parameters.AddWithValue("@nombreSector", nombreSector);
            

            comando.CommandType = System.Data.CommandType.Text;
            comando.ExecuteNonQuery();
        }

        public DataTable CargarCombo()
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand();
            DataTable dt = new DataTable();

            comando.Connection = conexionBD;
            comando.CommandText = "select Sector from sector where IDCOMUNIDAD=@idcomunidad";
            comando.Parameters.AddWithValue("@idcomunidad", CacheLoginComunidad.idcomunidad);
            comando.CommandType = System.Data.CommandType.Text;
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            da.Fill(dt);

            conexionBD.Close();
            return dt;
        }
    }
}
