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


namespace projeto_acg
{
    public class Funcoes
    {
        bool achouCpf = false;

        #region Aluno

        public void verificarMatricula(string matricula, Aluno alunos)
        {//ok
            try
            {
                string strConexao = @"Data Source=lenovo-l340\sqlexpress;Initial Catalog=BD_ACG;Integrated Security=True";
                SqlConnection conexao = new SqlConnection(strConexao);
                string sql = @"SELECT * FROM aluno WHERE matricula=@matricula";
                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@matricula", matricula);

                conexao.Open();
                SqlDataReader dados = comando.ExecuteReader();
                if (dados.Read())
                {
                    MessageBox.Show("Você já possui cadastro, retorne e acesse com seu número de matrícula e senha!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        {//ok
            try
            {
                string strConexao = @"Data Source=lenovo-l340\sqlexpress;Initial Catalog=BD_ACG;Integrated Security=True";
                SqlConnection conexao = new SqlConnection(strConexao);
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
        {//ok
            try
            {
                string strConexao = @"Data Source=lenovo-l340\sqlexpress;Initial Catalog=BD_ACG;Integrated Security=True";
                SqlConnection conexao = new SqlConnection(strConexao);
                string sql = @"UPDATE aluno SET nome=@nome, email=@email, matricula=@matricula WHERE id=@id";
                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@nome", alunos.nome);
                comando.Parameters.AddWithValue("@email", alunos.email);
                comando.Parameters.AddWithValue("@peso", alunos.matricula);
                comando.Parameters.AddWithValue("@altura", alunos.senha);

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
            string strConexao = @"Data Source=Lenovo-L340\sqlexpress;Initial Catalog=BD_ACADEMIA;Integrated Security=True";
            SqlConnection conexao = new SqlConnection(strConexao);
            string sql = @"SELECT matricula AS Matrícula, nome AS Nome, cpf AS CPF, idade AS Idade, endereco AS Endereço, celular AS Celular, email AS 'E-mail', peso AS 'Peso(kg)', altura AS 'Altura(cm)' FROM aluno";
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
                string strConexao = @"Data Source=Lenovo-L340\sqlexpress;Initial Catalog=BD_ACADEMIA;Integrated Security=True";
                SqlConnection conexao = new SqlConnection(strConexao);
                string sql = @"DELETE FROM aluno WHERE matricula=@matricula";
                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@matricula", alunos.matricula);

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

        #endregion


        #region Professor

        public void verificarCpfProfessor(string cpf, Professor profs)
        {
            try
            {
                string strConexao = @"Data Source=Lenovo-L340\sqlexpress;Initial Catalog=BD_ACADEMIA;Integrated Security=True";
                SqlConnection conexao = new SqlConnection(strConexao);
                string sql = @"SELECT * FROM professor WHERE cpf=@cpf";
                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@cpf", cpf);

                conexao.Open();
                SqlDataReader dados = comando.ExecuteReader();
                if (dados.Read())
                {
                    MessageBox.Show("CPF já cadastrado, tente novamente!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    achouCpf = true;
                    conexao.Close();
                }
                else
                {
                    cadastrarProf(profs);
                    conexao.Close();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void cadastrarProf(Professor profs)
        {
            try
            {
                string strConexao = @"Data Source=Lenovo-L340\sqlexpress;Initial Catalog=BD_ACADEMIA;Integrated Security=True";
                SqlConnection conexao = new SqlConnection(strConexao);
                string sql = @"INSERT INTO professor (nome, cpf, idade, endereco, celular, email, usuario, senha) VALUES (@nome, @cpf, @idade, @endereco, @celular, @email, @usuario, @senha)";
                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@nome", profs.nome);
                comando.Parameters.AddWithValue("@cpf", profs.cpf);
                comando.Parameters.AddWithValue("@idade", profs.idade.ToString());
                comando.Parameters.AddWithValue("@endereco", profs.endereco);
                comando.Parameters.AddWithValue("@celular", profs.celular);
                comando.Parameters.AddWithValue("@email", profs.email);
                comando.Parameters.AddWithValue("@usuario", profs.usuario);
                comando.Parameters.AddWithValue("@senha", profs.senha);

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

        public void editarProf(Professor profs)
        {
            try
            {
                string strConexao = @"Data Source=Lenovo-L340\sqlexpress;Initial Catalog=BD_ACADEMIA;Integrated Security=True";
                SqlConnection conexao = new SqlConnection(strConexao);
                string sql = @"UPDATE professor SET nome=@nome, cpf=@cpf, idade=@idade, endereco=@endereco, celular=@celular, email=@email, usuario=@usuario, senha=@senha WHERE cracha = @cracha";
                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@nome", profs.nome);
                comando.Parameters.AddWithValue("@cpf", profs.cpf.ToString());
                comando.Parameters.AddWithValue("@idade", profs.idade.ToString());
                comando.Parameters.AddWithValue("@endereco", profs.endereco);
                comando.Parameters.AddWithValue("@celular", profs.celular);
                comando.Parameters.AddWithValue("@email", profs.email);
                comando.Parameters.AddWithValue("@usuario", profs.usuario);
                comando.Parameters.AddWithValue("@senha", profs.senha);

                comando.Parameters.AddWithValue("@cracha", profs.cracha);

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

        public void verificarCpfEditProf(string cpf, Professor profs)
        {
            try
            {
                string strConexao = @"Data Source=Lenovo-L340\sqlexpress;Initial Catalog=BD_ACADEMIA;Integrated Security=True";
                SqlConnection conexao = new SqlConnection(strConexao);
                string sql = @"SELECT * FROM professor WHERE cpf=@cpf";
                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@cpf", cpf);

                conexao.Open();
                SqlDataReader dados = comando.ExecuteReader();
                if (dados.Read())
                {
                    MessageBox.Show("CPF já cadastrado, tente novamente!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    achouCpf = true;
                    conexao.Close();
                }
                else
                {
                    editarProf(profs);
                    conexao.Close();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable listarProfs()
        {
            string strConexao = @"Data Source=Lenovo-L340\sqlexpress;Initial Catalog=BD_ACADEMIA;Integrated Security=True";
            SqlConnection conexao = new SqlConnection(strConexao);
            string sql = @"SELECT cracha AS Crachá, nome AS Nome, cpf AS CPF, idade AS Idade, endereco AS Endereço, celular AS Celular, email AS 'E-mail', usuario AS Usuário, senha AS Senha FROM professor";
            SqlCommand comando = new SqlCommand(sql, conexao);
            conexao.Open();
            comando.ExecuteNonQuery();
            DataTable tabelaProfs = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(tabelaProfs);
            conexao.Close();
            return tabelaProfs;
        }

        public void excluirProf(Professor profs)
        {
            try
            {
                string strConexao = @"Data Source=Lenovo-L340\sqlexpress;Initial Catalog=BD_ACADEMIA;Integrated Security=True";
                SqlConnection conexao = new SqlConnection(strConexao);
                string sql = @"DELETE FROM professor WHERE cracha = @cracha";
                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@cracha", profs.cracha);

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

        #endregion

        #region Validação de CPF e Telefone

        public static bool validarCpf(string cpf)
        {
            var regExp = new Regex(@"^\d{11}"); //@"^\d{3}.\d{3}.\d{3}-\d{2}"
            return regExp.IsMatch(cpf);
        }

        public static bool validarCelular(string celular)
        {
            var regExp = new Regex(@"^\d{11}"); //@"^\d{3}.\d{3}.\d{3}-\d{2}"
            return regExp.IsMatch(celular);
        }

        #endregion

        #region Login

        public void loginProf(string usuario, string senha)
        {
            try
            {
                string strConexao = @"Data Source=Lenovo-L340\sqlexpress;Initial Catalog=BD_ACADEMIA;Integrated Security=True";
                SqlConnection conexao = new SqlConnection(strConexao);
                string sql = @"SELECT * FROM professor WHERE usuario=@usuario AND senha=@senha";
                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@senha", senha);

                conexao.Open();
                SqlDataReader dados = comando.ExecuteReader();
                if (dados.Read())
                {
                    FormPrincipal Fp = new FormPrincipal();
                    Fp.ShowDialog();
                    conexao.Close();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos, tente novamente!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conexao.Close();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}
