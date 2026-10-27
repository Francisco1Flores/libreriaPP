using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using MySqlConnector;

namespace Presentacion
{
    public partial class FormPrincipal : Form
    {
        private Panel panel;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        //  Método  para incrustar los formularios en el panel central
        private void AbrirFormularioEnPanel(Form formHijo)
        {
            // Limpiamos la pantalla anterior del panel
            panelContenedor.Controls.Clear();

            // Ajustamos el formulario hijo para que actúe como un control interno
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;

            // Lo metemos dentro del panel y lo mostramos
            panelContenedor.Controls.Add(formHijo);
            formHijo.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conexion = ConexionDB.ObtenerConexion();
                conexion.Open();
                MessageBox.Show("conexion exitosa");
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FormVentas());
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FormStock());
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FormCompras());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FormClientes());
        }
    }
}