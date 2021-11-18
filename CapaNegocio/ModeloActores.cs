using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class ModeloActores
    {
        DatosActores datosActores = new DatosActores();
        public void InsertarDatosActores(string nombreActor, string siglas, string tipo, string unidadAnalisis, string competenciasRel)
        {
            datosActores.InsertarDatosActores(nombreActor, siglas, tipo, unidadAnalisis, competenciasRel);
        }

        public void CargarDatosActores(string nombreActor)
        {
            datosActores.CargarDatosActores(nombreActor);
        }
    }
}
