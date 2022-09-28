using System;
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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void todosToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void enviaracg_Click(object sender, EventArgs e)
        {//enviar ACG
            FormCadAcg Fca = new FormCadAcg();
            Fca.ShowDialog();
        }
    }
}
