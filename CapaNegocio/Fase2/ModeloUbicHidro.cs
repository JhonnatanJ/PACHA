using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Fase2;
using System.Data;

namespace CapaNegocio.Fase2
{
    public class ModeloUbicHidro
    {
        DatosUbicHidro datos = new DatosUbicHidro();
        public String Nombre;
        public String Codigo;
        public String Nivel;
        public void InsertarDatos(String tipo, String nombre, String codigo, String nivel)
        {
            datos.InsertarDatos(tipo, nombre, codigo, nivel);
        }
        public DataTable CargarDGV()
        {
            return datos.CargarDGV();
        }

        public void EliminarUbicHidro(string item)
        {
            datos.EliminarUbicHidro(item);
        }
    }
}
