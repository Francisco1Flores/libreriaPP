namespace Presentacion
{
    partial class FormClientes
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
            txtBuscarCliente = new TextBox();
            dgvClientes = new DataGridView();
            label2 = new Label();
            btnNuevoCliente = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(67, 24);
            label1.Name = "label1";
            label1.Size = new Size(523, 34);
            label1.TabIndex = 0;
            label1.Text = "ADMINISTRACIÓN DE CLIENTES";
            // 
            // txtBuscarCliente
            // 
            txtBuscarCliente.Location = new Point(80, 136);
            txtBuscarCliente.Name = "txtBuscarCliente";
            txtBuscarCliente.Size = new Size(307, 27);
            txtBuscarCliente.TabIndex = 1;
            txtBuscarCliente.TextChanged += txtBuscarCliente_TextChanged;
            // 
            // dgvClientes
            // 
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(80, 174);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new Size(1244, 444);
            dgvClientes.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 113);
            label2.Name = "label2";
            label2.Size = new Size(212, 20);
            label2.TabIndex = 4;
            label2.Text = "Buscar cliente (Nombre o DNI)";
            // 
            // btnNuevoCliente
            // 
            btnNuevoCliente.Cursor = Cursors.Hand;
            btnNuevoCliente.Location = new Point(1187, 134);
            btnNuevoCliente.Name = "btnNuevoCliente";
            btnNuevoCliente.Size = new Size(137, 29);
            btnNuevoCliente.TabIndex = 5;
            btnNuevoCliente.Text = "Nuevo";
            btnNuevoCliente.UseVisualStyleBackColor = true;
            btnNuevoCliente.Click += btnNuevoCliente_Click_1;
            // 
            // FormClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1386, 761);
            Controls.Add(btnNuevoCliente);
            Controls.Add(label2);
            Controls.Add(dgvClientes);
            Controls.Add(txtBuscarCliente);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormClientes";
            Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBuscarCliente;
        private DataGridView dgvClientes;
        private Label label2;
        private Button btnNuevoCliente;
    }
}