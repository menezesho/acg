using projeto_acg.DAO;
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

namespace projeto_acg.View
{
    public partial class FormPrincipal : Form
    {
        string matriculaAtual = "";

        public FormPrincipal()
        {
            InitializeComponent();
        }

        public FormPrincipal(string matricula)
        {
            InitializeComponent();
            matriculaAtual = matricula;
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btenviaracg_Click(object sender, EventArgs e)
        {//btenviaracg
            FormEnviarAcg Feacg = new FormEnviarAcg(matriculaAtual);
            Feacg.ShowDialog();
        }

        private void btverificarsituacao_Click(object sender, EventArgs e)
        {//btverificarsituacao
            FormVerificar Fv = new FormVerificar(matriculaAtual);
            Fv.ShowDialog();
        }

        private void btcadastraracg_Click(object sender, EventArgs e)
        {//btcadastraracg
            FormCadAcg Fcacg = new FormCadAcg();
            Fcacg.ShowDialog();
        }

        private void bteditaracgs_Click(object sender, EventArgs e)
        {//bteditaracgs
            FormEditAcg Feacg = new FormEditAcg();
            Feacg.ShowDialog();
        }

        private void bteditaraluno_Click(object sender, EventArgs e)
        {//bteditaraluno
            FormEditAluno Fea = new FormEditAluno();
            Fea.ShowDialog();
        }

        private void lbsair_Click(object sender, EventArgs e)
        {//lbsair
            if (MessageBox.Show("Deseja mesmo sair do programa?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }

        private void FormPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btGerarRelatorio_Click(object sender, EventArgs e)
        {//btGerarRelatorio
            Conexao conec = new Conexao();

            if (MessageBox.Show("Deseja gerar um relatório de todos os cadastros?", "Relatório", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                SqlConnection conexao = new SqlConnection(conec.conexaoBD());
                string endereco = "C:\\Users\\henry\\OneDrive\\03. UEMG S.I\\Matérias\\Semestre 04\\Programação II\\projeto-acg\\Relatório\\relatorio-geral.csv";
                using (StreamWriter writer = new StreamWriter(endereco, false, Encoding.GetEncoding("iso-8859-15")))
                {
                    writer.WriteLine("ID;Nome;ID;Nome");
                    using (SqlConnection conn = new SqlConnection(conec.conexaoBD()))
                    {
                        string query = "SELECT * FROM ALUNO, ACG, ENVIO WHERE ALUNO.ID = ENVIO.ID_ALUNO AND ACG.ID = ENVIO.ID_ACG;";
                        SqlCommand sqlComand = new SqlCommand(query, conn);
                        conn.Open();
                        using (IDataReader reader = sqlComand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                writer.WriteLine(Convert.ToString(reader["idaluno"]) + ";" + Convert.ToString(reader["nomealuno"]) + ";" + Convert.ToString(reader["idacg"]) + ";" + Convert.ToString(reader["nomeacg"]));
                            }
                        }
                        conn.Close();
                    }
                }
                MessageBox.Show("Relatório gerado com sucesso!", "Gerar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
