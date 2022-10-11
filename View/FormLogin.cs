using projeto_acg.DAO;
using projeto_acg.View;
using System.Windows.Forms;

namespace projeto_acg
{
    public partial class FormLogin : Form
    {
        public string matriculaAtual = "";

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            btlogin.Enabled = false;
            btlogin.BackColor = Color.LightGray;

            mtbmatricula.Mask = "";
        }

        private void btlogin_Click(object sender, EventArgs e)
        {//btlogin
            if (mtbmatricula.Text == "1234567" && tbsenha.Text == "123")
            {
                MessageBox.Show("Login de administrador efetuado com sucesso!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormPrincipal Fp = new FormPrincipal();

                Fp.btenviaracg.Enabled = false;
                Fp.btenviaracg.BackColor = Color.LightGray;
                Fp.btverificarsituacao.Enabled = false;
                Fp.btverificarsituacao.BackColor = Color.LightGray;
                matriculaAtual = mtbmatricula.Text;
                Fp.ShowDialog();
            }
            else
            {
                string matricula, senha;

                matricula = mtbmatricula.Text;
                senha = tbsenha.Text;
                LoginDAO loginDAO = new LoginDAO();
                matriculaAtual = mtbmatricula.Text;
                loginDAO.realizarLogin(matricula, senha);
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
            //padr�o de confirma��o de sa�da 
        }

        private void lbcadastrese_Click(object sender, EventArgs e)
        {//lbcadastrese (primeiro acesso)
            FormCadAluno Fca = new FormCadAluno();
            Fca.ShowDialog();
        }

        #region M�scara

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