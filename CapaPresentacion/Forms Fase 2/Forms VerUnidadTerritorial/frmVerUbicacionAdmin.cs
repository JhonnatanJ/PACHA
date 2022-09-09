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

namespace CapaPresentacion.Forms_Fase_2.Forms_VerUnidadTerritorial
{
    public partial class frmVerUbicacionAdmin : Form
    {
        public frmVerUbicacionAdmin()
        {
            InitializeComponent();
        } 

        private void frmVisualizarRecursoImportante_Load(object sender, EventArgs e)
        {
            ModeloUnidadTerritorial unidadA = new ModeloUnidadTerritorial();
            dgvUbiAdmin.DataSource = unidadA.CargarDGV();
            //this.dgvRecursoImportante.Columns[0].Visible = false;
        }

        private void btnEliminarClima_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
