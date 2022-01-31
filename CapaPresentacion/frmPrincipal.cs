using CapaComun.Cache;
using CapaPresentacion.Forms_Reportes;
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
using System.Runtime.InteropServices;

namespace CapaPresentacion
{
    public partial class frmPrincipal : Form
    {
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
        }
        ControlPaneles controlPaneles = new ControlPaneles();//Instancia de la clase ControlPaneles
        Panel pnlFaseVisible;//Variable PanelFase
        Panel pnlSubFaseVisible;//Variable PanelSubFase

        #region Barra de Titulo
        private void btnCerrar_Click(object sender, EventArgs e) //pictureBox Cerrar aplicación 
        {
            Application.Exit();
        }
        private void pbMinimizar_Click(object sender, EventArgs e) //pictureBox Minimizar Aplicación
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void label1_Click(object sender, EventArgs e)// label cerrar forms
        {
            OcultarTodosPaneles();
        }

        private void lblNombreComunidad_MouseDown(object sender, MouseEventArgs e)//Evento para Arrastrar Formulario
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]//Archivo para Arrastrar Formulario
        private extern static void ReleaseCapture();//Funcion para Arrastrar Formulario
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]//Archivo para Arrastrar Formulario
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);//Funcion para Arrastrar Formulario
        private void panel1_MouseDown(object sender, MouseEventArgs e)//Evento para arrastrar Formulario
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Apertura de Forms        
        private void btnCambiarComunidad_Click(object sender, EventArgs e) //Boton para Cambiar de Comunidad
        {
            DialogResult result = MessageBox.Show("¿Está seguro de Cambiar de Comunidad?", "Advertencia", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                frmLogComunidad logComunidad = new frmLogComunidad();
                logComunidad.Show();
                this.Hide();
            }
        }

        #endregion

        #region Fase 1
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

        private void btnIngresarCambioClimatico_Click(object sender, EventArgs e)//Abrir Form Ingresar Cambio Climatico
        {
            OcultarTodosPaneles();
            controlPaneles.AbrirUnicoForm(new frmCambioClimatico(), panelContenedor);
        }

        private void button2_Click(object sender, EventArgs e)// Abrir Form Mostrar Cambio Climatico
        {
            OcultarTodosPaneles();
            controlPaneles.AbrirUnicoForm(new frmContexto(), panelContenedor);
        }
        #endregion

        #region Fase 2
        private void btnIngresarUnidadTerritorial_Click(object sender, EventArgs e) //Panel Unidad Territorial 
        {
            OcultarTodosPaneles();
            controlPaneles.AbrirUnicoForm(new Forms_Fase_2.frmIngresarUnidadTerritorial(), panelContenedor);
        }

        private void btnVisualizarUnidadTerritorial_Click(object sender, EventArgs e)
        {
            OcultarTodosPaneles();
            controlPaneles.AbrirUnicoForm(new Forms_Fase_2.frmVerUnidadTerritorial(), panelContenedor);
        }

        private void btnIngresarAnalisisSocioambiental_Click(object sender, EventArgs e)
        {
            OcultarTodosPaneles();
            controlPaneles.AbrirUnicoForm(new Forms_Fase_2.frmIngresarAnalisisSocioambiental(), panelContenedor);
        }

        private void btnVerAnalisisSocioambiental_Click(object sender, EventArgs e)
        {
            OcultarTodosPaneles();
            controlPaneles.AbrirUnicoForm(new Forms_Fase_2.frmVerAnalisisSocioambiental(), panelContenedor);
        }

        private void btnIngresarRiesgoClimatico_Click(object sender, EventArgs e)
        {
            OcultarTodosPaneles();
            controlPaneles.AbrirUnicoForm(new Forms_Fase_2.frmIngresarRiesgoClimatico(), panelContenedor);
        }

        private void btnVerRiesgoClimatico_Click(object sender, EventArgs e)
        {
            OcultarTodosPaneles();
            controlPaneles.AbrirUnicoForm(new Forms_Fase_2.frmVerRiesgoClimatico(), panelContenedor);
        }

        #endregion

        #region Control Paneles
        private void btnFase1_Click(object sender, EventArgs e)//Panel Fase 1
        {
            OcultarTodosPaneles();
            controlPaneles.MostrarOcultarPanel(pnlFase1Submenu, btnFase1);
        }
        private void btnActoresLocales_Click(object sender, EventArgs e) //Panel Actores Locales
        {
            if (pnlOpcCambioClimatico.Visible == true)
            {
                pnlOpcCambioClimatico.Visible = false;
                btnCambioClimatico.BackColor = Color.Transparent;
            }
            controlPaneles.MostrarOcultarPanel(pnlOpcActoresLocales, btnActoresLocales);
        }
        private void button1_Click_1(object sender, EventArgs e)//Panel Cambio Climatico
        {
            if (pnlOpcActoresLocales.Visible == true)
            {
                pnlOpcActoresLocales.Visible = false;
                btnActoresLocales.BackColor = Color.Transparent;

            }
            controlPaneles.MostrarOcultarPanel(pnlOpcCambioClimatico, btnCambioClimatico);
        }

        private void btnFase2_Click(object sender, EventArgs e) // Panel Fase 2
        {
            OcultarTodosPaneles();
            controlPaneles.MostrarOcultarPanel(pnlFase2Submenu, btnFase2);
        }        

        private void btnUnidadTerritorial_Click(object sender, EventArgs e)
        {
            if (pnlAnalisisSocioambiental.Visible == true)
            {
                pnlAnalisisSocioambiental.Visible = false;
                btnAnalisisSocioambiental.BackColor = Color.Transparent;
            }

            if (pnlRiesgoClimatico.Visible == true)
            {
                pnlRiesgoClimatico.Visible = false;
                btnRiesgoClimatico.BackColor = Color.Transparent;
            }

            controlPaneles.MostrarOcultarPanel(pnlUnidadTerritorial, btnUnidadTerritorial);
        }

        private void btnAnalisisSocioambiental_Click(object sender, EventArgs e)
        {
            if (pnlUnidadTerritorial.Visible == true)
            {
                pnlUnidadTerritorial.Visible = false;
                btnUnidadTerritorial.BackColor = Color.Transparent;
            }

            if (pnlRiesgoClimatico.Visible == true)
            {
                pnlRiesgoClimatico.Visible = false;
                btnRiesgoClimatico.BackColor = Color.Transparent;
            }

            controlPaneles.MostrarOcultarPanel(pnlAnalisisSocioambiental, btnAnalisisSocioambiental);
        }

        private void btnRiesgoClimatico_Click(object sender, EventArgs e)
        {
            if (pnlAnalisisSocioambiental.Visible == true)
            {
                pnlAnalisisSocioambiental.Visible = false;
                btnAnalisisSocioambiental.BackColor = Color.Transparent;
            }

            if (pnlUnidadTerritorial.Visible == true)
            {
                pnlUnidadTerritorial.Visible = false;
                btnUnidadTerritorial.BackColor = Color.Transparent;
            }

            controlPaneles.MostrarOcultarPanel(pnlRiesgoClimatico, btnRiesgoClimatico);
        }

        private void btnMediosEstrategiasVida_Click(object sender, EventArgs e)
        {
            controlPaneles.MostrarOcultarPanel(pnlMediosEst, btnMediosEstrategiasVida);
        }

        private void btnIngresarMediosEst_Click(object sender, EventArgs e)
        {
            OcultarTodosPaneles();
            controlPaneles.AbrirUnicoForm(new Forms_Fase_3.frmRecursoImportante(), panelContenedor);
        }

        private void btnVisualizarMediosEst_Click(object sender, EventArgs e)
        {
            OcultarTodosPaneles();
            controlPaneles.AbrirUnicoForm(new Forms_Fase_3.frmVisualizarRecursoImportante(), panelContenedor);
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            OcultarTodosPaneles();
            controlPaneles.AbrirUnicoForm(new Forms_Reportes.frmReportes(), panelContenedor);
        }

        

        private void btnFase3_Click(object sender, EventArgs e) //Panel Fase 3
        {
            OcultarTodosPaneles();
            controlPaneles.MostrarOcultarPanel(pnlFase3Submenu, btnFase3);
        }

        private void button1_Click_2(object sender, EventArgs e)//Panel Reportes
        {
            OcultarTodosPaneles();
            controlPaneles.MostrarOcultarPanel(pnlUsuarios, btnReportes);
        }

        

        #endregion

        #region Funciones

        private void OcultarTodosPaneles()//Funcion para Ocultar Paneles
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
            btnReporte.BackColor = Color.Transparent;
            pnlUnidadTerritorial.Visible = false;
            btnUnidadTerritorial.BackColor = Color.Transparent;
            pnlAnalisisSocioambiental.Visible = false;
            btnAnalisisSocioambiental.BackColor = Color.Transparent;
            pnlRiesgoClimatico.Visible = false;
            btnRiesgoClimatico.BackColor = Color.Transparent;
            pnlMediosEst.Visible = false;
            btnMediosEstrategiasVida.BackColor = Color.Transparent;
        }

        private void btnCambioComunidad_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de Cambiar de Comunidad?", "Advertencia", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                frmLogComunidad logComunidad = new frmLogComunidad();
                logComunidad.Show();
                this.Hide();
            }
        }


        #endregion
    }
}
