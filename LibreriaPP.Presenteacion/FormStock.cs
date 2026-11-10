using Entidades;
using Negocio;
using Negocio.Negocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormStock : Form
    {
        private ProductoNegocio productoNegocio = new ProductoNegocio();
        private int idProductoSeleccionado = 0;

        public FormStock()
        {
            InitializeComponent();
        }

        private void FormStock_Load_1(object sender, EventArgs e)
        {
            CargarTablaStock();
        }

        private void CargarTablaStock()
        {
            try
            {
                dgvStock.DataSource = productoNegocio.ObtenerStock();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la tabla: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBuscarProductos_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvStock.DataSource = productoNegocio.BuscarStock(txtBuscarProductos.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvStock.Rows[e.RowIndex];

                idProductoSeleccionado = Convert.ToInt32(fila.Cells["ID"].Value);

                txtCodigo.Text = fila.Cells["Código"].Value?.ToString();
                txtNombre.Text = fila.Cells["Producto"].Value?.ToString();
                txtPrecioLista.Text = fila.Cells["Precio Lista ($)"].Value?.ToString();
                txtPrecioVenta.Text = fila.Cells["Precio Venta ($)"].Value?.ToString();
                txtCantidad.Text = fila.Cells["Stock"].Value?.ToString();

                txtCantidad.Enabled = false;
            }
        }

        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtPrecioLista.Clear();
            txtPrecioVenta.Clear();
            txtCantidad.Clear();

            idProductoSeleccionado = 0;
            txtCantidad.Enabled = true;
            txtNombre.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Producto prod = new Producto()
                {
                    Nombre = txtNombre.Text.Trim(),
                    CodigoBarra = txtCodigo.Text.Trim(),
                    PrecioLista = string.IsNullOrEmpty(txtPrecioLista.Text) ? 0 : Convert.ToDecimal(txtPrecioLista.Text),
                    PrecioVenta = string.IsNullOrEmpty(txtPrecioVenta.Text) ? 0 : Convert.ToDecimal(txtPrecioVenta.Text),
                    CantidadStock = string.IsNullOrEmpty(txtCantidad.Text) ? 0 : Convert.ToInt32(txtCantidad.Text)
                };

                productoNegocio.RegistrarProducto(prod);

                MessageBox.Show("¡Producto registrado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarTablaStock();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Producto prod = new Producto()
                {
                    Id = idProductoSeleccionado,
                    Nombre = txtNombre.Text.Trim(),
                    CodigoBarra = txtCodigo.Text.Trim(),
                    PrecioLista = string.IsNullOrEmpty(txtPrecioLista.Text) ? 0 : Convert.ToDecimal(txtPrecioLista.Text),
                    PrecioVenta = string.IsNullOrEmpty(txtPrecioVenta.Text) ? 0 : Convert.ToDecimal(txtPrecioVenta.Text)
                };

                productoNegocio.ModificarProducto(prod);

                MessageBox.Show("¡Producto modificado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarTablaStock();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idProductoSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un producto de la tabla para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "¿Está seguro de eliminar este producto?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    productoNegocio.EliminarProducto(idProductoSeleccionado);
                    MessageBox.Show("Producto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarTablaStock();
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}