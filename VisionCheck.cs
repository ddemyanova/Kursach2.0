using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodVision
{
    public partial class VisionCheck : Form
    {
        public VisionCheck()
        {
            InitializeComponent();
        }

        private void BackFromVChButton_Click(object sender, EventArgs e)
        {
            MainMenu mMForm = new MainMenu();
            mMForm.Show();
            this.Hide();
        }
    }
}
