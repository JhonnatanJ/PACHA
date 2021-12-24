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
    public partial class frmEcos : Form
    {
        public frmEcos()
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
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿El ingreso esta correcto?", "Advertencia", MessageBoxButtons.YesNo);
            ModeloEco eco = new ModeloEco();
            String tipo = cbxTipo.Text;
            String nombre = txtNombre.Text;

            if (result == DialogResult.Yes)
            {
                eco.InsertarDatos(tipo, nombre);
                MessageBox.Show("Los datos se agregaron correctamente", "Advertencia", MessageBoxButtons.OK);
                this.limpiar();
            }
        }
    }
}
