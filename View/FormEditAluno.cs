using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projeto_acg.Class;
using projeto_acg.DAO;

namespace projeto_acg
{
    public partial class FormEditAluno : Form
    {
        Conexao conec = new Conexao();

        public FormEditAluno()
        {
            InitializeComponent();
        }

        private void FormEditAluno_Load(object sender, EventArgs e)
        {
            mtbmatricula.Mask = "";

            AlunoDAO alunoDAO = new AlunoDAO();
            dgalunos.DataSource = alunoDAO.listarAlunos();
            dgalunos.Columns["ID"].Width = 40;
            dgalunos.Columns["Nome"].Width = 230;
            dgalunos.Columns["E-mail"].Width = 270;
            dgalunos.Columns["Matrícula"].Width = 90;
            dgalunos.Columns["Senha"].Visible = false;

            tbid.Clear();
            tbnome.Clear();
            tbemail.Clear();
            mtbmatricula.Clear();
            tbsenha.Clear();
               
            tbnome.Enabled = false;
            tbemail.Enabled = false;
            mtbmatricula.Enabled = false;
            
            bteditar.Enabled = true;
            btcancelar.Enabled = false;
            btsalvar.Enabled = false;

            bteditar.BackColor = Color.GhostWhite;
            bteditar.ForeColor = Color.SteelBlue;
            btcancelar.BackColor = Color.Gainsboro;
            btcancelar.ForeColor = Color.GhostWhite;
            btsalvar.BackColor = Color.Gainsboro;
            btsalvar.ForeColor = Color.GhostWhite;
        }

        public void dgalunos_CellClick(object sender, DataGridViewCellEventArgs e)
        {//cellclick datagrid
            tbid.Text = dgalunos.CurrentRow.Cells[0].Value.ToString();
            tbnome.Text = dgalunos.CurrentRow.Cells[1].Value.ToString();
            tbemail.Text = dgalunos.CurrentRow.Cells[2].Value.ToString();
            mtbmatricula.Text = dgalunos.CurrentRow.Cells[3].Value.ToString();
            tbsenha.Text = dgalunos.CurrentRow.Cells[4].Value.ToString();

            tbnome.Enabled = false;
            tbemail.Enabled = false;
            mtbmatricula.Enabled = false;
            tbsenha.Enabled = false;
            
            bteditar.Enabled = true;
            btcancelar.Enabled = false;
            btsalvar.Enabled = false;

            bteditar.BackColor = Color.GhostWhite;
            bteditar.ForeColor = Color.SteelBlue;
            btcancelar.BackColor = Color.Gainsboro;
            btcancelar.ForeColor = Color.GhostWhite;
            btsalvar.BackColor = Color.Gainsboro;
            btsalvar.ForeColor = Color.GhostWhite;
        }

