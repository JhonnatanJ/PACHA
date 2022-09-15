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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de eliminar la selección?", "Control", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            ModeloBiodiversidad bio = new ModeloBiodiversidad();
            if (result == DialogResult.Yes)
            {
                try
                {
                    DataTable datos = bio.CargarDGVbiodiversidad();
                    String item = datos.Rows[dgvBiodiversidad.CurrentRow.Index]["Información"].ToString();
                    bio.EliminarBiodiversidad(item);
                    dgvBiodiversidad.DataSource = bio.CargarDGVbiodiversidad();
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
