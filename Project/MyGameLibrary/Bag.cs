using System.Collections.Generic;

namespace Fall2020_CSC403_Project.code
{
    /// <summary>
    /// holds all the players items
    /// </summary>
    public class Bag
    {
        List<string> items = new List<string>();
        private int bag_size;
        public bool has_a_weapon;
        public string current_weapon { get; set; }


        public Bag()
        {
            bag_size = 0;
        }

        /// <summary>
        ///  keeps the count of items in players bag
        /// </summary>
        /// <returns></returns> the size of the bag (int)
        public int get_bag_size()
        {
            return bag_size;
        }

        /// <summary>
        /// if item is a weapon it adds it to the current weapon
        /// if it is not a weapon it is put in the bag
        /// </summary>
        /// <param name="new_item"></param>
        /// <param name="is_weapon"></param>
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

        /// <summary>
        /// remove the item from the bag and subtracts 1 from the bag size
        /// </summary>
        /// <param name="item"></param>
        public void remove_item(string item)
        {
            items.Remove(item);
            bag_size--;


        }

        /// <summary>
        /// check to see if the bag is empty, if not empty, then looks for the itme in the bag and removes it 
        /// after it is removed subtracts 1 from bag size
        /// </summary>
        /// <param name="tool"></param>
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

        /// <summary>
        ///  Goes throught the bag and counts all the healing potions
        /// </summary>
        /// <returns></returns> the total count
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

        /// <summary>
        /// looks in bag and searches for the hammer
        /// </summary>
        /// <returns></returns> true= hammer is in bag, false otherwise
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

        /// <summary>
        /// return the bool of has_a_hammer
        /// </summary>
        /// <returns></returns>
        public bool has_weapon()
        {
            return has_a_weapon;
        }

        /// <summary>
        /// if player already has a weapon and tries to pick up another it will be traded
        /// player can only hold one weapon
        /// </summary>
        /// <param name="curr_weap"></param> the current weapon in bag
        /// <param name="next_weap"></param> the weapon the player is trying to pick up
        public void trade_weapon(string curr_weap, string next_weap)
        {
            items.Remove(curr_weap);
            items.Add(next_weap);
            current_weapon = next_weap;
        }

        public void remove_all()
        {
            items.Clear();
        }
    }
}
