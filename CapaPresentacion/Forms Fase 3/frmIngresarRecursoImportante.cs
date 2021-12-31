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
using CapaNegocio.Fase3;

namespace CapaPresentacion.Forms_Fase_3
{
    public partial class frmRecursoImportante : Form
    {
        public frmRecursoImportante()
        {
            InitializeComponent();
        }
        public class Valor
        {
            public string Value { get; set; }
            public string Index { get; set; }
        }

        private void frmRecursoImportante_Load(object sender, EventArgs e)
        {
            ModeloSector sector = new ModeloSector();
            cbxSectorRecurso.DataSource = sector.CargarCombo();
            cbxSectorRecurso.DisplayMember = "SECTOR";
            cbxSectorRecurso.Text = "";
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Valores = new List<Valor>();

            if (cbxTipoRecurso.Text == "Recursos Naturales")
            {
                Valores.Add(new Valor() { Index = "1", Value = "Suelo (tierra)" });
                Valores.Add(new Valor() { Index = "2", Value = "Luz Solar" });
                Valores.Add(new Valor() { Index = "3", Value = "Minerales" });
                Valores.Add(new Valor() { Index = "4", Value = "Gas Natural" });
                Valores.Add(new Valor() { Index = "5", Value = "Madera" });
                Valores.Add(new Valor() { Index = "6", Value = "Productos silvestres y biodiversidad" });
                Valores.Add(new Valor() { Index = "7", Value = "Viento" });
                Valores.Add(new Valor() { Index = "8", Value = "Acuíferos" });
                Valores.Add(new Valor() { Index = "3", Value = "Petróleo" });
                Valores.Add(new Valor() { Index = "3", Value = "Peces" });
                Valores.Add(new Valor() { Index = "3", Value = "Energía (hidraúlica)" });
                cbxRecurso.DataSource = Valores;
                cbxRecurso.DisplayMember = "Value";
                cbxRecurso.ValueMember = "Index";
            }

            if (cbxTipoRecurso.Text == "Recursos Físicos")
            {
                Valores.Add(new Valor() { Index = "1", Value = "Vías de primer y segundo orden" });
                Valores.Add(new Valor() { Index = "2", Value = "Vias de tercer orden" });
                Valores.Add(new Valor() { Index = "3", Value = "Bienes inmuebles (casa, oficinas, galpones, terrenos)" });
                Valores.Add(new Valor() { Index = "4", Value = "Maquinaria" });
                Valores.Add(new Valor() { Index = "5", Value = "Automóviles y Camiones" });
                Valores.Add(new Valor() { Index = "6", Value = "Insumos para la producción: semillas, materiales, químicos" });
                Valores.Add(new Valor() { Index = "7", Value = "Material de oficina: computadoras, escritorios, muebles, impresoras, teléfonos" });
                Valores.Add(new Valor() { Index = "8", Value = "Ganado menor" });
                Valores.Add(new Valor() { Index = "3", Value = "Ganado mayor" });
                Valores.Add(new Valor() { Index = "3", Value = "Productos terminados: disponibles para la venta o almacenados" });
                cbxRecurso.DataSource = Valores;
                cbxRecurso.DisplayMember = "Value";
                cbxRecurso.ValueMember = "Index";
            }

            if (cbxTipoRecurso.Text == "Recursos Humanos")
            {
                Valores.Add(new Valor() { Index = "1", Value = "Componentes del hogar familiar" });
                Valores.Add(new Valor() { Index = "2", Value = "Mano de obra activa" });
                Valores.Add(new Valor() { Index = "3", Value = "Educación" });
                Valores.Add(new Valor() { Index = "4", Value = "Conocimiento" });
                Valores.Add(new Valor() { Index = "5", Value = "Capacidades" });
                cbxRecurso.DataSource = Valores;
                cbxRecurso.DisplayMember = "Value";
                cbxRecurso.ValueMember = "Index";
            }

            if (cbxTipoRecurso.Text == "Recursos Sociales")
            {
                Valores.Add(new Valor() { Index = "1", Value = "Redes de parentesco" });
                Valores.Add(new Valor() { Index = "2", Value = "Afiliaciones a grupos" });
                Valores.Add(new Valor() { Index = "3", Value = "Representación e influencia sociopolítica" });
                Valores.Add(new Valor() { Index = "4", Value = "Centros de ayuda" });
                Valores.Add(new Valor() { Index = "5", Value = "Servicios publicos de salud y sanitario" });
                Valores.Add(new Valor() { Index = "6", Value = "Pensiones para adultos mayores" });
                Valores.Add(new Valor() { Index = "7", Value = "Educación gratuita" });
                Valores.Add(new Valor() { Index = "8", Value = "Servicios o comedores publicos" });
                Valores.Add(new Valor() { Index = "3", Value = "Prestaciones economicas" });
                Valores.Add(new Valor() { Index = "3", Value = "Servicios residenciales" });
                cbxRecurso.DataSource = Valores;
                cbxRecurso.DisplayMember = "Value";
                cbxRecurso.ValueMember = "Index";
            }

            if (cbxTipoRecurso.Text == "Recursos Económicos")
            {
                Valores.Add(new Valor() { Index = "1", Value = "Dinero en efectivo" });
                Valores.Add(new Valor() { Index = "2", Value = "Ganancias de los productos y servicios realizados" });
                Valores.Add(new Valor() { Index = "3", Value = "Aportes de los socios o accionistas" });
                Valores.Add(new Valor() { Index = "4", Value = "Acciones, bonos, títulos" });
                Valores.Add(new Valor() { Index = "5", Value = "Utilidades" });
                Valores.Add(new Valor() { Index = "6", Value = "Remesas del exterior" });
                Valores.Add(new Valor() { Index = "7", Value = "Intercambio de productos" });
                Valores.Add(new Valor() { Index = "8", Value = "Créditos" });
                cbxRecurso.DataSource = Valores;
                cbxRecurso.DisplayMember = "Value";
                cbxRecurso.ValueMember = "Index";
            }

            if (cbxTipoRecurso.Text == "Recursos Políticos")
            {
                Valores.Add(new Valor() { Index = "1", Value = "Toma de decisiones" });
                Valores.Add(new Valor() { Index = "2", Value = "Relaciones de poder" });
                cbxRecurso.DataSource = Valores;
                cbxRecurso.DisplayMember = "Value";
                cbxRecurso.ValueMember = "Index";
            }
        }

