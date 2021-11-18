using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class ModeloProyecto
    {
        DatosProyecto datosActores = new DatosProyecto();
        public void InsertarDatosProyecto(string nombreProyecto, string objetivo, string responsable, string cargo, string telefono, string email)
        {
            datosActores.InsertarDatosProyecto(nombreProyecto, objetivo, responsable, cargo, telefono, email);
        }
      
    }
}
