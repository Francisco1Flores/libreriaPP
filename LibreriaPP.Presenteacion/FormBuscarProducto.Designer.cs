using System.ComponentModel;

namespace Presentacion;

partial class FormBuscarProducto
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        dgvProductos = new System.Windows.Forms.DataGridView();
        txtBuscarProducto = new System.Windows.Forms.TextBox();
        btnSeleccionar = new System.Windows.Forms.Button();
        btnCancelar = new System.Windows.Forms.Button();
        label1 = new System.Windows.Forms.Label();
        txtCodigoBarras = new System.Windows.Forms.TextBox();
        txtNombre = new System.Windows.Forms.TextBox();
        txtPrecio = new System.Windows.Forms.TextBox();
        txtStock = new System.Windows.Forms.TextBox();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
        SuspendLayout();
        // 
        // dgvProductos
        // 
        dgvProductos.ColumnHeadersHeight = 29;
        dgvProductos.Location = new System.Drawing.Point(79, 125);
        dgvProductos.Name = "dgvProductos";
        dgvProductos.RowHeadersWidth = 51;
        dgvProductos.Size = new System.Drawing.Size(808, 194);
        dgvProductos.TabIndex = 0;
        dgvProductos.CellClick += dataGridView1_CellClick;
        // 
        // txtBuscarProducto
        // 
        txtBuscarProducto.Location = new System.Drawing.Point(79, 75);
        txtBuscarProducto.Name = "txtBuscarProducto";
        txtBuscarProducto.Size = new System.Drawing.Size(391, 27);
        txtBuscarProducto.TabIndex = 1;
        txtBuscarProducto.TextChanged += textBox1_TextChanged;
        // 
        // btnSeleccionar
        // 
        btnSeleccionar.Cursor = System.Windows.Forms.Cursors.Hand;
        btnSeleccionar.Location = new System.Drawing.Point(351, 479);
        btnSeleccionar.Name = "btnSeleccionar";
        btnSeleccionar.Size = new System.Drawing.Size(102, 35);
        btnSeleccionar.TabIndex = 2;
        btnSeleccionar.Text = "Seleccionar";
        btnSeleccionar.UseVisualStyleBackColor = true;
        btnSeleccionar.Click += btnSeleccionar_Click;
        // 
        // btnCancelar
        // 
        btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
        btnCancelar.Location = new System.Drawing.Point(535, 479);
        btnCancelar.Name = "btnCancelar";
        btnCancelar.Size = new System.Drawing.Size(75, 35);
        btnCancelar.TabIndex = 3;
        btnCancelar.Text = "Cancelar";
        btnCancelar.UseVisualStyleBackColor = true;
        btnCancelar.Click += btnCancelar_Click;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(79, 49);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(269, 23);
        label1.TabIndex = 4;
        label1.Text = "Buscar (Nombre o Código de Barras):";
        // 
        // txtCodigoBarras
        // 
        txtCodigoBarras.Enabled = false;
        txtCodigoBarras.Location = new System.Drawing.Point(102, 361);
        txtCodigoBarras.Name = "txtCodigoBarras";
        txtCodigoBarras.Size = new System.Drawing.Size(234, 27);
        txtCodigoBarras.TabIndex = 5;
        // 
        // txtNombre
        // 
        txtNombre.Enabled = false;
        txtNombre.Location = new System.Drawing.Point(342, 361);
        txtNombre.Name = "txtNombre";
        txtNombre.Size = new System.Drawing.Size(253, 27);
        txtNombre.TabIndex = 6;
        // 
        // txtPrecio
        // 
        txtPrecio.Enabled = false;
        txtPrecio.Location = new System.Drawing.Point(601, 361);
        txtPrecio.Name = "txtPrecio";
        txtPrecio.Size = new System.Drawing.Size(143, 27);
        txtPrecio.TabIndex = 7;
        // 
        // txtStock
        // 
        txtStock.Enabled = false;
        txtStock.Location = new System.Drawing.Point(750, 361);
        txtStock.Name = "txtStock";
        txtStock.Size = new System.Drawing.Size(100, 27);
        txtStock.TabIndex = 8;
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(102, 335);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(100, 23);
        label2.TabIndex = 9;
        label2.Text = "Código";
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(342, 335);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(100, 23);
        label3.TabIndex = 10;
        label3.Text = "Nombre";
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(601, 335);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(100, 23);
        label4.TabIndex = 11;
        label4.Text = "Precio";
        // 
        // label5
        // 
        label5.Location = new System.Drawing.Point(750, 335);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(100, 23);
        label5.TabIndex = 12;
        label5.Text = "Stock";
        // 
        // FormBuscarProducto
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(959, 573);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(txtStock);
        Controls.Add(txtPrecio);
        Controls.Add(txtNombre);
        Controls.Add(txtCodigoBarras);
        Controls.Add(label1);
        Controls.Add(btnCancelar);
        Controls.Add(btnSeleccionar);
        Controls.Add(txtBuscarProducto);
        Controls.Add(dgvProductos);
        MaximizeBox = false;
        MinimizeBox = false;
        Text = "FormBuscarProducto";
        ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox txtCodigoBarras;
    private System.Windows.Forms.TextBox txtNombre;
    private System.Windows.Forms.TextBox txtPrecio;
    private System.Windows.Forms.TextBox txtStock;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.DataGridView dgvProductos;
    private System.Windows.Forms.TextBox txtBuscarProducto;
    private System.Windows.Forms.Button btnSeleccionar;
    private System.Windows.Forms.Button btnCancelar;

    #endregion
}