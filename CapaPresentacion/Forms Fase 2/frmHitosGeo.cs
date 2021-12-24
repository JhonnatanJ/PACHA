using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio.Fase2;

namespace CapaPresentacion.Forms_Fase_2
{
    public partial class frmHitosGeo : Form
    {
        public frmHitosGeo()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        public void limpiar()
        {
            cbxTipo.Text = "";
            txtNombre.Text = "";
            txtLatHit.Text = "";
            txtLonHito.Text = "";
        }
        private void btnInsHito_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿El ingreso esta correcto?", "Advertencia", MessageBoxButtons.YesNo);
            ModeloHitos hito = new ModeloHitos();
            String tipo = cbxTipo.Text;
            String nombre = txtNombre.Text;
            String lat = txtLatHit.Text;   
            String lon = txtLonHito.Text;

            if (result == DialogResult.Yes)
            {
                hito.InsertarDatos(tipo, nombre, lat, lon);
                MessageBox.Show("Los datos se agregaron correctamente", "Advertencia", MessageBoxButtons.OK);
                this.limpiar();
            }

        }
    }
}
