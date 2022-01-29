using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Forms_Reportes
{
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnReporteF1_1_Click(object sender, EventArgs e)
        {
            frmReporteFase1_1 obj = new frmReporteFase1_1();
            obj.Show();
        }

        private void btnReporteF1_2_Click(object sender, EventArgs e)
        {
            frmReporteFase1_2 obj = new frmReporteFase1_2();
            obj.Show();
        }

        private void btnFase2_1_Click(object sender, EventArgs e)
        {
            frmReporteFase2_1 obj = new frmReporteFase2_1();
            obj.Show();
        }

        private void btnFase2_2_Click(object sender, EventArgs e)
        {
            frmReporteFase2_2 obj = new frmReporteFase2_2();
            obj.Show();
        }

        private void btnFase2_3_Click(object sender, EventArgs e)
        {
            frmReporteFase2_3 obj = new frmReporteFase2_3();
            obj.Show();
        }

        private void btnFase3_1_Click(object sender, EventArgs e)
        {
            frmReporteFase3_1 obj = new frmReporteFase3_1();
            obj.Show();
        }
    }
}
