using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Rock_Paper_Scissors
{
    public partial class frmRockPaperScissors : Form
    {

        int GameRounds = 0;

        public frmRockPaperScissors()
        {
            InitializeComponent();
        
        }

        
        private void btnStartGame_Click(object sender, EventArgs e)
        {
            Form frm2 = new frmGameForm(GameRounds);
            this.Hide();
            frm2.Show();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            GameRounds = (int)numericUpDown1.Value;
        }
    }
}
