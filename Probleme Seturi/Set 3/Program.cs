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
            Console.WriteLine();
            Console.WriteLine("Problema 5: Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga. ");
            Console.WriteLine();

            Console.WriteLine("Introduceti un numar: "); int num = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int szr = 1;
            int rez = 0;

            if (k == 1)
            {
                rez = num % 10;
                Console.WriteLine(rez);
            }
            /*else if (k == 2)
            {
                rez = num / szr;
                rez = rez % 10;
                Console.WriteLine(rez);
            }*/
            else if (k > 1)
            {
                for (int i = 2; i <= k; i++)
                {
                    szr = szr * 10;
                    rez = num / szr;
                    rez = rez % 10;
                }
                Console.WriteLine(rez);
            }
        }
    }
}
