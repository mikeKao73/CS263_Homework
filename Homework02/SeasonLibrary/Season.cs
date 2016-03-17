using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeasonLibrary
{
    public class Season
    {
        public int month;

        public void ToSeason()
        {
            switch (this.month)
            {
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("國曆{0}月份為春季", this.month);
                    break;

                case 6:
                case 7:
                case 8:
                    Console.WriteLine("國曆{0}月份為夏季", this.month);
                    break;

                case 9:
                case 10:
                case 11:
                    Console.WriteLine("國曆{0}月份為春季", this.month);
                    break;

                case 12:
                case 1:
                case 2:
                    Console.WriteLine("國曆{0}月份為冬季", this.month);
                    break;
            }
        }
    }
}