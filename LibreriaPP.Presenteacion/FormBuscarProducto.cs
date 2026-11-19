using Entidades;
using Negocio;
using Negocio.Negocio;

namespace Presentacion;

public partial class FormBuscarProducto : Form
{
    private FormVentas formVentasPadre;
    private Producto_ productoSeleccionado;
    private List<Producto_> productos;
    
    public FormBuscarProducto(FormVentas formVentas)
    {
        InitializeComponent();
        formVentasPadre = formVentas;
        dgvProductos.AllowUserToAddRows = false;
        CargarProductos();
    }

    private void CargarProductos()
    {
        productos = new ProductoNegocio_().Listar();
        dgvProductos.DataSource = productos;
    }

    private void btnSeleccionar_Click(object sender, EventArgs e)
    {
        formVentasPadre.EstablecerProductoSeleccionado(productoSeleccionado.toProducto());
        this.Close();
    }

    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        int IndiceFilaSeleccionada = 0;
        if (dgvProductos.CurrentCell != null)
        {
            IndiceFilaSeleccionada = dgvProductos.CurrentCell.RowIndex;
        }

        if (IndiceFilaSeleccionada < 0)
        {
            LimpiarCampos();
            productoSeleccionado = null;
            return;
        }

        DataGridViewRow fila = dgvProductos.Rows[IndiceFilaSeleccionada];
        Producto_ producto = (Producto_)fila.DataBoundItem;
        
        if (producto == null)
        {
            LimpiarCampos();
            productoSeleccionado = null;
            return;
        }

        txtCodigoBarras.Text = producto.CodigoBarra;
        txtNombre.Text      = producto.Nombre;
        txtPrecio.Text      = producto.PrecioVenta.ToString();
        txtStock.Text       = producto.Stock.ToString();
            
        productoSeleccionado = producto;
    }

    private void LimpiarCampos()
    {
        txtCodigoBarras.Text = txtNombre.Text = txtPrecio.Text = txtStock.Text = "";
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
        string texto = txtBuscarProducto.Text;
        List<Producto_> encontrados = new List<Producto_>();
        if (texto.Length == 0 || texto.Equals(""))
        {
            dgvProductos.DataSource = productos;
        }
        else
        {
            foreach (Producto_ producto in productos)
            {
                if (producto.Nombre.Contains(texto) ||
                    producto.Nombre.ToUpper().Contains(texto.ToUpper()) ||
                    producto.CodigoBarra.Contains(texto))
                {
                    encontrados.Add(producto);
                }
            }
            dgvProductos.DataSource = encontrados;
        }
    }
}