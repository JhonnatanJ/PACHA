using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio
{
    public class ModeloUsuario
    {
        DatosUsuario datosUsuario = new DatosUsuario();
        public bool LoginUser(string user, string pass)
        {
            return datosUsuario.Login(user, pass);
        }

        public DataTable CargarDGVUsuario()
        {
            return datosUsuario.CargarDGVUsuarios();
        }

        public void EditarUsuario(string pass, string nombres, string apellidos, string email, string celular)
        {
            datosUsuario.Modificar(pass, nombres, apellidos, email, celular);
        }

        public void AgregarUsuario(string ci, string pass, string nombres, string apellidos, string rol, string email, string celular)
        {
            datosUsuario.Agregar(ci, pass, nombres, apellidos, rol, email, celular);
        }
    }
}
