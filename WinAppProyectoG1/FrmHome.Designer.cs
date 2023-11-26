namespace WinAppProyectoG1
{
    partial class FrmHome
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TStrip_Salir = new System.Windows.Forms.ToolStripMenuItem();
            this.videosMusicalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TStrip_IngresarDatosV = new System.Windows.Forms.ToolStripMenuItem();
            this.TStrip_Eliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblNomApe = new System.Windows.Forms.Label();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.videosMusicalesToolStripMenuItem,
            this.listarToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1028, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TStrip_Salir});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // TStrip_Salir
            // 
            this.TStrip_Salir.Name = "TStrip_Salir";
            this.TStrip_Salir.Size = new System.Drawing.Size(121, 30);
            this.TStrip_Salir.Text = "Salir";
            this.TStrip_Salir.Click += new System.EventHandler(this.TStrip_Salir_Click);
            // 
            // videosMusicalesToolStripMenuItem
            // 
            this.videosMusicalesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TStrip_IngresarDatosV,
            this.TStrip_Eliminar,
            this.eliminarToolStripMenuItem,
            this.buscarToolStripMenuItem});
            this.videosMusicalesToolStripMenuItem.Name = "videosMusicalesToolStripMenuItem";
            this.videosMusicalesToolStripMenuItem.Size = new System.Drawing.Size(169, 29);
            this.videosMusicalesToolStripMenuItem.Text = "Videos Musicales";
            // 
            // TStrip_IngresarDatosV
            // 
            this.TStrip_IngresarDatosV.Name = "TStrip_IngresarDatosV";
            this.TStrip_IngresarDatosV.Size = new System.Drawing.Size(180, 30);
            this.TStrip_IngresarDatosV.Text = "Ingresar";
            this.TStrip_IngresarDatosV.Click += new System.EventHandler(this.TStrip_IngresarDatosV_Click);
            // 
            // TStrip_Eliminar
            // 
            this.TStrip_Eliminar.Name = "TStrip_Eliminar";
            this.TStrip_Eliminar.Size = new System.Drawing.Size(180, 30);
            this.TStrip_Eliminar.Text = "Eliminar";
            this.TStrip_Eliminar.Click += new System.EventHandler(this.TStrip_Eliminar_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.eliminarToolStripMenuItem.Text = "Reproducir";
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.listarToolStripMenuItem.Text = "Listar";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(33, 29);
            this.toolStripMenuItem1.Text = "?";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(179, 30);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            // 
            // lblNomApe
            // 
            this.lblNomApe.AutoSize = true;
            this.lblNomApe.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblNomApe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomApe.Location = new System.Drawing.Point(908, 7);
            this.lblNomApe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomApe.Name = "lblNomApe";
            this.lblNomApe.Size = new System.Drawing.Size(17, 24);
            this.lblNomApe.TabIndex = 1;
            this.lblNomApe.Text = "-";
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.buscarToolStripMenuItem.Text = "Buscar";
            this.buscarToolStripMenuItem.Click += new System.EventHandler(this.buscarToolStripMenuItem_Click);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.lblNomApe);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHome";
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TStrip_Salir;
        private System.Windows.Forms.ToolStripMenuItem videosMusicalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TStrip_IngresarDatosV;
        private System.Windows.Forms.ToolStripMenuItem TStrip_Eliminar;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.Label lblNomApe;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
    }
}