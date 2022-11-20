using projeto_acg.DAO;
using projeto_acg.View;
using System.Data.SqlClient;
using System.Security.Policy;
using System.Windows.Forms;

namespace projeto_acg
{
    public partial class FormLogin : Form
    {
        Conexao conec = new Conexao();
        public string matriculaAtual = "";

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            mtbmatricula.Mask = "";
        }

        private void btlogin_Click(object sender, EventArgs e)
        {//btlogin
            if (mtbmatricula.Text == "1234567" && tbsenha.Text == "123")
            {
                MessageBox.Show("Login de administrador efetuado com sucesso!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormPrincipal Fp = new FormPrincipal();
                matriculaAtual = mtbmatricula.Text;
                Fp.btenviaracg.Enabled = false;
                Fp.btverificarsituacao.Enabled = false;
                Fp.btenviaracg.BackColor = Color.LightGray;
                Fp.btverificarsituacao.BackColor = Color.LightGray;
                Fp.btenviaracg.ForeColor = Color.GhostWhite;
                Fp.btverificarsituacao.ForeColor = Color.GhostWhite;
                this.Hide();
                Fp.ShowDialog();
            }
            else
            {
                try
                {
                    SqlConnection conexao = new SqlConnection(conec.conexaoBD());
                    string sql = @"SELECT * FROM aluno WHERE matricula=@matricula AND senha=@senha";
                    SqlCommand comando = new SqlCommand(sql, conexao);

                    comando.Parameters.AddWithValue("@matricula", mtbmatricula.Text);
                    comando.Parameters.AddWithValue("@senha", tbsenha.Text);

                    conexao.Open();
                    SqlDataReader dados = comando.ExecuteReader();
                    if (dados.Read())
                    {
                        FormPrincipal Fp = new FormPrincipal(mtbmatricula.Text);

                        Fp.btcadastraracg.Enabled = false;
                        Fp.bteditaracg.Enabled = false;
                        Fp.bteditaraluno.Enabled = false;
                        Fp.btcadastraracg.BackColor = Color.LightGray;
                        Fp.bteditaracg.BackColor = Color.LightGray;
                        Fp.bteditaraluno.BackColor = Color.LightGray;
                        Fp.btcadastraracg.ForeColor = Color.GhostWhite;
                        Fp.bteditaracg.ForeColor = Color.GhostWhite;
                        Fp.bteditaraluno.ForeColor = Color.GhostWhite;

                        MessageBox.Show("Login de aluno efetuado com sucesso!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conexao.Close();
                        this.Hide();
                        Fp.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Matrícula ou senha incorretos, tente novamente!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        mtbmatricula.Focus();
                        conexao.Close();
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btprimeiroacesso_Click(object sender, EventArgs e)
        {//btprimeiroacesso
            FormCadAluno Fca = new FormCadAluno();
            Fca.ShowDialog();
        }

        private void btversenha_Click(object sender, EventArgs e)
        {//btversenha
            if (tbsenha.UseSystemPasswordChar.Equals(true))
                tbsenha.UseSystemPasswordChar =     false;
            else
                tbsenha.UseSystemPasswordChar = true;
        }

        private void btsair_Click(object sender, EventArgs e)
        {//btsair
            if (MessageBox.Show("Deseja mesmo sair do programa?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
            //padrão de confirmação de saída 
        }

        private void lbcadastrese_Click(object sender, EventArgs e)
        {//lbcadastrese (primeiro acesso)
            FormCadAluno Fca = new FormCadAluno();
            Fca.ShowDialog();
        }

        #region Máscara

        private void mtbmatricula_Enter(object sender, EventArgs e)
        {
            mtbmatricula.Mask = "00-00000";
        }

        private void mtbmatricula_Leave(object sender, EventArgs e)
        {
            if(mtbmatricula.Text == "")
                mtbmatricula.Mask = "";
        }

        private void tbsenha_TextChanged(object sender, EventArgs e)
        {
            if (tbsenha.Text != "")
            {
                btlogin.Enabled = true;
                btlogin.BackColor = Color.SteelBlue;
            }
            else
            {
                btlogin.Enabled = false;
                btlogin.BackColor = Color.LightGray;
            }
        }

        #endregion

    }
}