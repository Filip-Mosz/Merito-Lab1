using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {//program spyta o liczbę
            //użytkownik wprowadza liczbę i zatwierdza
            //liczba zapisana jako x

            int x = 0;
            Console.WriteLine("podaj pierwszą liczbę całkowitą");
            x = Convert.ToInt32(Console.ReadLine());

            //program spyta o liczbę
            //użytkownik wprowadza liczbę i zatwierdza
            //liczba zapisana jako y
            int y = 0;
            Console.WriteLine("podaj drugą liczbę całkowitą");
            y = Convert.ToInt32(Console.ReadLine());

            //program utworzy zmienną suma i zapisze wynik 
            //operacji x + y
            //program wyswietla wartość zmiennej suma
            int sum = x + y;
            Console.WriteLine("suma {0} i {1} to {2}", x,y, sum);
            float average = (float)(x + y) / 2;
            Console.WriteLine("średnia wpisanych prze użytkownika liczb to {0}", average);
            Console.ReadKey();
        }
    }
}
