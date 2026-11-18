namespace Presentacion
{
    partial class FormRegistrarCompra
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

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
            lblTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            SuspendLayout();
            // 
            // cmbProveedor
            // 
            cmbProveedor.BackColor = Color.FromArgb(37, 37, 38);
            cmbProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProveedor.FlatStyle = FlatStyle.Flat;
            cmbProveedor.ForeColor = Color.FromArgb(240, 240, 240);
            cmbProveedor.FormattingEnabled = true;
            cmbProveedor.Location = new Point(24, 57);
            cmbProveedor.Margin = new Padding(3, 4, 3, 4);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new Size(260, 28);
            cmbProveedor.TabIndex = 0;
            cmbProveedor.SelectedIndexChanged += cmbProveedor_SelectedIndexChanged;
            // 
            // cmbFormaPago
            // 
            cmbFormaPago.BackColor = Color.FromArgb(37, 37, 38);
            cmbFormaPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFormaPago.FlatStyle = FlatStyle.Flat;
            cmbFormaPago.ForeColor = Color.FromArgb(240, 240, 240);
            cmbFormaPago.FormattingEnabled = true;
            cmbFormaPago.Location = new Point(310, 57);
            cmbFormaPago.Margin = new Padding(3, 4, 3, 4);
            cmbFormaPago.Name = "cmbFormaPago";
            cmbFormaPago.Size = new Size(215, 28);
            cmbFormaPago.TabIndex = 1;
            // 
            // cmbProducto
            // 
            cmbProducto.BackColor = Color.FromArgb(37, 37, 38);
            cmbProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProducto.FlatStyle = FlatStyle.Flat;
            cmbProducto.ForeColor = Color.FromArgb(240, 240, 240);
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(24, 147);
            cmbProducto.Margin = new Padding(3, 4, 3, 4);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(260, 28);
            cmbProducto.TabIndex = 2;
            // 
            // txtCantidad
            // 
            txtCantidad.BackColor = Color.FromArgb(37, 37, 38);
            txtCantidad.BorderStyle = BorderStyle.FixedSingle;
            txtCantidad.ForeColor = Color.FromArgb(240, 240, 240);
            txtCantidad.Location = new Point(310, 147);
            txtCantidad.Margin = new Padding(3, 4, 3, 4);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(110, 27);
            txtCantidad.TabIndex = 3;
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = Color.FromArgb(37, 37, 38);
            txtPrecio.BorderStyle = BorderStyle.FixedSingle;
            txtPrecio.ForeColor = Color.FromArgb(240, 240, 240);
            txtPrecio.Location = new Point(440, 147);
            txtPrecio.Margin = new Padding(3, 4, 3, 4);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(125, 27);
            txtPrecio.TabIndex = 4;
            // 
            // btnRegistrarCompra
            // 
            btnRegistrarCompra.BackColor = Color.FromArgb(65, 80, 140);
            btnRegistrarCompra.Cursor = Cursors.Hand;
            btnRegistrarCompra.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 60);
            btnRegistrarCompra.FlatStyle = FlatStyle.Flat;
            btnRegistrarCompra.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnRegistrarCompra.ForeColor = Color.White;
            btnRegistrarCompra.Location = new Point(575, 455);
            btnRegistrarCompra.Margin = new Padding(3, 4, 3, 4);
            btnRegistrarCompra.Name = "btnRegistrarCompra";
            btnRegistrarCompra.Size = new Size(170, 36);
            btnRegistrarCompra.TabIndex = 5;
            btnRegistrarCompra.Text = "Registrar Compra";
            btnRegistrarCompra.UseVisualStyleBackColor = false;
            btnRegistrarCompra.Click += btnRegistrarCompra_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(55, 55, 60);
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 60);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.ForeColor = Color.FromArgb(240, 240, 240);
            btnAgregar.Location = new Point(595, 145);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(150, 31);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "+ Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(240, 240, 240);
            label1.Location = new Point(24, 33);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 7;
            label1.Text = "Proveedor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(240, 240, 240);
            label2.Location = new Point(310, 33);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 8;
            label2.Text = "Forma de Pago";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(240, 240, 240);
            label3.Location = new Point(24, 123);
            label3.Name = "label3";
            label3.Size = new Size(149, 20);
            label3.TabIndex = 9;
            label3.Text = "Seleccionar Producto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(240, 240, 240);
            label4.Location = new Point(310, 123);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 10;
            label4.Text = "Cantidad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(240, 240, 240);
            label5.Location = new Point(440, 123);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 11;
            label5.Text = "Precio";
            // 
            // dgvDetalle
            // 
            dgvDetalle.AllowUserToAddRows = false;
            dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalle.BackgroundColor = Color.FromArgb(45, 45, 48);
            dgvDetalle.BorderStyle = BorderStyle.None;
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.EnableHeadersVisualStyles = false;
            dgvDetalle.GridColor = Color.FromArgb(60, 60, 60);
            dgvDetalle.Location = new Point(24, 205);
            dgvDetalle.Margin = new Padding(3, 4, 3, 4);
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.ReadOnly = true;
            dgvDetalle.RowHeadersWidth = 35;
            dgvDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalle.Size = new Size(721, 190);
            dgvDetalle.TabIndex = 12;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTotal.ForeColor = Color.FromArgb(187, 134, 252);
            lblTotal.Location = new Point(585, 412);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(135, 30);
            lblTotal.TabIndex = 13;
            lblTotal.Text = "Total: $ 0.00";
            // 
            // FormRegistrarCompra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(775, 520);
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
            ForeColor = Color.FromArgb(240, 240, 240);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
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
        private Label lblTotal;
    }
}