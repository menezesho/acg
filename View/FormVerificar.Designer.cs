namespace projeto_acg
{
    partial class FormVerificar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVerificar));
            this.lbcadastro = new System.Windows.Forms.Label();
            this.tbnome = new System.Windows.Forms.TextBox();
            this.lbmatricula = new System.Windows.Forms.Label();
            this.lbsituacao = new System.Windows.Forms.Label();
            this.lbhorasfaltantes = new System.Windows.Forms.Label();
            this.lbhorastotais = new System.Windows.Forms.Label();
            this.lbnome = new System.Windows.Forms.Label();
            this.mtbmatricula = new System.Windows.Forms.MaskedTextBox();
            this.btcancelar = new System.Windows.Forms.Button();
            this.btlimpar = new System.Windows.Forms.Button();
            this.btenviar = new System.Windows.Forms.Button();
            this.tbhorastotais = new System.Windows.Forms.TextBox();
            this.tbhorasfaltantes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbcadastro
            // 
            this.lbcadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbcadastro.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbcadastro.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbcadastro.Location = new System.Drawing.Point(86, 80);
            this.lbcadastro.Name = "lbcadastro";
            this.lbcadastro.Size = new System.Drawing.Size(422, 38);
            this.lbcadastro.TabIndex = 25;
            this.lbcadastro.Text = "VERIFICAR SITUAÇÃO";
            this.lbcadastro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbnome
            // 
            this.tbnome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbnome.BackColor = System.Drawing.Color.White;
            this.tbnome.Enabled = false;
            this.tbnome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbnome.Location = new System.Drawing.Point(86, 253);
            this.tbnome.MaxLength = 50;
            this.tbnome.Name = "tbnome";
            this.tbnome.Size = new System.Drawing.Size(422, 29);
            this.tbnome.TabIndex = 26;
            // 
            // lbmatricula
            // 
            this.lbmatricula.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbmatricula.AutoSize = true;
            this.lbmatricula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbmatricula.Location = new System.Drawing.Point(86, 170);
            this.lbmatricula.Name = "lbmatricula";
            this.lbmatricula.Size = new System.Drawing.Size(75, 21);
            this.lbmatricula.TabIndex = 30;
            this.lbmatricula.Text = "Matrícula";
            // 
            // lbsituacao
            // 
            this.lbsituacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbsituacao.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbsituacao.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbsituacao.Location = new System.Drawing.Point(86, 408);
            this.lbsituacao.Name = "lbsituacao";
            this.lbsituacao.Size = new System.Drawing.Size(422, 34);
            this.lbsituacao.TabIndex = 33;
            this.lbsituacao.Text = "Situação: ";
            this.lbsituacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbhorasfaltantes
            // 
            this.lbhorasfaltantes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbhorasfaltantes.AutoSize = true;
            this.lbhorasfaltantes.Font = new System.Drawing.Font("Segoe UI", 9.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbhorasfaltantes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbhorasfaltantes.Location = new System.Drawing.Point(403, 171);
            this.lbhorasfaltantes.Name = "lbhorasfaltantes";
            this.lbhorasfaltantes.Size = new System.Drawing.Size(64, 21);
            this.lbhorasfaltantes.TabIndex = 34;
            this.lbhorasfaltantes.Text = "Faltante";
            // 
            // lbhorastotais
            // 
            this.lbhorastotais.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbhorastotais.AutoSize = true;
            this.lbhorastotais.Font = new System.Drawing.Font("Segoe UI", 9.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbhorastotais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbhorastotais.Location = new System.Drawing.Point(292, 171);
            this.lbhorastotais.Name = "lbhorastotais";
            this.lbhorastotais.Size = new System.Drawing.Size(42, 21);
            this.lbhorastotais.TabIndex = 35;
            this.lbhorastotais.Text = "Total";
            // 
            // lbnome
            // 
            this.lbnome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbnome.AutoSize = true;
            this.lbnome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbnome.Location = new System.Drawing.Point(86, 228);
            this.lbnome.Name = "lbnome";
            this.lbnome.Size = new System.Drawing.Size(53, 21);
            this.lbnome.TabIndex = 36;
            this.lbnome.Text = "Nome";
            // 
            // mtbmatricula
            // 
            this.mtbmatricula.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbmatricula.BackColor = System.Drawing.Color.White;
            this.mtbmatricula.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.mtbmatricula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mtbmatricula.Location = new System.Drawing.Point(86, 195);
            this.mtbmatricula.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtbmatricula.Mask = "00-00000";
            this.mtbmatricula.Name = "mtbmatricula";
            this.mtbmatricula.Size = new System.Drawing.Size(125, 29);
            this.mtbmatricula.TabIndex = 37;
            this.mtbmatricula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbmatricula.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // btcancelar
            // 
            this.btcancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btcancelar.BackColor = System.Drawing.Color.GhostWhite;
            this.btcancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btcancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btcancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btcancelar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btcancelar.Location = new System.Drawing.Point(300, 313);
            this.btcancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(208, 37);
            this.btcancelar.TabIndex = 39;
            this.btcancelar.Text = "CANCELAR";
            this.btcancelar.UseVisualStyleBackColor = false;
            this.btcancelar.Click += new System.EventHandler(this.btcancelar_Click);
            // 
            // btlimpar
            // 
            this.btlimpar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btlimpar.BackColor = System.Drawing.Color.GhostWhite;
            this.btlimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btlimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btlimpar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btlimpar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btlimpar.Location = new System.Drawing.Point(86, 313);
            this.btlimpar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btlimpar.Name = "btlimpar";
            this.btlimpar.Size = new System.Drawing.Size(208, 37);
            this.btlimpar.TabIndex = 38;
            this.btlimpar.Text = "LIMPAR";
            this.btlimpar.UseVisualStyleBackColor = false;
            this.btlimpar.Click += new System.EventHandler(this.btlimpar_Click);
            // 
            // btenviar
            // 
            this.btenviar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btenviar.BackColor = System.Drawing.Color.SteelBlue;
            this.btenviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btenviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btenviar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btenviar.ForeColor = System.Drawing.Color.White;
            this.btenviar.Location = new System.Drawing.Point(86, 358);
            this.btenviar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btenviar.Name = "btenviar";
            this.btenviar.Size = new System.Drawing.Size(422, 37);
            this.btenviar.TabIndex = 40;
            this.btenviar.Text = "VERIFICAR";
            this.btenviar.UseVisualStyleBackColor = false;
            this.btenviar.Click += new System.EventHandler(this.btverificar_Click);
            // 
            // tbhorastotais
            // 
            this.tbhorastotais.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbhorastotais.BackColor = System.Drawing.Color.White;
            this.tbhorastotais.Enabled = false;
            this.tbhorastotais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbhorastotais.Location = new System.Drawing.Point(292, 195);
            this.tbhorastotais.Name = "tbhorastotais";
            this.tbhorastotais.Size = new System.Drawing.Size(105, 29);
            this.tbhorastotais.TabIndex = 41;
            this.tbhorastotais.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbhorasfaltantes
            // 
            this.tbhorasfaltantes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbhorasfaltantes.BackColor = System.Drawing.Color.White;
            this.tbhorasfaltantes.Enabled = false;
            this.tbhorasfaltantes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbhorasfaltantes.Location = new System.Drawing.Point(403, 195);
            this.tbhorasfaltantes.Name = "tbhorasfaltantes";
            this.tbhorasfaltantes.Size = new System.Drawing.Size(105, 29);
            this.tbhorasfaltantes.TabIndex = 42;
            this.tbhorasfaltantes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormVerificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 505);
            this.Controls.Add(this.tbhorasfaltantes);
            this.Controls.Add(this.tbhorastotais);
            this.Controls.Add(this.btcancelar);
            this.Controls.Add(this.btlimpar);
            this.Controls.Add(this.btenviar);
            this.Controls.Add(this.mtbmatricula);
            this.Controls.Add(this.lbnome);
            this.Controls.Add(this.lbhorastotais);
            this.Controls.Add(this.lbhorasfaltantes);
            this.Controls.Add(this.lbsituacao);
            this.Controls.Add(this.lbmatricula);
            this.Controls.Add(this.tbnome);
            this.Controls.Add(this.lbcadastro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormVerificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Situação";
            this.Load += new System.EventHandler(this.FormVerificar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbcadastro;
        private TextBox tbnome;
        private Label lbmatricula;
        private Label lbsituacao;
        private Label lbhorasfaltantes;
        private Label lbhorastotais;
        private Label lbnome;
        private MaskedTextBox mtbmatricula;
        private Button btcancelar;
        private Button btlimpar;
        private Button btenviar;
        private TextBox tbhorastotais;
        private TextBox tbhorasfaltantes;
    }
}