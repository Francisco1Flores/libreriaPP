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
            cmbProveedor = new System.Windows.Forms.ComboBox();
            cmbFormaPago = new System.Windows.Forms.ComboBox();
            cmbProducto = new System.Windows.Forms.ComboBox();
            txtCantidad = new System.Windows.Forms.TextBox();
            txtPrecio = new System.Windows.Forms.TextBox();
            btnRegistrarCompra = new System.Windows.Forms.Button();
            btnAgregar = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            dgvDetalle = new System.Windows.Forms.DataGridView();
            colIdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colNombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            lblTotal = new System.Windows.Forms.Label();
            btnProveedores = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            SuspendLayout();
            // 
            // cmbProveedor
            // 
            cmbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbProveedor.FormattingEnabled = true;
            cmbProveedor.Location = new System.Drawing.Point(12, 43);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new System.Drawing.Size(142, 28);
            cmbProveedor.TabIndex = 0;
            cmbProveedor.SelectedIndexChanged += cmbProveedor_SelectedIndexChanged;
            // 
            // cmbFormaPago
            // 
            cmbFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbFormaPago.FormattingEnabled = true;
            cmbFormaPago.Location = new System.Drawing.Point(168, 43);
            cmbFormaPago.Name = "cmbFormaPago";
            cmbFormaPago.Size = new System.Drawing.Size(121, 28);
            cmbFormaPago.TabIndex = 1;
            // 
            // cmbProducto
            // 
            cmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new System.Drawing.Point(12, 110);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new System.Drawing.Size(142, 28);
            cmbProducto.TabIndex = 2;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new System.Drawing.Point(170, 110);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new System.Drawing.Size(100, 27);
            txtCantidad.TabIndex = 3;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new System.Drawing.Point(285, 110);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new System.Drawing.Size(100, 27);
            txtPrecio.TabIndex = 4;
            // 
            // btnRegistrarCompra
            // 
            btnRegistrarCompra.BackColor = System.Drawing.Color.PaleGreen;
            btnRegistrarCompra.Location = new System.Drawing.Point(475, 339);
            btnRegistrarCompra.Name = "btnRegistrarCompra";
            btnRegistrarCompra.Size = new System.Drawing.Size(134, 23);
            btnRegistrarCompra.TabIndex = 5;
            btnRegistrarCompra.Text = "Registrar Compra";
            btnRegistrarCompra.UseVisualStyleBackColor = false;
            btnRegistrarCompra.Click += btnRegistrarCompra_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = System.Drawing.Color.LightSteelBlue;
            btnAgregar.Location = new System.Drawing.Point(12, 139);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new System.Drawing.Size(75, 23);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 25);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(77, 20);
            label1.TabIndex = 7;
            label1.Text = "Proveedor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(168, 25);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(109, 20);
            label2.TabIndex = 8;
            label2.Text = "Forma de Pago";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 92);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(149, 20);
            label3.TabIndex = 9;
            label3.Text = "Seleccionar Producto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(170, 92);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(69, 20);
            label4.TabIndex = 10;
            label4.Text = "Cantidad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(285, 92);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(50, 20);
            label5.TabIndex = 11;
            label5.Text = "Precio";
            // 
            // dgvDetalle
            // 
            dgvDetalle.AllowUserToAddRows = false;
            dgvDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colIdProducto, colNombreProducto, colCantidad, colPrecio, colSubTotal });
            dgvDetalle.Location = new System.Drawing.Point(12, 168);
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.ReadOnly = true;
            dgvDetalle.RowHeadersWidth = 51;
            dgvDetalle.Size = new System.Drawing.Size(597, 125);
            dgvDetalle.TabIndex = 12;
            // 
            // colIdProducto
            // 
            colIdProducto.HeaderText = "Id";
            colIdProducto.MinimumWidth = 6;
            colIdProducto.Name = "colIdProducto";
            colIdProducto.ReadOnly = true;
            colIdProducto.Width = 109;
            // 
            // colNombreProducto
            // 
            colNombreProducto.HeaderText = "Producto";
            colNombreProducto.MinimumWidth = 6;
            colNombreProducto.Name = "colNombreProducto";
            colNombreProducto.ReadOnly = true;
            colNombreProducto.Width = 109;
            // 
            // colCantidad
            // 
            colCantidad.HeaderText = "Cantidad";
            colCantidad.MinimumWidth = 6;
            colCantidad.Name = "colCantidad";
            colCantidad.ReadOnly = true;
            colCantidad.Width = 108;
            // 
            // colPrecio
            // 
            colPrecio.HeaderText = "Precio Unitario";
            colPrecio.MinimumWidth = 6;
            colPrecio.Name = "colPrecio";
            colPrecio.ReadOnly = true;
            colPrecio.Width = 109;
            // 
            // colSubTotal
            // 
            colSubTotal.HeaderText = "Subtotal";
            colSubTotal.MinimumWidth = 6;
            colSubTotal.Name = "colSubTotal";
            colSubTotal.ReadOnly = true;
            colSubTotal.Width = 109;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblTotal.Location = new System.Drawing.Point(496, 308);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new System.Drawing.Size(115, 23);
            lblTotal.TabIndex = 13;
            lblTotal.Text = "Total: $ 0.00";
            // 
            // btnProveedores
            // 
            btnProveedores.Location = new System.Drawing.Point(454, 19);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new System.Drawing.Size(116, 47);
            btnProveedores.TabIndex = 14;
            btnProveedores.Text = "VER\r\nProveedores";
            btnProveedores.UseVisualStyleBackColor = true;
            btnProveedores.Click += btnProveedores_Click;
            // 
            // FormRegistrarCompra
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
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
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.DataGridView dgvDetalle;
        private DataGridViewTextBoxColumn colIdProducto;
        private DataGridViewTextBoxColumn colNombreProducto;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewTextBoxColumn colPrecio;
        private DataGridViewTextBoxColumn colSubTotal;
        private Label lblTotal;
        private Button btnProveedores;
    }
}