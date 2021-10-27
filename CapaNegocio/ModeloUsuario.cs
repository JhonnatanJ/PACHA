using CapaDatos;
using System;
using System.Collections.Generic;
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
    }
}
