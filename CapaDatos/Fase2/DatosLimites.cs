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
    public class DatosLimites
    {
        public void InsertarDatos(String norte, String latnorte, String lonnorte, String sur, String latsur, String lonsur,
            String este, String lateste, String loneste, String oeste, String latoeste, String lonoeste)
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand();


            comando.Connection = conexionBD;
            comando.CommandText = "insert into limites(IDCOMUNIDAD, NORTE, SUR, ESTE, OESTE, LATNORTE, LONGNORTE, " +
                "LATSUR, LONGSUR, LATESTE, LONGESTE, LATOESTE, LONGOESTE)" +
                "VALUES (@id, @norte, @sur, @este, @oeste, @latnorte, @lonnorte, @latsur, @lonsur, @lateste, @loneste, " +
                "@latoeste, @lonoeste)";

            comando.Parameters.AddWithValue("@id", CacheLoginComunidad.idcomunidad);
            comando.Parameters.AddWithValue("@norte", norte);
            comando.Parameters.AddWithValue("@sur", sur);
            comando.Parameters.AddWithValue("@este", este);
            comando.Parameters.AddWithValue("@oeste", oeste);
            comando.Parameters.AddWithValue("@latnorte", latnorte);
            comando.Parameters.AddWithValue("@lonnorte", lonnorte);
            comando.Parameters.AddWithValue("@latsur", latsur);
            comando.Parameters.AddWithValue("@lonsur", lonsur);
            comando.Parameters.AddWithValue("@lateste", lateste);
            comando.Parameters.AddWithValue("@loneste", loneste);
            comando.Parameters.AddWithValue("@latoeste", latoeste);
            comando.Parameters.AddWithValue("@lonoeste", lonoeste);

            comando.CommandType = System.Data.CommandType.Text;
            comando.ExecuteNonQuery();
        }

        public void ModificarDatos(String norte, String latnorte, String lonnorte, String sur, String latsur, String lonsur,
            String este, String lateste, String loneste, String oeste, String latoeste, String lonoeste)
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand();


            comando.Connection = conexionBD;
            comando.CommandText = "update limites set NORTE=@norte, SUR=@sur, ESTE=@este, OESTE=@oeste, LATNORTE=@latnorte," +
                "LONGNORTE=@lonnorte, LATSUR=@latsur, LONGSUR=@lonsur, LATESTE=@lateste, LONGESTE=@loneste, LATOESTE=@latoeste, LONGOESTE=@lonoeste WHERE IDCOMUNIDAD=@id";

            comando.Parameters.AddWithValue("@id", CacheLoginComunidad.idcomunidad);
            comando.Parameters.AddWithValue("@norte", norte);
            comando.Parameters.AddWithValue("@sur", sur);
            comando.Parameters.AddWithValue("@este", este);
            comando.Parameters.AddWithValue("@oeste", oeste);
            comando.Parameters.AddWithValue("@latnorte", latnorte);
            comando.Parameters.AddWithValue("@lonnorte", lonnorte);
            comando.Parameters.AddWithValue("@latsur", latsur);
            comando.Parameters.AddWithValue("@lonsur", lonsur);
            comando.Parameters.AddWithValue("@lateste", lateste);
            comando.Parameters.AddWithValue("@loneste", loneste);
            comando.Parameters.AddWithValue("@latoeste", latoeste);
            comando.Parameters.AddWithValue("@lonoeste", lonoeste);

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

            comando.CommandText = "select NORTE as Norte, LATNORTE as Xn, LONGNORTE as Yn," +
                "SUR as Sur, LATSUR as Xs, LONGSUR as Ys, ESTE as Este, LATESTE as Xe, LONGESTE as Ye," +
                "OESTE as Oeste, LATOESTE as Xo, LONGOESTE as Yo from limites where IDCOMUNIDAD=@idcomunidad";

            comando.Parameters.AddWithValue("@idcomunidad", CacheLoginComunidad.idcomunidad);
            comando.CommandType = System.Data.CommandType.Text;
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            da.Fill(dt);
            conexionBD.Close();
            return dt;
        }
    }
}
