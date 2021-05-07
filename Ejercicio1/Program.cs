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
            /* //ejercicio 1
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
             Console.WriteLine("escribe una enter, un double y una cademna");
             int stInt = Int32.Parse(Console.ReadLine());
             double myDouble = double.Parse(Console.ReadLine());
             String cadena = Console.ReadLine();

             Console.WriteLine("String:" + cadena);
             Console.WriteLine("Double:" + myDouble);
             Console.WriteLine("int:" + stInt);

             //ejercicio 5
             Console.WriteLine("escribe tres entradas");
             for (int i = 0; i < 3; i++)
             {
                 String tam1 = Console.ReadLine();
                 int tam2 = Int32.Parse(Console.ReadLine());
                 if (Convert.ToString(tam2).Length == 3)
                 {
                     Console.WriteLine(tam1 + "  " + tam2);
                 }else if (Convert.ToString(tam2).Length < 3)
                 {
                     Console.WriteLine(tam1 + "  " + "0"+ tam2);
                 }
             }

             // ejercicion 6
             Console.WriteLine("dame un numero ");
             int var = Int32.Parse(Console.ReadLine());
             for (int i =1; i <= 10; i++)
             {
                 Console.WriteLine(var +"*"+ i+":"  +(var*i));
             }

             //ejercicio 7
             Console.WriteLine("dame un numero de repeticiones : ");
             int seq = Int32.Parse(Console.ReadLine());
             for (int i = 0; i < seq; i++)

             {
                 int aux = 1;
                 Console.WriteLine("dame tres numeros : ");
                 int a = Int32.Parse(Console.ReadLine());
                 int b = Int32.Parse(Console.ReadLine());
                 int n = Int32.Parse(Console.ReadLine());
                 for (int j = 0; j < n; j++)
                 {
                     a = a + (b * aux);
                     Console.WriteLine(a);
                     aux=aux * 2;
                 }

             }


            //ejercicio 8

            Console.WriteLine("dame un numero de solicitudes : ");
            int repeticiones = Convert.ToInt32(Console.ReadLine());
            for (int x = 0; x < repeticiones; x++)
            {
                long y = long.Parse(Console.ReadLine());
                Console.WriteLine("puede concvertirse en  : ");
                if (y>=-128 && y<= 127) { Console.WriteLine("* sbyte"); }
                else if (y >= 0 && y <= 255) { Console.WriteLine("* byte"); }
                else if (y >= -32768 && y <= 32767) { Console.WriteLine("* short"); }
                else if (y >= -2147483648 && y <= 2147483647) { Console.WriteLine("* int"); }
                else if (y >= -9223372036854775808 && y <= 9223372036854775807) { Console.WriteLine("* Long"); }
                else { Console.WriteLine("* No se puede converitr"); }
            }          
            //ejercicio 9
            int x = 0;
            while (x < 3) { 
                String st = Console.ReadLine();
                Console.WriteLine(x+st);
                x++;
            }*/


            //ejercicio 10
            double B = 10;
            double h = 2;
            double area = B * h;
            Console.WriteLine(area);
;


        }
    }
}
