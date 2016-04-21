using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountLibrary
{
    public abstract class Discount
    {
        //private double price;
        //private float movieDiscount = 1f;

        //public double Price
        //{
        //    get { return this.price; }
        //}

        //public float MovieDiscount
        //{
        //    get { return this.movieDiscount; }
        //}

        public abstract double SetDiscount();

        public abstract double SetPrice();

        // {
        //     return this.Price;
        // }
    }
}