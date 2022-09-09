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
using CapaPresentacion.PanelControl;

namespace CapaPresentacion
{
    public partial class frmVisualizarActores : Form
    {

        //tablaDatosActores obj = new tablaDatosActores();         
        public frmVisualizarActores()
        {
            InitializeComponent();
            this.ttLogVerActor.SetToolTip(this.pbAyuda, "Para ver los datos, seleccione un actor y despues el proyecto.\n Tiene la opción de modificar y eliminar tanto actores como proyectos,\n En caso de no existir actores se deben Ingresar en la opción \"Ingresar Actor\".");
        }

        private void frmCambioClimatico_Load(object sender, EventArgs e)
        {
            panelActor.Visible = false;
            panelActor.Enabled = false;
            panelProyecto.Visible = false;
            panelProyecto.Enabled = false;
            panelInsProy.Visible = false;
            panelInsProy.Enabled = false;
            try
            {
                ModeloActores actores = new ModeloActores();
                cboActores.DataSource = actores.CargarCombo();
                cboActores.DisplayMember = "NOMBRE";
                actores.CargarDatosActores(cboActores.Text);
            }
            catch
            {
                MessageBox.Show("No se pueden cargar los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            try
            {
                ModeloActores actores = new ModeloActores();

                dgvActores.DataSource = actores.CargarDGV(cboActores.Text);
                actores.CargarDatosActores(cboActores.Text);
            }
            catch
            {
                MessageBox.Show("No se pueden cargar los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            try
            {
                ModeloProyecto proyectos = new ModeloProyecto();
                cboProyectos.DataSource = proyectos.CargarCombo();
                cboProyectos.DisplayMember = "NOMBRE";
                if (cboProyectos.Text == "")
                {
                    dgvProyectos.Columns.Clear();
                }
            }
            catch
            {
                MessageBox.Show("No se pueden cargar los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void cboProyectos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ModeloProyecto proyectos = new ModeloProyecto();
                dgvProyectos.DataSource = proyectos.CargarDGV(cboProyectos.Text);
            }
            catch
            {
                MessageBox.Show("No se pueden cargar los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void txtnombreActor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnModificarActor_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloActores actores = new ModeloActores();
                DataTable datos = actores.CargarDGV(cboActores.Text);
                txtnombreActor.Text = datos.Rows[0]["NOMBRE"].ToString();
                txtsiglas.Text = datos.Rows[0]["SIGLAS"].ToString();
                cboModTipoActor.Text = datos.Rows[0]["TIPO"].ToString();
                cboModUnidadAnalisis.Text = datos.Rows[0]["RELACIONES"].ToString();
                cboModIncidencia.Text = datos.Rows[0]["INCIDENCIAS"].ToString();
                txtcompetenciaRel.Text = datos.Rows[0]["COMPETENCIAS RELACIONADAS"].ToString();

                cboActores.Enabled = false;
                cboProyectos.Enabled = false;
                panelActor.Visible = true;
                panelActor.Enabled = true;
                btnEliminarActor.Enabled = false;
                btnEliminarProyecto.Enabled = false;
            }
            catch
            {
                MessageBox.Show("No se seleccionó un actor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnGuardarActor_Click(object sender, EventArgs e)
        {
            if (ValidarCamposActor(txtnombreActor, txtsiglas, cboModTipoActor, cboModUnidadAnalisis, cboModIncidencia, txtcompetenciaRel))
            {
                DialogResult result = MessageBox.Show("¿La información ingresada es correcta?", "Control", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                ModeloActores actores = new ModeloActores();
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        actores.ModificarActor(cboActores.Text, txtnombreActor.Text, txtsiglas.Text, cboModTipoActor.Text, cboModUnidadAnalisis.Text, cboModIncidencia.Text, txtcompetenciaRel.Text);
                        panelActor.Visible = false;
                        panelActor.Enabled = false;
                        cboActores.Enabled = true;
                        cboProyectos.Enabled = true;
                        btnEliminarActor.Enabled = true;
                        btnEliminarProyecto.Enabled = true;
                        cboActores.DataSource = actores.CargarCombo();
                        cboActores.DisplayMember = "NOMBRE";
                        dgvActores.DataSource = actores.CargarDGV(cboActores.Text);
                        actores.CargarDatosActores(cboActores.Text);
                        MessageBox.Show("Los datos fueron guardados correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                    catch
                {
                    MessageBox.Show("No fue posible guardar la información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
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
            if (cboActores.Text != "")
            {
                DialogResult result = MessageBox.Show("¿Desea eliminar el actor?. OJO: Se eliminaran también los proyectos relacionados con el actor.", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                ModeloActores actores = new ModeloActores();
                ModeloProyecto proyecto = new ModeloProyecto();
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        proyecto.EliminarProyectosActor();
                        actores.EliminarActor(cboActores.Text);
                        cboActores.DataSource = actores.CargarCombo();
                        cboActores.DisplayMember = "NOMBRE";
                        dgvActores.DataSource = actores.CargarDGV(cboActores.Text);
                        actores.CargarDatosActores(cboActores.Text);
                    }
                    catch
                    {
                        DialogResult advice = MessageBox.Show("La información fue eliminada", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
            else
            {                
                MessageBox.Show("No se seleccionó un actor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificarProyecto_Click(object sender, EventArgs e)
        {
            ModeloProyecto proyecto = new ModeloProyecto();

            try
            {
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
            catch
            {
                MessageBox.Show("No se seleccionó un Proyecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnGuardarProyecto_Click(object sender, EventArgs e)
        {
            if (ValidarCamposProyecto(txtnombreProyecto, txtcargo, txtobjetivo, txttelefono, txtresponsable, txtemail))
            {
                DialogResult result = MessageBox.Show("¿La información ingresada es correcta?", "Control", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                ModeloProyecto proyecto = new ModeloProyecto();
                if (result == DialogResult.Yes)
                {
                    try
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
                        MessageBox.Show("Los datos fueron guardados correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch
                    {
                        MessageBox.Show("No fue posible guardar la información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
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
            DialogResult result = MessageBox.Show("¿Está seguro de eliminar el proyecto?","Control", MessageBoxButtons.YesNo, MessageBoxIcon.Question);    
            ModeloProyecto proyecto = new ModeloProyecto();
            if (result == DialogResult.Yes)
            {
                try
                {
                    proyecto.EliminarProyecto(cboProyectos.Text);
                    cboProyectos.DataSource = proyecto.CargarCombo();
                    cboProyectos.DisplayMember = "NOMBRE";
                    dgvProyectos.DataSource = proyecto.CargarDGV(cboProyectos.Text);
                    DialogResult advice = MessageBox.Show("La información fue eliminada", "",MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch
                {
                    DialogResult advice = MessageBox.Show("La información no pudo ser eliminada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidarCamposProyecto(txtInsNom, txtInsCarg, txtInsObj, txtInsTel, txtInsResp, txtInsEm))
            {
                DialogResult result = MessageBox.Show("¿La información ingresada es correcta?", "Control", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                ModeloProyecto proyecto = new ModeloProyecto();
                if (result == DialogResult.Yes)
                {
                    try
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
                        MessageBox.Show("Los datos fueron guardados correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("No fue posible guardar la información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    try
                    {
                        cboProyectos.DataSource = proyecto.CargarCombo();
                        cboProyectos.DisplayMember = "NOMBRE";
                        dgvProyectos.DataSource = proyecto.CargarDGV(cboProyectos.Text);
                    }
                    catch
                    {
                        MessageBox.Show("No se pueden cargar los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
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

        private bool ValidarCamposProyecto(TextBox nombre, TextBox cargo, TextBox objetivo, TextBox telefono, TextBox responsable, TextBox email)
        {
            ValidarCampos validar = new ValidarCampos();

            if (validar.CampoVacio(nombre.Text) || validar.CampoVacio(cargo.Text) || validar.CampoVacio(objetivo.Text) || validar.CampoVacio(telefono.Text) || validar.CampoVacio(responsable.Text) || validar.CampoVacio(email.Text))
            {
                DialogResult result = MessageBox.Show("Existen campos vacíos, ingrese todos los datos requeridos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                if (validar.NumeroTelefono(telefono.Text) == false)
                {
                    DialogResult result = MessageBox.Show("El número de teléfono está incorrecto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if(validar.Email(email.Text) == false)
                {
                    DialogResult result = MessageBox.Show("El formato de email está incorrecto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        private bool ValidarCamposActor(TextBox nombre, TextBox siglas, ComboBox tipo, ComboBox unidadAnálisis, ComboBox incidencia, TextBox competencias)
        {
            ValidarCampos validar = new ValidarCampos();

            if (validar.CampoVacio(nombre.Text) || validar.CampoVacio(siglas.Text) || validar.CampoVacio(tipo.Text) || validar.CampoVacio(unidadAnálisis.Text) || validar.CampoVacio(incidencia.Text) || validar.CampoVacio(competencias.Text))
            {
                DialogResult result = MessageBox.Show("Existen campos vacíos, ingrese todos los datos requeridos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                if (validar.Siglas(siglas.Text) == false)
                {
                    DialogResult result = MessageBox.Show("El campo siglas debe contener entre 2 y 20 caracteres", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            return true;
        }

        private void txtInsTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txttelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
