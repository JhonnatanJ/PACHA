using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Fase2;
using System.Data;

namespace CapaNegocio.Fase2
{
    public class ModeloHitos
    {
        DatosHitos datos = new DatosHitos();
        public void InsertarDatos(String tipo, String nombre, String latitud, String longitud)
        {
            datos.InsertarDatos(tipo, nombre, latitud, longitud);
        }

        public DataTable CargarDGV()
        {
            return datos.CargarDGV();
        }
    }
}
