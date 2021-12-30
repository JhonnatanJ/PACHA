using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Fase2;
using System.Data;

namespace CapaNegocio.Fase2
{
    public class ModeloBiodiversidad
    {
        DatosBiodiversidad datosBio = new DatosBiodiversidad();

        public void InsertarDatos(String sector, String especie, String bioDec1, String bioDec2, String bioDec3, String bioDec4, String bioDec5, String bioDec6, String bioDec7, String bioDec8)
        {
            datosBio.InsertarDatos(sector, especie, bioDec1, bioDec2, bioDec3, bioDec4, bioDec5, bioDec6, bioDec7, bioDec8);
        }

        public DataTable CargarDGVbiodiversidad()
        {
            return datosBio.CargarDGVbiodiversidad();
        }
    }
}
