﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Fase2;
using System.Data;

namespace CapaNegocio.Fase2
{
    public class ModeloOcuTerritorio
    {
        DatosOcuTerritorio datosOcupacion = new DatosOcuTerritorio();

        public void InsertarDatos(String informacion, String infDec1, String infDec2, String infDec3, String infDec4, String infDec5, String infDec6, String infDec7, String infDec8)
        {
            datosOcupacion.InsertarDatos(informacion, infDec1, infDec2, infDec3, infDec4, infDec5, infDec6, infDec7, infDec8);
        }

        public DataTable CargarDGVocupacion()
        {
            return datosOcupacion.CargarDGVocupacion();
        }
    }
}
