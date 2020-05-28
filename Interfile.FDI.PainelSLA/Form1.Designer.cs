namespace Interfile.FDI.PainelSLA
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.tClassificacao = new MetroFramework.Controls.MetroTile();
            this.tPreValidacao = new MetroFramework.Controls.MetroTile();
            this.tFormalizacao = new MetroFramework.Controls.MetroTile();
            this.tValidacao = new MetroFramework.Controls.MetroTile();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvFilaAtual = new MetroFramework.Controls.MetroGrid();
            this.fDIAUTOMACAODataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fDI_AUTOMACAODataSet = new Interfile.FDI.PainelSLA.FDI_AUTOMACAODataSet();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnAtualizar = new MetroFramework.Controls.MetroButton();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.lblClassificacao = new System.Windows.Forms.Label();
            this.lblPreValidacao = new System.Windows.Forms.Label();
            this.lblValidacao = new System.Windows.Forms.Label();
            this.lblFormalizacao = new System.Windows.Forms.Label();
            this.lblOnline = new System.Windows.Forms.Label();
            this.lblPausa = new System.Windows.Forms.Label();
            this.tClassificacao.SuspendLayout();
            this.tPreValidacao.SuspendLayout();
            this.tFormalizacao.SuspendLayout();
            this.tValidacao.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.metroTile1.SuspendLayout();
            this.metroTile3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilaAtual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fDIAUTOMACAODataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fDI_AUTOMACAODataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(331, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monitoramento - SLA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(629, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "[Data e Hora Atual]";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tClassificacao
            // 
            this.tClassificacao.ActiveControl = null;
            this.tClassificacao.Controls.Add(this.lblClassificacao);
            this.tClassificacao.Cursor = System.Windows.Forms.Cursors.Default;
            this.tClassificacao.Location = new System.Drawing.Point(21, 44);
            this.tClassificacao.Name = "tClassificacao";
            this.tClassificacao.PaintTileCount = false;
            this.tClassificacao.Size = new System.Drawing.Size(128, 76);
            this.tClassificacao.TabIndex = 3;
            this.tClassificacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tClassificacao.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tClassificacao.UseSelectable = true;
            this.tClassificacao.Click += new System.EventHandler(this.tClassificacao_Click);
            // 
            // tPreValidacao
            // 
            this.tPreValidacao.ActiveControl = null;
            this.tPreValidacao.Controls.Add(this.lblPreValidacao);
            this.tPreValidacao.Location = new System.Drawing.Point(155, 44);
            this.tPreValidacao.Name = "tPreValidacao";
            this.tPreValidacao.Size = new System.Drawing.Size(128, 76);
            this.tPreValidacao.TabIndex = 4;
            this.tPreValidacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tPreValidacao.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tPreValidacao.UseSelectable = true;
            // 
            // tFormalizacao
            // 
            this.tFormalizacao.ActiveControl = null;
            this.tFormalizacao.Controls.Add(this.lblFormalizacao);
            this.tFormalizacao.Location = new System.Drawing.Point(423, 44);
            this.tFormalizacao.Name = "tFormalizacao";
            this.tFormalizacao.Size = new System.Drawing.Size(128, 76);
            this.tFormalizacao.TabIndex = 8;
            this.tFormalizacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tFormalizacao.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tFormalizacao.UseSelectable = true;
            // 
            // tValidacao
            // 
            this.tValidacao.ActiveControl = null;
            this.tValidacao.Controls.Add(this.lblValidacao);
            this.tValidacao.Location = new System.Drawing.Point(289, 44);
            this.tValidacao.Name = "tValidacao";
            this.tValidacao.Size = new System.Drawing.Size(128, 76);
            this.tValidacao.TabIndex = 7;
            this.tValidacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tValidacao.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tValidacao.UseSelectable = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(25, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Classificação";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(158, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Pré Validação";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Location = new System.Drawing.Point(307, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Validação";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Location = new System.Drawing.Point(427, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Formalização";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.tValidacao);
            this.groupBox1.Controls.Add(this.tClassificacao);
            this.groupBox1.Controls.Add(this.tPreValidacao);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tFormalizacao);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Azure;
            this.groupBox1.Location = new System.Drawing.Point(178, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 135);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Etapas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SteelBlue;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label9.Location = new System.Drawing.Point(532, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(186, 37);
            this.label9.TabIndex = 18;
            this.label9.Text = "Fila Atual (0)";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.metroTile1);
            this.groupBox3.Controls.Add(this.metroTile3);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox3.Location = new System.Drawing.Point(759, 111);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(303, 135);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Controle de Pausa";
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Controls.Add(this.lblOnline);
            this.metroTile1.Location = new System.Drawing.Point(21, 44);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.PaintTileCount = false;
            this.metroTile1.Size = new System.Drawing.Size(128, 76);
            this.metroTile1.TabIndex = 3;
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click_1);
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Controls.Add(this.lblPausa);
            this.metroTile3.Location = new System.Drawing.Point(155, 44);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(128, 76);
            this.metroTile3.TabIndex = 4;
            this.metroTile3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile3.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label10.Location = new System.Drawing.Point(188, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 24);
            this.label10.TabIndex = 12;
            this.label10.Text = "Pausa";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label11.Location = new System.Drawing.Point(55, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 24);
            this.label11.TabIndex = 11;
            this.label11.Text = "Online";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // dgvFilaAtual
            // 
            this.dgvFilaAtual.AllowUserToAddRows = false;
            this.dgvFilaAtual.AllowUserToDeleteRows = false;
            this.dgvFilaAtual.AllowUserToResizeRows = false;
            this.dgvFilaAtual.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvFilaAtual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFilaAtual.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFilaAtual.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFilaAtual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFilaAtual.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFilaAtual.EnableHeadersVisualStyles = false;
            this.dgvFilaAtual.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvFilaAtual.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvFilaAtual.Location = new System.Drawing.Point(130, 252);
            this.dgvFilaAtual.Name = "dgvFilaAtual";
            this.dgvFilaAtual.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFilaAtual.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFilaAtual.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvFilaAtual.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFilaAtual.Size = new System.Drawing.Size(1000, 407);
            this.dgvFilaAtual.TabIndex = 21;
            this.dgvFilaAtual.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
            // 
            // fDIAUTOMACAODataSetBindingSource
            // 
            this.fDIAUTOMACAODataSetBindingSource.DataSource = this.fDI_AUTOMACAODataSet;
            this.fDIAUTOMACAODataSetBindingSource.Position = 0;
            this.fDIAUTOMACAODataSetBindingSource.CurrentChanged += new System.EventHandler(this.fDIAUTOMACAODataSetBindingSource_CurrentChanged);
            // 
            // fDI_AUTOMACAODataSet
            // 
            this.fDI_AUTOMACAODataSet.DataSetName = "FDI_AUTOMACAODataSet";
            this.fDI_AUTOMACAODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // timer2
            // 
            this.timer2.Interval = 10000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackgroundImage = global::Interfile.FDI.PainelSLA.Properties.Resources.Update_32;
            this.btnAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAtualizar.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAtualizar.Location = new System.Drawing.Point(1072, 6);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(55, 45);
            this.btnAtualizar.TabIndex = 22;
            this.btnAtualizar.UseSelectable = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // lblClassificacao
            // 
            this.lblClassificacao.AutoSize = true;
            this.lblClassificacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassificacao.Location = new System.Drawing.Point(42, 22);
            this.lblClassificacao.Name = "lblClassificacao";
            this.lblClassificacao.Size = new System.Drawing.Size(46, 31);
            this.lblClassificacao.TabIndex = 0;
            this.lblClassificacao.Text = "00";
            // 
            // lblPreValidacao
            // 
            this.lblPreValidacao.AutoSize = true;
            this.lblPreValidacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreValidacao.Location = new System.Drawing.Point(41, 23);
            this.lblPreValidacao.Name = "lblPreValidacao";
            this.lblPreValidacao.Size = new System.Drawing.Size(46, 31);
            this.lblPreValidacao.TabIndex = 0;
            this.lblPreValidacao.Text = "00";
            // 
            // lblValidacao
            // 
            this.lblValidacao.AutoSize = true;
            this.lblValidacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidacao.Location = new System.Drawing.Point(41, 24);
            this.lblValidacao.Name = "lblValidacao";
            this.lblValidacao.Size = new System.Drawing.Size(46, 31);
            this.lblValidacao.TabIndex = 0;
            this.lblValidacao.Text = "00";
            // 
            // lblFormalizacao
            // 
            this.lblFormalizacao.AutoSize = true;
            this.lblFormalizacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormalizacao.Location = new System.Drawing.Point(41, 24);
            this.lblFormalizacao.Name = "lblFormalizacao";
            this.lblFormalizacao.Size = new System.Drawing.Size(46, 31);
            this.lblFormalizacao.TabIndex = 0;
            this.lblFormalizacao.Text = "00";
            this.lblFormalizacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOnline
            // 
            this.lblOnline.AutoSize = true;
            this.lblOnline.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnline.ForeColor = System.Drawing.Color.Azure;
            this.lblOnline.Location = new System.Drawing.Point(44, 23);
            this.lblOnline.Name = "lblOnline";
            this.lblOnline.Size = new System.Drawing.Size(46, 31);
            this.lblOnline.TabIndex = 0;
            this.lblOnline.Text = "00";
            // 
            // lblPausa
            // 
            this.lblPausa.AutoSize = true;
            this.lblPausa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPausa.ForeColor = System.Drawing.Color.Azure;
            this.lblPausa.Location = new System.Drawing.Point(43, 24);
            this.lblPausa.Name = "lblPausa";
            this.lblPausa.Size = new System.Drawing.Size(46, 31);
            this.lblPausa.TabIndex = 0;
            this.lblPausa.Text = "00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1134, 698);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.dgvFilaAtual);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Controle Operacional -  SLA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tClassificacao.ResumeLayout(false);
            this.tClassificacao.PerformLayout();
            this.tPreValidacao.ResumeLayout(false);
            this.tPreValidacao.PerformLayout();
            this.tFormalizacao.ResumeLayout(false);
            this.tFormalizacao.PerformLayout();
            this.tValidacao.ResumeLayout(false);
            this.tValidacao.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.metroTile1.ResumeLayout(false);
            this.metroTile1.PerformLayout();
            this.metroTile3.ResumeLayout(false);
            this.metroTile3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilaAtual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fDIAUTOMACAODataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fDI_AUTOMACAODataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public MetroFramework.Controls.MetroTile tClassificacao;
        public MetroFramework.Controls.MetroTile tPreValidacao;
        public MetroFramework.Controls.MetroTile tFormalizacao;
        public MetroFramework.Controls.MetroTile tValidacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        public MetroFramework.Controls.MetroGrid dgvFilaAtual;
        private System.Windows.Forms.BindingSource fDIAUTOMACAODataSetBindingSource;
        private FDI_AUTOMACAODataSet fDI_AUTOMACAODataSet;
        private System.Windows.Forms.Timer timer2;
        public MetroFramework.Controls.MetroButton btnAtualizar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label lblClassificacao;
        private System.Windows.Forms.Label lblPreValidacao;
        private System.Windows.Forms.Label lblFormalizacao;
        private System.Windows.Forms.Label lblValidacao;
        private System.Windows.Forms.Label lblOnline;
        private System.Windows.Forms.Label lblPausa;
    }
}

