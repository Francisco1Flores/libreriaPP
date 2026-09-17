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
            button1 = new Button();
            panel1 = new Panel();
            btnClientes = new Button();
            btnCompras = new Button();
            btnStock = new Button();
            btnVentas = new Button();
            lblLogo = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(447, 167);
            button1.Name = "button1";
            button1.Size = new Size(179, 29);
            button1.TabIndex = 0;
            button1.Text = "probar conexion";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(btnClientes);
            panel1.Controls.Add(btnCompras);
            panel1.Controls.Add(btnStock);
            panel1.Controls.Add(btnVentas);
            panel1.Controls.Add(lblLogo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 450);
            panel1.TabIndex = 1;
            // 
            // btnClientes
            // 
            btnClientes.Cursor = Cursors.Hand;
            btnClientes.Dock = DockStyle.Top;
            btnClientes.Location = new Point(0, 209);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(250, 40);
            btnClientes.TabIndex = 3;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnCompras
            // 
            btnCompras.Cursor = Cursors.Hand;
            btnCompras.Dock = DockStyle.Top;
            btnCompras.Location = new Point(0, 169);
            btnCompras.Name = "btnCompras";
            btnCompras.Size = new Size(250, 40);
            btnCompras.TabIndex = 2;
            btnCompras.Text = "Compras";
            btnCompras.UseVisualStyleBackColor = true;
            btnCompras.Click += btnCompras_Click;
            // 
            // btnStock
            // 
            btnStock.Cursor = Cursors.Hand;
            btnStock.Dock = DockStyle.Top;
            btnStock.Location = new Point(0, 129);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(250, 40);
            btnStock.TabIndex = 1;
            btnStock.Text = "Stock";
            btnStock.UseVisualStyleBackColor = true;
            btnStock.Click += btnStock_Click;
            // 
            // btnVentas
            // 
            btnVentas.Cursor = Cursors.Hand;
            btnVentas.Dock = DockStyle.Top;
            btnVentas.Location = new Point(0, 89);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(250, 40);
            btnVentas.TabIndex = 0;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // lblLogo
            // 
            lblLogo.BackColor = Color.Gold;
            lblLogo.Dock = DockStyle.Top;
            lblLogo.Location = new Point(0, 0);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(250, 89);
            lblLogo.TabIndex = 4;
            lblLogo.Text = "Logo";
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(button1);
            Name = "FormPrincipal";
            Text = "FormPrincipal";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Panel panel1;
        private Button btnClientes;
        private Button btnCompras;
        private Button btnStock;
        private Button btnVentas;
        private Label lblLogo;
    }
}