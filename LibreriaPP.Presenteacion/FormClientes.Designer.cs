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
            btnBuscarCliente = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(67, 25);
            label1.Name = "label1";
            label1.Size = new Size(523, 34);
            label1.TabIndex = 0;
            label1.Text = "ADMINISTRACIÓN DE CLIENTES";
            // 
            // txtBuscarCliente
            // 
            txtBuscarCliente.Location = new Point(128, 116);
            txtBuscarCliente.Name = "txtBuscarCliente";
            txtBuscarCliente.Size = new Size(125, 27);
            txtBuscarCliente.TabIndex = 1;
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.Location = new Point(283, 114);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(94, 29);
            btnBuscarCliente.TabIndex = 2;
            btnBuscarCliente.Text = "Buscar";
            btnBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(128, 174);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 3;
            // 
            // FormClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnBuscarCliente);
            Controls.Add(txtBuscarCliente);
            Controls.Add(label1);
            Name = "FormClientes";
            Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBuscarCliente;
        private Button btnBuscarCliente;
        private DataGridView dataGridView1;
    }
}