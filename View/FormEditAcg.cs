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
using projeto_acg.Class;
using projeto_acg.DAO;

namespace projeto_acg
{
    public partial class FormEditAcg : Form
    {
        Conexao conec = new Conexao();
        AcgDAO acgDAO = new AcgDAO();

        public FormEditAcg()
        {
            InitializeComponent();
        }

        private void FormEditAcg_Load(object sender, EventArgs e)
        {
            mtbhoras.Mask = "";

            dgacg.DataSource = acgDAO.listarAcg();
            dgacg.Columns["ID"].Width = 40;
            dgacg.Columns["Nome"].Width = 240;
            dgacg.Columns["Modalidade"].Width = 200;
            dgacg.Columns["Tipo"].Width = 90;
            dgacg.Columns["Horas"].Width = 60;

            tbnome.Clear();
            mtbhoras.Clear();
            mtbhoras.Mask = "";
            cbmodalidade.SelectedIndex = 0;
            tbtipo.Clear();

            mtbhoras.Enabled = false;
            cbmodalidade.Enabled = false;
            tbtipo.Enabled = false;

            bteditar.Enabled = true;
            btsalvar.Enabled = false;

            bteditar.BackColor = Color.GhostWhite;
            bteditar.ForeColor = Color.SteelBlue;
            btsalvar.BackColor = Color.Gainsboro;
            btsalvar.ForeColor = Color.GhostWhite;
        }

        private void dgacg_CellClick(object sender, DataGridViewCellEventArgs e)
        {//cellclick datagrid
            tbid.Text = dgacg.CurrentRow.Cells[0].Value.ToString();
            tbnome.Text = dgacg.CurrentRow.Cells[1].Value.ToString();
            mtbhoras.Text = dgacg.CurrentRow.Cells[2].Value.ToString();
            cbmodalidade.Text = dgacg.CurrentRow.Cells[3].Value.ToString();
            tbtipo.Text = dgacg.CurrentRow.Cells[4].Value.ToString();

            cbmodalidade.Enabled = false;
            mtbhoras.Enabled = false;
            tbtipo.Enabled = false;

            bteditar.Enabled = true;
            btsalvar.Enabled = false;

            bteditar.BackColor = Color.GhostWhite;
            bteditar.ForeColor = Color.SteelBlue;
            btsalvar.BackColor = Color.Gainsboro;
            btsalvar.ForeColor = Color.GhostWhite;
        }

