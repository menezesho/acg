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
    public partial class FormEditAcg : Form
    {
        public FormEditAcg()
        {
            InitializeComponent();
        }

        private void FormEditAcg_Load(object sender, EventArgs e)
        {
            Funcoes funcoes = new Funcoes();
            dgalunos.DataSource = funcoes.listarAcg();

            tbnome.Clear();
            mtbhoras.Clear();
            cbmodalidade.SelectedIndex = 0;
            tbtipo.Clear();

            tbnome.Enabled = false;
            mtbhoras.Enabled = false;
            cbmodalidade.Enabled = false;
            tbtipo.Enabled = false;

            bteditar.Enabled = true;
            btcancelar.Enabled = false;
            btsalvar.Enabled = false;

            bteditar.BackColor = Color.GhostWhite;
            bteditar.ForeColor = Color.SteelBlue;
            btcancelar.BackColor = Color.Gainsboro;
            btcancelar.ForeColor = Color.GhostWhite;
            btsalvar.BackColor = Color.Gainsboro;
            btsalvar.ForeColor = Color.GhostWhite;
        }

        private void bteditar_Click(object sender, EventArgs e)
        {//bteditar

            tbnome.Enabled = true;
            mtbhoras.Enabled = true;
            cbmodalidade.Enabled = true;
            tbtipo.Enabled = true;

            bteditar.Enabled = false;
            btcancelar.Enabled = true;
            btsalvar.Enabled = true;

            bteditar.BackColor = Color.Gainsboro;
            bteditar.ForeColor = Color.GhostWhite;
            btcancelar.BackColor = Color.GhostWhite;
            btcancelar.ForeColor = Color.SteelBlue;
            btsalvar.BackColor = Color.SteelBlue;
            btsalvar.ForeColor = Color.White;
        }

        private void btexcluir_Click(object sender, EventArgs e)
        {//btexcluir

        }

        private void btcancelar_Click(object sender, EventArgs e)
        {//btcancelar

            tbnome.Enabled = false;
            mtbhoras.Enabled = false;
            cbmodalidade.Enabled = false;
            tbtipo.Enabled = false;

            bteditar.Enabled = true;
            btcancelar.Enabled = false;
            btsalvar.Enabled = false;

            bteditar.BackColor = Color.GhostWhite;
            bteditar.ForeColor = Color.SteelBlue;
            btcancelar.BackColor = Color.Gainsboro;
            btcancelar.ForeColor = Color.GhostWhite;
            btsalvar.BackColor = Color.Gainsboro;
            btsalvar.ForeColor = Color.GhostWhite;
        }

        private void btsalvar_Click(object sender, EventArgs e)
        {//btsalvar

        }

        private void lbsair_Click(object sender, EventArgs e)
        {//lbsair
            if (MessageBox.Show("Os dados não salvos serão perdidos.\nDeseja mesmo retornar?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Close();
        }
    }
}
