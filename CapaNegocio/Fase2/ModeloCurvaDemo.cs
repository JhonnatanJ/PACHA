using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Fase2;

namespace CapaNegocio.Fase2
{
    public class ModeloCurvaDemo
    {
        DatosCurvaDemo datosCurva = new DatosCurvaDemo();
        public String Informacion;
        public String Decada1;
        public String Decada2;
        public String Decada3;
        public String Decada4;
        public String Decada5;
        public String Decada6;
        public String Decada7;
        public String Decada8;
        public void InsertarDatos(String informacion, float infDec1, float infDec2, float infDec3, float infDec4, float infDec5, float infDec6, float infDec7, float infDec8)
        {
            datosCurva.InsertarDatos(informacion, infDec1, infDec2, infDec3, infDec4, infDec5, infDec6, infDec7, infDec8);
        }

        public void ModificarDatos(String informacion, float infDec1, float infDec2, float infDec3, float infDec4, float infDec5, float infDec6, float infDec7, float infDec8)
        {
            datosCurva.ModificarDatos(informacion, infDec1, infDec2, infDec3, infDec4, infDec5, infDec6, infDec7, infDec8);
        }

        public DataTable CargarDGVcurva()
        {
            return datosCurva.CargarDGVcurva();
        }

    }
}
