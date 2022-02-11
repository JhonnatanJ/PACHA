using CapaComun.Cache;
using CapaDominio;
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
using CapaPresentacion.PanelControl;

namespace CapaPresentacion
{
    public partial class frmPerfilUsuario : Form
    {
        public frmPerfilUsuario()
        {
            InitializeComponent();
            CargarDatosUsuario();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        EncriptarContrasena seguridad = new EncriptarContrasena();
        public void CargarDatosUsuario()
        {
            tbCI.Text = CacheLoginUsuario.ci;
            tbCI.Enabled = false;
            tbContrasena.Text = seguridad.DesEncriptar(CacheLoginUsuario.contrasena);
            tbNombres.Text = CacheLoginUsuario.nombres;
            tbApellidos.Text = CacheLoginUsuario.apellidos;
            tbEmail.Text = CacheLoginUsuario.email;
            tbCelular.Text = CacheLoginUsuario.celular;
        }

        private void btnIngCom_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea Guardar los cambios?", "Control", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
            try { 
                ModeloUsuario logicaUsuario = new ModeloUsuario();
                logicaUsuario.EditarUsuario(seguridad.Encriptar(tbContrasena.Text),tbNombres.Text,tbApellidos.Text,tbEmail.Text,tbCelular.Text);
                MessageBox.Show("Los datos fueron guardados correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("No fue posible guardar la información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        }

        private void frmPerfilUsuario_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(CacheLoginUsuario.rol == "admin")
            {
                frmLogComunidad logAdmin = new frmLogComunidad();
                logAdmin.Show();
                this.Close();
            }
            else
            {
                if(CacheLoginUsuario.rol == "user")
                {
                    frmLogComunidadUser logUser = new frmLogComunidadUser();
                    logUser.Show();
                    this.Close();
                }
            }
        }

        private void lbLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
