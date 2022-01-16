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
using CapaPresentacion.Forms_Fase_2.Forms_VerAnalisisSocioambiental;

namespace CapaPresentacion.Forms_Fase_2
{
    public partial class frmVerAnalisisSocioambiental : Form
    {
        public frmVerAnalisisSocioambiental()
        {
            InitializeComponent();
        }

        private void btnVerUbiAdmin_Click(object sender, EventArgs e)
        {
            frmVerCurvaDemo obj = new frmVerCurvaDemo();
            obj.Show();
        }

        private void btnVerOcupacion_Click(object sender, EventArgs e)
        {
            frmVerOcupacion obj = new frmVerOcupacion();
            obj.Show();
        }

        private void btnVerRecursos_Click(object sender, EventArgs e)
        {
            frmVerRecursoHidrico obj = new frmVerRecursoHidrico();
            obj.Show();
        }

        private void btnVerBio_Click(object sender, EventArgs e)
        {
            frmVerBiodiversidad obj = new frmVerBiodiversidad();
            obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmVerEventoClimatico obj = new frmVerEventoClimatico();
            obj.Show();
        }
    }
}
