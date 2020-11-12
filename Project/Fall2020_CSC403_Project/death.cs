using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fall2020_CSC403_Project.code;

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

        public void death_Load(object sender, EventArgs e)
        {

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
    }
}
