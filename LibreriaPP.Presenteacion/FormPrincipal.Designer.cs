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
            button1 = new Button();
            panel1 = new Panel();
            btnProveedores = new Button();
            btnClientes = new Button();
            btnCompras = new Button();
            btnStock = new Button();
            btnVentas = new Button();
            lblLogo = new Label();
            pictureBox1 = new PictureBox();
            panelContenedor = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelContenedor.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.BackColor = Color.FromArgb(45, 45, 52);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.FromArgb(75, 75, 85);
            button1.FlatAppearance.BorderSize = 1;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(65, 65, 75);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            button1.ForeColor = Color.FromArgb(187, 134, 252);
            button1.Location = new Point(18, 465);
            button1.Name = "button1";
            button1.Size = new Size(194, 36);
            button1.TabIndex = 0;
            button1.Text = "Probar conexión";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 24, 27);
            panel1.Controls.Add(btnProveedores);
            panel1.Controls.Add(btnClientes);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnCompras);
            panel1.Controls.Add(btnStock);
            panel1.Controls.Add(btnVentas);
            panel1.Controls.Add(lblLogo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 522);
            panel1.TabIndex = 1;
            // 
            // btnProveedores
            // 
            btnProveedores.BackColor = Color.FromArgb(24, 24, 27);
            btnProveedores.Cursor = Cursors.Hand;
            btnProveedores.Dock = DockStyle.Top;
            btnProveedores.FlatAppearance.BorderSize = 0;
            btnProveedores.FlatAppearance.MouseDownBackColor = Color.FromArgb(80, 60, 120);
            btnProveedores.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 52);
            btnProveedores.FlatStyle = FlatStyle.Flat;
            btnProveedores.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular);
            btnProveedores.ForeColor = Color.FromArgb(235, 235, 240);
            btnProveedores.Location = new Point(0, 325);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Padding = new Padding(24, 0, 0, 0);
            btnProveedores.Size = new Size(230, 56);
            btnProveedores.TabIndex = 5;
            btnProveedores.Text = "Proveedores";
            btnProveedores.TextAlign = ContentAlignment.MiddleLeft;
            btnProveedores.UseVisualStyleBackColor = false;
            btnProveedores.Click += btnProveedores_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.FromArgb(24, 24, 27);
            btnClientes.Cursor = Cursors.Hand;
            btnClientes.Dock = DockStyle.Top;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatAppearance.MouseDownBackColor = Color.FromArgb(80, 60, 120);
            btnClientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 52);
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular);
            btnClientes.ForeColor = Color.FromArgb(235, 235, 240);
            btnClientes.Location = new Point(0, 269);
            btnClientes.Name = "btnClientes";
            btnClientes.Padding = new Padding(24, 0, 0, 0);
            btnClientes.Size = new Size(230, 56);
            btnClientes.TabIndex = 3;
            btnClientes.Text = "Clientes";
            btnClientes.TextAlign = ContentAlignment.MiddleLeft;
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnCompras
            // 
            btnCompras.BackColor = Color.FromArgb(24, 24, 27);
            btnCompras.Cursor = Cursors.Hand;
            btnCompras.Dock = DockStyle.Top;
            btnCompras.FlatAppearance.BorderSize = 0;
            btnCompras.FlatAppearance.MouseDownBackColor = Color.FromArgb(80, 60, 120);
            btnCompras.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 52);
            btnCompras.FlatStyle = FlatStyle.Flat;
            btnCompras.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular);
            btnCompras.ForeColor = Color.FromArgb(235, 235, 240);
            btnCompras.Location = new Point(0, 213);
            btnCompras.Name = "btnCompras";
            btnCompras.Padding = new Padding(24, 0, 0, 0);
            btnCompras.Size = new Size(230, 56);
            btnCompras.TabIndex = 2;
            btnCompras.Text = "Compras";
            btnCompras.TextAlign = ContentAlignment.MiddleLeft;
            btnCompras.UseVisualStyleBackColor = false;
            btnCompras.Click += btnCompras_Click;
            // 
            // btnStock
            // 
            btnStock.BackColor = Color.FromArgb(24, 24, 27);
            btnStock.Cursor = Cursors.Hand;
            btnStock.Dock = DockStyle.Top;
            btnStock.FlatAppearance.BorderSize = 0;
            btnStock.FlatAppearance.MouseDownBackColor = Color.FromArgb(80, 60, 120);
            btnStock.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 52);
            btnStock.FlatStyle = FlatStyle.Flat;
            btnStock.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular);
            btnStock.ForeColor = Color.FromArgb(235, 235, 240);
            btnStock.Location = new Point(0, 157);
            btnStock.Name = "btnStock";
            btnStock.Padding = new Padding(24, 0, 0, 0);
            btnStock.Size = new Size(230, 56);
            btnStock.TabIndex = 1;
            btnStock.Text = "Stock";
            btnStock.TextAlign = ContentAlignment.MiddleLeft;
            btnStock.UseVisualStyleBackColor = false;
            btnStock.Click += btnStock_Click;
            // 
            // btnVentas
            // 
            btnVentas.BackColor = Color.FromArgb(24, 24, 27);
            btnVentas.Cursor = Cursors.Hand;
            btnVentas.Dock = DockStyle.Top;
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatAppearance.MouseDownBackColor = Color.FromArgb(80, 60, 120);
            btnVentas.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 52);
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular);
            btnVentas.ForeColor = Color.FromArgb(235, 235, 240);
            btnVentas.Location = new Point(0, 101);
            btnVentas.Name = "btnVentas";
            btnVentas.Padding = new Padding(24, 0, 0, 0);
            btnVentas.Size = new Size(230, 56);
            btnVentas.TabIndex = 0;
            btnVentas.Text = "Ventas";
            btnVentas.TextAlign = ContentAlignment.MiddleLeft;
            btnVentas.UseVisualStyleBackColor = false;
            btnVentas.Click += btnVentas_Click;
            // 
            // lblLogo
            // 
            lblLogo.BackColor = Color.FromArgb(24, 24, 27);
            lblLogo.Dock = DockStyle.Top;
            lblLogo.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblLogo.ForeColor = Color.FromArgb(187, 134, 252);
            lblLogo.Location = new Point(0, 0);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(230, 101);
            lblLogo.TabIndex = 4;
            lblLogo.Text = "LIBRERÍA";
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(116, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(345, 253);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FromArgb(30, 30, 30);
            panelContenedor.Controls.Add(pictureBox1);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(230, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(844, 522);
            panelContenedor.TabIndex = 2;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1074, 522);
            Controls.Add(panelContenedor);
            Controls.Add(panel1);
            Name = "FormPrincipal";
            Text = "Sistema de Gestión - Librería";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelContenedor.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Panel panel1;
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