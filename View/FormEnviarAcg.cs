using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_acg
{
    public partial class FormEnviarAcg : Form
    {
        Funcoes funcoes = new Funcoes();
        public FormEnviarAcg()
        {
            InitializeComponent();
        }

        private void FormEnviarAcg_Load(object sender, EventArgs e)
        {
            cbnome.DataSource = funcoes.listarAcg();
            cbnome.DisplayMember = "Nome";
            cbnome.Text = "Selecione";
        }

        private void btlimpar_Click(object sender, EventArgs e)
        {//btlimpar
            cbnome.Text = "Selecione";
            mtbhoras.Clear();
            tbmodalidade.Clear();
            tbtipo.Clear();
        }

        private void btcancelar_Click(object sender, EventArgs e)
        {//btcancelar
            if (MessageBox.Show("Os dados não salvos serão perdidos.\nDeseja mesmo retornar?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Close();
        }

        private void btsalvar_Click(object sender, EventArgs e)
        {//btsalvar
            
        }
    }
}
