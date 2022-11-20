using projeto_acg.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_acg
{
    public partial class FormVerificar : Form
    {
        int aux = 0, horas = 0, h = 36;
        string matriculaAtual = "";

        public FormVerificar()
        {
            InitializeComponent();
        }

        public FormVerificar(string matricula)
        {
            InitializeComponent();
            matriculaAtual = matricula;
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormVerificar_Load(object sender, EventArgs e)
        {
            try
            {
                Conexao conec = new Conexao();
                SqlConnection conexao = new SqlConnection(conec.conexaoBD());
                string sqlSelect1 = @"SELECT id, nome FROM aluno WHERE matricula=@matricula";
                SqlCommand comandoSelect1 = new SqlCommand(sqlSelect1, conexao);

                comandoSelect1.Parameters.AddWithValue("@matricula", matriculaAtual);

                conexao.Open();
                comandoSelect1.CommandText = sqlSelect1;
                comandoSelect1.ExecuteNonQuery();
                SqlDataReader dados1 = comandoSelect1.ExecuteReader();
                if (dados1.Read())
                {
                    int idaluno = (int)dados1["id"];
                    tbNome.Text = dados1["nome"].ToString();
                    conexao.Close();

                    string sqlSelect2 = @"SELECT SUM(HORAS) AS 'total' FROM ENVIO JOIN ACG ON ACG.ID = ENVIO.ID_ACG WHERE ENVIO.ID_ALUNO = @id";
                    SqlCommand comandoSelect2 = new SqlCommand(sqlSelect2, conexao);

                    comandoSelect2.Parameters.AddWithValue("@id", idaluno);

                    conexao.Open();
                    comandoSelect2.CommandText = sqlSelect2;
                    comandoSelect2.ExecuteNonQuery();
                    SqlDataReader dados2 = comandoSelect2.ExecuteReader();
                    if (dados2.Read())
                    {
                        horas = (int)dados2["total"];
                        tbhorastotais.Text = dados2["total"].ToString() + " Horas";
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

            aux = h - horas;
            tbhorasfaltantes.Text = aux.ToString() + " Horas";
            if (aux <= 0)
            {
                lbsituacao.Text = "Parabéns, você está apto com " + horas.ToString() + " horas enviadas!";
                tbhorasfaltantes.Text = "0 Horas";
                lbsituacao.ForeColor = Color.MediumSeaGreen;
            }
            else
            {
                lbsituacao.Text = "Infelizmente você está inapto com " + aux.ToString() + " horas faltantes!";
                lbsituacao.ForeColor = Color.Crimson;
            }
        }
    }
}
