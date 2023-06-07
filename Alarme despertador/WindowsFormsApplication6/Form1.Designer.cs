namespace WindowsFormsApplication6
{
    partial class Despertador
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Despertador));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.hora = new System.Windows.Forms.Label();
            this.timer_hora = new System.Windows.Forms.Timer(this.components);
            this.AddAlarme = new System.Windows.Forms.Label();
            this.pnAlarme = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.MM = new System.Windows.Forms.TextBox();
            this.HH = new System.Windows.Forms.TextBox();
            this.Lbminuto = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Lbhora = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.timer_alarme = new System.Windows.Forms.Timer(this.components);
            this.pn = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnAlarme.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.hora);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 212);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(63, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // hora
            // 
            this.hora.AutoSize = true;
            this.hora.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hora.ForeColor = System.Drawing.Color.White;
            this.hora.Location = new System.Drawing.Point(3, 128);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(274, 65);
            this.hora.TabIndex = 0;
            this.hora.Text = "00 : 00 : 00";
            this.hora.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer_hora
            // 
            this.timer_hora.Enabled = true;
            this.timer_hora.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AddAlarme
            // 
            this.AddAlarme.AutoSize = true;
            this.AddAlarme.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAlarme.ForeColor = System.Drawing.Color.CadetBlue;
            this.AddAlarme.Location = new System.Drawing.Point(237, 9);
            this.AddAlarme.Name = "AddAlarme";
            this.AddAlarme.Size = new System.Drawing.Size(180, 30);
            this.AddAlarme.TabIndex = 2;
            this.AddAlarme.Text = "Adicionar alarme";
            // 
            // pnAlarme
            // 
            this.pnAlarme.BackColor = System.Drawing.Color.LightGray;
            this.pnAlarme.Controls.Add(this.btnGuardar);
            this.pnAlarme.Controls.Add(this.MM);
            this.pnAlarme.Controls.Add(this.HH);
            this.pnAlarme.Controls.Add(this.Lbminuto);
            this.pnAlarme.Controls.Add(this.label4);
            this.pnAlarme.Controls.Add(this.Lbhora);
            this.pnAlarme.Location = new System.Drawing.Point(240, 44);
            this.pnAlarme.Name = "pnAlarme";
            this.pnAlarme.Size = new System.Drawing.Size(173, 128);
            this.pnAlarme.TabIndex = 3;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.CadetBlue;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(34, 87);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 30);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // MM
            // 
            this.MM.Location = new System.Drawing.Point(103, 48);
            this.MM.MaxLength = 2;
            this.MM.Name = "MM";
            this.MM.Size = new System.Drawing.Size(58, 20);
            this.MM.TabIndex = 4;
            this.MM.TextChanged += new System.EventHandler(this.MM_TextChanged);
            this.MM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MM_KeyPress);
            // 
            // HH
            // 
            this.HH.Location = new System.Drawing.Point(17, 48);
            this.HH.MaxLength = 2;
            this.HH.Name = "HH";
            this.HH.Size = new System.Drawing.Size(58, 20);
            this.HH.TabIndex = 3;
            this.HH.TextChanged += new System.EventHandler(this.HH_TextChanged);
            this.HH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HH_KeyPress);
            // 
            // Lbminuto
            // 
            this.Lbminuto.AutoSize = true;
            this.Lbminuto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbminuto.Location = new System.Drawing.Point(100, 25);
            this.Lbminuto.Name = "Lbminuto";
            this.Lbminuto.Size = new System.Drawing.Size(59, 17);
            this.Lbminuto.TabIndex = 2;
            this.Lbminuto.Text = "Minutos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(81, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = ":";
            // 
            // Lbhora
            // 
            this.Lbhora.AutoSize = true;
            this.Lbhora.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbhora.Location = new System.Drawing.Point(14, 25);
            this.Lbhora.Name = "Lbhora";
            this.Lbhora.Size = new System.Drawing.Size(38, 17);
            this.Lbhora.TabIndex = 0;
            this.Lbhora.Text = "Hora";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(426, 116);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 30);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.Color.White;
            this.btnNovo.Location = new System.Drawing.Point(426, 69);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(80, 30);
            this.btnNovo.TabIndex = 7;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // timer_alarme
            // 
            this.timer_alarme.Enabled = true;
            this.timer_alarme.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pn
            // 
            this.pn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn.Location = new System.Drawing.Point(231, 191);
            this.pn.Name = "pn";
            this.pn.Size = new System.Drawing.Size(287, 21);
            this.pn.TabIndex = 8;
            this.pn.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Despertador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(518, 212);
            this.Controls.Add(this.pn);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pnAlarme);
            this.Controls.Add(this.AddAlarme);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Despertador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alarme";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnAlarme.ResumeLayout(false);
            this.pnAlarme.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label hora;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer_hora;
        private System.Windows.Forms.Label AddAlarme;
        private System.Windows.Forms.Panel pnAlarme;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox MM;
        private System.Windows.Forms.TextBox HH;
        private System.Windows.Forms.Label Lbminuto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Lbhora;
        private System.Windows.Forms.Button btnNovo;
        public int varHH, varMM;
        private System.Windows.Forms.Timer timer_alarme;
        private System.Windows.Forms.Panel pn;
    }
}

