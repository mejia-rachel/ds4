using System;

class Program
{
    static void Main()
    {
        Aleatorios a = new Aleatorios();

        int minimo = 1;
        int maximo = 20;
        int c = 10;

        if (c > (maximo - minimo + 1))
        {
            Console.WriteLine("No se puede generar esa cantidad de números únicos en el rango indicado.");
            return;
        }

        int[] n = new int[c];
        int rache = 0;

        while (rache < c)
        {
            int num = a.randomNum(minimo, maximo);
            bool repetido = false;


            for (int i = 0; i < rache; i++)
            {
                if (n[i] == num)
                {
                    repetido = true;
                    break;
                }
            }

            if (!repetido)
            {
                n[rache] = num;
                rache++;
            }
        }

        Console.WriteLine("Arreglo de números no repetidos:");
        for (int i = 0; i < n.Length; i++)
        {
            Console.Write(n[i] + " ");
        }
        Console.WriteLine();
    }
}

public class Aleatorios
{

    private Random rnd;


    public Aleatorios()
    {
        rnd = new Random();
    }


    public int randomNum(int minimo, int max)
    {
        return rnd.Next(minimo, max + 1);
    }


    public int[] randomArreglo(int c, int minimo, int maximo)
    {
        int[] arreglo = new int[c];
        for (int i = 0; i < c; i++)
        {
            arreglo[i] = randomNum(minimo, maximo);
        }
        return arreglo;
    }
}
