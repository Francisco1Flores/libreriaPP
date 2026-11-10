using Entidades;
using Negocio;

namespace Presentacion
{
    public partial class FormAgregarCliente : Form
    {
        private FormClientes formPadre;
        private Cliente cliente;
        public FormAgregarCliente(string tipo, Cliente cliente, FormClientes formPadre)
        {
            InitializeComponent();

            this.formPadre = formPadre;

            this.cliente = cliente;

            if (tipo.Equals("agregar"))
            {
                btnAccion.Text = "Agregar";
                this.Text = "Agregar Cliente";
            }
            else if (tipo.Equals("modificar"))
            {
                btnAccion.Text = "Modificar";
                this.Text = "Modificar Cliente";

                txtNombre.Text = cliente.nombre;
                txtDni.Text = cliente.dni.ToString();
                txtDni.Enabled = false;
                txtEmail.Text = cliente.email;
                txtTel.Text = cliente.tel.ToString();
                txtDireccion.Text = cliente.direccion;

                this.cliente = cliente;
            }

            lblErrorNombre.Text = "";
            lblErrorDni.Text = "";
            lblErrorTel.Text = "";
            lblErrorEmail.Text = "";
            lblErrorDireccion.Text = "";
            lblNombreObligatorio.Visible = false;
            lblDniObligatorio.Visible = false;
            lblCamposObligatorios.Visible = false;
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {            
            ClienteNegocio clienteNegocio = new ClienteNegocio();

            if (!DatosValidos(clienteNegocio, btnAccion.Text))
            {
                return;
            }

            Cliente cliente = new Cliente();

            cliente.nombre = txtNombre.Text.ToUpper();
            cliente.dni = int.Parse(txtDni.Text);
            cliente.tel = txtTel.Text;
            cliente.email = txtEmail.Text;
            cliente.direccion = txtDireccion.Text.ToUpper();

            if (btnAccion.Text.Equals("Agregar"))
            {
                clienteNegocio.AgregarCliente(cliente);
            }
            else if (btnAccion.Text.Equals("Modificar"))
            {
                cliente.id = this.cliente.id;
                DialogResult respuesta = MessageBox.Show(
                    $"Está seguro que desea modificar al cliente:\nDNI: {this.cliente.dni}.", "",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    clienteNegocio.ModificarCliente(cliente);
                }                
            }
            formPadre.ActualizarClientes();

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool DatosValidos(ClienteNegocio clienteNegocio, string accion)
        {
            bool Resultado = true;
            if (string.IsNullOrEmpty(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                lblNombreObligatorio.Visible = true;
                lblCamposObligatorios.Visible = true;
                Resultado = Resultado ? false : Resultado;
            }
            else
            {
                Resultado = ValidarCampo(() => clienteNegocio.NombreValido(txtNombre.Text.ToUpper()),
                                         lblErrorNombre, "El nombre solo puede contener letras y espacios.") ? Resultado : false;
                lblNombreObligatorio.Visible = false;
                lblCamposObligatorios.Visible = false;                
            }
                

            if (accion.Equals("Agregar"))
            {
                if (string.IsNullOrEmpty(txtDni.Text) ||
                    string.IsNullOrWhiteSpace(txtDni.Text))
                {
                    lblDniObligatorio.Visible = true;
                    lblCamposObligatorios.Visible = true;
                    Resultado = Resultado ? false : Resultado;
                }
                else
                {
                    if (ValidarCampo(() => clienteNegocio.DniValido(txtDni.Text), lblErrorDni, "El DNI debe contener un número de documento válido."))
                    {
                        if (clienteNegocio.DniExiste(int.Parse(txtDni.Text)))
                        {
                            lblErrorDni.Text = "El DNI ya existe.";
                            Resultado = false;
                        }
                    }
                    lblDniObligatorio.Visible = false;
                    lblCamposObligatorios.Visible = false;
                }
                
            }
                
            Resultado = ValidarCampo(() => clienteNegocio.TelValido(txtTel.Text),
                                     lblErrorTel, "El teléfono contiene caracteres o tiene una longitud inválida.") ? Resultado : false;
            Resultado = ValidarCampo(() => clienteNegocio.EmailValido(txtEmail.Text),
                                     lblErrorEmail, "El email debe tener un formato válido (Ejemplo: usuario@dominio.com).") ? Resultado : false;
            Resultado = ValidarCampo(() => clienteNegocio.DireccionValido(txtDireccion.Text),
                                     lblErrorDireccion, "La dirección tiene un formato inválido.(Ejemplo: Calle 1234)") ? Resultado : false;

            return Resultado;
        }

        private bool ValidarCampo(Func<bool> validacion, Label ErrorLabel, string Mensaje)
        {
            bool valido = validacion();
            ErrorLabel.Text = valido ? "" : Mensaje;
            return valido;
        }
    }

}
