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
    public partial class frmVerEventoClimatico : Form
    {
        public frmVerEventoClimatico()
        {
            InitializeComponent();
        } 

        private void frmVisualizarRecursoImportante_Load(object sender, EventArgs e)
        {
            ModeloEventoClimatico eventoClimatico = new ModeloEventoClimatico();
            dgvEventoClimatico.DataSource = eventoClimatico.CargarDGVevento(); 
        }

        private void btnEliminarClima_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de eliminar la selección?", "Control", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            ModeloEventoClimatico clima = new ModeloEventoClimatico();
            if (result == DialogResult.Yes)
            {
                try
                {
                    DataTable datos = clima.CargarDGVevento();
                    String item = datos.Rows[dgvEventoClimatico.CurrentRow.Index]["Sector"].ToString();
                    clima.EliminarEventoClimatico(item);
                    dgvEventoClimatico.DataSource = clima.CargarDGVevento();
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
