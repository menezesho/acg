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
    public partial class FormCadAcg : Form
    {
        public FormCadAcg()
        {
            InitializeComponent();
        }

        private void FormCadAcg_Load(object sender, EventArgs e)
        {
            tbtipo.Text = "Curso, palestra, estágio...";
            tbtipo.TextAlign = HorizontalAlignment.Center;
        }

        private void btlimpar_Click(object sender, EventArgs e)
        {//btlimpar
            tbnome.Clear();
            mtbhoras.Clear();
            cbmodalidade.SelectedIndex = 0;
            tbtipo.Clear();
        }

        private void btcancelar_Click(object sender, EventArgs e)
        {//btcancelar
            if (MessageBox.Show("Os dados não salvos serão perdidos.\nDeseja mesmo retornar?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Close();
        }

        private void btsalvar_Click(object sender, EventArgs e)
        {//btsalvar
            if (tbnome.Text == "" || mtbhoras.Text == "__" || cbmodalidade.Text == "Selecione" || tbtipo.Text == "" || tbtipo.Text == "Curso, palestra, estágio...")
                MessageBox.Show("Preencha os campos vazios!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                Acg acg = new Acg();

                acg.nome = tbnome.Text;
                acg.horas = int.Parse(mtbhoras.Text);
                acg.modalidade = cbmodalidade.Text;
                acg.tipo = tbtipo.Text;

                Funcoes funcoes = new Funcoes();
                funcoes.cadastrarAcg(acg);
            }
        }

        private void tbtipo_Enter(object sender, EventArgs e)
        {
            tbtipo.Text = "";
            tbtipo.TextAlign = HorizontalAlignment.Left;
        }

        private void tbtipo_Leave(object sender, EventArgs e)
        {
            if (tbtipo.Text == "")
                tbtipo.Text = "Curso, palestra, estágio...";
                tbtipo.TextAlign = HorizontalAlignment.Center;
        }
    }
}
