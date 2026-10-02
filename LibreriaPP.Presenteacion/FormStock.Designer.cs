namespace Presentacion
{
    partial class FormStock
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
            txtBuscarProductos = new TextBox();
            dgvStock = new DataGridView();
            gbProducto = new GroupBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStock).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(570, 34);
            label1.TabIndex = 0;
            label1.Text = "CONTROL DE STOCK Y PRODUCTOS";
            // 
            // txtBuscarProductos
            // 
            txtBuscarProductos.Location = new Point(80, 119);
            txtBuscarProductos.Name = "txtBuscarProductos";
            txtBuscarProductos.Size = new Size(395, 27);
            txtBuscarProductos.TabIndex = 1;
            txtBuscarProductos.TextChanged += txtBuscarProductos_TextChanged;
            // 
            // dgvStock
            // 
            dgvStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStock.Location = new Point(80, 152);
            dgvStock.Name = "dgvStock";
            dgvStock.ReadOnly = true;
            dgvStock.RowHeadersWidth = 51;
            dgvStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStock.Size = new Size(1244, 188);
            dgvStock.TabIndex = 3;
            // 
            // gbProducto
            // 
            gbProducto.Location = new Point(80, 373);
            gbProducto.Name = "gbProducto";
            gbProducto.Size = new Size(1244, 262);
            gbProducto.TabIndex = 4;
            gbProducto.TabStop = false;
            gbProducto.Text = "REGISTRAR / EDITAR PRODUCTO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 85);
            label2.Name = "label2";
            label2.Size = new Size(117, 20);
            label2.TabIndex = 5;
            label2.Text = "Buscar producto";
            // 
            // FormStock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1751, 755);
            Controls.Add(label2);
            Controls.Add(gbProducto);
            Controls.Add(dgvStock);
            Controls.Add(txtBuscarProductos);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormStock";
            Text = "Stock";
            Load += FormStock_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBuscarProductos;
        private DataGridView dgvStock;
        private GroupBox gbProducto;
        private Label label2;
    }
}