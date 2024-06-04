using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeSystem
{
    internal class ListItem : Item
    {
        public string category;
        public double price;

        public ListItem(int id, string name, double price, string category) : base(id, name) 
        {
            this.price = price;
            this.category = category;
        }
    }
}
