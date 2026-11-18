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
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(187, 134, 252);
            lblTitulo.Location = new Point(21, 28);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(275, 28);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "GESTIÓN DE PROVEEDORES";
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.ForeColor = Color.FromArgb(240, 240, 240);
            lblBuscar.Location = new Point(21, 95);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(128, 20);
            lblBuscar.TabIndex = 1;
            lblBuscar.Text = "Buscar proveedor:";
            // 
            // txtBuscarProveedor
            // 
            txtBuscarProveedor.BackColor = Color.FromArgb(37, 37, 38);
            txtBuscarProveedor.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarProveedor.ForeColor = Color.FromArgb(240, 240, 240);
            txtBuscarProveedor.Location = new Point(165, 92);
            txtBuscarProveedor.Name = "txtBuscarProveedor";
            txtBuscarProveedor.Size = new Size(672, 27);
            txtBuscarProveedor.TabIndex = 2;
            txtBuscarProveedor.TextChanged += txtBuscarProveedor_TextChanged;
            // 
            // dgvProveedores
            // 
            dgvProveedores.AllowUserToAddRows = false;
            dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProveedores.BackgroundColor = Color.FromArgb(45, 45, 48);
            dgvProveedores.BorderStyle = BorderStyle.None;
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedores.EnableHeadersVisualStyles = false;
            dgvProveedores.GridColor = Color.FromArgb(60, 60, 60);
            dgvProveedores.Location = new Point(60, 136);
            dgvProveedores.MultiSelect = false;
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.ReadOnly = true;
            dgvProveedores.RowHeadersWidth = 35;
            dgvProveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProveedores.Size = new Size(816, 387);
            dgvProveedores.TabIndex = 3;
            dgvProveedores.CellClick += dgvProveedores_CellClick;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(65, 80, 140);
            btnGuardar.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 60);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(117, 299);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 32);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(55, 55, 60);
            btnModificar.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 60);
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.ForeColor = Color.FromArgb(240, 240, 240);
            btnModificar.Location = new Point(224, 299);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 32);
            btnModificar.TabIndex = 6;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(55, 55, 60);
            btnLimpiar.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 60);
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.ForeColor = Color.FromArgb(240, 240, 240);
            btnLimpiar.Location = new Point(331, 299);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 32);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(120, 40, 40);
            btnEliminar.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 60);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(439, 299);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 32);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.ForeColor = Color.FromArgb(240, 240, 240);
            lblNombre.Location = new Point(25, 48);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(166, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Razón Social / Nombre:";
            // 
            // lblCuil
            // 
            lblCuil.AutoSize = true;
            lblCuil.ForeColor = Color.FromArgb(240, 240, 240);
            lblCuil.Location = new Point(25, 97);
            lblCuil.Name = "lblCuil";
            lblCuil.Size = new Size(87, 20);
            lblCuil.TabIndex = 1;
            lblCuil.Text = "CUIL / CUIT:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.ForeColor = Color.FromArgb(240, 240, 240);
            lblTelefono.Location = new Point(25, 144);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(70, 20);
            lblTelefono.TabIndex = 2;
            lblTelefono.Text = "Teléfono:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.ForeColor = Color.FromArgb(240, 240, 240);
            lblEmail.Location = new Point(25, 191);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email:";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(37, 37, 38);
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.ForeColor = Color.FromArgb(240, 240, 240);
            txtNombre.Location = new Point(205, 45);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(380, 27);
            txtNombre.TabIndex = 4;
            // 
            // txtCuil
            // 
            txtCuil.BackColor = Color.FromArgb(37, 37, 38);
            txtCuil.BorderStyle = BorderStyle.FixedSingle;
            txtCuil.ForeColor = Color.FromArgb(240, 240, 240);
            txtCuil.Location = new Point(205, 94);
            txtCuil.Name = "txtCuil";
            txtCuil.Size = new Size(380, 27);
            txtCuil.TabIndex = 5;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.FromArgb(37, 37, 38);
            txtTelefono.BorderStyle = BorderStyle.FixedSingle;
            txtTelefono.ForeColor = Color.FromArgb(240, 240, 240);
            txtTelefono.Location = new Point(205, 141);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(380, 27);
            txtTelefono.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(37, 37, 38);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.ForeColor = Color.FromArgb(240, 240, 240);
            txtEmail.Location = new Point(205, 188);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(380, 27);
            txtEmail.TabIndex = 7;
            // 
            // gbProveedor
            // 
            gbProveedor.BackColor = Color.FromArgb(45, 45, 48);
            gbProveedor.Controls.Add(btnEliminar);
            gbProveedor.Controls.Add(txtEmail);
            gbProveedor.Controls.Add(btnLimpiar);
            gbProveedor.Controls.Add(txtTelefono);
            gbProveedor.Controls.Add(btnModificar);
            gbProveedor.Controls.Add(txtCuil);
            gbProveedor.Controls.Add(btnGuardar);
            gbProveedor.Controls.Add(txtNombre);
            gbProveedor.Controls.Add(lblEmail);
            gbProveedor.Controls.Add(lblTelefono);
            gbProveedor.Controls.Add(lblCuil);
            gbProveedor.Controls.Add(lblNombre);
            gbProveedor.ForeColor = Color.FromArgb(240, 240, 240);
            gbProveedor.Location = new Point(969, 136);
            gbProveedor.Name = "gbProveedor";
            gbProveedor.Size = new Size(640, 387);
            gbProveedor.TabIndex = 4;
            gbProveedor.TabStop = false;
            gbProveedor.Text = "REGISTRAR / EDITAR PROVEEDOR";
            // 
            // FormProveedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1764, 660);
            Controls.Add(gbProveedor);
            Controls.Add(dgvProveedores);
            Controls.Add(txtBuscarProveedor);
            Controls.Add(lblBuscar);
            Controls.Add(lblTitulo);
            ForeColor = Color.FromArgb(240, 240, 240);
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