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

        private void dgvClima_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnEliminarClima_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de eliminar la selección?", "Control", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            ModeloCambioClima clima = new ModeloCambioClima();
            if (result == DialogResult.Yes)
            {
                try
                {
                    DataTable datos = clima.CargarDGVclima();
                    String item = datos.Rows[dgvClima.CurrentRow.Index]["Item"].ToString();
                    clima.EliminarClima(item);
                    dgvClima.DataSource = clima.CargarDGVclima();
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
