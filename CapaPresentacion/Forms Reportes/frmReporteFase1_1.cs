using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaComun.Cache;

namespace CapaPresentacion.Forms_Reportes
{
    public partial class frmReporteFase1_1 : Form
    {
        

        public frmReporteFase1_1()
        {
            InitializeComponent();
        }

        private void frmReporteFase1_1_Load(object sender, EventArgs e)
        {
            crReporteFase1_1 obj = new crReporteFase1_1();
            obj.SetParameterValue("idCom",CacheLoginComunidad.idcomunidad);
            crystalReportViewer1.ReportSource = obj;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            crReporteFase1_1 obj = new crReporteFase1_1();
            obj.Refresh();
            obj.SetParameterValue("idCom", CacheLoginComunidad.idcomunidad);
            crystalReportViewer1.ReportSource = obj;
        }
    }
}
