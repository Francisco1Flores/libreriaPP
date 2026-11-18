namespace Presentacion;

public partial class FormBuscarCliente : Form
{
    private Form Padre;
    public FormBuscarCliente(Form padre)
    {
        InitializeComponent();
        Padre = padre;
    }
}