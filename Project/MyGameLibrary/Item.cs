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
        public Vector2 Position { get; set; }
        public Collider Collider { get; set; }
        public string name { get; set; }
        public Image Img { get; set; }
        public bool is_weapon { get; set; }

        public Item(Vector2 initPos, Collider collider)
        {
            Position = initPos;
            Collider = collider;
        }
        /// <summary>
        /// move the picture to x --> -100 | y --> -100
        /// </summary>
        public void remove_item()
        {
            Position = new Vector2(-100, -100);
            Collider.MovePosition(-100, -100);
        }
        public bool drop_item(int x, int y)
        {
            Position = new Vector2(x, y);
            Collider.MovePosition(x, y);
            return true;
        }
     
    }
}
