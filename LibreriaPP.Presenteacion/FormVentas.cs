using System.Data;
using Entidades;
using Negocio;

namespace Presentacion
{
    public partial class FormVentas : Form
    {
        private Cliente ClienteSeleccionado;
        private ClienteNegocio clienteNegocio = new ClienteNegocio();
        
        private ProductoNegocio_ productoNegocio = new ProductoNegocio_();
        private Producto productoSeleccionadoActual;
        
        private List<DetalleVentaFront> listaCarrito;

        private VentaNegocio ventaNegocio;

        private double totalVenta;
        private int idParaVentaAcutal = 0;
        
        public FormVentas()
        {
            InitializeComponent();
            
            DateTime fecha = DateTime.UtcNow;
            lblFecha.Text = "Fecha: " + fecha.Date.ToString("dd/MM/yyyy"); ;
            ventaNegocio = new VentaNegocio();

            idParaVentaAcutal = ventaNegocio.ObtenerIdParaNuevaVenta();
            lblNroVenta.Text = "Venta nro: " + idParaVentaAcutal.ToString("000000");
            
            CargarFormasDePago();
            IniciarCarrito();

            txtTotal.Text = "0";

            ventaNegocio = new VentaNegocio();

            cmbFormasDePago.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void IniciarCarrito()
        {
            dgvCarrito.AllowUserToAddRows = false;
            
            dgvCarrito.Columns.Add("C1", "Código");
            dgvCarrito.Columns.Add("C2", "Producto");
            dgvCarrito.Columns.Add("C3", "Precio");
            dgvCarrito.Columns.Add("C4", "Cantidad");
            dgvCarrito.Columns.Add("C5", "Sub Total");
            
            // Boton para quitar producto
            DataGridViewButtonColumn columnaBtnEliminar = new DataGridViewButtonColumn();
            columnaBtnEliminar.Name = "Quitar";
            columnaBtnEliminar.HeaderText = "Quitar";
            columnaBtnEliminar.Text = "Quitar";
            columnaBtnEliminar.UseColumnTextForButtonValue = true;
            dgvCarrito.Columns.Add(columnaBtnEliminar);
        }

        private void CargarFormasDePago()
        {
            cmbFormasDePago.DataSource = new FormaPagoNegocio().Listar();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            FormClientes formClientes = new FormClientes(this);
            
            formClientes.FormBorderStyle = FormBorderStyle.Sizable;
            formClientes.MaximizeBox = false;
            formClientes.MinimizeBox = false;
            
            formClientes.Size = new Size(new Point(formClientes.Size.Width, formClientes.Size.Height - 100));
            formClientes.StartPosition = FormStartPosition.CenterScreen;

            formClientes.ShowDialog();
        }

        public void EstablecerProductoSeleccionado(Producto producto)
        {
            txtCodigoProducto.Text = producto.CodigoBarra;
            
            txtNombreProducto.Text = producto.Nombre;
            txtNombreProducto.Enabled = false;
            
            txtPrecio.Text = producto.PrecioVenta.ToString();
            
            txtStock.Text = producto.CantidadStock.ToString();
            txtStock.Enabled = false;
            
            txtCantidad.Text = "1";
            productoSeleccionadoActual = producto;
        }

        public void EstablecerCliente(Cliente cliente)
        {
            ClienteSeleccionado = cliente;
            
            txtDniCliente.Text = ClienteSeleccionado.Dni.ToString();
            txtDniCliente.Enabled = false;
            
            txtNombreCliente.Text = ClienteSeleccionado.Nombre;
            txtNombreCliente.Enabled = false;

            if (!ClienteSeleccionado.Telefono.Equals(""))
            {
                txtTelCliente.Text = ClienteSeleccionado.Telefono;
                txtTelCliente.Enabled = false;
            }
        }

        private void btnLimpiarCliente_Click(object sender, EventArgs e)
        {
            txtTelCliente.Text = txtNombreCliente.Text = txtDniCliente.Text = "";
            txtTelCliente.Enabled = txtNombreCliente.Enabled = txtDniCliente.Enabled = true;
            ClienteSeleccionado = null;
        }

        private void BuscarYMostrarCliente()
        {
            string Dni = txtDniCliente.Text.Trim();
            if (clienteNegocio.DniValido(Dni))
            {
                Cliente cliente = clienteNegocio.BuscarPorDni(int.Parse(Dni));
                if (cliente != null)
                {
                    EstablecerCliente(cliente);
                    txtTelCliente.Enabled = txtNombreCliente.Enabled = txtDniCliente.Enabled = false;
                }
            }
        }
        
        private void txtDniCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                BuscarYMostrarCliente();
            }
        }

