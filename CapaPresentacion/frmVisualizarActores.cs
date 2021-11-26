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
    public partial class frmVisualizarActores : Form
    {

        //tablaDatosActores obj = new tablaDatosActores(); 

        
        public frmVisualizarActores()
        {
            InitializeComponent();
        }

        private void frmCambioClimatico_Load(object sender, EventArgs e)
        {
            panelActor.Visible = false;
            panelActor.Enabled = false;
            panelProyecto.Visible = false;
            panelProyecto.Enabled = false;
            panelInsProy.Visible = false;
            panelInsProy.Enabled = false;
            ModeloActores actores = new ModeloActores();
            cboActores.DataSource = actores.CargarCombo();
            cboActores.DisplayMember = "NOMBRE";
            actores.CargarDatosActores(cboActores.Text);
            //dataGridView1.DataSource = obj.vistatabla();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cboActores_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            ModeloActores actores = new ModeloActores();
            
            dgvActores.DataSource = actores.CargarDGV(cboActores.Text);
            actores.CargarDatosActores(cboActores.Text);

            

            ModeloProyecto proyectos = new ModeloProyecto();
            cboProyectos.DataSource = proyectos.CargarCombo();
            cboProyectos.DisplayMember = "NOMBRE";
            if (cboProyectos.Text == "")
            {
                dgvProyectos.Columns.Clear();
            }


        }

        private void cboProyectos_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            ModeloProyecto proyectos = new ModeloProyecto();
            dgvProyectos.DataSource = proyectos.CargarDGV(cboProyectos.Text);
            
            
            
        }

        private void txtnombreActor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnModificarActor_Click(object sender, EventArgs e)
        {
            ModeloActores actores = new ModeloActores();
            DataTable datos = actores.CargarDGV(cboActores.Text);
            txtnombreActor.Text = datos.Rows[0]["NOMBRE"].ToString();
            txtsiglas.Text = datos.Rows[0]["SIGLAS"].ToString();
            txttipo.Text = datos.Rows[0]["TIPO"].ToString();
            txtrelacionAnalisis.Text = datos.Rows[0]["RELACIONES"].ToString();
            txtcompetenciaRel.Text = datos.Rows[0]["COMPETENCIASRELACIONADAS"].ToString();


            cboActores.Enabled = false;
            cboProyectos.Enabled = false;
            panelActor.Visible = true;
            panelActor.Enabled = true;
            btnEliminarActor.Enabled = false;
            btnEliminarProyecto.Enabled = false;
            
        }

        private void btnGuardarActor_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿El ingreso esta correcto?", "Advertencia", MessageBoxButtons.YesNo);
            ModeloActores actores = new ModeloActores();
            if (result == DialogResult.Yes)
            {
                actores.ModificarActor(cboActores.Text, txtnombreActor.Text, txtsiglas.Text, txttipo.Text, txtrelacionAnalisis.Text, txtIncidencia.Text, txtcompetenciaRel.Text);
                panelActor.Visible = false;
                panelActor.Enabled = false;
                cboActores.Enabled = true;
                cboActores.DataSource = actores.CargarCombo();
                cboActores.DisplayMember = "NOMBRE";
                dgvActores.DataSource = actores.CargarDGV(cboActores.Text);
                actores.CargarDatosActores(cboActores.Text);
       
            }

        }

        private void btnCancelarActor_Click(object sender, EventArgs e)
        {
            panelActor.Visible = false;
            panelActor.Enabled = false;
            cboActores.Enabled = true;
            cboProyectos.Enabled = true;
            btnEliminarActor.Enabled = true;
            btnEliminarProyecto.Enabled = true;
        }

        private void btnEliminarActor_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea eliminar ese actor, se eliminaran sus proyectos?", "Advertencia", MessageBoxButtons.YesNo);
            ModeloActores actores = new ModeloActores();
            ModeloProyecto proyecto = new ModeloProyecto();
            if (result == DialogResult.Yes)
            {
                proyecto.EliminarProyectosActor();
                actores.EliminarActor(cboActores.Text);
                cboActores.DataSource = actores.CargarCombo();
                cboActores.DisplayMember = "NOMBRE";
                dgvActores.DataSource = actores.CargarDGV(cboActores.Text);
                actores.CargarDatosActores(cboActores.Text);
            }
        }

        private void btnModificarProyecto_Click(object sender, EventArgs e)
        {
            ModeloProyecto proyecto = new ModeloProyecto();

            DataTable datos = proyecto.CargarDGV(cboProyectos.Text);
            txtnombreProyecto.Text = datos.Rows[0]["NOMBRE"].ToString();
            txtobjetivo.Text = datos.Rows[0]["OBJETIVO"].ToString();
            txtresponsable.Text = datos.Rows[0]["RESPONSABLE"].ToString();
            txtcargo.Text = datos.Rows[0]["CARGO"].ToString();
            txttelefono.Text = datos.Rows[0]["TELEFONO"].ToString();
            txtemail.Text = datos.Rows[0]["EMAIL"].ToString();
            

            panelProyecto.Visible = true;
            panelProyecto.Enabled = true;
            cboActores.Enabled = false;
            cboProyectos.Enabled = false;
            btnEliminarActor.Enabled = false;
            btnEliminarProyecto.Enabled = false;
        }

        private void btnGuardarProyecto_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿El ingreso esta correcto?", "Advertencia", MessageBoxButtons.YesNo);
            ModeloProyecto proyecto = new ModeloProyecto();
            if (result == DialogResult.Yes)
            {
                proyecto.ModificarProyecto(cboProyectos.Text, txtnombreProyecto.Text, txtobjetivo.Text, txtresponsable.Text,
                txtcargo.Text, txttelefono.Text, txtemail.Text);
                panelProyecto.Visible = false;
                panelProyecto.Enabled = false;
                cboActores.Enabled = true;
                cboProyectos.Enabled = true;
                cboProyectos.DataSource = proyecto.CargarCombo();
                cboProyectos.DisplayMember = "NOMBRE";
                dgvProyectos.DataSource = proyecto.CargarDGV(cboProyectos.Text);
            }
        }

        private void btnCancelarProyecto_Click(object sender, EventArgs e)
        {
            panelProyecto.Visible = false;
            panelProyecto.Enabled = false;
            cboActores.Enabled = true;
            cboProyectos.Enabled = true;
            btnEliminarActor.Enabled = true;
            btnEliminarProyecto.Enabled = true;
        }

        private void btnEliminarProyecto_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea eliminar ese actor, se eliminaran sus proyectos?", "Advertencia", MessageBoxButtons.YesNo);    
            ModeloProyecto proyecto = new ModeloProyecto();
            if (result == DialogResult.Yes)
            {
                proyecto.EliminarProyecto(cboProyectos.Text);
                cboProyectos.DataSource = proyecto.CargarCombo();
                cboProyectos.DisplayMember = "NOMBRE";
                dgvProyectos.DataSource = proyecto.CargarDGV(cboProyectos.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea eliminar ese actor, se eliminaran sus proyectos?", "Advertencia", MessageBoxButtons.YesNo);
            ModeloProyecto proyecto = new ModeloProyecto();
            if (result == DialogResult.Yes)
            {
                proyecto.InsertarDatosProyecto(txtInsNom.Text, txtInsObj.Text, txtInsResp.Text, txtInsCarg.Text, txtInsTel.Text, txtInsEm.Text);
                panelInsProy.Visible = false;
                panelInsProy.Enabled = false;
                cboActores.Enabled = true;
                cboProyectos.Enabled = true;
                btnEliminarActor.Enabled = true;
                btnEliminarProyecto.Enabled = true;
                btnModificarActor.Enabled = true;
                btnModificarProyecto.Enabled = true;

                cboProyectos.DataSource = proyecto.CargarCombo();
                cboProyectos.DisplayMember = "NOMBRE";
                dgvProyectos.DataSource = proyecto.CargarDGV(cboProyectos.Text);
            }
        }

        private void btnInsProy_Click(object sender, EventArgs e)
        {
            cboActores.Enabled = false;
            cboProyectos.Enabled = false;
            panelInsProy.Visible = true;
            panelInsProy.Enabled = true;
            btnEliminarActor.Enabled = false;
            btnEliminarProyecto.Enabled = false;
            btnModificarActor.Enabled = false;
            btnModificarProyecto.Enabled = false;
        }

        private void btnCanIns_Click(object sender, EventArgs e)
        {
            panelInsProy.Visible = false;
            panelInsProy.Enabled = false;
            cboActores.Enabled = true;
            cboProyectos.Enabled = true;
            btnEliminarActor.Enabled = true;
            btnEliminarProyecto.Enabled = true;
            btnModificarActor.Enabled = true;
            btnModificarProyecto.Enabled = true;
        }
    }
}
