using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Entidades;
using Negocio;

namespace Presentacion
{
    public partial class FormRegistrarCompra : Form
    {
        private List<DetalleCompra> listaDetalleTemporal = new List<DetalleCompra>();
        private CompraNegocio objCompraNegocio = new CompraNegocio();

        public FormRegistrarCompra()
        {
            InitializeComponent();
            AplicarEstiloGrilla();
        }

        private void AplicarEstiloGrilla()
        {
            dgvDetalle.DefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48);
            dgvDetalle.DefaultCellStyle.ForeColor = Color.FromArgb(240, 240, 240);
            dgvDetalle.DefaultCellStyle.SelectionBackColor = Color.FromArgb(90, 70, 130);
            dgvDetalle.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvDetalle.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(35, 35, 38);
            dgvDetalle.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvDetalle.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvDetalle.CellDoubleClick += dgvDetalle_CellDoubleClick;
        }

        private void FormRegistrarCompra_Load(object sender, EventArgs e)
        {
            CargarProveedores();
            CargarFormasPago();
            CargarProductos();
        }

        private void CargarProveedores()
        {
            cmbProveedor.DataSource = new ProveedorNegocio().Listar();
            cmbProveedor.DisplayMember = "RazonSocial";
            cmbProveedor.ValueMember = "IdProveedor";
            cmbProveedor.SelectedIndex = -1;
        }

        private void CargarFormasPago()
        {
            DataTable dtFormasPago = new DataTable();
            dtFormasPago.Columns.Add("IdFormaPago", typeof(int));
            dtFormasPago.Columns.Add("Descripcion", typeof(string));

            dtFormasPago.Rows.Add(1, "Efectivo");
            dtFormasPago.Rows.Add(2, "Transferencia");
            dtFormasPago.Rows.Add(3, "Cuenta Corriente");

            cmbFormaPago.DataSource = dtFormasPago;
            cmbFormaPago.DisplayMember = "Descripcion";
            cmbFormaPago.ValueMember = "IdFormaPago";
            cmbFormaPago.SelectedIndex = -1;
        }

        private void CargarProductos()
        {
            // Traemos el DataTable real de Stock (columnas: "ID", "Producto", "Precio Lista ($)", etc.)
            cmbProducto.DataSource = new Negocio.Negocio.ProductoNegocio().ObtenerStock();
            cmbProducto.DisplayMember = "Producto";
            cmbProducto.ValueMember = "ID";
            cmbProducto.SelectedIndex = -1;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un producto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida mayor a cero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("Ingrese un precio unitario válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idProducto = Convert.ToInt32(cmbProducto.SelectedValue);
            string nombreProducto = cmbProducto.Text;

            DetalleCompra detalle = objCompraNegocio.CrearDetalle(idProducto, nombreProducto, cantidad, precio);
            listaDetalleTemporal.Add(detalle);

            RefrescarGrillaDetalle();
            ActualizarTotalVisual();

            txtCantidad.Clear();
            txtPrecio.Clear();
            cmbProducto.SelectedIndex = -1;
        }

        private void RefrescarGrillaDetalle()
        {
            dgvDetalle.DataSource = null;
            dgvDetalle.DataSource = listaDetalleTemporal.Select(d => new
            {
                Id = d.IdProducto,
                Producto = d.NombreProducto,
                d.Cantidad,
                PrecioUnitario = d.PrecioUnitario.ToString("C2"),
                Subtotal = d.SubTotal.ToString("C2")
            }).ToList();

            if (dgvDetalle.Columns["PrecioUnitario"] != null)
                dgvDetalle.Columns["PrecioUnitario"].HeaderText = "Precio Unitario";
        }

        private void ActualizarTotalVisual()
        {
            decimal total = objCompraNegocio.CalcularTotal(listaDetalleTemporal);
            lblTotal.Text = $"Total: $ {total:N2}";
        }

        private void btnRegistrarCompra_Click(object sender, EventArgs e)
        {
            if (cmbProveedor.SelectedIndex == -1 || cmbFormaPago.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un Proveedor y una Forma de Pago.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Compra nuevaCompra = new Compra()
            {
                IdProveedor = Convert.ToInt32(cmbProveedor.SelectedValue),
                IdFormaPago = Convert.ToInt32(cmbFormaPago.SelectedValue),
                Total = objCompraNegocio.CalcularTotal(listaDetalleTemporal)
            };

            string mensaje = string.Empty;
            bool resultado = objCompraNegocio.RegistrarCompra(nuevaCompra, listaDetalleTemporal, out mensaje);

            if (resultado)
            {
                MessageBox.Show("¡Compra registrada exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo registrar la compra: " + mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
        }


        private void dgvDetalle_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= listaDetalleTemporal.Count)
                return;

            string producto = listaDetalleTemporal[e.RowIndex].NombreProducto;
            DialogResult confirmacion = MessageBox.Show(
                $"¿Desea quitar '{producto}' del detalle de compra?",
                "Quitar producto",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                listaDetalleTemporal.RemoveAt(e.RowIndex);
                RefrescarGrillaDetalle();
                ActualizarTotalVisual();
            }
        }
    }
}