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
        private Enemy enemy;
        public death()
        {
            InitializeComponent();
        }

        public void death_Load(object sender, EventArgs e)
        {

        }
    }
}
