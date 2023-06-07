
namespace Web_Browser
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlNavegacao = new System.Windows.Forms.Panel();
            this.btnHistorico = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnYouTube = new System.Windows.Forms.Button();
            this.btnGoogle = new System.Windows.Forms.Button();
            this.btnIr = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splitHistorico = new System.Windows.Forms.SplitContainer();
            this.btnLimparHistorico = new System.Windows.Forms.Button();
            this.btnFecharHistorico = new System.Windows.Forms.Button();
            this.lblHistoricoTit = new System.Windows.Forms.Label();
            this.lbHistorico = new System.Windows.Forms.ListBox();
            this.pnlNavegacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitHistorico)).BeginInit();
            this.splitHistorico.Panel1.SuspendLayout();
            this.splitHistorico.Panel2.SuspendLayout();
            this.splitHistorico.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNavegacao
            // 
            this.pnlNavegacao.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnlNavegacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlNavegacao.Controls.Add(this.btnHistorico);
            this.pnlNavegacao.Controls.Add(this.btnHome);
            this.pnlNavegacao.Controls.Add(this.btnYouTube);
            this.pnlNavegacao.Controls.Add(this.btnGoogle);
            this.pnlNavegacao.Controls.Add(this.btnIr);
            this.pnlNavegacao.Controls.Add(this.btnRefresh);
            this.pnlNavegacao.Controls.Add(this.btnForward);
            this.pnlNavegacao.Controls.Add(this.btnGoBack);
            this.pnlNavegacao.Controls.Add(this.txtURL);
            this.pnlNavegacao.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavegacao.Location = new System.Drawing.Point(0, 0);
            this.pnlNavegacao.Name = "pnlNavegacao";
            this.pnlNavegacao.Size = new System.Drawing.Size(800, 62);
            this.pnlNavegacao.TabIndex = 0;
            // 
            // btnHistorico
            // 
            this.btnHistorico.Location = new System.Drawing.Point(132, 35);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(75, 23);
            this.btnHistorico.TabIndex = 9;
            this.btnHistorico.Text = "Histórico";
            this.btnHistorico.UseVisualStyleBackColor = true;
            this.btnHistorico.Click += new System.EventHandler(this.btnHistorico_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackgroundImage = global::Web_Browser.Properties.Resources.home_page_50px;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(85, 37);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(41, 22);
            this.btnHome.TabIndex = 8;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnYouTube
            // 
            this.btnYouTube.BackColor = System.Drawing.Color.Transparent;
            this.btnYouTube.BackgroundImage = global::Web_Browser.Properties.Resources.youtube_play_button_48px;
            this.btnYouTube.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnYouTube.FlatAppearance.BorderSize = 0;
            this.btnYouTube.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYouTube.Location = new System.Drawing.Point(38, 35);
            this.btnYouTube.Name = "btnYouTube";
            this.btnYouTube.Size = new System.Drawing.Size(41, 27);
            this.btnYouTube.TabIndex = 7;
            this.btnYouTube.UseVisualStyleBackColor = false;
            this.btnYouTube.Click += new System.EventHandler(this.btnYouTube_Click);
            // 
            // btnGoogle
            // 
            this.btnGoogle.BackColor = System.Drawing.Color.Transparent;
            this.btnGoogle.BackgroundImage = global::Web_Browser.Properties.Resources.google_48px;
            this.btnGoogle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGoogle.FlatAppearance.BorderSize = 0;
            this.btnGoogle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoogle.Location = new System.Drawing.Point(1, 37);
            this.btnGoogle.Name = "btnGoogle";
            this.btnGoogle.Size = new System.Drawing.Size(31, 24);
            this.btnGoogle.TabIndex = 5;
            this.btnGoogle.UseVisualStyleBackColor = false;
            this.btnGoogle.Click += new System.EventHandler(this.btnGoogle_Click);
            // 
            // btnIr
            // 
            this.btnIr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIr.BackColor = System.Drawing.Color.White;
            this.btnIr.BackgroundImage = global::Web_Browser.Properties.Resources.search_32px;
            this.btnIr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIr.FlatAppearance.BorderSize = 0;
            this.btnIr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIr.Location = new System.Drawing.Point(761, 12);
            this.btnIr.Name = "btnIr";
            this.btnIr.Size = new System.Drawing.Size(23, 17);
            this.btnIr.TabIndex = 4;
            this.btnIr.UseVisualStyleBackColor = false;
            this.btnIr.Click += new System.EventHandler(this.btnIr_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BackgroundImage = global::Web_Browser.Properties.Resources.refresh_26px;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(53, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(30, 19);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnForward
            // 
            this.btnForward.BackColor = System.Drawing.Color.Transparent;
            this.btnForward.BackgroundImage = global::Web_Browser.Properties.Resources.forward_26px;
            this.btnForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnForward.FlatAppearance.BorderSize = 0;
            this.btnForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForward.Location = new System.Drawing.Point(26, 12);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(30, 19);
            this.btnForward.TabIndex = 2;
            this.btnForward.UseVisualStyleBackColor = false;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.Transparent;
            this.btnGoBack.BackgroundImage = global::Web_Browser.Properties.Resources.back_26px;
            this.btnGoBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGoBack.FlatAppearance.BorderSize = 0;
            this.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBack.Location = new System.Drawing.Point(1, 12);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(30, 19);
            this.btnGoBack.TabIndex = 1;
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // txtURL
            // 
            this.txtURL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtURL.Location = new System.Drawing.Point(83, 11);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(705, 20);
            this.txtURL.TabIndex = 0;
            this.txtURL.TextChanged += new System.EventHandler(this.tbURL_TextChanged);
            this.txtURL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbURL_KeyDown);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 62);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(800, 388);
            this.webBrowser1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 388);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // splitHistorico
            // 
            this.splitHistorico.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitHistorico.Location = new System.Drawing.Point(466, 62);
            this.splitHistorico.Name = "splitHistorico";
            this.splitHistorico.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitHistorico.Panel1
            // 
            this.splitHistorico.Panel1.Controls.Add(this.btnLimparHistorico);
            this.splitHistorico.Panel1.Controls.Add(this.btnFecharHistorico);
            this.splitHistorico.Panel1.Controls.Add(this.lblHistoricoTit);
            // 
            // splitHistorico.Panel2
            // 
            this.splitHistorico.Panel2.Controls.Add(this.lbHistorico);
            this.splitHistorico.Size = new System.Drawing.Size(334, 388);
            this.splitHistorico.SplitterDistance = 75;
            this.splitHistorico.TabIndex = 3;
            this.splitHistorico.Visible = false;
            // 
            // btnLimparHistorico
            // 
            this.btnLimparHistorico.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparHistorico.Location = new System.Drawing.Point(8, 32);
            this.btnLimparHistorico.Name = "btnLimparHistorico";
            this.btnLimparHistorico.Size = new System.Drawing.Size(180, 40);
            this.btnLimparHistorico.TabIndex = 2;
            this.btnLimparHistorico.Text = "Limpar Histórico";
            this.btnLimparHistorico.UseVisualStyleBackColor = true;
            this.btnLimparHistorico.Click += new System.EventHandler(this.btnLimparHistorico_Click);
            // 
            // btnFecharHistorico
            // 
            this.btnFecharHistorico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFecharHistorico.FlatAppearance.BorderSize = 0;
            this.btnFecharHistorico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecharHistorico.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharHistorico.ForeColor = System.Drawing.Color.Red;
            this.btnFecharHistorico.Location = new System.Drawing.Point(295, 0);
            this.btnFecharHistorico.Name = "btnFecharHistorico";
            this.btnFecharHistorico.Size = new System.Drawing.Size(36, 43);
            this.btnFecharHistorico.TabIndex = 1;
            this.btnFecharHistorico.Text = "x";
            this.btnFecharHistorico.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnFecharHistorico.UseVisualStyleBackColor = true;
            this.btnFecharHistorico.Click += new System.EventHandler(this.btnFecharHistorico_Click);
            // 
            // lblHistoricoTit
            // 
            this.lblHistoricoTit.AutoSize = true;
            this.lblHistoricoTit.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistoricoTit.Location = new System.Drawing.Point(3, 3);
            this.lblHistoricoTit.Name = "lblHistoricoTit";
            this.lblHistoricoTit.Size = new System.Drawing.Size(195, 25);
            this.lblHistoricoTit.TabIndex = 0;
            this.lblHistoricoTit.Text = "Histórico de Pesquisa";
            // 
            // lbHistorico
            // 
            this.lbHistorico.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHistorico.FormattingEnabled = true;
            this.lbHistorico.ItemHeight = 21;
            this.lbHistorico.Location = new System.Drawing.Point(3, 1);
            this.lbHistorico.Name = "lbHistorico";
            this.lbHistorico.Size = new System.Drawing.Size(328, 298);
            this.lbHistorico.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitHistorico);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.pnlNavegacao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlNavegacao.ResumeLayout(false);
            this.pnlNavegacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitHistorico.Panel1.ResumeLayout(false);
            this.splitHistorico.Panel1.PerformLayout();
            this.splitHistorico.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitHistorico)).EndInit();
            this.splitHistorico.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNavegacao;
        private System.Windows.Forms.Button btnIr;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnYouTube;
        private System.Windows.Forms.Button btnGoogle;
        private System.Windows.Forms.Button btnHistorico;
        private System.Windows.Forms.SplitContainer splitHistorico;
        private System.Windows.Forms.Button btnLimparHistorico;
        private System.Windows.Forms.Button btnFecharHistorico;
        private System.Windows.Forms.Label lblHistoricoTit;
        private System.Windows.Forms.ListBox lbHistorico;
    }
}

