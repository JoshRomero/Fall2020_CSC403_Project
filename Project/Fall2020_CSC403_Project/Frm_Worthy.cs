using System;
using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class Frm_Worthy : Form
    {

        public static Frm_Worthy instance = null;
        private Frm_Worthy()
        {
            InitializeComponent();
        }
        public static Frm_Worthy GetInstance()
        {
            if (instance == null)
            {
                instance = new Frm_Worthy();
            }
            return instance;
        }

        private void btnworthy_Click(object sender, EventArgs e)
        {
            instance = null;
            Close();
        }
    }
}
