using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_acg
{
    public class Conexao
    {
        public string conexaoBD()
        {
            //string strConexao = @"    COLAR O CAMINHO DO BANCO (MATEUS)   ";
            string strConexao = @"Data Source=lenovo-l340\sqlexpress;Initial Catalog=BD_ACG;Integrated Security=True";
            return strConexao;
        }
    }
}
