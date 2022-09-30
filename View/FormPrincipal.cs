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

        private void bteditaraluno_Click(object sender, EventArgs e)
        {//bteditaraluno
            FormEditAluno Fea = new FormEditAluno();
            Fea.ShowDialog();
        }

        private void btenviaracg_Click(object sender, EventArgs e)
        {//btenviar ACG
            FormCadAcg Fca = new FormCadAcg();
            Fca.ShowDialog();
        }

        private void btsair_Click(object sender, EventArgs e)
        {//btsair
            if (MessageBox.Show("Deseja mesmo sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Close();
        }
    }
}
