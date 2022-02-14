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
                boton.BackColor = Color.FromArgb(239, 124, 29);
            }
        }

        public Form formActivo = null;
        public void AbrirUnicoForm(Form formHijo, Panel panelContenedor)
        {
            if (formActivo != null) formActivo.Close();
            formActivo = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            formHijo.Size = panelContenedor.Size;
            panelContenedor.Controls.Add(formHijo);
            panelContenedor.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }

        public void AbrirMultiForm<FormHijo>(Panel panelContenedor) where FormHijo : Form, new() {
            Form formulario;
            formulario = panelContenedor.Controls.OfType<FormHijo>().FirstOrDefault();

            if(formulario == null)
            {
                formulario = new FormHijo();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelContenedor.Controls.Add(formulario);
                panelContenedor.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }
    }
}
