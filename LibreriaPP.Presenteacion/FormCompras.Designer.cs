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
            label1.Location = new Point(12, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(147, 15);
            label1.TabIndex = 0;
            label1.Text = "\"MÓDULO DE COMPRAS\".";
            // 
            // dgvProveedores
            // 
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedores.Location = new Point(12, 96);
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.Size = new Size(716, 229);
            dgvProveedores.TabIndex = 1;
            dgvProveedores.CellClick += dgvProveedores_CellCellClick;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(458, 67);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(107, 23);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtRazonSocial
            // 
            txtRazonSocial.Location = new Point(12, 67);
            txtRazonSocial.Name = "txtRazonSocial";
            txtRazonSocial.Size = new Size(105, 23);
            txtRazonSocial.TabIndex = 3;
            // 
            // txtCuit
            // 
            txtCuit.Location = new Point(123, 67);
            txtCuit.Name = "txtCuit";
            txtCuit.Size = new Size(105, 23);
            txtCuit.TabIndex = 4;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(234, 67);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(105, 23);
            txtTelefono.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(345, 67);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(105, 23);
            txtEmail.TabIndex = 6;
            // 
            // lblRazonSocial
            // 
            lblRazonSocial.AutoSize = true;
            lblRazonSocial.Location = new Point(12, 49);
            lblRazonSocial.Name = "lblRazonSocial";
            lblRazonSocial.Size = new Size(73, 15);
            lblRazonSocial.TabIndex = 7;
            lblRazonSocial.Text = "Razón Social";
            // 
            // lblCuit
            // 
            lblCuit.AutoSize = true;
            lblCuit.Location = new Point(134, 49);
            lblCuit.Name = "lblCuit";
            lblCuit.Size = new Size(32, 15);
            lblCuit.TabIndex = 8;
            lblCuit.Text = "CUIT";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(244, 49);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(52, 15);
            lblTelefono.TabIndex = 9;
            lblTelefono.Text = "Teléfono";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(360, 49);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Email";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(571, 67);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Dar de baja";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // FormCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(762, 380);
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
            Margin = new Padding(3, 2, 3, 2);
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