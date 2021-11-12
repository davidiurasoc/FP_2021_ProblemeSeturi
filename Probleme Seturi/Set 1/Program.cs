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
            // problema1();  rezolvata
            // problema2();
            // problema3();  //rezolvata
            // problema4();  //rezolvata
            // problema5();
            // problema6();
            // problema7();  //rezolvata
            // problema8();  //rezolvata
            // problema9();  //rezolvata
            // problema10(); //rezolvata
            // problema11();
            // problema12();
            problema13();
        }

        private static void problema13()
        {
            Console.WriteLine();
            Console.WriteLine("Problema 13: Determianti cati ani bisecti sunt intre anii y1 si y2.");
            Console.WriteLine();

            Console.Write("Introduceti un numar: "); int y1 = int.Parse(Console.ReadLine());
            Console.Write("Introduceti un numar: "); int y2 = int.Parse(Console.ReadLine());
        }

        private static void problema12()
        {
        }

        private static void problema11()
        {
        }

        private static void problema10()
        {
            Console.WriteLine();
            Console.WriteLine("Problema 10: Test de primalitate: determinati daca un numar n este prim. ");
            Console.WriteLine();
            
            Console.WriteLine("Introduceti un numar: "); int n = int.Parse(Console.ReadLine());
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

            Console.WriteLine("Introduceti un numar:"); int n = int.Parse(Console.ReadLine());

            Console.WriteLine();
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                    Console.Write(i + " ");
            }
        }

        private static void problema8()
        {
            Console.WriteLine();
            Console.WriteLine("Problema 8: (Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. ");
            Console.WriteLine("Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare. ");
            Console.WriteLine();

            Console.Write("Introduceti valoarea lui a : ");  int a = int.Parse(Console.ReadLine());
            Console.Write("Introduceti valoarea lui b : ");  int b = int.Parse(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
        }

        private static void problema7()
        {
            Console.WriteLine();
            Console.WriteLine("Problema 7: (Swap) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. ");
            Console.WriteLine("Se cere sa se inverseze valorile lor. ");
            Console.WriteLine();

            Console.WriteLine("Introduceti valoarea a : "); int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti valoarea b : "); int b = int.Parse(Console.ReadLine()); 
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

            Console.Write("Introduceti valoarea numar: "); int numar = int.Parse(Console.ReadLine()); // 12345
            Console.Write("Introduceti valoarea k: "); int k = int.Parse(Console.ReadLine()); // 4

        }

        private static void problema4()
        {
            Console.WriteLine();
            Console.Write("Problema 4: Detreminati daca un an y este an bisect. ");
            Console.WriteLine();

            Console.Write("Introduceti valoarea y:"); int y = int.Parse(Console.ReadLine());
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

            Console.Write("Introduceti  valoarea n: "); int n = int.Parse(Console.ReadLine());
            Console.Write("Introduceti valoarea k: "); int k = int.Parse(Console.ReadLine());

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
            Console.WriteLine();
            Console.WriteLine("Problema 1: Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax + b = 0, unde a si b sunt date de intrare. ");
            Console.WriteLine();

            int a, b, x;
            Console.Write("Introduceti valoare lui a: "); a = int.Parse(Console.ReadLine());
            Console.Write("Introduceti valoare lui b: "); b = int.Parse(Console.ReadLine());

            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Exista o infinitate de solutii!");
                }
                else
                {
                     Console.WriteLine();
                     Console.WriteLine("Ecuatie nu se poate rezolva!");
                }
                }
                else
                {
                    Console.WriteLine();
                    x = -b / a;
                    Console.WriteLine($"Solutia ecuatiei este {x}");
            }
        }
    }
}
