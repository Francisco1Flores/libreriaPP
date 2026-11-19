namespace Presentacion
{
    partial class FormVentas
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
            components = new System.ComponentModel.Container();
            gbCliente = new System.Windows.Forms.GroupBox();
            btnLimpiarCliente = new System.Windows.Forms.Button();
            btnBuscarCliente = new System.Windows.Forms.Button();
            txtTelCliente = new System.Windows.Forms.TextBox();
            txtNombreCliente = new System.Windows.Forms.TextBox();
            txtDniCliente = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            gbProducto = new System.Windows.Forms.GroupBox();
            btnLimpiarProducto = new System.Windows.Forms.Button();
            btnAgregar = new System.Windows.Forms.Button();
            btnBuscarProducto = new System.Windows.Forms.Button();
            txtCantidad = new System.Windows.Forms.TextBox();
            txtStock = new System.Windows.Forms.TextBox();
            txtPrecio = new System.Windows.Forms.TextBox();
            txtNombreProducto = new System.Windows.Forms.TextBox();
            txtCodigoProducto = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            txtTotal = new System.Windows.Forms.TextBox();
            cmbFormasDePago = new System.Windows.Forms.ComboBox();
            button2 = new System.Windows.Forms.Button();
            label10 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            dgvCarrito = new System.Windows.Forms.DataGridView();
            gbInfoVenta = new System.Windows.Forms.GroupBox();
            lblNroVenta = new System.Windows.Forms.Label();
            lblHora = new System.Windows.Forms.Label();
            lblFecha = new System.Windows.Forms.Label();
            timer1 = new System.Windows.Forms.Timer(components);
            gbCliente.SuspendLayout();
            gbProducto.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            gbInfoVenta.SuspendLayout();
            SuspendLayout();
            // 
            // gbCliente
            // 
            gbCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            gbCliente.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            gbCliente.Controls.Add(btnLimpiarCliente);
            gbCliente.Controls.Add(btnBuscarCliente);
            gbCliente.Controls.Add(txtTelCliente);
            gbCliente.Controls.Add(txtNombreCliente);
            gbCliente.Controls.Add(txtDniCliente);
            gbCliente.Controls.Add(label3);
            gbCliente.Controls.Add(label2);
            gbCliente.Controls.Add(label1);
            gbCliente.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
            gbCliente.Location = new System.Drawing.Point(424, 24);
            gbCliente.Name = "gbCliente";
            gbCliente.Size = new System.Drawing.Size(640, 150);
            gbCliente.TabIndex = 0;
            gbCliente.TabStop = false;
            gbCliente.Text = "Seleccionar Cliente";
            // 
            // btnLimpiarCliente
            // 
            btnLimpiarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            btnLimpiarCliente.BackColor = System.Drawing.Color.FromArgb(55, 55, 60);
            btnLimpiarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            btnLimpiarCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 60, 60);
            btnLimpiarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLimpiarCliente.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
            btnLimpiarCliente.Location = new System.Drawing.Point(482, 103);
            btnLimpiarCliente.Name = "btnLimpiarCliente";
            btnLimpiarCliente.Size = new System.Drawing.Size(134, 30);
            btnLimpiarCliente.TabIndex = 7;
            btnLimpiarCliente.Text = "Limpiar";
            btnLimpiarCliente.UseVisualStyleBackColor = false;
            btnLimpiarCliente.Click += btnLimpiarCliente_Click;
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            btnBuscarCliente.BackColor = System.Drawing.Color.FromArgb(55, 55, 60);
            btnBuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            btnBuscarCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 60, 60);
            btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBuscarCliente.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
            btnBuscarCliente.Location = new System.Drawing.Point(338, 103);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new System.Drawing.Size(134, 30);
            btnBuscarCliente.TabIndex = 6;
            btnBuscarCliente.Text = "Buscar";
            btnBuscarCliente.UseVisualStyleBackColor = false;
            btnBuscarCliente.Click += btnBuscarCliente_Click;
            // 
            // txtTelCliente
            // 
            txtTelCliente.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            txtTelCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtTelCliente.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
            txtTelCliente.Location = new System.Drawing.Point(24, 105);
            txtTelCliente.Name = "txtTelCliente";
            txtTelCliente.Size = new System.Drawing.Size(190, 27);
            txtTelCliente.TabIndex = 5;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            txtNombreCliente.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            txtNombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtNombreCliente.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
            txtNombreCliente.Location = new System.Drawing.Point(234, 49);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new System.Drawing.Size(382, 27);
            txtNombreCliente.TabIndex = 4;
            // 
            // txtDniCliente
            // 
            txtDniCliente.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            txtDniCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtDniCliente.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
            txtDniCliente.Location = new System.Drawing.Point(24, 49);
            txtDniCliente.Name = "txtDniCliente";
            txtDniCliente.Size = new System.Drawing.Size(190, 27);
            txtDniCliente.TabIndex = 3;
            txtDniCliente.KeyPress += txtDniCliente_KeyPress;
            txtDniCliente.Leave += txtDniCliente_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
            label3.Location = new System.Drawing.Point(24, 82);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Teléfono:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
            label2.Location = new System.Drawing.Point(234, 26);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(67, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
            label1.Location = new System.Drawing.Point(24, 26);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(38, 20);
            label1.TabIndex = 0;
            label1.Text = "DNI:";
            // 
            // gbProducto
            // 
            gbProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            gbProducto.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            gbProducto.Controls.Add(btnLimpiarProducto);
            gbProducto.Controls.Add(btnAgregar);
            gbProducto.Controls.Add(btnBuscarProducto);
            gbProducto.Controls.Add(txtCantidad);
            gbProducto.Controls.Add(txtStock);
            gbProducto.Controls.Add(txtPrecio);
            gbProducto.Controls.Add(txtNombreProducto);
            gbProducto.Controls.Add(txtCodigoProducto);
            gbProducto.Controls.Add(label8);
            gbProducto.Controls.Add(label7);
            gbProducto.Controls.Add(label6);
            gbProducto.Controls.Add(label5);
            gbProducto.Controls.Add(label4);
            gbProducto.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
            gbProducto.Location = new System.Drawing.Point(36, 186);
            gbProducto.Name = "gbProducto";
            gbProducto.Size = new System.Drawing.Size(1028, 136);
            gbProducto.TabIndex = 1;
            gbProducto.TabStop = false;
            gbProducto.Text = "Selección de Productos";
            // 
            // btnLimpiarProducto
            // 
            btnLimpiarProducto.BackColor = System.Drawing.Color.FromArgb(55, 55, 60);
            btnLimpiarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            btnLimpiarProducto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 60, 60);
            btnLimpiarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLimpiarProducto.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
            btnLimpiarProducto.Location = new System.Drawing.Point(129, 90);
            btnLimpiarProducto.Name = "btnLimpiarProducto";
            btnLimpiarProducto.Size = new System.Drawing.Size(80, 31);
            btnLimpiarProducto.TabIndex = 12;
            btnLimpiarProducto.Text = "Quitar";
            btnLimpiarProducto.UseVisualStyleBackColor = false;
            btnLimpiarProducto.Click += btnLimpiarProducto_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            btnAgregar.BackColor = System.Drawing.Color.FromArgb(55, 55, 60);
            btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 60, 60);
            btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAgregar.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
            btnAgregar.Location = new System.Drawing.Point(904, 51);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new System.Drawing.Size(100, 31);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.BackColor = System.Drawing.Color.FromArgb(55, 55, 60);
            btnBuscarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            btnBuscarProducto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 60, 60);
            btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBuscarProducto.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
            btnBuscarProducto.Location = new System.Drawing.Point(24, 90);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new System.Drawing.Size(95, 31);
            btnBuscarProducto.TabIndex = 10;
            btnBuscarProducto.Text = "Buscar";
            btnBuscarProducto.UseVisualStyleBackColor = false;
            btnBuscarProducto.Click += btnBuscarProducto_Click;
            // 
            // txtCantidad
            // 
            txtCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            txtCantidad.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtCantidad.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
            txtCantidad.Location = new System.Drawing.Point(795, 53);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new System.Drawing.Size(95, 27);
            txtCantidad.TabIndex = 9;
            // 
            // txtStock
            // 
            txtStock.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            txtStock.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            txtStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtStock.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
            txtStock.Location = new System.Drawing.Point(684, 53);
            txtStock.Name = "txtStock";
            txtStock.Size = new System.Drawing.Size(95, 27);
            txtStock.TabIndex = 8;
            // 
            // txtPrecio
            // 
            txtPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            txtPrecio.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtPrecio.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
            txtPrecio.Location = new System.Drawing.Point(563, 53);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new System.Drawing.Size(105, 27);
            txtPrecio.TabIndex = 7;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            txtNombreProducto.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            txtNombreProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtNombreProducto.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
            txtNombreProducto.Location = new System.Drawing.Point(225, 53);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new System.Drawing.Size(320, 27);
            txtNombreProducto.TabIndex = 6;
            // 
            // txtCodigoProducto
            // 
            txtCodigoProducto.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            txtCodigoProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtCodigoProducto.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
            txtCodigoProducto.Location = new System.Drawing.Point(24, 53);
            txtCodigoProducto.Name = "txtCodigoProducto";
            txtCodigoProducto.Size = new System.Drawing.Size(185, 27);
            txtCodigoProducto.TabIndex = 5;
            txtCodigoProducto.KeyPress += txtCodigoProducto_KeyPress;
            // 
            // label8
            // 
            label8.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            label8.AutoSize = true;
            label8.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
            label8.Location = new System.Drawing.Point(795, 30);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(69, 20);
            label8.TabIndex = 4;
            label8.Text = "Cantidad";
            // 
            // label7
            // 
            label7.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            label7.AutoSize = true;
            label7.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
            label7.Location = new System.Drawing.Point(684, 30);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(45, 20);
            label7.TabIndex = 3;
            label7.Text = "Stock";
            // 
            // label6
            // 
            label6.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            label6.AutoSize = true;
            label6.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
            label6.Location = new System.Drawing.Point(563, 30);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(50, 20);
            label6.TabIndex = 2;
            label6.Text = "Precio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
            label5.Location = new System.Drawing.Point(225, 30);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(64, 20);
            label5.TabIndex = 1;
            label5.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
            label4.Location = new System.Drawing.Point(24, 30);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(58, 20);
            label4.TabIndex = 0;
            label4.Text = "Código";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            groupBox1.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            groupBox1.Controls.Add(txtTotal);
            groupBox1.Controls.Add(cmbFormasDePago);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(dgvCarrito);
            groupBox1.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
            groupBox1.Location = new System.Drawing.Point(36, 334);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(1028, 362);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalle de Venta";
            // 
            // txtTotal
            // 
            txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            txtTotal.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtTotal.Enabled = false;
            txtTotal.ForeColor = System.Drawing.Color.FromArgb(187, 134, 252);
            txtTotal.Location = new System.Drawing.Point(804, 57);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new System.Drawing.Size(200, 27);
            txtTotal.TabIndex = 6;
            // 
            // cmbFormasDePago
            // 
            cmbFormasDePago.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            cmbFormasDePago.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            cmbFormasDePago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cmbFormasDePago.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
            cmbFormasDePago.FormattingEnabled = true;
            cmbFormasDePago.Location = new System.Drawing.Point(804, 105);
            cmbFormasDePago.Name = "cmbFormasDePago";
            cmbFormasDePago.Size = new System.Drawing.Size(200, 28);
            cmbFormasDePago.TabIndex = 5;
            // 
            // button2
            // 
            button2.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
            button2.BackColor = System.Drawing.Color.FromArgb(187, 134, 252);
            button2.Cursor = System.Windows.Forms.Cursors.Hand;
            button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(187, 134, 252);
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            button2.ForeColor = System.Drawing.Color.FromArgb(20, 20, 20);
            button2.Location = new System.Drawing.Point(757, 294);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(200, 44);
            button2.TabIndex = 3;
            button2.Text = "Registrar venta";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnRegistrarVenta_Click;
            // 
            // label10
            // 
            label10.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            label10.AutoSize = true;
            label10.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
            label10.Location = new System.Drawing.Point(688, 108);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(112, 20);
            label10.TabIndex = 2;
            label10.Text = "Forma de Pago:";
            // 
            // label9
            // 
            label9.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            label9.AutoSize = true;
            label9.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
            label9.Location = new System.Drawing.Point(688, 60);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(45, 20);
            label9.TabIndex = 1;
            label9.Text = "Total:";
            // 
            // dgvCarrito
            // 
            dgvCarrito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            dgvCarrito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvCarrito.BackgroundColor = System.Drawing.Color.FromArgb(45, 45, 48);
            dgvCarrito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvCarrito.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(35, 35, 38);
            dgvCarrito.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgvCarrito.ColumnHeadersHeight = 29;
            dgvCarrito.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            dgvCarrito.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
            dgvCarrito.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(90, 70, 130);
            dgvCarrito.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            dgvCarrito.EnableHeadersVisualStyles = false;
            dgvCarrito.GridColor = System.Drawing.Color.FromArgb(60, 60, 60);
            dgvCarrito.Location = new System.Drawing.Point(24, 34);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dgvCarrito.RowHeadersWidth = 51;
            dgvCarrito.Size = new System.Drawing.Size(640, 304);
            dgvCarrito.TabIndex = 0;
            dgvCarrito.CellContentClick += dgvCarrito_CellContentClick;
            // 
            // gbInfoVenta
            // 
            gbInfoVenta.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            gbInfoVenta.Controls.Add(lblNroVenta);
            gbInfoVenta.Controls.Add(lblHora);
            gbInfoVenta.Controls.Add(lblFecha);
            gbInfoVenta.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
            gbInfoVenta.Location = new System.Drawing.Point(36, 24);
            gbInfoVenta.Name = "gbInfoVenta";
            gbInfoVenta.Size = new System.Drawing.Size(370, 150);
            gbInfoVenta.TabIndex = 3;
            gbInfoVenta.TabStop = false;
            gbInfoVenta.Text = "Información de Venta";
            // 
            // lblNroVenta
            // 
            lblNroVenta.AutoSize = true;
            lblNroVenta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblNroVenta.ForeColor = System.Drawing.Color.FromArgb(187, 134, 252);
            lblNroVenta.Location = new System.Drawing.Point(24, 32);
            lblNroVenta.Name = "lblNroVenta";
            lblNroVenta.Size = new System.Drawing.Size(115, 28);
            lblNroVenta.TabIndex = 2;
            lblNroVenta.Text = "Venta nro: ";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblHora.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
            lblHora.Location = new System.Drawing.Point(24, 104);
            lblHora.Name = "lblHora";
            lblHora.Size = new System.Drawing.Size(58, 28);
            lblHora.TabIndex = 1;
            lblHora.Text = "Hora";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblFecha.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
            lblFecha.Location = new System.Drawing.Point(24, 68);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new System.Drawing.Size(66, 28);
            lblFecha.TabIndex = 0;
            lblFecha.Text = "Fecha";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // FormVentas
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            ClientSize = new System.Drawing.Size(1100, 720);
            Controls.Add(gbInfoVenta);
            Controls.Add(groupBox1);
            Controls.Add(gbProducto);
            Controls.Add(gbCliente);
            ForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            MinimumSize = new System.Drawing.Size(960, 650);
            Text = "Ventas";
            gbCliente.ResumeLayout(false);
            gbCliente.PerformLayout();
            gbProducto.ResumeLayout(false);
            gbProducto.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            gbInfoVenta.ResumeLayout(false);
            gbInfoVenta.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnLimpiarProducto;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.ComboBox cmbFormasDePago;
        private System.Windows.Forms.Label lblNroVenta;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnLimpiarCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDniCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtTelCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.GroupBox gbInfoVenta;
        private System.Windows.Forms.DataGridView dgvCarrito;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.GroupBox gbProducto;

        #endregion
    }
}