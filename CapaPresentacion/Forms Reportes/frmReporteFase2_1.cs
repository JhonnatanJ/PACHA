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
    public partial class frmReporteFase2_1 : Form
    {
        public frmReporteFase2_1()
        {
            InitializeComponent();
        }

        private void frmReporteFase1_1_Load(object sender, EventArgs e)
        {
            crReporteFase2_1 rep = new crReporteFase2_1();
            rep.SetParameterValue("idCom", CacheLoginComunidad.idcomunidad);
            crSubReporteAsentamiento subrep1 = new crSubReporteAsentamiento();
            subrep1.SetParameterValue("idCom", CacheLoginComunidad.idcomunidad);
            crystalReportViewer1.ReportSource = rep;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
