using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Student someone = new Student()
            {
                name = "mikeKao",
                information = new Contact()
                {
                    address = "台北市羅斯福路123號",
                    phone = "0938938938",
                    email = "gmail@gmail.com",
                    birthday = "1984-12-03",
                    bloodType = "A"
                }
            };

            Console.WriteLine(someone.name);
            Console.WriteLine(someone.information.address);
            Console.WriteLine(someone.information.phone);
            Console.WriteLine(someone.information.email);
            Console.WriteLine(someone.information.birthday);
            Console.WriteLine(someone.information.bloodType);
        }
    }
}