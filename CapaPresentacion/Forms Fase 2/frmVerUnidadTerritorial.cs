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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmVerUnidadTerritorial_Load(object sender, EventArgs e)
        {
            ModeloUnidadTerritorial unidadA = new ModeloUnidadTerritorial();
            dgvUbAd.DataSource = unidadA.CargarDGV();
            ModeloLimites limites = new ModeloLimites();
            dgvLimites.DataSource = limites.CargarDGV();
        }
    }
}
