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

namespace projeto_acg.View
{
    public partial class FormCadAluno : Form
    {
        public FormCadAluno()
        {
            InitializeComponent();
        }

        private void FormCadAluno_Load(object sender, EventArgs e)
        {
            mtbmatricula.Mask = "";

            tbnome.Clear();
            tbemail.Clear();
            mtbmatricula.Clear();
            tbsenha.Clear();
        }

        private void btversenha_Click(object sender, EventArgs e)
        {//btversenha
            if (tbsenha.UseSystemPasswordChar.Equals(true))
                tbsenha.UseSystemPasswordChar = false;
            else
                tbsenha.UseSystemPasswordChar = true;
        }

        private void btcancelar_Click(object sender, EventArgs e)
        {//btcancelar
            if (tbnome.Text == "" || tbemail.Text == "" || mtbmatricula.Text == "_______" || tbsenha.Text == "")
            {
                Close();
            }
            else
            {
                if (MessageBox.Show("Os dados não salvos serão perdidos.\nDeseja mesmo retornar para o menu principal?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    Close();
            }
        }

        private void btlimpar_Click(object sender, EventArgs e)
        {//btlimpar
            tbnome.Clear();
            tbemail.Clear();
            mtbmatricula.Clear();
            tbsenha.Clear();
            MessageBox.Show("Todos os campos foram limpos!", "Limpar", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                    alunos.nome = tbnome.Text;
                    alunos.email = tbemail.Text;
                    alunos.matricula = mtbmatricula.Text;
                    alunos.senha = tbsenha.Text;

                    AlunoDAO alunoDAO = new AlunoDAO();

                    string matricula = mtbmatricula.Text;
                    alunoDAO.validarMatricula(matricula, alunos);
                    tabControl1.SelectedTab = tabPage1;
                }
                else
                    MessageBox.Show("Insira a matrícula corretamente!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
    }
}
