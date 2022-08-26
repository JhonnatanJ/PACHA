using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Fase3;
using System.Data;

namespace CapaNegocio.Fase3
{
    public class ModeloRecursoImportante
    {
        DatosRecursoImportante datosRecursoImportante = new DatosRecursoImportante();
        public String Sector;
        public String TipoRecurso;
        public String Recurso;
        public String Cantidad;
        public String Calidad;
        public String Acceso;
        public String Control;
        public String Notas;

        public void InsertarDatos(String sector, String tipoderecurso, String recurso, String cantidad, String calidad, String acceso, String control, String notas)
        {
            datosRecursoImportante.InsertarDatos(sector, tipoderecurso, recurso, cantidad, calidad, acceso, control, notas);
        }

        public DataTable CargarDGVrecursoImportante()
        {
            return datosRecursoImportante.CargarDGVrecursoImportante();
        }

        public void EliminarRecursoImportante(string item)
        {
            datosRecursoImportante.EliminarRecursoImportante(item);
        }
    }
}
