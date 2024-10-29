using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //let user paste a year
            Console.WriteLine("wpisz rok");
            int year = Convert.ToInt32(Console.ReadLine());

            bool flag = (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
            string leapYearNegation = flag ? "" : "nie ";
            Console.WriteLine("Rok {0} {1}jest przestępny", year, leapYearNegation);

            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                Console.WriteLine("Rok {0} jest przestępny", year);
            }
            else
            {
                Console.WriteLine("Rok {0} nie jest przestępny", year);
            }
            Console.ReadKey(true);
        }
    }
}
