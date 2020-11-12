using Fall2020_CSC403_Project.code;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class Frm_Pick_Up1 : Form
    {
        public static Frm_Pick_Up1 instance = null;
        private Item item;
        private Item item2;
        private bool trade_weapon;
        private Frm_Worthy frmWorthy;
        private FrmNotWorthy frmNotWorthy;
        public Frm_Pick_Up1(int initial)
        {
            // if the player is not trading
            if (initial == 1)
            {
                InitializeComponent1();
            }
            // if the player is trading
            else if(initial == 2)
            {
                InitializeComponent();
            }
            
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

        // not trading
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

        // trading
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

        /// <summary>
        /// handle all the picking up items and trading of weapons
        /// </summary>
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
                if (Program.PN_CurrentLevel >= 4)
                {
                    Worthy();
                }
                else
                {

                    NotWorthy();
                    Program.bag.remove_item(item.name);
                }
            }

        }

        /// <summary>
        /// handles the picking up of thor's hammer
        /// </summary>
        private void Worthy()
        {
            frmWorthy = Frm_Worthy.GetInstance();
            frmWorthy.Show();
        }

        /// <summary>
        /// handles the picking up of thor's hammer
        /// </summary>
        private void NotWorthy()
        {
            frmNotWorthy = FrmNotWorthy.GetInstance();
            frmNotWorthy.Show();
        }

        /// <summary>
        /// disables the exit button at the top-right of the sceen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
