namespace projeto_acg
{
    partial class FormEnviarAcg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEnviarAcg));
            this.tbtipo = new System.Windows.Forms.TextBox();
            this.lbtipo = new System.Windows.Forms.Label();
            this.mtbhoras = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbnome = new System.Windows.Forms.ComboBox();
            this.lbmodalidade = new System.Windows.Forms.Label();
            this.tbmodalidade = new System.Windows.Forms.TextBox();
            this.lbnome = new System.Windows.Forms.Label();
            this.lbcadastro = new System.Windows.Forms.Label();
            this.btenviar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbsair = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbtipo
            // 
            this.tbtipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbtipo.BackColor = System.Drawing.Color.White;
            this.tbtipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbtipo.Enabled = false;
            this.tbtipo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbtipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbtipo.Location = new System.Drawing.Point(288, 354);
            this.tbtipo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbtipo.MaxLength = 50;
            this.tbtipo.Name = "tbtipo";
            this.tbtipo.Size = new System.Drawing.Size(300, 34);
            this.tbtipo.TabIndex = 2;
            // 
            // lbtipo
            // 
            this.lbtipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbtipo.AutoSize = true;
            this.lbtipo.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbtipo.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbtipo.Location = new System.Drawing.Point(288, 319);
            this.lbtipo.Name = "lbtipo";
            this.lbtipo.Size = new System.Drawing.Size(61, 31);
            this.lbtipo.TabIndex = 41;
            this.lbtipo.Text = "Tipo";
            // 
            // mtbhoras
            // 
            this.mtbhoras.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbhoras.BackColor = System.Drawing.Color.White;
            this.mtbhoras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbhoras.Enabled = false;
            this.mtbhoras.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtbhoras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mtbhoras.HidePromptOnLeave = true;
            this.mtbhoras.Location = new System.Drawing.Point(167, 354);
            this.mtbhoras.Mask = "00";
            this.mtbhoras.Name = "mtbhoras";
            this.mtbhoras.Size = new System.Drawing.Size(76, 34);
            this.mtbhoras.TabIndex = 1;
            this.mtbhoras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbhoras.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbhoras.Enter += new System.EventHandler(this.mtbhoras_Enter);
            this.mtbhoras.Leave += new System.EventHandler(this.mtbhoras_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(167, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 31);
            this.label1.TabIndex = 39;
            this.label1.Text = "Horas";
            // 
            // cbnome
            // 
            this.cbnome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbnome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbnome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbnome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbnome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbnome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbnome.FormattingEnabled = true;
            this.cbnome.Items.AddRange(new object[] {
            "Selecione"});
            this.cbnome.Location = new System.Drawing.Point(167, 261);
            this.cbnome.Name = "cbnome";
            this.cbnome.Size = new System.Drawing.Size(421, 36);
            this.cbnome.TabIndex = 0;
            this.cbnome.SelectedIndexChanged += new System.EventHandler(this.cbnome_SelectedIndexChanged);
            // 
            // lbmodalidade
            // 
            this.lbmodalidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbmodalidade.AutoSize = true;
            this.lbmodalidade.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbmodalidade.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbmodalidade.Location = new System.Drawing.Point(167, 411);
            this.lbmodalidade.Name = "lbmodalidade";
            this.lbmodalidade.Size = new System.Drawing.Size(139, 31);
            this.lbmodalidade.TabIndex = 33;
            this.lbmodalidade.Text = "Modalidade";
            // 
            // tbmodalidade
            // 
            this.tbmodalidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbmodalidade.BackColor = System.Drawing.Color.White;
            this.tbmodalidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbmodalidade.Enabled = false;
            this.tbmodalidade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbmodalidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbmodalidade.Location = new System.Drawing.Point(167, 446);
            this.tbmodalidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbmodalidade.MaxLength = 50;
            this.tbmodalidade.Name = "tbmodalidade";
            this.tbmodalidade.Size = new System.Drawing.Size(421, 34);
            this.tbmodalidade.TabIndex = 3;
            // 
            // lbnome
            // 
            this.lbnome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbnome.AutoSize = true;
            this.lbnome.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbnome.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbnome.Location = new System.Drawing.Point(167, 227);
            this.lbnome.Name = "lbnome";
            this.lbnome.Size = new System.Drawing.Size(78, 31);
            this.lbnome.TabIndex = 32;
            this.lbnome.Text = "Nome";
            // 
            // lbcadastro
            // 
            this.lbcadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbcadastro.AutoSize = true;
            this.lbcadastro.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbcadastro.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbcadastro.Location = new System.Drawing.Point(279, 146);
            this.lbcadastro.Name = "lbcadastro";
            this.lbcadastro.Size = new System.Drawing.Size(197, 41);
            this.lbcadastro.TabIndex = 37;
            this.lbcadastro.Text = "ENVIAR ACG";
            this.lbcadastro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btenviar
            // 
            this.btenviar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btenviar.BackColor = System.Drawing.Color.SteelBlue;
            this.btenviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btenviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btenviar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btenviar.ForeColor = System.Drawing.Color.White;
            this.btenviar.Location = new System.Drawing.Point(167, 529);
            this.btenviar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btenviar.Name = "btenviar";
            this.btenviar.Size = new System.Drawing.Size(421, 44);
            this.btenviar.TabIndex = 6;
            this.btenviar.Text = "ENVIAR";
            this.btenviar.UseVisualStyleBackColor = false;
            this.btenviar.Click += new System.EventHandler(this.btenviar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(634, 146);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(591, 427);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // lbsair
            // 
            this.lbsair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbsair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbsair.Font = new System.Drawing.Font("Segoe UI Semibold", 11.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbsair.ForeColor = System.Drawing.SystemColors.Control;
            this.lbsair.Image = ((System.Drawing.Image)(resources.GetObject("lbsair.Image")));
            this.lbsair.Location = new System.Drawing.Point(1324, 685);
            this.lbsair.Name = "lbsair";
            this.lbsair.Size = new System.Drawing.Size(56, 54);
            this.lbsair.TabIndex = 43;
            this.lbsair.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbsair.Click += new System.EventHandler(this.lbsair_Click);
            // 
            // FormEnviarAcg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 748);
            this.Controls.Add(this.lbsair);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbtipo);
            this.Controls.Add(this.lbtipo);
            this.Controls.Add(this.mtbhoras);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbnome);
            this.Controls.Add(this.lbmodalidade);
            this.Controls.Add(this.tbmodalidade);
            this.Controls.Add(this.lbnome);
            this.Controls.Add(this.lbcadastro);
            this.Controls.Add(this.btenviar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1410, 795);
            this.Name = "FormEnviarAcg";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enviar ACG";
            this.Load += new System.EventHandler(this.FormEnviarAcg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbtipo;
        private Label lbtipo;
        private MaskedTextBox mtbhoras;
        private Label label1;
        private ComboBox cbnome;
        private Label lbmodalidade;
        private TextBox tbmodalidade;
        private Label lbnome;
        private Label lbcadastro;
        private Button btenviar;
        private PictureBox pictureBox1;
        private Label lbsair;
    }
}