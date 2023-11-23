namespace WinAppProyectoG1
{
    partial class FrmEliminarDatosVideo
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NomC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GCantante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TCancion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.POC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GCancion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Productora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direc_Video = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DuracionV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FPublicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LinkV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(745, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eliminar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomC,
            this.GCantante,
            this.TCancion,
            this.POC,
            this.GCancion,
            this.Productora,
            this.Direc_Video,
            this.Descrip,
            this.DuracionV,
            this.FPublicacion,
            this.LinkV});
            this.dataGridView1.Location = new System.Drawing.Point(49, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1428, 499);
            this.dataGridView1.TabIndex = 1;
            // 
            // NomC
            // 
            this.NomC.HeaderText = "Nombre Cantante";
            this.NomC.MinimumWidth = 6;
            this.NomC.Name = "NomC";
            this.NomC.Width = 125;
            // 
            // GCantante
            // 
            this.GCantante.HeaderText = "Género Cantante";
            this.GCantante.MinimumWidth = 6;
            this.GCantante.Name = "GCantante";
            this.GCantante.Width = 125;
            // 
            // TCancion
            // 
            this.TCancion.HeaderText = "Título de la Canción";
            this.TCancion.MinimumWidth = 6;
            this.TCancion.Name = "TCancion";
            this.TCancion.Width = 125;
            // 
            // POC
            // 
            this.POC.HeaderText = "País de Origen Cantante";
            this.POC.MinimumWidth = 6;
            this.POC.Name = "POC";
            this.POC.Width = 125;
            // 
            // GCancion
            // 
            this.GCancion.HeaderText = "Género Canción";
            this.GCancion.MinimumWidth = 6;
            this.GCancion.Name = "GCancion";
            this.GCancion.Width = 125;
            // 
            // Productora
            // 
            this.Productora.HeaderText = "Productora";
            this.Productora.MinimumWidth = 6;
            this.Productora.Name = "Productora";
            this.Productora.Width = 125;
            // 
            // Direc_Video
            // 
            this.Direc_Video.HeaderText = "Director del Video";
            this.Direc_Video.MinimumWidth = 6;
            this.Direc_Video.Name = "Direc_Video";
            this.Direc_Video.Width = 125;
            // 
            // Descrip
            // 
            this.Descrip.HeaderText = "Descripción del video";
            this.Descrip.MinimumWidth = 6;
            this.Descrip.Name = "Descrip";
            this.Descrip.Width = 125;
            // 
            // DuracionV
            // 
            this.DuracionV.HeaderText = "Duración del Video";
            this.DuracionV.MinimumWidth = 6;
            this.DuracionV.Name = "DuracionV";
            this.DuracionV.Width = 125;
            // 
            // FPublicacion
            // 
            this.FPublicacion.HeaderText = "Fecha de Publicación";
            this.FPublicacion.MinimumWidth = 6;
            this.FPublicacion.Name = "FPublicacion";
            this.FPublicacion.Width = 125;
            // 
            // LinkV
            // 
            this.LinkV.HeaderText = "Link del Video";
            this.LinkV.MinimumWidth = 6;
            this.LinkV.Name = "LinkV";
            this.LinkV.Width = 125;
            // 
            // FrmEliminarDatosVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1785, 765);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "FrmEliminarDatosVideo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomC;
        private System.Windows.Forms.DataGridViewTextBoxColumn GCantante;
        private System.Windows.Forms.DataGridViewTextBoxColumn TCancion;
        private System.Windows.Forms.DataGridViewTextBoxColumn POC;
        private System.Windows.Forms.DataGridViewTextBoxColumn GCancion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Productora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direc_Video;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn DuracionV;
        private System.Windows.Forms.DataGridViewTextBoxColumn FPublicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn LinkV;
    }
}