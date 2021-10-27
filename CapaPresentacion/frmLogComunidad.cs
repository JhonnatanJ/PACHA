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
using CapaComun;
using CapaComun.Cache;

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
            ModeloComunidadLog comunidadLog = new ModeloComunidadLog();
            comunidadLog.CargarDatosComunidadLog(cboComunidad.Text);
            
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Hide();
        }

        private void labelNombre_Click(object sender, EventArgs e)
        {

        }

        

        private void frmLogComunidad_Load(object sender, EventArgs e)
        {
            ModeloComunidadLog comunidadLog = new ModeloComunidadLog();
            CargarDatosUsuario();
            cboComunidad.DataSource = comunidadLog.CargarCombo();
            cboComunidad.DisplayMember = "NOMBRE";
            

        }
        private void CargarDatosUsuario()
        {
            labelNombre.Text = CacheLoginUsuario.nombres;
            labelApellido.Text = CacheLoginUsuario.apellidos;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
