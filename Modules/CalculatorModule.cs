namespace CalculadoraCSharp.Modules;

public class CalculatorModule
{
    public double FirstValue { get; set; }
    public double SecondValue { get; set; }

    public void Continue()
    {
        Console.WriteLine("Aperte qualquer tecla para continuar");
        Console.ReadKey();
    }

    public void ShowResult(double result)
    {
        Console.WriteLine($"O resultado é {result}");
    }

    public void GetValues()
    {
        Console.Write("Primeiro valor: ");
        FirstValue = double.Parse(Console.ReadLine());

        Console.Write("Segundo valor: ");
        SecondValue = double.Parse(Console.ReadLine());
    }
}
