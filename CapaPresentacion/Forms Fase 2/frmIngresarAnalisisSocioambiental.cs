﻿using System;
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
    public partial class frmIngresarAnalisisSocioambiental : Form
    {
        public frmIngresarAnalisisSocioambiental()
        {
            InitializeComponent();
            this.ttCurvaDemografica.SetToolTip(this.pbAyuda, "CURVA DEMOGRÁFICA:\nIngrese los datos de las dos primeras filas, las filas restantes\nse calculan automaticámente. No es obligatorio ingresar datos\nen todas las decadas.\n\nOCUPACIÓN DEL TERRITORIO:\nElija un tipo de ocupación y seleccione el nivel de zonificación \nen las decadas de las que se conozca este dato.");

        }


        private void txtD1NoFamiliaChanged(object sender, EventArgs e)
        {
            if(txtD1NoFamilia.Text != "" && txtD1NoPersonas.Text != "")
            {
                if (!Char.IsDigit(txtD1NoFamilia.Text[0]))
                {                    
                    MessageBox.Show("No puede ingresar letras", "Advertencia", MessageBoxButtons.OK);
                    txtD1NoFamilia.Text = "0";
                }
                if (!Char.IsDigit(txtD1NoPersonas.Text[0]))
                {
                    MessageBox.Show("No puede ingresar letras", "Advertencia", MessageBoxButtons.OK);
                    txtD1NoPersonas.Text = "0";
                }

                int aux = 0 + Convert.ToInt32(txtD1NoFamilia.Text) * Convert.ToInt32(txtD1NoPersonas.Text);
                txtD1PobEst.Text = aux.ToString();
                txtD2NoFamilia_TextChanged(sender, e);
            }
            else
                txtD1PobEst.Text = "0";
        }
            
        private void txtD2NoFamilia_TextChanged(object sender, EventArgs e)
        {
            if (txtD2NoFamilia.Text != "" && txtD2NoPersonas.Text != "")
            {
                if (!Char.IsDigit(txtD2NoFamilia.Text[0]))
                {
                    MessageBox.Show("No puede ingresar letras", "Advertencia", MessageBoxButtons.OK);
                    txtD2NoFamilia.Text = "0";
                }
                if (!Char.IsDigit(txtD2NoPersonas.Text[0]))
                {
                    MessageBox.Show("No puede ingresar letras", "Advertencia", MessageBoxButtons.OK);
                    txtD2NoPersonas.Text = "0";
                }

                int aux = 0 + Convert.ToInt32(txtD2NoFamilia.Text) * Convert.ToInt32(txtD2NoPersonas.Text);
                txtD2PobEst.Text = aux.ToString();
                if (txtD1PobEst.Text != "" && Convert.ToInt32(txtD1PobEst.Text)!=0 && Convert.ToInt32(txtD2PobEst.Text) != 0)
                {    
                    decimal x = Convert.ToDecimal(txtD2PobEst.Text) / Convert.ToDecimal(txtD1PobEst.Text);
                    decimal aux2 = (decimal)Math.Log(Convert.ToDouble(x))*10;

                    txtD2TasaAnual.Text = aux2.ToString("N2");
                }
                else
                {
                    txtD2TasaAnual.Text = "0";
                    txtD3TasaAnual.Text = "0";
                }
                txtD3NoFamilia_TextChanged(sender, e);
            }
            else
            {
                txtD2PobEst.Text = "0";
                txtD2TasaAnual.Text = "0";
            }
        }

        private void txtD3NoFamilia_TextChanged(object sender, EventArgs e)
        {
            if (txtD3NoFamilia.Text != "" && txtD3NoPersonas.Text != "")
            {
                if (!Char.IsDigit(txtD3NoFamilia.Text[0]))
                {
                    MessageBox.Show("No puede ingresar letras", "Advertencia", MessageBoxButtons.OK);
                    txtD3NoFamilia.Text = "0";
                }
                if (!Char.IsDigit(txtD3NoPersonas.Text[0]))
                {
                    MessageBox.Show("No puede ingresar letras", "Advertencia", MessageBoxButtons.OK);
                    txtD3NoPersonas.Text = "0";
                }

                int aux = 0 + Convert.ToInt32(txtD3NoFamilia.Text) * Convert.ToInt32(txtD3NoPersonas.Text);
                txtD3PobEst.Text = aux.ToString();
                if (txtD2PobEst.Text != "" && Convert.ToInt32(txtD2PobEst.Text) != 0 && Convert.ToInt32(txtD3PobEst.Text) != 0)
                {
                    decimal x = Convert.ToDecimal(txtD3PobEst.Text) / Convert.ToDecimal(txtD2PobEst.Text);
                    decimal aux2 = (decimal)Math.Log(Convert.ToDouble(x)) * 10;

                    txtD3TasaAnual.Text = aux2.ToString("N2");
                }
                else
                {
                    txtD3TasaAnual.Text = "0";
                    txtD4TasaAnual.Text = "0";
                }
                txtD4NoFamilia_TextChanged(sender, e);
            }
            else
            {
                txtD3PobEst.Text = "0";
                txtD3TasaAnual.Text = "0";
            }
        }

        private void txtD4NoFamilia_TextChanged(object sender, EventArgs e)
        {
            if (txtD4NoFamilia.Text != "" && txtD4NoPersonas.Text != "")
            {
                if (!Char.IsDigit(txtD4NoFamilia.Text[0]))
                {
                    MessageBox.Show("No puede ingresar letras", "Advertencia", MessageBoxButtons.OK);
                    txtD4NoFamilia.Text = "0";
                }
                if (!Char.IsDigit(txtD4NoPersonas.Text[0]))
                {
                    MessageBox.Show("No puede ingresar letras", "Advertencia", MessageBoxButtons.OK);
                    txtD4NoPersonas.Text = "0";
                }

                int aux = 0 + Convert.ToInt32(txtD4NoFamilia.Text) * Convert.ToInt32(txtD4NoPersonas.Text);
                txtD4PobEst.Text = aux.ToString();
                if (txtD3PobEst.Text != "" && Convert.ToInt32(txtD3PobEst.Text) != 0 && Convert.ToInt32(txtD4PobEst.Text) != 0)
                {
                    decimal x = Convert.ToDecimal(txtD4PobEst.Text) / Convert.ToDecimal(txtD3PobEst.Text);
                    decimal aux2 = (decimal)Math.Log(Convert.ToDouble(x)) * 10;

                    txtD4TasaAnual.Text = aux2.ToString("N2");
                }
                else
                {
                    txtD4TasaAnual.Text = "0";
                    txtD5TasaAnual.Text = "0";
                }
                txtD5NoFamilia_TextChanged(sender, e);
            }
            else
            {
                txtD4PobEst.Text = "0";
                txtD4TasaAnual.Text = "0";
            }
        }

        private void txtD5NoFamilia_TextChanged(object sender, EventArgs e)
        {
            if (!Char.IsDigit(txtD5NoFamilia.Text[0]))
            {
                MessageBox.Show("No puede ingresar letras", "Advertencia", MessageBoxButtons.OK);
                txtD5NoFamilia.Text = "0";
            }
            if (!Char.IsDigit(txtD5NoPersonas.Text[0]))
            {
                MessageBox.Show("No puede ingresar letras", "Advertencia", MessageBoxButtons.OK);
                txtD5NoPersonas.Text = "0";
            }

            if (txtD5NoFamilia.Text != "" && txtD5NoPersonas.Text != "")
            {
                int aux = 0 + Convert.ToInt32(txtD5NoFamilia.Text) * Convert.ToInt32(txtD5NoPersonas.Text);
                txtD5PobEst.Text = aux.ToString();
                if (txtD4PobEst.Text != "" && Convert.ToInt32(txtD4PobEst.Text) != 0 && Convert.ToInt32(txtD5PobEst.Text) != 0)
                {
                    decimal x = Convert.ToDecimal(txtD5PobEst.Text) / Convert.ToDecimal(txtD4PobEst.Text);
                    decimal aux2 = (decimal)Math.Log(Convert.ToDouble(x)) * 10;

                    txtD5TasaAnual.Text = aux2.ToString("N2");
                }
                else
                {
                    txtD5TasaAnual.Text = "0";
                    txtD6TasaAnual.Text = "0";
                }
                txtD6NoFamilia_TextChanged(sender, e);
            }
            else
            {
                txtD5PobEst.Text = "0";
                txtD5TasaAnual.Text = "0";
            }
        }

        private void txtD6NoFamilia_TextChanged(object sender, EventArgs e)
        {
            if (txtD6NoFamilia.Text != "" && txtD6NoPersonas.Text != "")
            {

                if (!Char.IsDigit(txtD6NoFamilia.Text[0]))
                {
                    MessageBox.Show("No puede ingresar letras", "Advertencia", MessageBoxButtons.OK);
                    txtD6NoFamilia.Text = "0";
                }
                if (!Char.IsDigit(txtD6NoPersonas.Text[0]))
                {
                    MessageBox.Show("No puede ingresar letras", "Advertencia", MessageBoxButtons.OK);
                    txtD6NoPersonas.Text = "0";
                }

                int aux = 0 + Convert.ToInt32(txtD6NoFamilia.Text) * Convert.ToInt32(txtD6NoPersonas.Text);
                txtD6PobEst.Text = aux.ToString();
                if (txtD5PobEst.Text != "" && Convert.ToInt32(txtD5PobEst.Text) != 0 && Convert.ToInt32(txtD6PobEst.Text) != 0)
                {
                    decimal x = Convert.ToDecimal(txtD6PobEst.Text) / Convert.ToDecimal(txtD5PobEst.Text);
                    decimal aux2 = (decimal)Math.Log(Convert.ToDouble(x)) * 10;

                    txtD6TasaAnual.Text = aux2.ToString("N2");
                }
                else
                {
                    txtD6TasaAnual.Text = "0";
                    txtD7TasaAnual.Text = "0";
                }
                txtD7NoFamilia_TextChanged(sender, e);
            }
            else
            {
                txtD6PobEst.Text = "0";
                txtD6TasaAnual.Text = "0";
            }
        }

        private void txtD7NoFamilia_TextChanged(object sender, EventArgs e)
        {
            if (txtD7NoFamilia.Text != "" && txtD7NoPersonas.Text != "")
            {
                if (!Char.IsDigit(txtD7NoFamilia.Text[0]))
                {
                    MessageBox.Show("No puede ingresar letras", "Advertencia", MessageBoxButtons.OK);
                    txtD7NoFamilia.Text = "0";
                }
                if (!Char.IsDigit(txtD7NoPersonas.Text[0]))
                {
                    MessageBox.Show("No puede ingresar letras", "Advertencia", MessageBoxButtons.OK);
                    txtD7NoPersonas.Text = "0";
                }

                int aux = 0 + Convert.ToInt32(txtD7NoFamilia.Text) * Convert.ToInt32(txtD7NoPersonas.Text);
                txtD7PobEst.Text = aux.ToString();
                if (txtD6PobEst.Text != "" && Convert.ToInt32(txtD6PobEst.Text) != 0 && Convert.ToInt32(txtD7PobEst.Text) != 0)
                {
                    decimal x = Convert.ToDecimal(txtD7PobEst.Text) / Convert.ToDecimal(txtD6PobEst.Text);
                    decimal aux2 = (decimal)Math.Log(Convert.ToDouble(x)) * 10;

                    txtD7TasaAnual.Text = aux2.ToString("N2");
                }
                else
                {
                    txtD7TasaAnual.Text = "0";
                    txtD8TasaAnual.Text = "0";
                }
                txtD8NoFamilia_TextChanged(sender, e);
            }
            else
            {
                txtD7PobEst.Text = "0";
                txtD7TasaAnual.Text = "0";
            }
        }

        private void txtD8NoFamilia_TextChanged(object sender, EventArgs e)
        {
            if (txtD8NoFamilia.Text != "" && txtD8NoPersonas.Text != "")
            {
                if (!Char.IsDigit(txtD8NoFamilia.Text[0]))
                {
                    MessageBox.Show("No puede ingresar letras", "Advertencia", MessageBoxButtons.OK);
                    txtD8NoFamilia.Text = "0";
                }
                if (!Char.IsDigit(txtD8NoPersonas.Text[0]))
                {
                    MessageBox.Show("No puede ingresar letras", "Advertencia", MessageBoxButtons.OK);
                    txtD8NoPersonas.Text = "0";
                }

                int aux = 0 + Convert.ToInt32(txtD8NoFamilia.Text) * Convert.ToInt32(txtD8NoPersonas.Text);
                txtD8PobEst.Text = aux.ToString();
                if (txtD7PobEst.Text != "" && Convert.ToInt32(txtD7PobEst.Text) != 0 && Convert.ToInt32(txtD8PobEst.Text) != 0)
                {
                    decimal x = Convert.ToDecimal(txtD8PobEst.Text) / Convert.ToDecimal(txtD7PobEst.Text);
                    decimal aux2 = (decimal)Math.Log(Convert.ToDouble(x)) * 10;

                    txtD8TasaAnual.Text = aux2.ToString("N2");
                }
            }
            else
            {
                txtD8PobEst.Text = "0";
                txtD8TasaAnual.Text = "0";
            }
        }

        private void bloquear()
        {
            txtD1NoFamilia.Enabled = false;
            txtD2NoFamilia.Enabled = false;
            txtD3NoFamilia.Enabled = false;
            txtD4NoFamilia.Enabled = false;
            txtD5NoFamilia.Enabled = false;
            txtD6NoFamilia.Enabled = false;
            txtD7NoFamilia.Enabled = false;
            txtD8NoFamilia.Enabled = false;

            txtD1NoPersonas.Enabled = false;
            txtD2NoPersonas.Enabled = false;
            txtD3NoPersonas.Enabled = false;
            txtD4NoPersonas.Enabled = false;
            txtD5NoPersonas.Enabled = false;
            txtD6NoPersonas.Enabled = false;
            txtD7NoPersonas.Enabled = false;
            txtD8NoPersonas.Enabled = false;

            btnGuardarCurva.Enabled = false;
        }

        private void btnGuardarCurva_Click(object sender, EventArgs e)
        {
            ModeloCurvaDemo curva = new ModeloCurvaDemo();
            DataTable datos = curva.CargarDGVcurva();

            if (txtD1NoFamilia.Text != "" && txtD2NoFamilia.Text != "" && txtD3NoFamilia.Text != "" && txtD4NoFamilia.Text != "" &&
            txtD5NoFamilia.Text != "" && txtD6NoFamilia.Text != "" && txtD7NoFamilia.Text != "" && txtD8NoFamilia.Text != "" && txtD1NoPersonas.Text != "" &&
            txtD2NoPersonas.Text != "" && txtD3NoPersonas.Text != "" && txtD4NoPersonas.Text != "" && txtD5NoPersonas.Text != "" && txtD6NoPersonas.Text != "" &&
            txtD7NoPersonas.Text != "" && txtD8NoPersonas.Text != "")
            {
                DialogResult result = MessageBox.Show("¿El ingreso esta correcto?", "Advertencia", MessageBoxButtons.YesNo);
                ModeloCurvaDemo curvaDemo = new ModeloCurvaDemo();

                String informacion1 = "NumeroFamilias";
                float inf1dec1 = float.Parse(txtD1NoFamilia.Text);
                float inf1dec2 = float.Parse(txtD2NoFamilia.Text);
                float inf1dec3 = float.Parse(txtD3NoFamilia.Text);
                float inf1dec4 = float.Parse(txtD4NoFamilia.Text);
                float inf1dec5 = float.Parse(txtD5NoFamilia.Text);
                float inf1dec6 = float.Parse(txtD6NoFamilia.Text);
                float inf1dec7 = float.Parse(txtD7NoFamilia.Text);
                float inf1dec8 = float.Parse(txtD8NoFamilia.Text);

                String informacion2 = "NumeroPersonasPromedioPorFamilia";
                float inf2dec1 = float.Parse(txtD1NoPersonas.Text);
                float inf2dec2 = float.Parse(txtD2NoPersonas.Text);
                float inf2dec3 = float.Parse(txtD3NoPersonas.Text);
                float inf2dec4 = float.Parse(txtD4NoPersonas.Text);
                float inf2dec5 = float.Parse(txtD5NoPersonas.Text);
                float inf2dec6 = float.Parse(txtD6NoPersonas.Text);
                float inf2dec7 = float.Parse(txtD7NoPersonas.Text);
                float inf2dec8 = float.Parse(txtD8NoPersonas.Text);

                String informacion3 = "PoblacionEstimada";
                float inf3dec1 = float.Parse(txtD1PobEst.Text);
                float inf3dec2 = float.Parse(txtD2PobEst.Text);
                float inf3dec3 = float.Parse(txtD3PobEst.Text);
                float inf3dec4 = float.Parse(txtD4PobEst.Text);
                float inf3dec5 = float.Parse(txtD5PobEst.Text);
                float inf3dec6 = float.Parse(txtD6PobEst.Text);
                float inf3dec7 = float.Parse(txtD7PobEst.Text);
                float inf3dec8 = float.Parse(txtD8PobEst.Text);

                String informacion4 = "TasaCrecimientoAnual";
                float inf4dec1 = 0;
                float inf4dec2 = float.Parse(txtD2TasaAnual.Text);
                float inf4dec3 = float.Parse(txtD3TasaAnual.Text);
                float inf4dec4 = float.Parse(txtD4TasaAnual.Text);
                float inf4dec5 = float.Parse(txtD5TasaAnual.Text);
                float inf4dec6 = float.Parse(txtD6TasaAnual.Text);
                float inf4dec7 = float.Parse(txtD7TasaAnual.Text);
                float inf4dec8 = float.Parse(txtD8TasaAnual.Text);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        if (datos.Rows.Count == 0)
                        {
                            curvaDemo.InsertarDatos(informacion1, inf1dec1, inf1dec2, inf1dec3, inf1dec4, inf1dec5, inf1dec6, inf1dec7, inf1dec8);
                            curvaDemo.InsertarDatos(informacion2, inf2dec1, inf2dec2, inf2dec3, inf2dec4, inf2dec5, inf2dec6, inf2dec7, inf2dec8);
                            curvaDemo.InsertarDatos(informacion3, inf3dec1, inf3dec2, inf3dec3, inf3dec4, inf3dec5, inf3dec6, inf3dec7, inf3dec8);
                            curvaDemo.InsertarDatos(informacion4, inf4dec1, inf4dec2, inf4dec3, inf4dec4, inf4dec5, inf4dec6, inf4dec7, inf4dec8);
                            MessageBox.Show("Los datos se agregaron correctamente", "Advertencia", MessageBoxButtons.OK);
                        }
                        else
                        {
                            curvaDemo.ModificarDatos(informacion1, inf1dec1, inf1dec2, inf1dec3, inf1dec4, inf1dec5, inf1dec6, inf1dec7, inf1dec8);
                            curvaDemo.ModificarDatos(informacion2, inf2dec1, inf2dec2, inf2dec3, inf2dec4, inf2dec5, inf2dec6, inf2dec7, inf2dec8);
                            curvaDemo.ModificarDatos(informacion3, inf3dec1, inf3dec2, inf3dec3, inf3dec4, inf3dec5, inf3dec6, inf3dec7, inf3dec8);
                            curvaDemo.ModificarDatos(informacion4, inf4dec1, inf4dec2, inf4dec3, inf4dec4, inf4dec5, inf4dec6, inf4dec7, inf4dec8);
                            MessageBox.Show("Los datos se modificaron correctamente", "Advertencia", MessageBoxButtons.OK);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Para poder ingresar curva demográfica debe ingresar los datos de Ubicación Administrativa y Limites, en la FASE 2.1:Unidad Territorial");
                    }
                }
            }
            else
            {
                MessageBox.Show("- Verifique que todos los campos contengan un número. \n- En caso de no tener un dato debe ingresar cero(0)", "Advertencia", MessageBoxButtons.OK);
            }
        }

        private void limpiar()
        {
            cbxInformacion.SelectedIndex = -1;
            cbxOcupDec1.SelectedIndex = -1;
            cbxOcupDec2.SelectedIndex = -1;
            cbxOcupDec3.SelectedIndex = -1;
            cbxOcupDec4.SelectedIndex = -1;
            cbxOcupDec5.SelectedIndex = -1;
            cbxOcupDec6.SelectedIndex = -1;
            cbxOcupDec7.SelectedIndex = -1;
            cbxOcupDec8.SelectedIndex = -1;
            btnGuardarCurva.Enabled = false;
        }

        private void btnGuardarOcupacion_Click(object sender, EventArgs e)
        {
            ModeloOcuTerritorio ocuTerritorio = new ModeloOcuTerritorio();

            if (cbxInformacion.Text != "" && cbxOcupDec1.Text != "" && cbxOcupDec2.Text != "" && cbxOcupDec3.Text != "" && cbxOcupDec4.Text != "" && cbxOcupDec5.Text != "" && cbxOcupDec6.Text != "" && cbxOcupDec7.Text != "" && cbxOcupDec8.Text != "")
            {
                
                if(!ocuTerritorio.VerificarCampos(cbxInformacion.Text))
                {
                    DialogResult result = MessageBox.Show("¿El ingreso esta correcto?", "Advertencia", MessageBoxButtons.YesNo);
                    String informacion = cbxInformacion.Text;
                    String ocuDec1 = cbxOcupDec1.Text;
                    String ocuDec2 = cbxOcupDec2.Text;
                    String ocuDec3 = cbxOcupDec3.Text;
                    String ocuDec4 = cbxOcupDec4.Text;
                    String ocuDec5 = cbxOcupDec5.Text;
                    String ocuDec6 = cbxOcupDec6.Text;
                    String ocuDec7 = cbxOcupDec7.Text;
                    String ocuDec8 = cbxOcupDec8.Text;

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            ocuTerritorio.InsertarDatos(informacion, ocuDec1, ocuDec2, ocuDec3, ocuDec4, ocuDec5, ocuDec6, ocuDec7, ocuDec8);
                            MessageBox.Show("Los datos se agregaron correctamente", "Advertencia", MessageBoxButtons.OK);
                            this.limpiar();
                        }
                        catch
                        {
                            MessageBox.Show("Para poder ingresar Ocupación del Territorio debe ingresar los datos de Ubicación Administrativa y Limites, en la FASE 2.1:Unidad Territorial");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ya existen datos sobre " + cbxInformacion.Text + " guardados, puede revisar los datos en el apartado de visualizar datos" , "Advertencia", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Existen campos vacíos, si no tiene el dato escoja la opción Desconocido", "Advertencia", MessageBoxButtons.OK);
            }
        }

        private void btnRecHidrico_Click(object sender, EventArgs e)
        {
            frmRecursosHidricos recursos = new frmRecursosHidricos();
            recursos.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSector sector = new frmSector();
            sector.Show();
        }

        private void btnBiodiversidad_Click(object sender, EventArgs e)
        {
            frmBiodiversidad bio = new frmBiodiversidad();
            bio.Show();
        }

        private void btnEventos_Click(object sender, EventArgs e)
        {
            frmEventosClimaticos evento = new frmEventosClimaticos();
            evento.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmIngresarAnalisisSocioambiental_Load(object sender, EventArgs e)
        {
            ModeloCurvaDemo curva = new ModeloCurvaDemo();
            DataTable datos = curva.CargarDGVcurva();
            
            if(datos.Rows.Count != 0)
            {
                txtD1NoFamilia.Text = datos.Rows[0]["1950"].ToString();
                txtD2NoFamilia.Text = datos.Rows[0]["1960"].ToString();
                txtD3NoFamilia.Text = datos.Rows[0]["1970"].ToString();
                txtD4NoFamilia.Text = datos.Rows[0]["1980"].ToString();
                txtD5NoFamilia.Text = datos.Rows[0]["1990"].ToString();
                txtD6NoFamilia.Text = datos.Rows[0]["2000"].ToString();
                txtD7NoFamilia.Text = datos.Rows[0]["2010"].ToString();
                txtD8NoFamilia.Text = datos.Rows[0]["2020"].ToString();

                txtD1NoPersonas.Text = datos.Rows[1]["1950"].ToString();
                txtD2NoPersonas.Text = datos.Rows[1]["1960"].ToString();
                txtD3NoPersonas.Text = datos.Rows[1]["1970"].ToString();
                txtD4NoPersonas.Text = datos.Rows[1]["1980"].ToString();
                txtD5NoPersonas.Text = datos.Rows[1]["1990"].ToString();
                txtD6NoPersonas.Text = datos.Rows[1]["2000"].ToString();
                txtD7NoPersonas.Text = datos.Rows[1]["2010"].ToString();
                txtD8NoPersonas.Text = datos.Rows[1]["2020"].ToString();
            }
            

            
        }

        private void txtD1NoPersonas_Validated(object sender, EventArgs e)
        {

        }
    }
}
