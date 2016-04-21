using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountLibrary
{
    public class NoDicount : Discount
    {
        //private double price = 270;
        //private float movieDiscount = 1f;

        //new public double Price
        //{
        //    get { return this.price; }
        //}

        //new public float MovieDiscount
        //{
        //    get { return this.movieDiscount; }
        //}
        public override double SetDiscount()
        {
            return 1f;
        }

        public override double SetPrice()
        {
            return 270;
        }
    }
}