using System;
using System.ComponentModel;
using System.Windows.Forms;


namespace Fall2020_CSC403_Project
{
    public partial class death : Form
    {
        public static death instance = null;
        private death()
        {
            InitializeComponent();
        }

        public static death GetInstance()
        {
            if (instance == null)
            {
                instance = new death();
            }
            return instance;
        }

        private void btnReplay_Click(object sender, EventArgs e)
        {
            instance = null;
            Program.play_again();
            Close();
        }

        private void btnGiveUp_Click(object sender, EventArgs e)
        {
            instance = null;
            Program.end_game();
            Close();
        }
        /// <summary>
        /// this disables the cancel button on the top right of the screen
        /// </summary>
        private void Form1_Closing(Object sender, CancelEventArgs e)
        {
            if (instance == null)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
