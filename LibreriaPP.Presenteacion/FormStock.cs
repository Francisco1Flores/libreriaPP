using System;
using System.Data;
using System.Windows.Forms;
using Datos;
using MySqlConnector;

namespace Presentacion
{
    public partial class FormStock : Form
    {
        public FormStock()
        {
            InitializeComponent();
        }

        private void FormStock_Load(object sender, EventArgs e)
        {
            CargarTablaStock();
        }

        private void CargarTablaStock()
        {
            try
            {
                using (MySqlConnection conexion = ConexionDB.ObtenerConexion())
                {
                    conexion.Open();

                    // Consulta con INNER JOIN para juntar Producto y Stock según tus tablas
                    string query = @"SELECT 
                                        p.id AS 'ID', 
                                        p.codigoBarra AS 'Código de Barras', 
                                        p.nombre AS 'Producto / Artículo', 
                                        p.precioVenta AS 'Precio Venta ($)', 
                                        s.cantidad AS 'Stock Disponible'
                                     FROM Producto p
                                     INNER JOIN Stock s ON p.id = s.idProducto";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexion);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Asignamos el resultado al DataGridView
                    dgvStock.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el stock desde la BD: " + ex.Message);
            }
        }
        private void BuscarStock(string filtro)
        {
            try
            {
                using (MySqlConnection conexion = ConexionDB.ObtenerConexion())
                {
                    conexion.Open();

                    // Usamos LIKE para buscar coincidencias parciales en el Nombre o en el Código de Barras
                    string query = @"SELECT 
                                p.id AS 'ID', 
                                p.codigoBarra AS 'Código de Barras', 
                                p.nombre AS 'Producto / Artículo', 
                                p.precioVenta AS 'Precio Venta ($)', 
                                s.cantidad AS 'Stock Disponible'
                             FROM Producto p
                             INNER JOIN Stock s ON p.id = s.idProducto
                             WHERE p.nombre LIKE @filtro OR p.codigoBarra LIKE @filtro";

                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@filtro", "%" + filtro + "%");

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvStock.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
        }
        private void FormStock_Load_1(object sender, EventArgs e)
        {
            CargarTablaStock();
        }

        private void txtBuscarProductos_TextChanged(object sender, EventArgs e)
        {
            BuscarStock(txtBuscarProductos.Text.Trim());
        }

      


    }
}