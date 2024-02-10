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
    public partial class salaForm1 : Form
    {
        public salaForm1()
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
    }
}
