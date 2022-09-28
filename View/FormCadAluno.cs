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

        private void FormCadAluno_Load(object sender, EventArgs e)
        {
            tbnome.Clear();
            mtbcpf.Clear();
            tbemail.Clear();
            mtbmatricula.Clear();
            tbsenha.Clear();
        }

        private void retornarToolStripMenuItem_Click(object sender, EventArgs e)
        {//strip >> retornar
            if (MessageBox.Show("Os dados não salvos serão perdidos. Deseja mesmo retornar?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Close();
        }

        private void btversenha_Click(object sender, EventArgs e)
        {//btversenha
            if (tbsenha.UseSystemPasswordChar.Equals(true))
                tbsenha.UseSystemPasswordChar = false;
            else
                tbsenha.UseSystemPasswordChar = true;
        }

        private void btcancelar_Click(object sender, EventArgs e)
        {//btcancelar
            if (MessageBox.Show("Os dados não salvos serão perdidos.\nDeseja mesmo retornar para o menu principal?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Close();
        }

        private void btlimpar_Click(object sender, EventArgs e)
        {
            tbnome.Clear();
            mtbcpf.Clear();
            tbemail.Clear();
            mtbmatricula.Clear();
            tbsenha.Clear();
        }
    }
}
