using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Fase2;
using System.Data;

namespace CapaNegocio.Fase2
{
    public class ModeloRecursoHidrico
    {
        DatosRecursoHidrico datosRecurso = new DatosRecursoHidrico();
        public String Informacion;
        public String Decada1;
        public String Decada2;
        public String Decada3;
        public String Decada4;
        public String Decada5;
        public String Decada6;
        public String Decada7;
        public String Decada8;

        public void InsertarDatos(String recHidrico, float recDec1, float recDec2, float recDec3, float recDec4, float recDec5, float recDec6, float recDec7, float recDec8)
        {
            datosRecurso.InsertarDatos(recHidrico, recDec1, recDec2, recDec3, recDec4, recDec5, recDec6, recDec7, recDec8);
        }
        public DataTable CargarDGVrecurso()
        {
            return datosRecurso.CargarDGVrecurso();
        }

        public void EliminarRecurso (string item)
        {
            datosRecurso.EliminarRecurso(item);
        }
    }
}
