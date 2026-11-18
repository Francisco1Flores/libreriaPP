namespace Presentacion
{
    partial class FormStock
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
            txtBuscarProductos = new TextBox();
            dgvStock = new DataGridView();
            gbProducto = new GroupBox();
            cmbProveedor = new ComboBox();
            cmbRubro = new ComboBox();
            lblProveedor = new Label();
            lblRubro = new Label();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            btnModificar = new Button();
            btnGuardar = new Button();
            txtCantidad = new TextBox();
            lblCantidad = new Label();
            txtPrecioVenta = new TextBox();
            lblPrecioVenta = new Label();
            txtPrecioLista = new TextBox();
            lblPrecioLista = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            txtCodigo = new TextBox();
            lblCodigo = new Label();
            lblBuscar = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStock).BeginInit();
            gbProducto.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(187, 134, 252);
            lblTitulo.Location = new Point(21, 28);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(340, 28);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "CONTROL DE STOCK Y PRODUCTOS";
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.ForeColor = Color.FromArgb(240, 240, 240);
            lblBuscar.Location = new Point(21, 95);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(125, 20);
            lblBuscar.TabIndex = 5;
            lblBuscar.Text = "Buscar producto:";
            // 
            // txtBuscarProductos
            // 
            txtBuscarProductos.BackColor = Color.FromArgb(37, 37, 38);
            txtBuscarProductos.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarProductos.ForeColor = Color.FromArgb(240, 240, 240);
            txtBuscarProductos.Location = new Point(165, 92);
            txtBuscarProductos.Name = "txtBuscarProductos";
            txtBuscarProductos.Size = new Size(520, 27);
            txtBuscarProductos.TabIndex = 1;
            txtBuscarProductos.TextChanged += txtBuscarProductos_TextChanged;
            // 
            // dgvStock
            // 
            dgvStock.AllowUserToAddRows = false;
            dgvStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStock.BackgroundColor = Color.FromArgb(45, 45, 48);
            dgvStock.BorderStyle = BorderStyle.None;
            dgvStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStock.EnableHeadersVisualStyles = false;
            dgvStock.GridColor = Color.FromArgb(60, 60, 60);
            dgvStock.Location = new Point(21, 136);
            dgvStock.MultiSelect = false;
            dgvStock.Name = "dgvStock";
            dgvStock.ReadOnly = true;
            dgvStock.RowHeadersWidth = 35;
            dgvStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStock.Size = new Size(1484, 230);
            dgvStock.TabIndex = 3;
            dgvStock.CellClick += dgvStock_CellClick;
            // 
            // gbProducto
            // 
            gbProducto.BackColor = Color.FromArgb(45, 45, 48);
            gbProducto.Controls.Add(cmbProveedor);
            gbProducto.Controls.Add(cmbRubro);
            gbProducto.Controls.Add(lblProveedor);
            gbProducto.Controls.Add(lblRubro);
            gbProducto.Controls.Add(btnEliminar);
            gbProducto.Controls.Add(btnLimpiar);
            gbProducto.Controls.Add(btnModificar);
            gbProducto.Controls.Add(btnGuardar);
            gbProducto.Controls.Add(txtCantidad);
            gbProducto.Controls.Add(lblCantidad);
            gbProducto.Controls.Add(txtPrecioVenta);
            gbProducto.Controls.Add(lblPrecioVenta);
            gbProducto.Controls.Add(txtPrecioLista);
            gbProducto.Controls.Add(lblPrecioLista);
            gbProducto.Controls.Add(txtNombre);
            gbProducto.Controls.Add(lblNombre);
            gbProducto.Controls.Add(txtCodigo);
            gbProducto.Controls.Add(lblCodigo);
            gbProducto.ForeColor = Color.FromArgb(240, 240, 240);
            gbProducto.Location = new Point(21, 385);
            gbProducto.Name = "gbProducto";
            gbProducto.Size = new Size(1484, 245);
            gbProducto.TabIndex = 4;
            gbProducto.TabStop = false;
            gbProducto.Text = "REGISTRAR / EDITAR PRODUCTO";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.ForeColor = Color.FromArgb(240, 240, 240);
            lblNombre.Location = new Point(25, 45);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(37, 37, 38);
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.ForeColor = Color.FromArgb(240, 240, 240);
            txtNombre.Location = new Point(145, 42);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(220, 27);
            txtNombre.TabIndex = 3;
            // 
            // lblPrecioLista
            // 
            lblPrecioLista.AutoSize = true;
            lblPrecioLista.ForeColor = Color.FromArgb(240, 240, 240);
            lblPrecioLista.Location = new Point(25, 92);
            lblPrecioLista.Name = "lblPrecioLista";
            lblPrecioLista.Size = new Size(109, 20);
            lblPrecioLista.TabIndex = 4;
            lblPrecioLista.Text = "Precio Lista ($):";
            // 
            // txtPrecioLista
            // 
            txtPrecioLista.BackColor = Color.FromArgb(37, 37, 38);
            txtPrecioLista.BorderStyle = BorderStyle.FixedSingle;
            txtPrecioLista.ForeColor = Color.FromArgb(240, 240, 240);
            txtPrecioLista.Location = new Point(145, 89);
            txtPrecioLista.Name = "txtPrecioLista";
            txtPrecioLista.Size = new Size(220, 27);
            txtPrecioLista.TabIndex = 5;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.ForeColor = Color.FromArgb(240, 240, 240);
            lblCantidad.Location = new Point(25, 139);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(91, 20);
            lblCantidad.TabIndex = 8;
            lblCantidad.Text = "Stock Inicial:";
            // 
            // txtCantidad
            // 
            txtCantidad.BackColor = Color.FromArgb(37, 37, 38);
            txtCantidad.BorderStyle = BorderStyle.FixedSingle;
            txtCantidad.ForeColor = Color.FromArgb(240, 240, 240);
            txtCantidad.Location = new Point(145, 136);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(220, 27);
            txtCantidad.TabIndex = 9;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.ForeColor = Color.FromArgb(240, 240, 240);
            lblCodigo.Location = new Point(420, 45);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(127, 20);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código de Barras:";
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.FromArgb(37, 37, 38);
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.ForeColor = Color.FromArgb(240, 240, 240);
            txtCodigo.Location = new Point(560, 42);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(220, 27);
            txtCodigo.TabIndex = 1;
            // 
            // lblPrecioVenta
            // 
            lblPrecioVenta.AutoSize = true;
            lblPrecioVenta.ForeColor = Color.FromArgb(240, 240, 240);
            lblPrecioVenta.Location = new Point(420, 92);
            lblPrecioVenta.Name = "lblPrecioVenta";
            lblPrecioVenta.Size = new Size(116, 20);
            lblPrecioVenta.TabIndex = 6;
            lblPrecioVenta.Text = "Precio Venta ($):";
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.BackColor = Color.FromArgb(37, 37, 38);
            txtPrecioVenta.BorderStyle = BorderStyle.FixedSingle;
            txtPrecioVenta.ForeColor = Color.FromArgb(240, 240, 240);
            txtPrecioVenta.Location = new Point(560, 89);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(220, 27);
            txtPrecioVenta.TabIndex = 7;
            // 
            // lblRubro
            // 
            lblRubro.AutoSize = true;
            lblRubro.ForeColor = Color.FromArgb(240, 240, 240);
            lblRubro.Location = new Point(840, 45);
            lblRubro.Name = "lblRubro";
            lblRubro.Size = new Size(52, 20);
            lblRubro.TabIndex = 14;
            lblRubro.Text = "Rubro:";
            // 
            // cmbRubro
            // 
            cmbRubro.BackColor = Color.FromArgb(37, 37, 38);
            cmbRubro.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRubro.FlatStyle = FlatStyle.Flat;
            cmbRubro.ForeColor = Color.FromArgb(240, 240, 240);
            cmbRubro.FormattingEnabled = true;
            cmbRubro.Location = new Point(935, 42);
            cmbRubro.Name = "cmbRubro";
            cmbRubro.Size = new Size(220, 28);
            cmbRubro.TabIndex = 16;
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.ForeColor = Color.FromArgb(240, 240, 240);
            lblProveedor.Location = new Point(840, 92);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(80, 20);
            lblProveedor.TabIndex = 15;
            lblProveedor.Text = "Proveedor:";
            // 
            // cmbProveedor
            // 
            cmbProveedor.BackColor = Color.FromArgb(37, 37, 38);
            cmbProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProveedor.FlatStyle = FlatStyle.Flat;
            cmbProveedor.ForeColor = Color.FromArgb(240, 240, 240);
            cmbProveedor.FormattingEnabled = true;
            cmbProveedor.Location = new Point(935, 89);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new Size(220, 28);
            cmbProveedor.TabIndex = 17;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(65, 80, 140);
            btnGuardar.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 60);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(145, 192);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 32);
            btnGuardar.TabIndex = 10;
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
            btnModificar.Location = new Point(260, 192);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(100, 32);
            btnModificar.TabIndex = 11;
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
            btnLimpiar.Location = new Point(375, 192);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(100, 32);
            btnLimpiar.TabIndex = 12;
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
            btnEliminar.Location = new Point(490, 192);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 32);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FormStock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1540, 660);
            Controls.Add(lblBuscar);
            Controls.Add(gbProducto);
            Controls.Add(dgvStock);
            Controls.Add(txtBuscarProductos);
            Controls.Add(lblTitulo);
            ForeColor = Color.FromArgb(240, 240, 240);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormStock";
            Text = "Stock";
            Load += FormStock_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvStock).EndInit();
            gbProducto.ResumeLayout(false);
            gbProducto.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private TextBox txtBuscarProductos;
        private DataGridView dgvStock;
        private GroupBox gbProducto;
        private Label lblBuscar;
        private TextBox txtCodigo;
        private Label lblCodigo;
        private TextBox txtPrecioVenta;
        private Label lblPrecioVenta;
        private TextBox txtPrecioLista;
        private Label lblPrecioLista;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtCantidad;
        private Label lblCantidad;
        private Button btnLimpiar;
        private Button btnModificar;
        private Button btnGuardar;
        private Button btnEliminar;
        private ComboBox cmbProveedor;
        private ComboBox cmbRubro;
        private Label lblProveedor;
        private Label lblRubro;
    }
}