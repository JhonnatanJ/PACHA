using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class ModeloComunidadLog
    {
        DatosComunidadLog datosComunidad = new DatosComunidadLog();
        public DataTable CargarCombo()
        {
            return datosComunidad.CargarCombo();
        }

        public DataTable CargarComboAdmin()
        {
            return datosComunidad.CargarComboAdmin();
        }

        public void CargarDatosComunidadLog(string nombreComunidad)
        {
            datosComunidad.CargarDatosComunidadLog(nombreComunidad);
        }

        public void InsertarDatosComunidadLog(string id, string nombre)
        {
            datosComunidad.InsertarDatosComunidadLog(id, nombre);
        }
    }
}
