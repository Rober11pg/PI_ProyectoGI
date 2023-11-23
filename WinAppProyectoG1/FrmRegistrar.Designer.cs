namespace WinAppProyectoG1
{
    partial class FrmRegistrar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.grpBoxNombre = new System.Windows.Forms.GroupBox();
            this.grpApellido = new System.Windows.Forms.GroupBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.grpBoxUsuario = new System.Windows.Forms.GroupBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.grpContra = new System.Windows.Forms.GroupBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.grpConfContra = new System.Windows.Forms.GroupBox();
            this.txtConFContra = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.grpBoxNombre.SuspendLayout();
            this.grpApellido.SuspendLayout();
            this.grpBoxUsuario.SuspendLayout();
            this.grpContra.SuspendLayout();
            this.grpConfContra.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grpConfContra);
            this.groupBox1.Controls.Add(this.grpContra);
            this.groupBox1.Controls.Add(this.grpBoxUsuario);
            this.groupBox1.Controls.Add(this.grpApellido);
            this.groupBox1.Controls.Add(this.grpBoxNombre);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(438, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1015, 589);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrarse";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(43, 37);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(222, 27);
            this.txtNombre.TabIndex = 9;
            // 
            // grpBoxNombre
            // 
            this.grpBoxNombre.BackColor = System.Drawing.SystemColors.HighlightText;
            this.grpBoxNombre.Controls.Add(this.txtNombre);
            this.grpBoxNombre.Location = new System.Drawing.Point(89, 91);
            this.grpBoxNombre.Name = "grpBoxNombre";
            this.grpBoxNombre.Size = new System.Drawing.Size(332, 79);
            this.grpBoxNombre.TabIndex = 20;
            this.grpBoxNombre.TabStop = false;
            this.grpBoxNombre.Text = "Nombre";
            // 
            // grpApellido
            // 
            this.grpApellido.BackColor = System.Drawing.SystemColors.HighlightText;
            this.grpApellido.Controls.Add(this.txtApellido);
            this.grpApellido.Location = new System.Drawing.Point(495, 78);
            this.grpApellido.Name = "grpApellido";
            this.grpApellido.Size = new System.Drawing.Size(332, 92);
            this.grpApellido.TabIndex = 21;
            this.grpApellido.TabStop = false;
            this.grpApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(62, 46);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(223, 27);
            this.txtApellido.TabIndex = 9;
            // 
            // grpBoxUsuario
            // 
            this.grpBoxUsuario.BackColor = System.Drawing.SystemColors.HighlightText;
            this.grpBoxUsuario.Controls.Add(this.txtUsuario);
            this.grpBoxUsuario.Location = new System.Drawing.Point(89, 195);
            this.grpBoxUsuario.Name = "grpBoxUsuario";
            this.grpBoxUsuario.Size = new System.Drawing.Size(738, 92);
            this.grpBoxUsuario.TabIndex = 21;
            this.grpBoxUsuario.TabStop = false;
            this.grpBoxUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(62, 46);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(640, 27);
            this.txtUsuario.TabIndex = 9;
            // 
            // grpContra
            // 
            this.grpContra.BackColor = System.Drawing.SystemColors.HighlightText;
            this.grpContra.Controls.Add(this.txtContra);
            this.grpContra.Location = new System.Drawing.Point(89, 331);
            this.grpContra.Name = "grpContra";
            this.grpContra.Size = new System.Drawing.Size(332, 92);
            this.grpContra.TabIndex = 21;
            this.grpContra.TabStop = false;
            this.grpContra.Text = "Contraseña";
            // 
            // txtContra
            // 
            this.txtContra.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtContra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContra.Location = new System.Drawing.Point(62, 46);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(203, 27);
            this.txtContra.TabIndex = 9;
            // 
            // grpConfContra
            // 
            this.grpConfContra.BackColor = System.Drawing.SystemColors.HighlightText;
            this.grpConfContra.Controls.Add(this.txtConFContra);
            this.grpConfContra.Location = new System.Drawing.Point(495, 331);
            this.grpConfContra.Name = "grpConfContra";
            this.grpConfContra.Size = new System.Drawing.Size(332, 92);
            this.grpConfContra.TabIndex = 22;
            this.grpConfContra.TabStop = false;
            this.grpConfContra.Text = "Contraseña";
            // 
            // txtConFContra
            // 
            this.txtConFContra.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtConFContra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConFContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConFContra.Location = new System.Drawing.Point(62, 46);
            this.txtConFContra.Name = "txtConFContra";
            this.txtConFContra.Size = new System.Drawing.Size(203, 27);
            this.txtConFContra.TabIndex = 9;
            // 
            // FrmRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1785, 765);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmRegistrar";
            this.Text = "FrmRegistrar";
            this.groupBox1.ResumeLayout(false);
            this.grpBoxNombre.ResumeLayout(false);
            this.grpBoxNombre.PerformLayout();
            this.grpApellido.ResumeLayout(false);
            this.grpApellido.PerformLayout();
            this.grpBoxUsuario.ResumeLayout(false);
            this.grpBoxUsuario.PerformLayout();
            this.grpContra.ResumeLayout(false);
            this.grpContra.PerformLayout();
            this.grpConfContra.ResumeLayout(false);
            this.grpConfContra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpBoxNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox grpApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.GroupBox grpBoxUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.GroupBox grpConfContra;
        private System.Windows.Forms.TextBox txtConFContra;
        private System.Windows.Forms.GroupBox grpContra;
        private System.Windows.Forms.TextBox txtContra;
    }
}