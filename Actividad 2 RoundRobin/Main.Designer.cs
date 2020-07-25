namespace Actividad_2_RoundRobin
{
    partial class Main
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
            this.TxtNumProcesos = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ListBoxNuevo = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ListBoxListo = new System.Windows.Forms.ListBox();
            this.ListBoxEjecucion = new System.Windows.Forms.ListBox();
            this.ListBoxTerminado = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LbTiempo = new System.Windows.Forms.Label();
            this.LbIdle = new System.Windows.Forms.Label();
            this.LbOcupado = new System.Windows.Forms.Label();
            this.LbRespuestaMedia = new System.Windows.Forms.Label();
            this.LbRespuestaMax = new System.Windows.Forms.Label();
            this.LbRespuestaMin = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.LbRespuestaDesviacion = new System.Windows.Forms.Label();
            this.LbRetornoDesviacion = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.LbRetornoMedio = new System.Windows.Forms.Label();
            this.LbRetornoMax = new System.Windows.Forms.Label();
            this.LbRetornoMin = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.TablaBloqueados = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TablaBloqueados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de Procesos:";
            // 
            // TxtNumProcesos
            // 
            this.TxtNumProcesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumProcesos.Location = new System.Drawing.Point(213, 16);
            this.TxtNumProcesos.Name = "TxtNumProcesos";
            this.TxtNumProcesos.Size = new System.Drawing.Size(56, 29);
            this.TxtNumProcesos.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(313, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Iniciar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button1_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(309, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ejecucion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(555, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Bloqueado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Aqua;
            this.label5.Location = new System.Drawing.Point(327, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Listo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(797, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Terminado";
            // 
            // ListBoxNuevo
            // 
            this.ListBoxNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxNuevo.FormattingEnabled = true;
            this.ListBoxNuevo.ItemHeight = 20;
            this.ListBoxNuevo.Location = new System.Drawing.Point(16, 96);
            this.ListBoxNuevo.Name = "ListBoxNuevo";
            this.ListBoxNuevo.Size = new System.Drawing.Size(220, 284);
            this.ListBoxNuevo.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(22, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nuevo";
            // 
            // ListBoxListo
            // 
            this.ListBoxListo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxListo.ForeColor = System.Drawing.Color.Aqua;
            this.ListBoxListo.FormattingEnabled = true;
            this.ListBoxListo.ItemHeight = 20;
            this.ListBoxListo.Location = new System.Drawing.Point(255, 96);
            this.ListBoxListo.Name = "ListBoxListo";
            this.ListBoxListo.Size = new System.Drawing.Size(220, 124);
            this.ListBoxListo.TabIndex = 10;
            // 
            // ListBoxEjecucion
            // 
            this.ListBoxEjecucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxEjecucion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ListBoxEjecucion.FormattingEnabled = true;
            this.ListBoxEjecucion.ItemHeight = 20;
            this.ListBoxEjecucion.Location = new System.Drawing.Point(255, 276);
            this.ListBoxEjecucion.Name = "ListBoxEjecucion";
            this.ListBoxEjecucion.Size = new System.Drawing.Size(220, 104);
            this.ListBoxEjecucion.TabIndex = 12;
            // 
            // ListBoxTerminado
            // 
            this.ListBoxTerminado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxTerminado.ForeColor = System.Drawing.Color.Red;
            this.ListBoxTerminado.FormattingEnabled = true;
            this.ListBoxTerminado.ItemHeight = 20;
            this.ListBoxTerminado.Location = new System.Drawing.Point(739, 96);
            this.ListBoxTerminado.Name = "ListBoxTerminado";
            this.ListBoxTerminado.Size = new System.Drawing.Size(220, 284);
            this.ListBoxTerminado.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 407);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "CPU";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 446);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 24);
            this.label8.TabIndex = 15;
            this.label8.Text = "Tiempo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 479);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 24);
            this.label9.TabIndex = 16;
            this.label9.Text = "Idle:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(26, 514);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 24);
            this.label10.TabIndex = 17;
            this.label10.Text = "Ocupado:";
            // 
            // LbTiempo
            // 
            this.LbTiempo.AutoSize = true;
            this.LbTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTiempo.Location = new System.Drawing.Point(127, 446);
            this.LbTiempo.Name = "LbTiempo";
            this.LbTiempo.Size = new System.Drawing.Size(0, 24);
            this.LbTiempo.TabIndex = 18;
            // 
            // LbIdle
            // 
            this.LbIdle.AutoSize = true;
            this.LbIdle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbIdle.Location = new System.Drawing.Point(127, 479);
            this.LbIdle.Name = "LbIdle";
            this.LbIdle.Size = new System.Drawing.Size(0, 24);
            this.LbIdle.TabIndex = 19;
            // 
            // LbOcupado
            // 
            this.LbOcupado.AutoSize = true;
            this.LbOcupado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbOcupado.Location = new System.Drawing.Point(127, 514);
            this.LbOcupado.Name = "LbOcupado";
            this.LbOcupado.Size = new System.Drawing.Size(0, 24);
            this.LbOcupado.TabIndex = 20;
            // 
            // LbRespuestaMedia
            // 
            this.LbRespuestaMedia.AutoSize = true;
            this.LbRespuestaMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbRespuestaMedia.Location = new System.Drawing.Point(352, 514);
            this.LbRespuestaMedia.Name = "LbRespuestaMedia";
            this.LbRespuestaMedia.Size = new System.Drawing.Size(0, 24);
            this.LbRespuestaMedia.TabIndex = 27;
            // 
            // LbRespuestaMax
            // 
            this.LbRespuestaMax.AutoSize = true;
            this.LbRespuestaMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbRespuestaMax.Location = new System.Drawing.Point(352, 479);
            this.LbRespuestaMax.Name = "LbRespuestaMax";
            this.LbRespuestaMax.Size = new System.Drawing.Size(0, 24);
            this.LbRespuestaMax.TabIndex = 26;
            // 
            // LbRespuestaMin
            // 
            this.LbRespuestaMin.AutoSize = true;
            this.LbRespuestaMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbRespuestaMin.Location = new System.Drawing.Point(352, 446);
            this.LbRespuestaMin.Name = "LbRespuestaMin";
            this.LbRespuestaMin.Size = new System.Drawing.Size(0, 24);
            this.LbRespuestaMin.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(251, 514);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 24);
            this.label14.TabIndex = 24;
            this.label14.Text = "Media:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(251, 479);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 24);
            this.label15.TabIndex = 23;
            this.label15.Text = "Max:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(251, 446);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 24);
            this.label16.TabIndex = 22;
            this.label16.Text = "Min:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(251, 407);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(215, 24);
            this.label17.TabIndex = 21;
            this.label17.Text = "Tiempo de Respuesta";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(251, 546);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(186, 24);
            this.label18.TabIndex = 28;
            this.label18.Text = "Desviacion Estandar:";
            // 
            // LbRespuestaDesviacion
            // 
            this.LbRespuestaDesviacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbRespuestaDesviacion.Location = new System.Drawing.Point(456, 546);
            this.LbRespuestaDesviacion.Name = "LbRespuestaDesviacion";
            this.LbRespuestaDesviacion.Size = new System.Drawing.Size(148, 24);
            this.LbRespuestaDesviacion.TabIndex = 29;
            // 
            // LbRetornoDesviacion
            // 
            this.LbRetornoDesviacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbRetornoDesviacion.Location = new System.Drawing.Point(819, 546);
            this.LbRetornoDesviacion.Name = "LbRetornoDesviacion";
            this.LbRetornoDesviacion.Size = new System.Drawing.Size(140, 24);
            this.LbRetornoDesviacion.TabIndex = 38;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(627, 546);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(186, 24);
            this.label12.TabIndex = 37;
            this.label12.Text = "Desviacion Estandar:";
            // 
            // LbRetornoMedio
            // 
            this.LbRetornoMedio.AutoSize = true;
            this.LbRetornoMedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbRetornoMedio.Location = new System.Drawing.Point(728, 514);
            this.LbRetornoMedio.Name = "LbRetornoMedio";
            this.LbRetornoMedio.Size = new System.Drawing.Size(0, 24);
            this.LbRetornoMedio.TabIndex = 36;
            // 
            // LbRetornoMax
            // 
            this.LbRetornoMax.AutoSize = true;
            this.LbRetornoMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbRetornoMax.Location = new System.Drawing.Point(728, 479);
            this.LbRetornoMax.Name = "LbRetornoMax";
            this.LbRetornoMax.Size = new System.Drawing.Size(0, 24);
            this.LbRetornoMax.TabIndex = 35;
            // 
            // LbRetornoMin
            // 
            this.LbRetornoMin.AutoSize = true;
            this.LbRetornoMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbRetornoMin.Location = new System.Drawing.Point(728, 446);
            this.LbRetornoMin.Name = "LbRetornoMin";
            this.LbRetornoMin.Size = new System.Drawing.Size(0, 24);
            this.LbRetornoMin.TabIndex = 34;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(627, 514);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(67, 24);
            this.label21.TabIndex = 33;
            this.label21.Text = "Media:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(627, 479);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(51, 24);
            this.label22.TabIndex = 32;
            this.label22.Text = "Max:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(627, 446);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(46, 24);
            this.label23.TabIndex = 31;
            this.label23.Text = "Min:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(627, 407);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(230, 24);
            this.label24.TabIndex = 30;
            this.label24.Text = "Tiempo de TurnAround";
            // 
            // TablaBloqueados
            // 
            this.TablaBloqueados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaBloqueados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColTiempo});
            this.TablaBloqueados.Location = new System.Drawing.Point(488, 96);
            this.TablaBloqueados.Name = "TablaBloqueados";
            this.TablaBloqueados.Size = new System.Drawing.Size(240, 284);
            this.TablaBloqueados.TabIndex = 39;
            this.TablaBloqueados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaBloqueados_CellClick);
            // 
            // ColID
            // 
            this.ColID.HeaderText = "ID";
            this.ColID.Name = "ColID";
            // 
            // ColTiempo
            // 
            this.ColTiempo.HeaderText = "Tiempo";
            this.ColTiempo.Name = "ColTiempo";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 579);
            this.Controls.Add(this.TablaBloqueados);
            this.Controls.Add(this.LbRetornoDesviacion);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.LbRetornoMedio);
            this.Controls.Add(this.LbRetornoMax);
            this.Controls.Add(this.LbRetornoMin);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.LbRespuestaDesviacion);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.LbRespuestaMedia);
            this.Controls.Add(this.LbRespuestaMax);
            this.Controls.Add(this.LbRespuestaMin);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.LbOcupado);
            this.Controls.Add(this.LbIdle);
            this.Controls.Add(this.LbTiempo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ListBoxTerminado);
            this.Controls.Add(this.ListBoxEjecucion);
            this.Controls.Add(this.ListBoxListo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ListBoxNuevo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtNumProcesos);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Actividad 2 Round Robin";
            ((System.ComponentModel.ISupportInitialize)(this.TablaBloqueados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNumProcesos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox ListBoxNuevo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ListBoxListo;
        private System.Windows.Forms.ListBox ListBoxEjecucion;
        private System.Windows.Forms.ListBox ListBoxTerminado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LbTiempo;
        private System.Windows.Forms.Label LbIdle;
        private System.Windows.Forms.Label LbOcupado;
        private System.Windows.Forms.Label LbRespuestaMedia;
        private System.Windows.Forms.Label LbRespuestaMax;
        private System.Windows.Forms.Label LbRespuestaMin;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label LbRespuestaDesviacion;
        private System.Windows.Forms.Label LbRetornoDesviacion;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label LbRetornoMedio;
        private System.Windows.Forms.Label LbRetornoMax;
        private System.Windows.Forms.Label LbRetornoMin;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.DataGridView TablaBloqueados;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTiempo;
    }
}

