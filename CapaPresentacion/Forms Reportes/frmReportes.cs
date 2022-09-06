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
            PDFDownloadController pdf = new PDFDownloadController();
            pdf.ReporteActoresProyectos();
        }

        private void btnReporteF1_2_Click(object sender, EventArgs e)
        {
            PDFDownloadController pdf = new PDFDownloadController();
            pdf.ReporteCambioClimatico();
        }

        private void btnFase2_1_Click(object sender, EventArgs e)
        {
            PDFDownloadController pdf = new PDFDownloadController();
            pdf.ReporteUnidadTerritorial();
        }

        private void btnFase2_2_Click(object sender, EventArgs e)
        {
            PDFDownloadController pdf = new PDFDownloadController();
            pdf.ReporteAnalisisSocioambiental();
        }

        private void btnFase2_3_Click(object sender, EventArgs e)
        {
            PDFDownloadController pdf = new PDFDownloadController();
            pdf.ReporteRiesgoClimatico();
        }

        private void btnFase3_1_Click(object sender, EventArgs e)
        {
            PDFDownloadController pdf = new PDFDownloadController();
            pdf.ReporteMediosEstrategicos();
        }
    }
}
