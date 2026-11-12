namespace Presentacion
{
    partial class FormProveedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblBuscar = new Label();
            txtBuscarProveedor = new TextBox();
            dgvProveedores = new DataGridView();
            btnGuardar = new Button();
            btnModificar = new Button();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            lblNombre = new Label();
            lblCuil = new Label();
            lblTelefono = new Label();
            lblEmail = new Label();
            txtNombre = new TextBox();
            txtCuil = new TextBox();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            gbProveedor = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            gbProveedor.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(68, 28);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(196, 20);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "GESTIÓN DE PROVEEDORES";
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(4, 136);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(128, 20);
            lblBuscar.TabIndex = 1;
            lblBuscar.Text = "Buscar proveedor:";
            // 
            // txtBuscarProveedor
            // 
            txtBuscarProveedor.Location = new Point(152, 129);
            txtBuscarProveedor.Name = "txtBuscarProveedor";
            txtBuscarProveedor.Size = new Size(125, 27);
            txtBuscarProveedor.TabIndex = 2;
            txtBuscarProveedor.TextChanged += txtBuscarProveedor_TextChanged;
            // 
            // dgvProveedores
            // 
            dgvProveedores.AllowUserToAddRows = false;
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedores.Location = new Point(21, 174);
            dgvProveedores.MultiSelect = false;
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.ReadOnly = true;
            dgvProveedores.RowHeadersWidth = 51;
            dgvProveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProveedores.Size = new Size(274, 83);
            dgvProveedores.TabIndex = 3;
            dgvProveedores.CellClick += dgvProveedores_CellClick;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(218, 393);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(354, 405);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 6;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(490, 407);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(619, 408);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(21, 43);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(166, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Razón Social / Nombre:";
            // 
            // lblCuil
            // 
            lblCuil.AutoSize = true;
            lblCuil.Location = new Point(23, 78);
            lblCuil.Name = "lblCuil";
            lblCuil.Size = new Size(87, 20);
            lblCuil.TabIndex = 1;
            lblCuil.Text = "CUIL / CUIT:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(14, 125);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(70, 20);
            lblTelefono.TabIndex = 2;
            lblTelefono.Text = "Teléfono:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(17, 179);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(193, 40);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 4;
            // 
            // txtCuil
            // 
            txtCuil.Location = new Point(119, 82);
            txtCuil.Name = "txtCuil";
            txtCuil.Size = new Size(125, 27);
            txtCuil.TabIndex = 5;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(117, 133);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(125, 27);
            txtTelefono.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(99, 179);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 7;
            // 
            // gbProveedor
            // 
            gbProveedor.Controls.Add(txtEmail);
            gbProveedor.Controls.Add(txtTelefono);
            gbProveedor.Controls.Add(txtCuil);
            gbProveedor.Controls.Add(txtNombre);
            gbProveedor.Controls.Add(lblEmail);
            gbProveedor.Controls.Add(lblTelefono);
            gbProveedor.Controls.Add(lblCuil);
            gbProveedor.Controls.Add(lblNombre);
            gbProveedor.Location = new Point(875, 136);
            gbProveedor.Name = "gbProveedor";
            gbProveedor.Size = new Size(756, 387);
            gbProveedor.TabIndex = 4;
            gbProveedor.TabStop = false;
            gbProveedor.Text = "REGISTRAR / EDITAR PROVEEDOR";
            // 
            // FormProveedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1790, 694);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(gbProveedor);
            Controls.Add(dgvProveedores);
            Controls.Add(txtBuscarProveedor);
            Controls.Add(lblBuscar);
            Controls.Add(lblTitulo);
            ForeColor = Color.FromArgb(30, 30, 30);
            Name = "FormProveedor";
            Text = "FormProveedor";
            Load += FormProveedor_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            gbProveedor.ResumeLayout(false);
            gbProveedor.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblBuscar;
        private TextBox txtBuscarProveedor;
        private DataGridView dgvProveedores;
        private Button btnGuardar;
        private Button btnModificar;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Label lblNombre;
        private Label lblCuil;
        private Label lblTelefono;
        private Label lblEmail;
        private TextBox txtNombre;
        private TextBox txtCuil;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private GroupBox gbProveedor;
    }
}