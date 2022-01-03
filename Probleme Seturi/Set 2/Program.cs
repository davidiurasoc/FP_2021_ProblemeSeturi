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
            // problema3(); // rezolvata
            // problema4();
            // problema5();
            // problema6(); // rezolvata
            // problema7(); // rezolvata
        }

        private static void problema7()
        {
            Console.WriteLine("Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa. ");
            Console.WriteLine();

            int n, a2;
            Console.Write("Introduceti n: "); n = int.Parse(Console.ReadLine());
            Console.Write("Introduceti a: "); int a1 = int.Parse(Console.ReadLine());
            int min = a1;
            int max = a1;

            for (int i = 1; i < n; i++)
            {
                Console.Write("Introduceti a: "); a2 = int.Parse(Console.ReadLine());
                if (a2 < min)
                {
                    min = a2;
                }
                if (a2 > max)
                {
                    max = a2;
                }
            }
            Console.WriteLine("Minimum: " + min);
            Console.WriteLine("Maximum: " + max);

        }

        private static void problema6()
        {
            Console.WriteLine();
            Console.WriteLine("Problema 6: Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare. ");
            Console.WriteLine();

            int secondNr;
            int x = 1;

            Console.Write("Introduceti valoare lui n: "); int n = int.Parse(Console.ReadLine());
            Console.Write("Introduceti un numar: "); int firstNr = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                Console.Write("Introduceti un numar: "); secondNr = int.Parse(Console.ReadLine());
                if (firstNr > secondNr || firstNr == secondNr)
                {
                    x = 0;
                }
                firstNr = secondNr;
            }

            Console.WriteLine();
            if (x == 1)
            {
                Console.WriteLine("Numerele sunt in ordine crescatoare!");
            }
            else
            {
                Console.WriteLine("Numerle nu sunt in ordine crescatoare!");
            }
            Console.WriteLine();
        }

        private static void problema5()
        {
        }

        private static void problema4()
        {
        }

        private static void problema3()
        {
            Console.WriteLine("Problema 3: Calculati suma si produsul numerelor de la 1 la n. ");

            Console.Write("Introduceti un numar: "); int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int x = n;
            int z = x;

            int suma = 0;
            for (int i = 1; n != 0; i++)
            {
                suma = suma + i;
                n--;
            }
            Console.WriteLine($"Suma numerelor de la 1 la {x} este: {suma}");

            int produs = 1;
            if (z > 0)
            {
                for (int y = 1; x != 0; y++)
                {
                    produs = produs * y;
                    x--;
                }
                Console.WriteLine($"Produsul numerelor de la 1 la {z} este: {produs}");
            }else
            {
                Console.WriteLine($"Produsul numerelor de la 1 la {z} este: {produs - 1}");
            }
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
            Console.WriteLine($"Sunt {counter} numere pare");
        }
    }
}
