using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace B10302002project
{
    class Item
    {
        private int number;
        private ItemType type;
        private Bitmap image;
        private bool is_mouse_on;
        private bool is_mouse_down;
        private bool need_target;

        public Item(ItemType t = ItemType.None, string path = "None.bmp")
        {
            Number = 0;
            Type = t;
            Image = new Bitmap(path);
            IsMouseOn = false;
            IsMouseDown = false;
        }

        public Item(int n, ItemType t = ItemType.None, string path = "None.bmp")
        {
            Number = n;
            Type = t;
            Image = new Bitmap(path);
            IsMouseOn = false;
            IsMouseDown = false;
        }

        public bool IsMouseOn
        {
            get { return is_mouse_on; }
            set { is_mouse_on = value; }
        }

        public bool IsMouseDown
        {
            get { return is_mouse_down; }
            set { is_mouse_down = value; }
        }

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public ItemType Type
        {
            get { return type; }
            set { type = value; }
        }

        public Bitmap Image
        {
            get { return image; }
            set { image = value; }
        }

        public virtual void Use(Player source, Player[] target)
        {
            --Number;
        }
    }
}
