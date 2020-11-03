using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project.code
{

    public class Item
    {
        public Color Color { get; set; }

        /// <summary>
        /// Specifies where the item will be at on the screen
        /// </summary>
        public Vector2 Position { get; private set; }
        public Collider Collider { get; private set; }
        public string name { get; set; }
        public Image Img { get; set; }

        public Item(Vector2 initPos, Collider collider)
        {
            //Position = initPos;
            //Collider = collider;
        }
    }
}
