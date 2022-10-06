using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projeto_acg.Class;
using projeto_acg.DAO;

namespace projeto_acg
{
    public partial class FormEditAluno : Form
    {
        public FormEditAluno()
        {
            InitializeComponent();
        }

        private void FormEditAluno_Load(object sender, EventArgs e)
        {//load
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
            //btbuscar.Enabled = true;
            //tbbusca.Clear();
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
            //btbuscar.Enabled = true;
        }

        private void btbuscar_Click(object sender, EventArgs e)
        {//btbuscar
            /*
            string strConexao = @"Data Source=Lenovo-L340\sqlexpress;Initial Catalog=BD_ACADEMIA;Integrated Security=True";
            SqlConnection conexao = new SqlConnection(strConexao);
            string sql = @"SELECT matricula AS Matrícula, nome AS Nome, cpf AS CPF, idade AS Idade, endereco AS Endereço, celular AS Celular, email AS 'E-mail', peso AS 'Peso(kg)', altura AS 'Altura(cm)' FROM aluno WHERE nome LIKE @nome ORDER BY nome";
            SqlCommand comando = new SqlCommand(sql, conexao);

            comando.Parameters.AddWithValue("@nome", "%" + tbbusca.Text + "%");

            conexao.Open();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            DataSet tabela = new DataSet();
            da.Fill(tabela);
            dgalunos.DataSource = tabela.Tables[0];
            conexao.Close();
            */
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
                //btbuscar.Enabled = false;
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
            //btbuscar.Enabled = true;

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
                    //btbuscar.Enabled = true;
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
                //btbuscar.Enabled = true;
            }
        }

        private void lbsair_Click(object sender, EventArgs e)
        {//lbsair
            if (MessageBox.Show("Os dados não salvos serão perdidos.\nDeseja mesmo retornar?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Close();
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
    }
}
