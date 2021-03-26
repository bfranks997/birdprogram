using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Birds
{
    public partial class learnFromPictures : Form
    {
        int n = 0;
        List<Bird> birds = new List<Bird> { };
        string birdName = birds[0].Name;
        string birdCall = birds[0].Sound;
        public learnFromPictures()
        {
            InitializeComponent();
        }

        private void learnFromPictures_Load(object sender, EventArgs e)
        {
            reset();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            submitted();
        }

        private void submitted(/*string birdname*/)
        {
            Continue.Visible = true;
            submit.Visible = false;
            //label1.Text = birdname;

        }

        private void reset()
        {
            submit.Visible = true;
            Continue.Visible = false;
            userInput.Text = "";
            label1.Text = "";
        }

        private void Continue_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void nextBird()
        {
            birdImage.Image = Image.FromFile(birds[1].Image);
        }
    }
}
