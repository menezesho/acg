using projeto_acg.Class;
using projeto_acg.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace projeto_acg.DAO
{
    public class AlunoDAO
    {
        Conexao conec = new Conexao();

        public void validarMatricula(string matricula, Aluno alunos)
        {
            try
            {
                SqlConnection conexao = new SqlConnection(conec.conexaoBD());
                string sql = @"SELECT * FROM aluno WHERE matricula=@matricula";
                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@matricula", matricula);

                conexao.Open();
                SqlDataReader dados = comando.ExecuteReader();
                if (dados.Read())
                {
                    MessageBox.Show("Você já possui cadastro!\nRetorne e acesse com seu número de matrícula e senha!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conexao.Close();
                }
                else
                {
                    cadastrarAluno(alunos);
                    conexao.Close();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void cadastrarAluno(Aluno alunos)
        {
            try
            {
                SqlConnection conexao = new SqlConnection(conec.conexaoBD());
                string sql = @"INSERT INTO aluno (nome, email, matricula, senha) VALUES (@nome, @email, @matricula, @senha)";
                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@nome", alunos.nome);
                comando.Parameters.AddWithValue("@email", alunos.email);
                comando.Parameters.AddWithValue("@matricula", alunos.matricula);
                comando.Parameters.AddWithValue("@senha", alunos.senha);

                conexao.Open();
                comando.CommandText = sql;
                comando.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show("Cadastro efetuado com sucesso!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void editarAluno(Aluno alunos)
        {
            try
            {
                SqlConnection conexao = new SqlConnection(conec.conexaoBD());
                string sql = @"UPDATE aluno SET nome=@nome, email=@email, matricula=@matricula, senha=@senha WHERE id=@id";
                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@nome", alunos.nome);
                comando.Parameters.AddWithValue("@email", alunos.email);
                comando.Parameters.AddWithValue("@matricula", alunos.matricula);
                comando.Parameters.AddWithValue("@senha", alunos.senha);

                comando.Parameters.AddWithValue("@id", alunos.id);

                conexao.Open();
                comando.CommandText = sql;
                comando.ExecuteNonQuery();
                conexao.Close();

                MessageBox.Show("Cadastro alterado com sucesso!", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable listarAlunos()
        {
            SqlConnection conexao = new SqlConnection(conec.conexaoBD());
            string sql = @"SELECT id AS ID, nome AS Nome, email AS 'E-mail', matricula AS Matrícula, senha AS Senha  FROM aluno";
            SqlCommand comando = new SqlCommand(sql, conexao);
            conexao.Open();
            comando.ExecuteNonQuery();
            DataTable tabelaAlunos = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(tabelaAlunos);
            conexao.Close();
            return tabelaAlunos;
        }

        public void excluirAluno(Aluno alunos)
        {
            try
            {
                SqlConnection conexao = new SqlConnection(conec.conexaoBD());
                string sql = @"DELETE FROM aluno WHERE id=@id";
                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@id", alunos.id);

                conexao.Open();
                comando.CommandText = sql;
                comando.ExecuteNonQuery();
                conexao.Close();

                MessageBox.Show("Cadastro excluido com sucesso!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void verificarSituacao(string matricula)
        {
            try
            {
                Conexao conec = new Conexao();
                SqlConnection conexao = new SqlConnection(conec.conexaoBD());
                string sqlSelect1 = @"SELECT id FROM aluno WHERE matricula=@matricula";
                SqlCommand comandoSelect1 = new SqlCommand(sqlSelect1, conexao);

                comandoSelect1.Parameters.AddWithValue("@matricula", matricula);

                conexao.Open();
                comandoSelect1.CommandText = sqlSelect1;
                comandoSelect1.ExecuteNonQuery();
                SqlDataReader dados1 = comandoSelect1.ExecuteReader();
                if (dados1.Read())
                {
                    int idaluno = (int)dados1["id"];
                    conexao.Close();

                    string sqlSelect2 = @"SELECT SUM(HORAS) AS 'HORA TOTAL' FROM ENVIO JOIN ACG ON ACG.ID = ENVIO.FK_ACG WHERE ENVIO.FK_ALUNO = @id";
                    SqlCommand comandoSelect2 = new SqlCommand(sqlSelect2, conexao);

                    comandoSelect2.Parameters.AddWithValue("@id", idaluno);

                    conexao.Open();
                    comandoSelect2.CommandText = sqlSelect2;
                    comandoSelect2.ExecuteNonQuery();
                    SqlDataReader dados2 = comandoSelect2.ExecuteReader();
                    if (dados2.Read())
                    {
                        int horasTotais = (int)dados2["sum(horas)"];
                        conexao.Close();
                    }
                    else
                        MessageBox.Show("Matrícula não encontrada!\nInsira a mátrícula corretamente!", "Enviar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static bool verificarMatricula(string matricula)
        {
            var regExp = new Regex(@"^\d{7}"); //@"^\d{3}.\d{3}.\d{3}-\d{2}"
            return regExp.IsMatch(matricula);
        }
    }
}
