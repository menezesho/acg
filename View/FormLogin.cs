using projeto_acg.View;
using System.Windows.Forms;

namespace projeto_acg
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btlogin_Click(object sender, EventArgs e)
        {//btlogin
            if (mtbmatricula.Text == "1234567" && tbsenha.Text == "1234567")
            {
                MessageBox.Show("Login de administrador efetuado com sucesso!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormPrincipal Fp = new FormPrincipal();

                Fp.btenviaracg.Enabled = false;
                Fp.btenviaracg.BackColor = Color.LightGray;
                Fp.btverificarsituacao.Enabled = false;
                Fp.btverificarsituacao.BackColor = Color.LightGray;

                Fp.ShowDialog();
            }
            else
            {
                string matricula, senha;

                matricula = mtbmatricula.Text;
                senha = tbsenha.Text;
                Funcoes funcoes = new Funcoes();
                funcoes.realizarLogin(matricula, senha);
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
                tbsenha.UseSystemPasswordChar =false;
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
    }
}