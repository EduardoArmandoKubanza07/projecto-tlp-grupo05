
namespace wfaJogoDaVelha
{
    partial class wfaJogoDaVelha
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelBotoes = new System.Windows.Forms.Panel();
            this.tableBtns = new System.Windows.Forms.TableLayoutPanel();
            this.btnNove = new System.Windows.Forms.Button();
            this.btnOito = new System.Windows.Forms.Button();
            this.btnSete = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnQuatro = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnDois = new System.Windows.Forms.Button();
            this.btnUm = new System.Windows.Forms.Button();
            this.panelResultado = new System.Windows.Forms.Panel();
            this.lblEmpatePontos = new System.Windows.Forms.Label();
            this.lblOPontos = new System.Windows.Forms.Label();
            this.lblXPontos = new System.Windows.Forms.Label();
            this.lblEmpates = new System.Windows.Forms.Label();
            this.lblO = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.lblInfor = new System.Windows.Forms.Label();
            this.panelBotoes.SuspendLayout();
            this.tableBtns.SuspendLayout();
            this.panelResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(118, -2);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(196, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Jogo da Velha";
            // 
            // panelBotoes
            // 
            this.panelBotoes.Controls.Add(this.tableBtns);
            this.panelBotoes.Location = new System.Drawing.Point(64, 49);
            this.panelBotoes.Name = "panelBotoes";
            this.panelBotoes.Size = new System.Drawing.Size(310, 204);
            this.panelBotoes.TabIndex = 1;
            // 
            // tableBtns
            // 
            this.tableBtns.ColumnCount = 3;
            this.tableBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableBtns.Controls.Add(this.btnNove, 2, 2);
            this.tableBtns.Controls.Add(this.btnOito, 1, 2);
            this.tableBtns.Controls.Add(this.btnSete, 0, 2);
            this.tableBtns.Controls.Add(this.btnSeis, 2, 1);
            this.tableBtns.Controls.Add(this.btnCinco, 1, 1);
            this.tableBtns.Controls.Add(this.btnQuatro, 0, 1);
            this.tableBtns.Controls.Add(this.btnTres, 2, 0);
            this.tableBtns.Controls.Add(this.btnDois, 1, 0);
            this.tableBtns.Controls.Add(this.btnUm, 0, 0);
            this.tableBtns.Location = new System.Drawing.Point(0, 0);
            this.tableBtns.Name = "tableBtns";
            this.tableBtns.RowCount = 3;
            this.tableBtns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableBtns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableBtns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableBtns.Size = new System.Drawing.Size(308, 201);
            this.tableBtns.TabIndex = 0;
            // 
            // btnNove
            // 
            this.btnNove.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNove.FlatAppearance.BorderSize = 0;
            this.btnNove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNove.Font = new System.Drawing.Font("Segoe UI", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNove.ForeColor = System.Drawing.Color.Black;
            this.btnNove.Location = new System.Drawing.Point(207, 137);
            this.btnNove.Name = "btnNove";
            this.btnNove.Size = new System.Drawing.Size(98, 61);
            this.btnNove.TabIndex = 8;
            this.btnNove.UseVisualStyleBackColor = false;
            this.btnNove.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnOito
            // 
            this.btnOito.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOito.FlatAppearance.BorderSize = 0;
            this.btnOito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOito.Font = new System.Drawing.Font("Segoe UI", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOito.ForeColor = System.Drawing.Color.Black;
            this.btnOito.Location = new System.Drawing.Point(105, 137);
            this.btnOito.Name = "btnOito";
            this.btnOito.Size = new System.Drawing.Size(96, 61);
            this.btnOito.TabIndex = 7;
            this.btnOito.UseVisualStyleBackColor = false;
            this.btnOito.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnSete
            // 
            this.btnSete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSete.FlatAppearance.BorderSize = 0;
            this.btnSete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSete.Font = new System.Drawing.Font("Segoe UI", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSete.ForeColor = System.Drawing.Color.Black;
            this.btnSete.Location = new System.Drawing.Point(3, 137);
            this.btnSete.Name = "btnSete";
            this.btnSete.Size = new System.Drawing.Size(96, 61);
            this.btnSete.TabIndex = 6;
            this.btnSete.UseVisualStyleBackColor = false;
            this.btnSete.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnSeis
            // 
            this.btnSeis.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSeis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSeis.FlatAppearance.BorderSize = 0;
            this.btnSeis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeis.Font = new System.Drawing.Font("Segoe UI", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeis.ForeColor = System.Drawing.Color.Black;
            this.btnSeis.Location = new System.Drawing.Point(207, 70);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(98, 61);
            this.btnSeis.TabIndex = 5;
            this.btnSeis.UseVisualStyleBackColor = false;
            this.btnSeis.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnCinco
            // 
            this.btnCinco.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCinco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCinco.FlatAppearance.BorderSize = 0;
            this.btnCinco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCinco.Font = new System.Drawing.Font("Segoe UI", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCinco.ForeColor = System.Drawing.Color.Black;
            this.btnCinco.Location = new System.Drawing.Point(105, 70);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(96, 61);
            this.btnCinco.TabIndex = 4;
            this.btnCinco.UseVisualStyleBackColor = false;
            this.btnCinco.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnQuatro
            // 
            this.btnQuatro.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnQuatro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQuatro.FlatAppearance.BorderSize = 0;
            this.btnQuatro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuatro.Font = new System.Drawing.Font("Segoe UI", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuatro.ForeColor = System.Drawing.Color.Black;
            this.btnQuatro.Location = new System.Drawing.Point(3, 70);
            this.btnQuatro.Name = "btnQuatro";
            this.btnQuatro.Size = new System.Drawing.Size(96, 61);
            this.btnQuatro.TabIndex = 3;
            this.btnQuatro.UseVisualStyleBackColor = false;
            this.btnQuatro.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnTres
            // 
            this.btnTres.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTres.FlatAppearance.BorderSize = 0;
            this.btnTres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTres.Font = new System.Drawing.Font("Segoe UI", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTres.ForeColor = System.Drawing.Color.Black;
            this.btnTres.Location = new System.Drawing.Point(207, 3);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(98, 61);
            this.btnTres.TabIndex = 2;
            this.btnTres.UseVisualStyleBackColor = false;
            this.btnTres.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnDois
            // 
            this.btnDois.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDois.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDois.FlatAppearance.BorderSize = 0;
            this.btnDois.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDois.Font = new System.Drawing.Font("Segoe UI", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDois.ForeColor = System.Drawing.Color.Black;
            this.btnDois.Location = new System.Drawing.Point(105, 3);
            this.btnDois.Name = "btnDois";
            this.btnDois.Size = new System.Drawing.Size(96, 61);
            this.btnDois.TabIndex = 1;
            this.btnDois.UseVisualStyleBackColor = false;
            this.btnDois.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnUm
            // 
            this.btnUm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUm.FlatAppearance.BorderSize = 0;
            this.btnUm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUm.Font = new System.Drawing.Font("Segoe UI", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUm.ForeColor = System.Drawing.Color.Black;
            this.btnUm.Location = new System.Drawing.Point(3, 3);
            this.btnUm.Name = "btnUm";
            this.btnUm.Size = new System.Drawing.Size(96, 61);
            this.btnUm.TabIndex = 0;
            this.btnUm.UseVisualStyleBackColor = false;
            this.btnUm.Click += new System.EventHandler(this.btn_Click);
            // 
            // panelResultado
            // 
            this.panelResultado.Controls.Add(this.lblEmpatePontos);
            this.panelResultado.Controls.Add(this.lblOPontos);
            this.panelResultado.Controls.Add(this.lblXPontos);
            this.panelResultado.Controls.Add(this.lblEmpates);
            this.panelResultado.Controls.Add(this.lblO);
            this.panelResultado.Controls.Add(this.lblX);
            this.panelResultado.Location = new System.Drawing.Point(12, 379);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(421, 93);
            this.panelResultado.TabIndex = 2;
            // 
            // lblEmpatePontos
            // 
            this.lblEmpatePontos.AutoSize = true;
            this.lblEmpatePontos.Font = new System.Drawing.Font("Segoe UI", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpatePontos.Location = new System.Drawing.Point(355, 38);
            this.lblEmpatePontos.Name = "lblEmpatePontos";
            this.lblEmpatePontos.Size = new System.Drawing.Size(40, 47);
            this.lblEmpatePontos.TabIndex = 5;
            this.lblEmpatePontos.Text = "0";
            // 
            // lblOPontos
            // 
            this.lblOPontos.AutoSize = true;
            this.lblOPontos.Font = new System.Drawing.Font("Segoe UI", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOPontos.Location = new System.Drawing.Point(187, 38);
            this.lblOPontos.Name = "lblOPontos";
            this.lblOPontos.Size = new System.Drawing.Size(40, 47);
            this.lblOPontos.TabIndex = 4;
            this.lblOPontos.Text = "0";
            // 
            // lblXPontos
            // 
            this.lblXPontos.AutoSize = true;
            this.lblXPontos.Font = new System.Drawing.Font("Segoe UI", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXPontos.Location = new System.Drawing.Point(44, 38);
            this.lblXPontos.Name = "lblXPontos";
            this.lblXPontos.Size = new System.Drawing.Size(40, 47);
            this.lblXPontos.TabIndex = 3;
            this.lblXPontos.Text = "0";
            // 
            // lblEmpates
            // 
            this.lblEmpates.AutoSize = true;
            this.lblEmpates.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpates.Location = new System.Drawing.Point(332, 4);
            this.lblEmpates.Name = "lblEmpates";
            this.lblEmpates.Size = new System.Drawing.Size(86, 25);
            this.lblEmpates.TabIndex = 2;
            this.lblEmpates.Text = "Empates";
            // 
            // lblO
            // 
            this.lblO.AutoSize = true;
            this.lblO.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblO.Location = new System.Drawing.Point(152, 4);
            this.lblO.Name = "lblO";
            this.lblO.Size = new System.Drawing.Size(103, 25);
            this.lblO.TabIndex = 1;
            this.lblO.Text = "O - pontos";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(4, 4);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(101, 25);
            this.lblX.TabIndex = 0;
            this.lblX.Text = "X - pontos";
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReiniciar.FlatAppearance.BorderSize = 0;
            this.btnReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReiniciar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.Location = new System.Drawing.Point(125, 269);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(177, 38);
            this.btnReiniciar.TabIndex = 3;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // lblInfor
            // 
            this.lblInfor.AutoSize = true;
            this.lblInfor.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfor.Location = new System.Drawing.Point(120, 324);
            this.lblInfor.Name = "lblInfor";
            this.lblInfor.Size = new System.Drawing.Size(169, 25);
            this.lblInfor.TabIndex = 4;
            this.lblInfor.Text = "Vez do jogador : X";
            // 
            // wfaJogoDaVelha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(445, 475);
            this.Controls.Add(this.lblInfor);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.panelResultado);
            this.Controls.Add(this.panelBotoes);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "wfaJogoDaVelha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo Da Velha";
            this.panelBotoes.ResumeLayout(false);
            this.tableBtns.ResumeLayout(false);
            this.panelResultado.ResumeLayout(false);
            this.panelResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelBotoes;
        private System.Windows.Forms.TableLayoutPanel tableBtns;
        private System.Windows.Forms.Button btnNove;
        private System.Windows.Forms.Button btnOito;
        private System.Windows.Forms.Button btnSete;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnQuatro;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnDois;
        private System.Windows.Forms.Button btnUm;
        private System.Windows.Forms.Panel panelResultado;
        private System.Windows.Forms.Label lblEmpates;
        private System.Windows.Forms.Label lblO;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblEmpatePontos;
        private System.Windows.Forms.Label lblOPontos;
        private System.Windows.Forms.Label lblXPontos;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Label lblInfor;
    }
}

