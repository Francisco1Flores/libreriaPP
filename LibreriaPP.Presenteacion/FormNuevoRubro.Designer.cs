using System.ComponentModel;

namespace Presentacion;

partial class FormNuevoRubro
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
        btnGuardar = new System.Windows.Forms.Button();
        btnCancelar = new System.Windows.Forms.Button();
        txtRubro = new System.Windows.Forms.TextBox();
        label1 = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // btnGuardar
        // 
        btnGuardar.Location = new System.Drawing.Point(284, 122);
        btnGuardar.Name = "btnGuardar";
        btnGuardar.Size = new System.Drawing.Size(75, 30);
        btnGuardar.TabIndex = 0;
        btnGuardar.Text = "Guardar";
        btnGuardar.UseVisualStyleBackColor = true;
        btnGuardar.Click += btnGuardar_Click;
        // 
        // btnCancelar
        // 
        btnCancelar.Location = new System.Drawing.Point(403, 122);
        btnCancelar.Name = "btnCancelar";
        btnCancelar.Size = new System.Drawing.Size(75, 30);
        btnCancelar.TabIndex = 1;
        btnCancelar.Text = "Cancelar";
        btnCancelar.UseVisualStyleBackColor = true;
        btnCancelar.Click += btnCancelar_Click_1;
        // 
        // txtRubro
        // 
        txtRubro.Location = new System.Drawing.Point(188, 72);
        txtRubro.Name = "txtRubro";
        txtRubro.Size = new System.Drawing.Size(392, 27);
        txtRubro.TabIndex = 2;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(188, 46);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(137, 23);
        label1.TabIndex = 3;
        label1.Text = "Ingrese el rubro:";
        // 
        // FormNuevoRubro
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 198);
        Controls.Add(label1);
        Controls.Add(txtRubro);
        Controls.Add(btnCancelar);
        Controls.Add(btnGuardar);
        MaximizeBox = false;
        MinimizeBox = false;
        Text = "FormNuevoRubro";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button btnGuardar;
    private System.Windows.Forms.Button btnCancelar;
    private System.Windows.Forms.TextBox txtRubro;
    private System.Windows.Forms.Label label1;

    #endregion
}