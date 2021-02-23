using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            //Declaración de variables a usar.
            int l1, l2, l3, l4,sum,prod;

            
            int l = 1;

            for (int z = 0; z < l; z++)
            {
                try
                {
                    Console.WriteLine("\nDigite el primer numero.");
                    //Entrada de datos l1.
                    l1 = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("\nDigite el segundo numero.");
                    //Entrada de datos l1.
                    l2 = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("\nDigite el tercer numero.");
                    //Entrada de datos l1.
                    l3 = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("\nDigite el cuarto numero.");
                    //Entrada de datos l1.
                    l4 = Int32.Parse(Console.ReadLine());

                    sum = l1 + l2;
                    prod = l3 * l4;

                    Console.WriteLine($" \tLa suma del primer y segundo numero es de: {sum}");
                    Console.WriteLine($" \tEl producto del tercer y cuarto numero es de: {prod}");
                   


                }
                catch (Exception)
                {
                    l++;
                    Console.WriteLine($" \n\nPor favor ingrese un numero sin decimales");

                }

            }

            Console.ReadKey();
        }
    }
}
