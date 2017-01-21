using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema5
{
    class Program
    {
        static void Main(string[] args)
        {
            String palabra1, palabra2;
            Console.WriteLine("Escriba una palabra: ");
            palabra1 = Console.ReadLine();
            Console.WriteLine("Escriba otra palabra");
            palabra2 = Console.ReadLine();

            if(palabra1[0] < palabra2[0])
                Console.WriteLine(palabra1);
            else
                Console.WriteLine(palabra2);

            Console.ReadKey();
        }
    }
}
