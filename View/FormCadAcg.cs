using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projeto_acg.Class;
using projeto_acg.DAO;

namespace projeto_acg.View
{
    public partial class FormCadAcg : Form
    {
        Conexao conec = new Conexao();

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
                mtbhoras.Mask = "";
                cbmodalidade.SelectedIndex = 0;
                tbtipo.Clear();
                tbtipo.Text = "Curso, palestra, estágio...";
                tbtipo.TextAlign = HorizontalAlignment.Center;
            }
        }

        private void btsalvar_Click(object sender, EventArgs e)
        {//btcadastrar
            if (tbnome.Text == "" || mtbhoras.Text == "" || cbmodalidade.Text == "Selecione" || tbtipo.Text == "Curso, palestra, estágio...")
                MessageBox.Show("Preencha os campos vazios!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try
                {
                    SqlConnection conexao = new SqlConnection(conec.conexaoBD());
                    string sqlSelect = @"SELECT * FROM acg WHERE nome=@nome";
                    SqlCommand comandoSelect = new SqlCommand(sqlSelect, conexao);

                    comandoSelect.Parameters.AddWithValue("@nome", tbnome.Text);

                    conexao.Open();
                    SqlDataReader dados = comandoSelect.ExecuteReader();
                    if (dados.Read())
                    {
                        MessageBox.Show("ACG de mesmo nome já cadastrada!\nCadastre com um nome diferente ou adicione um complemento!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        conexao.Close();
                    }
                    else
                    {
                        conexao.Close();
                        string sqlInsert = @"INSERT INTO acg (nome, modalidade, tipo, horas) VALUES (@nome, @modalidade, @tipo, @horas)";
                        SqlCommand comandoInsert = new SqlCommand(sqlInsert, conexao);

                        comandoInsert.Parameters.AddWithValue("@nome", tbnome.Text);
                        comandoInsert.Parameters.AddWithValue("@horas", mtbhoras.Text);
                        comandoInsert.Parameters.AddWithValue("@modalidade", cbmodalidade.Text);
                        comandoInsert.Parameters.AddWithValue("@tipo", tbtipo.Text);

                        conexao.Open();
                        comandoInsert.CommandText = sqlInsert;
                        comandoInsert.ExecuteNonQuery();
                        conexao.Close();
                        MessageBox.Show("Cadastro efetuado com sucesso!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btcancelar_Click(object sender, EventArgs e)
        {//btcancelar
            if (tbnome.Text == "" && cbmodalidade.SelectedIndex == 0 && mtbhoras.Text == "" && tbtipo.Text == "Curso, palestra, estágio...")
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
