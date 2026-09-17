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
        public FormPrincipal()
        {
            InitializeComponent();
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
            // abrir form ventas
            FormVentas formVentas = new FormVentas();
            formVentas.Show();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            // abrir form stock
            FormStock formStock = new FormStock();
            formStock.Show();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            // abrir form compras
            FormCompras formCompras = new FormCompras();
            formCompras.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            //abrir form clientes
            FormClientes formClientes = new FormClientes();
            formClientes.Show();
        }
    }
}
