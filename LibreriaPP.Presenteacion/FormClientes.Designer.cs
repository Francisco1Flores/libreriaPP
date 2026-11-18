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
            label1.Location = new System.Drawing.Point(67, 24);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(523, 34);
            label1.TabIndex = 0;
            label1.Text = "ADMINISTRACIÓN DE CLIENTES";
            // 
            // txtBuscarCliente
            // 
            txtBuscarCliente.Location = new System.Drawing.Point(80, 136);
            txtBuscarCliente.Name = "txtBuscarCliente";
            txtBuscarCliente.Size = new System.Drawing.Size(307, 27);
            txtBuscarCliente.TabIndex = 1;
            txtBuscarCliente.TextChanged += txtBuscarCliente_TextChanged;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new System.Drawing.Point(80, 174);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new System.Drawing.Size(1244, 467);
            dgvClientes.TabIndex = 3;
            dgvClientes.CellMouseClick += dgvClientes_CellMouseClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(80, 113);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(212, 20);
            label2.TabIndex = 4;
            label2.Text = "Buscar cliente (Nombre o DNI)";
            // 
            // btnNuevoCliente
            // 
            btnNuevoCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNuevoCliente.Location = new System.Drawing.Point(1187, 134);
            btnNuevoCliente.Name = "btnNuevoCliente";
            btnNuevoCliente.Size = new System.Drawing.Size(137, 29);
            btnNuevoCliente.TabIndex = 5;
            btnNuevoCliente.Text = "Nuevo";
            btnNuevoCliente.UseVisualStyleBackColor = true;
            btnNuevoCliente.Click += btnNuevoCliente_Click_1;
            // 
            // groupBox1
            // 
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
            groupBox1.Location = new System.Drawing.Point(77, 663);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(1247, 254);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Administrar Clientes";
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSeleccionar.Location = new System.Drawing.Point(486, 176);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new System.Drawing.Size(145, 29);
            btnSeleccionar.TabIndex = 33;
            btnSeleccionar.Text = "Seleccionar";
            btnSeleccionar.UseVisualStyleBackColor = true;
            btnSeleccionar.Click += btnSeleccionar_Click;
            // 
            // lblDniObligatorio
            // 
            lblDniObligatorio.Location = new System.Drawing.Point(820, 56);
            lblDniObligatorio.Name = "lblDniObligatorio";
            lblDniObligatorio.Size = new System.Drawing.Size(29, 23);
            lblDniObligatorio.TabIndex = 32;
            lblDniObligatorio.Text = "(*)";
            // 
            // lblNombreObligatorio
            // 
            lblNombreObligatorio.Location = new System.Drawing.Point(496, 55);
            lblNombreObligatorio.Name = "lblNombreObligatorio";
            lblNombreObligatorio.Size = new System.Drawing.Size(29, 23);
            lblNombreObligatorio.TabIndex = 31;
            lblNombreObligatorio.Text = "(*)";
            // 
            // lblCamposObligatorios
            // 
            lblCamposObligatorios.Location = new System.Drawing.Point(6, 23);
            lblCamposObligatorios.Name = "lblCamposObligatorios";
            lblCamposObligatorios.Size = new System.Drawing.Size(187, 23);
            lblCamposObligatorios.TabIndex = 30;
            lblCamposObligatorios.Text = "(*) Campos Obligatorios";
            // 
            // btnCancelar
            // 
            btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCancelar.Location = new System.Drawing.Point(638, 176);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(145, 29);
            btnCancelar.TabIndex = 29;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardarDatos
            // 
            btnGuardarDatos.Cursor = System.Windows.Forms.Cursors.Hand;
            btnGuardarDatos.Location = new System.Drawing.Point(487, 176);
            btnGuardarDatos.Name = "btnGuardarDatos";
            btnGuardarDatos.Size = new System.Drawing.Size(145, 29);
            btnGuardarDatos.TabIndex = 28;
            btnGuardarDatos.Text = "Guardar Datos";
            btnGuardarDatos.UseVisualStyleBackColor = true;
            btnGuardarDatos.Click += btnGuardarDatos_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNuevo.Location = new System.Drawing.Point(335, 176);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new System.Drawing.Size(145, 29);
            btnNuevo.TabIndex = 26;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnEliminar.Location = new System.Drawing.Point(638, 176);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(145, 29);
            btnEliminar.TabIndex = 25;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAgregar.Location = new System.Drawing.Point(487, 176);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new System.Drawing.Size(145, 29);
            btnAgregar.TabIndex = 24;
            btnAgregar.Text = "Guardar Nuevo";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnModificar.Location = new System.Drawing.Point(487, 176);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new System.Drawing.Size(145, 29);
            btnModificar.TabIndex = 23;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new System.Drawing.Point(581, 109);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new System.Drawing.Size(321, 27);
            txtDireccion.TabIndex = 22;
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(184, 112);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(306, 27);
            txtEmail.TabIndex = 21;
            // 
            // txtTel
            // 
            txtTel.Location = new System.Drawing.Point(928, 55);
            txtTel.Name = "txtTel";
            txtTel.Size = new System.Drawing.Size(245, 27);
            txtTel.TabIndex = 20;
            // 
            // txtDni
            // 
            txtDni.Location = new System.Drawing.Point(581, 55);
            txtDni.Name = "txtDni";
            txtDni.Size = new System.Drawing.Size(233, 27);
            txtDni.TabIndex = 19;
            // 
            // txtNombre
            // 
            txtNombre.Location = new System.Drawing.Point(184, 52);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(306, 27);
            txtNombre.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(540, 58);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(35, 20);
            label8.TabIndex = 17;
            label8.Text = "DNI";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(505, 112);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(72, 20);
            label7.TabIndex = 16;
            label7.Text = "Dirección";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(132, 116);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(46, 20);
            label6.TabIndex = 15;
            label6.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(855, 58);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(67, 20);
            label4.TabIndex = 14;
            label4.Text = "Teléfono";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(44, 55);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(134, 20);
            label3.TabIndex = 13;
            label3.Text = "Nombre Completo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(44, 123);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(0, 20);
            label5.TabIndex = 12;
            // 
            // FormClientes
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = System.Drawing.SystemColors.ActiveBorder;
            ClientSize = new System.Drawing.Size(1386, 1047);
            Controls.Add(groupBox1);
            Controls.Add(btnNuevoCliente);
            Controls.Add(label2);
            Controls.Add(dgvClientes);
            Controls.Add(txtBuscarCliente);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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