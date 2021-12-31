using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using CapaComun.Cache;
using System.Data;

namespace CapaDatos.Fase3
{
    public class DatosRecursoImportante
    {
        public void InsertarDatos(String sector, String tipoderecurso, String recurso, String cantidad, String calidad, String acceso, String control, String notas)
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand();


            comando.Connection = conexionBD;
            comando.CommandText = "insert into recursosimportantes(IDCOMUNIDAD, SECTOR, TIPORECURSO, RECURSO, CANTIDAD, CALIDAD, ACCESO, CONTROL, NOTAS)" +
                "VALUES (@id, @sector, @tiporecurso, @recurso, @cantidad, @calidad, @acceso, @control, @notas)";

            comando.Parameters.AddWithValue("@id", CacheLoginComunidad.idcomunidad);
            comando.Parameters.AddWithValue("@sector", sector);
            comando.Parameters.AddWithValue("@tiporecurso", tipoderecurso);
            comando.Parameters.AddWithValue("@recurso", recurso);
            comando.Parameters.AddWithValue("@cantidad", cantidad);
            comando.Parameters.AddWithValue("@calidad", calidad);
            comando.Parameters.AddWithValue("@acceso", acceso);
            comando.Parameters.AddWithValue("@control", control);
            comando.Parameters.AddWithValue("@notas", notas);

            comando.CommandType = System.Data.CommandType.Text;
            comando.ExecuteNonQuery();
        }

        public DataTable CargarDGVrecursoImportante()
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand();
            DataTable dt = new DataTable();

            comando.Connection = conexionBD;
            comando.CommandText = "select IDRECURSO as ID, SECTOR as Sector, TIPORECURSO as 'Tipo de Recurso',RECURSO as Recurso, CANTIDAD as Cantidad," +
                "CALIDAD as Calidad, ACCESO as Acceso, CONTROL as Control," +
                "NOTAS as Notas from recursosimportantes " +
                "where IDCOMUNIDAD=@idcomunidad";

            comando.Parameters.AddWithValue("@idcomunidad", CacheLoginComunidad.idcomunidad);
            comando.CommandType = System.Data.CommandType.Text;
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            da.Fill(dt);
            conexionBD.Close();
            return dt;
        }

        public void EliminarRecursoImportante(string item)
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand();

            comando.Connection = conexionBD;
            comando.CommandText = "delete from recursosimportantes where IDRECURSO=@idrecurso";
            comando.Parameters.AddWithValue("@idrecurso", item);
            comando.CommandType = System.Data.CommandType.Text;
            comando.ExecuteNonQuery();
            conexionBD.Close();
        }
    }
}
