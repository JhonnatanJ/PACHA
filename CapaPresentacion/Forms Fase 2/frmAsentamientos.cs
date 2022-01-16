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
    public partial class frmAsentamientos : Form
    {
        public frmAsentamientos()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void limpiar()
        {
            txtNomAsen.Text = "";
            cbxSectorAse.Text = "";
            txtLatAsen.Text = "";
            txtLonAsen.Text = "";
            txtPobla.Text = "";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿El ingreso esta correcto?", "Advertencia", MessageBoxButtons.YesNo);
            ModeloAsentamiento asen = new ModeloAsentamiento();
            String nombre = txtNomAsen.Text;
            String sector = cbxSectorAse.Text;
            String lat = txtLatAsen.Text;
            String lon = txtLonAsen.Text;
            int pobl = Int32.Parse(txtPobla.Text);

            if(result == DialogResult.Yes)
            {
                asen.InsertarDatos(nombre, sector, lat, lon, pobl);
                MessageBox.Show("Los datos se agregaron correctamente", "Advertencia", MessageBoxButtons.OK);
                this.limpiar();
            }
        }

        private void frmAsentamientos_Load(object sender, EventArgs e)
        {
            ModeloSector sector = new ModeloSector();
            cbxSectorAse.DataSource = sector.CargarCombo();
            cbxSectorAse.DisplayMember = "SECTOR";
            cbxSectorAse.Text = "";
        }
    }
}
