using System;

namespace ejercicio2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.Clear();
            Console.Title = "Ejercicio 2";
            Double x, ang, resul1, resul2;

            Console.WriteLine("Digitar el radio:");
            x = Double.Parse(Console.ReadLine());

            Console.WriteLine("Digitar el angulo:");
            ang = Double.Parse(Console.ReadLine());

            resul1 = Desarrollo(x, '1');
            Console.WriteLine("El valor de x es: {0} ", resul1);

            resul2 = Desarrollo2(x, '2');
            Console.WriteLine("El valor de y es{0} ", resul2);


            Console.WriteLine("\n");
            Console.WriteLine("-->Fin del programa");
            Console.ReadKey();
        }
        static Double Desarrollo(Double px, Char pang)
        {
            Double resul1 = 0;

            resul1 = px * Math.Cos(pang);
            return resul1;

        }
        static Double Desarrollo2(Double px, Char pang)
        {
            Double resul2 = 0;

            resul2 = px * Math.Sin(pang);
            return resul2;

        }

    }
}