using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // problema1(); // rezolvata
            // problema2(); // rezolvata
        }

        private static void problema2()
        {
            Console.WriteLine();
            Console.WriteLine("Problema 2: Se da o secventa de n numere. ");
            Console.WriteLine("Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive.");
            Console.WriteLine();

            Console.Write("Cate numere vreti sa introduceti: "); int n = int.Parse(Console.ReadLine());
            int ctrPoz = 0;
            int ctrNull = 0;
            int ctrNeg = 0;
            do
            {
                Console.Write("Introduceti un numar: "); int numar = int.Parse(Console.ReadLine());
                n--;

                if (numar > 0)
                {
                    ctrPoz++;
                }
                else if (numar == 0)
                {
                    ctrNull++;
                }
                else
                {
                    ctrNeg++;
                }
            }
            while (n != 0);
            Console.WriteLine($"Sunt {ctrPoz} numere pozitive nenule!");
            Console.WriteLine($"Sunt {ctrNull} numere nule!");
            Console.WriteLine($"Sunt {ctrNeg} numere negative!");
        }

        private static void problema1()
        {
            Console.WriteLine();
            Console.WriteLine("Problema 1: Se da o secventa de n numere. Sa se determine cate din ele sunt pare.");
            Console.WriteLine();

            Console.Write("Cate numere vreti sa introduceti: "); int n = int.Parse(Console.ReadLine());
            int counter = 0;
            int num;

            do
            {
                Console.Write("Introduceti un numar: "); int numbers = int.Parse(Console.ReadLine());
                n--;

                if (numbers % 2 == 0)
                {
                    counter++;
                }
            }
            while (n != 0);
            Console.WriteLine(counter);
        }
    }
}
