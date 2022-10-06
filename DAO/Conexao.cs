using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_acg.DAO
{
    public class Conexao
    {
        public string conexaoBD()
        {

          //  string strConexao = @"Data Source = LAPTOP-GE998OMN; Initial Catalog = BD_ACG; Integrated Security = True"; //Mateus
          string strConexao = @"Data Source=lenovo-l340\sqlexpress;Initial Catalog=BD_ACG;Integrated Security=True"; //Henrique
            return strConexao;
        }
    }
}
