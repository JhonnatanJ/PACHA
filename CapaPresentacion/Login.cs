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
using CapaDominio;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
                        
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void tbUsuario_Enter(object sender, EventArgs e)
        {

        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            ModeloUsuario usuario = new ModeloUsuario();
            var validarLogin = usuario.LoginUser(tbUsuario.Text, tbContrasena.Text);

            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                if (validarLogin == true)
                {
                    frmLogComunidad vistaPrincipal = new frmLogComunidad();
                    vistaPrincipal.Show();
                    this.Hide();
                }
                else
                {
                    MsgError("Usuario o Contraseña Incorrectos");
                    tbUsuario.Clear();
                    tbContrasena.Clear();
                    tbUsuario.Focus();
                }
            }
            else
            {
                MsgError("Datos Incorrectos");
            }
        }

        private void tbUsuario_Validating(object sender, CancelEventArgs e)
        {
            bool bandera = true;

            if (String.IsNullOrEmpty(tbUsuario.Text)){
                e.Cancel = true;
                errorProvider1.SetError(tbUsuario, "Campo vacío");
            }
            else {
                foreach (char caracter in tbUsuario.Text)
                {
                    if (char.IsLetter(caracter))
                    {
                        bandera = false;
                        break;                        
                    }
                    else
                    {
                        errorProvider1.SetError(tbUsuario,"");
                        bandera = true;
                    }
                }

                if (bandera)
                {
                    errorProvider1.SetError(tbUsuario,"");
                }
                else
                {
                    e.Cancel = true;
                    errorProvider1.SetError(tbUsuario,"Ingrese solo números");
                }
                
            }
        }

        private void tbUsuario_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbUsuario, "");
        }
              

        private void tbContrasena_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(tbContrasena.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbContrasena, "Campo vacío");
            }
        }

        private void tbContrasena_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbContrasena, "");
        }

        //-------------------------------------------- VALIDACIONES --------------------------------------------
        private void MsgError(string msg) // Mensaje de error
        {
            lblError.Text = "    " + msg;
            lblError.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
