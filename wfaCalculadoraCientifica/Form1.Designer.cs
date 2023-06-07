
namespace wfaCalculadoraCientifica
{
    partial class wfaCalculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfaCalculadora));
            this.splitTela = new System.Windows.Forms.SplitContainer();
            this.lblConta = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAcos = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnVirgula = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnMiasOuMenos = new System.Windows.Forms.Button();
            this.btnParentDir = new System.Windows.Forms.Button();
            this.btnParentEsq = new System.Windows.Forms.Button();
            this.btnFat = new System.Windows.Forms.Button();
            this.btnPi = new System.Windows.Forms.Button();
            this.button36 = new System.Windows.Forms.Button();
            this.btnMais = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnDois = new System.Windows.Forms.Button();
            this.btnUm = new System.Windows.Forms.Button();
            this.btnDeg = new System.Windows.Forms.Button();
            this.btnDms = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnEElevX = new System.Windows.Forms.Button();
            this.btnUmSobreX = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnQuatro = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnExp = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnDezElevX = new System.Windows.Forms.Button();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnNove = new System.Windows.Forms.Button();
            this.btnOito = new System.Windows.Forms.Button();
            this.btnSete = new System.Windows.Forms.Button();
            this.btnATang = new System.Windows.Forms.Button();
            this.btnAsin = new System.Windows.Forms.Button();
            this.btnYRaizX = new System.Windows.Forms.Button();
            this.btnXCubico = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnTan = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnXElevY = new System.Windows.Forms.Button();
            this.btnXQuad = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitTela)).BeginInit();
            this.splitTela.Panel1.SuspendLayout();
            this.splitTela.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitTela
            // 
            this.splitTela.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitTela.Location = new System.Drawing.Point(0, 0);
            this.splitTela.Margin = new System.Windows.Forms.Padding(1);
            this.splitTela.Name = "splitTela";
            // 
            // splitTela.Panel1
            // 
            this.splitTela.Panel1.Controls.Add(this.lblConta);
            this.splitTela.Panel1.Controls.Add(this.lblResultado);
            this.splitTela.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitTela.Panel1.Controls.Add(this.lblTitulo);
            this.splitTela.Panel1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitTela.Panel2Collapsed = true;
            this.splitTela.Panel2MinSize = 0;
            this.splitTela.Size = new System.Drawing.Size(622, 479);
            this.splitTela.SplitterDistance = 615;
            this.splitTela.TabIndex = 0;
            // 
            // lblConta
            // 
            this.lblConta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConta.Location = new System.Drawing.Point(10, 77);
            this.lblConta.Name = "lblConta";
            this.lblConta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblConta.Size = new System.Drawing.Size(609, 45);
            this.lblConta.TabIndex = 3;
            this.lblConta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblConta.Click += new System.EventHandler(this.btnOperacao_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(-23, 111);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblResultado.Size = new System.Drawing.Size(640, 86);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "0";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.Controls.Add(this.btnAcos, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnIgual, 8, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnVirgula, 7, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnZero, 6, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnMiasOuMenos, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnParentDir, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnParentEsq, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnFat, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnPi, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.button36, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnMais, 8, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnTres, 7, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnDois, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnUm, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnDeg, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnDms, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnIn, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnEElevX, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnUmSobreX, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnMenos, 8, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSeis, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnCinco, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnQuatro, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnMod, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnExp, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnLog, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnDezElevX, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnRaiz, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnMultiplicar, 8, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnNove, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnOito, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSete, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnATang, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnAsin, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnYRaizX, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnXCubico, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDividir, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEliminar, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnC, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCE, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnTan, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCos, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSin, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnXElevY, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnXQuad, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 200);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(628, 275);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(628, 275);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnAcos
            // 
            this.btnAcos.AutoSize = true;
            this.btnAcos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnAcos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAcos.FlatAppearance.BorderSize = 0;
            this.btnAcos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcos.Location = new System.Drawing.Point(208, 56);
            this.btnAcos.Margin = new System.Windows.Forms.Padding(1);
            this.btnAcos.Name = "btnAcos";
            this.btnAcos.Size = new System.Drawing.Size(67, 53);
            this.btnAcos.TabIndex = 12;
            this.btnAcos.Text = "cos¯¹";
            this.btnAcos.UseVisualStyleBackColor = false;
            this.btnAcos.Click += new System.EventHandler(this.btnAcos_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.AutoSize = true;
            this.btnIgual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnIgual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIgual.FlatAppearance.BorderSize = 0;
            this.btnIgual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIgual.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.Location = new System.Drawing.Point(553, 221);
            this.btnIgual.Margin = new System.Windows.Forms.Padding(1);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(74, 53);
            this.btnIgual.TabIndex = 44;
            this.btnIgual.Text = " =";
            this.btnIgual.UseVisualStyleBackColor = false;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnVirgula
            // 
            this.btnVirgula.AutoSize = true;
            this.btnVirgula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnVirgula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVirgula.FlatAppearance.BorderSize = 0;
            this.btnVirgula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVirgula.Location = new System.Drawing.Point(484, 221);
            this.btnVirgula.Margin = new System.Windows.Forms.Padding(1);
            this.btnVirgula.Name = "btnVirgula";
            this.btnVirgula.Size = new System.Drawing.Size(67, 53);
            this.btnVirgula.TabIndex = 43;
            this.btnVirgula.Text = ",";
            this.btnVirgula.UseVisualStyleBackColor = false;
            this.btnVirgula.Click += new System.EventHandler(this.btnVirgula_Click);
            // 
            // btnZero
            // 
            this.btnZero.AutoSize = true;
            this.btnZero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnZero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnZero.FlatAppearance.BorderSize = 0;
            this.btnZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZero.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZero.Location = new System.Drawing.Point(415, 221);
            this.btnZero.Margin = new System.Windows.Forms.Padding(1);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(67, 53);
            this.btnZero.TabIndex = 42;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = false;
            this.btnZero.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnMiasOuMenos
            // 
            this.btnMiasOuMenos.AutoSize = true;
            this.btnMiasOuMenos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnMiasOuMenos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMiasOuMenos.FlatAppearance.BorderSize = 0;
            this.btnMiasOuMenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMiasOuMenos.Location = new System.Drawing.Point(346, 221);
            this.btnMiasOuMenos.Margin = new System.Windows.Forms.Padding(1);
            this.btnMiasOuMenos.Name = "btnMiasOuMenos";
            this.btnMiasOuMenos.Size = new System.Drawing.Size(67, 53);
            this.btnMiasOuMenos.TabIndex = 41;
            this.btnMiasOuMenos.Text = " ±";
            this.btnMiasOuMenos.UseVisualStyleBackColor = false;
            this.btnMiasOuMenos.Click += new System.EventHandler(this.btnMiasOuMenos_Click);
            // 
            // btnParentDir
            // 
            this.btnParentDir.AutoSize = true;
            this.btnParentDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnParentDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnParentDir.FlatAppearance.BorderSize = 0;
            this.btnParentDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParentDir.Location = new System.Drawing.Point(277, 221);
            this.btnParentDir.Margin = new System.Windows.Forms.Padding(1);
            this.btnParentDir.Name = "btnParentDir";
            this.btnParentDir.Size = new System.Drawing.Size(67, 53);
            this.btnParentDir.TabIndex = 40;
            this.btnParentDir.Text = " )";
            this.btnParentDir.UseVisualStyleBackColor = false;
            this.btnParentDir.Click += new System.EventHandler(this.btnParentDir_Click);
            // 
            // btnParentEsq
            // 
            this.btnParentEsq.AutoSize = true;
            this.btnParentEsq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnParentEsq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnParentEsq.FlatAppearance.BorderSize = 0;
            this.btnParentEsq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParentEsq.Location = new System.Drawing.Point(208, 221);
            this.btnParentEsq.Margin = new System.Windows.Forms.Padding(1);
            this.btnParentEsq.Name = "btnParentEsq";
            this.btnParentEsq.Size = new System.Drawing.Size(67, 53);
            this.btnParentEsq.TabIndex = 39;
            this.btnParentEsq.Text = "(";
            this.btnParentEsq.UseVisualStyleBackColor = false;
            this.btnParentEsq.Click += new System.EventHandler(this.btnParentEsq_Click);
            // 
            // btnFat
            // 
            this.btnFat.AutoSize = true;
            this.btnFat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnFat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFat.FlatAppearance.BorderSize = 0;
            this.btnFat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFat.Location = new System.Drawing.Point(139, 221);
            this.btnFat.Margin = new System.Windows.Forms.Padding(1);
            this.btnFat.Name = "btnFat";
            this.btnFat.Size = new System.Drawing.Size(67, 53);
            this.btnFat.TabIndex = 38;
            this.btnFat.Text = "n!";
            this.btnFat.UseVisualStyleBackColor = false;
            this.btnFat.Click += new System.EventHandler(this.btnFat_Click);
            // 
            // btnPi
            // 
            this.btnPi.AutoSize = true;
            this.btnPi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnPi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPi.FlatAppearance.BorderSize = 0;
            this.btnPi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPi.Location = new System.Drawing.Point(70, 221);
            this.btnPi.Margin = new System.Windows.Forms.Padding(1);
            this.btnPi.Name = "btnPi";
            this.btnPi.Size = new System.Drawing.Size(67, 53);
            this.btnPi.TabIndex = 37;
            this.btnPi.Text = "π";
            this.btnPi.UseVisualStyleBackColor = false;
            this.btnPi.Click += new System.EventHandler(this.btnPi_Click);
            // 
            // button36
            // 
            this.button36.AutoSize = true;
            this.button36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.button36.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button36.Enabled = false;
            this.button36.FlatAppearance.BorderSize = 0;
            this.button36.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button36.Location = new System.Drawing.Point(1, 221);
            this.button36.Margin = new System.Windows.Forms.Padding(1);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(67, 53);
            this.button36.TabIndex = 36;
            this.button36.Text = "↑";
            this.button36.UseVisualStyleBackColor = false;
            // 
            // btnMais
            // 
            this.btnMais.AutoSize = true;
            this.btnMais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnMais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMais.FlatAppearance.BorderSize = 0;
            this.btnMais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMais.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMais.Location = new System.Drawing.Point(553, 166);
            this.btnMais.Margin = new System.Windows.Forms.Padding(1);
            this.btnMais.Name = "btnMais";
            this.btnMais.Size = new System.Drawing.Size(74, 53);
            this.btnMais.TabIndex = 35;
            this.btnMais.Text = "+";
            this.btnMais.UseVisualStyleBackColor = false;
            this.btnMais.Click += new System.EventHandler(this.btnOperacao_Click);
            // 
            // btnTres
            // 
            this.btnTres.AutoSize = true;
            this.btnTres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnTres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTres.FlatAppearance.BorderSize = 0;
            this.btnTres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTres.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTres.Location = new System.Drawing.Point(484, 166);
            this.btnTres.Margin = new System.Windows.Forms.Padding(1);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(67, 53);
            this.btnTres.TabIndex = 34;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = false;
            this.btnTres.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnDois
            // 
            this.btnDois.AutoSize = true;
            this.btnDois.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnDois.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDois.FlatAppearance.BorderSize = 0;
            this.btnDois.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDois.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDois.Location = new System.Drawing.Point(415, 166);
            this.btnDois.Margin = new System.Windows.Forms.Padding(1);
            this.btnDois.Name = "btnDois";
            this.btnDois.Size = new System.Drawing.Size(67, 53);
            this.btnDois.TabIndex = 33;
            this.btnDois.Text = "2";
            this.btnDois.UseVisualStyleBackColor = false;
            this.btnDois.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnUm
            // 
            this.btnUm.AutoSize = true;
            this.btnUm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnUm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUm.FlatAppearance.BorderSize = 0;
            this.btnUm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUm.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUm.Location = new System.Drawing.Point(346, 166);
            this.btnUm.Margin = new System.Windows.Forms.Padding(1);
            this.btnUm.Name = "btnUm";
            this.btnUm.Size = new System.Drawing.Size(67, 53);
            this.btnUm.TabIndex = 32;
            this.btnUm.Text = "1";
            this.btnUm.UseVisualStyleBackColor = false;
            this.btnUm.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnDeg
            // 
            this.btnDeg.AutoSize = true;
            this.btnDeg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnDeg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeg.FlatAppearance.BorderSize = 0;
            this.btnDeg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeg.Location = new System.Drawing.Point(277, 166);
            this.btnDeg.Margin = new System.Windows.Forms.Padding(1);
            this.btnDeg.Name = "btnDeg";
            this.btnDeg.Size = new System.Drawing.Size(67, 53);
            this.btnDeg.TabIndex = 31;
            this.btnDeg.Text = "deg";
            this.btnDeg.UseVisualStyleBackColor = false;
            this.btnDeg.Click += new System.EventHandler(this.btnDeg_Click);
            // 
            // btnDms
            // 
            this.btnDms.AutoSize = true;
            this.btnDms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnDms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDms.FlatAppearance.BorderSize = 0;
            this.btnDms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDms.Location = new System.Drawing.Point(208, 166);
            this.btnDms.Margin = new System.Windows.Forms.Padding(1);
            this.btnDms.Name = "btnDms";
            this.btnDms.Size = new System.Drawing.Size(67, 53);
            this.btnDms.TabIndex = 30;
            this.btnDms.Text = "dms";
            this.btnDms.UseVisualStyleBackColor = false;
            this.btnDms.Click += new System.EventHandler(this.btnDms_Click);
            // 
            // btnIn
            // 
            this.btnIn.AutoSize = true;
            this.btnIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIn.FlatAppearance.BorderSize = 0;
            this.btnIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIn.Location = new System.Drawing.Point(139, 166);
            this.btnIn.Margin = new System.Windows.Forms.Padding(1);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(67, 53);
            this.btnIn.TabIndex = 29;
            this.btnIn.Text = " In";
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnEElevX
            // 
            this.btnEElevX.AutoSize = true;
            this.btnEElevX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnEElevX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEElevX.FlatAppearance.BorderSize = 0;
            this.btnEElevX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEElevX.Location = new System.Drawing.Point(70, 166);
            this.btnEElevX.Margin = new System.Windows.Forms.Padding(1);
            this.btnEElevX.Name = "btnEElevX";
            this.btnEElevX.Size = new System.Drawing.Size(67, 53);
            this.btnEElevX.TabIndex = 28;
            this.btnEElevX.Text = "eˣ";
            this.btnEElevX.UseVisualStyleBackColor = false;
            this.btnEElevX.Click += new System.EventHandler(this.btnEElevX_Click);
            // 
            // btnUmSobreX
            // 
            this.btnUmSobreX.AutoSize = true;
            this.btnUmSobreX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnUmSobreX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUmSobreX.FlatAppearance.BorderSize = 0;
            this.btnUmSobreX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUmSobreX.Location = new System.Drawing.Point(1, 166);
            this.btnUmSobreX.Margin = new System.Windows.Forms.Padding(1);
            this.btnUmSobreX.Name = "btnUmSobreX";
            this.btnUmSobreX.Size = new System.Drawing.Size(67, 53);
            this.btnUmSobreX.TabIndex = 27;
            this.btnUmSobreX.Text = "1/x";
            this.btnUmSobreX.UseVisualStyleBackColor = false;
            this.btnUmSobreX.Click += new System.EventHandler(this.btnUmSobreX_Click);
            // 
            // btnMenos
            // 
            this.btnMenos.AutoSize = true;
            this.btnMenos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnMenos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMenos.FlatAppearance.BorderSize = 0;
            this.btnMenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenos.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenos.Location = new System.Drawing.Point(553, 111);
            this.btnMenos.Margin = new System.Windows.Forms.Padding(1);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(74, 53);
            this.btnMenos.TabIndex = 26;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = false;
            this.btnMenos.Click += new System.EventHandler(this.btnOperacao_Click);
            // 
            // btnSeis
            // 
            this.btnSeis.AutoSize = true;
            this.btnSeis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnSeis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSeis.FlatAppearance.BorderSize = 0;
            this.btnSeis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeis.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeis.Location = new System.Drawing.Point(484, 111);
            this.btnSeis.Margin = new System.Windows.Forms.Padding(1);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(67, 53);
            this.btnSeis.TabIndex = 25;
            this.btnSeis.Text = "6";
            this.btnSeis.UseVisualStyleBackColor = false;
            this.btnSeis.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnCinco
            // 
            this.btnCinco.AutoSize = true;
            this.btnCinco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnCinco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCinco.FlatAppearance.BorderSize = 0;
            this.btnCinco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCinco.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCinco.Location = new System.Drawing.Point(415, 111);
            this.btnCinco.Margin = new System.Windows.Forms.Padding(1);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(67, 53);
            this.btnCinco.TabIndex = 24;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = false;
            this.btnCinco.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnQuatro
            // 
            this.btnQuatro.AutoSize = true;
            this.btnQuatro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnQuatro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQuatro.FlatAppearance.BorderSize = 0;
            this.btnQuatro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuatro.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuatro.Location = new System.Drawing.Point(346, 111);
            this.btnQuatro.Margin = new System.Windows.Forms.Padding(1);
            this.btnQuatro.Name = "btnQuatro";
            this.btnQuatro.Size = new System.Drawing.Size(67, 53);
            this.btnQuatro.TabIndex = 23;
            this.btnQuatro.Text = "4";
            this.btnQuatro.UseVisualStyleBackColor = false;
            this.btnQuatro.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnMod
            // 
            this.btnMod.AutoSize = true;
            this.btnMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnMod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMod.FlatAppearance.BorderSize = 0;
            this.btnMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMod.Location = new System.Drawing.Point(277, 111);
            this.btnMod.Margin = new System.Windows.Forms.Padding(1);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(67, 53);
            this.btnMod.TabIndex = 22;
            this.btnMod.Text = "Mod";
            this.btnMod.UseVisualStyleBackColor = false;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // btnExp
            // 
            this.btnExp.AutoSize = true;
            this.btnExp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnExp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExp.FlatAppearance.BorderSize = 0;
            this.btnExp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExp.Location = new System.Drawing.Point(208, 111);
            this.btnExp.Margin = new System.Windows.Forms.Padding(1);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(67, 53);
            this.btnExp.TabIndex = 21;
            this.btnExp.Text = "Exp";
            this.btnExp.UseVisualStyleBackColor = false;
            this.btnExp.Click += new System.EventHandler(this.btnExp_Click);
            // 
            // btnLog
            // 
            this.btnLog.AutoSize = true;
            this.btnLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLog.FlatAppearance.BorderSize = 0;
            this.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLog.Location = new System.Drawing.Point(139, 111);
            this.btnLog.Margin = new System.Windows.Forms.Padding(1);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(67, 53);
            this.btnLog.TabIndex = 20;
            this.btnLog.Text = "log";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnDezElevX
            // 
            this.btnDezElevX.AutoSize = true;
            this.btnDezElevX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnDezElevX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDezElevX.FlatAppearance.BorderSize = 0;
            this.btnDezElevX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDezElevX.Location = new System.Drawing.Point(70, 111);
            this.btnDezElevX.Margin = new System.Windows.Forms.Padding(1);
            this.btnDezElevX.Name = "btnDezElevX";
            this.btnDezElevX.Size = new System.Drawing.Size(67, 53);
            this.btnDezElevX.TabIndex = 19;
            this.btnDezElevX.Text = " 10ˣ";
            this.btnDezElevX.UseVisualStyleBackColor = false;
            this.btnDezElevX.Click += new System.EventHandler(this.btnDezElevX_Click);
            // 
            // btnRaiz
            // 
            this.btnRaiz.AutoSize = true;
            this.btnRaiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnRaiz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRaiz.FlatAppearance.BorderSize = 0;
            this.btnRaiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRaiz.Location = new System.Drawing.Point(1, 111);
            this.btnRaiz.Margin = new System.Windows.Forms.Padding(1);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(67, 53);
            this.btnRaiz.TabIndex = 18;
            this.btnRaiz.Text = "√";
            this.btnRaiz.UseVisualStyleBackColor = false;
            this.btnRaiz.Click += new System.EventHandler(this.btnRaiz_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.AutoSize = true;
            this.btnMultiplicar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnMultiplicar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMultiplicar.FlatAppearance.BorderSize = 0;
            this.btnMultiplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiplicar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicar.Location = new System.Drawing.Point(553, 56);
            this.btnMultiplicar.Margin = new System.Windows.Forms.Padding(1);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(74, 53);
            this.btnMultiplicar.TabIndex = 17;
            this.btnMultiplicar.Text = " × ";
            this.btnMultiplicar.UseVisualStyleBackColor = false;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnOperacao_Click);
            // 
            // btnNove
            // 
            this.btnNove.AutoSize = true;
            this.btnNove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnNove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNove.FlatAppearance.BorderSize = 0;
            this.btnNove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNove.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNove.Location = new System.Drawing.Point(484, 56);
            this.btnNove.Margin = new System.Windows.Forms.Padding(1);
            this.btnNove.Name = "btnNove";
            this.btnNove.Size = new System.Drawing.Size(67, 53);
            this.btnNove.TabIndex = 16;
            this.btnNove.Text = "9";
            this.btnNove.UseVisualStyleBackColor = false;
            this.btnNove.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnOito
            // 
            this.btnOito.AutoSize = true;
            this.btnOito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnOito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOito.FlatAppearance.BorderSize = 0;
            this.btnOito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOito.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOito.Location = new System.Drawing.Point(415, 56);
            this.btnOito.Margin = new System.Windows.Forms.Padding(1);
            this.btnOito.Name = "btnOito";
            this.btnOito.Size = new System.Drawing.Size(67, 53);
            this.btnOito.TabIndex = 15;
            this.btnOito.Text = "8";
            this.btnOito.UseVisualStyleBackColor = false;
            this.btnOito.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnSete
            // 
            this.btnSete.AutoSize = true;
            this.btnSete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnSete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSete.FlatAppearance.BorderSize = 0;
            this.btnSete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSete.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSete.Location = new System.Drawing.Point(346, 56);
            this.btnSete.Margin = new System.Windows.Forms.Padding(1);
            this.btnSete.Name = "btnSete";
            this.btnSete.Size = new System.Drawing.Size(67, 53);
            this.btnSete.TabIndex = 14;
            this.btnSete.Text = "7";
            this.btnSete.UseVisualStyleBackColor = false;
            this.btnSete.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnATang
            // 
            this.btnATang.AutoSize = true;
            this.btnATang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnATang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnATang.FlatAppearance.BorderSize = 0;
            this.btnATang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnATang.Location = new System.Drawing.Point(277, 56);
            this.btnATang.Margin = new System.Windows.Forms.Padding(1);
            this.btnATang.Name = "btnATang";
            this.btnATang.Size = new System.Drawing.Size(67, 53);
            this.btnATang.TabIndex = 13;
            this.btnATang.Text = "tan¯¹";
            this.btnATang.UseVisualStyleBackColor = false;
            this.btnATang.Click += new System.EventHandler(this.btnATang_Click);
            // 
            // btnAsin
            // 
            this.btnAsin.AutoSize = true;
            this.btnAsin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnAsin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAsin.FlatAppearance.BorderSize = 0;
            this.btnAsin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsin.Location = new System.Drawing.Point(139, 56);
            this.btnAsin.Margin = new System.Windows.Forms.Padding(1);
            this.btnAsin.Name = "btnAsin";
            this.btnAsin.Size = new System.Drawing.Size(67, 53);
            this.btnAsin.TabIndex = 11;
            this.btnAsin.Text = "sin¯¹";
            this.btnAsin.UseVisualStyleBackColor = false;
            this.btnAsin.Click += new System.EventHandler(this.btnAsin_Click);
            // 
            // btnYRaizX
            // 
            this.btnYRaizX.AutoSize = true;
            this.btnYRaizX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnYRaizX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnYRaizX.FlatAppearance.BorderSize = 0;
            this.btnYRaizX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYRaizX.Location = new System.Drawing.Point(70, 56);
            this.btnYRaizX.Margin = new System.Windows.Forms.Padding(1);
            this.btnYRaizX.Name = "btnYRaizX";
            this.btnYRaizX.Size = new System.Drawing.Size(67, 53);
            this.btnYRaizX.TabIndex = 10;
            this.btnYRaizX.Text = " ʸ√ₓ";
            this.btnYRaizX.UseVisualStyleBackColor = false;
            // 
            // btnXCubico
            // 
            this.btnXCubico.AutoSize = true;
            this.btnXCubico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnXCubico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXCubico.FlatAppearance.BorderSize = 0;
            this.btnXCubico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXCubico.Location = new System.Drawing.Point(1, 56);
            this.btnXCubico.Margin = new System.Windows.Forms.Padding(1);
            this.btnXCubico.Name = "btnXCubico";
            this.btnXCubico.Size = new System.Drawing.Size(67, 53);
            this.btnXCubico.TabIndex = 9;
            this.btnXCubico.Text = "xᶟ";
            this.btnXCubico.UseVisualStyleBackColor = false;
            this.btnXCubico.Click += new System.EventHandler(this.btnXCubico_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.AutoSize = true;
            this.btnDividir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnDividir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDividir.FlatAppearance.BorderSize = 0;
            this.btnDividir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDividir.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDividir.Location = new System.Drawing.Point(553, 1);
            this.btnDividir.Margin = new System.Windows.Forms.Padding(1);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(74, 53);
            this.btnDividir.TabIndex = 8;
            this.btnDividir.Text = "÷";
            this.btnDividir.UseVisualStyleBackColor = false;
            this.btnDividir.Click += new System.EventHandler(this.btnOperacao_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSize = true;
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(484, 1);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(1);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(67, 53);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = " ";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnC
            // 
            this.btnC.AutoSize = true;
            this.btnC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnC.FlatAppearance.BorderSize = 0;
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnC.Location = new System.Drawing.Point(415, 1);
            this.btnC.Margin = new System.Windows.Forms.Padding(1);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(67, 53);
            this.btnC.TabIndex = 6;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnCE
            // 
            this.btnCE.AutoSize = true;
            this.btnCE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnCE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCE.FlatAppearance.BorderSize = 0;
            this.btnCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCE.Location = new System.Drawing.Point(346, 1);
            this.btnCE.Margin = new System.Windows.Forms.Padding(1);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(67, 53);
            this.btnCE.TabIndex = 5;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnTan
            // 
            this.btnTan.AutoSize = true;
            this.btnTan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnTan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTan.FlatAppearance.BorderSize = 0;
            this.btnTan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTan.Location = new System.Drawing.Point(277, 1);
            this.btnTan.Margin = new System.Windows.Forms.Padding(1);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(67, 53);
            this.btnTan.TabIndex = 4;
            this.btnTan.Text = "tan";
            this.btnTan.UseVisualStyleBackColor = false;
            this.btnTan.Click += new System.EventHandler(this.btnTan_Click);
            // 
            // btnCos
            // 
            this.btnCos.AutoSize = true;
            this.btnCos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnCos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCos.FlatAppearance.BorderSize = 0;
            this.btnCos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCos.Location = new System.Drawing.Point(208, 1);
            this.btnCos.Margin = new System.Windows.Forms.Padding(1);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(67, 53);
            this.btnCos.TabIndex = 3;
            this.btnCos.Text = "cos";
            this.btnCos.UseVisualStyleBackColor = false;
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
            // 
            // btnSin
            // 
            this.btnSin.AutoSize = true;
            this.btnSin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnSin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSin.FlatAppearance.BorderSize = 0;
            this.btnSin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSin.Location = new System.Drawing.Point(139, 1);
            this.btnSin.Margin = new System.Windows.Forms.Padding(1);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(67, 53);
            this.btnSin.TabIndex = 2;
            this.btnSin.Text = "sin";
            this.btnSin.UseVisualStyleBackColor = false;
            this.btnSin.Click += new System.EventHandler(this.btnSin_Click);
            // 
            // btnXElevY
            // 
            this.btnXElevY.AutoSize = true;
            this.btnXElevY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnXElevY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXElevY.FlatAppearance.BorderSize = 0;
            this.btnXElevY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXElevY.Location = new System.Drawing.Point(70, 1);
            this.btnXElevY.Margin = new System.Windows.Forms.Padding(1);
            this.btnXElevY.Name = "btnXElevY";
            this.btnXElevY.Size = new System.Drawing.Size(67, 53);
            this.btnXElevY.TabIndex = 1;
            this.btnXElevY.Text = " x⁴";
            this.btnXElevY.UseVisualStyleBackColor = false;
            this.btnXElevY.Click += new System.EventHandler(this.btnXElevY_Click);
            // 
            // btnXQuad
            // 
            this.btnXQuad.AutoSize = true;
            this.btnXQuad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnXQuad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXQuad.FlatAppearance.BorderSize = 0;
            this.btnXQuad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXQuad.Location = new System.Drawing.Point(1, 1);
            this.btnXQuad.Margin = new System.Windows.Forms.Padding(1);
            this.btnXQuad.Name = "btnXQuad";
            this.btnXQuad.Size = new System.Drawing.Size(67, 53);
            this.btnXQuad.TabIndex = 0;
            this.btnXQuad.Text = " x²";
            this.btnXQuad.UseVisualStyleBackColor = false;
            this.btnXQuad.Click += new System.EventHandler(this.btnXQuad_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(3, 7);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(202, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Calculadora Científica";
            // 
            // wfaCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(622, 479);
            this.Controls.Add(this.splitTela);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(638, 518);
            this.Name = "wfaCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora Científica";
            this.splitTela.Panel1.ResumeLayout(false);
            this.splitTela.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitTela)).EndInit();
            this.splitTela.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitTela;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnXQuad;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnVirgula;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnMiasOuMenos;
        private System.Windows.Forms.Button btnParentDir;
        private System.Windows.Forms.Button btnParentEsq;
        private System.Windows.Forms.Button btnFat;
        private System.Windows.Forms.Button btnPi;
        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.Button btnMais;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnDois;
        private System.Windows.Forms.Button btnUm;
        private System.Windows.Forms.Button btnDeg;
        private System.Windows.Forms.Button btnDms;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnEElevX;
        private System.Windows.Forms.Button btnUmSobreX;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnQuatro;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnExp;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnDezElevX;
        private System.Windows.Forms.Button btnRaiz;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnNove;
        private System.Windows.Forms.Button btnOito;
        private System.Windows.Forms.Button btnSete;
        private System.Windows.Forms.Button btnYRaizX;
        private System.Windows.Forms.Button btnXCubico;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnTan;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.Button btnXElevY;
        private System.Windows.Forms.Label lblConta;
        private System.Windows.Forms.Button btnATang;
        private System.Windows.Forms.Button btnAcos;
        private System.Windows.Forms.Button btnAsin;
    }
}

