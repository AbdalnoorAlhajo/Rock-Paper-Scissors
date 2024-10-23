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
    public partial class frmResult : Form
    {
        int ComputerWin = 0, PlayerWin = 0, Draw = 0;

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            Form frm4 = new frmRockPaperScissors();
            this.Hide();
            frm4.Show();
        }

        public frmResult(int HowManyComputerWin, int HowManyPlayerWin, int HowManyDraw)
        {
            InitializeComponent();
            ComputerWin = HowManyComputerWin;
            PlayerWin = HowManyPlayerWin;
            Draw = HowManyDraw;
        }

        private void frmResult_Load(object sender, EventArgs e)
        {
            lbRounds.Text += (ComputerWin + PlayerWin + Draw).ToString();
            lbComputerWin.Text += ComputerWin.ToString();
            lbPlayerWin.Text += PlayerWin.ToString();
            lbDraw.Text += Draw.ToString();
        }
    }
}
