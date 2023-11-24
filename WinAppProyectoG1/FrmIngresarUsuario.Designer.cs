namespace WinAppProyectoG1
{
    partial class FrmIngresarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIngresarUsuario));
            this.pbxUsuario = new System.Windows.Forms.PictureBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grpBoxFondo = new System.Windows.Forms.GroupBox();
            this.checkBoxContra = new System.Windows.Forms.CheckBox();
            this.grpContraseña = new System.Windows.Forms.GroupBox();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.grpBoxUsuario = new System.Windows.Forms.GroupBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUsuario)).BeginInit();
            this.grpBoxFondo.SuspendLayout();
            this.grpContraseña.SuspendLayout();
            this.grpBoxUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbxUsuario
            // 
            this.pbxUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pbxUsuario.Image")));
            this.pbxUsuario.Location = new System.Drawing.Point(684, 110);
            this.pbxUsuario.Name = "pbxUsuario";
            this.pbxUsuario.Size = new System.Drawing.Size(206, 196);
            this.pbxUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxUsuario.TabIndex = 0;
            this.pbxUsuario.TabStop = false;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(288, 287);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(191, 63);
            this.btnIngresar.TabIndex = 6;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRegistrarse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarse.Location = new System.Drawing.Point(69, 287);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(167, 63);
            this.btnRegistrarse.TabIndex = 7;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = false;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(687, 52);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(191, 32);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Inciar Sesión";
            // 
            // grpBoxFondo
            // 
            this.grpBoxFondo.Controls.Add(this.checkBoxContra);
            this.grpBoxFondo.Controls.Add(this.grpContraseña);
            this.grpBoxFondo.Controls.Add(this.btnIngresar);
            this.grpBoxFondo.Controls.Add(this.btnRegistrarse);
            this.grpBoxFondo.Controls.Add(this.grpBoxUsuario);
            this.grpBoxFondo.Location = new System.Drawing.Point(509, 335);
            this.grpBoxFondo.Name = "grpBoxFondo";
            this.grpBoxFondo.Size = new System.Drawing.Size(549, 369);
            this.grpBoxFondo.TabIndex = 9;
            this.grpBoxFondo.TabStop = false;
            // 
            // checkBoxContra
            // 
            this.checkBoxContra.AutoSize = true;
            this.checkBoxContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxContra.Location = new System.Drawing.Point(58, 244);
            this.checkBoxContra.Name = "checkBoxContra";
            this.checkBoxContra.Size = new System.Drawing.Size(164, 20);
            this.checkBoxContra.TabIndex = 2;
            this.checkBoxContra.Text = "Mostrar Contraseña";
            this.checkBoxContra.UseVisualStyleBackColor = true;
            // 
            // grpContraseña
            // 
            this.grpContraseña.BackColor = System.Drawing.SystemColors.HighlightText;
            this.grpContraseña.Controls.Add(this.txtContrasenia);
            this.grpContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpContraseña.Location = new System.Drawing.Point(49, 155);
            this.grpContraseña.Name = "grpContraseña";
            this.grpContraseña.Size = new System.Drawing.Size(458, 74);
            this.grpContraseña.TabIndex = 1;
            this.grpContraseña.TabStop = false;
            this.grpContraseña.Text = "Contraseña";
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtContrasenia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasenia.Location = new System.Drawing.Point(20, 37);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(432, 27);
            this.txtContrasenia.TabIndex = 0;
            this.txtContrasenia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContrasenia_KeyPress);
            // 
            // grpBoxUsuario
            // 
            this.grpBoxUsuario.BackColor = System.Drawing.SystemColors.HighlightText;
            this.grpBoxUsuario.Controls.Add(this.txtUsuario);
            this.grpBoxUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxUsuario.Location = new System.Drawing.Point(49, 46);
            this.grpBoxUsuario.Name = "grpBoxUsuario";
            this.grpBoxUsuario.Size = new System.Drawing.Size(458, 74);
            this.grpBoxUsuario.TabIndex = 0;
            this.grpBoxUsuario.TabStop = false;
            this.grpBoxUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(9, 37);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(430, 27);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // FrmIngresarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1785, 765);
            this.Controls.Add(this.grpBoxFondo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pbxUsuario);
            this.Name = "FrmIngresarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesión";
            this.Load += new System.EventHandler(this.FrmIngresarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxUsuario)).EndInit();
            this.grpBoxFondo.ResumeLayout(false);
            this.grpBoxFondo.PerformLayout();
            this.grpContraseña.ResumeLayout(false);
            this.grpContraseña.PerformLayout();
            this.grpBoxUsuario.ResumeLayout(false);
            this.grpBoxUsuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxUsuario;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grpBoxFondo;
        private System.Windows.Forms.GroupBox grpBoxUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.CheckBox checkBoxContra;
        private System.Windows.Forms.GroupBox grpContraseña;
        private System.Windows.Forms.TextBox txtContrasenia;
    }
}