﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            tbnome.Clear();
            tbemail.Clear();
            mtbmatricula.Clear();
            tbsenha.Clear();
        }

        private void retornarToolStripMenuItem_Click(object sender, EventArgs e)
        {//strip >> retornar
            if (MessageBox.Show("Os dados não salvos serão perdidos. Deseja mesmo retornar?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Close();
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
            if (MessageBox.Show("Os dados não salvos serão perdidos.\nDeseja mesmo retornar para o menu principal?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Close();
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
                var matriculaValida = Funcoes.validarMatricula(mtbmatricula.Text);
                if (matriculaValida)
                {
                    Aluno alunos = new Aluno();

                    alunos.nome = tbnome.Text;
                    alunos.email = tbemail.Text;
                    alunos.matricula = mtbmatricula.Text;
                    alunos.senha = tbsenha.Text;

                    Funcoes funcoes = new Funcoes();

                    string matricula = mtbmatricula.Text;
                    funcoes.validarMatricula(matricula, alunos);
                    tabControl1.SelectedTab = tabPage1;
                }
                else
                    MessageBox.Show("Insira a matrícula corretamente!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
