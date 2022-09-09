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
using CapaPresentacion.PanelControl;

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
            cboRelacionAnalisis.SelectedIndex = -1;
            cboTipoActor.SelectedIndex = -1;
            cboIncidencias.SelectedIndex = -1;
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
            if (ValidarCamposProyecto(txtnombreProyecto, txtcargo, txtobjetivo, txttelefono, txtresponsable, txtemail))
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
                    try
                    {
                        proyecto.InsertarDatosProyecto(nombreProyecto, objetivo, responsable, cargo, telefono, email);
                        MessageBox.Show("Los datos fueron guardados correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarProyecto();
                    }
                    catch
                    {
                        MessageBox.Show("No fue posible guardar la información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Limpiar();
            txtnombreActor.Enabled = true;
            txtsiglas.Enabled = true;
            cboTipoActor.Enabled = true;
            cboRelacionAnalisis.Enabled = true;
            cboIncidencias.Enabled = true;
            txtcompetenciaRel.Enabled = true;
            btnGuardarActor.Enabled = true;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarActor_Click(object sender, EventArgs e)
        {
            if (ValidarCamposActor(txtnombreActor, txtsiglas, cboTipoActor, cboRelacionAnalisis, cboIncidencias, txtcompetenciaRel))
            {
                DialogResult result = MessageBox.Show("¿La información ingresada es correcta?", "Control", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                ModeloActores actores = new ModeloActores();
                String nombreActor = txtnombreActor.Text;
                String siglas = txtsiglas.Text;
                String tipo = cboTipoActor.Text;
                String unidadAnalisis = cboRelacionAnalisis.Text;
                String incidencias = cboIncidencias.Text;
                String competenciasRel = txtcompetenciaRel.Text;
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        actores.InsertarDatosActores(nombreActor, siglas, tipo, unidadAnalisis, incidencias, competenciasRel);
                        actores.CargarDatosActores(nombreActor);
                        txtnombreActor.Enabled = false;
                        txtsiglas.Enabled = false;
                        cboTipoActor.Enabled = false;
                        cboRelacionAnalisis.Enabled = false;
                        cboIncidencias.Enabled = false;
                        txtcompetenciaRel.Enabled = false;
                        btnGuardarActor.Enabled = false;
                        MessageBox.Show("Los datos fueron guardados correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch
                    {
                        MessageBox.Show("No fue posible guardar la información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
           
        }

        private void btnNuevoProyecto_Click(object sender, EventArgs e)
        {
            Limpiar();
        }


        private bool ValidarCamposActor(TextBox nombre, TextBox siglas, ComboBox tipo, ComboBox unidadAnálisis, ComboBox incidencia, TextBox competencias)
        {
            //bool bandera = true;
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


        private bool ValidarCamposProyecto(TextBox nombre, TextBox cargo, TextBox objetivo, TextBox telefono, TextBox responsable, TextBox email)
        {
            //bool bandera = true;
            ValidarCampos validar = new ValidarCampos();

            if (validar.CampoVacio(nombre.Text) || validar.CampoVacio(cargo.Text) || validar.CampoVacio(objetivo.Text) || validar.CampoVacio(telefono.Text) || validar.CampoVacio(responsable.Text) || validar.CampoVacio(email.Text))
            {
                DialogResult result = MessageBox.Show("Existen campos vacíos, ingrese todos los datos requeridos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //bandera = false;
                return false;
            }
            else
            {
                if (validar.NumeroTelefono(telefono.Text) == false)
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
            //return bandera;
            return true;
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
