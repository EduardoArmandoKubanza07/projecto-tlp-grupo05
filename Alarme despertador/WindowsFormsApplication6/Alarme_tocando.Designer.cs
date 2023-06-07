namespace WindowsFormsApplication6
{
    partial class Alarme_tocando
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alarme_tocando));
            this.btnDesligar_alarm = new System.Windows.Forms.Button();
            this.lbtime_now = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDesligar_alarm
            // 
            this.btnDesligar_alarm.BackColor = System.Drawing.Color.CadetBlue;
            this.btnDesligar_alarm.FlatAppearance.BorderSize = 0;
            this.btnDesligar_alarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesligar_alarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesligar_alarm.ForeColor = System.Drawing.Color.White;
            this.btnDesligar_alarm.Location = new System.Drawing.Point(65, 177);
            this.btnDesligar_alarm.Name = "btnDesligar_alarm";
            this.btnDesligar_alarm.Size = new System.Drawing.Size(100, 30);
            this.btnDesligar_alarm.TabIndex = 7;
            this.btnDesligar_alarm.Text = "Desligar";
            this.btnDesligar_alarm.UseVisualStyleBackColor = false;
            this.btnDesligar_alarm.Click += new System.EventHandler(this.btnDesligar_alarm_Click);
            // 
            // lbtime_now
            // 
            this.lbtime_now.AutoSize = true;
            this.lbtime_now.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtime_now.ForeColor = System.Drawing.Color.White;
            this.lbtime_now.Location = new System.Drawing.Point(57, 121);
            this.lbtime_now.Name = "lbtime_now";
            this.lbtime_now.Size = new System.Drawing.Size(119, 46);
            this.lbtime_now.TabIndex = 5;
            this.lbtime_now.Text = "00:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Alarme Tocando";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(82, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Alarme_tocando
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(242, 228);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnDesligar_alarm);
            this.Controls.Add(this.lbtime_now);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Alarme_tocando";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alarme_tocando";
            this.Load += new System.EventHandler(this.Alarme_tocando_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDesligar_alarm;
        private System.Windows.Forms.Label lbtime_now;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
    }
}