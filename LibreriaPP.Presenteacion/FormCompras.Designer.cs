namespace Presentacion
{
    partial class FormCompras
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
            label1 = new Label();
            dgvProveedores = new DataGridView();
            btnGuardar = new Button();
            txtRazonSocial = new TextBox();
            txtCuit = new TextBox();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            lblRazonSocial = new Label();
            lblCuit = new Label();
            lblTelefono = new Label();
            lblEmail = new Label();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 12);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(181, 20);
            label1.TabIndex = 0;
            label1.Text = "\"MÓDULO DE COMPRAS\".";
            // 
            // dgvProveedores
            // 
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedores.Location = new Point(14, 128);
            dgvProveedores.Margin = new Padding(3, 4, 3, 4);
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.RowHeadersWidth = 51;
            dgvProveedores.Size = new Size(818, 305);
            dgvProveedores.TabIndex = 1;
            dgvProveedores.CellClick += dgvProveedores_CellCellClick;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(101, 459);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(122, 31);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtRazonSocial
            // 
            txtRazonSocial.Location = new Point(14, 89);
            txtRazonSocial.Margin = new Padding(3, 4, 3, 4);
            txtRazonSocial.Name = "txtRazonSocial";
            txtRazonSocial.Size = new Size(119, 27);
            txtRazonSocial.TabIndex = 3;
            // 
            // txtCuit
            // 
            txtCuit.Location = new Point(141, 89);
            txtCuit.Margin = new Padding(3, 4, 3, 4);
            txtCuit.Name = "txtCuit";
            txtCuit.Size = new Size(119, 27);
            txtCuit.TabIndex = 4;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(267, 89);
            txtTelefono.Margin = new Padding(3, 4, 3, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(119, 27);
            txtTelefono.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(394, 89);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(119, 27);
            txtEmail.TabIndex = 6;
            // 
            // lblRazonSocial
            // 
            lblRazonSocial.AutoSize = true;
            lblRazonSocial.Location = new Point(14, 65);
            lblRazonSocial.Name = "lblRazonSocial";
            lblRazonSocial.Size = new Size(94, 20);
            lblRazonSocial.TabIndex = 7;
            lblRazonSocial.Text = "Razón Social";
            // 
            // lblCuit
            // 
            lblCuit.AutoSize = true;
            lblCuit.Location = new Point(153, 65);
            lblCuit.Name = "lblCuit";
            lblCuit.Size = new Size(40, 20);
            lblCuit.TabIndex = 8;
            lblCuit.Text = "CUIT";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(279, 65);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(67, 20);
            lblTelefono.TabIndex = 9;
            lblTelefono.Text = "Teléfono";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(411, 65);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Email";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(279, 459);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(178, 31);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Dar de baja";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // FormCompras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1351, 607);
            Controls.Add(btnEliminar);
            Controls.Add(lblEmail);
            Controls.Add(lblTelefono);
            Controls.Add(lblCuit);
            Controls.Add(lblRazonSocial);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefono);
            Controls.Add(txtCuit);
            Controls.Add(txtRazonSocial);
            Controls.Add(btnGuardar);
            Controls.Add(dgvProveedores);
            Controls.Add(label1);
            Name = "FormCompras";
            Text = "Compras";
            Load += FormCompras_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvProveedores;
        private Button btnGuardar;
        private TextBox txtRazonSocial;
        private TextBox txtCuit;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private Label lblRazonSocial;
        private Label lblCuit;
        private Label lblTelefono;
        private Label lblEmail;
        private Button btnEliminar;
    }
}