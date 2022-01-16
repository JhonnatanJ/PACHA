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
    public partial class frmVerUnidadTerritorial : Form
    {
        public frmVerUnidadTerritorial()
        {
            InitializeComponent();
        }

        private void frmVerUnidadTerritorial_Load(object sender, EventArgs e)
        {
        }

        private void btnVerUbiAdmin_Click(object sender, EventArgs e)
        {
            Forms_VerUnidadTerritorial.frmVerUbicacionAdmin obj = new Forms_VerUnidadTerritorial.frmVerUbicacionAdmin();
            obj.Show();
        }

        private void btnVerLimites_Click(object sender, EventArgs e)
        {
            Forms_VerUnidadTerritorial.frmVerLimites obj = new Forms_VerUnidadTerritorial.frmVerLimites();
            obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Forms_VerUnidadTerritorial.frmVerAsentamientos obj = new Forms_VerUnidadTerritorial.frmVerAsentamientos();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Forms_VerUnidadTerritorial.frmVerHitos obj = new Forms_VerUnidadTerritorial.frmVerHitos();
            obj.Show();
        }

        private void btnVerUbiHidro_Click(object sender, EventArgs e)
        {
            Forms_VerUnidadTerritorial.frmVerUbiHidro obj = new Forms_VerUnidadTerritorial.frmVerUbiHidro();
            obj.Show();
        }

        private void btnVerTiempo_Click(object sender, EventArgs e)
        {
            Forms_VerUnidadTerritorial.frmVerTiempos obj = new Forms_VerUnidadTerritorial.frmVerTiempos();
            obj.Show();
        }

        private void btnVerEcosistema_Click(object sender, EventArgs e)
        {
            Forms_VerUnidadTerritorial.frmVerEcosistemas obj = new Forms_VerUnidadTerritorial.frmVerEcosistemas();
            obj.Show();
        }
    }
}
