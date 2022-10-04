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
            this.btcancelar = new System.Windows.Forms.Button();
            this.lbmodalidade = new System.Windows.Forms.Label();
            this.tbnome = new System.Windows.Forms.TextBox();
            this.lbnome = new System.Windows.Forms.Label();
            this.lbcadastro = new System.Windows.Forms.Label();
            this.btlimpar = new System.Windows.Forms.Button();
            this.btsalvar = new System.Windows.Forms.Button();
            this.cbmodalidade = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mtbhoras = new System.Windows.Forms.MaskedTextBox();
            this.lbtipo = new System.Windows.Forms.Label();
            this.tbtipo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btcancelar
            // 
            this.btcancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btcancelar.BackColor = System.Drawing.Color.GhostWhite;
            this.btcancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btcancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btcancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btcancelar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btcancelar.Location = new System.Drawing.Point(240, 390);
            this.btcancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(147, 37);
            this.btcancelar.TabIndex = 21;
            this.btcancelar.Text = "CANCELAR";
            this.btcancelar.UseVisualStyleBackColor = false;
            this.btcancelar.Click += new System.EventHandler(this.btcancelar_Click);
            // 
            // lbmodalidade
            // 
            this.lbmodalidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbmodalidade.AutoSize = true;
            this.lbmodalidade.ForeColor = System.Drawing.Color.DimGray;
            this.lbmodalidade.Location = new System.Drawing.Point(87, 244);
            this.lbmodalidade.Name = "lbmodalidade";
            this.lbmodalidade.Size = new System.Drawing.Size(92, 21);
            this.lbmodalidade.TabIndex = 6;
            this.lbmodalidade.Text = "Modalidade";
            // 
            // tbnome
            // 
            this.tbnome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbnome.ForeColor = System.Drawing.Color.DimGray;
            this.tbnome.Location = new System.Drawing.Point(87, 155);
            this.tbnome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbnome.Name = "tbnome";
            this.tbnome.Size = new System.Drawing.Size(300, 29);
            this.tbnome.TabIndex = 0;
            // 
            // lbnome
            // 
            this.lbnome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbnome.AutoSize = true;
            this.lbnome.ForeColor = System.Drawing.Color.DimGray;
            this.lbnome.Location = new System.Drawing.Point(87, 130);
            this.lbnome.Name = "lbnome";
            this.lbnome.Size = new System.Drawing.Size(53, 21);
            this.lbnome.TabIndex = 0;
            this.lbnome.Text = "Nome";
            // 
            // lbcadastro
            // 
            this.lbcadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbcadastro.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbcadastro.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbcadastro.Location = new System.Drawing.Point(87, 64);
            this.lbcadastro.Name = "lbcadastro";
            this.lbcadastro.Size = new System.Drawing.Size(300, 38);
            this.lbcadastro.TabIndex = 24;
            this.lbcadastro.Text = "NOVA ACG";
            this.lbcadastro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btlimpar
            // 
            this.btlimpar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btlimpar.BackColor = System.Drawing.Color.GhostWhite;
            this.btlimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btlimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btlimpar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btlimpar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btlimpar.Location = new System.Drawing.Point(87, 390);
            this.btlimpar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btlimpar.Name = "btlimpar";
            this.btlimpar.Size = new System.Drawing.Size(147, 37);
            this.btlimpar.TabIndex = 22;
            this.btlimpar.Text = "LIMPAR";
            this.btlimpar.UseVisualStyleBackColor = false;
            this.btlimpar.Click += new System.EventHandler(this.btlimpar_Click);
            // 
            // btsalvar
            // 
            this.btsalvar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btsalvar.BackColor = System.Drawing.Color.SteelBlue;
            this.btsalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btsalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsalvar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btsalvar.ForeColor = System.Drawing.Color.White;
            this.btsalvar.Location = new System.Drawing.Point(87, 435);
            this.btsalvar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btsalvar.Name = "btsalvar";
            this.btsalvar.Size = new System.Drawing.Size(300, 37);
            this.btsalvar.TabIndex = 23;
            this.btsalvar.Text = "SALVAR";
            this.btsalvar.UseVisualStyleBackColor = false;
            this.btsalvar.Click += new System.EventHandler(this.btsalvar_Click);
            // 
            // cbmodalidade
            // 
            this.cbmodalidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbmodalidade.ForeColor = System.Drawing.Color.DimGray;
            this.cbmodalidade.FormattingEnabled = true;
            this.cbmodalidade.Items.AddRange(new object[] {
            "Selecione",
            "Formação Profissional",
            "Extensão Universitária",
            "Pesquisa",
            "Ensino",
            "Políticas",
            "Empreendedorismo e Inovação"});
            this.cbmodalidade.Location = new System.Drawing.Point(87, 268);
            this.cbmodalidade.Name = "cbmodalidade";
            this.cbmodalidade.Size = new System.Drawing.Size(300, 29);
            this.cbmodalidade.TabIndex = 25;
            this.cbmodalidade.Leave += new System.EventHandler(this.cbmodalidade_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(87, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 21);
            this.label1.TabIndex = 27;
            this.label1.Text = "Horas";
            // 
            // mtbhoras
            // 
            this.mtbhoras.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbhoras.ForeColor = System.Drawing.Color.DimGray;
            this.mtbhoras.HidePromptOnLeave = true;
            this.mtbhoras.Location = new System.Drawing.Point(87, 212);
            this.mtbhoras.Mask = "00";
            this.mtbhoras.Name = "mtbhoras";
            this.mtbhoras.Size = new System.Drawing.Size(51, 29);
            this.mtbhoras.TabIndex = 28;
            this.mtbhoras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbhoras.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lbtipo
            // 
            this.lbtipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbtipo.AutoSize = true;
            this.lbtipo.ForeColor = System.Drawing.Color.DimGray;
            this.lbtipo.Location = new System.Drawing.Point(87, 300);
            this.lbtipo.Name = "lbtipo";
            this.lbtipo.Size = new System.Drawing.Size(40, 21);
            this.lbtipo.TabIndex = 29;
            this.lbtipo.Text = "Tipo";
            // 
            // tbtipo
            // 
            this.tbtipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbtipo.ForeColor = System.Drawing.Color.DimGray;
            this.tbtipo.Location = new System.Drawing.Point(87, 325);
            this.tbtipo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbtipo.Name = "tbtipo";
            this.tbtipo.Size = new System.Drawing.Size(300, 29);
            this.tbtipo.TabIndex = 30;
            this.tbtipo.Enter += new System.EventHandler(this.tbtipo_Enter);
            this.tbtipo.Leave += new System.EventHandler(this.tbtipo_Leave);
            // 
            // FormCadAcg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 539);
            this.Controls.Add(this.tbtipo);
            this.Controls.Add(this.lbtipo);
            this.Controls.Add(this.mtbhoras);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbmodalidade);
            this.Controls.Add(this.btcancelar);
            this.Controls.Add(this.lbmodalidade);
            this.Controls.Add(this.tbnome);
            this.Controls.Add(this.lbnome);
            this.Controls.Add(this.lbcadastro);
            this.Controls.Add(this.btlimpar);
            this.Controls.Add(this.btsalvar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(490, 586);
            this.Name = "FormCadAcg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar ACG";
            this.Load += new System.EventHandler(this.FormCadAcg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btcancelar;
        private Label lbmodalidade;
        private TextBox tbnome;
        private Label lbnome;
        private Label lbcadastro;
        private Button btlimpar;
        private Button btsalvar;
        private ComboBox cbmodalidade;
        private Label label1;
        private MaskedTextBox mtbhoras;
        private Label lbtipo;
        private TextBox tbtipo;
    }
}