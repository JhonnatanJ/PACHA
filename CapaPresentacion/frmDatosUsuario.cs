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
using CapaDominio;

namespace CapaPresentacion
{
    public partial class frmDatosUsuario : Form
    {
        public frmDatosUsuario()
        {
            InitializeComponent();
        }

        private void frmDatosUsuario_Load(object sender, EventArgs e)
        {
            ModeloUsuario datosUsuario = new ModeloUsuario();
            dgUsuarios.DataSource = datosUsuario.CargarDGVUsuario();
        }

        public string ci, nombres, apellidos, rol, email, celular;
        int filaSeleccionada;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnIngCom_Click(object sender, EventArgs e)
        {
            frmAgregarUsuario agregar = new frmAgregarUsuario();
            agregar.Show();
        }

        private void frmDatosUsuario_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SeleccionDatos();
            frmEditarUsuario editar = new frmEditarUsuario(ci,nombres,apellidos,rol,email,celular);
            editar.Show();
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmLogComunidad logAdmin = new frmLogComunidad();
            logAdmin.Show();
            this.Close();
        }

        private void lbLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        public void SeleccionDatos()
        {                   
            try
            {
                filaSeleccionada = dgUsuarios.CurrentRow.Index;
                ModeloUsuario datosUsuario = new ModeloUsuario();
                DataTable datos = datosUsuario.CargarDGVUsuario();
                ci = datos.Rows[filaSeleccionada]["CI"].ToString();
                nombres = datos.Rows[filaSeleccionada]["NOMBRES"].ToString();
                apellidos = datos.Rows[filaSeleccionada]["APELLIDOS"].ToString();
                rol= datos.Rows[filaSeleccionada]["ROL"].ToString();
                email = datos.Rows[filaSeleccionada]["EMAIL"].ToString();
                celular = datos.Rows[filaSeleccionada]["CELULAR"].ToString();                
            }
            catch
            {
                MessageBox.Show("No se seleccionó un Proyecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
