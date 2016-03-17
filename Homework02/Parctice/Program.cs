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
        }
    }
}