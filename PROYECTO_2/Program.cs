using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Elija el literal para convertir, 1.(HORAS A MINUTOS), 2.(HORAS A SEGUNDOS)");
            double conver = int.Parse(Console.ReadLine());

            if (conver == 1)
            {
                Console.Write("Escriba las horas que desea convertir: ");
                double horas = int.Parse(Console.ReadLine());
                double convertirm = (horas * 60);

                Console.Write($"En {horas} horas, hay {convertirm} minutos");
                Console.ReadKey();
            }
            else
            {
                Console.Write("Escriba las horas que desea convertir: ");
                double hora = double.Parse(Console.ReadLine());
                double convertirs = (hora * 3600);

                Console.Write($"En {hora} horas, hay {convertirs} segundos");
                Console.ReadKey();
            }
        }
    }
}