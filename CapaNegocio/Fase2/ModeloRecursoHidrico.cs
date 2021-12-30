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

        public void InsertarDatos(String recHidrico, float recDec1, float recDec2, float recDec3, float recDec4, float recDec5, float recDec6, float recDec7, float recDec8)
        {
            datosRecurso.InsertarDatos(recHidrico, recDec1, recDec2, recDec3, recDec4, recDec5, recDec6, recDec7, recDec8);
        }
        public DataTable CargarDGVrecurso()
        {
            return datosRecurso.CargarDGVrecurso();
        }
    }
}
