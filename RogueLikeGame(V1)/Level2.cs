using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RogueLikeGame_V1_
{
    public partial class Level2 : Form
    {
        bool goLeft, goRight, jumping;

        int jumpSpeed;
        int force;
        int Score = 0;
        int playerSpeed = 7;
        int numberOfCoins = 0;
        List<PictureBox> floors = new List<PictureBox>();
        List<PictureBox> coins = new List<PictureBox>();

        public Level2()
        {
            InitializeComponent();

            foreach (PictureBox x in pnlScreen.Controls)
            {
                if ((string)x.Tag == "platform")
                {
                    floors.Add(x);
                }
                else if ((string)x.Tag == "coin")
                {
                    coins.Add(x);
                    numberOfCoins++;
                }
            }
        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            pctPlayer.Top += jumpSpeed;

            if (goLeft == true)
            {
                pctPlayer.Left -= playerSpeed;
            }
            if (goRight == true)
            {
                pctPlayer.Left += playerSpeed;
            }



            if (jumping == true && force < 0)
            {
                jumping = false;
            }

            if (jumping == true)
            {
                jumpSpeed = -8;
                force -= 1;
            }
            else
            {
                jumpSpeed = 10;
            }

            foreach (PictureBox x in floors)
            {
                if (pctPlayer.Bounds.IntersectsWith(x.Bounds))
                {
                    force = 10;
                    pctPlayer.Top = x.Top - pctPlayer.Height;
                }
            }

            foreach (PictureBox x in coins)
            {
                if (pctPlayer.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                {
                    x.Visible = false;
                    Score++;
                }
            }

            //if (Score == numberOfCoins && pctPlayer.Bounds.IntersectsWith(pctDoor.Bounds))
            //{
            //    Level2 form = new Level2();
            //    form.Show();
            //    this.Close();
            //}
        }

        private void Level2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.D)
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Space && jumping == false)
            {
                jumping = true;
            }
        }

        private void Level2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.D)
            {
                goRight = false;
            }
            if (jumping == true)
            {
                jumping = false;
            }
        }



    }
}
