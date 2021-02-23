using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            //Declaración de variables a usar.
            double n1, n2, n3, prom;


            int l = 1;

            for (int z = 0; z < l; z++)
            {
                try
                {
                    Console.WriteLine("\nDigite la primera nota.");
                    //Entrada de datos l1.
                    n1 = Double.Parse(Console.ReadLine());

                    Console.WriteLine("\nDigite la segunda nota.");
                    //Entrada de datos l1.
                    n2 = Double.Parse(Console.ReadLine());

                    Console.WriteLine("\nDigite la tercera nota.");
                    //Entrada de datos l1.
                    n3 = Double.Parse(Console.ReadLine());

                    prom = (n1 + n2 + n3) / 3;


                    if (n1 > 10 || n2 > 10 || n3 > 10)
                    {
                        Console.WriteLine($" \tIngrese numeros del 0 al 10");
                    }
                    else if(prom >= 7)
                    {
                        Console.WriteLine($" \tEl alumno esta promocionado ({Math.Round(prom,2)}).");
                    }
                    else
                    {
                        if (prom >= 4)
                        {
                            Console.WriteLine($" \tEl alumno esta regular ({Math.Round(prom, 2)}).");
                        }
                        else
                        {
                            Console.WriteLine($" \tEl alumno esta reprobado ({Math.Round(prom, 2)}).");
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
