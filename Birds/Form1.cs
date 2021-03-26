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
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }

        private void learnFromPictures_Click(object sender, EventArgs e)
        {
            learnFromPictures picLearner = new learnFromPictures();
            picLearner.Show();
        }
    }
}
