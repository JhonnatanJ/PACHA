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
        public frmEditarUsuario(string ci, string nombres, string apellidos, string rol, string email, string celular)
        {
            InitializeComponent();
            tbCI.Text = ci;
            tbCI.Enabled = false;
            tbNombres.Text = nombres;
            tbApellidos.Text = apellidos;
            cboRol.Text = rol;
            tbEmail.Text = email;
            tbCelular.Text = celular;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        EncriptarContrasena seguridad = new EncriptarContrasena();
        public frmEditarUsuario()
        {
            frmEditarUsuario editarUsuario = new frmEditarUsuario();
            
        }

        private void btnIngCom_Click(object sender, EventArgs e)
        {
            if (ValidarCampos(tbCI, tbNombres, tbApellidos, cboRol, tbEmail, tbCelular))
            {
                DialogResult result = MessageBox.Show("¿Desea Guardar los cambios?", "Control", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        ModeloUsuario logicaUsuario = new ModeloUsuario();
                        logicaUsuario.EditarUsuario(CacheLoginUsuario.contrasena, tbNombres.Text, tbApellidos.Text, tbEmail.Text, tbCelular.Text);
                        MessageBox.Show("Los datos fueron guardados correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("No fue posible guardar la información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                DialogResult result = MessageBox.Show("¿Está seguro de reestablecer la contraseña?", "Control", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        EncriptarContrasena seguridad = new EncriptarContrasena();
                        ModeloUsuario logicaUsuario = new ModeloUsuario();
                        logicaUsuario.ReestablecerCont(tbCI.Text, seguridad.Encriptar(tbCI.Text));
                        MessageBox.Show("La contraseña se reestableció correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("No fue posible reestablecer la contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            
        }


        private bool ValidarCampos(TextBox ci, TextBox nombres, TextBox apellidos, ComboBox rol, TextBox email, TextBox celular)
        {
            //bool bandera = true;
            ValidarCampos validar = new ValidarCampos();

            if (validar.CampoVacio(ci.Text) || validar.CampoVacio(nombres.Text) || validar.CampoVacio(apellidos.Text) || validar.CampoVacio(rol.Text) || validar.CampoVacio(email.Text) || validar.CampoVacio(celular.Text))
            {
                DialogResult result = MessageBox.Show("Existen campos vacíos, ingrese todos los datos requeridos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                if (validar.NumeroTelefono(celular.Text) == false)
                {
                    DialogResult result = MessageBox.Show("El número de teléfono está incorrecto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //bandera = false;
                    return false;
                }
                if (validar.Email(email.Text) == false)
                {
                    DialogResult result = MessageBox.Show("El formato de email está incorrecto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //bandera = false;
                    return false;
                }
            }
            return true;
        }
    }
}
