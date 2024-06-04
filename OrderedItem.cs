using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeSystem
{
    internal class OrderedItem : Item
    {
        public int quantity;
        public double priceSum;

        public OrderedItem(int id, string name, int quantity, double priceSum) : base(id, name)
        {
            this.quantity = quantity;
            this.priceSum = priceSum;
        }
    }
}
