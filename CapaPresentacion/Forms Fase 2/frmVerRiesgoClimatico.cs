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
    public partial class frmVerRiesgoClimatico : Form
    {
        public frmVerRiesgoClimatico()
        {
            InitializeComponent();
        }

        private void frmVerRiesgoClimatico_Load(object sender, EventArgs e)
        {
            ModeloRiesgoClimatico riesgoClimatico = new ModeloRiesgoClimatico();
            dgvRiesgoClimatico.DataSource = riesgoClimatico.CargarDGVriesgoClimatico();

        }

        private void btnEliminarClima_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea eliminar ese riesgo climatico, se eliminaran sus proyectos?", "Advertencia", MessageBoxButtons.YesNo);
            ModeloRiesgoClimatico riesgoClimatico = new ModeloRiesgoClimatico();
            if (result == DialogResult.Yes)
            {
                riesgoClimatico.EliminarRiesgoClimatico(dgvRiesgoClimatico.CurrentCell.Value.ToString());
                dgvRiesgoClimatico.DataSource = riesgoClimatico.CargarDGVriesgoClimatico();
            }
        }
    }
}
