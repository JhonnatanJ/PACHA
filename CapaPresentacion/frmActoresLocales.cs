using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmActoresLocales : Form
    {
        public frmActoresLocales()
        {
            InitializeComponent();
        }

        private void frmActoresLocales_Load(object sender, EventArgs e)
        {

        }

        public void Limpiar()
        {
            txtnombreActor.Text = "";
            txtsiglas.Text = "";
            txttipo.Text = "";
            txtrelacionAnalisis.Text = "";
            txtcompetenciaRel.Text = "";
            txtnombreProyecto.Text = "";
            txtobjetivo.Text = "";
            txtresponsable.Text = "";
            txtcargo.Text = "";
            txttelefono.Text = "";
            txtemail.Text = "";
        }

        public void LimpiarProyecto()
        {
            
            txtnombreProyecto.Text = "";
            txtobjetivo.Text = "";
            txtresponsable.Text = "";
            txtcargo.Text = "";
            txttelefono.Text = "";
            txtemail.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿El ingreso esta correcto?", "Advertencia", MessageBoxButtons.YesNo);
            ModeloProyecto proyecto = new ModeloProyecto();
          
            String nombreProyecto = txtnombreProyecto.Text;
            String objetivo = txtobjetivo.Text;
            String responsable = txtresponsable.Text;
            String cargo = txtcargo.Text;
            String telefono = txttelefono.Text;
            String email = txtemail.Text;

            if (result == DialogResult.Yes)
            {
                proyecto.InsertarDatosProyecto(nombreProyecto, objetivo, responsable, cargo, telefono, email);
                LimpiarProyecto();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Limpiar();
            txtnombreActor.Enabled = true;
            txtsiglas.Enabled = true;
            txttipo.Enabled = true;
            txtrelacionAnalisis.Enabled = true;
            txtcompetenciaRel.Enabled = true;
            btnGuardarActor.Enabled = true;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarActor_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿El ingreso esta correcto?", "Advertencia", MessageBoxButtons.YesNo);
            ModeloActores actores = new ModeloActores();
            String nombreActor = txtnombreActor.Text;
            String siglas = txtsiglas.Text;
            String tipo = txttipo.Text;
            String unidadAnalisis = txtrelacionAnalisis.Text;
            String competenciasRel = txtcompetenciaRel.Text;
            if (result == DialogResult.Yes)
            {
                actores.InsertarDatosActores(nombreActor, siglas, tipo, unidadAnalisis, competenciasRel);
                actores.CargarDatosActores(nombreActor);
                txtnombreActor.Enabled = false;
                txtsiglas.Enabled = false;
                txttipo.Enabled = false;
                txtrelacionAnalisis.Enabled = false;
                txtcompetenciaRel.Enabled = false;
                btnGuardarActor.Enabled = false;
            }
           
        }
    }
}
