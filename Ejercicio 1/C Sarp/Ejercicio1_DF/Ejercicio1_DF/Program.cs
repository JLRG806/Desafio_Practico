using System;


namespace Ejercicio1_DF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();

            //Declaración de variables a usar.           
            double pArt, cCli, cPag;
            int l = 1;

            for (int z = 0; z < l; z++)
            {
                try
                {
                    Console.WriteLine("\nDigite el precio del articulo.");
                    //Entrada de datos pArt.
                    pArt = Double.Parse(Console.ReadLine());

                    Console.WriteLine("\nDigite la cantidad que lleva el cliente.");
                    //Entrada de datos cCli.
                    cCli = Double.Parse(Console.ReadLine());


                    cPag = pArt * cCli;



                    Console.WriteLine($" \n\nPor {cCli} articulos, el cliende debe pagar ${cPag}.");



                }
                catch (Exception)
                {
                    l++;
                    Console.WriteLine($" \n\nPor favor ingrese un numero");

                }

            }

            Console.ReadKey();
        }
    }
}
