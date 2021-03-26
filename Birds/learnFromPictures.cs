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
        Bird[] birdArray = new Bird[200];

        string birdName = "Click Continue to begin";

        public learnFromPictures()
        {
            InitializeComponent();
        }

        private void learnFromPictures_Load(object sender, EventArgs e)
        {
            Continue.Visible = true;
            submit.Visible = false;
            userInput.Enabled = false;
            Continue.Text = "Begin";
        }

        private void submit_Click(object sender, EventArgs e)
        {
            submitted();
        }

        private void submitted(/*string birdname*/)
        {
            Continue.Visible = true;
            submit.Visible = false;
            userInput.Enabled = false;
            Continue.Text = "Continue";
            label1.Text = "Bird Name";

        }

        private void reset()
        {          
            userInput.Enabled = true;
            submit.Visible = true;
            Continue.Visible = false;
            userInput.Text = "";
            label1.Text = "";
            nextBird();
        }

        private void Continue_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void nextBird()
        {
         //   birdImage.Image = Image.FromFile(birds[1].Image);
        }
    }
}
