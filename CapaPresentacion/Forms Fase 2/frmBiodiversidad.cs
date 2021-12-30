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
    public partial class frmBiodiversidad : Form
    {
        public frmBiodiversidad()
        {
            InitializeComponent();
        }

        private void frmBiodiversidad_Load(object sender, EventArgs e)
        {
            ModeloSector sector = new ModeloSector();
            cbxSectorBio.DataSource = sector.CargarCombo();
            cbxSectorBio.DisplayMember = "SECTOR";
            cbxSectorBio.Text = "";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limpiar()
        {
            cbxSectorBio.Text = "";
            cbxEspecie.Text = "";
            txtBioDec1.Text = "";
            txtBioDec2.Text = "";
            txtBioDec3.Text = "";
            txtBioDec4.Text = "";
            txtBioDec5.Text = "";
            txtBioDec6.Text = "";
            txtBioDec7.Text = "";
            txtBioDec8.Text = "";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if(cbxSectorBio.Text != "" && cbxEspecie.Text != "")
            {
                DialogResult result = MessageBox.Show("¿El ingreso esta correcto?", "Advertencia", MessageBoxButtons.YesNo);
                ModeloBiodiversidad bio = new ModeloBiodiversidad();


                String sector = cbxSectorBio.Text;
                String especie = cbxEspecie.Text;
                String bioDec1 = txtBioDec1.Text;
                String bioDec2 = txtBioDec2.Text;
                String bioDec3 = txtBioDec3.Text;
                String bioDec4 = txtBioDec4.Text;
                String bioDec5 = txtBioDec5.Text;
                String bioDec6 = txtBioDec6.Text;
                String bioDec7 = txtBioDec7.Text;
                String bioDec8 = txtBioDec8.Text;

                if (result == DialogResult.Yes)
                {
                    bio.InsertarDatos(sector, especie, bioDec1, bioDec2, bioDec3, bioDec4, bioDec5, bioDec6, bioDec7, bioDec8);

                    MessageBox.Show("Los datos se agregaron correctamente", "Advertencia", MessageBoxButtons.OK);
                    this.limpiar();
                }
            }
            else
                MessageBox.Show("Debe elegir un Sector y un tipo de Especie", "Advertencia", MessageBoxButtons.OK);

        }
    }
}
