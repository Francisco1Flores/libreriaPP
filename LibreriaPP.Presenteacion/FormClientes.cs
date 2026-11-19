using System.Text;
using Negocio;
using Entidades;

namespace Presentacion
{
    public partial class FormClientes : Form
    {
        private Cliente? ClienteSeleccionado;
        private List<Cliente> listaClientes;
        private StringBuilder erroresSb = new StringBuilder();
        private FormVentas FormPadre;

        ClienteNegocio clienteNegocio;

        public FormClientes(FormVentas padre)
        {
            InitializeComponent();

            clienteNegocio = new ClienteNegocio();

            ActualizarClientes();

            dgvClientes.Columns[0].HeaderText = "ID";
            dgvClientes.Columns[1].HeaderText = "Nombre";
            dgvClientes.Columns[2].HeaderText = "DNI";
            dgvClientes.Columns[3].HeaderText = "Teléfono";
            dgvClientes.Columns[4].HeaderText = "Email";
            dgvClientes.Columns[5].HeaderText = "Dirección";

            if (false)
            {
                DataGridViewButtonColumn columnaBtnModificar = new DataGridViewButtonColumn();
                columnaBtnModificar.Name = "Modificar";
                columnaBtnModificar.HeaderText = "Modificar";
                columnaBtnModificar.Text = "Modificar";
                columnaBtnModificar.UseColumnTextForButtonValue = true;
                dgvClientes.Columns.Add(columnaBtnModificar);

                DataGridViewButtonColumn columnaBtnEliminar = new DataGridViewButtonColumn();
                columnaBtnEliminar.Name = "Eliminar";
                columnaBtnEliminar.HeaderText = "Eliminar";
                columnaBtnEliminar.Text = "Eliminar";
                columnaBtnEliminar.UseColumnTextForButtonValue = true;
                dgvClientes.Columns.Add(columnaBtnEliminar);

                dgvClientes.CellContentClick += btnModificarOEliminarCliente_Click;
            }
            SetDGVStyle(dgvClientes);

            CamposHabilitados(false);

            OcultarBotones();

            if (padre == null)
            {
                MostrarBoton(btnEliminar, btnModificar, btnNuevo);
            }
            else
            {
                MostrarBoton(btnSeleccionar, btnCancelar);
                FormPadre = padre;
            }

            MostrarDatosClienteSeleccionado();

            lblCamposObligatorios.Visible = false;
            lblNombreObligatorio.Visible = false;
            lblDniObligatorio.Visible = false;

            // Comentado para mantener el estilo oscuro unificado de los botones
            // Estilos.BotonesVerdes(btnNuevo, btnAgregar);
            // Estilos.BotonesAzules(btnModificar, btnGuardarDatos);
            // Estilos.BotonesRojos(btnEliminar, btnCancelar);
        }

        public void SetDGVStyle(DataGridView dgv)
        {
            dgv.EnableHeadersVisualStyles = false;

            // Estilo de cabecera unificado con el modo oscuro del sistema
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(35, 35, 38);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
        }

        public void ActualizarClientes()
        {
            listaClientes = clienteNegocio.ListarClientes();
            /*
            foreach( var cliente in listaClientes )
            {
                if (cliente.tel.Equals("")) cliente.tel = "--SIN DATOS--";
                if (cliente.email.Equals("")) cliente.email = "--SIN DATOS--";
                if (cliente.direccion.Equals("")) cliente.direccion = "--SIN DATOS--";
            }*/
            dgvClientes.DataSource = listaClientes;
        }

