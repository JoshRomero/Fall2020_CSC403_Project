using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Fall2020_CSC403_Project.code
{
    public class Bag
    {
        List<string> items = new List<string>();
        private int bag_size;
        private bool has_a_weapon;
        public string current_weapon { get; set; }


        public Bag()
        {
            bag_size = 0;
        }

        public int get_bag_size()
        {
            return bag_size;
        }
        public void add_item(string new_item, bool is_weapon)
        {
            if (is_weapon)
            {
                current_weapon = new_item;
                has_a_weapon = true;
            }
            items.Add(new_item);
            bag_size++;
        }
        public void use_item(string tool)
        {
            bool used = false;
            if (bag_size > 0)
            {
                for (int i = 0; i < bag_size; i++)
                {
                    if (tool == items[i])
                    {
                        items.RemoveAt(i);
                        used = true;
                        break;
                    }
                }
                if (used)
                {
                    bag_size--;
                }
                
            }
        }
        public int num_potions()
        {
            int count = 0;
            foreach (string itm in items)
            {
                if (itm == "Healing potion")
                {
                    count++;
                }
            }
            return count;
        }
        public bool has_hammer()
        {
            foreach (string item in items)
            {
                if (item == "Mjölnir")
                {
                    return true;
                }
            }
            return false;
        }
        public bool has_weapon()
        {
            return has_a_weapon;
        }

        public void trade_weapon(string curr_weap, string next_weap)
        {
            items.Remove(curr_weap);
            items.Add(next_weap);
            current_weapon = next_weap;
        }
    }
}
