using Entidades;
using Negocio;

namespace Presentacion
{
    public partial class FormAgregarCliente : Form
    {
        private FormClientes formPadre;
        private Cliente cliente;
        private string strSinDatos = "--SIN DATOS--";
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

                txtNombre.Text = cliente.Nombre;
                txtDni.Text = cliente.Dni.ToString();
                txtDni.Enabled = false;
                txtEmail.Text = cliente.Email.Equals(strSinDatos) ? "" : cliente.Email;
                txtTel.Text = cliente.Telefono.Equals(strSinDatos) ? "" : cliente.Telefono;
                txtDireccion.Text = cliente.Direccion.Equals(strSinDatos) ? "" : cliente.Direccion;

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

            cliente.Nombre = txtNombre.Text.ToUpper();
            cliente.Dni = int.Parse(txtDni.Text);
            cliente.Telefono = txtTel.Text;
            cliente.Email = txtEmail.Text;
            cliente.Direccion = txtDireccion.Text.ToUpper();

            if (btnAccion.Text.Equals("Agregar"))
            {
                clienteNegocio.AgregarCliente(cliente);
                formPadre.ActualizarClientes();
                this.Close();
            }
            else if (btnAccion.Text.Equals("Modificar"))
            {
                cliente.Id = this.cliente.Id;
                DialogResult respuesta = MessageBox.Show(
                    $"Está seguro que desea modificar al cliente:\nDNI: {this.cliente.Dni}.", "",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    clienteNegocio.ModificarCliente(cliente);
                    formPadre.ActualizarClientes();
                    formPadre.BuscarCliente();
                    this.Close();
                }
            }
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
                                     lblErrorTel, "El número de telefono debe contener entre 7 y 15 digitos.") ? Resultado : false;
            Resultado = ValidarCampo(() => clienteNegocio.EmailValido(txtEmail.Text),
                                     lblErrorEmail, "El email debe tener un formato válido (Ejemplo: usuario@dominio.com).") ? Resultado : false;
            Resultado = ValidarCampo(() => clienteNegocio.DireccionValido(txtDireccion.Text),
                                     lblErrorDireccion, "La dirección solo puede contener números, letras o espacios.(Ejemplo: Calle 1234)") ? Resultado : false;

            return Resultado;
        }

        private bool ValidarCampo(Func<bool> validacion, Label ErrorLabel, string Mensaje)
        {
            bool valido = validacion();
            ErrorLabel.Text = valido ? "" : Mensaje;
            ErrorLabel.Location = new Point(this.Width / 2 - ErrorLabel.Width / 2, ErrorLabel.Location.Y);
            return valido;
        }
    }

}
