using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class ModeloCambioClima
    {
        DatosCambioClima datosClima = new DatosCambioClima();
        public void InsertarDatosClimatico(string lugar, string cambioPotencial, string amenaza, string impactoPrevisto, 
            string riesgoClimatico, string estratSugerida, string politAplicada)
        {
            datosClima.InsertarDatosClimatico(lugar, cambioPotencial, amenaza, impactoPrevisto, riesgoClimatico, 
                estratSugerida, politAplicada);
        }

        public DataTable CargarDGVclima()
        {
            return datosClima.CargarDGVclima();
        }

        public void EliminarClima(string item)
        {
            datosClima.EliminarClima(item);
        }
    }

   

}
