﻿namespace projeto_acg
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.tbsenha = new System.Windows.Forms.TextBox();
            this.btversenha = new System.Windows.Forms.Button();
            this.btlogin = new System.Windows.Forms.Button();
            this.lbsenha = new System.Windows.Forms.Label();
            this.lbmatricula = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mtbmatricula = new System.Windows.Forms.MaskedTextBox();
            this.lbinfo = new System.Windows.Forms.Label();
            this.lbcadastrese = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbsenha
            // 
            this.tbsenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbsenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbsenha.Location = new System.Drawing.Point(117, 312);
            this.tbsenha.Name = "tbsenha";
            this.tbsenha.Size = new System.Drawing.Size(236, 29);
            this.tbsenha.TabIndex = 3;
            this.tbsenha.UseSystemPasswordChar = true;
            // 
            // btversenha
            // 
            this.btversenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btversenha.BackColor = System.Drawing.Color.Transparent;
            this.btversenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btversenha.FlatAppearance.BorderSize = 0;
            this.btversenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btversenha.Image = ((System.Drawing.Image)(resources.GetObject("btversenha.Image")));
            this.btversenha.Location = new System.Drawing.Point(355, 311);
            this.btversenha.Name = "btversenha";
            this.btversenha.Size = new System.Drawing.Size(38, 30);
            this.btversenha.TabIndex = 4;
            this.btversenha.UseVisualStyleBackColor = false;
            this.btversenha.Click += new System.EventHandler(this.btversenha_Click);
            // 
            // btlogin
            // 
            this.btlogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btlogin.BackColor = System.Drawing.Color.SteelBlue;
            this.btlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btlogin.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btlogin.ForeColor = System.Drawing.Color.GhostWhite;
            this.btlogin.Location = new System.Drawing.Point(117, 371);
            this.btlogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btlogin.Name = "btlogin";
            this.btlogin.Size = new System.Drawing.Size(236, 37);
            this.btlogin.TabIndex = 0;
            this.btlogin.Text = "LOGIN";
            this.btlogin.UseVisualStyleBackColor = false;
            this.btlogin.Click += new System.EventHandler(this.btlogin_Click);
            // 
            // lbsenha
            // 
            this.lbsenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbsenha.AutoSize = true;
            this.lbsenha.Font = new System.Drawing.Font("Segoe UI", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbsenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbsenha.Location = new System.Drawing.Point(117, 288);
            this.lbsenha.Name = "lbsenha";
            this.lbsenha.Size = new System.Drawing.Size(53, 21);
            this.lbsenha.TabIndex = 10;
            this.lbsenha.Text = "Senha";
            // 
            // lbmatricula
            // 
            this.lbmatricula.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbmatricula.AutoSize = true;
            this.lbmatricula.Font = new System.Drawing.Font("Segoe UI", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbmatricula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbmatricula.Location = new System.Drawing.Point(117, 216);
            this.lbmatricula.Name = "lbmatricula";
            this.lbmatricula.Size = new System.Drawing.Size(75, 21);
            this.lbmatricula.TabIndex = 8;
            this.lbmatricula.Text = "Matrícula";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(475, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // mtbmatricula
            // 
            this.mtbmatricula.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbmatricula.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.mtbmatricula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mtbmatricula.Location = new System.Drawing.Point(117, 241);
            this.mtbmatricula.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtbmatricula.Mask = "00-00000";
            this.mtbmatricula.Name = "mtbmatricula";
            this.mtbmatricula.Size = new System.Drawing.Size(236, 29);
            this.mtbmatricula.TabIndex = 2;
            this.mtbmatricula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbmatricula.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbmatricula.Enter += new System.EventHandler(this.mtbmatricula_Enter);
            this.mtbmatricula.Leave += new System.EventHandler(this.mtbmatricula_Leave);
            // 
            // lbinfo
            // 
            this.lbinfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbinfo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbinfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbinfo.Location = new System.Drawing.Point(117, 422);
            this.lbinfo.Name = "lbinfo";
            this.lbinfo.Size = new System.Drawing.Size(236, 29);
            this.lbinfo.TabIndex = 18;
            this.lbinfo.Text = "Ainda não possui um cadastro?";
            this.lbinfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbcadastrese
            // 
            this.lbcadastrese.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbcadastrese.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbcadastrese.Font = new System.Drawing.Font("Segoe UI Semibold", 11.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbcadastrese.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbcadastrese.Location = new System.Drawing.Point(176, 451);
            this.lbcadastrese.Name = "lbcadastrese";
            this.lbcadastrese.Size = new System.Drawing.Size(120, 23);
            this.lbcadastrese.TabIndex = 1;
            this.lbcadastrese.Text = "Cadastre-se!";
            this.lbcadastrese.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbcadastrese.Click += new System.EventHandler(this.lbcadastrese_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 587);
            this.Controls.Add(this.btversenha);
            this.Controls.Add(this.lbcadastrese);
            this.Controls.Add(this.lbinfo);
            this.Controls.Add(this.mtbmatricula);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbsenha);
            this.Controls.Add(this.btlogin);
            this.Controls.Add(this.lbsenha);
            this.Controls.Add(this.lbmatricula);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(503, 634);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbsenha;
        private Button btversenha;
        private Button btlogin;
        private Label lbsenha;
        private Label lbmatricula;
        private PictureBox pictureBox1;
        private MaskedTextBox mtbmatricula;
        private Label lbinfo;
        private Label lbcadastrese;
    }
}