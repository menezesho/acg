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
            mtbmatricula.Mask = "";
        }

        private void btlogin_Click(object sender, EventArgs e)
        {//btlogin
            if (mtbmatricula.Text == "1234567" && tbsenha.Text == "1234567")
            {
                MessageBox.Show("Login de administrador efetuado com sucesso!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormPrincipal Fp = new FormPrincipal();

                //Fp.btenviaracg.Enabled = false;
                //Fp.btenviaracg.BackColor = Color.LightGray;
                //Fp.btverificarsituacao.Enabled = false;
                //Fp.btverificarsituacao.BackColor = Color.LightGray;

                Fp.btenviaracg.Visible = false;
                Fp.btverificarsituacao.Visible = false;
                Fp.btcadastraracg.Location = new Point(42, 104);
                Fp.btlistaracgs.Location = new Point(42, 159);
                Fp.bteditaracgs.Location = new Point(42, 214);
                Fp.bteditaraluno.Location = new Point(42, 269);
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

        private void btreload_Click(object sender, EventArgs e)
        {//btreload
            mtbmatricula.Clear();
            tbsenha.Clear();
        }

        private void btsair_Click(object sender, EventArgs e)
        {//btsair
            if (MessageBox.Show("Deseja mesmo sair do programa?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
            //padrão de confirmação de saída 
        }

        #region Mask Matrícula
        private void mtbmatricula_Click(object sender, EventArgs e)
        {
            mtbmatricula.Mask = "00-00000";
        }


        private void mtbmatricula_Leave(object sender, EventArgs e)
        {
            if (mtbmatricula.Text == "  -")
                mtbmatricula.Mask = "";
        }

        #endregion
    }
}