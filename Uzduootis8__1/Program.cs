using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis8_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            int num, product;
            Console.Write("Įveskite skaičių ir atspausdinkite jo daugybos lentelę: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nSkaičiaus daugybos lentelė yra {0}: ", num);
            for (int i = 1; i <= 10; i++)
            {
                product = num * i;
                Console.WriteLine("{0} x {1} = {2}", num, i, product);
            }


            Console.ReadLine();
            //Console.ReadKey();
        }
    }
}

