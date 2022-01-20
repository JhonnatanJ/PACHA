using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace CapaPresentacion.PanelControl
{
    class ValidarCampos
    {
        public bool CampoVacio(String dato)
        {
            if (dato.Equals(""))
            {
                return true;
            }
            return false;
        }

        public bool NumeroTelefono(String celular)
        {
            if(celular.Length > 10 || celular.Length < 10)
            {
                return false;
            }
            else
            {
                int auxCell;
                for(int i=0; i <= 9; i++)
                {
                    auxCell = celular[i];
                    if(auxCell <48 || auxCell > 57)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public bool Email(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*"; //Expresión REGEX para verificar que el email tenga un formato correcto
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            
        }

        public bool Siglas(String siglas)
        {
            if(siglas.Length <=20 && siglas.Length >= 2)
            {
                return true;
            }
            return false;
        }





    }
}
