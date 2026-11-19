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
            lblTitulo = new System.Windows.Forms.Label();
            txtBuscarProductos = new System.Windows.Forms.TextBox();
            dgvStock = new System.Windows.Forms.DataGridView();
            gbProducto = new System.Windows.Forms.GroupBox();
            cmbProveedor = new System.Windows.Forms.ComboBox();
            cmbRubro = new System.Windows.Forms.ComboBox();
            lblProveedor = new System.Windows.Forms.Label();
            lblRubro = new System.Windows.Forms.Label();
            btnEliminar = new System.Windows.Forms.Button();
            btnLimpiar = new System.Windows.Forms.Button();
            btnModificar = new System.Windows.Forms.Button();
            btnGuardar = new System.Windows.Forms.Button();
            txtCantidad = new System.Windows.Forms.TextBox();
            lblCantidad = new System.Windows.Forms.Label();
            txtPrecioVenta = new System.Windows.Forms.TextBox();
            lblPrecioVenta = new System.Windows.Forms.Label();
            txtPrecioLista = new System.Windows.Forms.TextBox();
            lblPrecioLista = new System.Windows.Forms.Label();
            txtNombre = new System.Windows.Forms.TextBox();
            lblNombre = new System.Windows.Forms.Label();
            txtCodigo = new System.Windows.Forms.TextBox();
            lblCodigo = new System.Windows.Forms.Label();
            lblBuscar = new System.Windows.Forms.Label();
            btnNuevoRubro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvStock).BeginInit();
            gbProducto.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)187)), ((int)((byte)134)), ((int)((byte)252)));
            lblTitulo.Location = new System.Drawing.Point(21, 28);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new System.Drawing.Size(347, 28);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "CONTROL DE STOCK Y PRODUCTOS";
            // 
            // txtBuscarProductos
            // 
            txtBuscarProductos.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)37)), ((int)((byte)38)));
            txtBuscarProductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtBuscarProductos.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)240)), ((int)((byte)240)), ((int)((byte)240)));
            txtBuscarProductos.Location = new System.Drawing.Point(165, 92);
            txtBuscarProductos.Name = "txtBuscarProductos";
            txtBuscarProductos.Size = new System.Drawing.Size(520, 27);
            txtBuscarProductos.TabIndex = 1;
            txtBuscarProductos.TextChanged += txtBuscarProductos_TextChanged;
            // 
            // dgvStock
            // 
            dgvStock.AllowUserToAddRows = false;
            dgvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvStock.BackgroundColor = System.Drawing.Color.FromArgb(((int)((byte)45)), ((int)((byte)45)), ((int)((byte)48)));
            dgvStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStock.EnableHeadersVisualStyles = false;
            dgvStock.GridColor = System.Drawing.Color.FromArgb(((int)((byte)60)), ((int)((byte)60)), ((int)((byte)60)));
            dgvStock.Location = new System.Drawing.Point(21, 136);
            dgvStock.MultiSelect = false;
            dgvStock.Name = "dgvStock";
            dgvStock.ReadOnly = true;
            dgvStock.RowHeadersWidth = 35;
            dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvStock.Size = new System.Drawing.Size(1484, 230);
            dgvStock.TabIndex = 3;
            dgvStock.CellClick += dgvStock_CellClick;
            // 
            // gbProducto
            // 
            gbProducto.BackColor = System.Drawing.Color.FromArgb(((int)((byte)45)), ((int)((byte)45)), ((int)((byte)48)));
            gbProducto.Controls.Add(btnNuevoRubro);
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
            gbProducto.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)240)), ((int)((byte)240)), ((int)((byte)240)));
            gbProducto.Location = new System.Drawing.Point(21, 385);
            gbProducto.Name = "gbProducto";
            gbProducto.Size = new System.Drawing.Size(1484, 245);
            gbProducto.TabIndex = 4;
            gbProducto.TabStop = false;
            gbProducto.Text = "REGISTRAR / EDITAR PRODUCTO";
            // 
            // cmbProveedor
            // 
            cmbProveedor.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)37)), ((int)((byte)38)));
            cmbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cmbProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)240)), ((int)((byte)240)), ((int)((byte)240)));
            cmbProveedor.FormattingEnabled = true;
            cmbProveedor.Location = new System.Drawing.Point(935, 89);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new System.Drawing.Size(220, 28);
            cmbProveedor.TabIndex = 17;
            // 
            // cmbRubro
            // 
            cmbRubro.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)37)), ((int)((byte)38)));
            cmbRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbRubro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cmbRubro.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)240)), ((int)((byte)240)), ((int)((byte)240)));
            cmbRubro.FormattingEnabled = true;
            cmbRubro.Location = new System.Drawing.Point(935, 42);
            cmbRubro.Name = "cmbRubro";
            cmbRubro.Size = new System.Drawing.Size(220, 28);
            cmbRubro.TabIndex = 16;
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)240)), ((int)((byte)240)), ((int)((byte)240)));
            lblProveedor.Location = new System.Drawing.Point(840, 92);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new System.Drawing.Size(80, 20);
            lblProveedor.TabIndex = 15;
            lblProveedor.Text = "Proveedor:";
            // 
            // lblRubro
            // 
            lblRubro.AutoSize = true;
            lblRubro.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)240)), ((int)((byte)240)), ((int)((byte)240)));
            lblRubro.Location = new System.Drawing.Point(840, 45);
            lblRubro.Name = "lblRubro";
            lblRubro.Size = new System.Drawing.Size(52, 20);
            lblRubro.TabIndex = 14;
            lblRubro.Text = "Rubro:";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)((byte)120)), ((int)((byte)40)), ((int)((byte)40)));
            btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)60)), ((int)((byte)60)), ((int)((byte)60)));
            btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEliminar.ForeColor = System.Drawing.Color.White;
            btnEliminar.Location = new System.Drawing.Point(490, 192);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(100, 32);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)((byte)55)), ((int)((byte)55)), ((int)((byte)60)));
            btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)60)), ((int)((byte)60)), ((int)((byte)60)));
            btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)240)), ((int)((byte)240)), ((int)((byte)240)));
            btnLimpiar.Location = new System.Drawing.Point(375, 192);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new System.Drawing.Size(100, 32);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)((byte)55)), ((int)((byte)55)), ((int)((byte)60)));
            btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)60)), ((int)((byte)60)), ((int)((byte)60)));
            btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnModificar.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)240)), ((int)((byte)240)), ((int)((byte)240)));
            btnModificar.Location = new System.Drawing.Point(260, 192);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new System.Drawing.Size(100, 32);
            btnModificar.TabIndex = 11;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)((byte)65)), ((int)((byte)80)), ((int)((byte)140)));
            btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)60)), ((int)((byte)60)), ((int)((byte)60)));
            btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGuardar.ForeColor = System.Drawing.Color.White;
            btnGuardar.Location = new System.Drawing.Point(145, 192);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(100, 32);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtCantidad
            // 
            txtCantidad.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)37)), ((int)((byte)38)));
            txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)240)), ((int)((byte)240)), ((int)((byte)240)));
            txtCantidad.Location = new System.Drawing.Point(145, 136);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new System.Drawing.Size(220, 27);
            txtCantidad.TabIndex = 9;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)240)), ((int)((byte)240)), ((int)((byte)240)));
            lblCantidad.Location = new System.Drawing.Point(25, 139);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new System.Drawing.Size(91, 20);
            lblCantidad.TabIndex = 8;
            lblCantidad.Text = "Stock Inicial:";
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)37)), ((int)((byte)38)));
            txtPrecioVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtPrecioVenta.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)240)), ((int)((byte)240)), ((int)((byte)240)));
            txtPrecioVenta.Location = new System.Drawing.Point(560, 89);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new System.Drawing.Size(220, 27);
            txtPrecioVenta.TabIndex = 7;
            // 
            // lblPrecioVenta
            // 
            lblPrecioVenta.AutoSize = true;
            lblPrecioVenta.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)240)), ((int)((byte)240)), ((int)((byte)240)));
            lblPrecioVenta.Location = new System.Drawing.Point(420, 92);
            lblPrecioVenta.Name = "lblPrecioVenta";
            lblPrecioVenta.Size = new System.Drawing.Size(116, 20);
            lblPrecioVenta.TabIndex = 6;
            lblPrecioVenta.Text = "Precio Venta ($):";
            // 
            // txtPrecioLista
            // 
            txtPrecioLista.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)37)), ((int)((byte)38)));
            txtPrecioLista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtPrecioLista.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)240)), ((int)((byte)240)), ((int)((byte)240)));
            txtPrecioLista.Location = new System.Drawing.Point(145, 89);
            txtPrecioLista.Name = "txtPrecioLista";
            txtPrecioLista.Size = new System.Drawing.Size(220, 27);
            txtPrecioLista.TabIndex = 5;
            // 
            // lblPrecioLista
            // 
            lblPrecioLista.AutoSize = true;
            lblPrecioLista.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)240)), ((int)((byte)240)), ((int)((byte)240)));
            lblPrecioLista.Location = new System.Drawing.Point(25, 92);
            lblPrecioLista.Name = "lblPrecioLista";
            lblPrecioLista.Size = new System.Drawing.Size(109, 20);
            lblPrecioLista.TabIndex = 4;
            lblPrecioLista.Text = "Precio Lista ($):";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)37)), ((int)((byte)38)));
            txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)240)), ((int)((byte)240)), ((int)((byte)240)));
            txtNombre.Location = new System.Drawing.Point(145, 42);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(220, 27);
            txtNombre.TabIndex = 3;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)240)), ((int)((byte)240)), ((int)((byte)240)));
            lblNombre.Location = new System.Drawing.Point(25, 45);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new System.Drawing.Size(67, 20);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre:";
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)37)), ((int)((byte)38)));
            txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)240)), ((int)((byte)240)), ((int)((byte)240)));
            txtCodigo.Location = new System.Drawing.Point(560, 42);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new System.Drawing.Size(220, 27);
            txtCodigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)240)), ((int)((byte)240)), ((int)((byte)240)));
            lblCodigo.Location = new System.Drawing.Point(420, 45);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new System.Drawing.Size(127, 20);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código de Barras:";
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)240)), ((int)((byte)240)), ((int)((byte)240)));
            lblBuscar.Location = new System.Drawing.Point(21, 95);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new System.Drawing.Size(120, 20);
            lblBuscar.TabIndex = 5;
            lblBuscar.Text = "Buscar producto:";
            // 
            // btnNuevoRubro
            // 
            btnNuevoRubro.BackColor = System.Drawing.Color.FromArgb(((int)((byte)55)), ((int)((byte)55)), ((int)((byte)60)));
            btnNuevoRubro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)60)), ((int)((byte)60)), ((int)((byte)60)));
            btnNuevoRubro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNuevoRubro.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)240)), ((int)((byte)240)), ((int)((byte)240)));
            btnNuevoRubro.Location = new System.Drawing.Point(1173, 42);
            btnNuevoRubro.Name = "btnNuevoRubro";
            btnNuevoRubro.Size = new System.Drawing.Size(131, 32);
            btnNuevoRubro.TabIndex = 18;
            btnNuevoRubro.Text = "Nuevo Rubro";
            btnNuevoRubro.UseVisualStyleBackColor = false;
            btnNuevoRubro.Click += btnNuevoRubro_Click;
            // 
            // FormStock
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)30)), ((int)((byte)30)));
            ClientSize = new System.Drawing.Size(1540, 660);
            Controls.Add(lblBuscar);
            Controls.Add(gbProducto);
            Controls.Add(dgvStock);
            Controls.Add(txtBuscarProductos);
            Controls.Add(lblTitulo);
            ForeColor = System.Drawing.Color.FromArgb(((int)((byte)240)), ((int)((byte)240)), ((int)((byte)240)));
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Text = "Stock";
            Load += FormStock_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvStock).EndInit();
            gbProducto.ResumeLayout(false);
            gbProducto.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button btnNuevoRubro;

        #endregion

        private Label lblTitulo;
        private TextBox txtBuscarProductos;
        private DataGridView dgvStock;
        private System.Windows.Forms.GroupBox gbProducto;
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