        private void limpiar()
        {
            cbxSectorRecurso.Text = "";
            cbxTipoRecurso.Text = "";
            cbxRecurso.Text = "";
            cbxCantidad.Text = "";
            cbxCalidad.Text = "";
            cbxAcceso.Text = "";
            txtControl.Text = "";
            txtNotas.Text = "";
        }

        private void btnGuardarCambio_Click(object sender, EventArgs e)
        {
            if (cbxSectorRecurso.Text != "" && cbxTipoRecurso.Text != "")
            {
                DialogResult result = MessageBox.Show("¿El ingreso esta correcto?", "Advertencia", MessageBoxButtons.YesNo);
                ModeloRecursoImportante recursoImportante = new ModeloRecursoImportante();


                String sector = cbxSectorRecurso.Text;
                String tipoderecurso = cbxTipoRecurso.Text;
                String recurso = cbxRecurso.Text;
                String cantidad = cbxCantidad.Text;
                String calidad = cbxCalidad.Text;
                String acceso = cbxAcceso.Text;
                String control = txtControl.Text;
                String notas = txtNotas.Text;

                if (result == DialogResult.Yes)
                {
                    recursoImportante.InsertarDatos(sector, tipoderecurso, recurso, cantidad, calidad, acceso, control, notas);
                    MessageBox.Show("Los datos se agregaron correctamente", "Advertencia", MessageBoxButtons.OK);
                    this.limpiar();
                }
            }
            else
                MessageBox.Show("Debe elegir un sector y un tipo de recurso","Advertencia", MessageBoxButtons.OK);
        }
    }
}
