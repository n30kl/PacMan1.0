using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PacManGame
{
    public partial class Form1 : Form
    {

        bool goup, godown, goleft, goright, isGameOver;

        int score, playerSpeed, redGhostSpeedX, redGhostSpeedY, yellowGhostSpeedX, yellowGhostSpeedY, pinkGhostSpeedX, pinkGhostSpeedY;

        public Form1()
        {
            InitializeComponent();

            resetGame();

        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                goup = true;
            if (e.KeyCode == Keys.Down)
                godown = true;
            if (e.KeyCode == Keys.Left)
                goleft = true;
            if (e.KeyCode == Keys.Right)
                goright = true;

        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                goup = false;
            if (e.KeyCode == Keys.Down)
                godown = false;
            if (e.KeyCode == Keys.Left)
                goleft = false;
            if (e.KeyCode == Keys.Right)
                goright = false;
            if (e.KeyCode == Keys.Enter && isGameOver == true)
                resetGame();
        }

        private void mainGameTimer(object sender, EventArgs e)
        {
            label1.Text = "Счёт: " + score;


            if (goleft == true)
            {
                pacman.Left -= playerSpeed;
                pacman.Image = Properties.Resources.left;
            }

            if (goright == true)
            {
                pacman.Left += playerSpeed;
                pacman.Image = Properties.Resources.right;
            }

            if (godown == true)
            {
                pacman.Top += playerSpeed;
                pacman.Image = Properties.Resources.down;
            }

            if (goup == true)
            {
                pacman.Top -= playerSpeed;
                pacman.Image = Properties.Resources.Up;
            }

            foreach (Control x in this.Controls)
            {
                if ((string)x.Tag == "coin" && x.Visible == true)
                    if (pacman.Bounds.IntersectsWith(x.Bounds))
                    {
                        score += 1;
                        x.Visible = false;
                    }
                if ((string)x.Tag == "Wall")
                {
                    if (pacman.Bounds.IntersectsWith(x.Bounds))
                    {
                        gameOver("Вы проиграли.");

                    }
                    if (redghost.Bounds.IntersectsWith(x.Bounds))
                    {
                        redGhostSpeedX = redGhostSpeedY;
                        redGhostSpeedY = redGhostSpeedX;
                        IfBounce(redghost);
                        Logic("r");
                    }
                    if (yellowghost.Bounds.IntersectsWith(x.Bounds))
                    {
                        yellowGhostSpeedX = yellowGhostSpeedY;
                        yellowGhostSpeedY = yellowGhostSpeedX;
                        IfBounce(yellowghost);
                        GoRandom("y");
                    }
                    if (pinkghost.Bounds.IntersectsWith(x.Bounds))
                    {
                        pinkGhostSpeedX = pinkGhostSpeedY;
                        pinkGhostSpeedY = -pinkGhostSpeedX;
                        IfBounce(pinkghost);
                        Logic("p");
                    }
                }

                if ((string)x.Tag == "ghost")
                    if (pacman.Bounds.IntersectsWith(x.Bounds))
                    {
                        gameOver("Вы проиграли.");
                    }
            }

            redghost.Left += redGhostSpeedX;
            redghost.Top += redGhostSpeedY;

            pinkghost.Left += pinkGhostSpeedX;
            pinkghost.Top += pinkGhostSpeedY;

            yellowghost.Left += yellowGhostSpeedX;
            yellowghost.Top += yellowGhostSpeedY;

            if (score == 11)
            {
                gameOver("Вы выиграли!");
            }

        }

        private void Logic (string m) //m = type of ghost
        #region GhostLogic
        {
            Random random = new Random();
            int i;
            /*if (WallIsUp(m) == true && WallIsRight(m) == true && WallIsLeft(m) == true && WallIsDown(m) == true)
            {
                redGhostSpeedX = 0;
                redGhostSpeedY = 0;
            }
            else*/
                   if (WallIsRight(m) == true && WallIsLeft(m) == true && WallIsDown(m) == true)
                GoUp(m);
            else
                      if (WallIsUp(m) == true && WallIsLeft(m) == true && WallIsDown(m) == true)
                GoRight(m);
            else
                      if (WallIsUp(m) == true && WallIsRight(m) == true && WallIsDown(m) == true)
                GoLeft(m);
            else
                      if (WallIsUp(m) == true && WallIsRight(m) == true && WallIsLeft(m) == true)
                GoDown(m);
            else
                        if (WallIsUp(m) == true && WallIsDown(m) == true)
            {
                i = random.Next(0,2);
                if (i == 1)
                    GoLeft(m);
                else
                    GoRight(m);
            }
            else
                        if (WallIsRight(m) == true && WallIsDown(m) == true)
            {
                i = random.Next(0,2);
                if (i == 1)
                    GoLeft(m);
                else
                    GoUp(m);
            }
            else
                    if (WallIsRight(m) == true && WallIsUp(m) == true)
            {
                i = random.Next(0,2);
                if (i == 1)
                    GoLeft(m);
                else
                    GoDown(m);
            }
            else
                    if (WallIsLeft(m) == true && WallIsDown(m) == true)
            {
                i = random.Next(0,2);
                if (i == 1)
                    GoUp(m);
                else
                    GoRight(m);
            }
            else
                    if (WallIsUp(m) == true && WallIsLeft(m) == true)
            {
                i = random.Next(0,2);
                if (i == 1)
                    GoDown(m);
                else
                    GoRight(m);
            }
            else
                    if (WallIsRight(m) == true && WallIsLeft(m) == true)
            {
                i = random.Next(0, 2);
                if (i == 1)
                    GoUp(m);
                else
                    GoDown(m);
            }
            else
                    if (WallIsDown(m) == true)
            {
                i = random.Next(0, 3);
                if (i == 1)
                    GoLeft(m);
                else
                    if (i == 2)
                    GoRight(m);
                else
                    GoUp(m);
            }
            else
                    if (WallIsUp(m) == true)
            {
                i = random.Next(0, 3);
                if (i == 1)
                    GoLeft(m);
                else
                    if (i == 2)
                    GoRight(m);
                else
                    GoDown(m);
            }
            else
                    if (WallIsRight(m) == true)
            {
                i = random.Next(0, 3);
                if (i == 1)
                    GoLeft(m);
                else
                    if (i == 2)
                    GoUp(m);
                else
                    GoDown(m);
            }
            else
                    if (WallIsLeft(m) == true)
            {
                i = random.Next(0,3);
                if (i == 1)
                    GoRight(m);
                else
                    if (i == 2)
                    GoUp(m);
                else
                    GoDown(m);
            }
            else
                    if (WallIsUp(m) == false && WallIsRight(m) == false && WallIsLeft(m) == false && WallIsDown(m) == false)
            {
                i = random.Next(0, 4);
                if (i == 1)
                    GoRight(m);
                else
                    if (i == 2)
                    GoUp(m);
                else
                    if (i == 3)
                    GoLeft(m);
                else
                    if (i == 4)
                    GoDown(m);
            }
        }
        #endregion

        private void GoRandom(string m)
        #region GoRandom
        {
            Random random = new Random();
            int i;
            i = random.Next(0, 4);
            if (i == 1)
                GoRight(m);
            else
                if (i == 2)
                GoUp(m);
            else
                if (i == 2)
                GoLeft(m);
            else
                GoDown(m);
        }
        #endregion

        private void GoUp(string color)
        #region GoUp
        {
            if (color == "r")
            {
                redGhostSpeedX = 0;
                redGhostSpeedY = -1;
            }
            if (color == "y")
            {
                yellowGhostSpeedX = 0;
                yellowGhostSpeedY = -1;
            }
            if (color == "p")
            {
                pinkGhostSpeedX = 0;
                pinkGhostSpeedY = -1;
            }
        }
        #endregion

        private void GoLeft(string color)
        #region GoLeft
        {
            if (color == "r")
            {
                redGhostSpeedX = -1;
                redGhostSpeedY = 0;
            }
            if (color == "y")
            {
                yellowGhostSpeedX = -1;
                yellowGhostSpeedY = 0;
            }
            if (color == "p")
            {
                pinkGhostSpeedX = -1;
                pinkGhostSpeedY = 0;
            }
        }
        #endregion

        private void GoDown(string color)
        #region GoDown
        {
            if (color == "r")
            {
                redGhostSpeedY = 1;
                redGhostSpeedX = 0;
            }
            if (color == "y")
            {
                yellowGhostSpeedY = 1;
                yellowGhostSpeedX = 0;
            }
            if (color == "p")
            {
                pinkGhostSpeedX = 0;
                pinkGhostSpeedY = 1;
            }
        }
        #endregion

        private void GoRight(string color)
        #region goRight
        {

            if (color == "r")
            {
                redGhostSpeedX = 1;
                redGhostSpeedY = 0;
            }
            if (color == "y")
            {
                yellowGhostSpeedY = 0;
                yellowGhostSpeedX = 1;
            }
            if (color == "p")
            {
                pinkGhostSpeedY = 0;
                pinkGhostSpeedX = 1;
            }
        }
        #endregion

        private void IfBounce(PictureBox a)
        #region IfBounce
        {

            foreach (Control x in this.Controls)
            {
                if ((string)x.Tag == "Wall")
                {
                    if (a.Left == x.Bounds.Left)
                        a.Left += 20;
                    if (a.Right == x.Bounds.Right)
                        a.Left -= 20;
                    if (a.Top == x.Bounds.Top)
                        a.Top += 20;
                    if (a.Bottom == x.Bounds.Bottom)
                        a.Top -= 20;
                    
                }
            }
        }
        #endregion

        private bool WallIsRight(string color)
        #region WallIsRight
        {
            bool b = false;
            foreach (Control x in this.Controls)
            {
                if ((string)x.Tag == "Wall")
                {
                    if (redghost.Left + 50 == x.Bounds.Left && color == "r")
                        b = true;
                    if (pinkghost.Left + 50 == x.Bounds.Left && color == "p")
                        b = true;
                    if (yellowghost.Left + 50 == x.Bounds.Left && color == "y")
                        b = true;
                }
            }
            return b;
        }
        #endregion

        private bool WallIsLeft(string color)
        #region WallIsLeft
        {
            bool b = false;
            foreach (Control x in this.Controls)
            {
                if ((string)x.Tag == "Wall")
                {
                    if (redghost.Left -10 == x.Bounds.Right && color == "r")
                        b = true;
                    if (pinkghost.Left -10== x.Bounds.Right && color == "p")
                        b = true;
                    if (yellowghost.Left -10 == x.Bounds.Right && color == "y")
                        b = true;
                }
            }
            return b;
        }
        #endregion

        private bool WallIsUp(string color)
        #region WallIsUp
        {
            bool b = false;
            foreach (Control x in this.Controls)
            {
                if ((string)x.Tag == "Wall")
                {
                    if (redghost.Top -10 == x.Bounds.Bottom && color == "r")
                        b = true;
                    if (pinkghost.Top -10 == x.Bounds.Bottom && color == "p")
                        b = true;
                    if (yellowghost.Top -10 == x.Bounds.Bottom && color == "y")
                        b = true;
                }
            }
            return b;
        }
        #endregion

        private bool WallIsDown(string color)
        #region WallIsDown
        {
            bool b = false;
            foreach (Control x in this.Controls)
            {
                if ((string)x.Tag == "Wall")
                {
                    if (redghost.Top + 60 == x.Bounds.Top && color == "r")
                        b = true;
                    if (pinkghost.Top + 60 == x.Bounds.Top && color == "p")
                        b = true;
                    if (yellowghost.Top + 60 == x.Bounds.Top && color == "y")
                        b = true;
                }
            }
            return b;
        }
        #endregion

        private List<PictureBox> Boxes()
        #region PictureBoxes
        {
            List<PictureBox> Box = new List<PictureBox>();
            Box.Add(pictureBox5);
            Box.Add(pictureBox6);
            Box.Add(pictureBox7);
            Box.Add(pictureBox8);
            Box.Add(pictureBox9);
            Box.Add(pictureBox10);
            Box.Add(pictureBox11);
            Box.Add(pictureBox12);
            Box.Add(pictureBox13);
            Box.Add(pictureBox14);
            Box.Add(pictureBox15);
            Box.Add(pictureBox16);
            Box.Add(pictureBox17);
            Box.Add(pictureBox18);
            Box.Add(pictureBox19);
            Box.Add(pictureBox20);
            Box.Add(pictureBox21);
            Box.Add(pictureBox22);
            Box.Add(pictureBox23);
            Box.Add(pictureBox24);
            Box.Add(pictureBox25);
            Box.Add(pictureBox26);
            Box.Add(pictureBox27);
            Box.Add(pictureBox28);
            Box.Add(pictureBox29);
            Box.Add(pictureBox30);
            Box.Add(pictureBox31);
            Box.Add(pictureBox32);
            Box.Add(pictureBox33);
            Box.Add(pictureBox34);
            Box.Add(pictureBox35);
            Box.Add(pictureBox36);
            Box.Add(pictureBox40);
            Box.Add(pictureBox41);
            Box.Add(pictureBox42);
            Box.Add(pictureBox43);
            Box.Add(pictureBox44);
            Box.Add(pictureBox45);
            Box.Add(pictureBox46);
            Box.Add(pictureBox47);
            Box.Add(pictureBox49);
            Box.Add(pictureBox51);
            Box.Add(pictureBox52);
            Box.Add(pictureBox53);
            Box.Add(pictureBox54);
            Box.Add(pictureBox55);
            Box.Add(pictureBox56);
            Box.Add(pictureBox57);
            Box.Add(pictureBox58);
            Box.Add(pictureBox59);
            Box.Add(pictureBox60);
            Box.Add(pictureBox61);
            Box.Add(pictureBox62);
            Box.Add(pictureBox63);
            Box.Add(pictureBox64);
            Box.Add(pictureBox65);
            Box.Add(pictureBox66);
            Box.Add(pictureBox67);
            Box.Add(pictureBox68);
            Box.Add(pictureBox69);
            Box.Add(pictureBox71);
            Box.Add(pictureBox72);
            Box.Add(pictureBox73);
            Box.Add(pictureBox74);
            Box.Add(pictureBox75);

            return Box;
        }
        #endregion

        private void resetGame()
        {
            Random random = new Random();
            int value;

            foreach (var v in Boxes())
            {
                value = random.Next(1, 3);
                if (value == 2)
                {
                    v.Tag = "Wall";
                    v.BackColor = Color.Blue;
                }
            }

            foreach (var v in Boxes())
            {
                value = random.Next(1, 3);
                if (value == 2)
                {
                    v.Visible = true;
                    v.Tag = "goodWall";
                    v.BackColor = Color.Black;
                }
            }

            label1.Text = "Счёт: 0";
            score = 0;

            playerSpeed = 5;
            redGhostSpeedX = 1;
            redGhostSpeedY = 1;
            yellowGhostSpeedX = 1;
            yellowGhostSpeedY = 1;
            pinkGhostSpeedX = 1;
            pinkGhostSpeedY = 1;

            isGameOver = false;

            pacman.Left = 25;
            pacman.Top = 20;
            redghost.Left = 25;
            redghost.Top = 300;
            yellowghost.Left = 388;
            yellowghost.Top = 300;
            pinkghost.Left = 388;
            pinkghost.Top = 20;

            gameTimer.Start();

            foreach (Control x in this.Controls)
                if (x is PictureBox)
                {
                    x.Visible = true;
                }


        }

        private void gameOver(string message)
        {
            isGameOver = true;

            gameTimer.Stop();

            label1.Text += "     " + message;
        }
    }
}
