using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class ModeloActores
    {
        

        DatosActores datosActores = new DatosActores();
        public void InsertarDatosActores(string nombreActor, string siglas, string tipo, string unidadAnalisis, string incidencias, string competenciasRel)
        {
            datosActores.InsertarDatosActores(nombreActor, siglas, tipo, unidadAnalisis, incidencias, competenciasRel);
        }

        public void ModificarActor(string nombre, string nombreActor, string siglas, string tipo, string unidadAnalisis, string incidencias, string competenciasRel)
        {
            datosActores.ModificarActor(nombre, nombreActor, siglas, tipo, unidadAnalisis, incidencias, competenciasRel);
        }

        public void EliminarActor(string nombre)
        {
            datosActores.EliminarActor(nombre);
        }

        public DataTable CargarCombo()
        {
            return datosActores.CargarCombo();
        }

        public DataTable CargarDGV(string nombre)
        {
            return datosActores.CargarDGV(nombre);
        }

        public void CargarDatosActores(string nombreActor)
        {
            datosActores.CargarDatosActores(nombreActor);
        }
    }
}
