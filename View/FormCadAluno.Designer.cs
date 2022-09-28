namespace projeto_acg.View
{
    partial class FormCadAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadAluno));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.mtbcpf = new System.Windows.Forms.MaskedTextBox();
            this.tbnome = new System.Windows.Forms.TextBox();
            this.lbcpf = new System.Windows.Forms.Label();
            this.lbnome = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btversenha = new System.Windows.Forms.Button();
            this.tbsenha = new System.Windows.Forms.TextBox();
            this.lbsenha = new System.Windows.Forms.Label();
            this.mtbmatricula = new System.Windows.Forms.MaskedTextBox();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbcadastro = new System.Windows.Forms.Label();
            this.btlimpar = new System.Windows.Forms.Button();
            this.btsalvar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.retornarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(44, 92);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(368, 253);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage1.Controls.Add(this.mtbcpf);
            this.tabPage1.Controls.Add(this.tbnome);
            this.tabPage1.Controls.Add(this.lbcpf);
            this.tabPage1.Controls.Add(this.lbnome);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(360, 220);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados Pessoais";
            // 
            // mtbcpf
            // 
            this.mtbcpf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbcpf.Location = new System.Drawing.Point(45, 136);
            this.mtbcpf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtbcpf.Mask = "000,000,000-00";
            this.mtbcpf.Name = "mtbcpf";
            this.mtbcpf.Size = new System.Drawing.Size(129, 27);
            this.mtbcpf.TabIndex = 3;
            this.mtbcpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbcpf.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // tbnome
            // 
            this.tbnome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbnome.Location = new System.Drawing.Point(45, 81);
            this.tbnome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbnome.Name = "tbnome";
            this.tbnome.Size = new System.Drawing.Size(269, 27);
            this.tbnome.TabIndex = 2;
            // 
            // lbcpf
            // 
            this.lbcpf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbcpf.AutoSize = true;
            this.lbcpf.Location = new System.Drawing.Point(45, 112);
            this.lbcpf.Name = "lbcpf";
            this.lbcpf.Size = new System.Drawing.Size(33, 20);
            this.lbcpf.TabIndex = 1;
            this.lbcpf.Text = "CPF";
            // 
            // lbnome
            // 
            this.lbnome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbnome.AutoSize = true;
            this.lbnome.Location = new System.Drawing.Point(45, 57);
            this.lbnome.Name = "lbnome";
            this.lbnome.Size = new System.Drawing.Size(50, 20);
            this.lbnome.TabIndex = 0;
            this.lbnome.Text = "Nome";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage2.Controls.Add(this.btversenha);
            this.tabPage2.Controls.Add(this.tbsenha);
            this.tabPage2.Controls.Add(this.lbsenha);
            this.tabPage2.Controls.Add(this.mtbmatricula);
            this.tabPage2.Controls.Add(this.tbemail);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(360, 220);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Institucional";
            // 
            // btversenha
            // 
            this.btversenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btversenha.BackColor = System.Drawing.Color.Transparent;
            this.btversenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btversenha.FlatAppearance.BorderSize = 0;
            this.btversenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btversenha.Image = ((System.Drawing.Image)(resources.GetObject("btversenha.Image")));
            this.btversenha.Location = new System.Drawing.Point(286, 162);
            this.btversenha.Name = "btversenha";
            this.btversenha.Size = new System.Drawing.Size(34, 29);
            this.btversenha.TabIndex = 13;
            this.btversenha.UseVisualStyleBackColor = false;
            this.btversenha.Click += new System.EventHandler(this.btversenha_Click);
            // 
            // tbsenha
            // 
            this.tbsenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbsenha.Location = new System.Drawing.Point(46, 163);
            this.tbsenha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbsenha.Name = "tbsenha";
            this.tbsenha.Size = new System.Drawing.Size(240, 27);
            this.tbsenha.TabIndex = 9;
            this.tbsenha.UseSystemPasswordChar = true;
            // 
            // lbsenha
            // 
            this.lbsenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbsenha.AutoSize = true;
            this.lbsenha.Location = new System.Drawing.Point(46, 139);
            this.lbsenha.Name = "lbsenha";
            this.lbsenha.Size = new System.Drawing.Size(49, 20);
            this.lbsenha.TabIndex = 8;
            this.lbsenha.Text = "Senha";
            // 
            // mtbmatricula
            // 
            this.mtbmatricula.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbmatricula.Location = new System.Drawing.Point(46, 108);
            this.mtbmatricula.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtbmatricula.Mask = "00-00000";
            this.mtbmatricula.Name = "mtbmatricula";
            this.mtbmatricula.Size = new System.Drawing.Size(114, 27);
            this.mtbmatricula.TabIndex = 7;
            this.mtbmatricula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbmatricula.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // tbemail
            // 
            this.tbemail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbemail.Location = new System.Drawing.Point(46, 53);
            this.tbemail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(269, 27);
            this.tbemail.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Matrícula";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "E-mail Institucional";
            // 
            // lbcadastro
            // 
            this.lbcadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbcadastro.AutoSize = true;
            this.lbcadastro.Font = new System.Drawing.Font("Segoe UI Semibold", 14.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbcadastro.Location = new System.Drawing.Point(152, 44);
            this.lbcadastro.Name = "lbcadastro";
            this.lbcadastro.Size = new System.Drawing.Size(146, 35);
            this.lbcadastro.TabIndex = 19;
            this.lbcadastro.Text = "CADASTRO";
            // 
            // btlimpar
            // 
            this.btlimpar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btlimpar.BackColor = System.Drawing.Color.AliceBlue;
            this.btlimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btlimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btlimpar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btlimpar.Location = new System.Drawing.Point(48, 353);
            this.btlimpar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btlimpar.Name = "btlimpar";
            this.btlimpar.Size = new System.Drawing.Size(177, 29);
            this.btlimpar.TabIndex = 17;
            this.btlimpar.Text = "LIMPAR";
            this.btlimpar.UseVisualStyleBackColor = false;
            // 
            // btsalvar
            // 
            this.btsalvar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btsalvar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btsalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btsalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsalvar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btsalvar.Location = new System.Drawing.Point(231, 353);
            this.btsalvar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btsalvar.Name = "btsalvar";
            this.btsalvar.Size = new System.Drawing.Size(177, 29);
            this.btsalvar.TabIndex = 18;
            this.btsalvar.Text = "SALVAR";
            this.btsalvar.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.retornarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(451, 28);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // retornarToolStripMenuItem
            // 
            this.retornarToolStripMenuItem.Name = "retornarToolStripMenuItem";
            this.retornarToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.retornarToolStripMenuItem.Text = "Retornar";
            this.retornarToolStripMenuItem.Click += new System.EventHandler(this.retornarToolStripMenuItem_Click);
            // 
            // FormCadAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 424);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lbcadastro);
            this.Controls.Add(this.btlimpar);
            this.Controls.Add(this.btsalvar);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(469, 471);
            this.Name = "FormCadAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private MaskedTextBox mtbcpf;
        private TextBox tbnome;
        private Label lbcpf;
        private Label lbnome;
        private TabPage tabPage2;
        private Label lbcadastro;
        private Button btlimpar;
        private Button btsalvar;
        private MaskedTextBox mtbmatricula;
        private TextBox tbemail;
        private Label label1;
        private Label label3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem retornarToolStripMenuItem;
        private TextBox tbsenha;
        private Label lbsenha;
        private Button btversenha;
    }
}