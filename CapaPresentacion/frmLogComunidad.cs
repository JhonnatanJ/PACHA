using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
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

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de Cerrar Sesión?","Advertencia",MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Login vistaLogin = new Login();
                vistaLogin.Show();
                this.Hide();
            }
            
        }

        private void btnIngCom_Click(object sender, EventArgs e)
        {
            if (cboComunidad.Text.Equals(""))
            {
                MessageBox.Show("'No se ha seleccionado ninguna Comunidad, puede agregar comunidades utilizando el boton Crear Comunidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ModeloComunidadLog comunidadLog = new ModeloComunidadLog();
                comunidadLog.CargarDatosComunidadLog(cboComunidad.Text);

                frmPrincipal principal = new frmPrincipal();
                principal.Show();
                this.Hide();
            }
        }

        private void labelNombre_Click(object sender, EventArgs e)
        {

        }

        

        private void frmLogComunidad_Load(object sender, EventArgs e)
        {
            ModeloComunidadLog comunidadLog = new ModeloComunidadLog();
            CargarDatosUsuario();   //para cargar el nombre y apellido del usuario
            cboComunidad.DataSource = comunidadLog.CargarComboAdmin();
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

        private void frmLogComunidad_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void cboComunidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                btnIngCom_Click(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCrearComunidad crearCom = new frmCrearComunidad();
            crearCom.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmDatosUsuario datosUsuario = new frmDatosUsuario();
            datosUsuario.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmPerfilUsuario usuarioAdmin = new frmPerfilUsuario();
            usuarioAdmin.Show();
            this.Hide();
        }
    }
}
