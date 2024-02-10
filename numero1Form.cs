using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_do_Labirinto
{
    public partial class numero1Form : Form
    {
        public numero1Form()
        {
            InitializeComponent();
        }

        private void btndireita_Click(object sender, EventArgs e)
        {

        }

        private void btnbaixo_Click(object sender, EventArgs e)
        {

        }

        private void btncima_Click(object sender, EventArgs e)
        {

        }

        private void btnesquerda_Click(object sender, EventArgs e)
        {
            numero4_2form funcao = new numero4_2form();

            this.Hide();

            funcao.Show();

            funcao.Closed += (object s, EventArgs ev) => this.Show();
        }
    }
}
