namespace WinAppProyectoG1
{
    partial class FrmIngresarDatosVideos
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtTituloVideo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProductora = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtColaboraciones = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiscografia = new System.Windows.Forms.TextBox();
            this.cmbGeneroVideo = new System.Windows.Forms.ComboBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDirectorVideo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtGenerosArtista = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPeriodoActividad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPaisOrigen = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dateTimeDuracion = new System.Windows.Forms.DateTimePicker();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dateTimeFechaPublicacion = new System.Windows.Forms.DateTimePicker();
            this.txtNumeroVisitas = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblTDatos = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NomC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GCantante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.POC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TCancion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GCancion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direc_Video = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DuracionV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FPublicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LinkV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Título del video musical:";
            // 
            // txtTituloVideo
            // 
            this.txtTituloVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTituloVideo.Location = new System.Drawing.Point(301, 30);
            this.txtTituloVideo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTituloVideo.Name = "txtTituloVideo";
            this.txtTituloVideo.Size = new System.Drawing.Size(156, 28);
            this.txtTituloVideo.TabIndex = 3;
            this.txtTituloVideo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTituloVideo_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Duración del Video:";
            // 
            // txtProductora
            // 
            this.txtProductora.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductora.Location = new System.Drawing.Point(301, 166);
            this.txtProductora.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProductora.Name = "txtProductora";
            this.txtProductora.Size = new System.Drawing.Size(156, 28);
            this.txtProductora.TabIndex = 6;
            this.txtProductora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductora_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtColaboraciones);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtDiscografia);
            this.groupBox3.Controls.Add(this.cmbGeneroVideo);
            this.groupBox3.Controls.Add(this.txtDescripcion);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtDirectorVideo);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtProductora);
            this.groupBox3.Controls.Add(this.txtTituloVideo);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(574, 4);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(541, 344);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos del video musical";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(124, 215);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 24);
            this.label3.TabIndex = 22;
            this.label3.Text = "Colaboraciones:";
            // 
            // txtColaboraciones
            // 
            this.txtColaboraciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColaboraciones.Location = new System.Drawing.Point(301, 211);
            this.txtColaboraciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtColaboraciones.Name = "txtColaboraciones";
            this.txtColaboraciones.Size = new System.Drawing.Size(156, 28);
            this.txtColaboraciones.TabIndex = 21;
            this.txtColaboraciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtColaboraciones_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 124);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Discografía:";
            // 
            // txtDiscografia
            // 
            this.txtDiscografia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscografia.Location = new System.Drawing.Point(301, 119);
            this.txtDiscografia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDiscografia.Name = "txtDiscografia";
            this.txtDiscografia.Size = new System.Drawing.Size(156, 28);
            this.txtDiscografia.TabIndex = 19;
            this.txtDiscografia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscografia_KeyPress);
            // 
            // cmbGeneroVideo
            // 
            this.cmbGeneroVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGeneroVideo.FormattingEnabled = true;
            this.cmbGeneroVideo.Items.AddRange(new object[] {
            "rock ",
            "reggae"});
            this.cmbGeneroVideo.Location = new System.Drawing.Point(301, 74);
            this.cmbGeneroVideo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbGeneroVideo.Name = "cmbGeneroVideo";
            this.cmbGeneroVideo.Size = new System.Drawing.Size(156, 30);
            this.cmbGeneroVideo.TabIndex = 18;
            this.cmbGeneroVideo.SelectedIndexChanged += new System.EventHandler(this.cmbGeneroVideo_SelectedIndexChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(164, 306);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(292, 28);
            this.txtDescripcion.TabIndex = 15;
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcion_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(32, 309);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 24);
            this.label12.TabIndex = 14;
            this.label12.Text = "Descripción:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(106, 261);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 24);
            this.label9.TabIndex = 11;
            this.label9.Text = "Director del video:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(166, 168);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Productora:";
            // 
            // txtDirectorVideo
            // 
            this.txtDirectorVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirectorVideo.Location = new System.Drawing.Point(301, 258);
            this.txtDirectorVideo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDirectorVideo.Name = "txtDirectorVideo";
            this.txtDirectorVideo.Size = new System.Drawing.Size(156, 28);
            this.txtDirectorVideo.TabIndex = 8;
            this.txtDirectorVideo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDirectorVideo_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(196, 80);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Género:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(874, 519);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(122, 50);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(875, 414);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(121, 48);
            this.btnIngresar.TabIndex = 10;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtGenerosArtista);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtPeriodoActividad);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtPaisOrigen);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(90, 84);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(395, 237);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Artista";
            // 
            // txtGenerosArtista
            // 
            this.txtGenerosArtista.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenerosArtista.Location = new System.Drawing.Point(220, 146);
            this.txtGenerosArtista.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGenerosArtista.Name = "txtGenerosArtista";
            this.txtGenerosArtista.Size = new System.Drawing.Size(153, 28);
            this.txtGenerosArtista.TabIndex = 19;
            this.txtGenerosArtista.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGenerosArtista_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(97, 146);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 24);
            this.label11.TabIndex = 18;
            this.label11.Text = "Género(s):";
            // 
            // txtPeriodoActividad
            // 
            this.txtPeriodoActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeriodoActividad.Location = new System.Drawing.Point(220, 98);
            this.txtPeriodoActividad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPeriodoActividad.Name = "txtPeriodoActividad";
            this.txtPeriodoActividad.Size = new System.Drawing.Size(153, 28);
            this.txtPeriodoActividad.TabIndex = 16;
            this.txtPeriodoActividad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeriodoActividad_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 102);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(207, 24);
            this.label10.TabIndex = 15;
            this.label10.Text = "Periodo de actividad:";
            // 
            // txtPaisOrigen
            // 
            this.txtPaisOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaisOrigen.Location = new System.Drawing.Point(220, 191);
            this.txtPaisOrigen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPaisOrigen.Name = "txtPaisOrigen";
            this.txtPaisOrigen.Size = new System.Drawing.Size(153, 28);
            this.txtPaisOrigen.TabIndex = 14;
            this.txtPaisOrigen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaisOrigen_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(54, 193);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 24);
            this.label8.TabIndex = 13;
            this.label8.Text = "País de Origen:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(220, 48);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(153, 28);
            this.txtNombre.TabIndex = 12;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(120, 50);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nombre:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dateTimeDuracion);
            this.groupBox4.Controls.Add(this.txtLink);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.dateTimeFechaPublicacion);
            this.groupBox4.Controls.Add(this.txtNumeroVisitas);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(90, 371);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(617, 240);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos Adicionales";
            // 
            // dateTimeDuracion
            // 
            this.dateTimeDuracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeDuracion.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimeDuracion.Location = new System.Drawing.Point(229, 27);
            this.dateTimeDuracion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimeDuracion.Name = "dateTimeDuracion";
            this.dateTimeDuracion.ShowUpDown = true;
            this.dateTimeDuracion.Size = new System.Drawing.Size(374, 28);
            this.dateTimeDuracion.TabIndex = 23;
            this.dateTimeDuracion.Value = new System.DateTime(2023, 11, 24, 17, 14, 0, 0);
            this.dateTimeDuracion.ValueChanged += new System.EventHandler(this.dateTimeDuracion_ValueChanged);
            // 
            // txtLink
            // 
            this.txtLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLink.Location = new System.Drawing.Point(229, 183);
            this.txtLink.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(374, 28);
            this.txtLink.TabIndex = 21;
            this.txtLink.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLink_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(84, 185);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(135, 24);
            this.label15.TabIndex = 22;
            this.label15.Text = "Link del Video:";
            // 
            // dateTimeFechaPublicacion
            // 
            this.dateTimeFechaPublicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeFechaPublicacion.Location = new System.Drawing.Point(229, 80);
            this.dateTimeFechaPublicacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimeFechaPublicacion.Name = "dateTimeFechaPublicacion";
            this.dateTimeFechaPublicacion.Size = new System.Drawing.Size(374, 28);
            this.dateTimeFechaPublicacion.TabIndex = 20;
            this.dateTimeFechaPublicacion.ValueChanged += new System.EventHandler(this.dateTimeFechaPublicacion_ValueChanged);
            // 
            // txtNumeroVisitas
            // 
            this.txtNumeroVisitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroVisitas.Location = new System.Drawing.Point(229, 132);
            this.txtNumeroVisitas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumeroVisitas.Name = "txtNumeroVisitas";
            this.txtNumeroVisitas.Size = new System.Drawing.Size(374, 28);
            this.txtNumeroVisitas.TabIndex = 17;
            this.txtNumeroVisitas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroVisitas_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(25, 84);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(199, 24);
            this.label14.TabIndex = 18;
            this.label14.Text = "Fecha de Publicación:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(54, 134);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(165, 24);
            this.label13.TabIndex = 17;
            this.label13.Text = "Número de visitas:";
            // 
            // lblTDatos
            // 
            this.lblTDatos.AutoSize = true;
            this.lblTDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTDatos.Location = new System.Drawing.Point(142, 7);
            this.lblTDatos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTDatos.Name = "lblTDatos";
            this.lblTDatos.Size = new System.Drawing.Size(343, 31);
            this.lblTDatos.TabIndex = 14;
            this.lblTDatos.Text = "DATOS DE LOS VIDEOS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomC,
            this.Column1,
            this.GCantante,
            this.POC,
            this.TCancion,
            this.GCancion,
            this.Column2,
            this.Column3,
            this.Direc_Video,
            this.Descrip,
            this.DuracionV,
            this.FPublicacion,
            this.Column4,
            this.LinkV});
            this.dataGridView1.Location = new System.Drawing.Point(-14, 637);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1086, 425);
            this.dataGridView1.TabIndex = 15;
            // 
            // NomC
            // 
            this.NomC.HeaderText = "Nombre del artista";
            this.NomC.MinimumWidth = 6;
            this.NomC.Name = "NomC";
            this.NomC.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Periodo de actividad";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // GCantante
            // 
            this.GCantante.HeaderText = "Género(s):";
            this.GCantante.MinimumWidth = 6;
            this.GCantante.Name = "GCantante";
            this.GCantante.Width = 125;
            // 
            // POC
            // 
            this.POC.HeaderText = "País de origen";
            this.POC.MinimumWidth = 6;
            this.POC.Name = "POC";
            this.POC.Width = 125;
            // 
            // TCancion
            // 
            this.TCancion.HeaderText = "Título del video musical";
            this.TCancion.MinimumWidth = 6;
            this.TCancion.Name = "TCancion";
            this.TCancion.Width = 125;
            // 
            // GCancion
            // 
            this.GCancion.HeaderText = "Género del video musical";
            this.GCancion.MinimumWidth = 6;
            this.GCancion.Name = "GCancion";
            this.GCancion.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Discografía";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Colaboraciones";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Direc_Video
            // 
            this.Direc_Video.HeaderText = "Director del video";
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
            this.DuracionV.HeaderText = "Duración del video";
            this.DuracionV.MinimumWidth = 6;
            this.DuracionV.Name = "DuracionV";
            this.DuracionV.Width = 125;
            // 
            // FPublicacion
            // 
            this.FPublicacion.HeaderText = "Fecha de publicación";
            this.FPublicacion.MinimumWidth = 6;
            this.FPublicacion.Name = "FPublicacion";
            this.FPublicacion.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Número de visitas";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // LinkV
            // 
            this.LinkV.HeaderText = "Link del Video";
            this.LinkV.MinimumWidth = 6;
            this.LinkV.Name = "LinkV";
            this.LinkV.Width = 125;
            // 
            // FrmIngresarDatosVideos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 675);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTDatos);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmIngresarDatosVideos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos de videos";
            this.Load += new System.EventHandler(this.FrmIngresarDatosVideos_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTituloVideo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProductora;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDirectorVideo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPeriodoActividad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPaisOrigen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtNumeroVisitas;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimeFechaPublicacion;
        private System.Windows.Forms.ComboBox cmbGeneroVideo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtGenerosArtista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiscografia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtColaboraciones;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblTDatos;
        private System.Windows.Forms.DateTimePicker dateTimeDuracion;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn GCantante;
        private System.Windows.Forms.DataGridViewTextBoxColumn POC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TCancion;
        private System.Windows.Forms.DataGridViewTextBoxColumn GCancion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direc_Video;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn DuracionV;
        private System.Windows.Forms.DataGridViewTextBoxColumn FPublicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn LinkV;
    }
}