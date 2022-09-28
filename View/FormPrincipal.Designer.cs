namespace projeto_acg.View
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.msmenu = new System.Windows.Forms.MenuStrip();
            this.enviaracg = new System.Windows.Forms.ToolStripMenuItem();
            this.verificarsituacao = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastraracg = new System.Windows.Forms.ToolStripMenuItem();
            this.listaracgs = new System.Windows.Forms.ToolStripMenuItem();
            this.editaracgs = new System.Windows.Forms.ToolStripMenuItem();
            this.editaraluno = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.msmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // msmenu
            // 
            this.msmenu.AutoSize = false;
            this.msmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.msmenu.GripMargin = new System.Windows.Forms.Padding(2);
            this.msmenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enviaracg,
            this.verificarsituacao,
            this.cadastraracg,
            this.listaracgs,
            this.editaracgs,
            this.editaraluno});
            this.msmenu.Location = new System.Drawing.Point(0, 0);
            this.msmenu.Name = "msmenu";
            this.msmenu.Padding = new System.Windows.Forms.Padding(30);
            this.msmenu.Size = new System.Drawing.Size(311, 397);
            this.msmenu.TabIndex = 0;
            this.msmenu.Text = "menuStrip1";
            // 
            // enviaracg
            // 
            this.enviaracg.BackColor = System.Drawing.Color.SteelBlue;
            this.enviaracg.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enviaracg.ForeColor = System.Drawing.Color.GhostWhite;
            this.enviaracg.Margin = new System.Windows.Forms.Padding(5);
            this.enviaracg.Name = "enviaracg";
            this.enviaracg.Padding = new System.Windows.Forms.Padding(10);
            this.enviaracg.Size = new System.Drawing.Size(240, 47);
            this.enviaracg.Text = "ENVIAR ACG";
            this.enviaracg.MouseMove += new System.Windows.Forms.MouseEventHandler(this.todosToolStripMenuItem_MouseMove);
            // 
            // verificarsituacao
            // 
            this.verificarsituacao.BackColor = System.Drawing.Color.SteelBlue;
            this.verificarsituacao.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.verificarsituacao.ForeColor = System.Drawing.Color.GhostWhite;
            this.verificarsituacao.Margin = new System.Windows.Forms.Padding(5);
            this.verificarsituacao.Name = "verificarsituacao";
            this.verificarsituacao.Padding = new System.Windows.Forms.Padding(10);
            this.verificarsituacao.Size = new System.Drawing.Size(240, 47);
            this.verificarsituacao.Text = "VERIFICAR SITUAÇÃO";
            this.verificarsituacao.MouseMove += new System.Windows.Forms.MouseEventHandler(this.todosToolStripMenuItem_MouseMove);
            // 
            // cadastraracg
            // 
            this.cadastraracg.BackColor = System.Drawing.Color.SteelBlue;
            this.cadastraracg.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cadastraracg.ForeColor = System.Drawing.Color.GhostWhite;
            this.cadastraracg.Margin = new System.Windows.Forms.Padding(5);
            this.cadastraracg.Name = "cadastraracg";
            this.cadastraracg.Padding = new System.Windows.Forms.Padding(10);
            this.cadastraracg.Size = new System.Drawing.Size(240, 47);
            this.cadastraracg.Text = "CADASTRAR ACG";
            this.cadastraracg.MouseMove += new System.Windows.Forms.MouseEventHandler(this.todosToolStripMenuItem_MouseMove);
            // 
            // listaracgs
            // 
            this.listaracgs.BackColor = System.Drawing.Color.SteelBlue;
            this.listaracgs.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listaracgs.ForeColor = System.Drawing.Color.GhostWhite;
            this.listaracgs.Margin = new System.Windows.Forms.Padding(5);
            this.listaracgs.Name = "listaracgs";
            this.listaracgs.Padding = new System.Windows.Forms.Padding(10);
            this.listaracgs.Size = new System.Drawing.Size(240, 47);
            this.listaracgs.Text = "LISTAR ACGs";
            this.listaracgs.MouseMove += new System.Windows.Forms.MouseEventHandler(this.todosToolStripMenuItem_MouseMove);
            // 
            // editaracgs
            // 
            this.editaracgs.BackColor = System.Drawing.Color.SteelBlue;
            this.editaracgs.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editaracgs.ForeColor = System.Drawing.Color.GhostWhite;
            this.editaracgs.Margin = new System.Windows.Forms.Padding(5);
            this.editaracgs.Name = "editaracgs";
            this.editaracgs.Padding = new System.Windows.Forms.Padding(10);
            this.editaracgs.Size = new System.Drawing.Size(240, 47);
            this.editaracgs.Text = "EDITAR ACGs";
            this.editaracgs.MouseMove += new System.Windows.Forms.MouseEventHandler(this.todosToolStripMenuItem_MouseMove);
            // 
            // editaraluno
            // 
            this.editaraluno.BackColor = System.Drawing.Color.SteelBlue;
            this.editaraluno.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editaraluno.ForeColor = System.Drawing.Color.GhostWhite;
            this.editaraluno.Margin = new System.Windows.Forms.Padding(5);
            this.editaraluno.Name = "editaraluno";
            this.editaraluno.Padding = new System.Windows.Forms.Padding(10);
            this.editaraluno.Size = new System.Drawing.Size(240, 47);
            this.editaraluno.Text = "EDITAR ALUNO";
            this.editaraluno.MouseMove += new System.Windows.Forms.MouseEventHandler(this.todosToolStripMenuItem_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(314, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(385, 350);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 397);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.msmenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msmenu;
            this.MinimumSize = new System.Drawing.Size(736, 444);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.msmenu.ResumeLayout(false);
            this.msmenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MenuStrip msmenu;
        private ToolStripMenuItem enviaracg;
        private ToolStripMenuItem editaraluno;
        private PictureBox pictureBox1;
        private ToolStripMenuItem verificarsituacao;
        private ToolStripMenuItem cadastraracg;
        private ToolStripMenuItem listaracgs;
        private ToolStripMenuItem editaracgs;
    }
}