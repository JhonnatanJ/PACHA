using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Fase2;
using System.Data;

namespace CapaNegocio.Fase2
{
    public class ModeloRiesgoClimatico
    {
        DatosRiesgoClimatico datosRiesgo = new DatosRiesgoClimatico();
        public String Sector;
        public String Amenaza;
        public String Impacto;
        public String Respuesta;
        public String Riesgo;
        public String Importancia;
        public String Observaciones;
        public void InsertarDatos(String sector, String amenaza, String impacto, String respuesta, String riesgo, int importancia, String observacion)
        {
            datosRiesgo.InsertarDatos(sector, amenaza, impacto, respuesta, riesgo, importancia, observacion);
        }

        public DataTable CargarDGVriesgoClimatico()
        {
            return datosRiesgo.CargarDGVriesgoClimatico();
        }

        public void EliminarRiesgoClimatico(string item)
        {
            datosRiesgo.EliminarRiesgoClimatico(item);
        }
    }
}
