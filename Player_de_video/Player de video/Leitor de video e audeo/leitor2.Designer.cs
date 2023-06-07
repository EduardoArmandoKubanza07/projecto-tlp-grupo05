namespace Leitor_de_video_e_audeo
{
    partial class leitor2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(leitor2));
            this.timer_currentTime = new System.Windows.Forms.Timer(this.components);
            this.abrir_arquivo = new System.Windows.Forms.OpenFileDialog();
            this.pnl_cima = new System.Windows.Forms.Panel();
            this.lbl_nome_arquivo = new System.Windows.Forms.Label();
            this.btn_min = new System.Windows.Forms.Button();
            this.btn_max = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_normal = new System.Windows.Forms.Button();
            this.btn_comprimir = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.pnl_controles = new System.Windows.Forms.Panel();
            this.btn_expandir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_previous = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_parar = new System.Windows.Forms.Button();
            this.btn_rep_off = new System.Windows.Forms.Button();
            this.btn_rep_on = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_escolher = new System.Windows.Forms.Button();
            this.lbl_volume = new System.Windows.Forms.Label();
            this.trackBar_volume = new System.Windows.Forms.TrackBar();
            this.lbl_fim = new System.Windows.Forms.Label();
            this.trackBar_currentTime = new System.Windows.Forms.TrackBar();
            this.lbl_comeco = new System.Windows.Forms.Label();
            this.btn_playlist_on = new System.Windows.Forms.Button();
            this.btn_playlist_off = new System.Windows.Forms.Button();
            this.btn_com_som = new System.Windows.Forms.Button();
            this.btn_sem_som = new System.Windows.Forms.Button();
            this.pnl_play_list = new System.Windows.Forms.Panel();
            this.lst_playlist = new System.Windows.Forms.ListBox();
            this.btn_limpar_tudo = new System.Windows.Forms.Button();
            this.btn_limpar_selecionado = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pnl_cima.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.pnl_controles.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_currentTime)).BeginInit();
            this.pnl_play_list.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer_currentTime
            // 
            this.timer_currentTime.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // abrir_arquivo
            // 
            this.abrir_arquivo.FileName = "openFileDialog1";
            this.abrir_arquivo.Multiselect = true;
            this.abrir_arquivo.FileOk += new System.ComponentModel.CancelEventHandler(this.abrir_arquivo_FileOk);
            // 
            // pnl_cima
            // 
            this.pnl_cima.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.pnl_cima.Controls.Add(this.lbl_nome_arquivo);
            this.pnl_cima.Controls.Add(this.btn_min);
            this.pnl_cima.Controls.Add(this.btn_max);
            this.pnl_cima.Controls.Add(this.btn_sair);
            this.pnl_cima.Controls.Add(this.btn_normal);
            this.pnl_cima.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_cima.ForeColor = System.Drawing.Color.Black;
            this.pnl_cima.Location = new System.Drawing.Point(1, 1);
            this.pnl_cima.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_cima.Name = "pnl_cima";
            this.pnl_cima.Size = new System.Drawing.Size(1299, 51);
            this.pnl_cima.TabIndex = 0;
            this.pnl_cima.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_cima_MouseDown);
            // 
            // lbl_nome_arquivo
            // 
            this.lbl_nome_arquivo.AutoSize = true;
            this.lbl_nome_arquivo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nome_arquivo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_arquivo.ForeColor = System.Drawing.Color.Black;
            this.lbl_nome_arquivo.Location = new System.Drawing.Point(28, 18);
            this.lbl_nome_arquivo.Name = "lbl_nome_arquivo";
            this.lbl_nome_arquivo.Size = new System.Drawing.Size(116, 19);
            this.lbl_nome_arquivo.TabIndex = 14;
            this.lbl_nome_arquivo.Text = "Nome do arquivo";
            // 
            // btn_min
            // 
            this.btn_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_min.BackColor = System.Drawing.Color.Transparent;
            this.btn_min.FlatAppearance.BorderSize = 0;
            this.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_min.ForeColor = System.Drawing.Color.Black;
            this.btn_min.Image = global::Leitor_de_video_e_audeo.Properties.Resources.icons8_subtract_161;
            this.btn_min.Location = new System.Drawing.Point(1158, 0);
            this.btn_min.Margin = new System.Windows.Forms.Padding(0);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(47, 41);
            this.btn_min.TabIndex = 0;
            this.btn_min.UseVisualStyleBackColor = false;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // btn_max
            // 
            this.btn_max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_max.BackColor = System.Drawing.Color.Transparent;
            this.btn_max.FlatAppearance.BorderSize = 0;
            this.btn_max.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_max.ForeColor = System.Drawing.Color.Black;
            this.btn_max.Image = global::Leitor_de_video_e_audeo.Properties.Resources.icons8_maximize_button_161;
            this.btn_max.Location = new System.Drawing.Point(1205, 0);
            this.btn_max.Margin = new System.Windows.Forms.Padding(0);
            this.btn_max.Name = "btn_max";
            this.btn_max.Size = new System.Drawing.Size(47, 41);
            this.btn_max.TabIndex = 2;
            this.btn_max.UseVisualStyleBackColor = false;
            this.btn_max.Click += new System.EventHandler(this.btn_max_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sair.BackColor = System.Drawing.Color.Transparent;
            this.btn_sair.FlatAppearance.BorderSize = 0;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.ForeColor = System.Drawing.Color.Black;
            this.btn_sair.Image = global::Leitor_de_video_e_audeo.Properties.Resources.icons8_delete_161;
            this.btn_sair.Location = new System.Drawing.Point(1252, 0);
            this.btn_sair.Margin = new System.Windows.Forms.Padding(0);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(47, 41);
            this.btn_sair.TabIndex = 4;
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_normal
            // 
            this.btn_normal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_normal.BackColor = System.Drawing.Color.Transparent;
            this.btn_normal.FlatAppearance.BorderSize = 0;
            this.btn_normal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_normal.ForeColor = System.Drawing.Color.Black;
            this.btn_normal.Image = global::Leitor_de_video_e_audeo.Properties.Resources.icons8_maximize_button1_16;
            this.btn_normal.Location = new System.Drawing.Point(1205, 0);
            this.btn_normal.Margin = new System.Windows.Forms.Padding(0);
            this.btn_normal.Name = "btn_normal";
            this.btn_normal.Size = new System.Drawing.Size(47, 41);
            this.btn_normal.TabIndex = 3;
            this.btn_normal.UseVisualStyleBackColor = false;
            this.btn_normal.Click += new System.EventHandler(this.btn_normal_Click);
            // 
            // btn_comprimir
            // 
            this.btn_comprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_comprimir.BackColor = System.Drawing.Color.Transparent;
            this.btn_comprimir.FlatAppearance.BorderSize = 0;
            this.btn_comprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_comprimir.ForeColor = System.Drawing.Color.Black;
            this.btn_comprimir.Image = global::Leitor_de_video_e_audeo.Properties.Resources.icons8_compress3_32;
            this.btn_comprimir.Location = new System.Drawing.Point(962, 76);
            this.btn_comprimir.Margin = new System.Windows.Forms.Padding(0);
            this.btn_comprimir.Name = "btn_comprimir";
            this.btn_comprimir.Size = new System.Drawing.Size(31, 33);
            this.btn_comprimir.TabIndex = 18;
            this.btn_comprimir.UseVisualStyleBackColor = false;
            this.btn_comprimir.Visible = false;
            this.btn_comprimir.Click += new System.EventHandler(this.btn_comprimir_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axWindowsMediaPlayer1.BackColor = System.Drawing.Color.White;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.ForeColor = System.Drawing.Color.Black;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(1, 52);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(1299, 559);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.ClickEvent += new AxWMPLib._WMPOCXEvents_ClickEventHandler(this.axWindowsMediaPlayer1_ClickEvent);
            this.axWindowsMediaPlayer1.MouseMoveEvent += new AxWMPLib._WMPOCXEvents_MouseMoveEventHandler(this.axWindowsMediaPlayer1_MouseMoveEvent);
            this.axWindowsMediaPlayer1.MouseCaptureChanged += new System.EventHandler(this.axWindowsMediaPlayer1_MouseCaptureChanged);
            // 
            // pnl_controles
            // 
            this.pnl_controles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.pnl_controles.Controls.Add(this.btn_expandir);
            this.pnl_controles.Controls.Add(this.groupBox1);
            this.pnl_controles.Controls.Add(this.btn_escolher);
            this.pnl_controles.Controls.Add(this.lbl_volume);
            this.pnl_controles.Controls.Add(this.trackBar_volume);
            this.pnl_controles.Controls.Add(this.lbl_fim);
            this.pnl_controles.Controls.Add(this.trackBar_currentTime);
            this.pnl_controles.Controls.Add(this.lbl_comeco);
            this.pnl_controles.Controls.Add(this.btn_playlist_on);
            this.pnl_controles.Controls.Add(this.btn_playlist_off);
            this.pnl_controles.Controls.Add(this.btn_com_som);
            this.pnl_controles.Controls.Add(this.btn_sem_som);
            this.pnl_controles.Controls.Add(this.btn_comprimir);
            this.pnl_controles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_controles.ForeColor = System.Drawing.Color.Black;
            this.pnl_controles.Location = new System.Drawing.Point(1, 606);
            this.pnl_controles.Name = "pnl_controles";
            this.pnl_controles.Size = new System.Drawing.Size(1299, 127);
            this.pnl_controles.TabIndex = 2;
            // 
            // btn_expandir
            // 
            this.btn_expandir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_expandir.BackColor = System.Drawing.Color.Transparent;
            this.btn_expandir.Enabled = false;
            this.btn_expandir.FlatAppearance.BorderSize = 0;
            this.btn_expandir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_expandir.ForeColor = System.Drawing.Color.Black;
            this.btn_expandir.Image = global::Leitor_de_video_e_audeo.Properties.Resources.icons8_expand_32;
            this.btn_expandir.Location = new System.Drawing.Point(962, 76);
            this.btn_expandir.Margin = new System.Windows.Forms.Padding(0);
            this.btn_expandir.Name = "btn_expandir";
            this.btn_expandir.Size = new System.Drawing.Size(31, 33);
            this.btn_expandir.TabIndex = 5;
            this.btn_expandir.UseVisualStyleBackColor = false;
            this.btn_expandir.Click += new System.EventHandler(this.btn_expandir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn_previous);
            this.groupBox1.Controls.Add(this.btn_next);
            this.groupBox1.Controls.Add(this.btn_parar);
            this.groupBox1.Controls.Add(this.btn_rep_off);
            this.groupBox1.Controls.Add(this.btn_rep_on);
            this.groupBox1.Controls.Add(this.btn_play);
            this.groupBox1.Controls.Add(this.btn_pause);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(359, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 57);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // btn_previous
            // 
            this.btn_previous.BackColor = System.Drawing.Color.Transparent;
            this.btn_previous.Enabled = false;
            this.btn_previous.FlatAppearance.BorderSize = 0;
            this.btn_previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_previous.ForeColor = System.Drawing.Color.Black;
            this.btn_previous.Image = global::Leitor_de_video_e_audeo.Properties.Resources.icons8_skip_to_start_32;
            this.btn_previous.Location = new System.Drawing.Point(164, 11);
            this.btn_previous.Margin = new System.Windows.Forms.Padding(0);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(47, 41);
            this.btn_previous.TabIndex = 1;
            this.btn_previous.UseVisualStyleBackColor = false;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.Transparent;
            this.btn_next.Enabled = false;
            this.btn_next.FlatAppearance.BorderSize = 0;
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.ForeColor = System.Drawing.Color.Black;
            this.btn_next.Image = global::Leitor_de_video_e_audeo.Properties.Resources.icons8_end_32;
            this.btn_next.Location = new System.Drawing.Point(278, 11);
            this.btn_next.Margin = new System.Windows.Forms.Padding(0);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(47, 41);
            this.btn_next.TabIndex = 3;
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_parar
            // 
            this.btn_parar.BackColor = System.Drawing.Color.Transparent;
            this.btn_parar.Enabled = false;
            this.btn_parar.FlatAppearance.BorderSize = 0;
            this.btn_parar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_parar.ForeColor = System.Drawing.Color.Black;
            this.btn_parar.Image = global::Leitor_de_video_e_audeo.Properties.Resources.icons8_stop_32;
            this.btn_parar.Location = new System.Drawing.Point(93, 11);
            this.btn_parar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_parar.Name = "btn_parar";
            this.btn_parar.Size = new System.Drawing.Size(47, 41);
            this.btn_parar.TabIndex = 0;
            this.btn_parar.UseVisualStyleBackColor = false;
            this.btn_parar.Click += new System.EventHandler(this.btn_parar_Click);
            // 
            // btn_rep_off
            // 
            this.btn_rep_off.BackColor = System.Drawing.Color.Transparent;
            this.btn_rep_off.Enabled = false;
            this.btn_rep_off.FlatAppearance.BorderSize = 0;
            this.btn_rep_off.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rep_off.ForeColor = System.Drawing.Color.Black;
            this.btn_rep_off.Image = global::Leitor_de_video_e_audeo.Properties.Resources.icons8_repeat_32;
            this.btn_rep_off.Location = new System.Drawing.Point(354, 11);
            this.btn_rep_off.Margin = new System.Windows.Forms.Padding(0);
            this.btn_rep_off.Name = "btn_rep_off";
            this.btn_rep_off.Size = new System.Drawing.Size(47, 41);
            this.btn_rep_off.TabIndex = 4;
            this.btn_rep_off.UseVisualStyleBackColor = false;
            this.btn_rep_off.Click += new System.EventHandler(this.btn_rep_off_Click);
            // 
            // btn_rep_on
            // 
            this.btn_rep_on.BackColor = System.Drawing.Color.Transparent;
            this.btn_rep_on.FlatAppearance.BorderSize = 0;
            this.btn_rep_on.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rep_on.ForeColor = System.Drawing.Color.Black;
            this.btn_rep_on.Image = global::Leitor_de_video_e_audeo.Properties.Resources.icons8_repeata_32;
            this.btn_rep_on.Location = new System.Drawing.Point(354, 11);
            this.btn_rep_on.Margin = new System.Windows.Forms.Padding(0);
            this.btn_rep_on.Name = "btn_rep_on";
            this.btn_rep_on.Size = new System.Drawing.Size(47, 41);
            this.btn_rep_on.TabIndex = 12;
            this.btn_rep_on.UseVisualStyleBackColor = false;
            this.btn_rep_on.Click += new System.EventHandler(this.btn_rep_on_Click);
            // 
            // btn_play
            // 
            this.btn_play.BackColor = System.Drawing.Color.Transparent;
            this.btn_play.Enabled = false;
            this.btn_play.FlatAppearance.BorderSize = 0;
            this.btn_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_play.ForeColor = System.Drawing.Color.Black;
            this.btn_play.Image = global::Leitor_de_video_e_audeo.Properties.Resources.icons8_play_32;
            this.btn_play.Location = new System.Drawing.Point(220, 11);
            this.btn_play.Margin = new System.Windows.Forms.Padding(0);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(47, 41);
            this.btn_play.TabIndex = 2;
            this.btn_play.UseVisualStyleBackColor = false;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.BackColor = System.Drawing.Color.Transparent;
            this.btn_pause.FlatAppearance.BorderSize = 0;
            this.btn_pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pause.ForeColor = System.Drawing.Color.Black;
            this.btn_pause.Image = global::Leitor_de_video_e_audeo.Properties.Resources.icons8_pause_32;
            this.btn_pause.Location = new System.Drawing.Point(220, 11);
            this.btn_pause.Margin = new System.Windows.Forms.Padding(0);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(47, 41);
            this.btn_pause.TabIndex = 4;
            this.btn_pause.UseVisualStyleBackColor = false;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_escolher
            // 
            this.btn_escolher.BackColor = System.Drawing.Color.Transparent;
            this.btn_escolher.FlatAppearance.BorderSize = 0;
            this.btn_escolher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_escolher.ForeColor = System.Drawing.Color.Black;
            this.btn_escolher.Image = global::Leitor_de_video_e_audeo.Properties.Resources.icons8_star_32;
            this.btn_escolher.Location = new System.Drawing.Point(13, 72);
            this.btn_escolher.Margin = new System.Windows.Forms.Padding(0);
            this.btn_escolher.Name = "btn_escolher";
            this.btn_escolher.Size = new System.Drawing.Size(47, 41);
            this.btn_escolher.TabIndex = 1;
            this.btn_escolher.UseVisualStyleBackColor = false;
            this.btn_escolher.Click += new System.EventHandler(this.btn_escolher_Click);
            // 
            // lbl_volume
            // 
            this.lbl_volume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_volume.AutoSize = true;
            this.lbl_volume.BackColor = System.Drawing.Color.Transparent;
            this.lbl_volume.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_volume.ForeColor = System.Drawing.Color.Black;
            this.lbl_volume.Location = new System.Drawing.Point(1220, 82);
            this.lbl_volume.Name = "lbl_volume";
            this.lbl_volume.Size = new System.Drawing.Size(37, 19);
            this.lbl_volume.TabIndex = 9;
            this.lbl_volume.Text = "50%";
            // 
            // trackBar_volume
            // 
            this.trackBar_volume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar_volume.AutoSize = false;
            this.trackBar_volume.BackColor = System.Drawing.Color.White;
            this.trackBar_volume.Location = new System.Drawing.Point(1059, 82);
            this.trackBar_volume.Maximum = 100;
            this.trackBar_volume.Name = "trackBar_volume";
            this.trackBar_volume.Size = new System.Drawing.Size(155, 30);
            this.trackBar_volume.TabIndex = 7;
            this.trackBar_volume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_volume.Value = 50;
            this.trackBar_volume.Scroll += new System.EventHandler(this.trackBar_volume_Scroll);
            // 
            // lbl_fim
            // 
            this.lbl_fim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_fim.AutoSize = true;
            this.lbl_fim.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fim.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fim.ForeColor = System.Drawing.Color.Black;
            this.lbl_fim.Location = new System.Drawing.Point(1209, 39);
            this.lbl_fim.Name = "lbl_fim";
            this.lbl_fim.Size = new System.Drawing.Size(65, 19);
            this.lbl_fim.TabIndex = 2;
            this.lbl_fim.Text = "00:00:00";
            // 
            // trackBar_currentTime
            // 
            this.trackBar_currentTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar_currentTime.AutoSize = false;
            this.trackBar_currentTime.BackColor = System.Drawing.Color.White;
            this.trackBar_currentTime.Location = new System.Drawing.Point(7, 8);
            this.trackBar_currentTime.Maximum = 100;
            this.trackBar_currentTime.Minimum = 100;
            this.trackBar_currentTime.Name = "trackBar_currentTime";
            this.trackBar_currentTime.Size = new System.Drawing.Size(1282, 28);
            this.trackBar_currentTime.TabIndex = 0;
            this.trackBar_currentTime.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_currentTime.Value = 100;
            this.trackBar_currentTime.Scroll += new System.EventHandler(this.trackBar_currentTime_Scroll);
            // 
            // lbl_comeco
            // 
            this.lbl_comeco.AutoSize = true;
            this.lbl_comeco.BackColor = System.Drawing.Color.Transparent;
            this.lbl_comeco.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_comeco.ForeColor = System.Drawing.Color.Black;
            this.lbl_comeco.Location = new System.Drawing.Point(3, 39);
            this.lbl_comeco.Name = "lbl_comeco";
            this.lbl_comeco.Size = new System.Drawing.Size(65, 19);
            this.lbl_comeco.TabIndex = 0;
            this.lbl_comeco.Text = "00:00:00";
            // 
            // btn_playlist_on
            // 
            this.btn_playlist_on.BackColor = System.Drawing.Color.Transparent;
            this.btn_playlist_on.FlatAppearance.BorderSize = 0;
            this.btn_playlist_on.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_playlist_on.ForeColor = System.Drawing.Color.Black;
            this.btn_playlist_on.Image = global::Leitor_de_video_e_audeo.Properties.Resources.icons8_toggle_on_32;
            this.btn_playlist_on.Location = new System.Drawing.Point(69, 74);
            this.btn_playlist_on.Margin = new System.Windows.Forms.Padding(0);
            this.btn_playlist_on.Name = "btn_playlist_on";
            this.btn_playlist_on.Size = new System.Drawing.Size(47, 41);
            this.btn_playlist_on.TabIndex = 2;
            this.btn_playlist_on.UseVisualStyleBackColor = false;
            this.btn_playlist_on.Click += new System.EventHandler(this.btn_playlist_on_Click);
            // 
            // btn_playlist_off
            // 
            this.btn_playlist_off.BackColor = System.Drawing.Color.Transparent;
            this.btn_playlist_off.FlatAppearance.BorderSize = 0;
            this.btn_playlist_off.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_playlist_off.ForeColor = System.Drawing.Color.Black;
            this.btn_playlist_off.Image = global::Leitor_de_video_e_audeo.Properties.Resources.icons8_toggle_off_32;
            this.btn_playlist_off.Location = new System.Drawing.Point(69, 74);
            this.btn_playlist_off.Margin = new System.Windows.Forms.Padding(0);
            this.btn_playlist_off.Name = "btn_playlist_off";
            this.btn_playlist_off.Size = new System.Drawing.Size(47, 41);
            this.btn_playlist_off.TabIndex = 3;
            this.btn_playlist_off.UseVisualStyleBackColor = false;
            this.btn_playlist_off.Visible = false;
            this.btn_playlist_off.Click += new System.EventHandler(this.btn_playlist_off_Click);
            // 
            // btn_com_som
            // 
            this.btn_com_som.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_com_som.BackColor = System.Drawing.Color.Transparent;
            this.btn_com_som.FlatAppearance.BorderSize = 0;
            this.btn_com_som.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_com_som.ForeColor = System.Drawing.Color.Black;
            this.btn_com_som.Image = global::Leitor_de_video_e_audeo.Properties.Resources.icons8_audio_16;
            this.btn_com_som.Location = new System.Drawing.Point(1009, 73);
            this.btn_com_som.Margin = new System.Windows.Forms.Padding(0);
            this.btn_com_som.Name = "btn_com_som";
            this.btn_com_som.Size = new System.Drawing.Size(47, 41);
            this.btn_com_som.TabIndex = 6;
            this.btn_com_som.UseVisualStyleBackColor = false;
            this.btn_com_som.Click += new System.EventHandler(this.btn_com_som_Click);
            // 
            // btn_sem_som
            // 
            this.btn_sem_som.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sem_som.BackColor = System.Drawing.Color.Transparent;
            this.btn_sem_som.FlatAppearance.BorderSize = 0;
            this.btn_sem_som.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sem_som.ForeColor = System.Drawing.Color.Black;
            this.btn_sem_som.Image = global::Leitor_de_video_e_audeo.Properties.Resources.icons8_no_audio_16;
            this.btn_sem_som.Location = new System.Drawing.Point(1009, 73);
            this.btn_sem_som.Margin = new System.Windows.Forms.Padding(0);
            this.btn_sem_som.Name = "btn_sem_som";
            this.btn_sem_som.Size = new System.Drawing.Size(47, 41);
            this.btn_sem_som.TabIndex = 14;
            this.btn_sem_som.UseVisualStyleBackColor = false;
            this.btn_sem_som.Click += new System.EventHandler(this.btn_sem_som_Click);
            // 
            // pnl_play_list
            // 
            this.pnl_play_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_play_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.pnl_play_list.Controls.Add(this.lst_playlist);
            this.pnl_play_list.Controls.Add(this.btn_limpar_tudo);
            this.pnl_play_list.Controls.Add(this.btn_limpar_selecionado);
            this.pnl_play_list.Controls.Add(this.label2);
            this.pnl_play_list.ForeColor = System.Drawing.Color.Black;
            this.pnl_play_list.Location = new System.Drawing.Point(1, 52);
            this.pnl_play_list.Name = "pnl_play_list";
            this.pnl_play_list.Size = new System.Drawing.Size(1299, 593);
            this.pnl_play_list.TabIndex = 3;
            this.pnl_play_list.Visible = false;
            // 
            // lst_playlist
            // 
            this.lst_playlist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lst_playlist.BackColor = System.Drawing.Color.White;
            this.lst_playlist.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_playlist.ForeColor = System.Drawing.Color.Black;
            this.lst_playlist.FormattingEnabled = true;
            this.lst_playlist.ItemHeight = 17;
            this.lst_playlist.Location = new System.Drawing.Point(7, 87);
            this.lst_playlist.Name = "lst_playlist";
            this.lst_playlist.Size = new System.Drawing.Size(1282, 412);
            this.lst_playlist.TabIndex = 1;
            this.lst_playlist.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lst_playlist_MouseDoubleClick);
            // 
            // btn_limpar_tudo
            // 
            this.btn_limpar_tudo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_limpar_tudo.BackColor = System.Drawing.Color.Transparent;
            this.btn_limpar_tudo.FlatAppearance.BorderSize = 0;
            this.btn_limpar_tudo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpar_tudo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar_tudo.ForeColor = System.Drawing.Color.Black;
            this.btn_limpar_tudo.Image = global::Leitor_de_video_e_audeo.Properties.Resources.icons8_empty_trash_32;
            this.btn_limpar_tudo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_limpar_tudo.Location = new System.Drawing.Point(644, 510);
            this.btn_limpar_tudo.Margin = new System.Windows.Forms.Padding(0);
            this.btn_limpar_tudo.Name = "btn_limpar_tudo";
            this.btn_limpar_tudo.Size = new System.Drawing.Size(256, 41);
            this.btn_limpar_tudo.TabIndex = 14;
            this.btn_limpar_tudo.Text = "       Limpar Lista De Reprodução";
            this.btn_limpar_tudo.UseVisualStyleBackColor = false;
            this.btn_limpar_tudo.Click += new System.EventHandler(this.btn_limpar_tudo_Click_1);
            // 
            // btn_limpar_selecionado
            // 
            this.btn_limpar_selecionado.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_limpar_selecionado.BackColor = System.Drawing.Color.Transparent;
            this.btn_limpar_selecionado.FlatAppearance.BorderSize = 0;
            this.btn_limpar_selecionado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpar_selecionado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar_selecionado.ForeColor = System.Drawing.Color.Black;
            this.btn_limpar_selecionado.Image = global::Leitor_de_video_e_audeo.Properties.Resources.icons8_subtract_32;
            this.btn_limpar_selecionado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_limpar_selecionado.Location = new System.Drawing.Point(399, 510);
            this.btn_limpar_selecionado.Margin = new System.Windows.Forms.Padding(0);
            this.btn_limpar_selecionado.Name = "btn_limpar_selecionado";
            this.btn_limpar_selecionado.Size = new System.Drawing.Size(245, 41);
            this.btn_limpar_selecionado.TabIndex = 13;
            this.btn_limpar_selecionado.Text = "     Limpar   Item Selecionado";
            this.btn_limpar_selecionado.UseVisualStyleBackColor = false;
            this.btn_limpar_selecionado.Click += new System.EventHandler(this.btn_limpar_selecionado_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(531, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lista de reprodução";
            // 
            // leitor2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 734);
            this.Controls.Add(this.pnl_controles);
            this.Controls.Add(this.pnl_cima);
            this.Controls.Add(this.pnl_play_list);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "leitor2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DotNetBar Metro App Form";
            this.Load += new System.EventHandler(this.leitor2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.leitor2_KeyDown);
            this.pnl_cima.ResumeLayout(false);
            this.pnl_cima.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.pnl_controles.ResumeLayout(false);
            this.pnl_controles.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_currentTime)).EndInit();
            this.pnl_play_list.ResumeLayout(false);
            this.pnl_play_list.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer_currentTime;
        private System.Windows.Forms.OpenFileDialog abrir_arquivo;
        private System.Windows.Forms.Panel pnl_cima;
        private System.Windows.Forms.Button btn_normal;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Button btn_max;
        private System.Windows.Forms.Button btn_sair;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Panel pnl_controles;
        private System.Windows.Forms.Button btn_escolher;
        private System.Windows.Forms.Label lbl_volume;
        private System.Windows.Forms.TrackBar trackBar_volume;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_previous;
        private System.Windows.Forms.Button btn_parar;
        private System.Windows.Forms.Label lbl_fim;
        private System.Windows.Forms.TrackBar trackBar_currentTime;
        private System.Windows.Forms.Label lbl_comeco;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button btn_rep_off;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_sem_som;
        private System.Windows.Forms.Button btn_com_som;
        private System.Windows.Forms.Label lbl_nome_arquivo;
        private System.Windows.Forms.Panel pnl_play_list;
        private System.Windows.Forms.Button btn_limpar_tudo;
        private System.Windows.Forms.Button btn_limpar_selecionado;
        private System.Windows.Forms.ListBox lst_playlist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_playlist_on;
        private System.Windows.Forms.Button btn_playlist_off;
        private System.Windows.Forms.Button btn_rep_on;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btn_expandir;
        private System.Windows.Forms.Button btn_comprimir;
    }
}

