namespace Presentacion
{
    partial class FormRegistrarCompra
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
            cmbProveedor = new ComboBox();
            cmbFormaPago = new ComboBox();
            cmbProducto = new ComboBox();
            txtCantidad = new TextBox();
            txtPrecio = new TextBox();
            btnRegistrarCompra = new Button();
            btnAgregar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dgvDetalle = new DataGridView();
            colIdProducto = new DataGridViewTextBoxColumn();
            colNombreProducto = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            colSubTotal = new DataGridViewTextBoxColumn();
            lblTotal = new Label();
            btnProveedores = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            SuspendLayout();
            // 
            // cmbProveedor
            // 
            cmbProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProveedor.FormattingEnabled = true;
            cmbProveedor.Location = new Point(12, 43);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new Size(142, 23);
            cmbProveedor.TabIndex = 0;
            cmbProveedor.SelectedIndexChanged += cmbProveedor_SelectedIndexChanged;
            // 
            // cmbFormaPago
            // 
            cmbFormaPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFormaPago.FormattingEnabled = true;
            cmbFormaPago.Location = new Point(168, 43);
            cmbFormaPago.Name = "cmbFormaPago";
            cmbFormaPago.Size = new Size(121, 23);
            cmbFormaPago.TabIndex = 1;
            // 
            // cmbProducto
            // 
            cmbProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(12, 110);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(142, 23);
            cmbProducto.TabIndex = 2;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(170, 110);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 3;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(285, 110);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 4;
            // 
            // btnRegistrarCompra
            // 
            btnRegistrarCompra.BackColor = Color.PaleGreen;
            btnRegistrarCompra.Location = new Point(475, 339);
            btnRegistrarCompra.Name = "btnRegistrarCompra";
            btnRegistrarCompra.Size = new Size(134, 23);
            btnRegistrarCompra.TabIndex = 5;
            btnRegistrarCompra.Text = "Registrar Compra";
            btnRegistrarCompra.UseVisualStyleBackColor = false;
            btnRegistrarCompra.Click += btnRegistrarCompra_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.LightSteelBlue;
            btnAgregar.Location = new Point(12, 139);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 7;
            label1.Text = "Proveedor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(168, 25);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 8;
            label2.Text = "Forma de Pago";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 92);
            label3.Name = "label3";
            label3.Size = new Size(119, 15);
            label3.TabIndex = 9;
            label3.Text = "Seleccionar Producto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(170, 92);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 10;
            label4.Text = "Cantidad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(285, 92);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 11;
            label5.Text = "Precio";
            // 
            // dgvDetalle
            // 
            dgvDetalle.AllowUserToAddRows = false;
            dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Columns.AddRange(new DataGridViewColumn[] { colIdProducto, colNombreProducto, colCantidad, colPrecio, colSubTotal });
            dgvDetalle.Location = new Point(12, 168);
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.ReadOnly = true;
            dgvDetalle.Size = new Size(597, 125);
            dgvDetalle.TabIndex = 12;
            // 
            // colIdProducto
            // 
            colIdProducto.HeaderText = "Id";
            colIdProducto.Name = "colIdProducto";
            colIdProducto.ReadOnly = true;
            // 
            // colNombreProducto
            // 
            colNombreProducto.HeaderText = "Producto";
            colNombreProducto.Name = "colNombreProducto";
            colNombreProducto.ReadOnly = true;
            // 
            // colCantidad
            // 
            colCantidad.HeaderText = "Cantidad";
            colCantidad.Name = "colCantidad";
            colCantidad.ReadOnly = true;
            // 
            // colPrecio
            // 
            colPrecio.HeaderText = "Precio Unitario";
            colPrecio.Name = "colPrecio";
            colPrecio.ReadOnly = true;
            // 
            // colSubTotal
            // 
            colSubTotal.HeaderText = "Subtotal";
            colSubTotal.Name = "colSubTotal";
            colSubTotal.ReadOnly = true;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(496, 308);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(92, 19);
            lblTotal.TabIndex = 13;
            lblTotal.Text = "Total: $ 0.00";
            // 
            // btnProveedores
            // 
            btnProveedores.Location = new Point(454, 19);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(116, 47);
            btnProveedores.TabIndex = 14;
            btnProveedores.Text = "VER\r\nProveedores";
            btnProveedores.UseVisualStyleBackColor = true;
            btnProveedores.Click += btnProveedores_Click;
            // 
            // FormRegistrarCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnProveedores);
            Controls.Add(lblTotal);
            Controls.Add(dgvDetalle);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAgregar);
            Controls.Add(btnRegistrarCompra);
            Controls.Add(txtPrecio);
            Controls.Add(txtCantidad);
            Controls.Add(cmbProducto);
            Controls.Add(cmbFormaPago);
            Controls.Add(cmbProveedor);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormRegistrarCompra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar Compra";
            Load += FormRegistrarCompra_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbProveedor;
        private ComboBox cmbFormaPago;
        private ComboBox cmbProducto;
        private TextBox txtCantidad;
        private TextBox txtPrecio;
        private Button btnRegistrarCompra;
        private Button btnAgregar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView dgvDetalle;
        private DataGridViewTextBoxColumn colIdProducto;
        private DataGridViewTextBoxColumn colNombreProducto;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewTextBoxColumn colPrecio;
        private DataGridViewTextBoxColumn colSubTotal;
        private Label lblTotal;
        private Button btnProveedores;
    }
}