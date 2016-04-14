using SeasonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthToSeason
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Season aSeason = new Season();

            Console.Write("請輸入月份:");
            int.TryParse(Console.ReadLine(), out aSeason.month);
            aSeason.ToSeason();
        }
    }
}