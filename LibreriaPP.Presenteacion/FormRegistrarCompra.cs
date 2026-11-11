using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocio;

namespace Presentacion
{
    public partial class FormRegistrarCompra : Form
    {
        // Lista temporal para almacenar los productos que vamos agregando antes de guardarlos
        private List<DetalleCompra> listaDetalleTemporal = new List<DetalleCompra>();

        public FormRegistrarCompra()
        {
            InitializeComponent();
            CargarProveedores();
            CargarFormasPago();
            CargarProductos();
        }

        // Este evento se ejecuta automáticamente cuando se abre la ventana
        private void FormRegistrarCompra_Load(object sender, EventArgs e)
        {
            CargarProveedores();
            CargarFormasPago();
            CargarProductos();
        }

        // 1. Método para llenar el ComboBox de Proveedores
        private void CargarProveedores()
        {
            cmbProveedor.DataSource = new ProveedorNegocio().Listar();
            cmbProveedor.DisplayMember = "RazonSocial";
            cmbProveedor.ValueMember = "IdProveedor";
            cmbProveedor.SelectedIndex = -1;
        }

        // 2. Método para llenar las Formas de Pago
        private void CargarFormasPago()
        {
            // (Si aún no tienes una tabla de formas de pago, puedes armar una lista estática o consulta rápida)
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

        // 3. Método para llenar el ComboBox de Productos
        private void CargarProductos()
        {
            DataTable dtProductos = new DataTable();
            dtProductos.Columns.Add("IdProducto", typeof(int));
            dtProductos.Columns.Add("Nombre", typeof(string));

            dtProductos.Rows.Add(1, "Cuaderno A4");
            dtProductos.Rows.Add(2, "Lápiz Negro");
            dtProductos.Rows.Add(3, "Impresora Térmica");

            cmbProducto.DataSource = dtProductos;
            cmbProducto.DisplayMember = "Nombre";
            cmbProducto.ValueMember = "IdProducto";
            cmbProducto.SelectedIndex = -1;
        
        }

        // 4. Botón "Agregar" (Suma el producto a la tabla temporal)
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un producto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCantidad.Text) || string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("Debe ingresar la cantidad y el precio unitario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idProducto = Convert.ToInt32(cmbProducto.SelectedValue);
            string nombreProducto = cmbProducto.Text;

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

            decimal subTotal = cantidad * precio;

            // 2. Agregamos a la lista temporal de detalles
            listaDetalleTemporal.Add(new DetalleCompra()
            {
                IdProducto = idProducto,
                Cantidad = cantidad,
                SubTotal = subTotal
            });

            // 3. Refrescamos el DataGridView
            dgvDetalle.DataSource = null;
            dgvDetalle.DataSource = listaDetalleTemporal;

            // 4. Actualizamos el total general de la compra
            CalcularTotalGeneral();

            // 5. Limpiamos los campos para cargar el siguiente producto
            txtCantidad.Clear();
            txtPrecio.Clear();
            cmbProducto.SelectedIndex = -1;
        }

        // 5. Método auxiliar para sumar todos los subtotales
        private void CalcularTotalGeneral()
        {
            decimal totalGeneral = 0;
            foreach (var item in listaDetalleTemporal)
            {
                totalGeneral += item.SubTotal;
            }
            // Mostramos el monto formateado en la etiqueta que agregaste al diseño
            lblTotal.Text = $"Total: $ {totalGeneral:N2}";
        }

        // 6. Botón Principal "Registrar Compra" (Guarda cabecera y detalles en la BD)
        private void btnRegistrarCompra_Click(object sender, EventArgs e)
        {
            // Armamos el objeto principal de la Compra
            Compra nuevaCompra = new Compra()
            {
                IdProveedor = Convert.ToInt32(cmbProveedor.SelectedValue),
                IdFormaPago = Convert.ToInt32(cmbFormaPago.SelectedValue),
                Total = ObtenerTotalCalculado()
            };

            string mensaje = string.Empty;

            // Invocamos a la Capa de Negocio que maneja la transacción
            bool resultado = new CompraNegocio().RegistrarCompra(nuevaCompra, listaDetalleTemporal, out mensaje);

            if (resultado)
            {
                MessageBox.Show("¡Compra registrada exitosamente y stock actualizado!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Cerramos la ventana
            }
            else
            {
                MessageBox.Show("No se pudo registrar la compra: " + mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private decimal ObtenerTotalCalculado()
        {
            decimal total = 0;
            foreach (var item in listaDetalleTemporal) total += item.SubTotal;
            return total;
        }
        private void cmbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Por ahora lo dejamos vacío para que el diseñador no se queje
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            FormCompras frm = new FormCompras();
            frm.ShowDialog();

            // Al cerrar la ventana, se actualiza el combo automáticamente:
            CargarProveedores();
        }

        private void btnRegistrarCompra_Click_1(object sender, EventArgs e)
        {
            if (cmbProveedor.SelectedIndex == -1 || cmbFormaPago.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un Proveedor y una Forma de Pago.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Armar la cabecera de la Compra
            Compra nuevaCompra = new Compra()
            {
                IdProveedor = Convert.ToInt32(cmbProveedor.SelectedValue),
                IdFormaPago = Convert.ToInt32(cmbFormaPago.SelectedValue),
                Total = ObtenerTotalCalculado()
            };

            string mensaje = string.Empty;

            // 3. Invocación a CompraNegocio
            bool resultado = new CompraNegocio().RegistrarCompra(nuevaCompra, listaDetalleTemporal, out mensaje);

            // 4. Mensaje de resultado
            if (resultado)
            {
                MessageBox.Show("¡Compra registrada exitosamente y stock actualizado!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo registrar la compra: " + mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}