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
    public partial class frmSector : Form
    {
        public frmSector()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limpiar()
        {
            txtNombreSector.Text = "";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtNombreSector.Text != "")
            {
                DialogResult result = MessageBox.Show("¿El ingreso esta correcto?", "Advertencia", MessageBoxButtons.YesNo);
                ModeloSector sect = new ModeloSector();
                String nombreSector = txtNombreSector.Text;

                if (result == DialogResult.Yes)
                {
                    sect.InsertarDatos(nombreSector);
                    MessageBox.Show("Los datos se agregaron correctamente", "Advertencia", MessageBoxButtons.OK);
                    this.limpiar();
                }
            }
            else
                MessageBox.Show("Debe ingresar un nombre para crear", "Advertencia", MessageBoxButtons.OK);
        }
    }
}
