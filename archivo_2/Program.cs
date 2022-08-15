using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Contador = 0, Base_t = 0, Altura_t = 0;

            double Area = 0;
            //Calcular el area de un triangulo
            Console.Write("Ingrese de cuantos triangulos desea sacar el area : ");
            int Veces = int.Parse(Console.ReadLine());
            for (int i = 1; 1 <= Veces; i++)
            {
                Contador = i;
                {
                    Console.WriteLine("Ingrese la base del triangulo ");
                    Base_t = int.Parse(Console.ReadLine());

                    {
                        Console.WriteLine("Ingrese la altura del triangulo ");
                        Altura_t = int.Parse(Console.ReadLine());

                        {
                            Area = (Base_t * Altura_t) / 2;
                        }
                        Console.WriteLine("El area del triangulo" + i + " es: " + Area);

                    }

                }
            }
        }

    }
}