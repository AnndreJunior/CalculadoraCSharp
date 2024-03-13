namespace CalculadoraCSharp.Modules;

public class SubtractionModule : CalculatorModule
{
    public void Subtract()
    {
        Console.Clear();

        GetValues();

        ShowResult(FirstValue - SecondValue);

        Continue();
    }
}
