using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class ModeloProyecto
    {
        public String Actor;
        public String Proyecto;
        public String Objetivo;
        public String Responsable;
        public String Cargo;
        public String Telefono;
        public String Email;

        DatosProyecto datosProyecto = new DatosProyecto();
        public DataTable CargarReporteActoresProyecto()
        {
            return datosProyecto.CargarReporteActoresProyecto();
        }
            public void InsertarDatosProyecto(string nombreProyecto, string objetivo, string responsable, string cargo, string telefono, string email)
        {
            datosProyecto.InsertarDatosProyecto(nombreProyecto, objetivo, responsable, cargo, telefono, email);
        }

        public void ModificarProyecto(string nombre, string nombreProyecto, string objetivo, string responsable, string cargo,
            string telefono, string email)
        {
            datosProyecto.ModificarProyecto(nombre, nombreProyecto, objetivo, responsable, cargo, telefono, email);
        }

        public void EliminarProyecto(string nombre)
        {
            datosProyecto.EliminarProyecto(nombre);
        }

        public void EliminarProyectosActor()
        {
            datosProyecto.EliminarProyectosActor();
        }

        public DataTable CargarCombo()
        {
            return datosProyecto.CargarCombo();
        }

        public DataTable CargarDGV(string nombre)
        {
            return datosProyecto.CargarDGV(nombre);
        }
    }
}
