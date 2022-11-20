namespace projeto_acg.View
{
    partial class FormCadAcg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadAcg));
            this.tbtipo = new System.Windows.Forms.TextBox();
            this.lbtipo = new System.Windows.Forms.Label();
            this.mtbhoras = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btcancelar = new System.Windows.Forms.Button();
            this.lbmodalidade = new System.Windows.Forms.Label();
            this.lbnome = new System.Windows.Forms.Label();
            this.lbcadastro = new System.Windows.Forms.Label();
            this.btlimpar = new System.Windows.Forms.Button();
            this.btcadastrar = new System.Windows.Forms.Button();
            this.cbmodalidade = new System.Windows.Forms.ComboBox();
            this.tbnome = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbtipo
            // 
            this.tbtipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbtipo.BackColor = System.Drawing.Color.White;
            this.tbtipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbtipo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbtipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbtipo.Location = new System.Drawing.Point(283, 348);
            this.tbtipo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbtipo.MaxLength = 50;
            this.tbtipo.Name = "tbtipo";
            this.tbtipo.Size = new System.Drawing.Size(300, 34);
            this.tbtipo.TabIndex = 2;
            this.tbtipo.Enter += new System.EventHandler(this.tbtipo_Enter);
            this.tbtipo.Leave += new System.EventHandler(this.tbtipo_Leave);
            // 
            // lbtipo
            // 
            this.lbtipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbtipo.AutoSize = true;
            this.lbtipo.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbtipo.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbtipo.Location = new System.Drawing.Point(283, 313);
            this.lbtipo.Name = "lbtipo";
            this.lbtipo.Size = new System.Drawing.Size(61, 31);
            this.lbtipo.TabIndex = 53;
            this.lbtipo.Text = "Tipo";
            // 
            // mtbhoras
            // 
            this.mtbhoras.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbhoras.BackColor = System.Drawing.Color.White;
            this.mtbhoras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbhoras.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtbhoras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mtbhoras.HidePromptOnLeave = true;
            this.mtbhoras.Location = new System.Drawing.Point(162, 348);
            this.mtbhoras.Mask = "00";
            this.mtbhoras.Name = "mtbhoras";
            this.mtbhoras.Size = new System.Drawing.Size(76, 34);
            this.mtbhoras.TabIndex = 1;
            this.mtbhoras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbhoras.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(162, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 31);
            this.label1.TabIndex = 52;
            this.label1.Text = "Horas";
            // 
            // btcancelar
            // 
            this.btcancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btcancelar.BackColor = System.Drawing.Color.GhostWhite;
            this.btcancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btcancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btcancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btcancelar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btcancelar.Location = new System.Drawing.Point(376, 523);
            this.btcancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(207, 44);
            this.btcancelar.TabIndex = 47;
            this.btcancelar.Text = "CANCELAR";
            this.btcancelar.UseVisualStyleBackColor = false;
            this.btcancelar.Click += new System.EventHandler(this.btcancelar_Click);
            // 
            // lbmodalidade
            // 
            this.lbmodalidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbmodalidade.AutoSize = true;
            this.lbmodalidade.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbmodalidade.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbmodalidade.Location = new System.Drawing.Point(162, 405);
            this.lbmodalidade.Name = "lbmodalidade";
            this.lbmodalidade.Size = new System.Drawing.Size(139, 31);
            this.lbmodalidade.TabIndex = 50;
            this.lbmodalidade.Text = "Modalidade";
            // 
            // lbnome
            // 
            this.lbnome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbnome.AutoSize = true;
            this.lbnome.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbnome.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbnome.Location = new System.Drawing.Point(162, 221);
            this.lbnome.Name = "lbnome";
            this.lbnome.Size = new System.Drawing.Size(78, 31);
            this.lbnome.TabIndex = 49;
            this.lbnome.Text = "Nome";
            // 
            // lbcadastro
            // 
            this.lbcadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbcadastro.AutoSize = true;
            this.lbcadastro.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbcadastro.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbcadastro.Location = new System.Drawing.Point(240, 140);
            this.lbcadastro.Name = "lbcadastro";
            this.lbcadastro.Size = new System.Drawing.Size(265, 41);
            this.lbcadastro.TabIndex = 51;
            this.lbcadastro.Text = "CADASTRAR ACG";
            this.lbcadastro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btlimpar
            // 
            this.btlimpar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btlimpar.BackColor = System.Drawing.Color.GhostWhite;
            this.btlimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btlimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btlimpar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btlimpar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btlimpar.Location = new System.Drawing.Point(162, 523);
            this.btlimpar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btlimpar.Name = "btlimpar";
            this.btlimpar.Size = new System.Drawing.Size(207, 44);
            this.btlimpar.TabIndex = 46;
            this.btlimpar.Text = "LIMPAR";
            this.btlimpar.UseVisualStyleBackColor = false;
            this.btlimpar.Click += new System.EventHandler(this.btlimpar_Click);
            // 
            // btcadastrar
            // 
            this.btcadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btcadastrar.BackColor = System.Drawing.Color.SteelBlue;
            this.btcadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btcadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btcadastrar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btcadastrar.ForeColor = System.Drawing.Color.White;
            this.btcadastrar.Location = new System.Drawing.Point(162, 575);
            this.btcadastrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btcadastrar.Name = "btcadastrar";
            this.btcadastrar.Size = new System.Drawing.Size(421, 44);
            this.btcadastrar.TabIndex = 48;
            this.btcadastrar.Text = "CADASTRAR";
            this.btcadastrar.UseVisualStyleBackColor = false;
            this.btcadastrar.Click += new System.EventHandler(this.btsalvar_Click);
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
            this.cbmodalidade.Location = new System.Drawing.Point(162, 439);
            this.cbmodalidade.Name = "cbmodalidade";
            this.cbmodalidade.Size = new System.Drawing.Size(421, 36);
            this.cbmodalidade.TabIndex = 3;
            this.cbmodalidade.Enter += new System.EventHandler(this.tbtipo_Enter);
            this.cbmodalidade.Leave += new System.EventHandler(this.tbtipo_Leave);
            // 
            // tbnome
            // 
            this.tbnome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbnome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbnome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbnome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbnome.Location = new System.Drawing.Point(162, 256);
            this.tbnome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbnome.MaxLength = 50;
            this.tbnome.Name = "tbnome";
            this.tbnome.Size = new System.Drawing.Size(421, 34);
            this.tbnome.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(629, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(591, 479);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // FormCadAcg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 748);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbnome);
            this.Controls.Add(this.cbmodalidade);
            this.Controls.Add(this.tbtipo);
            this.Controls.Add(this.lbtipo);
            this.Controls.Add(this.mtbhoras);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btcancelar);
            this.Controls.Add(this.lbmodalidade);
            this.Controls.Add(this.lbnome);
            this.Controls.Add(this.lbcadastro);
            this.Controls.Add(this.btlimpar);
            this.Controls.Add(this.btcadastrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1410, 795);
            this.Name = "FormCadAcg";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar ACG";
            this.Load += new System.EventHandler(this.FormCadAcg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbtipo;
        private Label lbtipo;
        private MaskedTextBox mtbhoras;
        private Label label1;
        private Button btcancelar;
        private Label lbmodalidade;
        private Label lbnome;
        private Label lbcadastro;
        private Button btlimpar;
        private Button btcadastrar;
        private ComboBox cbmodalidade;
        private TextBox tbnome;
        private PictureBox pictureBox1;
    }
}