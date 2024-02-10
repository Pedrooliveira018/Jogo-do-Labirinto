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
    public partial class funcaoform : Form
    {
        public funcaoform()
        {
            InitializeComponent();
        
        }
        private void btndireita_Click(object sender, EventArgs e)
        {
            sala2Form funcao = new sala2Form();

            this.Hide();

            funcao.Show();

            funcao.Closed += (object s, EventArgs ev) => this.Show();
        }

        private void btncima_Click(object sender, EventArgs e)
        {
            numero1Form funcao = new numero1Form();

            this.Hide();

            funcao.Show();

            funcao.Closed += (object s, EventArgs ev) => this.Show();
        }

        private void btnesquerda_Click(object sender, EventArgs e)
        {
            numero4Form funcao = new numero4Form();

            this.Hide();

            funcao.Show();

            funcao.Closed += (object s, EventArgs ev) => this.Show();
        }

        private void btnbaixo_Click(object sender, EventArgs e)
        {
            numero3Form1 funcao = new numero3Form1();

            this.Hide();

            funcao.Show();

            funcao.Closed += (object s, EventArgs ev) => this.Show();
        }
    }
}
