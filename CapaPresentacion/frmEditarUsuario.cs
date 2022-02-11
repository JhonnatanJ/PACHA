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
    public partial class frmEditarUsuario : Form
    {
        public frmEditarUsuario()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        EncriptarContrasena seguridad = new EncriptarContrasena();
        //public frmEditarUsuario(string ci, string nombres, string apellidos, string rol, string email, string celular)
        //{
        //    frmEditarUsuario editarUsuario = new frmEditarUsuario();
        //    editarUsuario.tbCI.Text = ci;
        //    editarUsuario.tbNombres.Text = nombres;
        //    editarUsuario.tbApellidos.Text = apellidos;
        //    editarUsuario.tbRol.Text = rol;
        //    editarUsuario.tbEmail.Text = email;
        //    editarUsuario.tbCelular.Text = celular;
        //}

        private void btnIngCom_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea Guardar los cambios?", "Control", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
            try { 
                ModeloUsuario logicaUsuario = new ModeloUsuario();
                logicaUsuario.EditarUsuario(CacheLoginUsuario.contrasena,tbNombres.Text,tbApellidos.Text,tbEmail.Text,tbCelular.Text);
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
            this.Close();
        }

        private void lbLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void frmEditarUsuario_Load(object sender, EventArgs e)
        {
            frmDatosUsuario usuario = new frmDatosUsuario();
            frmEditarUsuario editarUsuario = new frmEditarUsuario();
            tbCI.Text = usuario.ci;
            tbNombres.Text = usuario.nombres;
            tbApellidos.Text = usuario.apellidos;
            tbRol.Text = usuario.rol;
            editarUsuario.tbEmail.Text = usuario.email;
            editarUsuario.tbCelular.Text = usuario.celular;
        }
    }
}
