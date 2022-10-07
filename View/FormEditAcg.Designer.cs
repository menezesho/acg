namespace projeto_acg
{
    partial class FormEditAcg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditAcg));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbsair = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgacg = new System.Windows.Forms.DataGridView();
            this.bteditar = new System.Windows.Forms.Button();
            this.btcancelar = new System.Windows.Forms.Button();
            this.lbeditar = new System.Windows.Forms.Label();
            this.btexcluir = new System.Windows.Forms.Button();
            this.btsalvar = new System.Windows.Forms.Button();
            this.tbtipo = new System.Windows.Forms.TextBox();
            this.lbtipo = new System.Windows.Forms.Label();
            this.mtbhoras = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbmodalidade = new System.Windows.Forms.ComboBox();
            this.lbmodalidade = new System.Windows.Forms.Label();
            this.tbnome = new System.Windows.Forms.TextBox();
            this.lbnome = new System.Windows.Forms.Label();
            this.tbbusca = new System.Windows.Forms.TextBox();
            this.lbbusca = new System.Windows.Forms.Label();
            this.tbid = new System.Windows.Forms.TextBox();
            this.lbid = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dgacg)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbsair
            // 
            this.lbsair.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbsair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbsair.Font = new System.Drawing.Font("Segoe UI Semibold", 11.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbsair.ForeColor = System.Drawing.SystemColors.Control;
            this.lbsair.Image = ((System.Drawing.Image)(resources.GetObject("lbsair.Image")));
            this.lbsair.Location = new System.Drawing.Point(1144, 572);
            this.lbsair.Name = "lbsair";
            this.lbsair.Size = new System.Drawing.Size(32, 36);
            this.lbsair.TabIndex = 11;
            this.lbsair.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbsair.Click += new System.EventHandler(this.lbsair_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(546, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(630, 38);
            this.label2.TabIndex = 41;
            this.label2.Text = "TODAS AS ACGs";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgacg
            // 
            this.dgacg.AllowUserToAddRows = false;
            this.dgacg.AllowUserToDeleteRows = false;
            this.dgacg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgacg.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgacg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgacg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgacg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgacg.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgacg.Location = new System.Drawing.Point(542, 170);
            this.dgacg.Margin = new System.Windows.Forms.Padding(4);
            this.dgacg.MultiSelect = false;
            this.dgacg.Name = "dgacg";
            this.dgacg.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgacg.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgacg.RowHeadersVisible = false;
            this.dgacg.RowHeadersWidth = 51;
            this.dgacg.RowTemplate.Height = 29;
            this.dgacg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgacg.Size = new System.Drawing.Size(634, 393);
            this.dgacg.TabIndex = 10;
            this.dgacg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgacg_CellClick);
            // 
            // bteditar
            // 
            this.bteditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bteditar.BackColor = System.Drawing.Color.GhostWhite;
            this.bteditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bteditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bteditar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bteditar.ForeColor = System.Drawing.Color.SteelBlue;
            this.bteditar.Location = new System.Drawing.Point(85, 483);
            this.bteditar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bteditar.Name = "bteditar";
            this.bteditar.Size = new System.Drawing.Size(199, 36);
            this.bteditar.TabIndex = 4;
            this.bteditar.Text = "EDITAR";
            this.bteditar.UseVisualStyleBackColor = false;
            this.bteditar.Click += new System.EventHandler(this.bteditar_Click);
            // 
            // btcancelar
            // 
            this.btcancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btcancelar.BackColor = System.Drawing.Color.GhostWhite;
            this.btcancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btcancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btcancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btcancelar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btcancelar.Location = new System.Drawing.Point(85, 527);
            this.btcancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(406, 36);
            this.btcancelar.TabIndex = 6;
            this.btcancelar.Text = "CANCELAR";
            this.btcancelar.UseVisualStyleBackColor = false;
            this.btcancelar.Click += new System.EventHandler(this.btcancelar_Click);
            // 
            // lbeditar
            // 
            this.lbeditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbeditar.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbeditar.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbeditar.Location = new System.Drawing.Point(138, 61);
            this.lbeditar.Name = "lbeditar";
            this.lbeditar.Size = new System.Drawing.Size(300, 38);
            this.lbeditar.TabIndex = 38;
            this.lbeditar.Text = "EDITAR ACG";
            this.lbeditar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btexcluir
            // 
            this.btexcluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btexcluir.BackColor = System.Drawing.Color.GhostWhite;
            this.btexcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btexcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btexcluir.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btexcluir.ForeColor = System.Drawing.Color.SteelBlue;
            this.btexcluir.Location = new System.Drawing.Point(291, 483);
            this.btexcluir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btexcluir.Name = "btexcluir";
            this.btexcluir.Size = new System.Drawing.Size(201, 36);
            this.btexcluir.TabIndex = 5;
            this.btexcluir.Text = "EXCLUIR";
            this.btexcluir.UseVisualStyleBackColor = false;
            this.btexcluir.Click += new System.EventHandler(this.btexcluir_Click);
            // 
            // btsalvar
            // 
            this.btsalvar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btsalvar.BackColor = System.Drawing.Color.SteelBlue;
            this.btsalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btsalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsalvar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btsalvar.ForeColor = System.Drawing.Color.White;
            this.btsalvar.Location = new System.Drawing.Point(85, 572);
            this.btsalvar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btsalvar.Name = "btsalvar";
            this.btsalvar.Size = new System.Drawing.Size(406, 36);
            this.btsalvar.TabIndex = 7;
            this.btsalvar.Text = "SALVAR";
            this.btsalvar.UseVisualStyleBackColor = false;
            this.btsalvar.Click += new System.EventHandler(this.btsalvar_Click);
            // 
            // tbtipo
            // 
            this.tbtipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbtipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbtipo.Location = new System.Drawing.Point(51, 273);
            this.tbtipo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbtipo.MaxLength = 50;
            this.tbtipo.Name = "tbtipo";
            this.tbtipo.Size = new System.Drawing.Size(300, 29);
            this.tbtipo.TabIndex = 3;
            // 
            // lbtipo
            // 
            this.lbtipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbtipo.AutoSize = true;
            this.lbtipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbtipo.Location = new System.Drawing.Point(51, 248);
            this.lbtipo.Name = "lbtipo";
            this.lbtipo.Size = new System.Drawing.Size(40, 21);
            this.lbtipo.TabIndex = 49;
            this.lbtipo.Text = "Tipo";
            // 
            // mtbhoras
            // 
            this.mtbhoras.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbhoras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mtbhoras.HidePromptOnLeave = true;
            this.mtbhoras.Location = new System.Drawing.Point(51, 160);
            this.mtbhoras.Mask = "00";
            this.mtbhoras.Name = "mtbhoras";
            this.mtbhoras.Size = new System.Drawing.Size(52, 29);
            this.mtbhoras.TabIndex = 1;
            this.mtbhoras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbhoras.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(51, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 21);
            this.label1.TabIndex = 47;
            this.label1.Text = "Horas";
            // 
            // cbmodalidade
            // 
            this.cbmodalidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbmodalidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbmodalidade.FormattingEnabled = true;
            this.cbmodalidade.Items.AddRange(new object[] {
            "Selecione",
            "Formação Profissional",
            "Extensão Universitária",
            "Pesquisa",
            "Ensino",
            "Políticas",
            "Empreendedorismo e Inovação"});
            this.cbmodalidade.Location = new System.Drawing.Point(51, 216);
            this.cbmodalidade.Name = "cbmodalidade";
            this.cbmodalidade.Size = new System.Drawing.Size(300, 29);
            this.cbmodalidade.TabIndex = 2;
            // 
            // lbmodalidade
            // 
            this.lbmodalidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbmodalidade.AutoSize = true;
            this.lbmodalidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbmodalidade.Location = new System.Drawing.Point(51, 192);
            this.lbmodalidade.Name = "lbmodalidade";
            this.lbmodalidade.Size = new System.Drawing.Size(92, 21);
            this.lbmodalidade.TabIndex = 45;
            this.lbmodalidade.Text = "Modalidade";
            // 
            // tbnome
            // 
            this.tbnome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbnome.Enabled = false;
            this.tbnome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbnome.Location = new System.Drawing.Point(51, 104);
            this.tbnome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbnome.MaxLength = 100;
            this.tbnome.Name = "tbnome";
            this.tbnome.Size = new System.Drawing.Size(300, 29);
            this.tbnome.TabIndex = 0;
            // 
            // lbnome
            // 
            this.lbnome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbnome.AutoSize = true;
            this.lbnome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbnome.Location = new System.Drawing.Point(51, 78);
            this.lbnome.Name = "lbnome";
            this.lbnome.Size = new System.Drawing.Size(53, 21);
            this.lbnome.TabIndex = 44;
            this.lbnome.Text = "Nome";
            // 
            // tbbusca
            // 
            this.tbbusca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbbusca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbbusca.Location = new System.Drawing.Point(542, 122);
            this.tbbusca.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbbusca.MaxLength = 100;
            this.tbbusca.Name = "tbbusca";
            this.tbbusca.Size = new System.Drawing.Size(597, 29);
            this.tbbusca.TabIndex = 8;
            this.tbbusca.TextChanged += new System.EventHandler(this.lbbusca_Click);
            this.tbbusca.Enter += new System.EventHandler(this.tbbusca_Enter);
            this.tbbusca.Leave += new System.EventHandler(this.tbbusca_Leave);
            // 
            // lbbusca
            // 
            this.lbbusca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbbusca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbbusca.Font = new System.Drawing.Font("Segoe UI Semibold", 11.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbbusca.ForeColor = System.Drawing.SystemColors.Control;
            this.lbbusca.Image = ((System.Drawing.Image)(resources.GetObject("lbbusca.Image")));
            this.lbbusca.Location = new System.Drawing.Point(1146, 122);
            this.lbbusca.Name = "lbbusca";
            this.lbbusca.Size = new System.Drawing.Size(32, 29);
            this.lbbusca.TabIndex = 9;
            this.lbbusca.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbbusca.Click += new System.EventHandler(this.lbbusca_Click);
            // 
            // tbid
            // 
            this.tbid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbid.Enabled = false;
            this.tbid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbid.Location = new System.Drawing.Point(183, 43);
            this.tbid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbid.Name = "tbid";
            this.tbid.Size = new System.Drawing.Size(45, 29);
            this.tbid.TabIndex = 54;
            this.tbid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbid
            // 
            this.lbid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbid.AutoSize = true;
            this.lbid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbid.Location = new System.Drawing.Point(194, 18);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(25, 21);
            this.lbid.TabIndex = 55;
            this.lbid.Text = "ID";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl1.Location = new System.Drawing.Point(81, 122);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(15, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(414, 357);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage1.Controls.Add(this.tbid);
            this.tabPage1.Controls.Add(this.tbnome);
            this.tabPage1.Controls.Add(this.lbid);
            this.tabPage1.Controls.Add(this.lbnome);
            this.tabPage1.Controls.Add(this.lbmodalidade);
            this.tabPage1.Controls.Add(this.cbmodalidade);
            this.tabPage1.Controls.Add(this.tbtipo);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lbtipo);
            this.tabPage1.Controls.Add(this.mtbhoras);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(406, 323);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Informações";
            // 
            // FormEditAcg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 678);
            this.Controls.Add(this.lbbusca);
            this.Controls.Add(this.tbbusca);
            this.Controls.Add(this.lbsair);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgacg);
            this.Controls.Add(this.bteditar);
            this.Controls.Add(this.btcancelar);
            this.Controls.Add(this.lbeditar);
            this.Controls.Add(this.btexcluir);
            this.Controls.Add(this.btsalvar);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1269, 725);
            this.Name = "FormEditAcg";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajustes";
            this.Load += new System.EventHandler(this.FormEditAcg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgacg)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbsair;
        private Label label2;
        private DataGridView dgacg;
        internal Button bteditar;
        internal Button btcancelar;
        private Label lbeditar;
        internal Button btexcluir;
        internal Button btsalvar;
        private TextBox tbtipo;
        private Label lbtipo;
        private MaskedTextBox mtbhoras;
        private Label label1;
        private ComboBox cbmodalidade;
        private Label lbmodalidade;
        private TextBox tbnome;
        private Label lbnome;
        private TextBox tbbusca;
        private Label lbbusca;
        private TextBox tbid;
        private Label lbid;
        private TabControl tabControl1;
        private TabPage tabPage1;
    }
}