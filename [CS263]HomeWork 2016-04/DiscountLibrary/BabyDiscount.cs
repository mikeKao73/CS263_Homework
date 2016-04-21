using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountLibrary
{
    public class BabyDiscount : Discount
    {
        //private double price = 180;
        //private float movieDiscount = 0.3f;

        public override double SetDiscount()
        {
            return 0.3f;
        }

        public override double SetPrice()
        {
            return 180;
        }
    }
}