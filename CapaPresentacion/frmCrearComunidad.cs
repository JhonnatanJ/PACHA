using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmCrearComunidad : Form
    {
        public frmCrearComunidad()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            frmLogComunidad logCom = new frmLogComunidad();
            logCom.Show();
            this.Hide();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿El ingreso esta correcto?", "Advertencia", MessageBoxButtons.YesNo);
            ModeloComunidadLog comunidadLog = new ModeloComunidadLog();
            

            if (result == DialogResult.Yes)
            {
                comunidadLog.InsertarDatosComunidadLog(txtIDCom.Text, txtnombreComunidad.Text);
                frmLogComunidad logCom = new frmLogComunidad();
                logCom.Show();
                this.Hide();
            }
        }

        private void frmCrearComunidad_Load(object sender, EventArgs e)
        {

        }
    }
}
