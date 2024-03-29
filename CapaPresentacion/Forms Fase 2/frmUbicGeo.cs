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
    public partial class frmUbicGeo : Form
    {
        public frmUbicGeo()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void limpiar()
        {
            cbxTipo.SelectedIndex = -1;
            txtNivel.Text = "";
            txtNombre.Text = "";
            txtCodigo.Text = "";
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(cbxTipo.Text) && !String.IsNullOrWhiteSpace(txtNombre.Text))
            {
                DialogResult result = MessageBox.Show("¿El ingreso esta correcto?", "Advertencia", MessageBoxButtons.YesNo);
                ModeloUbicHidro ubichidro = new ModeloUbicHidro();
                String tipo = cbxTipo.Text;
                String nivel = txtNivel.Text;
                String nombre = txtNombre.Text;
                String codigo = txtCodigo.Text;

                if (result == DialogResult.Yes)
                {
                    ubichidro.InsertarDatos(tipo, nombre, codigo, nivel);
                    MessageBox.Show("Los datos se agregaron correctamente", "Advertencia", MessageBoxButtons.OK);
                    this.limpiar();
                }
            }
            else
            {
                MessageBox.Show("Para guardar debe ingresar datos en el campo Nombre y seleccionar un Tipo", "Advertencia", MessageBoxButtons.OK);
            }
        }
    }
}
