using CapaComun.Cache;
using CapaPresentacion.PanelControl;
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
    public partial class frmPrincipal : Form
    {
        ControlPaneles controlPaneles = new ControlPaneles();
        Panel pnlFaseVisible;
        Panel pnlSubFaseVisible;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlFaseVisible = pnlFase1Submenu;
            pnlSubFaseVisible = pnlOpcActoresLocales;
            lblNombreComunidad.Text = (CacheLoginComunidad.nombre).ToUpper();
            OcultarTodosPaneles();
            AbrirFormPanelContenedor(new frmPanelContenedor());
        }

        private void OcultarTodosPaneles()
        {
            pnlFase1Submenu.Visible = false;
            btnFase1.BackColor = Color.Transparent;
            pnlFase2Submenu.Visible = false;
            btnFase2.BackColor = Color.Transparent;
            pnlFase3Submenu.Visible = false;
            btnFase3.BackColor = Color.Transparent;
            pnlOpcActoresLocales.Visible = false;
            btnActoresLocales.BackColor = Color.Transparent;
            pnlOpcCambioClimatico.Visible = false;
            btnCambioClimatico.BackColor = Color.Transparent;
            pnlUsuarios.Visible = false;
            btnGestionUsuarios.BackColor = Color.Transparent;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void AbrirFormActoresLocales(object formActoresLocales)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fAL = formActoresLocales as Form;
            fAL.TopLevel = false;
            fAL.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fAL);
            this.panelContenedor.Tag = fAL;
            fAL.Show();
        }

        private void AbrirFormContexto(object formContexto)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fCt = formContexto as Form;
            fCt.TopLevel = false;
            fCt.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fCt);
            this.panelContenedor.Tag = fCt;
            fCt.Show();
        }

        private void AbrirFormPanelContenedor(object formPanelContenedor)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fPC = formPanelContenedor as Form;
            fPC.TopLevel = false;
            fPC.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fPC);
            this.panelContenedor.Tag = fPC;
            fPC.Show();
        }

        private void AbrirFormCambioClimatico(object formCambioClimatico)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fCC = formCambioClimatico as Form;
            fCC.TopLevel = false;
            fCC.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fCC);
            this.panelContenedor.Tag = fCC;
            fCC.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OcultarTodosPaneles();
            AbrirFormActoresLocales(new frmActoresLocales());
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OcultarTodosPaneles();
            AbrirFormContexto(new frmContexto());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OcultarTodosPaneles();
            AbrirFormCambioClimatico(new frmVisualizarActores());
        }

        private void label1_Click(object sender, EventArgs e)
        {
            AbrirFormPanelContenedor(new frmPanelContenedor());
        }

        private void label2_Click(object sender, EventArgs e)
        {
            OcultarTodosPaneles();
        }

        private void btnCambiarComunidad_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de Cambiar de Comunidad?", "Advertencia", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                frmLogComunidad logComunidad = new frmLogComunidad();
                logComunidad.Show();
                this.Hide();
            }            
        }

        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (pnlOpcActoresLocales.Visible == true)
            {
                pnlOpcActoresLocales.Visible = false;
                btnActoresLocales.BackColor = Color.Transparent;

            }
            controlPaneles.MostrarOcultarPanel(pnlOpcCambioClimatico, btnCambioClimatico);
        }

        private void btnFase1_Click(object sender, EventArgs e)
        {
            OcultarTodosPaneles();
            controlPaneles.MostrarOcultarPanel(pnlFase1Submenu, btnFase1);
        }

        private void btnActoresLocales_Click(object sender, EventArgs e)
        {
            if(pnlOpcCambioClimatico.Visible == true)
            {
                pnlOpcCambioClimatico.Visible = false;
                btnCambioClimatico.BackColor = Color.Transparent;
            }
            controlPaneles.MostrarOcultarPanel(pnlOpcActoresLocales, btnActoresLocales);
        }

        private void btnFase2_Click(object sender, EventArgs e)
        {            
            OcultarTodosPaneles();
            controlPaneles.MostrarOcultarPanel(pnlFase2Submenu,btnFase2);
        }

        private void btnUnidadTerritorial_Click(object sender, EventArgs e)
        {

        }

        private void btnFase3_Click(object sender, EventArgs e)
        {
            OcultarTodosPaneles();
            controlPaneles.MostrarOcultarPanel(pnlFase3Submenu,btnFase3);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            OcultarTodosPaneles();
            controlPaneles.MostrarOcultarPanel(pnlUsuarios, btnUsuarios);
        }

        private void btnGestionUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresarCambioClimatico_Click(object sender, EventArgs e)
        {

        }
    }
}
