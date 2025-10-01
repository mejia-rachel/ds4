using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== Cálculo del perímetro de un rectángulo ===");

        Console.Write("Introduce la base del rectángulo: ");
        int baseRectangulo = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduce la altura del rectángulo: ");
        int altura = Convert.ToInt32(Console.ReadLine());

        // Crear objeto de la clase
        CalculosMatematicos calculo = new CalculosMatematicos();

        int perimetro = calculo.CalcularPerimetroRectangulo(baseRectangulo, altura);

        Console.WriteLine($"\nEl perímetro del rectángulo es: {perimetro}");
    }
}

class CalculosMatematicos
{
    public int CalcularPerimetroRectangulo(int baseRectangulo, int altura)
    {
        return 2 * (baseRectangulo + altura);
    }
}
