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
    public partial class frmReporteFase2_3 : Form
    {
        public frmReporteFase2_3()
        {
            InitializeComponent();
        }

        private void frmReporteFase1_1_Load(object sender, EventArgs e)
        {
            crReporteFase2_3 rep = new crReporteFase2_3();
            rep.SetParameterValue("idCom", CacheLoginComunidad.idcomunidad);
            crystalReportViewer1.ReportSource = rep;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
