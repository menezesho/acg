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
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lbsituacao = new System.Windows.Forms.Label();
            this.lbhorasfaltantes = new System.Windows.Forms.Label();
            this.lbhorastotais = new System.Windows.Forms.Label();
            this.lbnome = new System.Windows.Forms.Label();
            this.tbhorastotais = new System.Windows.Forms.TextBox();
            this.tbhorasfaltantes = new System.Windows.Forms.TextBox();
            this.btFechar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbcadastro
            // 
            this.lbcadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbcadastro.AutoSize = true;
            this.lbcadastro.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbcadastro.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbcadastro.Location = new System.Drawing.Point(246, 161);
            this.lbcadastro.Name = "lbcadastro";
            this.lbcadastro.Size = new System.Drawing.Size(328, 41);
            this.lbcadastro.TabIndex = 25;
            this.lbcadastro.Text = "VERIFICAR SITUAÇÃO";
            this.lbcadastro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbNome
            // 
            this.tbNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNome.BackColor = System.Drawing.Color.White;
            this.tbNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNome.Enabled = false;
            this.tbNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbNome.Location = new System.Drawing.Point(188, 279);
            this.tbNome.MaxLength = 50;
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(444, 34);
            this.tbNome.TabIndex = 0;
            this.tbNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbsituacao
            // 
            this.lbsituacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbsituacao.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbsituacao.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbsituacao.Location = new System.Drawing.Point(151, 418);
            this.lbsituacao.Name = "lbsituacao";
            this.lbsituacao.Size = new System.Drawing.Size(521, 53);
            this.lbsituacao.TabIndex = 33;
            this.lbsituacao.Text = "Situação: ";
            this.lbsituacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbhorasfaltantes
            // 
            this.lbhorasfaltantes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbhorasfaltantes.AutoSize = true;
            this.lbhorasfaltantes.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbhorasfaltantes.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbhorasfaltantes.Location = new System.Drawing.Point(451, 336);
            this.lbhorasfaltantes.Name = "lbhorasfaltantes";
            this.lbhorasfaltantes.Size = new System.Drawing.Size(102, 32);
            this.lbhorasfaltantes.TabIndex = 34;
            this.lbhorasfaltantes.Text = "Faltante";
            // 
            // lbhorastotais
            // 
            this.lbhorastotais.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbhorastotais.AutoSize = true;
            this.lbhorastotais.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbhorastotais.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbhorastotais.Location = new System.Drawing.Point(290, 336);
            this.lbhorastotais.Name = "lbhorastotais";
            this.lbhorastotais.Size = new System.Drawing.Size(67, 32);
            this.lbhorastotais.TabIndex = 35;
            this.lbhorastotais.Text = "Total";
            // 
            // lbnome
            // 
            this.lbnome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbnome.AutoSize = true;
            this.lbnome.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbnome.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbnome.Location = new System.Drawing.Point(370, 244);
            this.lbnome.Name = "lbnome";
            this.lbnome.Size = new System.Drawing.Size(80, 32);
            this.lbnome.TabIndex = 36;
            this.lbnome.Text = "Nome";
            // 
            // tbhorastotais
            // 
            this.tbhorastotais.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbhorastotais.BackColor = System.Drawing.Color.White;
            this.tbhorastotais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbhorastotais.Enabled = false;
            this.tbhorastotais.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbhorastotais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbhorastotais.Location = new System.Drawing.Point(245, 371);
            this.tbhorastotais.Name = "tbhorastotais";
            this.tbhorastotais.Size = new System.Drawing.Size(156, 34);
            this.tbhorastotais.TabIndex = 1;
            this.tbhorastotais.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbhorasfaltantes
            // 
            this.tbhorasfaltantes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbhorasfaltantes.BackColor = System.Drawing.Color.White;
            this.tbhorasfaltantes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbhorasfaltantes.Enabled = false;
            this.tbhorasfaltantes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbhorasfaltantes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbhorasfaltantes.Location = new System.Drawing.Point(424, 371);
            this.tbhorasfaltantes.Name = "tbhorasfaltantes";
            this.tbhorasfaltantes.Size = new System.Drawing.Size(156, 34);
            this.tbhorasfaltantes.TabIndex = 2;
            this.tbhorasfaltantes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btFechar
            // 
            this.btFechar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btFechar.BackColor = System.Drawing.Color.SteelBlue;
            this.btFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFechar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btFechar.ForeColor = System.Drawing.Color.White;
            this.btFechar.Location = new System.Drawing.Point(246, 495);
            this.btFechar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(334, 44);
            this.btFechar.TabIndex = 3;
            this.btFechar.Text = "FECHAR";
            this.btFechar.UseVisualStyleBackColor = false;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(678, 161);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(591, 378);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // FormVerificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 748);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbhorasfaltantes);
            this.Controls.Add(this.tbhorastotais);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.lbnome);
            this.Controls.Add(this.lbhorastotais);
            this.Controls.Add(this.lbhorasfaltantes);
            this.Controls.Add(this.lbsituacao);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.lbcadastro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1410, 795);
            this.Name = "FormVerificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Situação";
            this.Load += new System.EventHandler(this.FormVerificar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbcadastro;
        private TextBox tbNome;
        private Label lbsituacao;
        private Label lbhorasfaltantes;
        private Label lbhorastotais;
        private Label lbnome;
        private TextBox tbhorastotais;
        private TextBox tbhorasfaltantes;
        private Button btFechar;
        private PictureBox pictureBox1;
    }
}