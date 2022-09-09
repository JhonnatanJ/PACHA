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
    public partial class frmVerHitos : Form
    {
        public frmVerHitos()
        {
            InitializeComponent();
        } 

        private void frmVisualizarRecursoImportante_Load(object sender, EventArgs e)
        {
            ModeloHitos hitos = new ModeloHitos();
            dgvHitos.DataSource = hitos.CargarDGV(); 
        }

        private void btnEliminarClima_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de eliminar la selección?", "Control", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            ModeloHitos hito = new ModeloHitos();
            if (result == DialogResult.Yes)
            {
                try
                {
                    DataTable datos = hito.CargarDGV();
                    String item = datos.Rows[dgvHitos.CurrentRow.Index]["Nombre"].ToString();
                    hito.EliminarHito(item);
                    dgvHitos.DataSource = hito.CargarDGV();
                    DialogResult advice = MessageBox.Show("La información fue eliminada", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    DialogResult advice = MessageBox.Show("La información no pudo ser eliminada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
