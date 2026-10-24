namespace Presentacion
{
    partial class FormAgregarCliente
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
            btnAccion = new Button();
            btnCancelar = new Button();
            txtNombre = new TextBox();
            txtDni = new TextBox();
            txtTel = new TextBox();
            txtEmail = new TextBox();
            txtDireccion = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblErrorNombre = new Label();
            lblErrorDni = new Label();
            lblErrorTel = new Label();
            lblErrorEmail = new Label();
            lblErrorDireccion = new Label();
            lblNombreObligatorio = new Label();
            lblDniObligatorio = new Label();
            lblCamposObligatorios = new Label();
            SuspendLayout();
            // 
            // btnAccion
            // 
            btnAccion.Cursor = Cursors.Hand;
            btnAccion.Location = new Point(304, 364);
            btnAccion.Name = "btnAccion";
            btnAccion.Size = new Size(94, 29);
            btnAccion.TabIndex = 0;
            btnAccion.Text = "Agregar";
            btnAccion.UseVisualStyleBackColor = true;
            btnAccion.Click += btnAccion_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Location = new Point(450, 364);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(340, 53);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(204, 27);
            txtNombre.TabIndex = 2;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(340, 106);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(204, 27);
            txtDni.TabIndex = 3;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(340, 159);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(204, 27);
            txtTel.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(340, 212);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(204, 27);
            txtEmail.TabIndex = 5;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(340, 265);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(204, 27);
            txtDireccion.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(270, 60);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 7;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(294, 113);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 8;
            label2.Text = "DNI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(262, 162);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 9;
            label3.Text = "Teléfono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(283, 215);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 10;
            label4.Text = "email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(262, 272);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 11;
            label5.Text = "Dirección";
            // 
            // lblErrorNombre
            // 
            lblErrorNombre.AutoSize = true;
            lblErrorNombre.ForeColor = Color.Red;
            lblErrorNombre.Location = new Point(340, 83);
            lblErrorNombre.Name = "lblErrorNombre";
            lblErrorNombre.Size = new Size(50, 20);
            lblErrorNombre.TabIndex = 12;
            lblErrorNombre.Text = "label6";
            // 
            // lblErrorDni
            // 
            lblErrorDni.AutoSize = true;
            lblErrorDni.ForeColor = Color.Red;
            lblErrorDni.Location = new Point(340, 136);
            lblErrorDni.Name = "lblErrorDni";
            lblErrorDni.Size = new Size(50, 20);
            lblErrorDni.TabIndex = 13;
            lblErrorDni.Text = "label7";
            // 
            // lblErrorTel
            // 
            lblErrorTel.AutoSize = true;
            lblErrorTel.ForeColor = Color.Red;
            lblErrorTel.Location = new Point(340, 189);
            lblErrorTel.Name = "lblErrorTel";
            lblErrorTel.Size = new Size(50, 20);
            lblErrorTel.TabIndex = 14;
            lblErrorTel.Text = "label8";
            // 
            // lblErrorEmail
            // 
            lblErrorEmail.AutoSize = true;
            lblErrorEmail.ForeColor = Color.Red;
            lblErrorEmail.Location = new Point(340, 242);
            lblErrorEmail.Name = "lblErrorEmail";
            lblErrorEmail.Size = new Size(50, 20);
            lblErrorEmail.TabIndex = 15;
            lblErrorEmail.Text = "label9";
            // 
            // lblErrorDireccion
            // 
            lblErrorDireccion.AutoSize = true;
            lblErrorDireccion.ForeColor = Color.Red;
            lblErrorDireccion.Location = new Point(340, 295);
            lblErrorDireccion.Name = "lblErrorDireccion";
            lblErrorDireccion.Size = new Size(58, 20);
            lblErrorDireccion.TabIndex = 16;
            lblErrorDireccion.Text = "label10";
            // 
            // lblNombreObligatorio
            // 
            lblNombreObligatorio.AutoSize = true;
            lblNombreObligatorio.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNombreObligatorio.ForeColor = Color.Red;
            lblNombreObligatorio.Location = new Point(550, 52);
            lblNombreObligatorio.Name = "lblNombreObligatorio";
            lblNombreObligatorio.Size = new Size(21, 28);
            lblNombreObligatorio.TabIndex = 17;
            lblNombreObligatorio.Text = "*";
            // 
            // lblDniObligatorio
            // 
            lblDniObligatorio.AutoSize = true;
            lblDniObligatorio.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDniObligatorio.ForeColor = Color.Red;
            lblDniObligatorio.Location = new Point(550, 106);
            lblDniObligatorio.Name = "lblDniObligatorio";
            lblDniObligatorio.Size = new Size(21, 28);
            lblDniObligatorio.TabIndex = 18;
            lblDniObligatorio.Text = "*";
            // 
            // lblCamposObligatorios
            // 
            lblCamposObligatorios.AutoSize = true;
            lblCamposObligatorios.ForeColor = Color.Red;
            lblCamposObligatorios.Location = new Point(352, 329);
            lblCamposObligatorios.Name = "lblCamposObligatorios";
            lblCamposObligatorios.Size = new Size(158, 20);
            lblCamposObligatorios.TabIndex = 19;
            lblCamposObligatorios.Text = "Campos obligatorios *";
            // 
            // FormAgregarCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(863, 450);
            Controls.Add(lblCamposObligatorios);
            Controls.Add(lblDniObligatorio);
            Controls.Add(lblNombreObligatorio);
            Controls.Add(lblErrorDireccion);
            Controls.Add(lblErrorEmail);
            Controls.Add(lblErrorTel);
            Controls.Add(lblErrorDni);
            Controls.Add(lblErrorNombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDireccion);
            Controls.Add(txtEmail);
            Controls.Add(txtTel);
            Controls.Add(txtDni);
            Controls.Add(txtNombre);
            Controls.Add(btnCancelar);
            Controls.Add(btnAccion);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAgregarCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAgregarCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAccion;
        private Button btnCancelar;
        private TextBox txtNombre;
        private TextBox txtDni;
        private TextBox txtTel;
        private TextBox txtEmail;
        private TextBox txtDireccion;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblErrorNombre;
        private Label lblErrorDni;
        private Label lblErrorTel;
        private Label lblErrorEmail;
        private Label lblErrorDireccion;
        private Label lblNombreObligatorio;
        private Label lblDniObligatorio;
        private Label lblCamposObligatorios;
    }
}