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
    public class AcgDAO
    {
        Conexao conec = new Conexao();

        public void cadastrarAcg(Acg acg)
        {
            try
            {
                SqlConnection conexao = new SqlConnection(conec.conexaoBD());
                string sql = @"INSERT INTO acg (nome, modalidade, tipo, horas) VALUES (@nome, @modalidade, @tipo, @horas)";
                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@nome", acg.nome);
                comando.Parameters.AddWithValue("@horas", acg.horas.ToString());
                comando.Parameters.AddWithValue("@modalidade", acg.modalidade);
                comando.Parameters.AddWithValue("@tipo", acg.tipo);

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

        public DataTable listarAcg()
        {
            SqlConnection conexao = new SqlConnection(conec.conexaoBD());
            string sql = @"SELECT id AS 'ID', nome AS 'Nome', horas AS 'Horas', modalidade AS 'Modalidade', tipo AS 'Tipo' FROM acg";
            SqlCommand comando = new SqlCommand(sql, conexao);

            conexao.Open();
            comando.ExecuteNonQuery();
            DataTable tabelaAcg = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(tabelaAcg);
            conexao.Close();

            return tabelaAcg;
        }

        public void enviarAcg(string nome, string matricula)
        {//EM ANDAMENTO
            try
            {
                Conexao conec = new Conexao();
                SqlConnection conexao = new SqlConnection(conec.conexaoBD());
                string sqlSelect1 = @"SELECT id FROM acg WHERE nome=@nome";
                SqlCommand comandoSelect1 = new SqlCommand(sqlSelect1, conexao);

                comandoSelect1.Parameters.AddWithValue("@nome", nome);

                conexao.Open();
                comandoSelect1.CommandText = sqlSelect1;
                comandoSelect1.ExecuteNonQuery();
                SqlDataReader dados1 = comandoSelect1.ExecuteReader();
                if (dados1.Read())
                {
                    int idacg = (int)dados1["id"];
                    conexao.Close();

                    string sqlSelect2 = @"SELECT id FROM aluno WHERE matricula=@matricula";
                    SqlCommand comandoSelect2 = new SqlCommand(sqlSelect2, conexao);
                    comandoSelect2.Parameters.AddWithValue("@matricula", matricula);
                    conexao.Open();
                    comandoSelect2.CommandText = sqlSelect2;
                    comandoSelect2.ExecuteNonQuery();
                    SqlDataReader dados2 = comandoSelect2.ExecuteReader();
                    if (dados2.Read())
                    {
                        int idaluno = (int)dados2["id"];
                        conexao.Close();

                        string sqlSelect3 = @"SELECT * FROM envio WHERE fk_acg=@idacg AND fk_aluno=@idaluno";
                        SqlCommand comandoSelect3 = new SqlCommand(sqlSelect3, conexao);
                        comandoSelect3.Parameters.AddWithValue("@idacg", idacg);
                        comandoSelect3.Parameters.AddWithValue("@idaluno", idaluno);
                        conexao.Open();
                        comandoSelect3.CommandText = sqlSelect3;
                        comandoSelect3.ExecuteNonQuery();
                        SqlDataReader dados3 = comandoSelect3.ExecuteReader();
                        if (dados3.Read())
                            MessageBox.Show("ACG já enviada!\nEnvie uma nova ACG!", "Enviar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            conexao.Close();
                            string sqlInsert = @"INSERT INTO envio VALUES (@idacg, @idaluno)";
                            SqlCommand comandoInsert = new SqlCommand(sqlInsert, conexao);
                            comandoInsert.Parameters.AddWithValue("@idacg", idacg);
                            comandoInsert.Parameters.AddWithValue("@idaluno", idaluno);
                            conexao.Open();
                            comandoInsert.CommandText = sqlInsert;
                            comandoInsert.ExecuteNonQuery();
                            MessageBox.Show("Envio efetuado com sucesso!", "Enviar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            conexao.Close();
                        }
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

        public void validarAcg(string nome, Acg acg)
        {
            try
            {
                SqlConnection conexao = new SqlConnection(conec.conexaoBD());
                string sql = @"SELECT * FROM acg WHERE nome=@nome";
                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@nome", nome);

                conexao.Open();
                SqlDataReader dados = comando.ExecuteReader();
                if (dados.Read())
                {
                    MessageBox.Show("ACG de mesmo nome já cadastrada!\nCadastre com um nome diferente ou adicione um complemento!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conexao.Close();
                }
                else
                {
                    cadastrarAcg(acg);
                    conexao.Close();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void excluirAcg(Acg acg, int id)
        {
            try
            {
                SqlConnection conexao = new SqlConnection(conec.conexaoBD());
                string sql = @"DELETE FROM acg WHERE id=@id";
                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@id", id);

                conexao.Open();
                comando.CommandText = sql;
                comando.ExecuteNonQuery();
                conexao.Close();

                MessageBox.Show("ACG excluida com sucesso!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void editarAcg(Acg acg, int id)
        {
            try
            {
                SqlConnection conexao = new SqlConnection(conec.conexaoBD());
                string sql = @"UPDATE acg SET modalidade=@modalidade, tipo=@tipo, horas=@horas WHERE id=@id";
                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@modalidade", acg.modalidade);
                comando.Parameters.AddWithValue("@tipo", acg.tipo);
                comando.Parameters.AddWithValue("@horas", acg.horas);
                comando.Parameters.AddWithValue("@id", id);

                conexao.Open();
                comando.CommandText = sql;
                comando.ExecuteNonQuery();
                conexao.Close();

                MessageBox.Show("Dados alterados com sucesso!", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
