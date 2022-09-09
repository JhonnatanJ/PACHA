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
    public partial class frmIngresarUnidadTerritorial : Form
    {
        public frmIngresarUnidadTerritorial()
        {
            InitializeComponent();
        }

        private void btnAsent_Click(object sender, EventArgs e)
        {
            if (VerificarDatosUnidad() == false)
            {
                frmAsentamientos Asen = new frmAsentamientos();
                Asen.Show();
            }
            else
            {
                MessageBox.Show("Para acceder a esta opción debe ingresar los datos de Ubicación Administrativa y Límites", "Advertencia", MessageBoxButtons.OK);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (VerificarDatosUnidad() == false)
            {
                frmHitosGeo hitos = new frmHitosGeo();
                hitos.Show();
            }
            else
            {
                MessageBox.Show("Para acceder a esta opción debe ingresar los datos de Ubicación Administrativa y Límites", "Advertencia", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (VerificarDatosUnidad() == false)
            {
                frmUbicGeo ubgeo = new frmUbicGeo();
                ubgeo.Show();
            }
            else
            {
                MessageBox.Show("Para acceder a esta opción debe ingresar los datos de Ubicación Administrativa y Límites", "Advertencia", MessageBoxButtons.OK);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (VerificarDatosUnidad() == false)
            {
                frmEcos ecos = new frmEcos();
                ecos.Show();
            }
            else
            {
                MessageBox.Show("Para acceder a esta opción debe ingresar los datos de Ubicación Administrativa y Límites", "Advertencia", MessageBoxButtons.OK);
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (VerificarDatosUnidad() == false)
            {
                frmTiempos tiempos = new frmTiempos();
                tiempos.Show();
            }
            else
            {
                MessageBox.Show("Para acceder a esta opción debe ingresar los datos de Ubicación Administrativa y Límites", "Advertencia", MessageBoxButtons.OK);
            }
        }

        public bool VerificarDatosUnidad()
        {
            ModeloUnidadTerritorial unidadT = new ModeloUnidadTerritorial();
            DataTable datos = unidadT.CargarDGV();

            if (datos.Rows.Count == 0)
            {
                return true;
            }

            return false;
        }

        public bool UAVacia()
        {
            if(txtPais.Text != "" && txtRegion.Text != "" && txtProvincia.Text != "" && txtCanton.Text != "" && txtParroquia.Text != "")
            {
                return true;
            }
            return false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿El ingreso esta correcto?", "Advertencia", MessageBoxButtons.YesNo);
            ModeloUnidadTerritorial unidadT = new ModeloUnidadTerritorial();
            ModeloLimites limites = new ModeloLimites();

            String pais = txtPais.Text;
            String region = txtRegion.Text;
            String provincia = txtProvincia.Text;
            String canton = txtCanton.Text;
            String parroquia = txtParroquia.Text;
            String norte = txtNorte.Text;
            String latnorte = txtLatNor.Text;
            String lonnorte = txtLonNor.Text;
            String sur = txtSur.Text;
            String latsur = txtLatSur.Text;
            String lonsur = txtLonSur.Text;
            String este = txtEste.Text;
            String lateste = txtLatEst.Text; 
            String loneste = txtLonEst.Text;
            String oeste = txtOeste.Text;
            String latoeste = txtLatOes.Text;
            String lonoeste = txtLonOes.Text;

            if (result == DialogResult.Yes && UAVacia() != false)
            {
                if (VerificarDatosUnidad()){
                    unidadT.InsertarDatos(pais, region, provincia, canton, parroquia);
                    limites.InsertarDatos(norte, latnorte, lonnorte, sur, latsur, lonsur, este, lateste, loneste, oeste, latoeste, lonoeste);
                }
                else
                {
                    unidadT.ModificarDatos(pais, region, provincia, canton, parroquia);
                    limites.ModificarDatos(norte, latnorte, lonnorte, sur, latsur, lonsur, este, lateste, loneste, oeste, latoeste, lonoeste);
                }

                MessageBox.Show("Los datos se agregaron correctamente", "Advertencia", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("- Los datos de Ubicación Administrativa no pueden estar vacíos \n- Los datos de límites si se pueden enviar vacíos", "Advertencia", MessageBoxButtons.OK);
            }
        }

        private void btnSector_Click(object sender, EventArgs e)
        {
            if (VerificarDatosUnidad() == false)
            {
                frmSector sector = new frmSector();
                sector.Show();
            }
            else
            {
                MessageBox.Show("Para acceder a esta opción debe ingresar los datos de Ubicación Administrativa y Límites", "Advertencia", MessageBoxButtons.OK);
            }
        }

        private void frmIngresarUnidadTerritorial_Load(object sender, EventArgs e)
        {
            ModeloUnidadTerritorial unidadT = new ModeloUnidadTerritorial();
            ModeloLimites limites = new ModeloLimites();
            DataTable datos = unidadT.CargarDGV();
            DataTable lim = limites.CargarDGV();

            if (datos.Rows.Count != 0)
            {
                txtPais.Text = datos.Rows[0]["Pais"].ToString();
                txtRegion.Text = datos.Rows[0]["Region"].ToString();
                txtProvincia.Text = datos.Rows[0]["Provincia"].ToString();
                txtCanton.Text = datos.Rows[0]["Canton"].ToString();
                txtParroquia.Text = datos.Rows[0]["Parroquia"].ToString();

                txtNorte.Text = lim.Rows[0]["Norte"].ToString();
                txtSur.Text = lim.Rows[0]["Sur"].ToString();
                txtEste.Text = lim.Rows[0]["Este"].ToString();
                txtOeste.Text = lim.Rows[0]["Oeste"].ToString();
                txtLatNor.Text = lim.Rows[0]["Xn"].ToString();
                txtLatSur.Text = lim.Rows[0]["Xs"].ToString();
                txtLatEst.Text = lim.Rows[0]["Xe"].ToString();
                txtLatOes.Text = lim.Rows[0]["Xo"].ToString();
                txtLonNor.Text = lim.Rows[0]["Yn"].ToString();
                txtLonSur.Text = lim.Rows[0]["Ys"].ToString();
                txtLonEst.Text = lim.Rows[0]["Ye"].ToString();
                txtLonOes.Text = lim.Rows[0]["Yo"].ToString();

            }
        }

        private void txtPais_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLatNor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtLatSur_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtLatEst_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtLatOes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtLonNor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtLonSur_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtLonEst_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtLonOes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
