using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaComun.Cache;

namespace CapaDatos
{
    public class DatosProyecto
    {
        public void InsertarDatosProyecto(string nombreProyecto, string objetivo, string responsable, string cargo, string telefono, string email)
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand();


            comando.Connection = conexionBD;
            comando.CommandText = "insert into proyecto(NUMACTOR, NOMBRE, OBJETIVO, RESPONSABLE, CARGO, TELEFONO, EMAIL) " +
                "VALUES (@id, @nombreProyecto, @objetivo, @responsable, @cargo, @telefono, @email)";


            comando.Parameters.AddWithValue("@id", CacheActores.numactor);
            comando.Parameters.AddWithValue("@nombreProyecto", nombreProyecto);
            comando.Parameters.AddWithValue("@objetivo", objetivo);
            comando.Parameters.AddWithValue("@responsable", responsable);
            comando.Parameters.AddWithValue("@cargo", cargo);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@email", email);

            comando.CommandType = System.Data.CommandType.Text;
            comando.ExecuteNonQuery();

        }
    }
}