        private void bteditar_Click_1(object sender, EventArgs e)
        {//bteditar
            if (tbid.Text != "")
            {
                tbnome.Enabled = true;
                tbemail.Enabled = true;
                tbsenha.Enabled = true;
                
                bteditar.Enabled = false;
                btcancelar.Enabled = true;
                btsalvar.Enabled = true;

                bteditar.BackColor = Color.Gainsboro;
                bteditar.ForeColor = Color.GhostWhite;
                btcancelar.BackColor = Color.GhostWhite;
                btcancelar.ForeColor = Color.SteelBlue;
                btsalvar.BackColor = Color.SteelBlue;
                btsalvar.ForeColor = Color.White;
            }
            else
                MessageBox.Show("Nenhum cadastro foi selecionado, tente novamente!", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btcancelar_Click_1(object sender, EventArgs e)
        {//btcancelar
            tbnome.Enabled = false;
            tbemail.Enabled = false;
            mtbmatricula.Enabled = false;
            tbsenha.Enabled = false;

            bteditar.Enabled = true;
            btcancelar.Enabled = false;
            btsalvar.Enabled = false;

            bteditar.BackColor = Color.GhostWhite;
            bteditar.ForeColor = Color.SteelBlue;
            btcancelar.BackColor = Color.Gainsboro;
            btcancelar.ForeColor = Color.GhostWhite;
            btsalvar.BackColor = Color.Gainsboro;
            btsalvar.ForeColor = Color.GhostWhite;

            tabControl1.SelectedTab = tabPage1;

            tbid.Text = dgalunos.CurrentRow.Cells[0].Value.ToString();
            tbnome.Text = dgalunos.CurrentRow.Cells[1].Value.ToString();
            tbemail.Text = dgalunos.CurrentRow.Cells[2].Value.ToString();
            mtbmatricula.Text = dgalunos.CurrentRow.Cells[3].Value.ToString();
            tbsenha.Text = dgalunos.CurrentRow.Cells[4].Value.ToString();
        }

        private void btexcluir_Click(object sender, EventArgs e)
        {//btexcluir
            if (tbid.Text != "")
            {
                if (MessageBox.Show("Deseja mesmo excluir este cadastro?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Aluno alunos = new Aluno();
                    alunos.id = int.Parse(tbid.Text);

                    AlunoDAO alunoDAO = new AlunoDAO();
                    alunoDAO.excluirAluno(alunos);
                    dgalunos.DataSource = alunoDAO.listarAlunos();

                    tbid.Clear();
                    tbnome.Clear();
                    tbemail.Clear();
                    mtbmatricula.Clear();
                    tbsenha.Clear();

                    tbnome.Enabled = false;
                    tbemail.Enabled = false;
                    mtbmatricula.Enabled = false;
                    tbsenha.Enabled = false;

                    bteditar.Enabled = true;
                    btsalvar.Enabled = false;
                    btcancelar.Enabled = false;

                    bteditar.BackColor = Color.GhostWhite;
                    bteditar.ForeColor = Color.SteelBlue;
                    btcancelar.BackColor = Color.Gainsboro;
                    btcancelar.ForeColor = Color.GhostWhite;
                    btsalvar.BackColor = Color.Gainsboro;
                    btsalvar.ForeColor = Color.GhostWhite;

                    tabControl1.SelectedTab = tabPage1;
                }
            }
            else
                MessageBox.Show("Nenhum cadastro foi selecionado, tente novamente!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btsalvar_Click(object sender, EventArgs e)
        {//btsalvar
            if (tbnome.Text == "" || tbemail.Text == "" || mtbmatricula.Text == "_______" || tbsenha.Text == "")
                MessageBox.Show("Preencha os campos vazios!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                var matriculaValida = AlunoDAO.verificarMatricula(mtbmatricula.Text);
                if (matriculaValida)
                {
                    Aluno alunos = new Aluno();

                    alunos.id = int.Parse(tbid.Text);
                    alunos.nome = tbnome.Text;
                    alunos.email = tbemail.Text;
                    alunos.matricula = mtbmatricula.Text;
                    alunos.senha = tbsenha.Text;

                    AlunoDAO alunoDAO = new AlunoDAO();
                    alunoDAO.editarAluno(alunos);
                    dgalunos.DataSource = alunoDAO.listarAlunos();

                    tabControl1.SelectedTab = tabPage1;
                }
                else
                    MessageBox.Show("Insira a mátrícula corretamente!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                tbid.Clear();
                tbnome.Clear();
                tbemail.Clear();
                mtbmatricula.Clear();
                tbsenha.Clear();
                tbemail.Clear();

                tbnome.Enabled = false;
                tbemail.Enabled = false;
                mtbmatricula.Enabled = false;
                tbsenha.Enabled = false;

                bteditar.Enabled = true;
                btcancelar.Enabled = false;
                btsalvar.Enabled = false;

                bteditar.BackColor = Color.GhostWhite;
                bteditar.ForeColor = Color.SteelBlue;
                btcancelar.BackColor = Color.Gainsboro;
                btcancelar.ForeColor = Color.GhostWhite;
                btsalvar.BackColor = Color.Gainsboro;
                btsalvar.ForeColor = Color.GhostWhite;

                tabControl1.SelectedTab = tabPage1;
            }
        }

        private void lbsair_Click(object sender, EventArgs e)
        {//lbsair

            if (tbnome.Text == "" || tbemail.Text == "" || mtbmatricula.Text == "_______" || tbsenha.Text == "")
            {
                Close();
            }
            else
            {
                if (MessageBox.Show("Os dados não salvos serão perdidos.\nDeseja mesmo retornar?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    Close();
            }
        }

        #region Máscara

        private void mtbmatricula_Enter(object sender, EventArgs e)
        {
            mtbmatricula.Mask = "00-00000";
        }

        private void mtbmatricula_Leave(object sender, EventArgs e)
        {
            if (mtbmatricula.Text == "")
                mtbmatricula.Mask = "";
        }

        #endregion

        private void tbbusca_TextChanged(object sender, EventArgs e)
        {//lbbuscar

            SqlConnection conexao = new SqlConnection(conec.conexaoBD());
            string sql = @"SELECT id AS ID, nome as Nome, email as 'E-mail', matricula as Matrícula, senha as Senha FROM aluno WHERE nome LIKE @nome ORDER BY nome";
            SqlCommand comando = new SqlCommand(sql, conexao);

            comando.Parameters.AddWithValue("@nome", "%" + tbbusca.Text + "%");

            conexao.Open();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            DataSet tabela = new DataSet();
            da.Fill(tabela);
            dgalunos.DataSource = tabela.Tables[0];
            conexao.Close();

        }

        private void btRelatorio_Click(object sender, EventArgs e)
        {//btRelatorio
            SqlConnection conexao = new SqlConnection(conec.conexaoBD());

            string endereco = "C:\\Users\\henry\\OneDrive\\03. UEMG S.I\\Matérias\\Semestre 04\\Programação II\\projeto-acg\\Relatório\\relatorio-cadastros.csv";

            using (StreamWriter writer = new StreamWriter(endereco, false, Encoding.GetEncoding("iso-8859-15")))
            {
                writer.WriteLine("ID;Nome;E-mail;Matrícula");

                using (SqlConnection conn = new SqlConnection(conec.conexaoBD()))
                {
                    string query = "SELECT * FROM aluno";

                    SqlCommand sqlComand = new SqlCommand(query, conn);

                    conn.Open();


                    using (IDataReader reader = sqlComand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            writer.WriteLine(Convert.ToString(reader["Id"]) + ";" + Convert.ToString(reader["Nome"]) + ";" + Convert.ToString(reader["email"]) + ";" + Convert.ToString(reader["matricula"]));
                        }
                    }
                    conn.Close();
                }
            }
            MessageBox.Show("Relatório gerado com sucesso!", "Gerar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
