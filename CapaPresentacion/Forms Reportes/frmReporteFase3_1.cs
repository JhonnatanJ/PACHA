using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaComun.Cache;

namespace CapaPresentacion.Forms_Reportes
{
    public partial class frmReporteFase3_1 : Form
    {
        public frmReporteFase3_1()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReporteFase3_1_Load(object sender, EventArgs e)
        {
            crReporteFase3_1 rep = new crReporteFase3_1();
            rep.SetParameterValue("idCom", CacheLoginComunidad.idcomunidad);
            crystalReportViewer1.ReportSource = rep;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            crReporteFase3_1 rep = new crReporteFase3_1();
            rep.Refresh();
            rep.SetParameterValue("idCom", CacheLoginComunidad.idcomunidad);
            crystalReportViewer1.ReportSource = rep;
        }
    }
}
