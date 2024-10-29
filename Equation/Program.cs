using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //program do rozwiązywania równań
            //postaci: ax^2 + bx + c = 0
            //gdzie abc są typu int
            //użytkownik podaje zmienne
            //jeśli a==0 program rzuci wyjątek z komunikatem 'nieprawidłowy parametr <parametr>'
            // przeciwnym razie mamy równanie kwadratowe
            //utworzymy zmienną int delta = b*b - 4+x+c
            //w zależności od znaku
            //if detla >0
            //program informuje o ilości rozwiąza i drukuje rozwiązania
            //jeśli delta == 0 informuje o ilości rozwiązań (1) i je drukuje
            //jeśli delta <0 informuje o braku rozwiązań
            Console.WriteLine("podaj parametr a");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == 0)
            {
                throw new Exception(@"Parametr ""a"" nie moze być równy 0!");
            }
            Console.WriteLine("podaj parametr b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("podaj parametr c");
            int c = Convert.ToInt32(Console.ReadLine());

            float delta = ((float)b * (float)b) - (4 * (float)a * (float)c);
            //Console.WriteLine("Delta ma wartość {0}", delta);
            if (delta < 0)
            {
                Console.WriteLine("Delta ma wartość zero. Równanie nie ma rozwiązania");
            }
            if (delta > 0)
            {
                Console.WriteLine("Równanie ma 2 rozwiązania:");
                double outcome1 = ((double)-b - Math.Sqrt(delta)) / 2 * (double)a;
                double outcome2 = ((double)-b + Math.Sqrt(delta)) / 2 * (double)a;
                Console.WriteLine(outcome1 + " i " + outcome2);
                Console.ReadKey();
            }
            if (delta == 0)
            {
                Console.WriteLine("Równanie ma 1 rozwiązanie:");
                double outcome = ((double)-b+Math.Sqrt(delta))/2*(double)a;
                Console.WriteLine(outcome);
                Console.ReadKey();
            }

        }
    }
}
