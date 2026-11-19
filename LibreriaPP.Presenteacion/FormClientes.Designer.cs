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
            label1 = new System.Windows.Forms.Label();
            txtBuscarCliente = new System.Windows.Forms.TextBox();
            dgvClientes = new System.Windows.Forms.DataGridView();
            label2 = new System.Windows.Forms.Label();
            btnNuevoCliente = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            btnSeleccionar = new System.Windows.Forms.Button();
            lblDniObligatorio = new System.Windows.Forms.Label();
            lblNombreObligatorio = new System.Windows.Forms.Label();
            lblCamposObligatorios = new System.Windows.Forms.Label();
            btnCancelar = new System.Windows.Forms.Button();
            btnGuardarDatos = new System.Windows.Forms.Button();
            btnNuevo = new System.Windows.Forms.Button();
            btnEliminar = new System.Windows.Forms.Button();
            btnAgregar = new System.Windows.Forms.Button();
            btnModificar = new System.Windows.Forms.Button();
            txtDireccion = new System.Windows.Forms.TextBox();
            txtEmail = new System.Windows.Forms.TextBox();
            txtTel = new System.Windows.Forms.TextBox();
            txtDni = new System.Windows.Forms.TextBox();
            txtNombre = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Verdana", 16.2F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)), System.Drawing.GraphicsUnit.Point, ((byte)0));
            label1.Location = new System.Drawing.Point(36, 20);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(523, 34);
            label1.TabIndex = 0;
            label1.Text = "ADMINISTRACIÓN DE CLIENTES";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(40, 72);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(212, 20);
            label2.TabIndex = 4;
            label2.Text = "Buscar cliente (Nombre o DNI)";
            // 
            // txtBuscarCliente
            // 
            txtBuscarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            txtBuscarCliente.Location = new System.Drawing.Point(40, 95);
            txtBuscarCliente.MaximumSize = new System.Drawing.Size(500, 0);
            txtBuscarCliente.Name = "txtBuscarCliente";
            txtBuscarCliente.Size = new System.Drawing.Size(340, 27);
            txtBuscarCliente.TabIndex = 1;
            txtBuscarCliente.TextChanged += txtBuscarCliente_TextChanged;
            // 
            // btnNuevoCliente
            // 
            btnNuevoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            btnNuevoCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNuevoCliente.Location = new System.Drawing.Point(923, 93);
            btnNuevoCliente.Name = "btnNuevoCliente";
            btnNuevoCliente.Size = new System.Drawing.Size(137, 29);
            btnNuevoCliente.TabIndex = 5;
            btnNuevoCliente.Text = "Nuevo";
            btnNuevoCliente.UseVisualStyleBackColor = true;
            btnNuevoCliente.Click += btnNuevoCliente_Click_1;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new System.Drawing.Point(40, 134);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new System.Drawing.Size(1020, 326);
            dgvClientes.TabIndex = 3;
            dgvClientes.CellMouseClick += dgvClientes_CellMouseClick;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            groupBox1.Controls.Add(btnSeleccionar);
            groupBox1.Controls.Add(lblDniObligatorio);
            groupBox1.Controls.Add(lblNombreObligatorio);
            groupBox1.Controls.Add(lblCamposObligatorios);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnGuardarDatos);
            groupBox1.Controls.Add(btnNuevo);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(btnModificar);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtTel);
            groupBox1.Controls.Add(txtDni);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new System.Drawing.Point(40, 476);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(1020, 215);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Administrar Clientes";
            // 
            // lblCamposObligatorios
            // 
            lblCamposObligatorios.AutoSize = true;
            lblCamposObligatorios.Location = new System.Drawing.Point(16, 25);
            lblCamposObligatorios.Name = "lblCamposObligatorios";
            lblCamposObligatorios.Size = new System.Drawing.Size(166, 20);
            lblCamposObligatorios.TabIndex = 30;
            lblCamposObligatorios.Text = "(*) Campos Obligatorios";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(24, 58);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(134, 20);
            label3.TabIndex = 13;
            label3.Text = "Nombre Completo";
            // 
            // txtNombre
            // 
            txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            txtNombre.Location = new System.Drawing.Point(164, 55);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(260, 27);
            txtNombre.TabIndex = 18;
            // 
            // lblNombreObligatorio
            // 
            lblNombreObligatorio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            lblNombreObligatorio.AutoSize = true;
            lblNombreObligatorio.Location = new System.Drawing.Point(428, 58);
            lblNombreObligatorio.Name = "lblNombreObligatorio";
            lblNombreObligatorio.Size = new System.Drawing.Size(25, 20);
            lblNombreObligatorio.TabIndex = 31;
            lblNombreObligatorio.Text = "(*)";
            // 
            // label8
            // 
            label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(468, 58);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(35, 20);
            label8.TabIndex = 17;
            label8.Text = "DNI";
            // 
            // txtDni
            // 
            txtDni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            txtDni.Location = new System.Drawing.Point(509, 55);
            txtDni.Name = "txtDni";
            txtDni.Size = new System.Drawing.Size(175, 27);
            txtDni.TabIndex = 19;
            // 
            // lblDniObligatorio
            // 
            lblDniObligatorio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            lblDniObligatorio.AutoSize = true;
            lblDniObligatorio.Location = new System.Drawing.Point(688, 58);
            lblDniObligatorio.Name = "lblDniObligatorio";
            lblDniObligatorio.Size = new System.Drawing.Size(25, 20);
            lblDniObligatorio.TabIndex = 32;
            lblDniObligatorio.Text = "(*)";
            // 
            // label4
            // 
            label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(728, 58);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(67, 20);
            label4.TabIndex = 14;
            label4.Text = "Teléfono";
            // 
            // txtTel
            // 
            txtTel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            txtTel.Location = new System.Drawing.Point(801, 55);
            txtTel.Name = "txtTel";
            txtTel.Size = new System.Drawing.Size(195, 27);
            txtTel.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(112, 108);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(46, 20);
            label6.TabIndex = 15;
            label6.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            txtEmail.Location = new System.Drawing.Point(164, 105);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(260, 27);
            txtEmail.TabIndex = 21;
            // 
            // label7
            // 
            label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(431, 108);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(72, 20);
            label7.TabIndex = 16;
            label7.Text = "Dirección";
            // 
            // txtDireccion
            // 
            txtDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            txtDireccion.Location = new System.Drawing.Point(509, 105);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new System.Drawing.Size(487, 27);
            txtDireccion.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(24, 115);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(0, 20);
            label5.TabIndex = 12;
            // 
            // btnNuevo
            // 
            btnNuevo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNuevo.Location = new System.Drawing.Point(285, 160);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new System.Drawing.Size(145, 32);
            btnNuevo.TabIndex = 26;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAgregar.Location = new System.Drawing.Point(437, 160);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new System.Drawing.Size(145, 32);
            btnAgregar.TabIndex = 24;
            btnAgregar.Text = "Guardar Nuevo";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnGuardarDatos
            // 
            btnGuardarDatos.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            btnGuardarDatos.Cursor = System.Windows.Forms.Cursors.Hand;
            btnGuardarDatos.Location = new System.Drawing.Point(437, 160);
            btnGuardarDatos.Name = "btnGuardarDatos";
            btnGuardarDatos.Size = new System.Drawing.Size(145, 32);
            btnGuardarDatos.TabIndex = 28;
            btnGuardarDatos.Text = "Guardar Datos";
            btnGuardarDatos.UseVisualStyleBackColor = true;
            btnGuardarDatos.Click += btnGuardarDatos_Click;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnModificar.Location = new System.Drawing.Point(437, 160);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new System.Drawing.Size(145, 32);
            btnModificar.TabIndex = 23;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            btnSeleccionar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSeleccionar.Location = new System.Drawing.Point(437, 160);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new System.Drawing.Size(145, 32);
            btnSeleccionar.TabIndex = 33;
            btnSeleccionar.Text = "Seleccionar";
            btnSeleccionar.UseVisualStyleBackColor = true;
            btnSeleccionar.Click += btnSeleccionar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnEliminar.Location = new System.Drawing.Point(588, 160);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(145, 32);
            btnEliminar.TabIndex = 25;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCancelar.Location = new System.Drawing.Point(588, 160);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(145, 32);
            btnCancelar.TabIndex = 29;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormClientes
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = System.Drawing.SystemColors.ActiveBorder;
            ClientSize = new System.Drawing.Size(1100, 720);
            Controls.Add(groupBox1);
            Controls.Add(btnNuevoCliente);
            Controls.Add(label2);
            Controls.Add(dgvClientes);
            Controls.Add(txtBuscarCliente);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            MinimumSize = new System.Drawing.Size(950, 650);
            Name = "FormClientes";
            Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Label lblNombreObligatorio;
        private System.Windows.Forms.Label lblDniObligatorio;
        private System.Windows.Forms.Label lblCamposObligatorios;

        #endregion

        private Label label1;
        private TextBox txtBuscarCliente;
        private System.Windows.Forms.DataGridView dgvClientes;
        private Label label2;
        private Button btnNuevoCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Label label6;
        private Label label7;
        private TextBox txtNombre;
        private System.Windows.Forms.Label label8;
        private TextBox txtDni;
        private Button btnModificar;
        private TextBox txtDireccion;
        private TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTel;
        private Button btnNuevo;
        private Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnGuardarDatos;
        private Button btnCancelar;
    }
}