using Entidades;
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
    public partial class FormProveedor : Form
    {
        private ProveedorNegocio proveedorNegocio = new ProveedorNegocio();
        private int idProveedorSeleccionado = 0;

        public FormProveedor()
        {
            InitializeComponent();
        

    // Paleta de colores Dark Mode
    Color fondoOscuro = Color.FromArgb(30, 30, 30);
    Color tarjetaGris = Color.FromArgb(45, 45, 48);
    Color campoTexto = Color.FromArgb(37, 37, 38);
    Color textoClaro = Color.FromArgb(240, 240, 240);
    Color bordeGris = Color.FromArgb(60, 60, 60);

    // Fondo del formulario
    this.BackColor = fondoOscuro;

    // Título y búsqueda
    lblTitulo.ForeColor = Color.FromArgb(187, 134, 252); // Violeta suave
    lblBuscar.ForeColor = textoClaro;

    txtBuscarProveedor.BackColor = campoTexto;
    txtBuscarProveedor.ForeColor = textoClaro;
    txtBuscarProveedor.BorderStyle = BorderStyle.FixedSingle;

    // GroupBox y sus controles internos (Labels, TextBoxes y Botones)
    gbProveedor.BackColor = tarjetaGris;
    gbProveedor.ForeColor = textoClaro;

    foreach (Control c in gbProveedor.Controls)
    {
        if (c is Label lbl)
        {
            lbl.ForeColor = textoClaro;
        }
        else if (c is TextBox txt)
        {
            txt.BackColor = campoTexto;
            txt.ForeColor = textoClaro;
            txt.BorderStyle = BorderStyle.FixedSingle;
        }
        else if (c is Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 1;
            btn.FlatAppearance.BorderColor = bordeGris;
            btn.BackColor = Color.FromArgb(55, 55, 60);
            btn.ForeColor = textoClaro;
        }
    }

    // Estilo de los botones que estén afuera del GroupBox
    btnGuardar.FlatStyle = FlatStyle.Flat;
    btnGuardar.FlatAppearance.BorderSize = 1;
    btnGuardar.FlatAppearance.BorderColor = bordeGris;
    btnGuardar.BackColor = Color.FromArgb(65, 80, 140); // Azul tenue para destacar
    btnGuardar.ForeColor = Color.White;

    btnModificar.FlatStyle = FlatStyle.Flat;
    btnModificar.FlatAppearance.BorderSize = 1;
    btnModificar.FlatAppearance.BorderColor = bordeGris;
    btnModificar.BackColor = Color.FromArgb(55, 55, 60);
    btnModificar.ForeColor = textoClaro;

    btnLimpiar.FlatStyle = FlatStyle.Flat;
    btnLimpiar.FlatAppearance.BorderSize = 1;
    btnLimpiar.FlatAppearance.BorderColor = bordeGris;
    btnLimpiar.BackColor = Color.FromArgb(55, 55, 60);
    btnLimpiar.ForeColor = textoClaro;

    btnEliminar.FlatStyle = FlatStyle.Flat;
    btnEliminar.FlatAppearance.BorderSize = 1;
    btnEliminar.FlatAppearance.BorderColor = bordeGris;
    btnEliminar.BackColor = Color.FromArgb(120, 40, 40); // Rojo apagado
    btnEliminar.ForeColor = Color.White;

    // Estilo de la grilla (DataGridView)
    dgvProveedores.BackgroundColor = tarjetaGris;
    dgvProveedores.BorderStyle = BorderStyle.None;
    dgvProveedores.GridColor = bordeGris;
    dgvProveedores.EnableHeadersVisualStyles = false;

    // Filas de datos
    dgvProveedores.DefaultCellStyle.BackColor = tarjetaGris;
    dgvProveedores.DefaultCellStyle.ForeColor = textoClaro;
    dgvProveedores.DefaultCellStyle.SelectionBackColor = Color.FromArgb(90, 70, 130);
    dgvProveedores.DefaultCellStyle.SelectionForeColor = Color.White;

    // Encabezado de columnas
    dgvProveedores.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(35, 35, 38);
    dgvProveedores.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
    dgvProveedores.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
        }

        private void FormProveedor_Load(object sender, EventArgs e)
        {
            CargarTablaProveedores();
        }

        private void CargarTablaProveedores()
        {
            try
            {
                dgvProveedores.DataSource = proveedorNegocio.ListarProveedores();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar proveedores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBuscarProveedor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvProveedores.DataSource = proveedorNegocio.BuscarProveedores(txtBuscarProveedor.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvProveedores.Rows[e.RowIndex];

                idProveedorSeleccionado = Convert.ToInt32(fila.Cells["ID"].Value);
                txtNombre.Text = fila.Cells["Nombre"].Value?.ToString();
                txtCuil.Text = fila.Cells["CUIL"].Value?.ToString();
                txtTelefono.Text = fila.Cells["Teléfono"].Value?.ToString();
                txtEmail.Text = fila.Cells["Email"].Value?.ToString();
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtCuil.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            idProveedorSeleccionado = 0;
            txtNombre.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Proveedor prov = new Proveedor()
                {
                    Nombre = txtNombre.Text.Trim(),
                    Cuil = txtCuil.Text.Trim(),
                    Tel = txtTelefono.Text.Trim(),
                    Email = txtEmail.Text.Trim()
                };

                proveedorNegocio.Registrar(prov);

                MessageBox.Show("¡Proveedor registrado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarTablaProveedores();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idProveedorSeleccionado == 0)
                {
                    MessageBox.Show("Seleccione un proveedor de la tabla para modificar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Proveedor prov = new Proveedor()
                {
                    Id = idProveedorSeleccionado,
                    Nombre = txtNombre.Text.Trim(),
                    Cuil = txtCuil.Text.Trim(),
                    Tel = txtTelefono.Text.Trim(),
                    Email = txtEmail.Text.Trim()
                };

                proveedorNegocio.Modificar(prov);

                MessageBox.Show("¡Proveedor modificado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarTablaProveedores();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idProveedorSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un proveedor de la tabla para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "¿Está seguro de eliminar este proveedor?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    proveedorNegocio.Eliminar(idProveedorSeleccionado);
                    MessageBox.Show("Proveedor eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarTablaProveedores();
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
