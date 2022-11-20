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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btrelatorio = new System.Windows.Forms.Button();
            this.lbbuscar = new System.Windows.Forms.Label();
            this.tbbusca = new System.Windows.Forms.TextBox();
            this.lbsair = new System.Windows.Forms.Label();
            this.lbtodos = new System.Windows.Forms.Label();
            this.dgacg = new System.Windows.Forms.DataGridView();
            this.bteditar = new System.Windows.Forms.Button();
            this.btcancelar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.mtbhoras = new System.Windows.Forms.MaskedTextBox();
            this.lbhoras = new System.Windows.Forms.Label();
            this.tbid = new System.Windows.Forms.TextBox();
            this.lbid = new System.Windows.Forms.Label();
            this.tbnome = new System.Windows.Forms.TextBox();
            this.lbnome = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbmodalidade = new System.Windows.Forms.ComboBox();
            this.tbtipo = new System.Windows.Forms.TextBox();
            this.lbtipo = new System.Windows.Forms.Label();
            this.lbmodalidade = new System.Windows.Forms.Label();
            this.lbEditar = new System.Windows.Forms.Label();
            this.btexcluir = new System.Windows.Forms.Button();
            this.btsalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgacg)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btrelatorio
            // 
            this.btrelatorio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btrelatorio.BackColor = System.Drawing.Color.GhostWhite;
            this.btrelatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btrelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btrelatorio.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btrelatorio.ForeColor = System.Drawing.Color.SteelBlue;
            this.btrelatorio.Location = new System.Drawing.Point(71, 555);
            this.btrelatorio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btrelatorio.Name = "btrelatorio";
            this.btrelatorio.Size = new System.Drawing.Size(457, 44);
            this.btrelatorio.TabIndex = 8;
            this.btrelatorio.Text = "GERAR RELATÓRIO";
            this.btrelatorio.UseVisualStyleBackColor = false;
            this.btrelatorio.Click += new System.EventHandler(this.btrelatorio_Click);
            // 
            // lbbuscar
            // 
            this.lbbuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbbuscar.AutoSize = true;
            this.lbbuscar.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbbuscar.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbbuscar.Location = new System.Drawing.Point(564, 158);
            this.lbbuscar.Name = "lbbuscar";
            this.lbbuscar.Size = new System.Drawing.Size(74, 31);
            this.lbbuscar.TabIndex = 71;
            this.lbbuscar.Text = "Busca";
            // 
            // tbbusca
            // 
            this.tbbusca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbbusca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbbusca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbbusca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbbusca.Location = new System.Drawing.Point(645, 157);
            this.tbbusca.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbbusca.MaxLength = 100;
            this.tbbusca.Name = "tbbusca";
            this.tbbusca.Size = new System.Drawing.Size(561, 34);
            this.tbbusca.TabIndex = 10;
            this.tbbusca.TextChanged += new System.EventHandler(this.lbbusca_Click);
            // 
            // lbsair
            // 
            this.lbsair.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbsair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbsair.Font = new System.Drawing.Font("Segoe UI Semibold", 11.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbsair.ForeColor = System.Drawing.SystemColors.Control;
            this.lbsair.Image = ((System.Drawing.Image)(resources.GetObject("lbsair.Image")));
            this.lbsair.Location = new System.Drawing.Point(1242, 692);
            this.lbsair.Name = "lbsair";
            this.lbsair.Size = new System.Drawing.Size(32, 37);
            this.lbsair.TabIndex = 67;
            this.lbsair.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbsair.Click += new System.EventHandler(this.lbsair_Click);
            // 
            // lbtodos
            // 
            this.lbtodos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbtodos.AutoSize = true;
            this.lbtodos.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbtodos.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbtodos.Location = new System.Drawing.Point(711, 70);
            this.lbtodos.Name = "lbtodos";
            this.lbtodos.Size = new System.Drawing.Size(354, 41);
            this.lbtodos.TabIndex = 69;
            this.lbtodos.Text = "TODOS OS CADASTROS";
            this.lbtodos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgacg
            // 
            this.dgacg.AllowUserToAddRows = false;
            this.dgacg.AllowUserToDeleteRows = false;
            this.dgacg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgacg.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgacg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgacg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgacg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgacg.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgacg.Location = new System.Drawing.Point(570, 210);
            this.dgacg.MultiSelect = false;
            this.dgacg.Name = "dgacg";
            this.dgacg.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgacg.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgacg.RowHeadersVisible = false;
            this.dgacg.RowHeadersWidth = 51;
            this.dgacg.RowTemplate.Height = 29;
            this.dgacg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgacg.Size = new System.Drawing.Size(636, 441);
            this.dgacg.TabIndex = 11;
            // 
            // bteditar
            // 
            this.bteditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bteditar.BackColor = System.Drawing.Color.GhostWhite;
            this.bteditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bteditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bteditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bteditar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bteditar.ForeColor = System.Drawing.Color.SteelBlue;
            this.bteditar.Image = ((System.Drawing.Image)(resources.GetObject("bteditar.Image")));
            this.bteditar.Location = new System.Drawing.Point(167, 503);
            this.bteditar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bteditar.Name = "bteditar";
            this.bteditar.Size = new System.Drawing.Size(90, 44);
            this.bteditar.TabIndex = 6;
            this.bteditar.UseVisualStyleBackColor = false;
            this.bteditar.Click += new System.EventHandler(this.bteditar_Click);
            // 
            // btcancelar
            // 
            this.btcancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btcancelar.BackColor = System.Drawing.Color.GhostWhite;
            this.btcancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btcancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btcancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btcancelar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btcancelar.Location = new System.Drawing.Point(263, 503);
            this.btcancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(265, 44);
            this.btcancelar.TabIndex = 7;
            this.btcancelar.Text = "CANCELAR";
            this.btcancelar.UseVisualStyleBackColor = false;
            this.btcancelar.Click += new System.EventHandler(this.btcancelar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(71, 155);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(15, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(457, 330);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage1.Controls.Add(this.mtbhoras);
            this.tabPage1.Controls.Add(this.lbhoras);
            this.tabPage1.Controls.Add(this.tbid);
            this.tabPage1.Controls.Add(this.lbid);
            this.tabPage1.Controls.Add(this.tbnome);
            this.tabPage1.Controls.Add(this.lbnome);
            this.tabPage1.Location = new System.Drawing.Point(4, 37);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(449, 289);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Principal";
            // 
            // mtbhoras
            // 
            this.mtbhoras.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbhoras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbhoras.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtbhoras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mtbhoras.HidePromptOnLeave = true;
            this.mtbhoras.Location = new System.Drawing.Point(56, 227);
            this.mtbhoras.Mask = "00";
            this.mtbhoras.Name = "mtbhoras";
            this.mtbhoras.Size = new System.Drawing.Size(76, 34);
            this.mtbhoras.TabIndex = 2;
            this.mtbhoras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbhoras.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lbhoras
            // 
            this.lbhoras.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbhoras.AutoSize = true;
            this.lbhoras.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbhoras.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbhoras.Location = new System.Drawing.Point(56, 193);
            this.lbhoras.Name = "lbhoras";
            this.lbhoras.Size = new System.Drawing.Size(76, 31);
            this.lbhoras.TabIndex = 5;
            this.lbhoras.Text = "Horas";
            // 
            // tbid
            // 
            this.tbid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbid.Enabled = false;
            this.tbid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbid.Location = new System.Drawing.Point(206, 62);
            this.tbid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbid.Name = "tbid";
            this.tbid.Size = new System.Drawing.Size(45, 34);
            this.tbid.TabIndex = 2;
            this.tbid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbid
            // 
            this.lbid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbid.AutoSize = true;
            this.lbid.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbid.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbid.Location = new System.Drawing.Point(209, 27);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(38, 31);
            this.lbid.TabIndex = 3;
            this.lbid.Text = "ID";
            // 
            // tbnome
            // 
            this.tbnome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbnome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbnome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbnome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbnome.Location = new System.Drawing.Point(56, 145);
            this.tbnome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbnome.MaxLength = 50;
            this.tbnome.Name = "tbnome";
            this.tbnome.Size = new System.Drawing.Size(345, 34);
            this.tbnome.TabIndex = 1;
            // 
            // lbnome
            // 
            this.lbnome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbnome.AutoSize = true;
            this.lbnome.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbnome.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbnome.Location = new System.Drawing.Point(56, 110);
            this.lbnome.Name = "lbnome";
            this.lbnome.Size = new System.Drawing.Size(78, 31);
            this.lbnome.TabIndex = 0;
            this.lbnome.Text = "Nome";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage2.Controls.Add(this.cbmodalidade);
            this.tabPage2.Controls.Add(this.tbtipo);
            this.tabPage2.Controls.Add(this.lbtipo);
            this.tabPage2.Controls.Add(this.lbmodalidade);
            this.tabPage2.Location = new System.Drawing.Point(4, 37);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(449, 289);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Técnico";
            // 
            // cbmodalidade
            // 
            this.cbmodalidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbmodalidade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbmodalidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmodalidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbmodalidade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.cbmodalidade.Location = new System.Drawing.Point(92, 104);
            this.cbmodalidade.Name = "cbmodalidade";
            this.cbmodalidade.Size = new System.Drawing.Size(270, 36);
            this.cbmodalidade.TabIndex = 3;
            // 
            // tbtipo
            // 
            this.tbtipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbtipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbtipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbtipo.Location = new System.Drawing.Point(92, 188);
            this.tbtipo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbtipo.MaxLength = 30;
            this.tbtipo.Name = "tbtipo";
            this.tbtipo.Size = new System.Drawing.Size(270, 34);
            this.tbtipo.TabIndex = 4;
            // 
            // lbtipo
            // 
            this.lbtipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbtipo.AutoSize = true;
            this.lbtipo.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbtipo.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbtipo.Location = new System.Drawing.Point(92, 153);
            this.lbtipo.Name = "lbtipo";
            this.lbtipo.Size = new System.Drawing.Size(61, 31);
            this.lbtipo.TabIndex = 8;
            this.lbtipo.Text = "Tipo";
            // 
            // lbmodalidade
            // 
            this.lbmodalidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbmodalidade.AutoSize = true;
            this.lbmodalidade.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbmodalidade.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbmodalidade.Location = new System.Drawing.Point(92, 70);
            this.lbmodalidade.Name = "lbmodalidade";
            this.lbmodalidade.Size = new System.Drawing.Size(139, 31);
            this.lbmodalidade.TabIndex = 6;
            this.lbmodalidade.Text = "Modalidade";
            // 
            // lbEditar
            // 
            this.lbEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbEditar.AutoSize = true;
            this.lbEditar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbEditar.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbEditar.Location = new System.Drawing.Point(167, 70);
            this.lbEditar.Name = "lbEditar";
            this.lbEditar.Size = new System.Drawing.Size(292, 41);
            this.lbEditar.TabIndex = 68;
            this.lbEditar.Text = "EDITAR CADASTRO";
            this.lbEditar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btexcluir
            // 
            this.btexcluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btexcluir.BackColor = System.Drawing.Color.GhostWhite;
            this.btexcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btexcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btexcluir.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btexcluir.ForeColor = System.Drawing.Color.SteelBlue;
            this.btexcluir.Image = ((System.Drawing.Image)(resources.GetObject("btexcluir.Image")));
            this.btexcluir.Location = new System.Drawing.Point(71, 503);
            this.btexcluir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btexcluir.Name = "btexcluir";
            this.btexcluir.Size = new System.Drawing.Size(90, 44);
            this.btexcluir.TabIndex = 5;
            this.btexcluir.UseVisualStyleBackColor = false;
            this.btexcluir.Click += new System.EventHandler(this.btexcluir_Click);
            // 
            // btsalvar
            // 
            this.btsalvar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btsalvar.BackColor = System.Drawing.Color.SteelBlue;
            this.btsalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btsalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsalvar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btsalvar.ForeColor = System.Drawing.Color.White;
            this.btsalvar.Location = new System.Drawing.Point(71, 607);
            this.btsalvar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btsalvar.Name = "btsalvar";
            this.btsalvar.Size = new System.Drawing.Size(457, 44);
            this.btsalvar.TabIndex = 9;
            this.btsalvar.Text = "SALVAR";
            this.btsalvar.UseVisualStyleBackColor = false;
            this.btsalvar.Click += new System.EventHandler(this.btsalvar_Click);
            // 
            // FormEditAcg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 738);
            this.Controls.Add(this.btrelatorio);
            this.Controls.Add(this.lbbuscar);
            this.Controls.Add(this.tbbusca);
            this.Controls.Add(this.lbsair);
            this.Controls.Add(this.lbtodos);
            this.Controls.Add(this.dgacg);
            this.Controls.Add(this.bteditar);
            this.Controls.Add(this.btcancelar);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lbEditar);
            this.Controls.Add(this.btexcluir);
            this.Controls.Add(this.btsalvar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1304, 785);
            this.Name = "FormEditAcg";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajustes";
            this.Load += new System.EventHandler(this.FormEditAcg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgacg)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal Button btrelatorio;
        private Label lbbuscar;
        private TextBox tbbusca;
        private Label lbsair;
        private Label lbtodos;
        private DataGridView dgacg;
        internal Button bteditar;
        internal Button btcancelar;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private MaskedTextBox mtbhoras;
        private Label lbhoras;
        private TextBox tbid;
        private Label lbid;
        private TextBox tbnome;
        private Label lbnome;
        private TabPage tabPage2;
        private TextBox tbtipo;
        private Label lbtipo;
        private Label lbmodalidade;
        private Label lbEditar;
        internal Button btexcluir;
        internal Button btsalvar;
        private ComboBox cbmodalidade;
    }
}