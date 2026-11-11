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
        private List<Cliente> listaClientes;       
        public FormClientes()
        {
            InitializeComponent();
            ActualizarClientes();

            dgvClientes.Columns[0].HeaderText = "ID";
            dgvClientes.Columns[1].HeaderText = "Nombre";
            dgvClientes.Columns[2].HeaderText = "DNI";
            dgvClientes.Columns[3].HeaderText = "Teléfono";
            dgvClientes.Columns[4].HeaderText = "Email";
            dgvClientes.Columns[5].HeaderText = "Dirección";

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
            SetDGVStyle(dgvClientes);
        }

        public void SetDGVStyle(DataGridView dgv)
        {
            dgv.EnableHeadersVisualStyles = false;
          
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 12, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        public void ActualizarClientes()
        {
            ClienteNegocio clienteNegocio = new ClienteNegocio();
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

        private void btnModificarOEliminarCliente_Click(object sender, DataGridViewCellEventArgs e)
        {            
            bool cambio = false;
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvClientes.Columns["Modificar"].Index)
            {
                ModificarCliente(e);
                cambio = true;
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == dgvClientes.Columns["Eliminar"].Index)
            {
                string nombre = dgvClientes.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
                string dni    = dgvClientes.Rows[e.RowIndex].Cells["dni"].Value.ToString();

                DialogResult respuesta = MessageBox.Show(
                    $"Está seguro que desea eliminar al cliente:\nNombre: {nombre}.\nDNI: {dni}.","",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    EliminarCliente(e);
                    cambio = true;
                }                
            }
            if (cambio)
            {
                ActualizarClientes();
            } 
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

            cliente.id        = int.Parse(fila.Cells["id"].Value.ToString());
            cliente.nombre    = fila.Cells["nombre"].Value.ToString();
            cliente.dni       = int.Parse(fila.Cells["dni"].Value.ToString());
            cliente.tel       = fila.Cells["tel"].Value.ToString();
            cliente.email     = fila.Cells["email"].Value.ToString();
            cliente.direccion = fila.Cells["direccion"].Value.ToString();

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
                    if (cliente.nombre.Contains(texto)           ||
                        cliente.nombre.Contains(texto.ToUpper()) ||
                        cliente.dni.ToString().Contains(texto))
                    {                       
                        encontrados.Add(cliente);
                    }
                }
                dgvClientes.DataSource = encontrados;
            }
        }
    }
}
