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
    public partial class frmEventosClimaticos : Form
    {
        public frmEventosClimaticos()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEventosClimaticos_Load(object sender, EventArgs e)
        {
            ModeloSector sector = new ModeloSector();
            cbxSectorEvento.DataSource = sector.CargarCombo();
            cbxSectorEvento.DisplayMember = "SECTOR";
            cbxSectorEvento.Text = "";
        }

        private void limpiar()
        {
            cbxSectorEvento.SelectedIndex = -1;
            cbxAmenazaDec1.SelectedIndex = -1;
            cbxAmenazaDec2.SelectedIndex = -1;
            cbxAmenazaDec3.SelectedIndex = -1;
            cbxAmenazaDec4.SelectedIndex = -1;
            cbxAmenazaDec5.SelectedIndex = -1;
            cbxAmenazaDec6.SelectedIndex = -1;
            cbxAmenazaDec7.SelectedIndex = -1;
            cbxAmenazaDec8.SelectedIndex = -1;

            txtImpactoD1.Text = "";
            txtImpactoD2.Text = "";
            txtImpactoD3.Text = "";
            txtImpactoD4.Text = "";
            txtImpactoD5.Text = "";
            txtImpactoD6.Text = "";
            txtImpactoD7.Text = "";
            txtImpactoD8.Text = "";

            txtRespuestaD1.Text = "";
            txtRespuestaD2.Text = "";
            txtRespuestaD3.Text = "";
            txtRespuestaD4.Text = "";
            txtRespuestaD5.Text = "";
            txtRespuestaD6.Text = "";
            txtRespuestaD7.Text = "";
            txtRespuestaD8.Text = "";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            ModeloEventoClimatico clima = new ModeloEventoClimatico();

            if (cbxSectorEvento.Text != "")
            {
                if (!clima.VerificarCampos(cbxSectorEvento.Text))
                {
                    DialogResult result = MessageBox.Show("¿El ingreso esta correcto?", "Advertencia", MessageBoxButtons.YesNo);
                    ModeloEventoClimatico evento = new ModeloEventoClimatico();

                    String sectorEvento = cbxSectorEvento.Text;

                    String informacion1 = "Amenaza";
                    String inf1dec1 = cbxAmenazaDec1.Text;
                    String inf1dec2 = cbxAmenazaDec2.Text;
                    String inf1dec3 = cbxAmenazaDec3.Text;
                    String inf1dec4 = cbxAmenazaDec4.Text;
                    String inf1dec5 = cbxAmenazaDec5.Text;
                    String inf1dec6 = cbxAmenazaDec6.Text;
                    String inf1dec7 = cbxAmenazaDec8.Text;
                    String inf1dec8 = cbxAmenazaDec7.Text;

                    String informacion2 = "Impactos";
                    String inf2dec1 = txtImpactoD1.Text;
                    String inf2dec2 = txtImpactoD2.Text;
                    String inf2dec3 = txtImpactoD3.Text;
                    String inf2dec4 = txtImpactoD4.Text;
                    String inf2dec5 = txtImpactoD5.Text;
                    String inf2dec6 = txtImpactoD6.Text;
                    String inf2dec7 = txtImpactoD7.Text;
                    String inf2dec8 = txtImpactoD8.Text;

                    String informacion3 = "Respuestas";
                    String inf3dec1 = txtRespuestaD1.Text;
                    String inf3dec2 = txtRespuestaD2.Text;
                    String inf3dec3 = txtRespuestaD3.Text;
                    String inf3dec4 = txtRespuestaD4.Text;
                    String inf3dec5 = txtRespuestaD5.Text;
                    String inf3dec6 = txtRespuestaD6.Text;
                    String inf3dec7 = txtRespuestaD7.Text;
                    String inf3dec8 = txtRespuestaD8.Text;

                    if (result == DialogResult.Yes)
                    {
                        evento.InsertarDatos(sectorEvento, informacion1, inf1dec1, inf1dec2, inf1dec3, inf1dec4, inf1dec5, inf1dec6, inf1dec7, inf1dec8);
                        evento.InsertarDatos(sectorEvento, informacion2, inf2dec1, inf2dec2, inf2dec3, inf2dec4, inf2dec5, inf2dec6, inf2dec7, inf2dec8);
                        evento.InsertarDatos(sectorEvento, informacion3, inf3dec1, inf3dec2, inf3dec3, inf3dec4, inf3dec5, inf3dec6, inf3dec7, inf3dec8);

                        MessageBox.Show("Los datos se agregaron correctamente", "Advertencia", MessageBoxButtons.OK);
                        this.limpiar();
                    }
                }
                else
                {
                    MessageBox.Show("Ya existen datos del " + cbxSectorEvento.Text + " guardados, puede revisar los datos en el apartado de visualizar datos", "Advertencia", MessageBoxButtons.OK);
                }
            }
            else
                MessageBox.Show("Debe elegir un Sector", "Advertencia", MessageBoxButtons.OK);

        }
    }
}
