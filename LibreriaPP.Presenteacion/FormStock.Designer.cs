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
            btnEliminar = new Button();
            btnLimpiar = new Button();
            btnModificar = new Button();
            btnGuardar = new Button();
            txtCantidad = new TextBox();
            lblCantidad = new Label();
            txtPrecioVenta = new TextBox();
            lblPrecioVenta = new Label();
            txtPrecioLista = new TextBox();
            lblPrecioLista = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            txtCodigo = new TextBox();
            lblCodigo = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStock).BeginInit();
            gbProducto.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.OrangeRed;
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
            dgvStock.BackgroundColor = SystemColors.ButtonHighlight;
            dgvStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStock.Location = new Point(80, 152);
            dgvStock.Name = "dgvStock";
            dgvStock.ReadOnly = true;
            dgvStock.RowHeadersWidth = 51;
            dgvStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStock.Size = new Size(1244, 188);
            dgvStock.TabIndex = 3;
            dgvStock.CellClick += dgvStock_CellClick;
            // 
            // gbProducto
            // 
            gbProducto.BackColor = SystemColors.ButtonHighlight;
            gbProducto.Controls.Add(btnEliminar);
            gbProducto.Controls.Add(btnLimpiar);
            gbProducto.Controls.Add(btnModificar);
            gbProducto.Controls.Add(btnGuardar);
            gbProducto.Controls.Add(txtCantidad);
            gbProducto.Controls.Add(lblCantidad);
            gbProducto.Controls.Add(txtPrecioVenta);
            gbProducto.Controls.Add(lblPrecioVenta);
            gbProducto.Controls.Add(txtPrecioLista);
            gbProducto.Controls.Add(lblPrecioLista);
            gbProducto.Controls.Add(txtNombre);
            gbProducto.Controls.Add(lblNombre);
            gbProducto.Controls.Add(txtCodigo);
            gbProducto.Controls.Add(lblCodigo);
            gbProducto.Location = new Point(80, 373);
            gbProducto.Name = "gbProducto";
            gbProducto.Size = new Size(1244, 262);
            gbProducto.TabIndex = 4;
            gbProducto.TabStop = false;
            gbProducto.Text = "REGISTRAR / EDITAR PRODUCTO";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(498, 225);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.Highlight;
            btnLimpiar.Location = new Point(362, 222);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = SystemColors.Highlight;
            btnModificar.Location = new Point(236, 222);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 11;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.MenuHighlight;
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Location = new Point(99, 222);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = " Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtCantidad
            // 
            txtCantidad.BorderStyle = BorderStyle.FixedSingle;
            txtCantidad.Location = new Point(136, 161);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(125, 27);
            txtCantidad.TabIndex = 9;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(26, 161);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(91, 20);
            lblCantidad.TabIndex = 8;
            lblCantidad.Text = "Stock Inicial:";
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.BorderStyle = BorderStyle.FixedSingle;
            txtPrecioVenta.Location = new Point(423, 116);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(125, 27);
            txtPrecioVenta.TabIndex = 7;
            // 
            // lblPrecioVenta
            // 
            lblPrecioVenta.AutoSize = true;
            lblPrecioVenta.Location = new Point(279, 116);
            lblPrecioVenta.Name = "lblPrecioVenta";
            lblPrecioVenta.Size = new Size(116, 20);
            lblPrecioVenta.TabIndex = 6;
            lblPrecioVenta.Text = "Precio Venta ($):";
            // 
            // txtPrecioLista
            // 
            txtPrecioLista.BorderStyle = BorderStyle.FixedSingle;
            txtPrecioLista.Location = new Point(136, 113);
            txtPrecioLista.Name = "txtPrecioLista";
            txtPrecioLista.Size = new Size(125, 27);
            txtPrecioLista.TabIndex = 5;
            // 
            // lblPrecioLista
            // 
            lblPrecioLista.AutoSize = true;
            lblPrecioLista.Location = new Point(21, 113);
            lblPrecioLista.Name = "lblPrecioLista";
            lblPrecioLista.Size = new Size(109, 20);
            lblPrecioLista.TabIndex = 4;
            lblPrecioLista.Text = "Precio Lista ($):";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.ButtonHighlight;
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Location = new Point(99, 67);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 3;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(21, 70);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre:";
            // 
            // txtCodigo
            // 
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.Location = new Point(423, 63);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(216, 27);
            txtCodigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(253, 70);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(127, 20);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código de Barras:";
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
            gbProducto.ResumeLayout(false);
            gbProducto.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBuscarProductos;
        private DataGridView dgvStock;
        private GroupBox gbProducto;
        private Label label2;
        private TextBox txtCodigo;
        private Label lblCodigo;
        private TextBox txtPrecioVenta;
        private Label lblPrecioVenta;
        private TextBox txtPrecioLista;
        private Label lblPrecioLista;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtCantidad;
        private Label lblCantidad;
        private Button btnLimpiar;
        private Button btnModificar;
        private Button btnGuardar;
        private Button btnEliminar;
    }
}