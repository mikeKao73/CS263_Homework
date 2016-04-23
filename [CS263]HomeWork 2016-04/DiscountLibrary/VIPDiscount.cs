using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountLibrary
{
    public class VIPDiscount : Discount
    {
        //private double price = 270;
        //private float movieDiscount = 0.5f;

        public override double SetDiscount()
        {
            return 0.5f;
        }

        public override double SetPrice()
        {
            return 270;
        }

        public string gift(int bonusPoints)
        {
            return bonusPoints > 5 ?
                "同時刷卡票數超過5張,免費贈送爆花+可樂套餐\n"
                : "";
        }
    }
}