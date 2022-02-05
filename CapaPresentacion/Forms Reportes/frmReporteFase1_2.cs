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
    public partial class frmReporteFase1_2 : Form
    {
        public frmReporteFase1_2()
        {
            InitializeComponent();
        }

        private void frmReporteFase1_1_Load(object sender, EventArgs e)
        {
            crReporteFase1_2 rep = new crReporteFase1_2();
            rep.SetParameterValue("idCom", CacheLoginComunidad.idcomunidad);
            crystalReportViewer1.ReportSource = rep;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            crReporteFase1_2 obj = new crReporteFase1_2();
            obj.Refresh();
            obj.SetParameterValue("idCom", CacheLoginComunidad.idcomunidad);
            crystalReportViewer1.ReportSource = obj;
        }
    }
}