        // TODO: eliminar este metodo 
        private void btnModificarOEliminarCliente_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvClientes.Columns["Modificar"].Index)
            {
                ModificarCliente(e);
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == dgvClientes.Columns["Eliminar"].Index)
            {
                string nombre = dgvClientes.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
                string dni = dgvClientes.Rows[e.RowIndex].Cells["dni"].Value.ToString();

                DialogResult respuesta = MessageBox.Show(
                    $"Está seguro que desea eliminar al cliente:\nNombre: {nombre}.\nDNI: {dni}.", "",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    EliminarCliente(e);
                    ActualizarClientes();
                }
            }
        }

        // TODO: Eliminar el parametro de la funcion cuado elimine "Eliminar de la grilla"
        private void EliminarCliente(DataGridViewCellEventArgs e)
        {
            if (ClienteSeleccionado == null)
            {
                MessageBox.Show("Seleccione un cliente.");
                return;
            }
            DialogResult respuesta = MessageBox.Show($"Está seguro que desea eliminar al cliente:\nNombre: {ClienteSeleccionado.Nombre}.\nDNI: {ClienteSeleccionado.Dni}.", "",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes)
            {
                clienteNegocio.EliminarCliente(ClienteSeleccionado.Id);
                ActualizarClientes();
                BuscarCliente();
            }
        }

        private void ModificarCliente(DataGridViewCellEventArgs e)
        {
            Cliente cliente = new Cliente();
            DataGridViewRow fila = dgvClientes.Rows[e.RowIndex];

            cliente.Id = int.Parse(fila.Cells["id"].Value.ToString());
            cliente.Nombre = fila.Cells["nombre"].Value.ToString();
            cliente.Dni = int.Parse(fila.Cells["dni"].Value.ToString());
            cliente.Telefono = fila.Cells["tel"].Value.ToString();
            cliente.Email = fila.Cells["email"].Value.ToString();
            cliente.Direccion = fila.Cells["direccion"].Value.ToString();

            FormAgregarCliente formAgregarCliente = new FormAgregarCliente("modificar", cliente, this);
            formAgregarCliente.ShowDialog(this);
        }

        private void btnNuevoCliente_Click_1(object sender, EventArgs e)
        {
            FormAgregarCliente formAgregarCliente = new FormAgregarCliente("agregar", null, this);
            formAgregarCliente.ShowDialog(this);
        }

        private void txtBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            BuscarCliente();
        }

        public void BuscarCliente()
        {
            string texto = txtBuscarCliente.Text;
            List<Cliente> encontrados = new List<Cliente>();
            if (texto.Length == 0 || texto.Equals(""))
            {
                dgvClientes.DataSource = listaClientes;
            }
            else
            {
                foreach (Cliente cliente in listaClientes)
                {
                    if (cliente.Nombre.Contains(texto) ||
                        cliente.Nombre.Contains(texto.ToUpper()) ||
                        cliente.Dni.ToString().Contains(texto))
                    {
                        encontrados.Add(cliente);
                    }
                }
                dgvClientes.DataSource = encontrados;
            }
        }

        private void OcultarBotones()
        {
            OcultarBoton(btnNuevo, btnModificar, btnEliminar,
                         btnAgregar, btnGuardarDatos, btnCancelar, btnSeleccionar);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ClienteSeleccionado = null;
            LimpiarCampos();
            CamposHabilitados(true);

            OcultarBotones();

            MostrarBoton(btnAgregar);
            MostrarBoton(btnCancelar);

            dgvClientes.Enabled = false;

            lblCamposObligatorios.Visible = true;
            lblNombreObligatorio.Visible = true;
            lblDniObligatorio.Visible = true;
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = txtDni.Text = txtEmail.Text = txtTel.Text = txtDireccion.Text = "";
        }

        private void CamposHabilitados(bool estado)
        {
            txtNombre.Enabled = txtDni.Enabled = txtEmail.Enabled = txtTel.Enabled = txtDireccion.Enabled = estado;
        }

        private void MostrarDatosClienteSeleccionado()
        {
            int IndiceFilaSeleccionada = 0;
            if (dgvClientes.CurrentCell != null)
            {
                IndiceFilaSeleccionada = dgvClientes.CurrentCell.RowIndex;
            }

            // Evita error si la tabla está vacía
            if (IndiceFilaSeleccionada < 0 || IndiceFilaSeleccionada >= dgvClientes.Rows.Count)
            {
                LimpiarCampos();
                ClienteSeleccionado = null;
                btnAgregar.Enabled = false;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                return;
            }

            DataGridViewRow fila = dgvClientes.Rows[IndiceFilaSeleccionada];

            Cliente cliente = (Cliente)fila.DataBoundItem;
            if (cliente == null)
            {
                LimpiarCampos();
                btnAgregar.Enabled = false;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                CamposHabilitados(false);
                return;
            }

            CamposHabilitados(false);
            txtNombre.Text = cliente.Nombre;
            txtDni.Text = cliente.Dni.ToString();
            txtEmail.Text = cliente.Email;
            txtTel.Text = cliente.Telefono;
            txtDireccion.Text = cliente.Direccion;

            ClienteSeleccionado = cliente;
        }
        private void dgvClientes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MostrarDatosClienteSeleccionado();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            CamposHabilitados(true);
            txtDni.Enabled = false;

            OcultarBotones();

            MostrarBoton(btnGuardarDatos, btnCancelar);
        }

        private void MostrarBoton(params Button[] buttons)
        {
            foreach (Button b in buttons)
            {
                b.Enabled = true;
                b.Visible = true;
            }
        }

        private void OcultarBoton(params Button[] buttons)
        {
            foreach (Button b in buttons)
            {
                b.Visible = false;
                b.Enabled = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (FormPadre != null)
            {
                this.Close();
            }
            dgvClientes.Enabled = true;
            CamposHabilitados(false);
            MostrarDatosClienteSeleccionado();

            OcultarBotones();

            MostrarBoton(btnModificar, btnEliminar, btnNuevo);

            lblCamposObligatorios.Visible = false;
            lblNombreObligatorio.Visible = false;
            lblDniObligatorio.Visible = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarCliente(null);
        }

        private bool DatosValidos(ClienteNegocio clienteNegocio, string accion)
        {
            bool Resultado = true;
            erroresSb.Clear();

            if (string.IsNullOrEmpty(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                //MessageBox.Show("Nombre es un campo obligatorio.", "Error",
                //                MessageBoxButtons.OK, MessageBoxIcon.Error);
                erroresSb.AppendLine("- Nombre es un campo obligatorio.");
                Resultado = Resultado ? false : Resultado;
            }
            else
            {
                Resultado = ValidarCampo(() => clienteNegocio.NombreValido(txtNombre.Text.ToUpper()),
                                         "El nombre solo puede contener letras y espacios.") ? Resultado : false;
            }

            if (accion.Equals("Agregar"))
            {
                if (string.IsNullOrEmpty(txtDni.Text) ||
                    string.IsNullOrWhiteSpace(txtDni.Text))
                {
                    //MessageBox.Show("DNI es un campo obligatorio.", "Error",
                    //                MessageBoxButtons.OK, MessageBoxIcon.Error);
                    erroresSb.AppendLine("- DNI es un campo obligatorio.");
                    Resultado = Resultado ? false : Resultado;
                }
                else
                {
                    if (ValidarCampo(() => clienteNegocio.DniValido(txtDni.Text), "El DNI debe contener un número de documento válido."))
                    {
                        if (clienteNegocio.DniExiste(int.Parse(txtDni.Text)))
                        {
                            //MessageBox.Show("- El DNI ya existe.", "Error",
                            //                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            erroresSb.AppendLine("- El DNI ya existe.");
                            Resultado = false;
                        }
                    }
                }
            }

            Resultado = ValidarCampo(() => clienteNegocio.TelValido(txtTel.Text),
                                      "El número de telefono debe contener entre 7 y 15 digitos.") ? Resultado : false;
            Resultado = ValidarCampo(() => clienteNegocio.EmailValido(txtEmail.Text),
                                      "El email debe tener un formato válido (Ejemplo: usuario@dominio.com).") ? Resultado : false;
            Resultado = ValidarCampo(() => clienteNegocio.DireccionValido(txtDireccion.Text),
                                      "La dirección solo puede contener números, letras o espacios.(Ejemplo: Calle 1234)") ? Resultado : false;

            if (!Resultado)
            {
                MessageBox.Show(erroresSb.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Resultado;
        }

        private bool ValidarCampo(Func<bool> validacion, string Mensaje)
        {
            bool valido = validacion();
            if (!valido)
            {
                erroresSb.AppendLine("- " + Mensaje);
                //MessageBox.Show(Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return valido;
        }

        private void btnGuardarDatos_Click(object sender, EventArgs e)
        {
            if (ClienteSeleccionado == null)
            {
                MessageBox.Show("Seleccione un cliente.");
                return;
            }

            if (!DatosValidos(clienteNegocio, "Modificar"))
            {
                return;
            }

            Cliente cliente = new Cliente();

            cliente.Nombre = txtNombre.Text.ToUpper();
            cliente.Dni = int.Parse(txtDni.Text);
            cliente.Telefono = txtTel.Text;
            cliente.Email = txtEmail.Text;
            cliente.Direccion = txtDireccion.Text.ToUpper();
            cliente.Id = ClienteSeleccionado.Id; ;

            DialogResult Respuesta = MessageBox.Show($"Está seguro que desea modificar al cliente:\nDNI: {cliente.Dni}.",
                                              "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Respuesta == DialogResult.Yes)
            {
                clienteNegocio.ModificarCliente(cliente);
                MessageBox.Show("Datos modificados correctamente.");

                OcultarBotones();
                MostrarBoton(btnNuevo, btnModificar, btnEliminar);

                dgvClientes.Enabled = true;

                CamposHabilitados(false);
                MostrarDatosClienteSeleccionado();

                ActualizarClientes();
                BuscarCliente();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!DatosValidos(clienteNegocio, "Agregar"))
            {
                return;
            }

            Cliente cliente = new Cliente();

            cliente.Nombre = txtNombre.Text.ToUpper();
            cliente.Dni = int.Parse(txtDni.Text);
            cliente.Telefono = txtTel.Text;
            cliente.Email = txtEmail.Text;
            cliente.Direccion = txtDireccion.Text.ToUpper();

            clienteNegocio.AgregarCliente(cliente);

            OcultarBotones();
            MostrarBoton(btnNuevo, btnModificar, btnEliminar);

            MessageBox.Show("Cliente guardado correctamente.");

            ActualizarClientes();
            BuscarCliente();

            dgvClientes.Enabled = true;
            MostrarDatosClienteSeleccionado();
            CamposHabilitados(false);

            lblCamposObligatorios.Visible = false;
            lblNombreObligatorio.Visible = false;
            lblDniObligatorio.Visible = false;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (FormPadre != null && ClienteSeleccionado != null)
            {
                FormPadre.EstablecerCliente(ClienteSeleccionado);
                this.Close();
            }
        }
    }
}