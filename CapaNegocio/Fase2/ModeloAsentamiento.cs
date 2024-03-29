﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Fase2;
using System.Data;

namespace CapaNegocio.Fase2
{
    
    public class ModeloAsentamiento
    {
        public String Nombre;
        public String Sector;
        public String X;
        public String Y;
        public String Poblacion;
        DatosAsentamiento datos = new DatosAsentamiento();
        public void InsertarDatos(String nombre, String sector, String latitud, String longitud, int poblacion)
        {
            datos.InsertarDatos(nombre, sector, latitud, longitud, poblacion);
        }

        public DataTable CargarDGV()
        {
            return datos.CargarDGV();
        }

        public void EliminarAsentamiento(string item)
        {
            datos.EliminarAsentamiento(item);
        }
    }
}
