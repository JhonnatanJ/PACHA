using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Fase2;

namespace CapaNegocio.Fase2
{
    public class ModeloRiesgoClimatico
    {
        DatosRiesgoClimatico datosRiesgo = new DatosRiesgoClimatico();
        public void InsertarDatos(String sector, String amenaza, String impacto, String respuesta, String riesgo, int importancia, String observacion)
        {
            datosRiesgo.InsertarDatos(sector, amenaza, impacto, respuesta, riesgo, importancia, observacion);
        }
    }
}
