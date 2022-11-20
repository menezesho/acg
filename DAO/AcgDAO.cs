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
    }
}
