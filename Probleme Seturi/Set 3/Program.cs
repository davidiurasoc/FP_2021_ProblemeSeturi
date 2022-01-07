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
