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

        public static bool verificarMatricula(string matricula)
        {
            var regExp = new Regex(@"^\d{7}"); //@"^\d{3}.\d{3}.\d{3}-\d{2}"
            return regExp.IsMatch(matricula);
        }
    }
}
