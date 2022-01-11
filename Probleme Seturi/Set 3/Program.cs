using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set_3
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
            
        }

        private static void problema5()
        {
            Console.WriteLine("Se da un vector cu n elemente, o valoare e si o pozitie din vector k. Se cere sa se insereze valoarea e in vector pe pozitia k. Primul element al vectorului se considera pe pozitia zero. ");
            Console.WriteLine();
            Console.Write("Lungimea vectorului: "); int n = int.Parse(Console.ReadLine());
            Console.Write("Valoarea e: " ); int e = int.Parse(Console.ReadLine());
            Console.Write("Pozitia k: "); int k = int.Parse(Console.ReadLine()); Console.WriteLine();
            int[] v = new int[n];
            int eNumIndex = 0, kIndex = 0, kNumar = 0;

            for (int i = 0; i < v.Length; i++)
            {
                Console.Write("Introduceti un numar: "); v[i] = int.Parse(Console.ReadLine());
                if (v[i] == e)
                {
                    eNumIndex = i;
                }
                if (i == k)
                {
                    kIndex = i;
                    kNumar = v[i];
                }
            }
            Console.WriteLine();

            Console.Write("Acesta este vectorul neschimbat: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(v[i] + " ");
            }
            Console.WriteLine();

            v[kIndex] = e;
            v[eNumIndex] = kNumar;

            Console.Write("Acesta  este vectorul schimbat: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(v[i] + " ");
            }
            Console.WriteLine();
        }

        private static void problema4()
        {
            Console.WriteLine("Deteminati printr-o singura parcurgere cea mai mica si cea mai mare valoare dintr-un vector si de cate ori apar acestea");
            Console.WriteLine();

            Console.Write("Introduceti un numar: "); int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];

            Console.Write("Introduceti un numar: "); v[0] = int.Parse(Console.ReadLine());
            int min = v[0];
            int minC = 1;
            int max = v[0];
            int maxC = 1;

            for (int i = 1; i < n; i++)
            {
                Console.Write("Introduceti un numar: "); v[i] = int.Parse(Console.ReadLine());
                if (v[i] < min)
                {
                    min = v[i];
                }
                else if (v[i] == min)
                {
                    minC++;
                }
                else if (v[i] > max)
                {
                    max = v[i];
                }
                else if (v[i] == max)
                {
                    maxC++;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Cea mai mica valoare este {min} si apare de {minC} ori.");
            Console.WriteLine($"Cea mai mare valoare este {max} si apare de {maxC} ori.");
            Console.WriteLine();
        }

        private static void problema3()
        {
            Console.WriteLine("Sa se determine pozitiile dintr-un vector pe care apar cel mai mic si cel mai mare element al vectorului.");
            Console.WriteLine();

            Console.Write("Introduceti un numar: "); int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine();
            Console.Write("Introduceti un numar: "); v[0] = int.Parse(Console.ReadLine());
            int min = v[0];
            int minl = 0;
            int max = v[0];
            int maxl = 0;

            for (int i = 1; i < n; i++)
            {
                Console.Write("Introduceti un numar: "); v[i] = int.Parse(Console.ReadLine());
                if (min > v[i])
                {
                    min = v[i];
                    minl = i;
                }
                else if (max < v[i])
                {
                    max = v[i];
                    maxl = i;
                }
            }
            Console.WriteLine($"Pozitia pe care se afla cel mai mic numar al vectorului este: {minl}");
            Console.WriteLine($"Pozitia pe care se afla cel mai mare numar al vectorului este: {maxl}");
            Console.WriteLine();
            Console.WriteLine($" Min = {min}");
            Console.WriteLine($" Max = {max}");
            Console.WriteLine();
        }

        private static void problema2()
        {
            Console.WriteLine("Se da un vector cu n elemente si o valoare k. Se cere sa se determine prima pozitie din vector pe care apare k.");
            Console.WriteLine("Daca k nu apare in vector rezultatul va fi -1. ");
            Console.WriteLine();

            Console.Write("Introduceti un numar: "); int n = int.Parse(Console.ReadLine());
            Console.Write("Care numar il cautati: "); int k = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            bool b = false;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Introduceti un numar: "); v[i] = int.Parse(Console.ReadLine());
                if (v[i] == k)
                {
                    Console.WriteLine($"Numarul {k} se afla pe pozitia {i}.");
                    b = true;
                    break;
                }
                else if (b == false && i == n - 1)
                {
                    Console.WriteLine("-1");
                }
            }
        }

        private static void problema1()
        {
            Console.WriteLine("Calculati suma elementelor unui vector de n numere citite de la tastatura. Rezultatul se va afisa pe ecran.");
            Console.WriteLine();


            Console.Write("Introduceti un numar: "); int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int sum = 0;

            for (int i = 0; i < v.Length; i++)
            {
                Console.Write("Introduceti un numar: "); v[i] = int.Parse(Console.ReadLine());
                sum += v[i];
            }
            Console.WriteLine($"Suma celor {n} numere este: {sum}");
        }
    }
}
