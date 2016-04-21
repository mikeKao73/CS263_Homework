﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountLibrary
{
    public class StudentDiscount : Discount
    {
        //private double price = 200;
        //private float movieDiscount = 0.8f;
        public override double SetDiscount()
        {
            return 0.8f;
        }

        public override double SetPrice()
        {
            return 200;
        }
    }
}