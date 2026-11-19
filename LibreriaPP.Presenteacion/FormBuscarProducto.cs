using Entidades;
using Negocio;

namespace Presentacion;

public partial class FormBuscarProducto : Form
{
    private FormVentas formVentasPadre;
    private Producto_ productoSeleccionado;
    
    public FormBuscarProducto(FormVentas formVentas)
    {
        InitializeComponent();
        formVentasPadre = formVentas;
        CargarProductos();
    }

    private void CargarProductos()
    {
        dgvProductos.DataSource = new ProductoNegocio_().Listar();
    }

    private void btnSeleccionar_Click(object sender, EventArgs e)
    {
        formVentasPadre.EstablecerProductoSeleccionado(productoSeleccionado);
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
}