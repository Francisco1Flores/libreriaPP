using Entidades;
using Mysqlx.Expect;
using Negocio;

namespace Presentacion
{
    public partial class FormVentas : Form
    {
        private Cliente ClienteSeleccionado;
        private ClienteNegocio clienteNegocio = new ClienteNegocio();
        public FormVentas()
        {
            InitializeComponent();
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
                    //txtNombreCliente.Text =  cliente.Nombre;
                    //txtTelCliente.Text = cliente.Telefono;
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
    }
}
