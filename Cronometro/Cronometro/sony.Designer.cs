namespace Cronometro
{
    partial class cronometro
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
            this.lbltempo = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnparar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.circuloprogressivo = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.lblcronometro = new System.Windows.Forms.Label();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.circuloprogressivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltempo
            // 
            this.lbltempo.AutoSize = true;
            this.lbltempo.BackColor = System.Drawing.Color.Transparent;
            this.lbltempo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltempo.ForeColor = System.Drawing.Color.Black;
            this.lbltempo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbltempo.ImageKey = "(none)";
            this.lbltempo.Location = new System.Drawing.Point(31, 67);
            this.lbltempo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltempo.Name = "lbltempo";
            this.lbltempo.Size = new System.Drawing.Size(97, 30);
            this.lbltempo.TabIndex = 0;
            this.lbltempo.Text = "11:11:11";
            this.lbltempo.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.Gray;
            this.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciar.FlatAppearance.BorderSize = 0;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.Black;
            this.btnIniciar.Location = new System.Drawing.Point(7, 324);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(108, 40);
            this.btnIniciar.TabIndex = 1;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnparar
            // 
            this.btnparar.BackColor = System.Drawing.Color.Gray;
            this.btnparar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnparar.FlatAppearance.BorderSize = 0;
            this.btnparar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnparar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnparar.ForeColor = System.Drawing.Color.Black;
            this.btnparar.Location = new System.Drawing.Point(226, 326);
            this.btnparar.Name = "btnparar";
            this.btnparar.Size = new System.Drawing.Size(101, 40);
            this.btnparar.TabIndex = 2;
            this.btnparar.Text = "parar";
            this.btnparar.UseVisualStyleBackColor = false;
            this.btnparar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.BackColor = System.Drawing.Color.Gray;
            this.btnlimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimpar.FlatAppearance.BorderSize = 0;
            this.btnlimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.ForeColor = System.Drawing.Color.Black;
            this.btnlimpar.Location = new System.Drawing.Point(122, 326);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(98, 40);
            this.btnlimpar.TabIndex = 3;
            this.btnlimpar.Text = "limpar";
            this.btnlimpar.UseVisualStyleBackColor = false;
            this.btnlimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // circuloprogressivo
            // 
            this.circuloprogressivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.circuloprogressivo.Controls.Add(this.lbltempo);
            this.circuloprogressivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.circuloprogressivo.FillColor = System.Drawing.Color.Gray;
            this.circuloprogressivo.FillThickness = 15;
            this.circuloprogressivo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.circuloprogressivo.ForeColor = System.Drawing.Color.White;
            this.circuloprogressivo.Location = new System.Drawing.Point(89, 71);
            this.circuloprogressivo.Minimum = 0;
            this.circuloprogressivo.Name = "circuloprogressivo";
            this.circuloprogressivo.ProgressColor = System.Drawing.Color.White;
            this.circuloprogressivo.ProgressColor2 = System.Drawing.Color.Black;
            this.circuloprogressivo.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.circuloprogressivo.ProgressThickness = 15;
            this.circuloprogressivo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.circuloprogressivo.Size = new System.Drawing.Size(162, 162);
            this.circuloprogressivo.TabIndex = 4;
            this.circuloprogressivo.Text = "circuloprogressivo";
            this.circuloprogressivo.Value = 75;
            // 
            // lblcronometro
            // 
            this.lblcronometro.AutoSize = true;
            this.lblcronometro.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcronometro.ForeColor = System.Drawing.Color.Black;
            this.lblcronometro.Location = new System.Drawing.Point(107, 25);
            this.lblcronometro.Name = "lblcronometro";
            this.lblcronometro.Size = new System.Drawing.Size(122, 25);
            this.lblcronometro.TabIndex = 5;
            this.lblcronometro.Text = "Cronômetro";
            this.lblcronometro.Click += new System.EventHandler(this.label2_Click);
            // 
            // cronometro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(334, 377);
            this.Controls.Add(this.lblcronometro);
            this.Controls.Add(this.circuloprogressivo);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnparar);
            this.Controls.Add(this.btnIniciar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "cronometro";
            this.Text = "cronometro";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.circuloprogressivo.ResumeLayout(false);
            this.circuloprogressivo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltempo;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnparar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar circuloprogressivo;
        private System.Windows.Forms.Label lblcronometro;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;

    }
}

