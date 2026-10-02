using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidades;

namespace Presentacion
{
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
            ActualizarClientes();

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

        public void ActualizarClientes()
        {
            ClienteNegocio clienteNegocio = new ClienteNegocio();
            dgvClientes.DataSource = clienteNegocio.ListarClientes();
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            FormAgregarCliente formAgregarCliente = new FormAgregarCliente("agregar", null, this);
            formAgregarCliente.Show();
        }

        private void btnModificarOEliminarCliente_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvClientes.Columns["Modificar"].Index)
            {
                ModificarCliente(e);
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == dgvClientes.Columns["Eliminar"].Index)
            {                
                EliminarCliente(e);
            }
            ActualizarClientes();            
        }

        private void EliminarCliente(DataGridViewCellEventArgs e)
        {
            int id = int.Parse(dgvClientes.Rows[e.RowIndex].Cells["id"].Value.ToString());
            ClienteNegocio clienteNegocio = new ClienteNegocio();
            clienteNegocio.EliminarCliente(id);
        }
        private void ModificarCliente(DataGridViewCellEventArgs e)
        {
            Cliente cliente = new Cliente();
            DataGridViewRow fila = dgvClientes.Rows[e.RowIndex];

            cliente.id = int.Parse(fila.Cells["id"].Value.ToString());
            cliente.nombre = fila.Cells["nombre"].Value.ToString();
            cliente.dni = int.Parse(fila.Cells["dni"].Value.ToString());
            cliente.tel = int.Parse(fila.Cells["tel"].Value.ToString());
            cliente.email = fila.Cells["email"].Value.ToString();
            cliente.direccion = fila.Cells["direccion"].Value.ToString();

            FormAgregarCliente formAgregarCliente = new FormAgregarCliente("modificar", cliente, this);
            formAgregarCliente.Show();
        }
    }
}
