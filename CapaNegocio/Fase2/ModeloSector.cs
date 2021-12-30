using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Fase2;
using System.Data;

namespace CapaNegocio.Fase2
{
    public class ModeloSector
    {
        DatosSector datosSect = new DatosSector();

        public void InsertarDatos(String nombreSector)
        {
            datosSect.InsertarDatos(nombreSector);
        }

        public DataTable CargarCombo()
        {
            return datosSect.CargarCombo();
        }
    }
}
