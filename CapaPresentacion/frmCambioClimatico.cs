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
    public partial class frmCambioClimatico : Form
    {

        //tablaDatosActores obj = new tablaDatosActores(); 

        
        public frmCambioClimatico()
        {
            InitializeComponent();
        }

        private void frmCambioClimatico_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = obj.vistatabla();

        }


        public void Limpiar()
        {
            cbxLugar.SelectedIndex = -1;
            cbxAmenaza.SelectedIndex = -1;
            txtCambiosPotenciales.Text = "";
            txtEstrSug.Text = "";
            txtImpacto.Text = "";
            txtPoliticas.Text = "";
            txtRiesgo.Text = "";
        }

        private void btnGuardarCambio_Click(object sender, EventArgs e)
        {
            if (ValidarCamposCambioClimatico(cbxLugar, cbxAmenaza, txtCambiosPotenciales, txtImpacto, txtRiesgo, txtEstrSug, txtPoliticas))
            {
                try
                {
                    DialogResult result = MessageBox.Show("¿La información ingresada es correcta?", "Control", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    ModeloCambioClima actores = new ModeloCambioClima();
                    String lugar = cbxLugar.Text;
                    String cambiosPotenciales = txtCambiosPotenciales.Text;
                    String amenaza = cbxAmenaza.Text;
                    String impactoPrevisto = txtImpacto.Text;
                    String riesgoClimatico = txtRiesgo.Text;
                    String estratSugerida = txtEstrSug.Text;
                    String politAplicada = txtPoliticas.Text;
                    if (result == DialogResult.Yes)
                    {
                        actores.InsertarDatosClimatico(lugar, cambiosPotenciales, amenaza, impactoPrevisto, riesgoClimatico,
                            estratSugerida, politAplicada);
                        MessageBox.Show("Los datos fueron guardados correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Limpiar();
                    }
                }
                catch
                {
                    MessageBox.Show("No fue posible guardar la información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            
        }

        private bool ValidarCamposCambioClimatico(ComboBox lugar, ComboBox amenazas, TextBox cambiosPotenciales, TextBox impactosPrevistos, TextBox riesgosClimaticos, TextBox estrategiasSugeridas, TextBox politicasMarcha)
        {
            //bool bandera = true;
            ValidarCampos validar = new ValidarCampos();

            if (validar.CampoVacio(lugar.Text) || validar.CampoVacio(amenazas.Text) || validar.CampoVacio(cambiosPotenciales.Text) || validar.CampoVacio(impactosPrevistos.Text) || validar.CampoVacio(riesgosClimaticos.Text) || validar.CampoVacio(estrategiasSugeridas.Text) || validar.CampoVacio(politicasMarcha.Text))
            {
                DialogResult result = MessageBox.Show("Existen campos vacíos, ingrese todos los datos requeridos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        
    }
}
