using Negocio;

namespace Presentacion;

public partial class FormNuevoRubro : Form
{
    private FormStock formStock;
    private FormProveedor formProveedor;
    public FormNuevoRubro(FormStock formStockPadre, FormProveedor formProveedorPadre)
    {
        InitializeComponent();
        formStock = formStockPadre;
        formProveedor = formProveedorPadre;
    }

    private void btnCancelar_Click_1(object sender, EventArgs e)
    {
        this.Close();
    }

    private void RecargarFormPadre()
    {
        if (formProveedor != null)
        {
            // todo
        }

        if (formStock != null)
        {
            formStock.CargarRubros();
        }
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
        string rubro = txtRubro.Text.Trim().ToUpper();
        if (string.IsNullOrEmpty(rubro) || string.IsNullOrWhiteSpace(rubro))
        {
            MessageBox.Show("Ingrese un nombre para el rubro.");
            return;
        }
        RubroNegocio rubroNegocio = new RubroNegocio();
        if (rubroNegocio.Existe(rubro))
        {
            MessageBox.Show("El rubro ingresado ya existe.");
            return;
        }
        new RubroNegocio().Guardar(rubro);
        MessageBox.Show("Rubro guardado correctamente.");
        RecargarFormPadre();
        this.Close();
    }
}