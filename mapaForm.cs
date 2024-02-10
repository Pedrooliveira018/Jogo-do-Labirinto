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
    public partial class mapaForm : Form
    {
        public mapaForm()
        {
            InitializeComponent();
        }

        private void mapaForm_Load(object sender, EventArgs e)
        {

        }

        private void btncomecar_Click(object sender, EventArgs e)
        {
            funcaoform jogo = new funcaoform();

            this.Hide();

            jogo.Show();

            jogo.Closed += (object s, EventArgs ev) => this.Show();
        }
    }
}
