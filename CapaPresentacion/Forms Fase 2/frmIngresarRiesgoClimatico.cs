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
    }
}
