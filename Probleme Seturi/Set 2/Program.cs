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
            // problema4(); // rezolvata
            // problema5(); // rezolvata
            // problema6(); // rezolvata
            // problema7(); // rezolvata
            // problema8(); // rezolvata
            // problema9(); // rezolvata
            // problema10();// rezolvata
            // problema11();
            // problema12(); // rezolvata
            // problema13();
        }

        private static void problema13()
        {
        }

        private static void problema12()
        {
            Console.WriteLine("Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere. ");
            Console.WriteLine("Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte. "); Console.WriteLine();
            
            Console.Write("Introduceti valoarea lui n: "); int n = int.Parse(Console.ReadLine());
            Console.Write("Introduceti un numar: "); int num = int.Parse(Console.ReadLine());
            int store = num;
            int group = 0;

            //1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0
            for (int i = 1; i < n; i++)
            {
                store = num;
                Console.Write("Introduceti un numar: "); num = int.Parse(Console.ReadLine());
                if (store > 0 && num == 0 || i == (n - 1) && num > 0)
                {
                    group++;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Sunt {group} grupuri de numere consecutive diferite de zero!");
        }

        private static void problema11()
        {
        }

        private static void problema10()
        {
            Console.WriteLine("Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa. ");
            Console.WriteLine();

            Console.Write("Introduceti lungimea secventei de numere: "); int n = int.Parse(Console.ReadLine());
            Console.Write("Introduceti un numar: "); int a = int.Parse(Console.ReadLine());
            int max = 1;
            int cnt = 1;

            for (int i = 1; i < n; i++)
            {
                int s = a;
                Console.Write("Introduceti un numar: "); int b = int.Parse(Console.ReadLine());
                if (b == a)
                {
                    cnt++;
                    if (cnt > max)
                    {
                        max = cnt;
                    }
                }
                else
                {
                    a = b;
                    cnt = 1;
                }
            }
            Console.WriteLine(max);
        }

        private static void problema9()
        {
            Console.WriteLine("Sa se determine daca o secventa de n numere este monotona. ");
            Console.WriteLine("Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare. ");
            Console.WriteLine();

            Console.Write("Introduceti lungimea secventei de numere: "); int n = int.Parse(Console.ReadLine());
            Console.Write("Introduceti un numar: "); int a = int.Parse(Console.ReadLine());
            int mDes = 1;
            int mCres = 1;
            
            for (int i = 2; i <= n; i++)
            {
                int s = a;
                Console.Write("Introduceti un numar: "); a = int.Parse(Console.ReadLine());
                if (a < s)
                {
                    mDes++;
                }
                else if (a > s)
                {
                    mCres++;
                }
            }
            Console.WriteLine();

            if (mDes == n)
            {
                Console.WriteLine("Secventa este monoton descrescatoare!");
            }
            else if (mCres == n)
            {
                Console.WriteLine("Secventa este monoton crescatoare!");
            }
            else
            {
                Console.WriteLine("Secventa nu este monotona");
            }
        }

        private static void problema8()
        {
            Console.WriteLine("Determianti al n-lea numar din sirul lui Fibonacci.");
            Console.WriteLine("Sirul lui Fibonacci se construieste astfel: f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2). Exemplu: 0, 1, 1, 2, 3, 5, 8 ...");
            Console.WriteLine();

            int n1 = 0, n2 = 1, n3 = 0;
            Console.Write("Introduceti un numar: "); int n = int.Parse(Console.ReadLine());
            //Console.Write(n1 + " " + n2 + " ");

            for (int i = 2; i < n; i++)
            {
                n3 = n1 + n2;
                //Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
            Console.WriteLine();
            Console.WriteLine($"Numarul al {n}-lea din sirul lui Fibonacci este: {n3}");
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
            Console.WriteLine("Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa.");
            Console.WriteLine("Se considera ca primul element din secventa este pe pozitia 0. "); Console.WriteLine();

            Console.Write("Introduceti valoarea lui n: "); int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int st = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Introduceti un numar: "); int num = int.Parse(Console.ReadLine());
                if (num == i)
                {
                    st++;
                    // Console.WriteLine("*");
                }
            }
            Console.WriteLine($"Sunt {st} elemente!");



        }

        private static void problema4()
        {
            Console.Write("Introduceti valoarea lui n: "); int n = int.Parse(Console.ReadLine());
            Console.Write("Introduceti valoarea lui a: "); int a = int.Parse(Console.ReadLine()); Console.WriteLine();
            int loc = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Introduceti un numar: "); int num = int.Parse(Console.ReadLine());
                if (loc == 0) // locul primului "a" care apare
                {
                    if (num == a)
                    {
                        loc = i;
                    }
                }
            }
            if (loc > 0)
            {
                Console.WriteLine($"Numarul {a} se afla pe pozitia {loc}!");
            }
            else
            {
                Console.WriteLine("-1");
            }
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
