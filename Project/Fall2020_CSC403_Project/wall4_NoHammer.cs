using System;
using System.Windows.Forms;
using System.ComponentModel;

namespace Fall2020_CSC403_Project
{
    public partial class wall4_NoHammer : Form
    {

        public static wall4_NoHammer instance = null;
        public wall4_NoHammer()
        {
            InitializeComponent();
        }

        public static wall4_NoHammer GetInstance()
        {
            if (instance == null)
            {
                instance = new wall4_NoHammer();
            }
            return instance;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            instance = null;
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
