using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace CapaDatos
{

    public class DatosComunidadLog
    {
        public DataTable CargarCombo()
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand();
            DataTable dt = new DataTable();

                comando.Connection = conexionBD;
                comando.CommandText = "select CI, NOMBRE from comunidadlog";
                comando.CommandType = System.Data.CommandType.Text;
                MySqlDataAdapter da = new MySqlDataAdapter(comando);
                da.Fill(dt);
            conexionBD.Close();
            return dt;
        }

    }
}
