using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Fase2;

namespace CapaNegocio.Fase2
{
    public class ModeloLimites
    {
        DatosLimites datoslim = new DatosLimites();
        public String Norte;
        public String Sur;
        public String Este;
        public String Oeste;
        public String Latnorte;
        public String Longnorte;
        public String Latsur;
        public String Longsur;
        public String Lateste;
        public String Longeste;
        public String Latoeste;
        public String Longoeste;

        public void InsertarDatos(String norte, String latnorte, String lonnorte, String sur, String latsur, String lonsur,
            String este, String lateste, String loneste, String oeste, String latoeste, String lonoeste)
        {
            datoslim.InsertarDatos(norte, latnorte, lonnorte, sur, latsur, lonsur, este, lateste, loneste, oeste, latoeste, 
                lonoeste);
        }

        public void ModificarDatos(String norte, String latnorte, String lonnorte, String sur, String latsur, String lonsur,
            String este, String lateste, String loneste, String oeste, String latoeste, String lonoeste)
        {
            datoslim.ModificarDatos(norte, latnorte, lonnorte, sur, latsur, lonsur, este, lateste, loneste, oeste, latoeste,
                lonoeste);
        }
        public DataTable CargarDGV()
        {
            return datoslim.CargarDGV();
        }
    }
   
}
