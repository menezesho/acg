using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projeto_acg.Class;
using projeto_acg.DAO;

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
            cbmodalidade.SelectedIndex = 0;
            tbtipo.Text = "Curso, palestra, estágio...";
            tbtipo.TextAlign = HorizontalAlignment.Center;
        }

        private void btlimpar_Click(object sender, EventArgs e)
        {//btlimpar
            if (MessageBox.Show("Os dados não salvos serão perdidos.\nDeseja mesmo limpar todos os campos?", "Limpar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tbnome.Clear();
                mtbhoras.Clear();
                cbmodalidade.SelectedIndex = 0;
                tbtipo.Clear();
                tbtipo.Text = "Curso, palestra, estágio...";
                tbtipo.TextAlign = HorizontalAlignment.Center;
            }
        }

        private void btsalvar_Click(object sender, EventArgs e)
        {//btsalvar
            if (tbnome.Text == "" || mtbhoras.Text == "" || cbmodalidade.Text == "Selecione" || tbtipo.Text == "Curso, palestra, estágio...")
                MessageBox.Show("Preencha os campos vazios!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                Acg acg = new Acg();

                acg.nome = tbnome.Text;
                acg.horas = int.Parse(mtbhoras.Text);
                acg.modalidade = cbmodalidade.Text;
                acg.tipo = tbtipo.Text;

                AcgDAO acgDAO = new AcgDAO();
                acgDAO.validarAcg(acg.nome, acg);
            }
        }

        private void btcancelar_Click(object sender, EventArgs e)
        {//btcancelar
            if (tbnome.Text == "" || cbmodalidade.Text == "" || mtbhoras.Text == "" || tbtipo.Text == "")
            {
                Close();
            }
            else
            {
                if (MessageBox.Show("Os dados não salvos serão perdidos.\nDeseja mesmo retornar?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    Close();
            }
        }

        #region Máscaras

        private void tbtipo_Enter(object sender, EventArgs e)
        {
            if (tbtipo.Text == "" || tbtipo.Text == "Curso, palestra, estágio...") {
                tbtipo.Text = "";
                tbtipo.TextAlign = HorizontalAlignment.Left;
            }
        }

        private void tbtipo_Leave(object sender, EventArgs e)
        {
            if (tbtipo.Text == "")
            {
                tbtipo.Text = "Curso, palestra, estágio...";
                tbtipo.TextAlign = HorizontalAlignment.Center;
            }
        }

        private void cbmodalidade_Leave(object sender, EventArgs e)
        {
            if (cbmodalidade.Text == "")
                cbmodalidade.SelectedIndex = 0;
        }

        #endregion

    }
}
