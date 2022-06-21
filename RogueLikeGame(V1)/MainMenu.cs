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
    public partial class MainMenu : Form
    {
        private Rectangle btnPlayOriginalRectangle;
        private Rectangle btnHelpOriginalRectangle;
        private Rectangle btnTitleOriginalRectangle;
        private Rectangle originalFormSize;
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //opens splash screem
        {
            SplashScreen form = new SplashScreen();
            form.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e) 
        {
            originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
            btnPlayOriginalRectangle = new Rectangle(btnPlay.Location.X, btnPlay.Location.Y, btnPlay.Width, btnPlay.Height);
            btnHelpOriginalRectangle = new Rectangle(btnHelp.Location.X, btnHelp.Location.Y, btnHelp.Width, btnHelp.Height);
            btnTitleOriginalRectangle = new Rectangle(btnTitle.Location.X, btnTitle.Location.Y, btnTitle.Width, btnTitle.Height);

        }

        private void resizeControlbtnPlay(Rectangle r, Control c) //resizes buttons
        {
            float xRatio = (float)(this.Width) / (float)(originalFormSize.Width);
            float yRatio = (float)(this.Height) / (float)(originalFormSize.Height);

            int newX = (int)(r.Location.X * xRatio);
            int newY = (int)(r.Location.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }

        private void resizeControlbtnHelp(Rectangle r, Control c)
        {
            float xRatio = (float)(this.Width) / (float)(originalFormSize.Width);
            float yRatio = (float)(this.Height) / (float)(originalFormSize.Height);

            int newX = (int)(r.Location.X * xRatio);
            int newY = (int)(r.Location.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }

        private void resizeControlbtnTitle(Rectangle r, Control c)
        {
            float xRatio = (float)(this.Width) / (float)(originalFormSize.Width);
            float yRatio = (float)(this.Height) / (float)(originalFormSize.Height);

            int newX = (int)(r.Location.X * xRatio);
            int newY = (int)(r.Location.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            resizeControlbtnPlay(btnPlayOriginalRectangle, btnPlay);
            resizeControlbtnHelp(btnHelpOriginalRectangle, btnHelp);
            resizeControlbtnTitle(btnTitleOriginalRectangle, btnTitle);
        }
    }
}
