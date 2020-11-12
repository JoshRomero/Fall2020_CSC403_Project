using System;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmNotWorthy : Form
    {
        public static FrmNotWorthy instance = null;
        public FrmNotWorthy()
        {
            InitializeComponent();
        }
        public static FrmNotWorthy GetInstance()
        {
            if (instance == null)
            {
                instance = new FrmNotWorthy();
            }
            return instance;
        }

        private void btnworthy1_Click(object sender, EventArgs e)
        {
            instance = null;
            Close();
        }
    }
}
