﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_acg
{
    public partial class FormEnviarAcg : Form
    {
        Funcoes funcoes = new Funcoes();
        public FormEnviarAcg()
        {
            InitializeComponent();
        }

        private void FormEnviarAcg_Load(object sender, EventArgs e)
        {
            
            cbnome.DataSource = funcoes.listarAcg();
            cbnome.DisplayMember = "Nome";
            cbnome.ValueMember = "id";
            cbnome.Text = "Selecione";
            tbmodalidade.Clear();
            tbtipo.Clear();
            mtbhoras.Clear();
        }

        private void btlimpar_Click(object sender, EventArgs e)
        {//btlimpar
            cbnome.Text = "Selecione";
            mtbhoras.Clear();
            tbmodalidade.Clear();
            tbtipo.Clear();
        }

        private void btcancelar_Click(object sender, EventArgs e)
        {//btcancelar
            if (MessageBox.Show("Os dados não salvos serão perdidos.\nDeseja mesmo retornar?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Close();
        }

        private void cbnome_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string strConexao = @"Data Source=lenovo-l340\sqlexpress;Initial Catalog=BD_ACG;Integrated Security=True";
                SqlConnection conexao = new SqlConnection(strConexao);
                string sql = @"SELECT * FROM acg WHERE nome=@nome";
                SqlCommand comando = new SqlCommand(sql, conexao);

                string nome = cbnome.Text;

                comando.Parameters.AddWithValue("@nome", nome);

                conexao.Open();
                comando.CommandText = sql;
                comando.ExecuteNonQuery();
                SqlDataReader dados = comando.ExecuteReader();
                if (dados.Read())
                {
                    tbmodalidade.Text = dados["modalidade"].ToString();
                    tbtipo.Text = dados["tipo"].ToString();
                    mtbhoras.Text = dados["horas"].ToString();
                }
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btenviar_Click(object sender, EventArgs e)
        {//btenviar
           
        }
    }
}