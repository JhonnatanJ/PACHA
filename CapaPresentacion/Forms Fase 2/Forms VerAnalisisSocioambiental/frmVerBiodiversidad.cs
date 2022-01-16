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
using CapaNegocio.Fase3;

namespace CapaPresentacion.Forms_Fase_2.Forms_VerAnalisisSocioambiental
{
    public partial class frmVerBiodiversidad : Form
    {
        public frmVerBiodiversidad()
        {
            InitializeComponent();
        } 

        private void frmVisualizarRecursoImportante_Load(object sender, EventArgs e)
        {
            ModeloBiodiversidad bio = new ModeloBiodiversidad();
            dgvBiodiversidad.DataSource = bio.CargarDGVbiodiversidad(); 
        }

        private void btnEliminarClima_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
