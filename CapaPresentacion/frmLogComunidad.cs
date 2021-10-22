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
    public partial class frmLogComunidad : Form
    {
        public frmLogComunidad()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login vistaLogin = new Login();
            vistaLogin.Show();
            this.Hide();
        }

        private void btnIngCom_Click(object sender, EventArgs e)
        {

        }

        private void labelNombre_Click(object sender, EventArgs e)
        {

        }

        ModeloComunidadLog mod = new ModeloComunidadLog();

        private void frmLogComunidad_Load(object sender, EventArgs e)
        {
            cboComunidad.DataSource = mod.CargarCombo();
            cboComunidad.DisplayMember = "NOMBRE";
            cboComunidad.ValueMember = "CI";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
