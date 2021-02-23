using System;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            //Declaración de variables a usar.
            double desc = 0, isss = 0.0525, AFP = 0.0688, rent = 0.1;
            string nb = "NO HAY BONO";
            //Empleado 1
            string nom1 = null, ap1 = null, carg1 = null;
            int car1 = 0;
            double dISS1 = 0, dAFP1 = 0, dRent1 = 0;
            double hTm1 = 0, b1 = 0, sB1 = 0, sl1 = 0;

            //Empleado 2
            string nom2 = null, ap2 = null, carg2 = null;
            int car2 = 0;
            double dISS2, dAFP2, dRent2;
            double hTm2 = 0, b2 = 0, sB2 = 0, sl2 = 0;

            //Empleado 3
            string nom3 = null, ap3 = null, carg3 = null;
            int car3 = 0;
            double dISS3, dAFP3, dRent3;
            double hTm3 = 0, b3 = 0, sB3 = 0, sl3 = 0;


            //Contadores for
            int l = 1;
            int lt = 1;

            
            for (int z = 0; z < l; z++)
            {
                try
                {
                    //Datos empleado 1
                    Console.WriteLine("\n\tEmpleado #1.");
                    for (int i = 0; i < lt; i++)
                    {
                        Console.WriteLine("\nNombres del empleado: ");
                        //Entrada de datos l1.
                        nom1 = Console.ReadLine();

                        Console.WriteLine("\nApellidos del empleado: ");
                        //Entrada de datos l1.
                        ap1 = Console.ReadLine();

                        Console.WriteLine("\nCargo del empleado ");
                        Console.WriteLine("\nIngrese el numero de la siguientes opciones: ");
                        Console.WriteLine("\n\t1) Gerente");
                        Console.WriteLine("\n\t2) Asistente");
                        Console.WriteLine("\n\t3) Secretaria");
                        Console.WriteLine("\n\t4) Otros");
                        //Entrada de datos l1.
                        car1 = Int32.Parse(Console.ReadLine());
                        if (car1 >= 1 && car1 <= 4)
                        {
                            Console.WriteLine("\nHoras trabajadas del empleado: ");
                            //Entrada de datos l1.
                            hTm1 = Double.Parse(Console.ReadLine());

                            if (hTm1 <= 0)
                            {
                                Console.WriteLine("\nIngrese horas trabajadas no menores a 1h");

                                lt++;
                            }
                            else
                            {

                                lt = 1;
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nIngrese las opcions validas de 1 a 4");

                            lt++;

                        }



                    }

                    //Datos empleado 2
                    Console.WriteLine("\n\tEmpleado #2.");
                    for (int i = 0; i < lt; i++)
                    {
                        Console.WriteLine("\nNombres del empleado: ");
                        //Entrada de datos l1.
                        nom2 = Console.ReadLine();

                        Console.WriteLine("\nApellidos del empleado: ");
                        //Entrada de datos l1.
                        ap2 = Console.ReadLine();

                        Console.WriteLine("\nCargo del empleado ");
                        Console.WriteLine("\nIngrese el numero de la siguientes opciones: ");
                        Console.WriteLine("\n\t1) Gerente");
                        Console.WriteLine("\n\t2) Asistente");
                        Console.WriteLine("\n\t3) Secretaria");
                        Console.WriteLine("\n\t4) Otros");
                        //Entrada de datos l1.
                        car2 = Int32.Parse(Console.ReadLine());
                        if (car2 >= 1 && car2 <= 4)
                        {
                            Console.WriteLine("\nHoras trabajadas del empleado: ");
                            //Entrada de datos l1.
                            hTm2 = Double.Parse(Console.ReadLine());

                            if (hTm2 <= 0)
                            {
                                Console.WriteLine("\nIngrese horas trabajadas no menores a 1h");

                                lt++;
                            }
                            else
                            {

                                lt = 1;
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nIngrese las opcions validas de 1 a 4");

                            lt++;

                        }


                    }

                    //Datos empleado 3
                    Console.WriteLine("\n\tEmpleado #3.");
                    for (int i = 0; i < lt; i++)
                    {
                        Console.WriteLine("\nNombres del empleado: ");
                        //Entrada de datos
                        nom3 = Console.ReadLine();

                        Console.WriteLine("\nApellidos del empleado: ");
                        //Entrada de datos
                        ap3 = Console.ReadLine();

                        Console.WriteLine("\nCargo del empleado ");
                        Console.WriteLine("\nIngrese el numero de la siguientes opciones: ");
                        Console.WriteLine("\n\t1) Gerente");
                        Console.WriteLine("\n\t2) Asistente");
                        Console.WriteLine("\n\t3) Secretaria");
                        Console.WriteLine("\n\t4) Otros");
                        //Entrada de datos
                        car3 = Int32.Parse(Console.ReadLine());
                        if (car3 >= 1 && car3 <= 4)
                        {
                            Console.WriteLine("\nHoras trabajadas del empleado: ");
                            //Entrada de datos
                            hTm3 = Double.Parse(Console.ReadLine());

                            if (hTm3 <= 0)
                            {
                                Console.WriteLine("\nIngrese horas trabajadas no menores a 1h");

                                lt++;
                            }
                            else
                            {

                                lt = 1;
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nIngrese las opcions validas de 1 a 4");

                            lt++;

                        }


                    }

                    //----------------Sueldo base y Sueldo liquido
                    //Empleado 1
                    //Sueldo Base
                    if (hTm1 <= 160)
                    {
                        sB1 = Math.Round((hTm1 * 9.75),2);
                    }
                    else
                    {
                        double hex1;

                        hex1 = hTm1 - 160;
                        sB1 = Math.Round((hTm1 * 9.75), 2) + Math.Round((hex1 * 11.5), 2); 


                    }
                    //Sueldo Liquido
                    dISS1 = sB1 * isss;
                    dAFP1 = sB1 * AFP;
                    dRent1 = sB1 * rent;
                    desc = Math.Round(dISS1,2) + Math.Round(dAFP1,2) + Math.Round(dRent1,2);
                    sl1 = sB1 - desc;

                    //Bono

                    if (car1 == 1)
                    {
                        b1 = sl1 * 0.10;
                        carg1 = "Gerente";
                    }
                    else if (car1 == 2)
                    {
                        b1 = sl1 * 0.05;
                        carg1 = "Asistente";
                    }
                    else if (car1 == 3)
                    {
                        b1 = sl1 * 0.03;
                        carg1 = "Secretaria";
                    }
                    else if (car1 == 4)
                    {
                        b1 = sl1 * 0.02;
                        carg1 = "Otros";
                    }

                    //Empleado 2
                    if (hTm2 <= 160)
                    {
                        sB2 = Math.Round((hTm2 * 9.75),2);
                    }
                    else
                    {
                        double hex2;

                        hex2 = hTm2 - 160;
                        sB2 = Math.Round((hTm2 * 9.75), 2) + Math.Round((hex2 * 11.5), 2);

                    }
                    //Sueldo Liquido
                    dISS2 = sB2 * isss;
                    dAFP2 = sB2 * AFP;
                    dRent2 = sB2 * rent;
                    desc = Math.Round(dISS2,2) + Math.Round(dAFP2,2) + Math.Round(dRent2,2);
                    sl2 = sB2 - desc;
                    //Bono
                    if (car2 == 1)
                    {
                        b2 = sl2 * 0.10;
                        carg2 = "Gerente";
                    }
                    else if (car2 == 2)
                    {
                        b2 = sl2 * 0.05;
                        carg2 = "Asistente";
                    }
                    else if (car2 == 3)
                    {
                        b2 = sl2 * 0.03;
                        carg2 = "Secretaria";
                    }
                    else if (car2 == 4)
                    {
                        b2 = sl2 * 0.02;
                        carg2 = "Otros";
                    }

                    //Empleado 3
                    if (hTm3 <= 160)
                    {
                        sB3 = Math.Round((hTm3 * 9.75),2);
                    }
                    else
                    {
                        double hex3;

                        hex3 = hTm3 - 160;
                        sB3 = Math.Round((hTm3 * 9.75),2) + Math.Round((hex3 * 11.5),2);

                    }
                    //Sueldo Liquido
                    dISS3 = sB3 * isss;
                    dAFP3 = sB3 * AFP;
                    dRent3 = sB3 * rent;
                    desc = Math.Round(dISS3,2) + Math.Round(dAFP3,2) + Math.Round(dRent3,2);
                    sl3 = sB3 - desc;

                    //Bono
                    if (car3 == 1)
                    {
                        b3 = sl3 * 0.10;
                        carg3 = "Gerente";
                    }
                    else if (car3 == 2)
                    {
                        b3 = sl3 * 0.05;
                        carg3 = "Asistente";
                    }
                    else if (car3 == 3)
                    {
                        b3 = sl3 * 0.03;
                        carg3 = "Secretaria";
                    }
                    else if (car3 == 4)
                    {
                        b3 = sl3 * 0.02;
                        carg3 = "Otros";
                    }

                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Green;
                    
                    //Impresion de datos
                    //Empleado 1
                    Console.WriteLine("\n/----------------------------Datos----------------------------");
                    Console.WriteLine("\n/*************************************************************");
                    Console.WriteLine("\n\t\t--Empleado # 1--");
                    Console.WriteLine($"\n\tNombre completo: {nom1} {ap1}");
                    Console.WriteLine($"\n\tCargo: {carg1}");
                    Console.WriteLine($"\n\t\t--Descuentos--");
                    Console.WriteLine($"\n\tISSS: ${dISS1}");
                    Console.WriteLine($"\n\tAFP: ${dAFP1}");
                    Console.WriteLine($"\n\tRenta: ${dRent1}");
                    Console.WriteLine($"\n\tSueldo Liquido: ${sl1}");
                    Console.WriteLine("\n/*************************************************************");

                    //Empleado 2             
                    Console.WriteLine("\n\t\t--Empleado # 2--");
                    Console.WriteLine($"\n\tNombre completo: {nom2} {ap2}");
                    Console.WriteLine($"\n\tCargo: {carg2}");
                    Console.WriteLine($"\n\t\t--Descuentos--");
                    Console.WriteLine($"\n\tISSS: ${dISS2}");
                    Console.WriteLine($"\n\tAFP: ${dAFP2}");
                    Console.WriteLine($"\n\tRenta: ${dRent2}");
                    Console.WriteLine($"\n\tSueldo Liquido: ${sl2}");
                    Console.WriteLine("\n/*************************************************************");

                    //Empleado 3             
                    Console.WriteLine("\n\t\t--Empleado # 3--");
                    Console.WriteLine($"\n\tNombre completo: {nom3} {ap3}");
                    Console.WriteLine($"\n\tCargo: {carg3}");
                    Console.WriteLine($"\n\t\t--Descuentos--");
                    Console.WriteLine($"\n\tISSS: ${dISS3}");
                    Console.WriteLine($"\n\tAFP: ${dAFP3}");
                    Console.WriteLine($"\n\tRenta: ${dRent3}");
                    Console.WriteLine($"\n\tSueldo Liquido: ${sl3}");
                    Console.WriteLine("\n/*************************************************************");

                    //Bonos
                    Console.WriteLine("\n\t\t--->Bonos<---");
                    if (car1 == 1 && car2 == 2 && car3 == 3)
                    {
                        Console.WriteLine($"\n\t\t\a{nb}");
                        Console.WriteLine("\n/*************************************************************");
                    }
                    else
                    {
                        Console.WriteLine("\n\t\t--Empleado # 1--");
                        Console.WriteLine($"\n\tBono: ${Math.Round(b1,2)}");
                        Console.WriteLine("\n/*************************************************************");
                        Console.WriteLine("\n\t\t--Empleado # 2--");
                        Console.WriteLine($"\n\tBono: ${Math.Round(b2,2)}");
                        Console.WriteLine("\n/*************************************************************");
                        Console.WriteLine("\n\t\t--Empleado # 3--");
                        Console.WriteLine($"\n\tBono: ${Math.Round(b3,2)}");
                        Console.WriteLine("\n/*************************************************************");
                    }

                    //Empleado mayor
                    Console.WriteLine("\n\t\t--->Empleado con mayor salario<---");
                    if (sl1 < sl2)
                    {
                        if (sl2 < sl3)
                        {
                            Console.WriteLine("\n\t\t--Empleado # 3--");
                            Console.WriteLine($"\n\tSueldo Liquido: ${sl3}");
                            Console.WriteLine("\n/*************************************************************");

                        }
                        else
                        {
                            Console.WriteLine("\n\t\t--Empleado # 2--");
                            Console.WriteLine($"\n\tSueldo Liquido: ${sl2}");
                            Console.WriteLine("\n/*************************************************************");
                        }
                            
                    }
                    else if (sl1 > sl2)
                    {
                        if (sl1 < sl3)
                        {
                            Console.WriteLine("\n\t\t--Empleado # 3--");
                            Console.WriteLine($"\n\tSueldo Liquido: ${sl2}");
                            Console.WriteLine("\n/*************************************************************");
                        }
                        else
                        {
                            Console.WriteLine("\n\t\t--Empleado # 1--");
                            Console.WriteLine($"\n\tSueldo Liquido: ${sl1}");
                            Console.WriteLine("\n/*************************************************************");
                        }
                            
                    }

                    //Empleado menor
                    Console.WriteLine("\n\t\t--->Empleado con menor salario<---");
                    if (sl1 > sl2)
                    {
                        if (sl2 > sl3)
                        {
                            Console.WriteLine("\n\t\t--Empleado # 3--");
                            Console.WriteLine($"\n\tSueldo Liquido: ${sl3}");
                            Console.WriteLine("\n/*************************************************************");

                        }
                        else
                        {
                            Console.WriteLine("\n\t\t--Empleado # 2--");
                            Console.WriteLine($"\n\tSueldo Liquido: ${sl2}");
                            Console.WriteLine("\n/*************************************************************");
                        }

                    }
                    else if (sl1 < sl2)
                    {
                        if (sl1 > sl3)
                        {
                            Console.WriteLine("\n\t\t--Empleado # 3--");
                            Console.WriteLine($"\n\tSueldo Liquido: ${sl3}");
                            Console.WriteLine("\n/*************************************************************");
                        }
                        else
                        {
                            Console.WriteLine("\n\t\t--Empleado # 1--");
                            Console.WriteLine($"\n\tSueldo Liquido: ${sl1}");
                            Console.WriteLine("\n/*************************************************************");
                        }

                    }

                    //Empleados que ganan mas de $300
                    Console.WriteLine("\n\t\t--->Empleados que ganan mas de $300<---");
                    //Empleado 1
                    if (sl1 >= 300)
                    {
                        Console.WriteLine("\n\t\t--Empleado # 1--");
                        Console.WriteLine($"\n\tSueldo Liquido: ${sl1}");
                        Console.WriteLine("\n/*************************************************************");
                    }
                    //Empleado 2
                    if (sl2 >= 300)
                    {
                        Console.WriteLine("\n\t\t--Empleado # 2--");
                        Console.WriteLine($"\n\tSueldo Liquido: ${sl2}");
                        Console.WriteLine("\n/*************************************************************");
                    }
                    //Empleado 3
                    if (sl3 >= 300)
                    {
                        Console.WriteLine("\n\t\t--Empleado # 3--");
                        Console.WriteLine($"\n\tSueldo Liquido: ${sl3}");
                        Console.WriteLine("\n/*************************************************************");
                    }




                }
                catch (Exception)
                {
                    l++;
                    Console.WriteLine($" \n\nPor favor ingrese numeros en los campos que corresponden.");

                }

            }

            Console.ReadKey();
        }
    }
}
