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
            cbxLugar.Text = "";
            cbxAmenaza.Text = "";
            txtCambiosPotenciales.Text = "";
            txtEstrSug.Text = "";
            txtImpacto.Text = "";
            txtPoliticas.Text = "";
            txtRiesgo.Text = "";
        }

        private void btnGuardarCambio_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿El ingreso esta correcto?", "Advertencia", MessageBoxButtons.YesNo);
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
                MessageBox.Show("Los datos se agregaron correctamente", "Advertencia", MessageBoxButtons.OK);
                this.Limpiar();
            }
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
