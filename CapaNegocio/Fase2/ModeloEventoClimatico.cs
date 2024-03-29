﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Fase2;
using System.Data;

namespace CapaNegocio.Fase2
{
    public class ModeloEventoClimatico
    {
        DatosEventoClimatico datosEvento = new DatosEventoClimatico();
        public String Sector;
        public String Informacion;
        public String Decada1;
        public String Decada2;
        public String Decada3;
        public String Decada4;
        public String Decada5;
        public String Decada6;
        public String Decada7;
        public String Decada8;
        public void InsertarDatos(String sector, String informacion, String infDec1, String infDec2, String infDec3, String infDec4, String infDec5, String infDec6, String infDec7, String infDec8)
        {
            datosEvento.InsertarDatos(sector, informacion, infDec1, infDec2, infDec3, infDec4, infDec5, infDec6, infDec7, infDec8);
        }

        public DataTable CargarDGVevento()
        {
            return datosEvento.CargarDGVevento();
        }

        public DataTable CargarComboAmenaza(String sector)
        {
            return datosEvento.CargarComboAmenaza(sector);
        }

        public DataTable CargarComboImpacto(String sector, String amenaza)
        {
            return datosEvento.CargarComboImpacto(sector, amenaza);
        }

        public DataTable CargarComboRespuesta(String sector, String amenaza)
        {
            return datosEvento.CargarComboRespuesta(sector, amenaza);
        }

        public bool VerificarCampos(String informacion)
        {
            return datosEvento.VerificarEventoClimatico(informacion);
        }

        public void EliminarEventoClimatico(string item)
        {
            datosEvento.EliminarEventoClimatico(item);
        }
    }
}
