using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocio;

namespace Presentacion
{
    public partial class FormCompras : Form
    {
        // Variable única para almacenar el ID del proveedor seleccionado (0 = Alta nueva, >0 = Modificación)
        private int idProveedorSeleccionado = 0;

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
                ProveedorNegocio objNegocio = new ProveedorNegocio();
                // Usamos .Listar() que es como lo tienes definido en tu capa de Negocio
                dgvProveedores.DataSource = objNegocio.ListarActivos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los proveedores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento cuando haces clic en una fila del DataGridView (Sube los datos a los TextBox)
        private void dgvProveedores_CellCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProveedores.Rows[e.RowIndex];

                // Guardamos el ID del proveedor seleccionado
                idProveedorSeleccionado = Convert.ToInt32(row.Cells["IdProveedor"].Value);

                // Llenamos las cajas de texto con los valores de la fila
                txtRazonSocial.Text = row.Cells["RazonSocial"].Value.ToString();
                txtCuit.Text = row.Cells["Cuit"].Value.ToString();
                txtTelefono.Text = row.Cells["Telefono"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
            }
        }

        // Único botón Guardar inteligente (Registra si es nuevo, Modifica si seleccionaste uno de la grilla)
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Proveedor proveedor = new Proveedor()
            {
                IdProveedor = idProveedorSeleccionado,
                RazonSocial = txtRazonSocial.Text.Trim(),
                Cuit = txtCuit.Text.Trim(),
                Telefono = txtTelefono.Text.Trim(),
                Email = txtEmail.Text.Trim()
            };

            if (idProveedorSeleccionado == 0)
            {
                // --- CASO A: REGISTRAR (NUEVO) ---
                int resultado = new ProveedorNegocio().Registrar(proveedor, out mensaje);

                if (resultado != 0)
                {
                    MessageBox.Show("Proveedor registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGrillaProveedores();
                    LimpiarFormulario();
                }
                else
                {
                    MessageBox.Show("Error al registrar: " + mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // --- CASO B: MODIFICAR (ACTUALIZAR) ---
                bool resultado = new ProveedorNegocio().Modificar(proveedor, out mensaje);

                if (resultado)
                {
                    MessageBox.Show("Proveedor modificado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGrillaProveedores();
                    LimpiarFormulario();
                }
                else
                {
                    MessageBox.Show("Error al modificar: " + mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Método auxiliar prolijo para limpiar campos y resetear el ID
        private void LimpiarFormulario()
        {
            txtRazonSocial.Clear();
            txtCuit.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            idProveedorSeleccionado = 0;
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificamos que realmente se haya seleccionado un proveedor de la grilla
            if (idProveedorSeleccionado == 0)
            {
                MessageBox.Show("Por favor, seleccione un proveedor de la tabla para dar de baja.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Cuadro de diálogo de confirmación (muy profesional para evitar errores accidentales)
            DialogResult confirmacion = MessageBox.Show("¿Está seguro de que desea dar de baja este proveedor?", "Confirmar Baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                string mensaje = string.Empty;
                bool resultado = new ProveedorNegocio().BajaLogica(idProveedorSeleccionado, out mensaje);

                if (resultado)
                {
                    MessageBox.Show("Proveedor dado de baja exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGrillaProveedores(); // Actualiza la grilla
                    LimpiarFormulario();       // Limpia los TextBox y resetea el ID a 0
                }
                else
                {
                    MessageBox.Show("Error al dar de baja: " + mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            // Verificamos que realmente se haya seleccionado un proveedor de la grilla
            if (idProveedorSeleccionado == 0)
            {
                MessageBox.Show("Por favor, seleccione un proveedor de la tabla para dar de baja.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Cuadro de diálogo de confirmación (ideal para mostrar seguridad en el sistema)
            DialogResult confirmacion = MessageBox.Show("¿Está seguro de que desea dar de baja este proveedor?", "Confirmar Baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                string mensaje = string.Empty;
                bool resultado = new ProveedorNegocio().BajaLogica(idProveedorSeleccionado, out mensaje);

                if (resultado)
                {
                    MessageBox.Show("Proveedor dado de baja exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGrillaProveedores(); // Actualiza la grilla reflejando el cambio de estado
                    LimpiarFormulario();       // Limpia los campos y resetea el ID a 0
                }
                else
                {
                    MessageBox.Show("Error al dar de baja: " + mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}