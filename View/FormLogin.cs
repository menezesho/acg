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
            if (mtbusuario.Text == "12-34567" && tbsenha.Text == "123456")
                    MessageBox.Show("Acesso como Administrador!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}