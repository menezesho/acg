using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projeto_acg.Class;
using projeto_acg.DAO;

namespace projeto_acg
{
    public partial class FormEnviarAcg : Form
    {
        public FormEnviarAcg()
        {
            InitializeComponent();
        }

        private void FormEnviarAcg_Load(object sender, EventArgs e)
        {
            AcgDAO acgDAO = new AcgDAO();
            cbnome.DataSource = acgDAO.listarAcg();
            cbnome.DisplayMember = "Nome";
            cbnome.ValueMember = "id";
            cbnome.Text = "Selecione";
            tbmodalidade.Clear();
            tbtipo.Clear();
            mtbhoras.Clear();
        }

        private void btlimpar_Click(object sender, EventArgs e)
        {//btlimpar
            if (MessageBox.Show("Os dados não salvos serão perdidos.\nDeseja mesmo limpar todos os campos?", "Limpar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                cbnome.Text = "Selecione";
                mtbhoras.Clear();
                tbmodalidade.Clear();
                tbtipo.Clear();
            }
        }

        private void btcancelar_Click(object sender, EventArgs e)
        {//btcancelar
            if (cbnome.Text == "Selecione" && mtbhoras.Text == "" && tbmodalidade.Text == "" && tbtipo.Text == "")
            {
                Close();
            }
            else
            {
                if (MessageBox.Show("Os dados não salvos serão perdidos.\nDeseja mesmo retornar?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    Close();
            }
        }

        private void cbnome_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Conexao conec = new Conexao();
                SqlConnection conexao = new SqlConnection(conec.conexaoBD());
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
            if (cbnome.Text == "Selecione" || mtbhoras.Text == "" || tbmodalidade.Text == "")
                MessageBox.Show("Escolha uma ACG para enviar!", "Enviar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                
            }
        }
    }
}
