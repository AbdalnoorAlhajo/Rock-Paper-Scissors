using _Rock_Paper_Scissors.Properties;
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
    public partial class frmGameForm : Form
    {
        int GameRounds = 0, ComputerWin = 0, PlayerWin = 0, Draw = 0;

        public frmGameForm(int HowManyRounds)
        {
            InitializeComponent();
            GameRounds = HowManyRounds;
        }

        void ComputerChoice()
        {
            Random rnd = new Random();
            int Number = rnd.Next(1, 4);  // creates a number between 1 and 12

            if (Number == 1)
            {
                pictureBox3.Image=  Resources.Rock;
                pictureBox3.Tag = "Rock";
            }
            else if (Number == 2)
            {
                pictureBox3.Image = Resources.Paper;
                pictureBox3.Tag = "Paper";
            }
            else
            {
                pictureBox3.Image = Resources.Scissors;
                pictureBox3.Tag = "Scissors";
            }
        }

        void CheckWinner()
        {
            if((pictureBox1.Tag.ToString() == "Rock" && pictureBox3.Tag.ToString() == "Scissors")
                || (pictureBox1.Tag.ToString() == "Paper" && pictureBox3.Tag.ToString() == "Rock")
                 || (pictureBox1.Tag.ToString() == "Scissors" && pictureBox3.Tag.ToString() == "Paper"))
            {
                lbWinner.Text = "Winner: Player";
                PlayerWin++;
            }
            else if ((pictureBox1.Tag.ToString() == "Rock" && pictureBox3.Tag.ToString() == "Rock")
                || (pictureBox1.Tag.ToString() == "Paper" && pictureBox3.Tag.ToString() == "Paper")
                 || (pictureBox1.Tag.ToString() == "Scissors" && pictureBox3.Tag.ToString() == "Scissors"))
            {
                lbWinner.Text = "Winner: Draw";
                Draw++;
            }    
            else
            {
                lbWinner.Text = "Winner: Computer";
                ComputerWin++;
            }
        }

        void CheckRoundsLimit()
        {
            GameRounds--;
            if (GameRounds == 0)
            {
                panel1.Enabled = false;
                ShowResults();
            }
        }

        void GameRound(Image image, string tag)
        {
            pictureBox1.Image = image;
            pictureBox1.Tag = tag;
            ComputerChoice();
            CheckWinner();
            CheckRoundsLimit();
        }

        void ShowResults()
        {

            Form frm3 = new frmResult(ComputerWin, PlayerWin, Draw);
            this.Hide();
            frm3.Show();
        }
        

        private void btnRock_Click_1(object sender, EventArgs e)
        {
            GameRound(Resources.Rock, "Rock");
        }

        private void btnScissors_Click_1(object sender, EventArgs e)
        {
            GameRound(Resources.Scissors, "Scissors");
        }

        private void btnPaper_Click_1(object sender, EventArgs e)
        {
            GameRound(Resources.Paper, "Paper");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (GameRounds <= 0)
                panel1.Enabled = false;

            
        }


        private void frmGameForm_Load(object sender, EventArgs e)
        {

        }
    }
}
