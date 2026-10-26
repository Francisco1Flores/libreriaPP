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

namespace Presentacion
{
    public partial class FormCompras : Form
    {
        public FormCompras()
        {
            InitializeComponent();
        }

        private void FormCompras_Load(object sender, EventArgs e)
        {
            CargarGrillaProveedores();
        }
        private void CargarGrillaProveedores()
        {
            try
            {
                // Instanciamos la capa de Negocio
                ProveedorNegocio objNegocio = new ProveedorNegocio();

                // Asignamos la lista a la tabla visual (asegúrate de que tu DataGridView se llame dgvProveedores)
                dgvProveedores.DataSource = objNegocio.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los proveedores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
