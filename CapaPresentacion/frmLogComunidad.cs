﻿using System;
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
    }
}
