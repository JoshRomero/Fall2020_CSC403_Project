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
        int bag_size = 0;
        public Bag()
        {
            Bag bag = new Bag();
        }

        public void add_item(string new_item)
        {
            items.Add(new_item);
            bag_size++;
        }

        public void use_item(string item)
        {
            string in_bag = "false";
            int count = 0;
            foreach(string i in items)
            {
                if (i == item) {
                    in_bag = "true";
                }
                else
                {
                    count++;
                }
            }
            if (in_bag == "true")
            {
                drink_item(item);
                items.RemoveAt(count);
                bag_size--;
            }
        }

        private void drink_item(string item)
        {
            if (item == "Blue"){
               player.AlterHealth(10);
            }
        }
     
    }
}
