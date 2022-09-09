using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Fase2;

namespace CapaNegocio.Fase2
{
    public class ModeloUnidadTerritorial
    {
        DatosUnidadTerritorial datosUnidad = new DatosUnidadTerritorial();

        public String Pais;
        public String Region;
        public String Provincia;
        public String Canton;
        public String Parroquia;
        public String Comunidad;

        public void InsertarDatos(String pais, String region, String provincia, String canton, String parroquia)
        {
            datosUnidad.InsertarDatos(pais, region, provincia, canton, parroquia);
        }

        public void ModificarDatos(String pais, String region, String provincia, String canton, String parroquia)
        {
            datosUnidad.ModificarDatos(pais, region, provincia, canton, parroquia);
        }

        public DataTable CargarDGV()
        {
            return datosUnidad.CargarDGV();
        }
    }

}
