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

        public FormVerificar()
        {
            InitializeComponent();
        }

        private void FormVerificar_Load(object sender, EventArgs e)
        {
            mtbmatricula.Clear();
            tbnome.Clear();
            tbhorastotais.Clear();
            tbhorasfaltantes.Clear();
            lbsituacao.Text = "";
        }

        private void btlimpar_Click(object sender, EventArgs e)
        {//btlimpar
            mtbmatricula.Clear();
            tbnome.Clear();
            tbhorastotais.Clear();
            tbhorasfaltantes.Clear();
            lbsituacao.Text = "";
        }

        private void btcancelar_Click(object sender, EventArgs e)
        {//btcancelar
            if (mtbmatricula.Text == "_______" && tbnome.Text == "" && tbhorastotais.Text == "" && tbhorasfaltantes.Text == "" && lbsituacao.Text == "")
            {
                Close();
            }
            else
            {
                if (MessageBox.Show("Os dados não salvos serão perdidos.\nDeseja mesmo retornar?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    Close();
            }
        }

        private void btverificar_Click(object sender, EventArgs e)
        {//btverificar
            if (mtbmatricula.Text == "_______" && tbnome.Text == "" && tbhorastotais.Text == "" && tbhorasfaltantes.Text == "" && lbsituacao.Text == "")
                MessageBox.Show("Preencha os campos vazios!", "Enviar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                var matriculaValida = AlunoDAO.verificarMatricula(mtbmatricula.Text);
                if (matriculaValida)
                {
                    try
                    {
                        Conexao conec = new Conexao();
                        SqlConnection conexao = new SqlConnection(conec.conexaoBD());
                        string sqlSelect1 = @"SELECT id, nome FROM aluno WHERE matricula=@matricula";
                        SqlCommand comandoSelect1 = new SqlCommand(sqlSelect1, conexao);

                        comandoSelect1.Parameters.AddWithValue("@matricula", mtbmatricula.Text);

                        conexao.Open();
                        comandoSelect1.CommandText = sqlSelect1;
                        comandoSelect1.ExecuteNonQuery();
                        SqlDataReader dados1 = comandoSelect1.ExecuteReader();
                        if (dados1.Read())
                        {
                            int idaluno = (int)dados1["id"];
                            tbnome.Text = dados1["nome"].ToString();
                            conexao.Close();

                            string sqlSelect2 = @"SELECT SUM(HORAS) AS 'total' FROM ENVIO JOIN ACG ON ACG.ID = ENVIO.FK_ACG WHERE ENVIO.FK_ALUNO = @id";
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
                }
                else
                    MessageBox.Show("Insira a mátrícula corretamente!", "Enviar", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
}
