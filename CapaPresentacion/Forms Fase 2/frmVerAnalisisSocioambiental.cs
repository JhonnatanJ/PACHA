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
    public partial class frmVerAnalisisSocioambiental : Form
    {
        public frmVerAnalisisSocioambiental()
        {
            InitializeComponent();
        }

        private void frmVerAnalisisSocioambiental_Load(object sender, EventArgs e)
        {
            ModeloCurvaDemo curvaDemo = new ModeloCurvaDemo();
            dgvCurvaDemo.DataSource = curvaDemo.CargarDGVcurva();

            ModeloOcuTerritorio ocuTerritorio = new ModeloOcuTerritorio();
            dgvOcuTerritorio.DataSource = ocuTerritorio.CargarDGVocupacion();

            ModeloRecursoHidrico recursoHidrico = new ModeloRecursoHidrico();
            dgvRecursoHidrico.DataSource = recursoHidrico.CargarDGVrecurso();

            ModeloBiodiversidad bio = new ModeloBiodiversidad();
            dgvBiodiversidad.DataSource = bio.CargarDGVbiodiversidad();

            ModeloEventoClimatico eventoClimatico = new ModeloEventoClimatico();
            dgvEventoClimatico.DataSource = eventoClimatico.CargarDGVevento();
        }
    }
}