        private void bteditar_Click(object sender, EventArgs e)
        {//bteditar
            if (tbid.Text != "")
            {
                mtbhoras.Enabled = true;
                cbmodalidade.Enabled = true;
                tbtipo.Enabled = true;

                bteditar.Enabled = false;
                btsalvar.Enabled = true;

                bteditar.BackColor = Color.Gainsboro;
                bteditar.ForeColor = Color.GhostWhite;
                btsalvar.BackColor = Color.SteelBlue;
                btsalvar.ForeColor = Color.White;
            }
            else
                MessageBox.Show("Nenhum cadastro foi selecionado, tente novamente!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btexcluir_Click(object sender, EventArgs e)
        {//btexcluir
            if (tbid.Text != "")
            {
                if (MessageBox.Show("Deseja mesmo excluir este cadastro?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection conexao = new SqlConnection(conec.conexaoBD());
                        string sql = @"DELETE FROM acg WHERE id=@id";
                        SqlCommand comando = new SqlCommand(sql, conexao);

                        comando.Parameters.AddWithValue("@id", tbid.Text);

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

                    dgacg.DataSource = acgDAO.listarAcg();

                    tbnome.Clear();
                    mtbhoras.Clear();
                    mtbhoras.Mask = "";
                    cbmodalidade.SelectedIndex = 0;
                    tbtipo.Clear();

                    mtbhoras.Enabled = false;
                    cbmodalidade.Enabled = false;
                    tbtipo.Enabled = false;

                    bteditar.Enabled = true;
                    btsalvar.Enabled = false;

                    bteditar.BackColor = Color.GhostWhite;
                    bteditar.ForeColor = Color.SteelBlue;
                    btsalvar.BackColor = Color.Gainsboro;
                    btsalvar.ForeColor = Color.GhostWhite;
                    tabControl1.SelectedTab = tabPage1;
                }
            }
            else
                MessageBox.Show("Nenhum cadastro foi selecionado, tente novamente!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btcancelar_Click(object sender, EventArgs e)
        {//btcancelar

            mtbhoras.Enabled = false;
            cbmodalidade.Enabled = false;
            tbtipo.Enabled = false;

            bteditar.Enabled = true;
            btsalvar.Enabled = false;

            bteditar.BackColor = Color.GhostWhite;
            bteditar.ForeColor = Color.SteelBlue;
            btsalvar.BackColor = Color.Gainsboro;
            btsalvar.ForeColor = Color.GhostWhite;

            tabControl1.SelectedTab = tabPage1;
        }

        private void btsalvar_Click(object sender, EventArgs e)
        {//btsalvar
            if (tbnome.Text == "" || cbmodalidade.Text == "" || mtbhoras.Text == "" || tbtipo.Text == "")
                MessageBox.Show("Preencha os campos vazios!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try
                {
                    SqlConnection conexao = new SqlConnection(conec.conexaoBD());
                    string sql = @"UPDATE acg SET modalidade=@modalidade, tipo=@tipo, horas=@horas WHERE id=@id";
                    SqlCommand comando = new SqlCommand(sql, conexao);

                    comando.Parameters.AddWithValue("@modalidade", cbmodalidade.Text);
                    comando.Parameters.AddWithValue("@tipo", tbtipo.Text);
                    comando.Parameters.AddWithValue("@horas", mtbhoras.Text);
                    comando.Parameters.AddWithValue("@id", tbid.Text);

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

                dgacg.DataSource = acgDAO.listarAcg();

                tbid.Clear();
                tbnome.Clear();
                mtbhoras.Mask = "";
                cbmodalidade.SelectedIndex = 0;
                tbtipo.Clear();
                mtbhoras.Clear();

                cbmodalidade.Enabled = false;
                tbtipo.Enabled = false;
                mtbhoras.Enabled = false;

                bteditar.Enabled = true;
                btsalvar.Enabled = false;

                bteditar.BackColor = Color.GhostWhite;
                bteditar.ForeColor = Color.SteelBlue;
                btsalvar.BackColor = Color.Gainsboro;
                btsalvar.ForeColor = Color.GhostWhite;

                tabControl1.SelectedTab = tabPage1;
            }
        }

        private void lbsair_Click(object sender, EventArgs e)
        {//lbsair
            if (tbnome.Text == "" && cbmodalidade.SelectedIndex == 0 && mtbhoras.Text == "" && tbtipo.Text == "")
            {
                Close();
            }
            else
            {
                if (MessageBox.Show("Os dados não salvos serão perdidos.\nDeseja mesmo retornar?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    Close();
            }
        }

        private void lbbusca_Click(object sender, EventArgs e)
        {//lbbuscar

            SqlConnection conexao = new SqlConnection(conec.conexaoBD());
            string sql = @"SELECT id AS ID, nome as Nome, horas as Horas, modalidade as Modalidade, tipo as Tipo FROM acg WHERE nome LIKE @nome ORDER BY nome";
            SqlCommand comando = new SqlCommand(sql, conexao);

            comando.Parameters.AddWithValue("@nome", "%" + tbbusca.Text + "%");

            conexao.Open();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            DataSet tabela = new DataSet();
            da.Fill(tabela);
            dgacg.DataSource = tabela.Tables[0];
            conexao.Close();
        }

        private void btrelatorio_Click(object sender, EventArgs e)
        {//btrelatorio
            if (MessageBox.Show("Deseja gerar um relatório de todas as ACGs?", "Relatório", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                SqlConnection conexao = new SqlConnection(conec.conexaoBD());
                string endereco = "C:\\Users\\henry\\OneDrive\\03. UEMG S.I\\Matérias\\Semestre 04\\Programação II\\projeto-acg\\Relatório\\relatorio-acg.csv";
                using (StreamWriter writer = new StreamWriter(endereco, false, Encoding.GetEncoding("iso-8859-15")))
                {
                    writer.WriteLine("ID;Nome;Modalidade;Tipo;Horas");
                    using (SqlConnection conn = new SqlConnection(conec.conexaoBD()))
                    {
                        string query = "SELECT * FROM acg";
                        SqlCommand sqlComand = new SqlCommand(query, conn);
                        conn.Open();
                        using (IDataReader reader = sqlComand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                writer.WriteLine(Convert.ToString(reader["Id"]) + ";" + Convert.ToString(reader["Nome"]) + ";" + Convert.ToString(reader["Modalidade"]) + ";" + Convert.ToString(reader["Tipo"]) + ";" + Convert.ToString(reader["Horas"]));
                            }
                        }
                        conn.Close();
                    }
                }
                MessageBox.Show("Relatório gerado com sucesso!", "Gerar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #region Máscara

        private void mtbhoras_Enter(object sender, EventArgs e)
        {
            mtbhoras.Mask = "00";
        }

        private void mtbhoras_Leave(object sender, EventArgs e)
        {
            if (mtbhoras.Text == "")
                mtbhoras.Mask = "";
        }

        #endregion
    }
}
