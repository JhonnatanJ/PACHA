using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio.Fase2;

namespace CapaPresentacion.Forms_Fase_2
{
    public partial class frmRecursosHidricos : Form
    {
        public frmRecursosHidricos()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limpiar()
        {
            txtRecDec1.Text = "0.00";
            txtRecDec2.Text = "0.00";
            txtRecDec3.Text = "0.00";
            txtRecDec4.Text = "0.00";
            txtRecDec5.Text = "0.00";
            txtRecDec6.Text = "0.00";
            txtRecDec7.Text = "0.00";
            txtRecDec8.Text = "0.00";

            cbxRecurso.SelectedIndex = -1;
        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            ModeloRecursoHidrico recursoHidrico = new ModeloRecursoHidrico();
            if (cbxRecurso.Text != "")
            {
                if (!recursoHidrico.ValidarRecursosH(cbxRecurso.Text))
                {

                    if (txtRecDec1.Text != "" && txtRecDec2.Text != "" && txtRecDec3.Text != "" && txtRecDec4.Text != "" && txtRecDec5.Text != "" && txtRecDec6.Text != "" && txtRecDec7.Text != "" && txtRecDec8.Text != "")
                    {

                        DialogResult result = MessageBox.Show("¿El ingreso esta correcto?", "Advertencia", MessageBoxButtons.YesNo);
                        ModeloRecursoHidrico recurso = new ModeloRecursoHidrico();
                        String recHidrico = cbxRecurso.Text;

                        float recDec1 = float.Parse(txtRecDec1.Text);
                        float recDec2 = float.Parse(txtRecDec2.Text);
                        float recDec3 = float.Parse(txtRecDec3.Text);
                        float recDec4 = float.Parse(txtRecDec4.Text);
                        float recDec5 = float.Parse(txtRecDec5.Text);
                        float recDec6 = float.Parse(txtRecDec6.Text);
                        float recDec7 = float.Parse(txtRecDec7.Text);
                        float recDec8 = float.Parse(txtRecDec8.Text);

                        if (result == DialogResult.Yes)
                        {
                            recurso.InsertarDatos(recHidrico, recDec1, recDec2, recDec3, recDec4, recDec5, recDec6, recDec7, recDec8);
                            MessageBox.Show("Los datos se agregaron correctamente", "Advertencia", MessageBoxButtons.OK);
                            this.limpiar();
                        }
                    }
                    else
                    {
                        MessageBox.Show("- Verifique que todos los campos contengan un número. \n- En caso de no tener un dato debe ingresar cero(0.00)", "Advertencia", MessageBoxButtons.OK);

                    }
                }
                else
                {
                    MessageBox.Show("Ya existen datos sobre " + cbxRecurso.Text + " guardados, puede revisar los datos en el apartado de visualizar datos", "Advertencia", MessageBoxButtons.OK);

                }
            }
            else
            {
                MessageBox.Show("Debe elegir un tipo de Recurso", "Advertencia", MessageBoxButtons.OK);
            }
                
            
        }

        private void txtRecDec1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtRecDec2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtRecDec3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtRecDec4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtRecDec5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtRecDec6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtRecDec7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtRecDec8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
