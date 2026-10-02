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
            txtEmail = new TextBox();
            txtTel = new TextBox();
            txtDireccion = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnAccion
            // 
            btnAccion.Location = new Point(225, 335);
            btnAccion.Name = "btnAccion";
            btnAccion.Size = new Size(94, 29);
            btnAccion.TabIndex = 0;
            btnAccion.Text = "Agregar";
            btnAccion.UseVisualStyleBackColor = true;
            btnAccion.Click += btnAccion_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(380, 335);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(298, 64);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 2;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(298, 107);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(125, 27);
            txtDni.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(298, 218);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 4;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(298, 166);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(125, 27);
            txtTel.TabIndex = 5;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(298, 269);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(125, 27);
            txtDireccion.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(228, 67);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 7;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(242, 110);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 8;
            label2.Text = "DNI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(225, 169);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 9;
            label3.Text = "Teléfono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(242, 221);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 10;
            label4.Text = "email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(220, 272);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 11;
            label5.Text = "Dirección";
            // 
            // FormAgregarCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDireccion);
            Controls.Add(txtTel);
            Controls.Add(txtEmail);
            Controls.Add(txtDni);
            Controls.Add(txtNombre);
            Controls.Add(btnCancelar);
            Controls.Add(btnAccion);
            Name = "FormAgregarCliente";
            Text = "FormAgregarCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAccion;
        private Button btnCancelar;
        private TextBox txtNombre;
        private TextBox txtDni;
        private TextBox txtEmail;
        private TextBox txtTel;
        private TextBox txtDireccion;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}