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
    public partial class frmIngresarRiesgoClimatico : Form
    {
        public frmIngresarRiesgoClimatico()
        {
            InitializeComponent();
        }

        private void frmIngresarRiesgoClimatico_Load(object sender, EventArgs e)
        {
            ModeloSector sector = new ModeloSector();
            cbxSectorRiesgo.DataSource = sector.CargarCombo();
            cbxSectorRiesgo.DisplayMember = "SECTOR";
            cbxSectorRiesgo.Text = "";
        }

        private void cbxSectorRiesgo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ModeloEventoClimatico amenaza = new ModeloEventoClimatico();
            String sectorEvento = cbxSectorRiesgo.Text;
            cbxRiesgoAmenaza.DataSource = amenaza.CargarComboAmenaza(sectorEvento);
            cbxRiesgoAmenaza.DisplayMember = "DECADA8";
        }

        private void cbxRiesgoAmenaza_SelectedIndexChanged(object sender, EventArgs e)
        {
            ModeloEventoClimatico amenaza = new ModeloEventoClimatico();
            String sectorEvento = cbxSectorRiesgo.Text;
            String amenazaCombo = cbxRiesgoAmenaza.Text;
            cbxImpactoRiesgo.DataSource = amenaza.CargarComboImpacto(sectorEvento, amenazaCombo);
            cbxImpactoRiesgo.DisplayMember = "DECADA8";
        }


        private void cbxImpactoRiesgo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ModeloEventoClimatico amenaza = new ModeloEventoClimatico();
            String sectorEvento = cbxSectorRiesgo.Text;
            String amenazaCombo = cbxRiesgoAmenaza.Text;
            cbxRespuestaRiesgo.DataSource = amenaza.CargarComboRespuesta(sectorEvento, amenazaCombo);
            cbxRespuestaRiesgo.DisplayMember = "DECADA8";
        }

        private void limpiar()
        {
            cbxSectorRiesgo.Text = "";
            cbxRiesgoAmenaza.Text = "";
            cbxImpactoRiesgo.Text = "";
            cbxRespuestaRiesgo.Text = "";
            txtRiesgo.Text = "";
            cbxImportanciaRiesgo.Text = "";
            txtObservaciones.Text = "";
        }

        private void btnGuardarCambio_Click(object sender, EventArgs e)
        {
            if (cbxSectorRiesgo.Text != "")
            {
                DialogResult result = MessageBox.Show("¿El ingreso esta correcto?", "Advertencia", MessageBoxButtons.YesNo);
                ModeloRiesgoClimatico riesgoClimatico = new ModeloRiesgoClimatico();


                String sector = cbxSectorRiesgo.Text;
                String amenaza = cbxRiesgoAmenaza.Text;
                String impacto = cbxImpactoRiesgo.Text;
                String respuesta = cbxRespuestaRiesgo.Text;
                String riesgo = txtRiesgo.Text;
                int importancia = Convert.ToInt32(cbxImportanciaRiesgo.Text);
                String observacion = txtObservaciones.Text;

                if (result == DialogResult.Yes)
                {
                    riesgoClimatico.InsertarDatos(sector, amenaza, impacto, respuesta, riesgo, importancia, observacion);
                    MessageBox.Show("Los datos se agregaron correctamente", "Advertencia", MessageBoxButtons.OK);
                    this.limpiar();
                }
            }
            else
                MessageBox.Show("Debe elegir un sector y un tipo de recurso", "Advertencia", MessageBoxButtons.OK);
        }
    }
}
