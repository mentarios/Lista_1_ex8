using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1_ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a1, a2, a3, a4, a5;
            Console.WriteLine("digite o primeiro numero:");
            a1 = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o segundo numero:");
            a2 = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o terceiro numero:");
            a3 = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o quarto numero:");
            a4 = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o quinto numero:");
            a5 = int.Parse(Console.ReadLine());
            if (a1 > a2 && a1 > a3 && a1 > a4 && a1 > a5)
            {
                Console.WriteLine("o maior é: " + a1);
            }
            if (a2 > a1 && a2 > a3 && a2 > a4 && a2 > a5)
            {
                Console.WriteLine("o maior é: " + a2);
            }
            if (a3 > a1 && a3 > a2 && a3 > a4 && a3 > a5)
            {
                Console.WriteLine("o maior é: " + a3);
            }
            if (a4 > a1 && a4 > a2 && a4 > a3 && a4 > a5)
            {
                Console.WriteLine("o maior é: " + a4);
            }
            if (a5 > a1 && a5 > a2 && a5 > a3 && a5 > a4)
            {
                Console.WriteLine("o maior é: " + a5);
            }



            if (a1 < a2 && a1 < a3 && a1 < a4 && a1 < a5)
            {
                Console.WriteLine("o menor é: " + a1);
            }
            if (a2 < a1 && a2 < a3 && a2 < a4 && a2 < a5)
            {
                Console.WriteLine("o menor é: " + a2);
            }
            if (a3 < a1 && a3 < a2 && a3 < a4 && a3 < a5)
            {
                Console.WriteLine("o menor é: " + a3);
            }
            if (a4 < a1 && a4 < a2 && a4 < a3 && a4 < a5)
            {
                Console.WriteLine("o menor é: " + a4);
            }
            if (a5 < a1 && a5 < a2 && a5 < a3 && a5 < a4)
            {
                Console.WriteLine("o menor é: " + a5);
            }
            Console.ReadKey();
        }
    }
}
