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
    public partial class FormCadAluno : Form
    {
        Conexao conec = new Conexao();

        public FormCadAluno()
        {
            InitializeComponent();
        }

        private void FormCadAluno_Load(object sender, EventArgs e)
        {
            mtbmatricula.Mask = "";

            tbnome.Clear();
            tbemail.Clear();
            mtbmatricula.Clear();
            tbsenha.Clear();
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
            if (tbnome.Text == "" && tbemail.Text == "" && mtbmatricula.Text == "" && tbsenha.Text == "")
            {
                Close();
            }
            else
            {
                if (MessageBox.Show("Os dados não salvos serão perdidos.\nDeseja mesmo retornar para o menu principal?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    Close();
            }
        }

        private void btlimpar_Click(object sender, EventArgs e)
        {//btlimpar
            if (MessageBox.Show("Os dados não salvos serão perdidos.\nDeseja mesmo limpar todos os campos?", "Limpar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tbnome.Clear();
                tbemail.Clear();
                mtbmatricula.Clear();
                mtbmatricula.Mask = "";
                tbsenha.Clear();
            }
        }

        private void btsalvar_Click(object sender, EventArgs e)
        {//btsalvar
            if (tbnome.Text == "" || tbemail.Text == "" || mtbmatricula.Text == "_______" || tbsenha.Text == "")
                MessageBox.Show("Preencha os campos vazios!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                var matriculaValida = AlunoDAO.verificarMatricula(mtbmatricula.Text);
                if (matriculaValida)
                {
                    try
                    {
                        SqlConnection conexao = new SqlConnection(conec.conexaoBD());
                        string sqlSelect = @"SELECT * FROM aluno WHERE matricula=@matricula";
                        SqlCommand comandoSelect = new SqlCommand(sqlSelect, conexao);

                        comandoSelect.Parameters.AddWithValue("@matricula", mtbmatricula.Text);

                        conexao.Open();
                        SqlDataReader dados = comandoSelect.ExecuteReader();
                        if (dados.Read())
                        {
                            MessageBox.Show("Você já possui cadastro!\nRetorne e acesse com seu número de matrícula e senha!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            conexao.Close();
                        }
                        else
                        {
                            conexao.Close();
                            string sqlInsert = @"INSERT INTO aluno (nome, email, matricula, senha) VALUES (@nome, @email, @matricula, @senha)";
                            SqlCommand comandoInsert = new SqlCommand(sqlInsert, conexao);

                            comandoInsert.Parameters.AddWithValue("@nome", tbnome.Text);
                            comandoInsert.Parameters.AddWithValue("@email", tbemail.Text);
                            comandoInsert.Parameters.AddWithValue("@matricula", mtbmatricula.Text);
                            comandoInsert.Parameters.AddWithValue("@senha", tbsenha.Text);

                            conexao.Open();
                            comandoInsert.CommandText = sqlInsert;
                            comandoInsert.ExecuteNonQuery();
                            conexao.Close();
                            MessageBox.Show("Cadastro efetuado com sucesso!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Information); conexao.Close();
                            tabControl1.SelectedTab = tabPage1;
                        }
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("Insira a matrícula corretamente!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #region Máscara

        private void mtbmatricula_Enter(object sender, EventArgs e)
        {
            mtbmatricula.Mask = "00-00000";
        }

        private void mtbmatricula_Leave(object sender, EventArgs e)
        {
            if (mtbmatricula.Text == "")
                mtbmatricula.Mask = "";
        }

        #endregion
    }
}
