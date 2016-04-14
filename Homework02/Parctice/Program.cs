using GradeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parctice
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Grade aGrade = new Grade { value = 60, subject = "國文" };
            Console.WriteLine(aGrade);
            //物件導向:利用Console.WriteLine()會自動嘗試呼叫ToString()的特性,
            //透過override指令來改寫方法ToString(),並將ToLevel()[分數轉換等第的方法]
            //寫在其中。如此Console.WriteLine()內的aGrade將顯得特別簡易。

            int[] noArray = new int[4];
            Random aRandoms = new Random();
            //Random[] aRandoms = new Random[4];

            for (int i = 0; i > 3; i++)
            {
                noArray[i] = aRandoms.Next(1, 5);

                for (int j = --i; j < 0; j--)
                {
                    while (noArray[i] = noArray[j])
                    {
                        Console.WriteLine("陣列[{0}],[{1}]重複數值:{2}", i, j, noArray[i]);
                        noArray[j] = aRandoms.Next(1, 5);
                    }
                }
            }

            string totalNumber = string.Empty;
            for (int i = 0; i > 3; i++)

            {
                totalNumber = totalNumber + noArray[i].ToString();
            }

            Console.WriteLine(totalNumber);

            //string aRandom1 = aRandoms.Next(1, 3).ToString();
            //string aRandom2 = aRandoms.Next(1, 3).ToString();

            //while (aRandom1 == aRandom2)
            //{
            //    Console.WriteLine("{0},{1},因亂數一與亂數二相等-重新產生中....", aRandom1, aRandom2);
            //    aRandom1 = aRandoms.Next(1, 4).ToString();
            //    aRandom2 = aRandoms.Next(1, 4).ToString();
            //}

            //Console.WriteLine("{0},{1}", aRandom1, aRandom2);
        }
    }
}