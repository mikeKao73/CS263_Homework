using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountLibrary
{
    public class VIPDiscount : Discount
    {
        private double price = 250;
        private float discount = 0.5f;

        public string gift(int bonusPoints)
        {
            return bonusPoints > 5 ?
                "刷卡累積票數超過5張,免費贈送爆花+可樂套餐"
                : "";
        }
    }
}