namespace pedra_papel_e_tesoura
{
    partial class wfpPedraPapelTesoura
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
            this.btnPedra = new System.Windows.Forms.Button();
            this.btnPapel = new System.Windows.Forms.Button();
            this.btnTesoura = new System.Windows.Forms.Button();
            this.pictureJogador = new System.Windows.Forms.PictureBox();
            this.pictureComputador = new System.Windows.Forms.PictureBox();
            this.lbldescricaojogador = new System.Windows.Forms.Label();
            this.lblDescricaocomputador = new System.Windows.Forms.Label();
            this.lblpontuacaojogador = new System.Windows.Forms.Label();
            this.lblpontuacaocomputador = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureJogador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureComputador)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPedra
            // 
            this.btnPedra.BackgroundImage = global::pedra_papel_e_tesoura.Properties.Resources.transferir;
            this.btnPedra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPedra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPedra.Location = new System.Drawing.Point(22, 199);
            this.btnPedra.Name = "btnPedra";
            this.btnPedra.Size = new System.Drawing.Size(120, 120);
            this.btnPedra.TabIndex = 0;
            this.btnPedra.Tag = "0";
            this.btnPedra.UseVisualStyleBackColor = true;
            this.btnPedra.Click += new System.EventHandler(this.ClickJogada);
            // 
            // btnPapel
            // 
            this.btnPapel.BackColor = System.Drawing.Color.Black;
            this.btnPapel.BackgroundImage = global::pedra_papel_e_tesoura.Properties.Resources.transferir1;
            this.btnPapel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPapel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPapel.Location = new System.Drawing.Point(218, 199);
            this.btnPapel.Name = "btnPapel";
            this.btnPapel.Size = new System.Drawing.Size(120, 120);
            this.btnPapel.TabIndex = 1;
            this.btnPapel.Tag = "1";
            this.btnPapel.UseVisualStyleBackColor = false;
            this.btnPapel.Click += new System.EventHandler(this.ClickJogada);
            // 
            // btnTesoura
            // 
            this.btnTesoura.BackgroundImage = global::pedra_papel_e_tesoura.Properties.Resources.transferir__2_;
            this.btnTesoura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTesoura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTesoura.Location = new System.Drawing.Point(408, 199);
            this.btnTesoura.Name = "btnTesoura";
            this.btnTesoura.Size = new System.Drawing.Size(120, 120);
            this.btnTesoura.TabIndex = 2;
            this.btnTesoura.Tag = "2";
            this.btnTesoura.UseVisualStyleBackColor = true;
            this.btnTesoura.Click += new System.EventHandler(this.ClickJogada);
            // 
            // pictureJogador
            // 
            this.pictureJogador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureJogador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureJogador.Location = new System.Drawing.Point(12, 31);
            this.pictureJogador.Name = "pictureJogador";
            this.pictureJogador.Size = new System.Drawing.Size(150, 150);
            this.pictureJogador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureJogador.TabIndex = 3;
            this.pictureJogador.TabStop = false;
            // 
            // pictureComputador
            // 
            this.pictureComputador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureComputador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureComputador.Location = new System.Drawing.Point(392, 31);
            this.pictureComputador.Name = "pictureComputador";
            this.pictureComputador.Size = new System.Drawing.Size(150, 150);
            this.pictureComputador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureComputador.TabIndex = 4;
            this.pictureComputador.TabStop = false;
            // 
            // lbldescricaojogador
            // 
            this.lbldescricaojogador.AutoSize = true;
            this.lbldescricaojogador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.lbldescricaojogador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbldescricaojogador.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescricaojogador.Location = new System.Drawing.Point(15, 8);
            this.lbldescricaojogador.Name = "lbldescricaojogador";
            this.lbldescricaojogador.Size = new System.Drawing.Size(66, 20);
            this.lbldescricaojogador.TabIndex = 5;
            this.lbldescricaojogador.Text = "Jogador";
            // 
            // lblDescricaocomputador
            // 
            this.lblDescricaocomputador.AutoSize = true;
            this.lblDescricaocomputador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.lblDescricaocomputador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDescricaocomputador.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricaocomputador.Location = new System.Drawing.Point(390, 8);
            this.lblDescricaocomputador.Name = "lblDescricaocomputador";
            this.lblDescricaocomputador.Size = new System.Drawing.Size(97, 20);
            this.lblDescricaocomputador.TabIndex = 6;
            this.lblDescricaocomputador.Text = "Computador";
            // 
            // lblpontuacaojogador
            // 
            this.lblpontuacaojogador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblpontuacaojogador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpontuacaojogador.Location = new System.Drawing.Point(97, 8);
            this.lblpontuacaojogador.Name = "lblpontuacaojogador";
            this.lblpontuacaojogador.Size = new System.Drawing.Size(40, 20);
            this.lblpontuacaojogador.TabIndex = 7;
            this.lblpontuacaojogador.Text = "0";
            this.lblpontuacaojogador.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblpontuacaocomputador
            // 
            this.lblpontuacaocomputador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblpontuacaocomputador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpontuacaocomputador.Location = new System.Drawing.Point(493, 8);
            this.lblpontuacaocomputador.Name = "lblpontuacaocomputador";
            this.lblpontuacaocomputador.Size = new System.Drawing.Size(40, 20);
            this.lblpontuacaocomputador.TabIndex = 8;
            this.lblpontuacaocomputador.Text = "0";
            this.lblpontuacaocomputador.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // wfpPedraPapelTesoura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(554, 321);
            this.Controls.Add(this.lblpontuacaocomputador);
            this.Controls.Add(this.lblpontuacaojogador);
            this.Controls.Add(this.lblDescricaocomputador);
            this.Controls.Add(this.lbldescricaojogador);
            this.Controls.Add(this.pictureComputador);
            this.Controls.Add(this.pictureJogador);
            this.Controls.Add(this.btnTesoura);
            this.Controls.Add(this.btnPapel);
            this.Controls.Add(this.btnPedra);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfpPedraPapelTesoura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pedra papel e tesoura";
            ((System.ComponentModel.ISupportInitialize)(this.pictureJogador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureComputador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPedra;
        private System.Windows.Forms.Button btnPapel;
        private System.Windows.Forms.Button btnTesoura;
        private System.Windows.Forms.PictureBox pictureJogador;
        private System.Windows.Forms.PictureBox pictureComputador;
        private System.Windows.Forms.Label lbldescricaojogador;
        private System.Windows.Forms.Label lblDescricaocomputador;
        private System.Windows.Forms.Label lblpontuacaojogador;
        private System.Windows.Forms.Label lblpontuacaocomputador;
    }
}

