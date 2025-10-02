using System;

class Program
{
    public static void Main()
    {
        Aleatorios aleatorio = new Aleatorios();


        int numero = aleatorio.randomNumero(1, 10);
        Console.WriteLine("Dame un numero aleatorio entre 1 y 10: " + numero);


        int[] arreglo = aleatorio.GenerarArreglo(5, 50, 100);
        Console.WriteLine("Arreglo de 5 números aleatorios entre 50 y 100:");
        for (int i = 0; i < arreglo.Length; i++)
        {
            Console.Write(arreglo[i] + " ");
        }
        Console.WriteLine();
    }
    public class Aleatorios
    {

    public Random random;


    public Aleatorios()
    {
        random = new Random();
    }


    public int randomNumero(int min, int max)
    {
        return random.Next(min, max + 1);
    }


    public int[] GenerarArreglo(int cantidad, int min, int max)
    {
        int[] arreglo = new int[cantidad];
        for (int i = 0; i < cantidad; i++)
        {
            arreglo[i] = randomNumero(min, max);
        }
        return arreglo;
    }
}

}
