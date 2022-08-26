using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Fase2;

namespace CapaNegocio.Fase2
{
    public class ModeloTiempo
    {
        DatosTiempos datos = new DatosTiempos();
        public String Tipo;
        public String Nombre;
        public void InsertarDatos(String tipo, String nombre)
        {
            datos.InsertarDatos(tipo, nombre);
        }

        public DataTable CargarDGV()
        {
            return datos.CargarDGV();
        }
    }
}
