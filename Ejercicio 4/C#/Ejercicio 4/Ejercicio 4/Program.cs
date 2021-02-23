using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            //Declaración de variables a usar.
            int n1, n2, n3;


            int l = 1;

            for (int z = 0; z < l; z++)
            {
                try
                {
                    Console.WriteLine("\nDigite el primer.");
                    //Entrada de datos l1.
                    n1 = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("\nDigite el segundo numero.");
                    //Entrada de datos l1.
                    n2 = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("\nDigite el tercer numero.");
                    //Entrada de datos l1.
                    n3 = Int32.Parse(Console.ReadLine());


                    if (n1 > n2 && n1 > n3)
                    {
                        Console.WriteLine($" \n\tEl primer numero es mayor.");
                    }
                    else
                    {
                        if (n2 > n3)
                        {
                            Console.WriteLine($" \n\tEl segundo numero es mayor.");
                        }
                        else
                        {
                            Console.WriteLine($" \n\tEl tercer numero es mayor.");
                        }
                    }


                }
                catch (Exception)
                {
                    l++;
                    Console.WriteLine($" \n\nPor favor ingrese un numero sin decimales.");

                }

            }

            Console.ReadKey();
        }
    }
}
