using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmActoresLocales : Form
    {
        public frmActoresLocales()
        {
            InitializeComponent();
        }

        private void frmActoresLocales_Load(object sender, EventArgs e)
        {

        }

        public void Limpiar()
        {
            txtnombreActor.Text = "";
            txtsiglas.Text = "";
            txttipo.Text = "";
            txtrelacionAnalisis.Text = "";
            txtcompetenciaRel.Text = "";
            txtnombreProyecto.Text = "";
            txtobjetivo.Text = "";
            txtresponsable.Text = "";
            txtcargo.Text = "";
            txttelefono.Text = "";
            txtemail.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String nombreActor = txtnombreActor.Text;
            String siglas = txtsiglas.Text;
            String tipo = txttipo.Text;
            String unidadAnalisis = txtrelacionAnalisis.Text;
            String competenciasRel = txtcompetenciaRel.Text;
            String nombreProyecto = txtnombreProyecto.Text;
            String objetivo = txtobjetivo.Text;
            String responsable = txtresponsable.Text;
            String cargo = txtcargo.Text;
            String telefono = txttelefono.Text;
            String email = txtemail.Text;

            string sql = "INSERT INTO actorlocal (nombreActor, siglasActor, tipoActor, relacionActor, competenciasActor, nombreProyecto, objetivoProyecto, responsableProyecto, cargoResponsable, telefonoResponsable, emailResponsable) VALUES ('" + nombreActor + "','" + siglas + "','" + tipo + "','" + unidadAnalisis + "','" + competenciasRel + "','" + nombreProyecto + "','" + objetivo + "','" + responsable + "','" + cargo + "','" + telefono + "','" + email + "')";

            

            //try
            //{
            //   // MySqlCommand comando = new MySqlCommand(sql, conexionBD);
            //    comando.ExecuteNonQuery();
            //    MessageBox.Show("Registro guardado");
            //    Limpiar();
            //}
            //catch (MySqlException ex)
            //{
            //    MessageBox.Show("Error al guardar: " + ex.Message);
            //}
            //finally
            //{
            //    conexionBD.Close();
            //}
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
