using System;

namespace Ejercicio_3
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.Write("Area Y Volumen De Un Cilindro, presiona 1 para continuar");
            int stop = int.Parse(Console.ReadLine());


            do
            {
                Console.WriteLine("Ingresa el valor de radio: ");
                double radio = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingresa el valor de altura:");
                double altura = double.Parse(Console.ReadLine());

                double R = (radio + altura);
                double area = (3.1416 * 2) * R;
                double volumen = 3.1416 * (R * 2) * altura;

                Console.Write("El area del cilindro es: {0} cm2 y el volumen es: {1} cm2 ", volumen, area);
                Console.Write("Presiona 0 para finalizar");
            }
            while (stop == 0);
        }
    }
}