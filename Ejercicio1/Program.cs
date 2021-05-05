using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ejercicio 1
            Console.WriteLine("Hello world");
            Console.WriteLine("Hello C#");

            //ejercicio 2
            String myString = Console.ReadLine();
            String entrada = Console.ReadLine();
            int myInt = Convert.ToInt32(entrada);
            Console.WriteLine("My string: " + myString);
            Console.WriteLine("My int: " + entrada);

            //ejercicio 3
            Console.WriteLine("escribe un numero");
            int n = Int32.Parse(Console.ReadLine());
            if (n % 2 != 0) { Console.WriteLine("Weird"); }
            if (n % 2 == 0 && n > 2 && n < 5) { Console.WriteLine("Not Weird"); }
            if (n % 2 == 0 && n > 6 && n < 20) { Console.WriteLine("Weird"); }
            if (n % 2 == 0 && n > 20) { Console.WriteLine("Not Weird"); }

            //ejercicico 4
            int stInt = Int32.Parse(Console.ReadLine());
            double myDouble = double.Parse(Console.ReadLine());
            String cadena = Console.ReadLine();

            Console.WriteLine("String:" + cadena);
            Console.WriteLine("Double:" + myDouble);
            Console.WriteLine("int:" + stInt);

            //ejercicio 5
            String tam1 = Console.ReadLine();
            int tam2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine(tam1 + "" + tam2);

        }
    }
}
