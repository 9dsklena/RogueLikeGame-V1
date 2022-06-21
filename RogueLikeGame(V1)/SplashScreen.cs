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
    public partial class SplashScreen : Form
    {
        const int MAXFACT = 14;
        const int MINFACT = 0;
        string[] funFacts = new string[15];
        int funFact = 0;
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void lblFunFacts_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e) //fun facts for loadin screen
        {
            Random rand = new Random();

            funFacts[0] = "Fun Fact! Sudan has the most pyramids in the world housing around 255 pyramids in total about 117 more than Egypt!";
            funFacts[1] = "Fun Fact! A childrens circulatory system is about 96,500 kilometers long this almost doubles by the time somes reaches adulthood at 160,000 kilometers long";
            funFacts[2] = "Fun Fact! The continent Africa can be found in all four hemispheres of the world";
            funFacts[3] = "Fun Fact! While small the Philippines has over 7,600 individual islands";
            funFacts[4] = "Fun Fact! While precious there it has been said that there is enough gold inside the earth to coat the entire planet";
            funFacts[5] = "Fun Fact! Water makes up about 71% of the earths surface but, humans are only able to use about 0.007% of this available water";
            funFacts[6] = "Fun Fact! The Mississippi river is about 3800 kilometers long this means that it takes a single drop of water about 90 days to travel the full length of it";
            funFacts[7] = "Fun Fact! Japan has the highest density of vending machines in the world with an average of one vending machine per 40 people";
            funFacts[8] = "Fun Fact! Oranges where originally green which makes you wonder, why were they called oranges?";
            funFacts[9] = "Fun Fact! Samsung uses a robot with a human shaped butt to sit on their phones to test the durability";
            funFacts[10] = "Fun Fact! The shell of an Armadillo is bullet-proof as a man was even hospitalised after he had a bullet ricochet off the animal hitting him in the jaw";
            funFacts[11] = "Fun Fact! Some Species of Octopus lay up to 56,000 eggs at one time";
            funFacts[12] = "Fun Fact! A blue whale will eat half a million calories in just one mouthful";
            funFacts[13] = "Fun Fact! Thanks to 3D printing NASA can now email tools to Astronauts on the international space station";
            funFacts[14] = "Fun Fact! It has been said that the moon had active volcanoes on it about 100,000,000 years ago";
            
            funFact = rand.Next(MINFACT, MAXFACT + 1); //funfact generater
            lblFunFacts.Text = $"{funFacts[funFact]}"; //funfact output

        }

        private void tmrLoading_Tick(object sender, EventArgs e) //loading bar
        {
            tmrLoading.Enabled = true;
            pgbLoading.Increment(2);

            if (pgbLoading.Value == 100)    
            {
                tmrLoading.Enabled = false;
                Level1 form = new Level1();
                form.Show();
                this.Hide();
            }
        }

        private void pgbLoading_Click(object sender, EventArgs e)
        {

        }
    }
}
