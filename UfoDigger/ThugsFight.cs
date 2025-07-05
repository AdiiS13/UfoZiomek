using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UfoDigger
{

    public partial class ThugsFight : Form
    {
        Random random = new Random();
        public string didUfoWon { get; set; }
        private bool areResultsIn = false;
        public ThugsFight()
        {
            InitializeComponent();
            this.Activate();
        }

        private void ThugsFight_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void RPSLost() ///Usuniencie punktów + benzyny po przegranien do dodaniaAdd commentMore actions
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!areResultsIn)
            {
                int computerTurn = random.Next(1, 4);
                int playerTurn = random.Next(1, 4);

                ///Obrazków dla renki ufoludka
                switch (playerTurn)
                {
                    case 1:
                        pictureBox2.Image = Properties.Resources.kamienU;
                        pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 2:
                        pictureBox2.Image = Properties.Resources.papierU;
                        pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 3:
                        pictureBox2.Image = Properties.Resources.nozyceU;
                        pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    default:
                        pictureBox2.Image = Properties.Resources.kamienU;
                        pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                }
                ///Obrazki dla renki dresiarza
                switch (computerTurn)
                {
                    case 1:
                        pictureBox1.Image = Properties.Resources.kamienD;
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 2:
                        pictureBox1.Image = Properties.Resources.papierD;
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 3:
                        pictureBox1.Image = Properties.Resources.nozyceD;
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    default:
                        pictureBox1.Image = Properties.Resources.kamienD;
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;

                }
                determineWinner(playerTurn, computerTurn);
            }
        }
        public void determineWinner(int player, int computer)
        {
            if (player == computer)
            {
                label3.Text = "Remis!";
                didUfoWon = "D";
            }
            else if ((player == 1 && computer == 3) || (player == 2 && computer == 1) || (player == 3 && computer == 2))
            {
                label3.Text = "Ufoludek wygrywa!";
                didUfoWon = "W";
            }
            else
            {
                label3.Text = "Ufoludek przegrywa!";
                //jeszcze dodanie utraty punktów i benzyny
                didUfoWon = "L";
            }
            areResultsIn = true;
        }

        private void KeyListener(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                e.Handled = true;
            }
        }
    }
}
