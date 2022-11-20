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
using projeto_acg.Class;
using projeto_acg.DAO;

namespace projeto_acg
{
    public partial class FormEnviarAcg : Form
    {
        string matriculaAtual = "";
        bool carregou = false;

        public FormEnviarAcg()
        {
            InitializeComponent();
        }

        public FormEnviarAcg(string matricula)
        {
            InitializeComponent();
            matriculaAtual = matricula;
        }

        private void FormEnviarAcg_Load(object sender, EventArgs e)
        {
            AcgDAO acgDAO = new AcgDAO();
            cbnome.DataSource = acgDAO.listarAcg();
            cbnome.DisplayMember = "Nome";
            cbnome.ValueMember = "ID";
            tbmodalidade.Clear();
            tbtipo.Clear();
            mtbhoras.Clear();
            carregou = true;
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
            if (cbnome.Text == "Selecione" && mtbhoras.Text == "" && tbmodalidade.Text == "" && tbtipo.Text == "")
            {
                Close();
            }
            else
            {
                if (MessageBox.Show("Os dados não salvos serão perdidos.\nDeseja mesmo retornar?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    Close();
            }
        }

        private void cbnome_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (carregou)
            {
                try
                {
                    Conexao conec = new Conexao();
                    SqlConnection conexao = new SqlConnection(conec.conexaoBD());
                    string sql = @"SELECT * FROM acg WHERE id=@id";
                    SqlCommand comando = new SqlCommand(sql, conexao);

                    comando.Parameters.AddWithValue("@id", cbnome.SelectedValue);

                    conexao.Open();
                    comando.CommandText = sql;
                    comando.ExecuteNonQuery();
                    SqlDataReader dados = comando.ExecuteReader();
                    if (dados.Read())
                    {
                        tbmodalidade.Text = dados["modalidade"].ToString();
                        tbtipo.Text = dados["tipo"].ToString();
                        mtbhoras.Text = dados["horas"].ToString();
                    }
                    conexao.Close();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btenviar_Click(object sender, EventArgs e)
        {//btenviar
            if (cbnome.Text == "Selecione" || mtbhoras.Text == "" || tbmodalidade.Text == "")
                MessageBox.Show("Preencha os campos vazios!", "Enviar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try
                {
                    Conexao conec = new Conexao();
                    SqlConnection conexao = new SqlConnection(conec.conexaoBD());
                    string sqlSelectMatricula = @"SELECT id FROM aluno WHERE matricula=@matricula";
                    SqlCommand comandoSelectMatricula = new SqlCommand(sqlSelectMatricula, conexao);

                    comandoSelectMatricula.Parameters.AddWithValue("@matricula", matriculaAtual);

                    conexao.Open();
                    comandoSelectMatricula.CommandText = sqlSelectMatricula;
                    comandoSelectMatricula.ExecuteNonQuery();
                    SqlDataReader dados = comandoSelectMatricula.ExecuteReader();
                    if (dados.Read())
                    {
                        int idaluno = (int)dados["id"];
                        conexao.Close();

                        string sqlSelectEnvioDuplicado = @"SELECT * FROM envio WHERE id_acg=@idacg AND id_aluno=@idaluno";
                        SqlCommand comandoSelectEnvioDuplicado = new SqlCommand(sqlSelectEnvioDuplicado, conexao);

                        comandoSelectEnvioDuplicado.Parameters.AddWithValue("@idacg", cbnome.SelectedValue);
                        comandoSelectEnvioDuplicado.Parameters.AddWithValue("@idaluno", idaluno);

                        conexao.Open();
                        comandoSelectEnvioDuplicado.CommandText = sqlSelectEnvioDuplicado;
                        comandoSelectEnvioDuplicado.ExecuteNonQuery();
                        SqlDataReader dados2 = comandoSelectEnvioDuplicado.ExecuteReader();
                        if (dados2.Read())
                            MessageBox.Show("ACG já enviada!\nEnvie uma nova ACG!", "Enviar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            conexao.Close();
                            string sqlInsert = @"INSERT INTO envio VALUES (@idacg, @idaluno)";
                            SqlCommand comandoInsert = new SqlCommand(sqlInsert, conexao);

                            comandoInsert.Parameters.AddWithValue("@idacg", cbnome.SelectedValue);
                            comandoInsert.Parameters.AddWithValue("@idaluno", idaluno);

                            conexao.Open();
                            comandoInsert.CommandText = sqlInsert;
                            comandoInsert.ExecuteNonQuery();
                            MessageBox.Show("Envio efetuado com sucesso!", "Enviar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            conexao.Close();
                        }
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
