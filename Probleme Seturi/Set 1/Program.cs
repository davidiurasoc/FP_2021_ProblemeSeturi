using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // problema1();
            // problema2();
            // problema3();  rezolvata
            // problema4();  rezolvata
            // problema5();
            // problema6();
            // problema7();  rezolvata
            // problema8();
            // problema9();  rezolvata
            // problema10(); rezolvata
        }

        private static void problema10()
        {
            Console.WriteLine();
            Console.WriteLine("Problema 10: Test de primalitate: determinati daca un numar n este prim. ");
            Console.WriteLine();
            
            Console.WriteLine("Introduceti un numar: ");
            int n = int.Parse(Console.ReadLine());
            int y = 0;

            for (int x = 2; x <= n / 2; x++)  
            {
                if (n % x == 0)
                {
                    y++;
                }
            }
            Console.WriteLine();

            if (y == 0)
                Console.WriteLine($"Numarul {n} este prim! ");
            else
                Console.WriteLine($"Numarul {n} nu este prim! ");
        }

        private static void problema9()
        {
            Console.WriteLine();
            Console.WriteLine("Problema 9: Afisati toti divizorii numarului n. ");
            Console.WriteLine();

            Console.WriteLine("Introduceti un numar:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                    Console.Write(i + " ");
            }
        }

        private static void problema8()
        {
        }

        private static void problema7()
        {
            Console.WriteLine();
            Console.WriteLine("Problema 7: (Swap) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. ");
            Console.WriteLine("Se cere sa se inverseze valorile lor. ");
            Console.WriteLine();

            int a = int.Parse(Console.ReadLine()); 
            int b = int.Parse(Console.ReadLine()); 
            int aux;

            aux = b; 
            b = a;  
            a = aux; 
            Console.WriteLine();

            Console.WriteLine($"Invers: {a}, {b}");

        }

        private static void problema6()
        {
        }

        private static void problema5()
        {
            Console.WriteLine();
            Console.WriteLine("Problema 5: Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga. ");
            Console.WriteLine();

            int numar = int.Parse(Console.ReadLine()); 
            int k = int.Parse(Console.ReadLine()); 
        }

        private static void problema4()
        {
            Console.WriteLine();
            Console.WriteLine("Problema 4: Detreminati daca un an y este an bisect. ");
            Console.WriteLine();

            int y = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (y % 4 == 0 && y % 100 != 0 || y % 400 == 0)
            {
                Console.WriteLine($"Anul {y} este an bisect!");
            }
            else
            {
                Console.WriteLine($"Anul {y} nu este an bisect!");
            }
        }

        private static void problema3()
        {
            Console.WriteLine();
            Console.WriteLine("Problema 3: Determinati daca n se divide cu k, unde n si k sunt date de intrare. ");
            Console.WriteLine();

            Console.WriteLine("Introduceti  valoarea n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti valoarea k: ");
            int k = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (n % k == 0)
            {
                Console.WriteLine($"{n} se divide cu {k}!");
            }
            else
            {
                Console.WriteLine($"{n} nu se divide cu {k}!");
            }
        }

        private static void problema2()
        {
        }

        private static void problema1()
        {
        }
    }
}
