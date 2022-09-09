using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio.Fase3;

namespace CapaPresentacion.Forms_Fase_3
{
    public partial class frmVisualizarRecursoImportante : Form
    {
        public frmVisualizarRecursoImportante()
        {
            InitializeComponent();
        }

        private void frmVisualizarRecursoImportante_Load(object sender, EventArgs e)
        {
            ModeloRecursoImportante recursoImportante = new ModeloRecursoImportante();
            dgvRecursoImportante.DataSource = recursoImportante.CargarDGVrecursoImportante();
            //this.dgvRecursoImportante.Columns[0].Visible = false;
        }

        private void btnEliminarClima_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea eliminar ese recurso?", "Advertencia", MessageBoxButtons.YesNo);
            ModeloRecursoImportante recursoImportante = new ModeloRecursoImportante();
            if (result == DialogResult.Yes)
            {
                recursoImportante.EliminarRecursoImportante(dgvRecursoImportante.CurrentCell.Value.ToString());
                dgvRecursoImportante.DataSource = recursoImportante.CargarDGVrecursoImportante();
            }
            
        }
    }
}
