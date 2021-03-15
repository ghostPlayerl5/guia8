using System;

namespace ejercicio1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Inicia el programa principal
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.Title = "Ejercicio 1";
            Double edad, result;

            Console.WriteLine("Digitar año de nacimiento");
            edad = Double.Parse(Console.ReadLine());

            result = Desarrollo(edad);
            Console.WriteLine("tienes {0} años de edad", result);

            Console.WriteLine("\n");
            Console.WriteLine("-->Fin del programa");
            Console.ReadKey();
        }

        static Double Desarrollo(Double pedad)
        {
            Double result = 0;

            result = 2021-pedad;


            return result;
        }

    }



}
