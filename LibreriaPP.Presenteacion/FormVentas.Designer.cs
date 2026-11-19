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
            button3 = new System.Windows.Forms.Button();
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
            gbCliente.Controls.Add(btnLimpiarCliente);
            gbCliente.Controls.Add(btnBuscarCliente);
            gbCliente.Controls.Add(txtTelCliente);
            gbCliente.Controls.Add(txtNombreCliente);
            gbCliente.Controls.Add(txtDniCliente);
            gbCliente.Controls.Add(label3);
            gbCliente.Controls.Add(label2);
            gbCliente.Controls.Add(label1);
            gbCliente.Location = new System.Drawing.Point(488, 37);
            gbCliente.Name = "gbCliente";
            gbCliente.Size = new System.Drawing.Size(554, 153);
            gbCliente.TabIndex = 0;
            gbCliente.TabStop = false;
            gbCliente.Text = "Seleccionar Cliente";
            // 
            // btnLimpiarCliente
            // 
            btnLimpiarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            btnLimpiarCliente.Location = new System.Drawing.Point(375, 105);
            btnLimpiarCliente.Name = "btnLimpiarCliente";
            btnLimpiarCliente.Size = new System.Drawing.Size(134, 29);
            btnLimpiarCliente.TabIndex = 7;
            btnLimpiarCliente.Text = "Limpiar";
            btnLimpiarCliente.UseVisualStyleBackColor = true;
            btnLimpiarCliente.Click += btnLimpiarCliente_Click;
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            btnBuscarCliente.Location = new System.Drawing.Point(235, 105);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new System.Drawing.Size(134, 29);
            btnBuscarCliente.TabIndex = 6;
            btnBuscarCliente.Text = "Buscar";
            btnBuscarCliente.UseVisualStyleBackColor = true;
            btnBuscarCliente.Click += btnBuscarCliente_Click;
            // 
            // txtTelCliente
            // 
            txtTelCliente.Location = new System.Drawing.Point(30, 105);
            txtTelCliente.Name = "txtTelCliente";
            txtTelCliente.Size = new System.Drawing.Size(199, 27);
            txtTelCliente.TabIndex = 5;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new System.Drawing.Point(235, 43);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new System.Drawing.Size(274, 27);
            txtNombreCliente.TabIndex = 4;
            // 
            // txtDniCliente
            // 
            txtDniCliente.Location = new System.Drawing.Point(30, 43);
            txtDniCliente.Name = "txtDniCliente";
            txtDniCliente.Size = new System.Drawing.Size(199, 27);
            txtDniCliente.TabIndex = 3;
            txtDniCliente.KeyPress += txtDniCliente_KeyPress;
            txtDniCliente.Leave += txtDniCliente_Leave;
            // 
            // label3
            // 
            label3.Location = new System.Drawing.Point(30, 77);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(68, 23);
            label3.TabIndex = 2;
            label3.Text = "Teléfono:";
            // 
            // label2
            // 
            label2.Location = new System.Drawing.Point(235, 21);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(68, 25);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.Location = new System.Drawing.Point(30, 23);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(41, 23);
            label1.TabIndex = 0;
            label1.Text = "DNI:";
            // 
            // gbProducto
            // 
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
            gbProducto.Location = new System.Drawing.Point(89, 196);
            gbProducto.Name = "gbProducto";
            gbProducto.Size = new System.Drawing.Size(953, 145);
            gbProducto.TabIndex = 1;
            gbProducto.TabStop = false;
            gbProducto.Text = "Selección de Productos";
            // 
            // btnAgregar
            // 
            btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAgregar.Location = new System.Drawing.Point(844, 63);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new System.Drawing.Size(75, 27);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            btnBuscarProducto.Location = new System.Drawing.Point(26, 96);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new System.Drawing.Size(75, 31);
            btnBuscarProducto.TabIndex = 10;
            btnBuscarProducto.Text = "Buscar";
            btnBuscarProducto.UseVisualStyleBackColor = true;
            btnBuscarProducto.Click += btnBuscarProducto_Click;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new System.Drawing.Point(738, 63);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new System.Drawing.Size(100, 27);
            txtCantidad.TabIndex = 9;
            // 
            // txtStock
            // 
            txtStock.Location = new System.Drawing.Point(613, 63);
            txtStock.Name = "txtStock";
            txtStock.Size = new System.Drawing.Size(100, 27);
            txtStock.TabIndex = 8;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new System.Drawing.Point(489, 63);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new System.Drawing.Size(100, 27);
            txtPrecio.TabIndex = 7;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new System.Drawing.Point(224, 63);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new System.Drawing.Size(246, 27);
            txtNombreProducto.TabIndex = 6;
            // 
            // txtCodigoProducto
            // 
            txtCodigoProducto.Location = new System.Drawing.Point(26, 63);
            txtCodigoProducto.Name = "txtCodigoProducto";
            txtCodigoProducto.Size = new System.Drawing.Size(188, 27);
            txtCodigoProducto.TabIndex = 5;
            txtCodigoProducto.KeyPress += txtCodigoProducto_KeyPress;
            // 
            // label8
            // 
            label8.Location = new System.Drawing.Point(738, 37);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(100, 23);
            label8.TabIndex = 4;
            label8.Text = "Cantidad";
            // 
            // label7
            // 
            label7.Location = new System.Drawing.Point(613, 37);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(100, 23);
            label7.TabIndex = 3;
            label7.Text = "Stock";
            // 
            // label6
            // 
            label6.Location = new System.Drawing.Point(489, 37);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(100, 23);
            label6.TabIndex = 2;
            label6.Text = "Precio";
            // 
            // label5
            // 
            label5.Location = new System.Drawing.Point(224, 37);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(100, 23);
            label5.TabIndex = 1;
            label5.Text = "Nombre";
            // 
            // label4
            // 
            label4.Location = new System.Drawing.Point(26, 37);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(100, 23);
            label4.TabIndex = 0;
            label4.Text = "Códido";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTotal);
            groupBox1.Controls.Add(cmbFormasDePago);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(dgvCarrito);
            groupBox1.Location = new System.Drawing.Point(89, 360);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(953, 363);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalle de Venta";
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Location = new System.Drawing.Point(733, 106);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new System.Drawing.Size(199, 27);
            txtTotal.TabIndex = 6;
            // 
            // cmbFormasDePago
            // 
            cmbFormasDePago.FormattingEnabled = true;
            cmbFormasDePago.Location = new System.Drawing.Point(733, 156);
            cmbFormasDePago.Name = "cmbFormasDePago";
            cmbFormasDePago.Size = new System.Drawing.Size(199, 28);
            cmbFormasDePago.TabIndex = 5;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(774, 263);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(134, 36);
            button3.TabIndex = 4;
            button3.Text = "Imprimir Factura";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(634, 263);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(134, 36);
            button2.TabIndex = 3;
            button2.Text = "Registrar venta";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnRegistrarVenta_Click;
            // 
            // label10
            // 
            label10.Location = new System.Drawing.Point(613, 161);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(114, 23);
            label10.TabIndex = 2;
            label10.Text = "Forma de Pago:";
            // 
            // label9
            // 
            label9.Location = new System.Drawing.Point(680, 109);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(47, 23);
            label9.TabIndex = 1;
            label9.Text = "Total:";
            // 
            // dgvCarrito
            // 
            dgvCarrito.ColumnHeadersHeight = 29;
            dgvCarrito.Location = new System.Drawing.Point(37, 60);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dgvCarrito.RowHeadersWidth = 51;
            dgvCarrito.Size = new System.Drawing.Size(563, 262);
            dgvCarrito.TabIndex = 0;
            dgvCarrito.CellContentClick += dgvCarrito_CellContentClick;
            // 
            // gbInfoVenta
            // 
            gbInfoVenta.Controls.Add(lblNroVenta);
            gbInfoVenta.Controls.Add(lblHora);
            gbInfoVenta.Controls.Add(lblFecha);
            gbInfoVenta.Location = new System.Drawing.Point(89, 37);
            gbInfoVenta.Name = "gbInfoVenta";
            gbInfoVenta.Size = new System.Drawing.Size(387, 153);
            gbInfoVenta.TabIndex = 3;
            gbInfoVenta.TabStop = false;
            gbInfoVenta.Text = "Información de Venta";
            // 
            // lblNroVenta
            // 
            lblNroVenta.Location = new System.Drawing.Point(32, 30);
            lblNroVenta.Name = "lblNroVenta";
            lblNroVenta.Size = new System.Drawing.Size(349, 23);
            lblNroVenta.TabIndex = 2;
            lblNroVenta.Text = "Venta nro: ";
            // 
            // lblHora
            // 
            lblHora.Location = new System.Drawing.Point(37, 105);
            lblHora.Name = "lblHora";
            lblHora.Size = new System.Drawing.Size(258, 23);
            lblHora.TabIndex = 1;
            lblHora.Text = "label4";
            // 
            // lblFecha
            // 
            lblFecha.Location = new System.Drawing.Point(37, 63);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new System.Drawing.Size(287, 23);
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
            BackColor = System.Drawing.SystemColors.ActiveBorder;
            ClientSize = new System.Drawing.Size(1294, 838);
            Controls.Add(gbInfoVenta);
            Controls.Add(groupBox1);
            Controls.Add(gbProducto);
            Controls.Add(gbCliente);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Text = "Ventas";
            gbCliente.ResumeLayout(false);
            gbCliente.PerformLayout();
            gbProducto.ResumeLayout(false);
            gbProducto.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            gbInfoVenta.ResumeLayout(false);
            ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox txtTotal;

        private System.Windows.Forms.ComboBox cmbFormasDePago;

        private System.Windows.Forms.Label lblNroVenta;

        private System.Windows.Forms.Button button3;

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