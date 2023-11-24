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
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Título del video musical:";
            // 
            // txtTituloVideo
            // 
            this.txtTituloVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTituloVideo.Location = new System.Drawing.Point(401, 37);
            this.txtTituloVideo.Name = "txtTituloVideo";
            this.txtTituloVideo.Size = new System.Drawing.Size(206, 34);
            this.txtTituloVideo.TabIndex = 3;
            this.txtTituloVideo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTituloVideo_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Duración del Video:";
            // 
            // txtProductora
            // 
            this.txtProductora.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductora.Location = new System.Drawing.Point(401, 204);
            this.txtProductora.Name = "txtProductora";
            this.txtProductora.Size = new System.Drawing.Size(206, 34);
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
            this.groupBox3.Location = new System.Drawing.Point(765, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(721, 424);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos del video musical";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(165, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 29);
            this.label3.TabIndex = 22;
            this.label3.Text = "Colaboraciones:";
            // 
            // txtColaboraciones
            // 
            this.txtColaboraciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColaboraciones.Location = new System.Drawing.Point(401, 260);
            this.txtColaboraciones.Name = "txtColaboraciones";
            this.txtColaboraciones.Size = new System.Drawing.Size(206, 34);
            this.txtColaboraciones.TabIndex = 21;
            this.txtColaboraciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtColaboraciones_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "Discografía:";
            // 
            // txtDiscografia
            // 
            this.txtDiscografia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscografia.Location = new System.Drawing.Point(401, 147);
            this.txtDiscografia.Name = "txtDiscografia";
            this.txtDiscografia.Size = new System.Drawing.Size(206, 34);
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
            this.cmbGeneroVideo.Location = new System.Drawing.Point(401, 91);
            this.cmbGeneroVideo.Name = "cmbGeneroVideo";
            this.cmbGeneroVideo.Size = new System.Drawing.Size(206, 37);
            this.cmbGeneroVideo.TabIndex = 18;
            this.cmbGeneroVideo.SelectedIndexChanged += new System.EventHandler(this.cmbGeneroVideo_SelectedIndexChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(219, 377);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(388, 34);
            this.txtDescripcion.TabIndex = 15;
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcion_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(43, 380);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(159, 29);
            this.label12.TabIndex = 14;
            this.label12.Text = "Descripción:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(141, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(228, 29);
            this.label9.TabIndex = 11;
            this.label9.Text = "Director del video:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(221, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "Productora:";
            // 
            // txtDirectorVideo
            // 
            this.txtDirectorVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirectorVideo.Location = new System.Drawing.Point(401, 318);
            this.txtDirectorVideo.Name = "txtDirectorVideo";
            this.txtDirectorVideo.Size = new System.Drawing.Size(206, 34);
            this.txtDirectorVideo.TabIndex = 8;
            this.txtDirectorVideo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDirectorVideo_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(262, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Género:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(1166, 639);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(162, 62);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(1167, 510);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(161, 59);
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
            this.groupBox2.Location = new System.Drawing.Point(120, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(527, 292);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Artista";
            // 
            // txtGenerosArtista
            // 
            this.txtGenerosArtista.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenerosArtista.Location = new System.Drawing.Point(293, 180);
            this.txtGenerosArtista.Name = "txtGenerosArtista";
            this.txtGenerosArtista.Size = new System.Drawing.Size(203, 34);
            this.txtGenerosArtista.TabIndex = 19;
            this.txtGenerosArtista.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGenerosArtista_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(129, 180);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 29);
            this.label11.TabIndex = 18;
            this.label11.Text = "Género(s):";
            // 
            // txtPeriodoActividad
            // 
            this.txtPeriodoActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeriodoActividad.Location = new System.Drawing.Point(293, 120);
            this.txtPeriodoActividad.Name = "txtPeriodoActividad";
            this.txtPeriodoActividad.Size = new System.Drawing.Size(203, 34);
            this.txtPeriodoActividad.TabIndex = 16;
            this.txtPeriodoActividad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeriodoActividad_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(261, 29);
            this.label10.TabIndex = 15;
            this.label10.Text = "Periodo de actividad:";
            // 
            // txtPaisOrigen
            // 
            this.txtPaisOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaisOrigen.Location = new System.Drawing.Point(293, 235);
            this.txtPaisOrigen.Name = "txtPaisOrigen";
            this.txtPaisOrigen.Size = new System.Drawing.Size(203, 34);
            this.txtPaisOrigen.TabIndex = 14;
            this.txtPaisOrigen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaisOrigen_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(72, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 29);
            this.label8.TabIndex = 13;
            this.label8.Text = "País de Origen:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(293, 59);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(203, 34);
            this.txtNombre.TabIndex = 12;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(160, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 29);
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
            this.groupBox4.Location = new System.Drawing.Point(120, 457);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(823, 295);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos Adicionales";
            // 
            // dateTimeDuracion
            // 
            this.dateTimeDuracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeDuracion.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimeDuracion.Location = new System.Drawing.Point(305, 33);
            this.dateTimeDuracion.Name = "dateTimeDuracion";
            this.dateTimeDuracion.ShowUpDown = true;
            this.dateTimeDuracion.Size = new System.Drawing.Size(497, 34);
            this.dateTimeDuracion.TabIndex = 23;
            this.dateTimeDuracion.Value = new System.DateTime(2023, 11, 24, 17, 14, 0, 0);
            this.dateTimeDuracion.ValueChanged += new System.EventHandler(this.dateTimeDuracion_ValueChanged);
            // 
            // txtLink
            // 
            this.txtLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLink.Location = new System.Drawing.Point(305, 225);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(497, 34);
            this.txtLink.TabIndex = 21;
            this.txtLink.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLink_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(112, 228);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(172, 29);
            this.label15.TabIndex = 22;
            this.label15.Text = "Link del Video:";
            // 
            // dateTimeFechaPublicacion
            // 
            this.dateTimeFechaPublicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeFechaPublicacion.Location = new System.Drawing.Point(305, 99);
            this.dateTimeFechaPublicacion.Name = "dateTimeFechaPublicacion";
            this.dateTimeFechaPublicacion.Size = new System.Drawing.Size(497, 34);
            this.dateTimeFechaPublicacion.TabIndex = 20;
            this.dateTimeFechaPublicacion.ValueChanged += new System.EventHandler(this.dateTimeFechaPublicacion_ValueChanged);
            // 
            // txtNumeroVisitas
            // 
            this.txtNumeroVisitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroVisitas.Location = new System.Drawing.Point(305, 162);
            this.txtNumeroVisitas.Name = "txtNumeroVisitas";
            this.txtNumeroVisitas.Size = new System.Drawing.Size(497, 34);
            this.txtNumeroVisitas.TabIndex = 17;
            this.txtNumeroVisitas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroVisitas_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(33, 104);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(251, 29);
            this.label14.TabIndex = 18;
            this.label14.Text = "Fecha de Publicación:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(72, 165);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(212, 29);
            this.label13.TabIndex = 17;
            this.label13.Text = "Número de visitas:";
            // 
            // lblTDatos
            // 
            this.lblTDatos.AutoSize = true;
            this.lblTDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTDatos.Location = new System.Drawing.Point(190, 9);
            this.lblTDatos.Name = "lblTDatos";
            this.lblTDatos.Size = new System.Drawing.Size(413, 38);
            this.lblTDatos.TabIndex = 14;
            this.lblTDatos.Text = "DATOS DE LOS VIDEOS";
            // 
            // FrmIngresarDatosVideos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1785, 787);
            this.Controls.Add(this.lblTDatos);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.groupBox3);
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
    }
}