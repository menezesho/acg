using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            tbbusca.Text = "Busca...";

            Funcoes funcoes = new Funcoes();
            dgacg.DataSource = funcoes.listarAcg();

            tbnome.Clear();
            mtbhoras.Clear();
            cbmodalidade.SelectedIndex = 0;
            tbtipo.Clear();

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
            if (tbid.Text != "")
            {
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
            else
                MessageBox.Show("Nenhum cadastro foi selecionado, tente novamente!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btexcluir_Click(object sender, EventArgs e)
        {//btexcluir
            if (tbid.Text != "")
            {
                if (MessageBox.Show("Deseja mesmo excluir este cadastro?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int id = int.Parse(tbid.Text);
                    Acg acg = new Acg();
                    Funcoes funcoes = new Funcoes();
                    funcoes.excluirAcg(acg, id);
                    dgacg.DataSource = funcoes.listarAcg();

                    tbnome.Clear();
                    mtbhoras.Clear();
                    cbmodalidade.SelectedIndex = 0;
                    tbtipo.Clear();

                    mtbhoras.Enabled = false;
                    cbmodalidade.Enabled = false;
                    tbtipo.Enabled = false;

                    bteditar.Enabled = true;
                    btsalvar.Enabled = false;
                    btcancelar.Enabled = false;

                    bteditar.BackColor = Color.GhostWhite;
                    bteditar.ForeColor = Color.SteelBlue;
                    btcancelar.BackColor = Color.Gainsboro;
                    btcancelar.ForeColor = Color.GhostWhite;
                    btsalvar.BackColor = Color.Gainsboro;
                    btsalvar.ForeColor = Color.GhostWhite;

                    //btbuscar.Enabled = true;
                }
            }
            else
                MessageBox.Show("Nenhum cadastro foi selecionado, tente novamente!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btcancelar_Click(object sender, EventArgs e)
        {//btcancelar
            if (tbid.Text != "")
            {
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
            else
                MessageBox.Show("Os dados registrados não seram salvos!", "Retornar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btsalvar_Click(object sender, EventArgs e)
        {//btsalvar
            if (tbnome.Text == "" || cbmodalidade.Text == "" || mtbhoras.Text == "" || tbtipo.Text == "")
                MessageBox.Show("Preencha os campos vazios!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                int id = int.Parse(tbid.Text);
                Acg acg = new Acg();

                acg.modalidade = cbmodalidade.Text;
                acg.horas = int.Parse(mtbhoras.Text);
                acg.tipo = tbtipo.Text;

                Funcoes funcoes = new Funcoes();
                funcoes.editarAcg(acg, id);
                dgacg.DataSource = funcoes.listarAcg();

                tbid.Clear();
                tbnome.Clear();
                cbmodalidade.SelectedIndex = 0;
                tbtipo.Clear();
                mtbhoras.Clear();

                cbmodalidade.Enabled = false;
                tbtipo.Enabled = false;
                mtbhoras.Enabled = false;

                bteditar.Enabled = true;
                btcancelar.Enabled = false;
                btsalvar.Enabled = false;

                bteditar.BackColor = Color.GhostWhite;
                bteditar.ForeColor = Color.SteelBlue;
                btcancelar.BackColor = Color.Gainsboro;
                btcancelar.ForeColor = Color.GhostWhite;
                btsalvar.BackColor = Color.Gainsboro;
                btsalvar.ForeColor = Color.GhostWhite;

                //btbuscar.Enabled = true;
            }
        }

        private void lbsair_Click(object sender, EventArgs e)
        {//lbsair
            if (MessageBox.Show("Os dados não salvos serão perdidos.\nDeseja mesmo retornar?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Close();
        }

        private void dgacg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbid.Text = dgacg.CurrentRow.Cells[0].Value.ToString();
            tbnome.Text = dgacg.CurrentRow.Cells[1].Value.ToString();
            mtbhoras.Text = dgacg.CurrentRow.Cells[2].Value.ToString();
            cbmodalidade.Text = dgacg.CurrentRow.Cells[3].Value.ToString();
            tbtipo.Text = dgacg.CurrentRow.Cells[4].Value.ToString();

            cbmodalidade.Enabled = false;
            mtbhoras.Enabled = false;
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

        private void lbbusca_Click(object sender, EventArgs e)
        {//lbbuscar

            string strConexao = @"Data Source=Lenovo-L340\sqlexpress;Initial Catalog=BD_ACG;Integrated Security=True";
            SqlConnection conexao = new SqlConnection(strConexao);
            string sql = @"SELECT id AS ID, nome as Nome, modalidade as Modalidade, tipo as Tipo, horas as Horas FROM acg WHERE nome LIKE @nome ORDER BY nome";
            SqlCommand comando = new SqlCommand(sql, conexao);

            comando.Parameters.AddWithValue("@nome", "%" + tbbusca.Text + "%");

            conexao.Open();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            DataSet tabela = new DataSet();
            da.Fill(tabela);
            dgacg.DataSource = tabela.Tables[0];
            conexao.Close();
        }

        #region Máscaras

        private void tbbusca_Enter(object sender, EventArgs e)
        {
            if (tbbusca.Text == "Busca...")
                tbbusca.Text = "";
        }

        private void tbbusca_Leave(object sender, EventArgs e)
        {
            if (tbbusca.Text == "")
                tbbusca.Text = "Busca...";
        }

        #endregion

    }
}
