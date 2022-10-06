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
    public class Login
    {
        Conexao conec = new Conexao();
        public void realizarLogin(string matricula, string senha)
        {
            try
            {
                SqlConnection conexao = new SqlConnection(conec.conexaoBD());
                string sql = @"SELECT * FROM aluno WHERE matricula=@matricula AND senha=@senha";
                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@matricula", matricula);
                comando.Parameters.AddWithValue("@senha", senha);

                conexao.Open();
                SqlDataReader dados = comando.ExecuteReader();
                if (dados.Read())
                {
                    FormPrincipal Fp = new FormPrincipal();

                    Fp.btcadastraracg.Enabled = false;
                    Fp.bteditaracg.Enabled = false;
                    Fp.bteditaraluno.Enabled = false;
                    Fp.btcadastraracg.BackColor = Color.LightGray;
                    Fp.bteditaracg.BackColor = Color.LightGray;
                    Fp.bteditaraluno.BackColor = Color.LightGray;
                    Fp.btcadastraracg.ForeColor = Color.GhostWhite;
                    Fp.bteditaracg.ForeColor = Color.GhostWhite;
                    Fp.bteditaraluno.ForeColor = Color.GhostWhite;

                    MessageBox.Show("Login de aluno efetuado com sucesso!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Fp.ShowDialog();
                    conexao.Close();
                }
                else
                {
                    MessageBox.Show("Matrícula ou senha incorretos, tente novamente!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conexao.Close();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
