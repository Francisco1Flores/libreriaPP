namespace Presentacion
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            panel1 = new System.Windows.Forms.Panel();
            btnProveedores = new System.Windows.Forms.Button();
            btnClientes = new System.Windows.Forms.Button();
            btnCompras = new System.Windows.Forms.Button();
            btnStock = new System.Windows.Forms.Button();
            btnVentas = new System.Windows.Forms.Button();
            lblLogo = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            panelContenedor = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelContenedor.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)24)), ((int)((byte)24)), ((int)((byte)27)));
            panel1.Controls.Add(btnProveedores);
            panel1.Controls.Add(btnClientes);
            panel1.Controls.Add(btnCompras);
            panel1.Controls.Add(btnStock);
            panel1.Controls.Add(btnVentas);
            panel1.Controls.Add(lblLogo);
            panel1.Dock = System.Windows.Forms.DockStyle.Left;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(230, 522);
            panel1.TabIndex = 1;
            // 
            // btnProveedores
            // 
            btnProveedores.BackColor = System.Drawing.Color.FromArgb(((int)((byte)24)), ((int)((byte)24)), ((int)((byte)27)));
            btnProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            btnProveedores.Dock = System.Windows.Forms.DockStyle.Top;
            btnProveedores.FlatAppearance.BorderSize = 0;
            btnProveedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)80)), ((int)((byte)60)), ((int)((byte)120)));
            btnProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)45)), ((int)((byte)45)), ((int)((byte)52)));
            btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnProveedores.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            btnProveedores.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)235)), ((int)((byte)235)), ((int)((byte)240)));
            btnProveedores.Location = new System.Drawing.Point(0, 325);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            btnProveedores.Size = new System.Drawing.Size(230, 56);
            btnProveedores.TabIndex = 5;
            btnProveedores.Text = "Proveedores";
            btnProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnProveedores.UseVisualStyleBackColor = false;
            btnProveedores.Click += btnProveedores_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)((byte)24)), ((int)((byte)24)), ((int)((byte)27)));
            btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)80)), ((int)((byte)60)), ((int)((byte)120)));
            btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)45)), ((int)((byte)45)), ((int)((byte)52)));
            btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClientes.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            btnClientes.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)235)), ((int)((byte)235)), ((int)((byte)240)));
            btnClientes.Location = new System.Drawing.Point(0, 269);
            btnClientes.Name = "btnClientes";
            btnClientes.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            btnClientes.Size = new System.Drawing.Size(230, 56);
            btnClientes.TabIndex = 3;
            btnClientes.Text = "Clientes";
            btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnCompras
            // 
            btnCompras.BackColor = System.Drawing.Color.FromArgb(((int)((byte)24)), ((int)((byte)24)), ((int)((byte)27)));
            btnCompras.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCompras.Dock = System.Windows.Forms.DockStyle.Top;
            btnCompras.FlatAppearance.BorderSize = 0;
            btnCompras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)80)), ((int)((byte)60)), ((int)((byte)120)));
            btnCompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)45)), ((int)((byte)45)), ((int)((byte)52)));
            btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCompras.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            btnCompras.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)235)), ((int)((byte)235)), ((int)((byte)240)));
            btnCompras.Location = new System.Drawing.Point(0, 213);
            btnCompras.Name = "btnCompras";
            btnCompras.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            btnCompras.Size = new System.Drawing.Size(230, 56);
            btnCompras.TabIndex = 2;
            btnCompras.Text = "Compras";
            btnCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnCompras.UseVisualStyleBackColor = false;
            btnCompras.Click += btnCompras_Click;
            // 
            // btnStock
            // 
            btnStock.BackColor = System.Drawing.Color.FromArgb(((int)((byte)24)), ((int)((byte)24)), ((int)((byte)27)));
            btnStock.Cursor = System.Windows.Forms.Cursors.Hand;
            btnStock.Dock = System.Windows.Forms.DockStyle.Top;
            btnStock.FlatAppearance.BorderSize = 0;
            btnStock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)80)), ((int)((byte)60)), ((int)((byte)120)));
            btnStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)45)), ((int)((byte)45)), ((int)((byte)52)));
            btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnStock.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            btnStock.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)235)), ((int)((byte)235)), ((int)((byte)240)));
            btnStock.Location = new System.Drawing.Point(0, 157);
            btnStock.Name = "btnStock";
            btnStock.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            btnStock.Size = new System.Drawing.Size(230, 56);
            btnStock.TabIndex = 1;
            btnStock.Text = "Stock";
            btnStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnStock.UseVisualStyleBackColor = false;
            btnStock.Click += btnStock_Click;
            // 
            // btnVentas
            // 
            btnVentas.BackColor = System.Drawing.Color.FromArgb(((int)((byte)24)), ((int)((byte)24)), ((int)((byte)27)));
            btnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            btnVentas.Dock = System.Windows.Forms.DockStyle.Top;
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)80)), ((int)((byte)60)), ((int)((byte)120)));
            btnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)45)), ((int)((byte)45)), ((int)((byte)52)));
            btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnVentas.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            btnVentas.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)235)), ((int)((byte)235)), ((int)((byte)240)));
            btnVentas.Location = new System.Drawing.Point(0, 101);
            btnVentas.Name = "btnVentas";
            btnVentas.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            btnVentas.Size = new System.Drawing.Size(230, 56);
            btnVentas.TabIndex = 0;
            btnVentas.Text = "Ventas";
            btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnVentas.UseVisualStyleBackColor = false;
            btnVentas.Click += btnVentas_Click;
            // 
            // lblLogo
            // 
            lblLogo.BackColor = System.Drawing.Color.FromArgb(((int)((byte)24)), ((int)((byte)24)), ((int)((byte)27)));
            lblLogo.Dock = System.Windows.Forms.DockStyle.Top;
            lblLogo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            lblLogo.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)187)), ((int)((byte)134)), ((int)((byte)252)));
            lblLogo.Location = new System.Drawing.Point(0, 0);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new System.Drawing.Size(230, 101);
            lblLogo.TabIndex = 4;
            lblLogo.Text = "LIBRERÍA";
            lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.Image = ((System.Drawing.Image)resources.GetObject("pictureBox1.Image"));
            pictureBox1.Location = new System.Drawing.Point(116, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(345, 253);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)30)), ((int)((byte)30)));
            panelContenedor.Controls.Add(pictureBox1);
            panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            panelContenedor.Location = new System.Drawing.Point(230, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new System.Drawing.Size(844, 522);
            panelContenedor.TabIndex = 2;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)30)), ((int)((byte)30)));
            ClientSize = new System.Drawing.Size(1074, 522);
            Controls.Add(panelContenedor);
            Controls.Add(panel1);
            Text = "Sistema de Gestión - Librería";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelContenedor.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Button btnClientes;
        private Button btnCompras;
        private Button btnStock;
        private Button btnVentas;
        private Panel panelContenedor;
        private PictureBox pictureBox1;
        private Label lblLogo;
        private Button btnProveedores;
    }
}