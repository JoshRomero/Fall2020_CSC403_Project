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
        private Item item2;
        private bool trade_weapon;
        private Frm_Worthy frmWorthy;
        public Frm_Pick_Up1(int initial)
        {
            // not trade
            if (initial == 1)
            {
                InitializeComponent1();
            }
            // trade
            else if(initial == 2)
            {
                InitializeComponent();
            }
            
            player = Game.player; 
        }
        // not trade
        public void Setup()
        {
            // update for this item
            picItem1.BackgroundImage = item.Img;
            picItem1.Refresh();
            BackColor = item.Color;
        }
        // trade
        public void Setup2()
        {
            // update for this item
            picItem1.BackgroundImage = item.Img;
            picItem1.Refresh();
            picItem2.BackgroundImage = item2.Img;
            picItem2.Refresh();
            BackColor = item.Color;
        }

        public static Frm_Pick_Up1 GetInstance(Item item)
        {
            if (instance == null)
            {
                instance = new Frm_Pick_Up1(1);
                instance.item = item;
                instance.Setup();
            }
            return instance;
        }
        public static Frm_Pick_Up1 GetInstance2(Item item, Item item2)
        {
            if (instance == null)
            {
                instance = new Frm_Pick_Up1(2);
                instance.item = item;
                instance.item2 = item2;
                instance.trade_weapon = true;
                instance.Setup2();
            }
            return instance;
        }
        private void Pick_Up_Click(object sender, EventArgs e)
        {
            
            if (!instance.trade_weapon)
            {
                Program.bag.add_item(item.name, item.is_weapon);
            }
            else
            {
                Program.bag.trade_weapon(item.name, item2.name);
            }
                instance = null;
                Close();
            if (item.name == "Mjölnir")
            {
                Worthy();
            }

        }
        private void Worthy()
        {
            frmWorthy = Frm_Worthy.GetInstance();
            frmWorthy.Show();
        }
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
