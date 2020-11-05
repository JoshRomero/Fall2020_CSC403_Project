using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class Frm_Pick_Up1 : Form
    {
        public static Frm_Pick_Up1 instance = null;
        private Player player;
        private Item item;
        public Frm_Pick_Up1()
        {
            InitializeComponent();
            player = Game.player;
        }

        public void Setup()
        {
            // update for this item
            picPotion.BackgroundImage = item.Img;
            picPotion.Refresh();
            BackColor = item.Color;
        }

        public static Frm_Pick_Up1 GetInstance(Item item)
        {
            if (instance == null)
            {
                instance = new Frm_Pick_Up1();
                instance.item = item;
                instance.Setup();
            }
            return instance;
        }
        private void Pick_Up_Click(object sender, EventArgs e)
        {
            player.bag.add_item(item.name);
            instance = null;
            Close();
            
        }
    }
}