        private void txtDniCliente_Leave(object sender, EventArgs e)
        {
            BuscarYMostrarCliente();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = "Hora: " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (productoSeleccionadoActual == null)
            {
                MessageBox.Show("Seleccione un producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DetalleVentaFront detalleVentafront = new DetalleVentaFront();

            detalleVentafront.CodigoBarra = productoSeleccionadoActual.CodigoBarra;
            detalleVentafront.NombreProducto = productoSeleccionadoActual.Nombre;

            int cantidad = 0;
            if (!int.TryParse(txtCantidad.Text, out cantidad))
            {
                MessageBox.Show("Ingrese cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCantidad.Text = "0";
                return;
            }
            if (cantidad <= 0)
            {
                MessageBox.Show("Cantidad debe ser mayor a cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int stock = int.Parse(txtStock.Text);
            if (cantidad > stock)
            {
                MessageBox.Show("Cantidad ingresada mayor a stock disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCantidad.Text = txtStock.Text;
                return;
            }

            double precio = 0.0;
            if (!double.TryParse(txtPrecio.Text, out precio))
            {
                MessageBox.Show("Precio inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrecio.Text = productoSeleccionadoActual.PrecioVenta.ToString();
                return;
            }
            
            double subTotal = precio * cantidad;
            
            detalleVentafront.Cantidad = cantidad;
            detalleVentafront.Precio = precio;
            detalleVentafront.SubTotal = subTotal;

            totalVenta += subTotal;
            txtTotal.Text = totalVenta.ToString();
            
            if (listaCarrito == null)
            {
                listaCarrito = new List<DetalleVentaFront>();
            }
            
            listaCarrito.Add(detalleVentafront);
            dgvCarrito.Rows.Add(detalleVentafront.GetStringArray());
            txtTotal.Text = CalcularTotal().ToString();
            productoSeleccionadoActual = null;
            LimpiarCamposProducto();
        }

        private void LimpiarCamposProducto()
        {
            txtCodigoProducto.Text = txtNombreProducto.Text = txtPrecio.Text = txtCantidad.Text = txtStock.Text = "";
        }

        private double CalcularTotal()
        {
            double suma = 0.0;
            foreach (DetalleVentaFront item in listaCarrito)
            {
                suma += item.SubTotal;
            }
            return suma;
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            var formBuscarProducto = new FormBuscarProducto(this);
            formBuscarProducto.StartPosition = FormStartPosition.CenterScreen;
            formBuscarProducto.ShowDialog();
        }

        private void txtCodigoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Producto_ producto = productoNegocio.BuscarPorCodigoDeBarras(txtCodigoProducto.Text);
                if (producto != null)
                {
                    EstablecerProductoSeleccionado(producto.toProducto());
                }
            }
        }

        private void dgvCarrito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvCarrito.Columns["Quitar"].Index)
            {
                DataGridViewRow fila = dgvCarrito.Rows[e.RowIndex];
                BorrarDeListaCarrito(fila);
                dgvCarrito.Rows.Remove(fila);
                txtTotal.Text = CalcularTotal().ToString();
            }
        }

        private void BorrarDeListaCarrito(DataGridViewRow fila)
        {
            DetalleVentaFront itemABorrar = DetalleVentaFront.DesdeDgvFila(fila);

            int indiceABorrar = 0;
            for (int i = 0; i < listaCarrito.Count; ++i)
            {
                if (itemABorrar.Equals(listaCarrito[i]))
                {
                    indiceABorrar = i;
                    break;
                }
            }
            listaCarrito.RemoveAt(indiceABorrar);
        }

        private bool ClienteValido()
        {
            if (ClienteSeleccionado != null)
            {
                return true;
            }

            if (string.IsNullOrEmpty(txtDniCliente.Text) ||
                string.IsNullOrWhiteSpace(txtDniCliente.Text))
            {
                MessageBox.Show("Debe ingresar el DNI del cliente o seleccionar uno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            if (string.IsNullOrEmpty(txtNombreCliente.Text) ||
                string.IsNullOrWhiteSpace(txtNombreCliente.Text))
            {
                MessageBox.Show("Debe ingresar el nombre del cliente o seleccionar uno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!clienteNegocio.DniValido(txtDniCliente.Text))
            {
                MessageBox.Show("DNI ingresado no tiene un formato valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!clienteNegocio.NombreValido(txtNombreCliente.Text))
            {
                MessageBox.Show("El nombre solo puede contener letras y espacios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!clienteNegocio.TelValido(txtTelCliente.Text))
            {
                MessageBox.Show("El número de telefono debe contener entre 7 y 15 digitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
             if (!ClienteValido())
             {
                 return;
             }
         
             if (listaCarrito == null || listaCarrito.Count == 0)
             {
                 MessageBox.Show("El carrito de compras está vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return;
             }
         
             try
             {
                 // 1. Obtener o crear el cliente si se ingresó manualmente
                 if (ClienteSeleccionado == null)
                 {
                     Cliente NuevoCliente = new Cliente();
                     NuevoCliente.Dni = int.Parse(txtDniCliente.Text.Trim());
                     NuevoCliente.Nombre = txtNombreCliente.Text.Trim().ToUpper();
                     NuevoCliente.Telefono = txtTelCliente.Text.Trim();
                     clienteNegocio.AgregarCliente(NuevoCliente);
                     ClienteSeleccionado = clienteNegocio.BuscarPorDni(NuevoCliente.Dni);
                 }
         
                 // 2. Construir la Entidad Venta y sus detalles
                 Venta nuevaVenta = new Venta();
                 // Nota: Asegúrate de adaptar las propiedades según cómo se llamen exactamente en tu clase Entidades.Venta
                 // nuevaVenta.IdVenta = ventaNegocio.ObtenerIdParaNuevaVenta(); // O se autogenera en la BD
                 nuevaVenta.Id = idParaVentaAcutal;
                 nuevaVenta.Cliente = ClienteSeleccionado;
                 nuevaVenta.Fecha = DateTime.Now;
                 nuevaVenta.Total = CalcularTotal();
                 
                 // Forma de pago seleccionada en el ComboBox
                 nuevaVenta.FormaDePago = (FormaDePago)cmbFormasDePago.SelectedItem; 
         
                 // Mapear el carrito (DetalleVentaFront) a los detalles de la entidad Venta
                 nuevaVenta.DetallesVenta = new List<DetalleVenta>(); 
                 foreach (var item in listaCarrito)
                 {
                     DetalleVenta detalle = new DetalleVenta();
                     
                     detalle.Producto = productoNegocio.BuscarPorCodigoDeBarras(item.CodigoBarra);
                     detalle.Precio   = item.Precio;
                     detalle.Cantidad = item.Cantidad;
                     detalle.SubTotal = item.SubTotal;
                     
                     nuevaVenta.DetallesVenta.Add(detalle);
                 }
         
                 bool resultado = ventaNegocio.GuardarVenta(nuevaVenta);
         
                 if (resultado)
                 {
                     MessageBox.Show("¡Venta registrada con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     
                     // Limpiar formulario / reiniciar venta
                     listaCarrito.Clear();
                     dgvCarrito.Rows.Clear();
                     txtTotal.Text = "0";
                     totalVenta = 0;
                     btnLimpiarCliente_Click(sender, e);

                     idParaVentaAcutal = ventaNegocio.ObtenerIdParaNuevaVenta();
                     lblNroVenta.Text = "Venta nro: " + idParaVentaAcutal.ToString("000000");
                 }
                 else
                 {
                     MessageBox.Show("No se pudo registrar la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Ocurrió un error al registrar la venta: " + ex.Message+ ":\n" + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
        }

        private void btnLimpiarProducto_Click(object sender, EventArgs e)
        {
            productoSeleccionadoActual = null;
            txtCodigoProducto.Text = txtNombreProducto.Text = txtPrecio.Text = txtCantidad.Text = txtStock.Text = "";
        }
    }
}