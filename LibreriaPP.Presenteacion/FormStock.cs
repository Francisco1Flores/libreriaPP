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

            // Estilo Dark Mode para las celdas y encabezados de la grilla
            dgvStock.DefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48);
            dgvStock.DefaultCellStyle.ForeColor = Color.FromArgb(240, 240, 240);
            dgvStock.DefaultCellStyle.SelectionBackColor = Color.FromArgb(90, 70, 130);
            dgvStock.DefaultCellStyle.SelectionForeColor = Color.White;

            dgvStock.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(35, 35, 38);
            dgvStock.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvStock.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            // Paleta de colores Dark Mode
            Color fondoOscuro = Color.FromArgb(30, 30, 30);
            Color tarjetaGris = Color.FromArgb(45, 45, 48);
            Color campoTexto = Color.FromArgb(37, 37, 38);
            Color textoClaro = Color.FromArgb(240, 240, 240);
            Color bordeGris = Color.FromArgb(60, 60, 60);

            this.BackColor = fondoOscuro;

            // Título y buscador
            lblTitulo.ForeColor = Color.FromArgb(187, 134, 252);
            lblBuscar.ForeColor = textoClaro;

            txtBuscarProductos.BackColor = campoTexto;
            txtBuscarProductos.ForeColor = textoClaro;
            txtBuscarProductos.BorderStyle = BorderStyle.FixedSingle;

            // Recuadro de datos (GroupBox)
            gbProducto.BackColor = tarjetaGris;
            gbProducto.ForeColor = textoClaro;

            foreach (Control c in gbProducto.Controls)
            {
                if (c is Label lbl) lbl.ForeColor = textoClaro;
                else if (c is TextBox txt) { txt.BackColor = campoTexto; txt.ForeColor = textoClaro; txt.BorderStyle = BorderStyle.FixedSingle; }
                else if (c is ComboBox cmb) { cmb.BackColor = campoTexto; cmb.ForeColor = textoClaro; cmb.FlatStyle = FlatStyle.Flat; }
                else if (c is NumericUpDown nud) { nud.BackColor = campoTexto; nud.ForeColor = textoClaro; }
                else if (c is Button btn) { btn.FlatStyle = FlatStyle.Flat; btn.BackColor = Color.FromArgb(55, 55, 60); btn.ForeColor = textoClaro; }
            }

            // Botones de acción
            btnGuardar.FlatStyle = FlatStyle.Flat; btnGuardar.BackColor = Color.FromArgb(65, 80, 140); btnGuardar.ForeColor = Color.White;
            btnModificar.FlatStyle = FlatStyle.Flat; btnModificar.BackColor = Color.FromArgb(55, 55, 60); btnModificar.ForeColor = textoClaro;
            btnLimpiar.FlatStyle = FlatStyle.Flat; btnLimpiar.BackColor = Color.FromArgb(55, 55, 60); btnLimpiar.ForeColor = textoClaro;
            btnEliminar.FlatStyle = FlatStyle.Flat; btnEliminar.BackColor = Color.FromArgb(120, 40, 40); btnEliminar.ForeColor = Color.White;

            // Grilla
            dgvStock.BackgroundColor = tarjetaGris;
            dgvStock.BorderStyle = BorderStyle.None;
            dgvStock.GridColor = bordeGris;
            dgvStock.EnableHeadersVisualStyles = false;

            dgvStock.DefaultCellStyle.BackColor = tarjetaGris;
            dgvStock.DefaultCellStyle.ForeColor = textoClaro;
            dgvStock.DefaultCellStyle.SelectionBackColor = Color.FromArgb(90, 70, 130);
            dgvStock.DefaultCellStyle.SelectionForeColor = Color.White;

            dgvStock.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(35, 35, 38);
            dgvStock.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            
            CargarRubros();
            CargarProveedores();
        }

        public void CargarRubros()
        {
            cmbRubro.DataSource = new RubroNegocio().Listar();
        }
        private void CargarProveedores()
        {
            cmbProveedor.DataSource = new ProveedorNegocio().ListarActivos();
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

        private void btnNuevoRubro_Click(object sender, EventArgs e)
        {
            var formNuevoRubro = new FormNuevoRubro(this, null);
            formNuevoRubro.StartPosition = FormStartPosition.CenterScreen;
            formNuevoRubro.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}