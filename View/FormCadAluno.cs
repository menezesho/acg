using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_acg.View
{
    public partial class FormCadAluno : Form
    {
        public FormCadAluno()
        {
            InitializeComponent();
        }

        private void retornarToolStripMenuItem_Click(object sender, EventArgs e)
        {//strip >> retornar
            if (MessageBox.Show("Os dados não salvos serão perdidos. Deseja mesmo retornar?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes);
                Close();
        }

        private void btversenha_Click(object sender, EventArgs e)
        {//btversenha
            if (tbsenha.UseSystemPasswordChar.Equals(true))
                tbsenha.UseSystemPasswordChar = false;
            else
                tbsenha.UseSystemPasswordChar = true;
        }
    }
}
