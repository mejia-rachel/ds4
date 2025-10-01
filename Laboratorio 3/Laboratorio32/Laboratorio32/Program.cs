using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== Cálculo del área de un círculo ===");

        Console.Write("Introduce el radio del círculo: ");
        double radio = Convert.ToDouble(Console.ReadLine());

        // Crear el objeto de la clase
        CalculosMatematicos calculo = new CalculosMatematicos();

        double area = calculo.CalculoArea(radio);

        Console.WriteLine("El área del círculo con radio {0} es: {1:F2}", radio, area);
    }
}

class CalculosMatematicos
{
    public double CalculoArea(double radio)
    {
        return 3.14 * Math.Pow(radio, 2);
    }
}
