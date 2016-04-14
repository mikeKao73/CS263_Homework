using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountLibrary
{
    public class Discount
    {
        private double price = 250;
        private float discount = 1f;

        public double Price
        {
            get { return price; }
        }

        public virtual double Calculate()
        {
            return this.Price * this.discount;
        }
    }
}