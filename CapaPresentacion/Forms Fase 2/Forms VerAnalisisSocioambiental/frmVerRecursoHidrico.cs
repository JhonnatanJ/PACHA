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
    public partial class frmVerRecursoHidrico : Form
    {
        public frmVerRecursoHidrico()
        {
            InitializeComponent();
        } 

        private void frmVisualizarRecursoImportante_Load(object sender, EventArgs e)
        {
            ModeloRecursoHidrico recursoHidrico = new ModeloRecursoHidrico();
            dgvRecursoHidrico.DataSource = recursoHidrico.CargarDGVrecurso(); 
        }

        private void btnEliminarClima_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de eliminar la selección?", "Control", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            ModeloRecursoHidrico recurso = new ModeloRecursoHidrico();
            if (result == DialogResult.Yes)
            {
                try
                {
                    DataTable datos = recurso.CargarDGVrecurso();
                    String item = datos.Rows[dgvRecursoHidrico.CurrentRow.Index]["Información"].ToString();
                    recurso.EliminarRecurso(item);
                    dgvRecursoHidrico.DataSource = recurso.CargarDGVrecurso();
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
