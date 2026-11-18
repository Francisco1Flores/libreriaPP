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
            groupBox1 = new System.Windows.Forms.GroupBox();
            dgbDetallesVenta = new System.Windows.Forms.DataGridView();
            gbInfoVenta = new System.Windows.Forms.GroupBox();
            gbCliente.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgbDetallesVenta).BeginInit();
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
            gbProducto.Location = new System.Drawing.Point(89, 196);
            gbProducto.Name = "gbProducto";
            gbProducto.Size = new System.Drawing.Size(953, 145);
            gbProducto.TabIndex = 1;
            gbProducto.TabStop = false;
            gbProducto.Text = "Selección de Productos";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgbDetallesVenta);
            groupBox1.Location = new System.Drawing.Point(89, 360);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(953, 363);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalle de Venta";
            // 
            // dgbDetallesVenta
            // 
            dgbDetallesVenta.ColumnHeadersHeight = 29;
            dgbDetallesVenta.Location = new System.Drawing.Point(37, 60);
            dgbDetallesVenta.Name = "dgbDetallesVenta";
            dgbDetallesVenta.RowHeadersWidth = 51;
            dgbDetallesVenta.Size = new System.Drawing.Size(563, 262);
            dgbDetallesVenta.TabIndex = 0;
            // 
            // gbInfoVenta
            // 
            gbInfoVenta.Location = new System.Drawing.Point(89, 37);
            gbInfoVenta.Name = "gbInfoVenta";
            gbInfoVenta.Size = new System.Drawing.Size(387, 153);
            gbInfoVenta.TabIndex = 3;
            gbInfoVenta.TabStop = false;
            gbInfoVenta.Text = "Información de Venta";
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
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgbDetallesVenta).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnLimpiarCliente;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDniCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtTelCliente;
        private System.Windows.Forms.Button btnBuscarCliente;

        private System.Windows.Forms.GroupBox gbInfoVenta;

        private System.Windows.Forms.DataGridView dgbDetallesVenta;

        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.GroupBox gbCliente;

        private System.Windows.Forms.GroupBox gbProducto;

        #endregion
    }
}