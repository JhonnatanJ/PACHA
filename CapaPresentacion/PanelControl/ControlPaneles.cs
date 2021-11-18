using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CapaPresentacion.PanelControl
{
    class ControlPaneles 
    {        
        public void MostrarOcultarPanel(Panel panel, Button boton)
        {
            if (panel.Visible == true)
            {
                panel.Visible = false;
                boton.BackColor = Color.Transparent;                
            }
            else
            {
                panel.Visible = true;
                boton.BackColor = Color.FromArgb(100, 160, 150);
            }
        }        
    }
}
