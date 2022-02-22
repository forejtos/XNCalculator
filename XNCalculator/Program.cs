using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XNCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Zadej hodnotu x (0 < x < 1): ");
            //double x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Zadej hodnotu n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int fact = 1;

            //if ((x < 0) || (x < 1)) //vyjímka, pokud x nesplňuje podmínku 0 < x < 1
            //{
            //    throw new IndexOutOfRangeException();
            //}

            for (int i = 1; i <= n; i++) //výpočet faktoriálů
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial of " + n + " is: " + fact);
            Console.ReadLine();
        }
    }
}
