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

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlFaseVisible = pnlFase1Submenu;
            pnlSubFaseVisible = pnlOpcActoresLocales;
            lblNombreComunidad.Text = (CacheLoginComunidad.nombre).ToUpper();
            OcultarTodosPaneles();
            controlPaneles.AbrirUnicoForm(new frmPanelContenedor(), panelContenedor);
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


        //                  ABRIR FORMS
        private void label1_Click(object sender, EventArgs e)// Abrir Form Panel Contenedor
        {
            controlPaneles.AbrirUnicoForm(new frmPanelContenedor(), panelContenedor);
        }
        private void button1_Click(object sender, EventArgs e)// Abrir Form Actores Locales
        {
            OcultarTodosPaneles();
            controlPaneles.AbrirUnicoForm(new frmActoresLocales(), panelContenedor);
        }
        private void button3_Click(object sender, EventArgs e) // Abrir Form Visualizar Actores
        {
            OcultarTodosPaneles();
            controlPaneles.AbrirUnicoForm(new frmVisualizarActores(), panelContenedor);
        }
        private void button2_Click(object sender, EventArgs e)// Abrir Form Contexto
        {
            OcultarTodosPaneles();
            controlPaneles.AbrirUnicoForm(new frmContexto(), panelContenedor);
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            OcultarTodosPaneles();
            controlPaneles.AbrirUnicoForm(new frmCambioClimatico(), panelContenedor);
        }

        int lx, ly, sw, sh;//variables tamaño de ventana
        private void pictureBox5_Click(object sender, EventArgs e)//pictureBox Maximizar/Minimizar
        {
            if (this.Size != Screen.PrimaryScreen.WorkingArea.Size)
            {
                lx = this.Location.X;
                ly = this.Location.Y;
                sw = this.Size.Width;
                sh = this.Size.Height;
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            }
            else
            {
                this.Size = new Size(sw, sh);
                this.Location = new Point(lx, ly);
            }
        }
    }
}
