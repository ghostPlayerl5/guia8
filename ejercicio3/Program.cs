using System;

namespace ejercicio3
{
    class MainClass
    {
        static void Main(string[] args)
        {

            double resul1, resul2, resul3;

            ConsoleKeyInfo op;
            Console.Title = "Ejercicio 3";

            do
            {
                Console.Clear();
                Console.WriteLine("\t\t\t\t MENU\n");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("[A]dividir \t");
                Console.Write("[B]obtener cubo\t");
                Console.Write("[C]calcular IMC\t");
                Console.Write("[Esc]Salir\t\n\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Elige una de las opciones......");
                op = Console.ReadKey(true);
                switch (op.Key)
                {
                    case ConsoleKey.A:

                        double div1, div2;

                        Console.WriteLine("Ingrese el primer numero:");
                        div1 = double.Parse(Console.ReadLine());

                        Console.WriteLine("ingrese el segundo numero");
                        div2 = double.Parse(Console.ReadLine());

                        resul1 = Desarrollo(div1, div2);
                        Console.WriteLine("El resultado de la divisiòn es de: {0}", resul1);
                        Console.ReadKey();
                        break;

                    case ConsoleKey.B:

                        double cub;
                        Console.WriteLine("ingrese el valor que desea al cubo:");
                        cub = double.Parse(Console.ReadLine());

                        resul2 = Desarrollo2(cub);
                        Console.WriteLine("El numero {0} al cubo es: {1}", cub, resul2);
                        Console.ReadKey();
                        break;

                    case ConsoleKey.C:
                        double peso, alt;
                        Console.WriteLine("Ingrese su peso (en kilogramos)");
                        peso = double.Parse(Console.ReadLine());
                        Console.WriteLine("ingrese su altura");
                        alt = double.Parse(Console.ReadLine());

                        resul3 = Desarrollo3(peso, alt);
                        Console.WriteLine("su IMC es de {0}", resul3);
                        Console.ReadKey();
                        break;

                    case ConsoleKey.Escape:
                        Console.Write("Arrivederci :D");
                        Console.ReadKey();
                        break;

                }
            }
            while (op.Key != ConsoleKey.Escape);

        }
        static Double Desarrollo(Double div1, Double div2)
        {
            Double resul1 = 0;

            resul1 = div2 * div1;

            return resul1;

        }
        static Double Desarrollo2(Double cub)
        {
            Double resul2 = 0;

            resul2 = Math.Pow(cub, 3);
            return resul2;

        }
        static Double Desarrollo3(Double peso, Double alt)
        {
            Double resul3 = 0;

            resul3 = peso / Math.Pow(alt, 2);

            return resul3;

        }

    }

}
