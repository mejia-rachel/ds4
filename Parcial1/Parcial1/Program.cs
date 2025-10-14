using System;

class Program
{
    static void Main()
    {
        Random rnd = new Random();
        int Numerito;

        do
        {
            Console.Write("Ingrese un numero impar: ");
            Numerito = int.Parse(Console.ReadLine());
        } while (Numerito % 2 == 0);

        int[,] matriz = new int[Numerito, Numerito];
        int suma = 0;
        int centro = Numerito / 2;

        for (int i = 0; i < Numerito; i++)
        {
            for (int j = 0; j < Numerito; j++)
            {
                if (i == 0 || i == Numerito - 1 || j == centro)
                {
                    matriz[i, j] = rnd.Next(101, 201);
                    suma += matriz[i, j];
                }
                else
                {
                    matriz[i, j] = 0;
                }
                Console.Write($"{matriz[i, j],5}");
            }
            Console.WriteLine();
        }

        Console.WriteLine("La suma de todos los elementos aleatorios es: " + suma);
    }
}