using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmContexto : Form
    {
        public frmContexto()
        {
            InitializeComponent();
        }

        private void frmContexto_Load(object sender, EventArgs e)
        {
            ModeloCambioClima clima = new ModeloCambioClima();
            dgvClima.DataSource = clima.CargarDGVclima();
        }

        private void btnModificarActor_Click(object sender, EventArgs e)
        {
        }

        private void dgvClima_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarClima_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelarClima_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarClima_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea eliminar ese actor, se eliminaran sus proyectos?", "Advertencia", MessageBoxButtons.YesNo);
            ModeloCambioClima clima = new ModeloCambioClima();
            if (result == DialogResult.Yes)
            {
                clima.EliminarClima(dgvClima.CurrentCell.Value.ToString());
                dgvClima.DataSource = clima.CargarDGVclima();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
