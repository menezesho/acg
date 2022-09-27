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
        {
            if (mtbUsuario.Text == "12-34567" && tbsenha.Text == "123456")
                    MessageBox.Show("Acesso como Administrador!", "Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btsair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deseja mesmo sair do programa!", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            Application.Exit();
        }

        private void btprimeiroacesso_Click(object sender, EventArgs e)
        {
            
        }
    }
}