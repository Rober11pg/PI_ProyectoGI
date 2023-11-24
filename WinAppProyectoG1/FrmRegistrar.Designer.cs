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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistrar));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpGenero = new System.Windows.Forms.GroupBox();
            this.rdbtnH = new System.Windows.Forms.RadioButton();
            this.rdbtnM = new System.Windows.Forms.RadioButton();
            this.checkBoxContra = new System.Windows.Forms.CheckBox();
            this.grpConfContra = new System.Windows.Forms.GroupBox();
            this.txtConFContra = new System.Windows.Forms.TextBox();
            this.grpContra = new System.Windows.Forms.GroupBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.grpBoxUsuario = new System.Windows.Forms.GroupBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.grpApellido = new System.Windows.Forms.GroupBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.grpBoxNombre = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.panelRoot = new System.Windows.Forms.Panel();
            this.btnContinuarRot = new System.Windows.Forms.Button();
            this.gpBoxCaracteresroot = new System.Windows.Forms.GroupBox();
            this.txtIngreCaracteresRoot = new System.Windows.Forms.TextBox();
            this.btnCambiarImage = new System.Windows.Forms.Button();
            this.pbxImageRobot = new System.Windows.Forms.PictureBox();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.checkBoxRobot = new System.Windows.Forms.CheckBox();
            this.lbl_resp = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grpGenero.SuspendLayout();
            this.grpConfContra.SuspendLayout();
            this.grpContra.SuspendLayout();
            this.grpBoxUsuario.SuspendLayout();
            this.grpApellido.SuspendLayout();
            this.grpBoxNombre.SuspendLayout();
            this.panelRoot.SuspendLayout();
            this.gpBoxCaracteresroot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImageRobot)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grpGenero);
            this.groupBox1.Controls.Add(this.checkBoxContra);
            this.groupBox1.Controls.Add(this.grpConfContra);
            this.groupBox1.Controls.Add(this.grpContra);
            this.groupBox1.Controls.Add(this.grpBoxUsuario);
            this.groupBox1.Controls.Add(this.grpApellido);
            this.groupBox1.Controls.Add(this.grpBoxNombre);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(236, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1250, 583);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrarse";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // grpGenero
            // 
            this.grpGenero.BackColor = System.Drawing.SystemColors.HighlightText;
            this.grpGenero.Controls.Add(this.rdbtnH);
            this.grpGenero.Controls.Add(this.rdbtnM);
            this.grpGenero.Enabled = false;
            this.grpGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGenero.Location = new System.Drawing.Point(184, 439);
            this.grpGenero.Name = "grpGenero";
            this.grpGenero.Size = new System.Drawing.Size(943, 74);
            this.grpGenero.TabIndex = 22;
            this.grpGenero.TabStop = false;
            this.grpGenero.Text = "Género";
            // 
            // rdbtnH
            // 
            this.rdbtnH.AutoSize = true;
            this.rdbtnH.Enabled = false;
            this.rdbtnH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnH.Location = new System.Drawing.Point(216, 22);
            this.rdbtnH.Name = "rdbtnH";
            this.rdbtnH.Size = new System.Drawing.Size(121, 33);
            this.rdbtnH.TabIndex = 24;
            this.rdbtnH.TabStop = true;
            this.rdbtnH.Text = "Hombre";
            this.rdbtnH.UseVisualStyleBackColor = true;
            this.rdbtnH.CheckedChanged += new System.EventHandler(this.rdbtnH_CheckedChanged);
            // 
            // rdbtnM
            // 
            this.rdbtnM.AutoSize = true;
            this.rdbtnM.Enabled = false;
            this.rdbtnM.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnM.Location = new System.Drawing.Point(530, 22);
            this.rdbtnM.Name = "rdbtnM";
            this.rdbtnM.Size = new System.Drawing.Size(95, 33);
            this.rdbtnM.TabIndex = 25;
            this.rdbtnM.TabStop = true;
            this.rdbtnM.Text = "Mujer";
            this.rdbtnM.UseVisualStyleBackColor = true;
            this.rdbtnM.CheckedChanged += new System.EventHandler(this.rdbtnM_CheckedChanged);
            // 
            // checkBoxContra
            // 
            this.checkBoxContra.AutoSize = true;
            this.checkBoxContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxContra.Location = new System.Drawing.Point(184, 374);
            this.checkBoxContra.Name = "checkBoxContra";
            this.checkBoxContra.Size = new System.Drawing.Size(220, 29);
            this.checkBoxContra.TabIndex = 23;
            this.checkBoxContra.Text = "Mostrar contraseña";
            this.checkBoxContra.UseVisualStyleBackColor = true;
            this.checkBoxContra.CheckedChanged += new System.EventHandler(this.checkBoxContra_CheckedChanged);
            // 
            // grpConfContra
            // 
            this.grpConfContra.BackColor = System.Drawing.SystemColors.HighlightText;
            this.grpConfContra.Controls.Add(this.txtConFContra);
            this.grpConfContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpConfContra.Location = new System.Drawing.Point(684, 294);
            this.grpConfContra.Name = "grpConfContra";
            this.grpConfContra.Size = new System.Drawing.Size(458, 74);
            this.grpConfContra.TabIndex = 22;
            this.grpConfContra.TabStop = false;
            this.grpConfContra.Text = "Confirmar contraseña";
            // 
            // txtConFContra
            // 
            this.txtConFContra.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtConFContra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConFContra.Enabled = false;
            this.txtConFContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConFContra.Location = new System.Drawing.Point(10, 37);
            this.txtConFContra.Name = "txtConFContra";
            this.txtConFContra.PasswordChar = '*';
            this.txtConFContra.Size = new System.Drawing.Size(442, 27);
            this.txtConFContra.TabIndex = 9;
            this.txtConFContra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConFContra_KeyPress);
            // 
            // grpContra
            // 
            this.grpContra.BackColor = System.Drawing.SystemColors.HighlightText;
            this.grpContra.Controls.Add(this.txtContra);
            this.grpContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpContra.Location = new System.Drawing.Point(184, 294);
            this.grpContra.Name = "grpContra";
            this.grpContra.Size = new System.Drawing.Size(458, 74);
            this.grpContra.TabIndex = 21;
            this.grpContra.TabStop = false;
            this.grpContra.Text = "Contraseña";
            // 
            // txtContra
            // 
            this.txtContra.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtContra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContra.Enabled = false;
            this.txtContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContra.Location = new System.Drawing.Point(15, 37);
            this.txtContra.Name = "txtContra";
            this.txtContra.PasswordChar = '*';
            this.txtContra.Size = new System.Drawing.Size(437, 27);
            this.txtContra.TabIndex = 9;
            this.txtContra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContra_KeyPress);
            // 
            // grpBoxUsuario
            // 
            this.grpBoxUsuario.BackColor = System.Drawing.SystemColors.HighlightText;
            this.grpBoxUsuario.Controls.Add(this.txtUsuario);
            this.grpBoxUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxUsuario.Location = new System.Drawing.Point(184, 192);
            this.grpBoxUsuario.Name = "grpBoxUsuario";
            this.grpBoxUsuario.Size = new System.Drawing.Size(958, 74);
            this.grpBoxUsuario.TabIndex = 21;
            this.grpBoxUsuario.TabStop = false;
            this.grpBoxUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(15, 37);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(937, 27);
            this.txtUsuario.TabIndex = 9;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // grpApellido
            // 
            this.grpApellido.BackColor = System.Drawing.SystemColors.HighlightText;
            this.grpApellido.Controls.Add(this.txtApellido);
            this.grpApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpApellido.Location = new System.Drawing.Point(684, 90);
            this.grpApellido.Name = "grpApellido";
            this.grpApellido.Size = new System.Drawing.Size(458, 74);
            this.grpApellido.TabIndex = 21;
            this.grpApellido.TabStop = false;
            this.grpApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellido.Enabled = false;
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(10, 37);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(442, 27);
            this.txtApellido.TabIndex = 9;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // grpBoxNombre
            // 
            this.grpBoxNombre.BackColor = System.Drawing.SystemColors.HighlightText;
            this.grpBoxNombre.Controls.Add(this.txtNombre);
            this.grpBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxNombre.Location = new System.Drawing.Point(184, 90);
            this.grpBoxNombre.Name = "grpBoxNombre";
            this.grpBoxNombre.Size = new System.Drawing.Size(458, 74);
            this.grpBoxNombre.TabIndex = 20;
            this.grpBoxNombre.TabStop = false;
            this.grpBoxNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(15, 37);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(437, 27);
            this.txtNombre.TabIndex = 9;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // panelRoot
            // 
            this.panelRoot.Controls.Add(this.lbl_resp);
            this.panelRoot.Controls.Add(this.btnContinuarRot);
            this.panelRoot.Controls.Add(this.gpBoxCaracteresroot);
            this.panelRoot.Controls.Add(this.btnCambiarImage);
            this.panelRoot.Controls.Add(this.pbxImageRobot);
            this.panelRoot.Location = new System.Drawing.Point(172, 127);
            this.panelRoot.Name = "panelRoot";
            this.panelRoot.Size = new System.Drawing.Size(383, 462);
            this.panelRoot.TabIndex = 24;
            this.panelRoot.Visible = false;
            // 
            // btnContinuarRot
            // 
            this.btnContinuarRot.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnContinuarRot.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuarRot.Location = new System.Drawing.Point(96, 398);
            this.btnContinuarRot.Name = "btnContinuarRot";
            this.btnContinuarRot.Size = new System.Drawing.Size(186, 48);
            this.btnContinuarRot.TabIndex = 25;
            this.btnContinuarRot.Text = "Continuar";
            this.btnContinuarRot.UseVisualStyleBackColor = false;
            this.btnContinuarRot.Visible = false;
            this.btnContinuarRot.Click += new System.EventHandler(this.btnContinuarRot_Click);
            // 
            // gpBoxCaracteresroot
            // 
            this.gpBoxCaracteresroot.BackColor = System.Drawing.SystemColors.HighlightText;
            this.gpBoxCaracteresroot.Controls.Add(this.txtIngreCaracteresRoot);
            this.gpBoxCaracteresroot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpBoxCaracteresroot.Location = new System.Drawing.Point(36, 286);
            this.gpBoxCaracteresroot.Name = "gpBoxCaracteresroot";
            this.gpBoxCaracteresroot.Size = new System.Drawing.Size(327, 57);
            this.gpBoxCaracteresroot.TabIndex = 24;
            this.gpBoxCaracteresroot.TabStop = false;
            this.gpBoxCaracteresroot.Text = "Ingrese los caracteres anteriores";
            this.gpBoxCaracteresroot.Visible = false;
            // 
            // txtIngreCaracteresRoot
            // 
            this.txtIngreCaracteresRoot.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtIngreCaracteresRoot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIngreCaracteresRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngreCaracteresRoot.Location = new System.Drawing.Point(20, 26);
            this.txtIngreCaracteresRoot.Name = "txtIngreCaracteresRoot";
            this.txtIngreCaracteresRoot.Size = new System.Drawing.Size(301, 20);
            this.txtIngreCaracteresRoot.TabIndex = 9;
            this.txtIngreCaracteresRoot.Visible = false;
            // 
            // btnCambiarImage
            // 
            this.btnCambiarImage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCambiarImage.Location = new System.Drawing.Point(64, 204);
            this.btnCambiarImage.Name = "btnCambiarImage";
            this.btnCambiarImage.Size = new System.Drawing.Size(269, 48);
            this.btnCambiarImage.TabIndex = 1;
            this.btnCambiarImage.Text = "Cambiar Imagen";
            this.btnCambiarImage.UseVisualStyleBackColor = false;
            this.btnCambiarImage.Visible = false;
            this.btnCambiarImage.Click += new System.EventHandler(this.btnCambiarImage_Click);
            // 
            // pbxImageRobot
            // 
            this.pbxImageRobot.Image = ((System.Drawing.Image)(resources.GetObject("pbxImageRobot.Image")));
            this.pbxImageRobot.Location = new System.Drawing.Point(36, 18);
            this.pbxImageRobot.Name = "pbxImageRobot";
            this.pbxImageRobot.Size = new System.Drawing.Size(327, 180);
            this.pbxImageRobot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImageRobot.TabIndex = 0;
            this.pbxImageRobot.TabStop = false;
            this.pbxImageRobot.Visible = false;
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnContinuar.Enabled = false;
            this.btnContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.Location = new System.Drawing.Point(750, 665);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(206, 58);
            this.btnContinuar.TabIndex = 10;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // checkBoxRobot
            // 
            this.checkBoxRobot.AutoSize = true;
            this.checkBoxRobot.Enabled = false;
            this.checkBoxRobot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRobot.Location = new System.Drawing.Point(291, 640);
            this.checkBoxRobot.Name = "checkBoxRobot";
            this.checkBoxRobot.Size = new System.Drawing.Size(186, 29);
            this.checkBoxRobot.TabIndex = 24;
            this.checkBoxRobot.Text = "No soy un robot";
            this.checkBoxRobot.UseVisualStyleBackColor = true;
            this.checkBoxRobot.CheckedChanged += new System.EventHandler(this.checkBoxRobot_CheckedChanged);
            // 
            // lbl_resp
            // 
            this.lbl_resp.AutoSize = true;
            this.lbl_resp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resp.Location = new System.Drawing.Point(151, 360);
            this.lbl_resp.Name = "lbl_resp";
            this.lbl_resp.Size = new System.Drawing.Size(0, 25);
            this.lbl_resp.TabIndex = 26;
            // 
            // FrmRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1785, 765);
            this.Controls.Add(this.panelRoot);
            this.Controls.Add(this.checkBoxRobot);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmRegistrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRegistrar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpGenero.ResumeLayout(false);
            this.grpGenero.PerformLayout();
            this.grpConfContra.ResumeLayout(false);
            this.grpConfContra.PerformLayout();
            this.grpContra.ResumeLayout(false);
            this.grpContra.PerformLayout();
            this.grpBoxUsuario.ResumeLayout(false);
            this.grpBoxUsuario.PerformLayout();
            this.grpApellido.ResumeLayout(false);
            this.grpApellido.PerformLayout();
            this.grpBoxNombre.ResumeLayout(false);
            this.grpBoxNombre.PerformLayout();
            this.panelRoot.ResumeLayout(false);
            this.panelRoot.PerformLayout();
            this.gpBoxCaracteresroot.ResumeLayout(false);
            this.gpBoxCaracteresroot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImageRobot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.GroupBox grpGenero;
        private System.Windows.Forms.RadioButton rdbtnH;
        private System.Windows.Forms.RadioButton rdbtnM;
        private System.Windows.Forms.CheckBox checkBoxContra;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.CheckBox checkBoxRobot;
        private System.Windows.Forms.Panel panelRoot;
        private System.Windows.Forms.GroupBox gpBoxCaracteresroot;
        private System.Windows.Forms.TextBox txtIngreCaracteresRoot;
        private System.Windows.Forms.Button btnCambiarImage;
        private System.Windows.Forms.PictureBox pbxImageRobot;
        private System.Windows.Forms.Button btnContinuarRot;
        private System.Windows.Forms.Label lbl_resp;
    }
}