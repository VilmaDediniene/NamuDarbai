using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.Write("Įveskite savo vardą: ");
            string ivedimas = Console.ReadLine();
            Console.Write("Įveskite savo amžių: ");
            int amzius = int.Parse(Console.ReadLine());
            Console.WriteLine($"Jūsų vardas: " + ivedimas + ", o amžius " + amzius);
            Console.ReadLine();
        }
    }
}
