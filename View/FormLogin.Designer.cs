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
            this.btreload = new System.Windows.Forms.Button();
            this.btversenha = new System.Windows.Forms.Button();
            this.btsair = new System.Windows.Forms.Button();
            this.btlogin = new System.Windows.Forms.Button();
            this.lbsenha = new System.Windows.Forms.Label();
            this.lbmatricula = new System.Windows.Forms.Label();
            this.btprimeiroacesso = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mtbusuario = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbsenha
            // 
            this.tbsenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbsenha.Location = new System.Drawing.Point(141, 245);
            this.tbsenha.Name = "tbsenha";
            this.tbsenha.Size = new System.Drawing.Size(167, 27);
            this.tbsenha.TabIndex = 11;
            this.tbsenha.UseSystemPasswordChar = true;
            // 
            // btreload
            // 
            this.btreload.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btreload.BackColor = System.Drawing.Color.Transparent;
            this.btreload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btreload.FlatAppearance.BorderSize = 0;
            this.btreload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btreload.ForeColor = System.Drawing.Color.Transparent;
            this.btreload.Image = ((System.Drawing.Image)(resources.GetObject("btreload.Image")));
            this.btreload.Location = new System.Drawing.Point(309, 182);
            this.btreload.Name = "btreload";
            this.btreload.Size = new System.Drawing.Size(34, 28);
            this.btreload.TabIndex = 9;
            this.btreload.UseVisualStyleBackColor = true;
            // 
            // btversenha
            // 
            this.btversenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btversenha.BackColor = System.Drawing.Color.Transparent;
            this.btversenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btversenha.FlatAppearance.BorderSize = 0;
            this.btversenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btversenha.Image = ((System.Drawing.Image)(resources.GetObject("btversenha.Image")));
            this.btversenha.Location = new System.Drawing.Point(309, 244);
            this.btversenha.Name = "btversenha";
            this.btversenha.Size = new System.Drawing.Size(34, 29);
            this.btversenha.TabIndex = 12;
            this.btversenha.UseVisualStyleBackColor = false;
            this.btversenha.Click += new System.EventHandler(this.btversenha_Click);
            // 
            // btsair
            // 
            this.btsair.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btsair.BackColor = System.Drawing.Color.AliceBlue;
            this.btsair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btsair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsair.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btsair.Image = ((System.Drawing.Image)(resources.GetObject("btsair.Image")));
            this.btsair.Location = new System.Drawing.Point(296, 304);
            this.btsair.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btsair.Name = "btsair";
            this.btsair.Size = new System.Drawing.Size(47, 35);
            this.btsair.TabIndex = 14;
            this.btsair.UseVisualStyleBackColor = false;
            this.btsair.Click += new System.EventHandler(this.btsair_Click);
            // 
            // btlogin
            // 
            this.btlogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btlogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btlogin.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btlogin.Location = new System.Drawing.Point(54, 304);
            this.btlogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btlogin.Name = "btlogin";
            this.btlogin.Size = new System.Drawing.Size(236, 35);
            this.btlogin.TabIndex = 13;
            this.btlogin.Text = "LOGIN";
            this.btlogin.UseVisualStyleBackColor = false;
            this.btlogin.Click += new System.EventHandler(this.btlogin_Click);
            // 
            // lbsenha
            // 
            this.lbsenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbsenha.AutoSize = true;
            this.lbsenha.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbsenha.Location = new System.Drawing.Point(54, 246);
            this.lbsenha.Name = "lbsenha";
            this.lbsenha.Size = new System.Drawing.Size(57, 23);
            this.lbsenha.TabIndex = 10;
            this.lbsenha.Text = "Senha";
            // 
            // lbmatricula
            // 
            this.lbmatricula.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbmatricula.AutoSize = true;
            this.lbmatricula.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbmatricula.Location = new System.Drawing.Point(54, 184);
            this.lbmatricula.Name = "lbmatricula";
            this.lbmatricula.Size = new System.Drawing.Size(81, 23);
            this.lbmatricula.TabIndex = 8;
            this.lbmatricula.Text = "Matrícula";
            // 
            // btprimeiroacesso
            // 
            this.btprimeiroacesso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btprimeiroacesso.BackColor = System.Drawing.Color.AliceBlue;
            this.btprimeiroacesso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btprimeiroacesso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btprimeiroacesso.Font = new System.Drawing.Font("Segoe UI Semibold", 8.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btprimeiroacesso.Location = new System.Drawing.Point(54, 347);
            this.btprimeiroacesso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btprimeiroacesso.Name = "btprimeiroacesso";
            this.btprimeiroacesso.Size = new System.Drawing.Size(289, 35);
            this.btprimeiroacesso.TabIndex = 16;
            this.btprimeiroacesso.Text = "PRIMEIRO ACESSO";
            this.btprimeiroacesso.UseVisualStyleBackColor = false;
            this.btprimeiroacesso.Click += new System.EventHandler(this.btprimeiroacesso_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(357, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // mtbusuario
            // 
            this.mtbusuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbusuario.Location = new System.Drawing.Point(141, 183);
            this.mtbusuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtbusuario.Mask = "00-00000";
            this.mtbusuario.Name = "mtbusuario";
            this.mtbusuario.Size = new System.Drawing.Size(167, 27);
            this.mtbusuario.TabIndex = 18;
            this.mtbusuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 436);
            this.Controls.Add(this.mtbusuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btprimeiroacesso);
            this.Controls.Add(this.tbsenha);
            this.Controls.Add(this.btreload);
            this.Controls.Add(this.btversenha);
            this.Controls.Add(this.btsair);
            this.Controls.Add(this.btlogin);
            this.Controls.Add(this.lbsenha);
            this.Controls.Add(this.lbmatricula);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(416, 483);
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
        private Button btreload;
        private Button btversenha;
        private Button btsair;
        private Button btlogin;
        private Label lbsenha;
        private Label lbmatricula;
        private Button btprimeiroacesso;
        private PictureBox pictureBox1;
        private MaskedTextBox mtbusuario;
    }
}