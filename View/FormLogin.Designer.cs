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
            this.lbusuario = new System.Windows.Forms.Label();
            this.btprimeiroacesso = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mtbUsuario = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbsenha
            // 
            this.tbsenha.Location = new System.Drawing.Point(42, 178);
            this.tbsenha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbsenha.Name = "tbsenha";
            this.tbsenha.Size = new System.Drawing.Size(252, 23);
            this.tbsenha.TabIndex = 11;
            this.tbsenha.UseSystemPasswordChar = true;
            // 
            // btreload
            // 
            this.btreload.BackColor = System.Drawing.Color.Transparent;
            this.btreload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btreload.FlatAppearance.BorderSize = 0;
            this.btreload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btreload.ForeColor = System.Drawing.Color.Transparent;
            this.btreload.Image = ((System.Drawing.Image)(resources.GetObject("btreload.Image")));
            this.btreload.Location = new System.Drawing.Point(294, 128);
            this.btreload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btreload.Name = "btreload";
            this.btreload.Size = new System.Drawing.Size(30, 21);
            this.btreload.TabIndex = 9;
            this.btreload.UseVisualStyleBackColor = true;
            // 
            // btversenha
            // 
            this.btversenha.BackColor = System.Drawing.Color.Transparent;
            this.btversenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btversenha.FlatAppearance.BorderSize = 0;
            this.btversenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btversenha.Image = ((System.Drawing.Image)(resources.GetObject("btversenha.Image")));
            this.btversenha.Location = new System.Drawing.Point(294, 176);
            this.btversenha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btversenha.Name = "btversenha";
            this.btversenha.Size = new System.Drawing.Size(30, 22);
            this.btversenha.TabIndex = 12;
            this.btversenha.UseVisualStyleBackColor = false;
            // 
            // btsair
            // 
            this.btsair.BackColor = System.Drawing.Color.AliceBlue;
            this.btsair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btsair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsair.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btsair.Image = ((System.Drawing.Image)(resources.GetObject("btsair.Image")));
            this.btsair.Location = new System.Drawing.Point(283, 222);
            this.btsair.Name = "btsair";
            this.btsair.Size = new System.Drawing.Size(41, 26);
            this.btsair.TabIndex = 14;
            this.btsair.UseVisualStyleBackColor = false;
            this.btsair.Click += new System.EventHandler(this.btsair_Click);
            // 
            // btlogin
            // 
            this.btlogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btlogin.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btlogin.Location = new System.Drawing.Point(42, 222);
            this.btlogin.Name = "btlogin";
            this.btlogin.Size = new System.Drawing.Size(235, 26);
            this.btlogin.TabIndex = 13;
            this.btlogin.Text = "LOGIN";
            this.btlogin.UseVisualStyleBackColor = false;
            this.btlogin.Click += new System.EventHandler(this.btlogin_Click);
            // 
            // lbsenha
            // 
            this.lbsenha.AutoSize = true;
            this.lbsenha.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbsenha.Location = new System.Drawing.Point(42, 158);
            this.lbsenha.Name = "lbsenha";
            this.lbsenha.Size = new System.Drawing.Size(46, 19);
            this.lbsenha.TabIndex = 10;
            this.lbsenha.Text = "Senha";
            // 
            // lbusuario
            // 
            this.lbusuario.AutoSize = true;
            this.lbusuario.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbusuario.Location = new System.Drawing.Point(42, 109);
            this.lbusuario.Name = "lbusuario";
            this.lbusuario.Size = new System.Drawing.Size(56, 19);
            this.lbusuario.TabIndex = 8;
            this.lbusuario.Text = "Usuário";
            // 
            // btprimeiroacesso
            // 
            this.btprimeiroacesso.BackColor = System.Drawing.Color.AliceBlue;
            this.btprimeiroacesso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btprimeiroacesso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btprimeiroacesso.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btprimeiroacesso.Location = new System.Drawing.Point(42, 254);
            this.btprimeiroacesso.Name = "btprimeiroacesso";
            this.btprimeiroacesso.Size = new System.Drawing.Size(282, 26);
            this.btprimeiroacesso.TabIndex = 16;
            this.btprimeiroacesso.Text = "PRIMEIRO ACESSO";
            this.btprimeiroacesso.UseVisualStyleBackColor = false;
            this.btprimeiroacesso.Click += new System.EventHandler(this.btprimeiroacesso_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // mtbUsuario
            // 
            this.mtbUsuario.Location = new System.Drawing.Point(42, 131);
            this.mtbUsuario.Mask = "00-00000";
            this.mtbUsuario.Name = "mtbUsuario";
            this.mtbUsuario.Size = new System.Drawing.Size(252, 23);
            this.mtbUsuario.TabIndex = 18;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 314);
            this.Controls.Add(this.mtbUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btprimeiroacesso);
            this.Controls.Add(this.tbsenha);
            this.Controls.Add(this.btreload);
            this.Controls.Add(this.btversenha);
            this.Controls.Add(this.btsair);
            this.Controls.Add(this.btlogin);
            this.Controls.Add(this.lbsenha);
            this.Controls.Add(this.lbusuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private Label lbusuario;
        private Button btprimeiroacesso;
        private PictureBox pictureBox1;
        private MaskedTextBox mtbUsuario;
    }
}