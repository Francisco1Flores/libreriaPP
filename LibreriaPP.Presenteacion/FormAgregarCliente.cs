using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            }
            else if (tipo.Equals("modificar"))
            {
                btnAccion.Text = "Modificar";

                txtNombre.Text = cliente.nombre;
                txtDni.Text = cliente.dni.ToString();
                txtDni.Enabled = false;
                txtTel.Text = cliente.tel.ToString();
                txtEmail.Text = cliente.email;
                txtDireccion.Text = cliente.direccion;

                this.cliente = cliente;
            }
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            // TODO: validar datos
            ClienteNegocio clienteNegocio = new ClienteNegocio();

            Cliente cliente = new Cliente();

            cliente.nombre = txtNombre.Text;
            cliente.dni = int.Parse(txtDni.Text);
            cliente.tel = int.Parse(txtTel.Text);
            cliente.email = txtEmail.Text;
            cliente.direccion = txtDireccion.Text;

            if (btnAccion.Text.Equals("Agregar"))
            {
                clienteNegocio.AgregarCliente(cliente);
            }
            else if (btnAccion.Text.Equals("Modificar"))
            {
                cliente.id = this.cliente.id;
                clienteNegocio.ModificarCliente(cliente);
            }
            formPadre.ActualizarClientes();

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
