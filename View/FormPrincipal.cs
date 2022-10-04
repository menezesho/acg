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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btenviaracg_Click(object sender, EventArgs e)
        {//btenviaracg
            FormEnviarAcg Feacg = new FormEnviarAcg();
            Feacg.ShowDialog();
        }

        private void btverificarsituacao_Click(object sender, EventArgs e)
        {//btverificarsituacao

        }

        private void btcadastraracg_Click(object sender, EventArgs e)
        {//btcadastraracg
            FormCadAcg Fcacg = new FormCadAcg();
            Fcacg.ShowDialog();
        }

        private void btlistaracgs_Click(object sender, EventArgs e)
        {//btlistaracgs

        }

        private void bteditaracgs_Click(object sender, EventArgs e)
        {//bteditaracgs

        }

        private void bteditaraluno_Click(object sender, EventArgs e)
        {//bteditaraluno
            FormEditAluno Fea = new FormEditAluno();
            Fea.ShowDialog();
        }

        private void lbsair_Click(object sender, EventArgs e)
        {//lbsair
            if (MessageBox.Show("Deseja mesmo sair do programa?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }
    }
}
