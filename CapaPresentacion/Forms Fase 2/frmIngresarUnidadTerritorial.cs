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
    public partial class frmIngresarUnidadTerritorial : Form
    {
        public frmIngresarUnidadTerritorial()
        {
            InitializeComponent();
        }

        private void btnAsent_Click(object sender, EventArgs e)
        {
            
            frmAsentamientos Asen = new frmAsentamientos();
            Asen.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmHitosGeo hitos = new frmHitosGeo();
            hitos.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmUbicGeo ubgeo = new frmUbicGeo();
            ubgeo.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmEcos ecos = new frmEcos();
            ecos.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmTiempos tiempos = new frmTiempos();
            tiempos.Show();
        }

        public void bloquear()
        {
            txtPais.Enabled = false;
            txtRegion.Enabled = false;
            txtProvincia.Enabled = false;
            txtCanton.Enabled = false;
            txtParroquia.Enabled = false;
            txtNorte.Enabled = false;
            txtLatNor.Enabled = false;
            txtLonNor.Enabled = false;
            txtSur.Enabled = false;
            txtLatSur.Enabled = false;
            txtLonSur.Enabled = false;
            txtEste.Enabled = false;
            txtLatEst.Enabled = false;
            txtLonEst.Enabled = false;
            txtOeste.Enabled = false;
            txtLatOes.Enabled = false;
            txtLonOes.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿El ingreso esta correcto?", "Advertencia", MessageBoxButtons.YesNo);
            ModeloUnidadTerritorial unidadT = new ModeloUnidadTerritorial();
            ModeloLimites limites = new ModeloLimites();

            String pais = txtPais.Text;
            String region = txtRegion.Text;
            String provincia = txtProvincia.Text;
            String canton = txtCanton.Text;
            String parroquia = txtParroquia.Text;
            String norte = txtNorte.Text;
            String latnorte = txtLatNor.Text;
            String lonnorte = txtLonNor.Text;
            String sur = txtSur.Text;
            String latsur = txtLatSur.Text;
            String lonsur = txtLonSur.Text;
            String este = txtEste.Text;
            String lateste = txtLatEst.Text; 
            String loneste = txtLonEst.Text;
            String oeste = txtOeste.Text;
            String latoeste = txtLatOes.Text;
            String lonoeste = txtLonOes.Text;

            if (result == DialogResult.Yes)
            {
                unidadT.InsertarDatos(pais, region, provincia, canton, parroquia);
                limites.InsertarDatos(norte, latnorte, lonnorte, sur, latsur, lonsur, este, lateste, loneste, oeste, latoeste, lonoeste);

                MessageBox.Show("Los datos se agregaron correctamente", "Advertencia", MessageBoxButtons.OK);
                this.bloquear();
            }
        }

        private void btnSector_Click(object sender, EventArgs e)
        {
            frmSector sector = new frmSector();
            sector.Show();
        }
    }
}
