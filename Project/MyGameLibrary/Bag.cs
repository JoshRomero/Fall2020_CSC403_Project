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
        //List<string> items = new List<string>();
        private int bag_size;


        public Bag()
        {
            bag_size = 0;
        }

        public int get_bag_size()
        {
            return bag_size;
        }
        public void add_item()
        {
            //items.Add(new_item);
            bag_size++;
        }
        public void use_item()
        {
            bag_size--;
        }
     
    }
}
