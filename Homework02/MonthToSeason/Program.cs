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

            Console.WriteLine("請輸入月份:");
            aSeason.month = int.Parse(Console.ReadLine());
            aSeason.ToSeason();
        }
    }
}