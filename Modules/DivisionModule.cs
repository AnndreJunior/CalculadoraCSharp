namespace CalculadoraCSharp.Modules;

public class DivisionModule : CalculatorModule
{
    public void Divide()
    {
        Console.Clear();

        GetValues();

        ShowResult(FirstValue / SecondValue);

        Continue();
    }
}
